using CapaDatos;
using CapaModelo;
using Sistema.Reutilizable;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema
{
    public partial class frmAsignarDocente : Form
    {
        public frmAsignarDocente()
        {
            InitializeComponent();
        }
        DataTable tabla = new DataTable();
        private void frmAsignarDocente_Load(object sender, EventArgs e)
        {
            List<Periodo> oListaPeriodo = CD_Periodo.Listar();
            List<Docente> oListaDocente = CD_Docente.Listar();

            if (oListaPeriodo != null)
            {
                foreach (Periodo row in oListaPeriodo.Where(x => x.Activo == true))
                {
                    cboperiodo.Items.Add(new ComboBoxItem() { Value = row.IdPeriodo, Text = row.Descripcion });
                }
                cboperiodo.DisplayMember = "Text";
                cboperiodo.ValueMember = "Value";


            }

            cbodocente.Items.Add(new ComboBoxItem() { Value = 0, Text = "Seleccione docente" });
            if(oListaDocente != null)
            {
                foreach (Docente row in oListaDocente.Where(x => x.Activo == true))
                {
                    cbodocente.Items.Add(new ComboBoxItem() { Value = row.IdDocente, Text = row.Nombres + " " + row.Apellidos });
                }
                cbodocente.DisplayMember = "Text";
                cbodocente.ValueMember = "Value";
                cbodocente.SelectedIndex = 0;
            }


            if (cboperiodo.Items.Count > 0)
            {
                cboperiodo.SelectedIndex = 0;

                List<Nivel> oListaNivel = CD_Nivel.Listar();
                int idperiodo = Convert.ToInt32(((ComboBoxItem)cboperiodo.SelectedItem).Value);
                cbonivel.Items.Add(new ComboBoxItem() { Value = 0, Text = "Seleccione Nivel Academico" });

                if (oListaNivel != null)
                {
                    foreach (Nivel row in oListaNivel.Where(x => x.Activo == true && x.oPeriodo.IdPeriodo == idperiodo))
                    {
                        cbonivel.Items.Add(new ComboBoxItem() { Value = row.IdNivel, Text = row.DescripcionNivel });
                    }
                    cbonivel.DisplayMember = "Text";
                    cbonivel.ValueMember = "Value";
                    cbonivel.SelectedIndex = 0;

                }
            }

            if (cbonivel.Items.Count > 0)
            {
                cbonivel.SelectedIndex = 0;
                int idnivel = Convert.ToInt32(((ComboBoxItem)cbonivel.SelectedItem).Value);
                List<NivelDetalle> oListaNivelDetalle = CD_NivelDetalle.Listar();
                cbogradoseccion.Items.Add(new ComboBoxItem() { Value = 0, Text = "Seleccione Grado - Seccion" });

                if (oListaNivelDetalle != null)
                {
                    oListaNivelDetalle = oListaNivelDetalle.Where(x => x.oNivel.IdNivel == idnivel).ToList();


                    if (oListaNivelDetalle.Count > 0)
                    {
                        foreach (NivelDetalle row in oListaNivelDetalle.Where(x => x.Activo == true))
                        {
                            cbogradoseccion.Items.Add(new ComboBoxItem()
                            {
                                Value = row.oGradoSeccion.IdGradoSeccion,
                                Text = row.oGradoSeccion.DescripcionGrado + " - " + row.oGradoSeccion.DescripcionSeccion
                            });
                        }

                    }

                }

                cbogradoseccion.DisplayMember = "Text";
                cbogradoseccion.ValueMember = "Value";
                cbogradoseccion.SelectedIndex = 0;
            }



            
        }

        private void CargarDatos()
        {
            cbocurso.Items.Clear();

            //cbodocente.SelectedIndex = 0;

            if (cbonivel.Items.Count < 1 || cboperiodo.Items.Count < 1 || cbogradoseccion.Items.Count < 1)
                return;


            int idnivel = Convert.ToInt32(((ComboBoxItem)cbonivel.SelectedItem).Value);
            if (idnivel == 0)
            {
                MessageBox.Show("Debe seleccionar un nivel academico", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            int idgradoseccion = Convert.ToInt32(((ComboBoxItem)cbogradoseccion.SelectedItem).Value);
            if (idgradoseccion == 0)
            {
                MessageBox.Show("Debe seleccionar un grado - seccion", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            //OBTENEMOS DATA
            List<Curso> oListaCursosPorAsignar = new List<Curso>();
            List<Curso> oListaCursosAsignados = new List<Curso>();

            List<Curso> oListaCurso = CD_Curso.Listar();
            List<NivelDetalleCurso> oListaNivelDetalleCurso = CD_NivelDetalleCurso.Listar();

            //FILTRAMOS SEGUN NUESTRO PARAMETROS DE FILTRO
            if (oListaNivelDetalleCurso != null)
            {
                oListaNivelDetalleCurso = oListaNivelDetalleCurso.Where(x =>
                x.oNivel.IdNivel == idnivel &&
                x.oGradoSeccion.IdGradoSeccion == idgradoseccion).ToList();

            }

            //OBTENEMOS LOS POR ASIGNAR Y LOS ASIGNADOS
            if (oListaCurso != null && oListaNivelDetalleCurso != null)
            {
                oListaCursosAsignados = (from a in oListaCurso
                                         join b in oListaNivelDetalleCurso on a.IdCurso equals b.oCurso.IdCurso
                                         select a).ToList();


            }

            //PINTAMOS LOS ASIGNADOS EN EL COMBOBOX
            cbocurso.Items.Add(new ComboBoxItem() { Value = 0, Text = "Seleccione curso" });
            if (oListaCursosAsignados.Count > 0)
            {
                foreach (Curso row in oListaCursosAsignados.Where(x => x.Activo == true))
                {
                    cbocurso.Items.Add(new ComboBoxItem() { Value = row.IdCurso, Text = row.Descripcion });
                }
                
            }
            cbocurso.DisplayMember = "Text";
            cbocurso.ValueMember = "Value";
            cbocurso.SelectedIndex = 0;
            //btnGuardar.Enabled = true;

            CargarAsignado();

            
        }

        private void CargarAsignado()
        {
            int idnivel = Convert.ToInt32(((ComboBoxItem)cbonivel.SelectedItem).Value);
            int idgradoseccion = Convert.ToInt32(((ComboBoxItem)cbogradoseccion.SelectedItem).Value);
            //MOSTRAMOS TODOS LOS CURSOS ASIGNADOS POR NIVEL Y GRADOSECCION
            List<DocenteCurso> oListaDocenteCurso = CD_DocenteCurso.Listar();
            if(oListaDocenteCurso != null)
            {

                tabla = new DataTable();
                tabla.Columns.Clear();
                tabla.Rows.Clear();
                cboFiltro.Items.Clear();
                dgvdata.DataSource = null;
                dgvdata.Columns.Clear();
                dgvdata.Rows.Clear();


                tabla.Columns.Add("IdDocenteCurso", typeof(int));
                tabla.Columns.Add("IdDocente", typeof(int));
                tabla.Columns.Add("IdCurso", typeof(int));
                tabla.Columns.Add("Codigo Docente", typeof(string));
                tabla.Columns.Add("Docente", typeof(string));
                tabla.Columns.Add("Nivel Academico", typeof(string));
                tabla.Columns.Add("Grado - Seccion", typeof(string));
                tabla.Columns.Add("Curso", typeof(string));
                tabla.Columns.Add("Activo", typeof(bool));

                foreach (DocenteCurso row in oListaDocenteCurso.Where(x => x.oNivelDetalleCurso.oNivel.IdNivel == idnivel && x.oNivelDetalleCurso.oGradoSeccion.IdGradoSeccion == idgradoseccion))
                {
                    tabla.Rows.Add(
                        row.IdDocenteCurso,
                        row.oDocente.IdDocente,
                        row.oNivelDetalleCurso.oCurso.IdCurso,
                        row.oDocente.Codigo,
                        row.oDocente.Nombres + " " + row.oDocente.Apellidos,
                        row.oNivelDetalleCurso.oNivel.DescripcionNivel,
                        row.oNivelDetalleCurso.oGradoSeccion.DescripcionGrado + " " + row.oNivelDetalleCurso.oGradoSeccion.DescripcionSeccion,
                        row.oNivelDetalleCurso.oCurso.Descripcion,
                        row.Activo);
                }

                dgvdata.DataSource = tabla;

                dgvdata.Columns["IdDocenteCurso"].Visible = false;
                dgvdata.Columns["IdDocente"].Visible = false;
                dgvdata.Columns["IdCurso"].Visible = false;
                dgvdata.Columns["Activo"].Visible = false;

                //AGREGAR BOTON ELIMINAR
                DataGridViewButtonColumn BotonElimar = new DataGridViewButtonColumn();

                BotonElimar.HeaderText = "Eliminar";
                BotonElimar.Width = 50;
                BotonElimar.Text = "Eliminar";
                BotonElimar.Name = "btnEliminar";
                BotonElimar.FlatStyle = FlatStyle.Flat;
                BotonElimar.UseColumnTextForButtonValue = true;
                BotonElimar.CellTemplate.Style.BackColor = Color.Red;
                BotonElimar.CellTemplate.Style.ForeColor = Color.White;
                BotonElimar.CellTemplate.Style.SelectionBackColor = Color.Red;
                BotonElimar.CellTemplate.Style.SelectionForeColor = Color.White;

                //AGREGAMOS LOS BOTONES
                dgvdata.Columns.Add(BotonElimar);


                foreach (DataGridViewColumn cl in dgvdata.Columns)
                {
                    if (cl.Visible == true && cl.Name != "btnEliminar")
                    {
                        cboFiltro.Items.Add(cl.HeaderText);
                    }
                }
                cboFiltro.SelectedIndex = 0;
            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (cboperiodo.Items.Count < 1 || cbonivel.Items.Count < 1 || cbogradoseccion.Items.Count < 1)
            {
                MessageBox.Show("No hay datos de busqueda", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (cbonivel.SelectedIndex == 0 || cbogradoseccion.SelectedIndex == 0)
            {
                MessageBox.Show("Debe seleccionar todos los datos de busqueda", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            CargarDatos();
        }

        private void cbonivel_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cbogradoseccion.Items.Clear();

            int idnivel = Convert.ToInt32(((ComboBoxItem)cbonivel.SelectedItem).Value);
            List<NivelDetalle> oListaNivelDetalle = CD_NivelDetalle.Listar();
            cbogradoseccion.Items.Add(new ComboBoxItem() { Value = 0, Text = "Seleccione Grado - Seccion" });

            if (oListaNivelDetalle != null)
            {
                oListaNivelDetalle = oListaNivelDetalle.Where(x => x.oNivel.IdNivel == idnivel).ToList();


                if (oListaNivelDetalle.Count > 0)
                {
                    foreach (NivelDetalle row in oListaNivelDetalle.Where(x => x.Activo == true))
                    {
                        cbogradoseccion.Items.Add(new ComboBoxItem()
                        {
                            Value = row.oGradoSeccion.IdGradoSeccion,
                            Text = row.oGradoSeccion.DescripcionGrado + " - " + row.oGradoSeccion.DescripcionSeccion
                        });
                    }

                }

            }

            cbogradoseccion.DisplayMember = "Text";
            cbogradoseccion.ValueMember = "Value";
            cbogradoseccion.SelectedIndex = 0;
        }

        private void btnasignar_Click(object sender, EventArgs e)
        {
            int idnivel = Convert.ToInt32(((ComboBoxItem)cbonivel.SelectedItem).Value);
            int idgradoseccion = Convert.ToInt32(((ComboBoxItem)cbogradoseccion.SelectedItem).Value);


            if(cbodocente.Items.Count < 1 && cbocurso.Items.Count < 1)
            {
                MessageBox.Show("No existen datos para asignar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (cbodocente.SelectedIndex == 0 || cbocurso.SelectedIndex == 0)
            {
                MessageBox.Show("Seleccione datos para asignar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            int idcurso = Convert.ToInt32(((ComboBoxItem)cbocurso.SelectedItem).Value);
            int iddocente = Convert.ToInt32(((ComboBoxItem)cbodocente.SelectedItem).Value);

            bool encontrado = false;
            foreach (DataGridViewRow row in dgvdata.Rows)
            {
                if (Convert.ToInt32(row.Cells["IdCurso"].Value) == idcurso)
                {
                    encontrado = true;
                    break;
                }
            }

            if (encontrado)
            {
                MessageBox.Show("Ya se encuentra registrado el curso a un docente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            

            DocenteCurso oDocenteCurso = new DocenteCurso()
            {
                oNivelDetalleCurso = new NivelDetalleCurso()
                {
                    oNivel = new Nivel() { IdNivel = idnivel},
                    oGradoSeccion = new GradoSeccion() { IdGradoSeccion = idgradoseccion},
                    oCurso = new Curso() { IdCurso = idcurso}
                },
                oDocente = new Docente() { IdDocente = iddocente}
            };

            bool respuesta = CD_DocenteCurso.Registrar(oDocenteCurso);
            if (respuesta)
            {
                MessageBox.Show("Asignado correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarAsignado();
            }
            else
            {
                MessageBox.Show("No se pudo asignar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void dgvdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvdata.Columns[e.ColumnIndex].Name == "btnEliminar")
            {
                int index = e.RowIndex;
                if (index >= 0)
                {

                    if (MessageBox.Show("¿Desea eliminar el registro?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        int iddocentecurso = int.Parse(dgvdata.Rows[index].Cells["IdDocenteCurso"].Value.ToString());
                        bool Respuesta = CD_DocenteCurso.Eliminar(iddocentecurso);

                        if (Respuesta)
                        {
                            dgvdata.Rows.RemoveAt(index);
                        }
                        else
                        {
                            MessageBox.Show("No se pudo eliminar, revise su configuracion", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }

                    

                }
            }
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            string columnaFiltro = cboFiltro.SelectedItem.ToString();
            (dgvdata.DataSource as DataTable).DefaultView.RowFilter = string.Format("[" + columnaFiltro + "] like '%{0}%'", txtFilter.Text);
        }
    }
    
}
