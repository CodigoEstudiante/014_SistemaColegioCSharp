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
    public partial class frmAgregarCurricula : Form
    {
        public frmAgregarCurricula()
        {
            InitializeComponent();
        }
        List<Docente> oListaDocenteCurso = new List<Docente>();
        List<Docente> oListaDocenteCursoTemp = new List<Docente>();

        List<Nivel> oListaNivel = new List<Nivel>();
        List<GradoSeccion> oListaGradoSeccion = new List<GradoSeccion>();
        List<Curso> oListaCurso = new List<Curso>();
        DataTable tabla = new DataTable();
        private void frmAgregarCurricula_Load(object sender, EventArgs e)
        {
            
            List<Periodo> oListaPeriodo = CD_Periodo.Listar();


            if (oListaPeriodo != null)
            {
                if(oListaPeriodo.Count > 0)
                {
                    foreach (Periodo row in oListaPeriodo.Where(x => x.Activo == true))
                    {
                        cboperiodo.Items.Add(new ComboBoxItem() { Value = row.IdPeriodo, Text = row.Descripcion });
                    }
                    cboperiodo.DisplayMember = "Text";
                    cboperiodo.ValueMember = "Value";
                    cboperiodo.SelectedIndex = 0;
                }
            }


            oListaDocenteCurso = CD_DetalleDocenteCurso.DetalleDocenteCurso();

            if(oListaDocenteCurso.Count > 0)
            {
                foreach (Docente item in oListaDocenteCurso)
                {
                    cbodocente.Items.Add(new ComboBoxItem() { Value = item.IdDocente, Text = item.Nombres + " " + item.Apellidos });
                }
                cbodocente.DisplayMember = "Text";
                cbodocente.ValueMember = "Value";
                cbodocente.SelectedIndex = 0;

                if (Configuracion.oUsuario.DescripcionReferencia == "DOCENTE")
                {
                    foreach (ComboBoxItem item in cbodocente.Items)
                    {
                        if ((int)item.Value == Configuracion.oUsuario.IdReferencia)
                        {
                            int id = cbodocente.Items.IndexOf(item);
                            cbodocente.SelectedIndex = id;
                            break;
                        }
                    }
                    cbodocente.Enabled = false;
                }

                cbodocente.SelectedIndex = 0;

                oListaDocenteCursoTemp = oListaDocenteCurso.Where(x => x.IdDocente == int.Parse(((ComboBoxItem)cbodocente.SelectedItem).Value.ToString())).ToList();


                //LISTAR NIVEL ACADEMICO
                cbonivel.Items.Add(new ComboBoxItem() { Value = 0, Text = "Selecciona" });
                oListaNivel = (from lista in oListaDocenteCursoTemp from temp in lista.oListaNivel select temp).ToList();
                if (oListaNivel.Count > 0)
                {
                    foreach (Nivel item in oListaNivel)
                    {
                        cbonivel.Items.Add(new ComboBoxItem() { Value = item.IdNivel, Text = item.DescripcionNivel });
                    }
                }
                cbonivel.DisplayMember = "Text";
                cbonivel.ValueMember = "Value";
                cbonivel.SelectedIndex = 0;

                //LISTAR GRADOSECCION
                cbogradoseccion.Items.Add(new ComboBoxItem() { Value = 0, Text = "Selecciona" });
                oListaGradoSeccion = (from lista in oListaNivel
                                      where lista.IdNivel == int.Parse(((ComboBoxItem)cbonivel.SelectedItem).Value.ToString())
                                      from temp in lista.oListaGradoSeccion
                                      select temp).ToList();
                if (oListaGradoSeccion.Count > 0)
                {
                    foreach (GradoSeccion item in oListaGradoSeccion)
                    {
                        cbogradoseccion.Items.Add(new ComboBoxItem() { Value = item.IdGradoSeccion, Text = item.DescripcionGrado + " - " + item.DescripcionSeccion });
                    }
                }
                cbogradoseccion.DisplayMember = "Text";
                cbogradoseccion.ValueMember = "Value";
                cbogradoseccion.SelectedIndex = 0;

                //LISTAR CURSO
                cbocurso.Items.Add(new ComboBoxItem() { Value = 0, Text = "Selecciona" });
                oListaCurso = (from lista in oListaGradoSeccion
                               where lista.IdGradoSeccion == int.Parse(((ComboBoxItem)cbogradoseccion.SelectedItem).Value.ToString())
                               from temp in lista.oListaCurso
                               select temp).ToList();
                if (oListaCurso.Count > 0)
                {
                    foreach (Curso item in oListaCurso)
                    {
                        cbocurso.Items.Add(new ComboBoxItem() { Value = item.IdCurso, Text = item.Descripcion });
                    }
                }
                cbocurso.DisplayMember = "Text";
                cbocurso.ValueMember = "Value";
                cbocurso.SelectedIndex = 0;
            }

            

        }

        private void cbonivel_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cbogradoseccion.Items.Clear();

            //LISTAR GRADOSECCION
            cbogradoseccion.Items.Add(new ComboBoxItem() { Value = 0, Text = "Selecciona" });
            oListaGradoSeccion = (from lista in oListaNivel
                                  where lista.IdNivel == int.Parse(((ComboBoxItem)cbonivel.SelectedItem).Value.ToString())
                                  from temp in lista.oListaGradoSeccion
                                  select temp).ToList();
            if (oListaGradoSeccion.Count > 0)
            {
                foreach (GradoSeccion item in oListaGradoSeccion)
                {
                    cbogradoseccion.Items.Add(new ComboBoxItem() { Value = item.IdGradoSeccion, Text = item.DescripcionGrado + " - " + item.DescripcionSeccion });
                }
            }
            cbogradoseccion.DisplayMember = "Text";
            cbogradoseccion.ValueMember = "Value";
            cbogradoseccion.SelectedIndex = 0;

            cbogradoseccion_SelectionChangeCommitted(cbogradoseccion,null);
        }

        private void cbogradoseccion_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cbocurso.Items.Clear();

            //LISTAR CURSO
            cbocurso.Items.Add(new ComboBoxItem() { Value = 0, Text = "Selecciona" });
            oListaCurso = (from lista in oListaGradoSeccion
                           where lista.IdGradoSeccion == int.Parse(((ComboBoxItem)cbogradoseccion.SelectedItem).Value.ToString())
                           from temp in lista.oListaCurso
                           select temp).ToList();
            if (oListaCurso.Count > 0)
            {
                foreach (Curso item in oListaCurso)
                {
                    cbocurso.Items.Add(new ComboBoxItem() { Value = item.IdCurso, Text = item.Descripcion });
                }
            }
            cbocurso.DisplayMember = "Text";
            cbocurso.ValueMember = "Value";
            cbocurso.SelectedIndex = 0;
        }

        private void cbodocente_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cbonivel.Items.Clear();
            oListaDocenteCursoTemp = oListaDocenteCurso.Where(x => x.IdDocente == int.Parse(((ComboBoxItem)cbodocente.SelectedItem).Value.ToString())).ToList();


            //LISTAR NIVEL ACADEMICO
            cbonivel.Items.Add(new ComboBoxItem() { Value = 0, Text = "Selecciona" });
            oListaNivel = (from lista in oListaDocenteCursoTemp from temp in lista.oListaNivel select temp).ToList();
            if (oListaNivel.Count > 0)
            {
                foreach (Nivel item in oListaNivel)
                {
                    cbonivel.Items.Add(new ComboBoxItem() { Value = item.IdNivel, Text = item.DescripcionNivel });
                }
            }
            cbonivel.DisplayMember = "Text";
            cbonivel.ValueMember = "Value";
            cbonivel.SelectedIndex = 0;

            cbonivel_SelectionChangeCommitted(cbonivel, null);
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            int idnivel = Convert.ToInt32(((ComboBoxItem)cbonivel.SelectedItem).Value);
            int idgradoseccion = Convert.ToInt32(((ComboBoxItem)cbogradoseccion.SelectedItem).Value);
            int idcurso = Convert.ToInt32(((ComboBoxItem)cbocurso.SelectedItem).Value);
            int iddocente = Convert.ToInt32(((ComboBoxItem)cbodocente.SelectedItem).Value);

            if(cbonivel.Items.Count <1 || cbogradoseccion.Items.Count < 1 || cbocurso.Items.Count < 1 || cbodocente.Items.Count < 1)
            {
                MessageBox.Show("Faltan algunos datos para agregar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (idnivel == 0 || idgradoseccion== 0 || idcurso == 0 || iddocente == 0)
            {
                MessageBox.Show("Seleccione todos los datos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DocenteCurso oDocenteCurso = new DocenteCurso()
            {
                oNivelDetalleCurso = new NivelDetalleCurso()
                {
                    oNivel = new Nivel() { IdNivel = idnivel },
                    oGradoSeccion = new GradoSeccion() { IdGradoSeccion = idgradoseccion },
                    oCurso = new Curso() { IdCurso = idcurso }
                },
                oDocente = new Docente() { IdDocente = iddocente }
            };

            bool respuesta = CD_DetalleDocenteCurso.Registrar(oDocenteCurso, txtdescripcion.Text);
            if (respuesta)
            {
                MessageBox.Show("Agregado correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                obtenercurricula();
                txtdescripcion.Text = "";
            }
            else
            {
                MessageBox.Show("No se pudo agregar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void obtenercurricula()
        {
            int idnivel = Convert.ToInt32(((ComboBoxItem)cbonivel.SelectedItem).Value);
            int idgradoseccion = Convert.ToInt32(((ComboBoxItem)cbogradoseccion.SelectedItem).Value);
            int idcurso = Convert.ToInt32(((ComboBoxItem)cbocurso.SelectedItem).Value);
            int iddocente = Convert.ToInt32(((ComboBoxItem)cbodocente.SelectedItem).Value);
            List<Curricula> oListaCurricula = CD_Currricula.Listar(idnivel,idgradoseccion,idcurso,iddocente);

            if (oListaCurricula.Count > 0)
            {
                tabla = new DataTable();
                tabla.Columns.Clear();
                tabla.Rows.Clear();

                dgvdata.DataSource = null;
                dgvdata.Columns.Clear();
                dgvdata.Rows.Clear();

                tabla.Columns.Add("IdCurricula", typeof(int));
                tabla.Columns.Add("Descripcion", typeof(string));

                foreach (Curricula row in oListaCurricula)
                {
                    tabla.Rows.Add(row.IdCurricula, row.Descripcion);
                }

                dgvdata.DataSource = tabla;

                dgvdata.Columns["IdCurricula"].Visible = false;

                //AGREGAR BOTON ELIMINAR
                DataGridViewButtonColumn BotonElimar = new DataGridViewButtonColumn();

                BotonElimar.HeaderText = "Eliminar";
                BotonElimar.Width = 10;
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

                dgvdata.Columns["btnEliminar"].Width = 100;



            }
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            int idnivel = Convert.ToInt32(((ComboBoxItem)cbonivel.SelectedItem).Value);
            int idgradoseccion = Convert.ToInt32(((ComboBoxItem)cbogradoseccion.SelectedItem).Value);
            int idcurso = Convert.ToInt32(((ComboBoxItem)cbocurso.SelectedItem).Value);
            int iddocente = Convert.ToInt32(((ComboBoxItem)cbodocente.SelectedItem).Value);

            if (cbonivel.Items.Count < 1 || cbogradoseccion.Items.Count < 1 || cbocurso.Items.Count < 1 || cbodocente.Items.Count < 1)
            {
                MessageBox.Show("Faltan algunos datos para agregar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (idnivel == 0 || idgradoseccion == 0 || idcurso == 0 || iddocente == 0)
            {
                MessageBox.Show("Seleccione todos los datos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            obtenercurricula();
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
                        int IdCurricula = int.Parse(dgvdata.Rows[index].Cells["IdCurricula"].Value.ToString());
                        bool Respuesta = CD_Currricula.Eliminar(IdCurricula);

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
