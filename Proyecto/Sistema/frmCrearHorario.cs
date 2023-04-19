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
    public partial class frmCrearHorario : Form
    {
        public frmCrearHorario()
        {
            InitializeComponent();
        }

        DataTable tabla = new DataTable();
        private void frmCrearHorario_Load(object sender, EventArgs e)
        {

            List<Periodo> oListaPeriodo = CD_Periodo.Listar();
            if (oListaPeriodo != null)
            {
                foreach (Periodo row in oListaPeriodo.Where(x => x.Activo == true))
                {
                    cboperiodo.Items.Add(new ComboBoxItem() { Value = row.IdPeriodo, Text = row.Descripcion });
                }
                cboperiodo.DisplayMember = "Text";
                cboperiodo.ValueMember = "Value";


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

            cbodiasemana.Items.Add(new ComboBoxItem() { Value = "Lunes", Text = "Lunes" });
            cbodiasemana.Items.Add(new ComboBoxItem() { Value = "Martes", Text = "Martes" });
            cbodiasemana.Items.Add(new ComboBoxItem() { Value = "Miercoles", Text = "Miercoles" });
            cbodiasemana.Items.Add(new ComboBoxItem() { Value = "Jueves", Text = "Jueves" });
            cbodiasemana.Items.Add(new ComboBoxItem() { Value = "Viernes", Text = "Viernes" });
            cbodiasemana.Items.Add(new ComboBoxItem() { Value = "Sabado", Text = "Sabado" });
            cbodiasemana.Items.Add(new ComboBoxItem() { Value = "Domingo", Text = "Domingo" });
            cbodiasemana.DisplayMember = "Text";
            cbodiasemana.ValueMember = "Value";
            cbodiasemana.SelectedIndex = 0;

            txthorainicio.Value = DateTime.Now.Date;
            txthorafin.Value = DateTime.Now.Date;

        }

        private void CargarDatos()
        {
            cbocurso.Items.Clear();
            cbodiasemana.SelectedIndex = 0;
            txthorainicio.Value = DateTime.Now.Date;
            txthorafin.Value = DateTime.Now.Date;

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

            //PINTAMOS LOS ASIGNADOS EN EL LISTBOX
            cbocurso.Items.Add(new ComboBoxItem() { Value = 0, Text = "Seleccione curso"});
            if (oListaCursosAsignados.Count > 0)
            {
                foreach (Curso row in oListaCursosAsignados.Where(x => x.Activo == true))
                {
                    cbocurso.Items.Add(new ComboBoxItem() { Value = row.IdCurso, Text = row.Descripcion });
                }

                lblmin.Text = "(Min. " + oListaNivelDetalleCurso[0].oNivel.HoraInicio.ToString("H:mm:ss") + ")";
                lblmax.Text = "(Max. " +  oListaNivelDetalleCurso[0].oNivel.HoraFin.ToString("H:mm:ss") + ")";

                    /*
             row.HoraInicio.ToString("H:mm:ss"),
                        row.HoraFin.ToString("H:mm:ss"),        
             */
            }
            cbocurso.DisplayMember = "Text";
            cbocurso.ValueMember = "Value";
            cbocurso.SelectedIndex = 0;
            //btnGuardar.Enabled = true;



            //MOSTRAMOS TODOS LOS HORARIOS POR NIVEL Y GRADOSECCION
            List<Horario> oListaHorario = CD_Horario.Listar();
            if(oListaHorario != null)
            {
                tabla = new DataTable();
                tabla.Columns.Clear();
                tabla.Rows.Clear();
                cboFiltro.Items.Clear();
                dgvdata.DataSource = null;
                dgvdata.Columns.Clear();
                dgvdata.Rows.Clear();


                tabla.Columns.Add("IdHorario", typeof(int));
                tabla.Columns.Add("IdCurso", typeof(int));
                tabla.Columns.Add("Dia Semana", typeof(string));
                tabla.Columns.Add("Nombre Curso", typeof(string));
                tabla.Columns.Add("Hora Inicio", typeof(string));
                tabla.Columns.Add("Hora Fin", typeof(string));
                tabla.Columns.Add("Activo", typeof(bool));

                foreach (Horario row in oListaHorario.Where(x => x.oNivelDetalleCurso.oNivel.IdNivel == idnivel && x.oNivelDetalleCurso.oGradoSeccion.IdGradoSeccion == idgradoseccion))
                {
                    tabla.Rows.Add(
                        row.IdHorario,
                        row.oNivelDetalleCurso.oCurso.IdCurso,
                        row.DiaSemana,
                        row.oNivelDetalleCurso.oCurso.Descripcion,
                        row.HoraInicio.ToString("H:mm:ss"),
                        row.HoraFin.ToString("H:mm:ss"), row.Activo);
                }
                dgvdata.DataSource = tabla;

                dgvdata.Columns["IdHorario"].Visible = false;
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
                    if (cl.Visible == true)
                    {
                        cboFiltro.Items.Add(cl.HeaderText);
                    }
                }
                cboFiltro.SelectedIndex = 0;
            }


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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if(cboperiodo.Items.Count < 1 || cbonivel.Items.Count < 1 || cbogradoseccion.Items.Count < 1)
            {
                MessageBox.Show("No hay datos de busqueda", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (cbonivel.SelectedIndex ==  0 || cbogradoseccion.SelectedIndex == 0)
            {
                MessageBox.Show("Debe seleccionar todos los datos de busqueda", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            CargarDatos();
        }

        private void btnasignar_Click(object sender, EventArgs e)
        {
            if(cbocurso.Items.Count < 1)
            {
                MessageBox.Show("Debe realizar la busqueda primero", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            int idnivel = Convert.ToInt32(((ComboBoxItem)cbonivel.SelectedItem).Value);
            int idgradoseccion = Convert.ToInt32(((ComboBoxItem)cbogradoseccion.SelectedItem).Value);
            int idcurso = Convert.ToInt32(((ComboBoxItem)cbocurso.SelectedItem).Value);

            if(idcurso == 0)
            {
                MessageBox.Show("Seleccione un curso", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            bool encontrado = false;
            foreach (DataGridViewRow row in dgvdata.Rows)
            {
                if(Convert.ToInt32(row.Cells["IdCurso"].Value) == idcurso &&
                   Convert.ToString(row.Cells["Dia Semana"].Value) == ((ComboBoxItem)cbodiasemana.SelectedItem).Value.ToString())
                {
                    encontrado = true;
                    break;
                }
            }

            if (encontrado)
            {
                MessageBox.Show("Ya se encuentra registrado el curso y dia", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }



            Horario oHorario = new Horario()
            {
                oNivelDetalleCurso = new NivelDetalleCurso(){
                    oNivel = new Nivel() { IdNivel = idnivel},
                    oGradoSeccion = new GradoSeccion() { IdGradoSeccion = idgradoseccion},
                    oCurso = new Curso() { IdCurso = idcurso}
                },
                DiaSemana = ((ComboBoxItem)cbodiasemana.SelectedItem).Value.ToString(),
                HoraInicio = txthorainicio.Value,
                HoraFin = txthorafin.Value
            };

            bool resultado = CD_Horario.Registrar(oHorario);

            if (resultado) {
                MessageBox.Show("Registro correcto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarDatos();
                Restablecer();
            }
            else
            {
                MessageBox.Show("No se pudo registrar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


        }

        private void Restablecer()
        {
            //cboperiodo.SelectedIndex = 0;
            //cbonivel.SelectedIndex = 0;
            //cbogradoseccion.SelectedIndex = 0;

            //cbocurso.Items.Clear();
            cbocurso.SelectedIndex = 0;
            cbodiasemana.SelectedIndex = 0;
            txthorainicio.Value = DateTime.Now.Date;
            txthorafin.Value = DateTime.Now.Date;
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            string columnaFiltro = cboFiltro.SelectedItem.ToString();
            (dgvdata.DataSource as DataTable).DefaultView.RowFilter = string.Format("[" + columnaFiltro + "] like '%{0}%'", txtFilter.Text);
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
                        int idhorario = int.Parse(dgvdata.Rows[index].Cells["IdHorario"].Value.ToString());
                        bool Respuesta = CD_Horario.Eliminar(idhorario);

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

        
    }
}
