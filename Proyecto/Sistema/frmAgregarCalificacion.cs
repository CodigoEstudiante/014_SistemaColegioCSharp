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
using System.Xml.Linq;

namespace Sistema
{
    public partial class frmAgregarCalificacion : Form
    {
        public frmAgregarCalificacion()
        {
            InitializeComponent();
        }
        List<Docente> oListaDocenteCurso = new List<Docente>();
        List<Docente> oListaDocenteCursoTemp = new List<Docente>();

        List<Nivel> oListaNivel = new List<Nivel>();
        List<GradoSeccion> oListaGradoSeccion = new List<GradoSeccion>();
        List<Curso> oListaCurso = new List<Curso>();
        DataTable tabla = new DataTable();

        private void frmAgregarCalificacion_Load(object sender, EventArgs e)
        {
            List<Periodo> oListaPeriodo = CD_Periodo.Listar();


            if (oListaPeriodo != null)
            {
                if (oListaPeriodo.Count > 0)
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

            if (oListaDocenteCurso.Count > 0)
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

            cbogradoseccion_SelectionChangeCommitted(cbogradoseccion, null);
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

            cboalumno.Items.Add(new ComboBoxItem() { Value = 0, Text = "Selecciona" });
            cboalumno.DisplayMember = "Text";
            cboalumno.ValueMember = "Value";
            cboalumno.SelectedIndex = 0;
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

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            cboalumno.Items.Clear();

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

            List<Matricula> oListaMatricula = CD_Matricula.Listar();

            oListaMatricula = oListaMatricula.Where(x => x.oNivelDetalle.oNivel.IdNivel == idnivel && x.oNivelDetalle.oGradoSeccion.IdGradoSeccion == idgradoseccion).ToList();

            //LISTAR ALUMNOS POR NIVEL Y GRADO
            cboalumno.Items.Add(new ComboBoxItem() { Value = 0, Text = "Selecciona" });
            if (oListaMatricula.Count > 0)
            {
                foreach (Matricula item in oListaMatricula) { cboalumno.Items.Add(new ComboBoxItem() { Value = item.oAlumno.IdAlumno , Text = item.oAlumno.Nombres + " " + item.oAlumno.Apellidos }); }
            }
            cboalumno.DisplayMember = "Text";
            cboalumno.ValueMember = "Value";
            cboalumno.SelectedIndex = 0;

            

        }

        private void btnvernotas_Click(object sender, EventArgs e)
        {


            int idnivel = Convert.ToInt32(((ComboBoxItem)cbonivel.SelectedItem).Value);
            int idgradoseccion = Convert.ToInt32(((ComboBoxItem)cbogradoseccion.SelectedItem).Value);
            int idcurso = Convert.ToInt32(((ComboBoxItem)cbocurso.SelectedItem).Value);
            int iddocente = Convert.ToInt32(((ComboBoxItem)cbodocente.SelectedItem).Value);
            int idalumno = Convert.ToInt32(((ComboBoxItem)cboalumno.SelectedItem).Value);

            if (cbonivel.Items.Count < 1 || cbogradoseccion.Items.Count < 1 || cbocurso.Items.Count < 1 || cbodocente.Items.Count < 1 || idalumno < 1)
            {
                MessageBox.Show("Faltan algunos datos para agregar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (idnivel == 0 || idgradoseccion == 0 || idcurso == 0 || iddocente == 0 || idalumno == 0)
            {
                MessageBox.Show("Seleccione todos los datos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            //LISTAMOS CURRICULA
            List<Curricula> oListaCurricula = CD_Currricula.Listar(idnivel, idgradoseccion, idcurso, iddocente);
            List<Calificacion> oListaCalificacion = CD_Calificacion.Listar(idnivel, idgradoseccion, idcurso, idalumno);

            List<Calificacion> oListaCalificacionTemp = new List<Calificacion>();


            foreach(Curricula cu in oListaCurricula)
            {
                bool encontrado = false;
                foreach(Calificacion ca in oListaCalificacion)
                {
                    if(cu.IdCurricula == ca.oCurricula.IdCurricula)
                    {
                        encontrado = true;
                        oListaCalificacionTemp.Add(new Calificacion()
                        {
                            oCurricula = new Curricula()
                            {
                                IdCurricula = ca.oCurricula.IdCurricula,
                                Descripcion = ca.oCurricula.Descripcion,
                            },
                            Nota = ca.Nota
                        });
                        break;
                    }
                }
                if (!encontrado)
                {
                    oListaCalificacionTemp.Add(new Calificacion()
                    {
                        oCurricula = new Curricula()
                        {
                            IdCurricula = cu.IdCurricula,
                            Descripcion = cu.Descripcion,
                        },
                        Nota = 0
                    });
                }

            }

            if (oListaCalificacionTemp.Count > 0)
            {
                tabla = new DataTable();
                tabla.Columns.Clear();
                tabla.Rows.Clear();

                dgvdata.DataSource = null;
                dgvdata.Columns.Clear();
                dgvdata.Rows.Clear();

                tabla.Columns.Add("IdCurricula", typeof(int)).ReadOnly = true;
                tabla.Columns.Add("Descripcion", typeof(string)).ReadOnly = true;
                tabla.Columns.Add("Nota", typeof(string));

                foreach (Calificacion row in oListaCalificacionTemp)
                {
                    tabla.Rows.Add(row.oCurricula.IdCurricula, row.oCurricula.Descripcion,row.Nota);
                };

                dgvdata.DataSource = tabla;

                dgvdata.Columns["IdCurricula"].Visible = false;
            }
            btnguardarcambios.Enabled = true;
        }

        private void btnguardarcambios_Click(object sender, EventArgs e)
        {
            XElement DETALLE = new XElement("DETALLE");
            int idalumno = Convert.ToInt32(((ComboBoxItem)cboalumno.SelectedItem).Value);
            foreach (DataGridViewRow row in dgvdata.Rows)
            {
                DETALLE.Add(new XElement("DATA",
                    new XElement("IdCurricula", row.Cells["IdCurricula"].Value),
                    new XElement("IdAlumno", idalumno),
                    new XElement("Nota", row.Cells["Nota"].Value)
                    ));
            }


            bool resultado = CD_Calificacion.Registrar(DETALLE.ToString());

            if (resultado)
            {
                MessageBox.Show("Se guardaron los cambios", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnguardarcambios.Enabled = false;
                tabla = new DataTable();
                tabla.Columns.Clear();
                tabla.Rows.Clear();
                dgvdata.DataSource = tabla;
                cboalumno.SelectedIndex = 0;
            }
            else
                MessageBox.Show("No se guardaron los cambios", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
