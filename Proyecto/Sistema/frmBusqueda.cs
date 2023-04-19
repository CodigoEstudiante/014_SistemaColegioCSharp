using CapaDatos;
using CapaModelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Sistema.Reutilizable.EnumModelo;

namespace Sistema
{
    public partial class frmBusqueda : Form
    {
        private DataTable tabla = new DataTable();
        private Modelo ModeloSeleccionado;
        public frmBusqueda(Modelo oModelo)
        {
            InitializeComponent();
            ModeloSeleccionado = oModelo;
            if (oModelo == Modelo.Docente)
            {
                BusquedaDocente();
            }
            else if (oModelo == Modelo.Alumno)
            {
                BusquedaAlumno();
            }
        }

        private void frmBusqueda_Load(object sender, EventArgs e)
        {

        }

        private void BusquedaAlumno()
        {
            List<Alumno> oListaAlumno = CD_Alumno.Listar();
            if (oListaAlumno != null)
            {

                if (oListaAlumno.Count > 0)
                {
                    tabla = new DataTable();
                    tabla.Columns.Clear();
                    tabla.Rows.Clear();
                    cboFiltro.Items.Clear();

                    lblTotalRegistros.Text = oListaAlumno.Count.ToString();

                    tabla.Columns.Add("IdAlumno", typeof(int));
                    tabla.Columns.Add("Codigo", typeof(string));
                    tabla.Columns.Add("Nombres", typeof(string));
                    tabla.Columns.Add("Apellidos", typeof(string));
                    tabla.Columns.Add("Documento Identidad", typeof(string));
                    tabla.Columns.Add("Fecha Nacimiento", typeof(string));
                    tabla.Columns.Add("Sexo", typeof(string));
                    tabla.Columns.Add("Ciudad", typeof(string));
                    tabla.Columns.Add("Direccion", typeof(string));

                    //AGREGAR BOTON SELECCIONAR
                    DataGridViewButtonColumn BotonSeleccionar = new DataGridViewButtonColumn();
                    BotonSeleccionar.HeaderText = "Seleccionar";
                    BotonSeleccionar.Text = "Seleccionar";
                    BotonSeleccionar.Width = 70;
                    BotonSeleccionar.Name = "btnSeleccionar";
                    BotonSeleccionar.FlatStyle = FlatStyle.Flat;
                    BotonSeleccionar.UseColumnTextForButtonValue = true;
                    BotonSeleccionar.CellTemplate.Style.BackColor = Color.DodgerBlue;
                    BotonSeleccionar.CellTemplate.Style.ForeColor = Color.White;
                    BotonSeleccionar.CellTemplate.Style.SelectionBackColor = Color.DodgerBlue;
                    BotonSeleccionar.CellTemplate.Style.SelectionForeColor = Color.White;
                    //AGREGAMOS EL BOTON
                    dgvdata.Columns.Add(BotonSeleccionar);

                    foreach (Alumno row in oListaAlumno)
                    {
                        tabla.Rows.Add(row.IdAlumno, row.Codigo, row.Nombres, row.Apellidos, row.DocumentoIdentidad,
                            row.FechaNacimiento.Date.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture),
                             row.Sexo, row.Ciudad, row.Direccion);
                    }

                    dgvdata.DataSource = tabla;

                    dgvdata.Columns["IdAlumno"].Visible = false;
                    dgvdata.Columns["Sexo"].Visible = false;
                    dgvdata.Columns["Ciudad"].Visible = false;
                    dgvdata.Columns["Direccion"].Visible = false;

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
            
        }

        private void BusquedaDocente()
        {
            List<Docente> oListaDocente = CD_Docente.Listar();
            if (oListaDocente != null)
            {

                if (oListaDocente.Count > 0)
                {
                    tabla = new DataTable();
                    tabla.Columns.Clear();
                    tabla.Rows.Clear();
                    cboFiltro.Items.Clear();

                    lblTotalRegistros.Text = oListaDocente.Count.ToString();

                    tabla.Columns.Add("IdDocente", typeof(int));
                    tabla.Columns.Add("Codigo", typeof(string));
                    tabla.Columns.Add("Documento Identidad", typeof(string));
                    tabla.Columns.Add("Nombres", typeof(string));
                    tabla.Columns.Add("Apellidos", typeof(string));
                    tabla.Columns.Add("Grado Estudio", typeof(string));
                   

                    //AGREGAR BOTON SELECCIONAR
                    DataGridViewButtonColumn BotonSeleccionar = new DataGridViewButtonColumn();
                    BotonSeleccionar.HeaderText = "Seleccionar";
                    BotonSeleccionar.Text = "Seleccionar";
                    BotonSeleccionar.Width = 70;
                    BotonSeleccionar.Name = "btnSeleccionar";
                    BotonSeleccionar.FlatStyle = FlatStyle.Flat;
                    BotonSeleccionar.UseColumnTextForButtonValue = true;
                    BotonSeleccionar.CellTemplate.Style.BackColor = Color.DodgerBlue;
                    BotonSeleccionar.CellTemplate.Style.ForeColor = Color.White;
                    BotonSeleccionar.CellTemplate.Style.SelectionBackColor = Color.DodgerBlue;
                    BotonSeleccionar.CellTemplate.Style.SelectionForeColor = Color.White;
                    //AGREGAMOS EL BOTON
                    dgvdata.Columns.Add(BotonSeleccionar);

                    foreach (Docente row in oListaDocente)
                    {
                        tabla.Rows.Add(row.IdDocente, row.Codigo, row.DocumentoIdentidad, row.Nombres, row.Apellidos,row.GradoEstudio);
                    }

                    dgvdata.DataSource = tabla;

                    dgvdata.Columns["IdDocente"].Visible = false;
             

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

        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            string columnaFiltro = cboFiltro.SelectedItem.ToString();
            (dgvdata.DataSource as DataTable).DefaultView.RowFilter = string.Format("[" + columnaFiltro + "] like '%{0}%'", txtFilter.Text);
        }

        private void dgvdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvdata.Columns[e.ColumnIndex].Name == "btnSeleccionar")
            {
                if (ModeloSeleccionado == Modelo.Alumno)
                {
                    Alumno oAlumno = new Alumno()
                    {
                        IdAlumno = Convert.ToInt32(dgvdata.Rows[e.RowIndex].Cells["IdAlumno"].Value.ToString()),
                        Codigo = dgvdata.Rows[e.RowIndex].Cells["Codigo"].Value.ToString(),
                        Nombres = dgvdata.Rows[e.RowIndex].Cells["Nombres"].Value.ToString(),
                        Apellidos = dgvdata.Rows[e.RowIndex].Cells["Apellidos"].Value.ToString(),
                        DocumentoIdentidad = dgvdata.Rows[e.RowIndex].Cells["Documento Identidad"].Value.ToString(),
                        FechaNacimiento = Convert.ToDateTime(dgvdata.Rows[e.RowIndex].Cells["Fecha Nacimiento"].Value.ToString()),
                        Sexo = dgvdata.Rows[e.RowIndex].Cells["Sexo"].Value.ToString(),
                        Ciudad = dgvdata.Rows[e.RowIndex].Cells["Ciudad"].Value.ToString(),
                        Direccion = dgvdata.Rows[e.RowIndex].Cells["Direccion"].Value.ToString()

                    };
                    frmRegistrarMatricula.oObjecto = oAlumno;
                    frmCrearUsuario.oObjecto = oAlumno;
                }else if (ModeloSeleccionado == Modelo.Docente)
                {
                    Docente oDocente = new Docente()
                    {
                        IdDocente = Convert.ToInt32(dgvdata.Rows[e.RowIndex].Cells["IdDocente"].Value.ToString()),
                        Codigo = dgvdata.Rows[e.RowIndex].Cells["Codigo"].Value.ToString(),
                        Nombres = dgvdata.Rows[e.RowIndex].Cells["Nombres"].Value.ToString(),
                        Apellidos = dgvdata.Rows[e.RowIndex].Cells["Apellidos"].Value.ToString(),
                        DocumentoIdentidad = dgvdata.Rows[e.RowIndex].Cells["Documento Identidad"].Value.ToString(),
                        Sexo = dgvdata.Rows[e.RowIndex].Cells["Grado Estudio"].Value.ToString()

                    };
                    frmRegistrarMatricula.oObjecto = oDocente;
                    frmCrearUsuario.oObjecto = oDocente;
                }
                this.Close();
            }
            
        }



    }
}
