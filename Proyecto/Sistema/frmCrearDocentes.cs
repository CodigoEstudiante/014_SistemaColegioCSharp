using CapaDatos;
using CapaModelo;
using Sistema.Reutilizable;
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

namespace Sistema
{
    public partial class frmCrearDocentes : Form
    {
        public frmCrearDocentes()
        {
            InitializeComponent();
        }
        DataTable tabla = new DataTable();
        private void frmCrearDocentes_Load(object sender, EventArgs e)
        {
            txtiddocente.Text = "0";
            cbosexo.Items.Add(new ComboBoxItem() { Value = "Masculino", Text = "Masculino" });
            cbosexo.Items.Add(new ComboBoxItem() { Value = "Femenino", Text = "Femenino" });
            cbosexo.DisplayMember = "Text";
            cbosexo.ValueMember = "Value";
            cbosexo.SelectedIndex = 0;

            cboestado.Items.Add(new ComboBoxItem() { Value = true, Text = "Activo" });
            cboestado.Items.Add(new ComboBoxItem() { Value = false, Text = "No Activo" });
            cboestado.DisplayMember = "Text";
            cboestado.ValueMember = "Value";
            cboestado.SelectedIndex = 0;

            CargarDatos();
        }

        private void CargarDatos()
        {

            List<Docente> oListaDocente = CD_Docente.Listar();
            if (oListaDocente == null)
                return;

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
                tabla.Columns.Add("Fecha Nacimiento", typeof(string));
                tabla.Columns.Add("Sexo", typeof(string));
                tabla.Columns.Add("Grado Estudio", typeof(string));
                tabla.Columns.Add("Ciudad", typeof(string));
                tabla.Columns.Add("Direccion", typeof(string));
                tabla.Columns.Add("Email", typeof(string));
                tabla.Columns.Add("Numero Telefono", typeof(string));
                tabla.Columns.Add("Estado", typeof(string));
                tabla.Columns.Add("Activo", typeof(bool));

                
                foreach (Docente row in oListaDocente)
                {
                    tabla.Rows.Add(row.IdDocente, row.Codigo, row.DocumentoIdentidad, row.Nombres, row.Apellidos,
                        row.FechaNacimiento.Date.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture),
                        row.Sexo, row.GradoEstudio, row.Ciudad, row.Direccion, row.Email,row.NumeroTelefono,
                        row.Activo == true ? "Activo" : "No Activo", row.Activo);
                }

                dgvdata.DataSource = tabla;

                dgvdata.Columns["IdDocente"].Visible = false;
                dgvdata.Columns["Activo"].Visible = false;

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

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            gbdatos.Enabled = true;

            btnnuevo.Visible = false;
            btnguardar.Visible = true;

            btnEditar.Visible = false;
            btncancelar.Visible = true;

            btneliminar.Visible = false;
            cboestado.Enabled = false;
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            bool eseditar = Convert.ToInt32(txtiddocente.Text) != 0 ? true : false;
            
            Docente oDocente = new Docente()
            {
                IdDocente = Convert.ToInt32(txtiddocente.Text),
                Codigo = txtcodigo.Text,
                DocumentoIdentidad = txtdocumentoidentidad.Text,
                Nombres = txtnombres.Text,
                Apellidos = txtapellidos.Text,
                FechaNacimiento = txtfechanacimiento.Value,
                Sexo = ((ComboBoxItem)cbosexo.SelectedItem).Value.ToString(),
                GradoEstudio = txtgradoestudio.Text,
                Ciudad = txtciudad.Text,
                Direccion = txtdireccion.Text,
                Email = txtemail.Text,
                NumeroTelefono = txtnumerotelefono.Text,
                Activo = Convert.ToBoolean(((ComboBoxItem)cboestado.SelectedItem).Value)
            };

            bool respuesta = false;

            string msgOk = "";
            string msgError = "";

            if (eseditar)
            {
                respuesta = CD_Docente.Editar(oDocente);
                msgOk = "Se guardaron los cambios";
                msgError = "No se pudo guardar los cambios";

            }
            else
            {
                respuesta = CD_Docente.Registrar(oDocente);
                msgOk = "Registro exitoso";
                msgError = "No se pudo registrar";
            }

            if (respuesta)
            {
                MessageBox.Show(msgOk, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Reestablecer();
                CargarDatos();
            }
            else
            {
                MessageBox.Show(msgError, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            
            if (dgvdata.SelectedRows.Count > 0)
            {
                DataGridViewRow currentRow = dgvdata.SelectedRows[0];
                int index = currentRow.Index;

                
                txtiddocente.Text = dgvdata.Rows[index].Cells["IdDocente"].Value.ToString();
                txtcodigo.Text = dgvdata.Rows[index].Cells["Codigo"].Value.ToString();
                txtdocumentoidentidad.Text = dgvdata.Rows[index].Cells["Documento Identidad"].Value.ToString();
                txtnombres.Text = dgvdata.Rows[index].Cells["Nombres"].Value.ToString();
                txtapellidos.Text = dgvdata.Rows[index].Cells["Apellidos"].Value.ToString();
                txtfechanacimiento.Value = Convert.ToDateTime(dgvdata.Rows[index].Cells["Fecha Nacimiento"].Value.ToString());

                foreach (ComboBoxItem item in cbosexo.Items)
                {
                    if ((string)item.Value == dgvdata.Rows[index].Cells["Sexo"].Value.ToString())
                    {
                        int id = cbosexo.Items.IndexOf(item);
                        cbosexo.SelectedIndex = id;
                        break;
                    }
                }

                txtgradoestudio.Text = dgvdata.Rows[index].Cells["Grado Estudio"].Value.ToString();
                txtciudad.Text = dgvdata.Rows[index].Cells["Ciudad"].Value.ToString();
                txtdireccion.Text = dgvdata.Rows[index].Cells["Direccion"].Value.ToString();
                txtemail.Text = dgvdata.Rows[index].Cells["Email"].Value.ToString();
                txtnumerotelefono.Text = dgvdata.Rows[index].Cells["Numero Telefono"].Value.ToString();

                foreach (ComboBoxItem item in cboestado.Items)
                {
                    if ((bool)item.Value == (bool)dgvdata.Rows[index].Cells["Activo"].Value)
                    {
                        int id = cboestado.Items.IndexOf(item);
                        cboestado.SelectedIndex = id;
                        break;
                    }
                }


            }
            else
            {
                MessageBox.Show("Selecciona un registro de la lista", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            gbdatos.Enabled = true;

            btnnuevo.Visible = false;
            btnguardar.Visible = true;

            btnEditar.Visible = false;
            btncancelar.Visible = true;

            btneliminar.Visible = false;
            cboestado.Enabled = true;

        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            gbdatos.Enabled = false;

            btnnuevo.Visible = true;
            btnguardar.Visible = false;

            btnEditar.Visible = true;
            btncancelar.Visible = false;

            btneliminar.Visible = true;
            Reestablecer();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (dgvdata.SelectedRows.Count > 0)
            {
                DataGridViewRow currentRow = dgvdata.SelectedRows[0];
                int index = currentRow.Index;
                if (MessageBox.Show("¿Desea eliminar el Docente con codigo " + dgvdata.Rows[index].Cells["Codigo"].Value.ToString() + "?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int idDocente = Convert.ToInt32(dgvdata.Rows[index].Cells["IdDocente"].Value.ToString());

                    bool respuesta = CD_Docente.Eliminar(idDocente);
                    if (respuesta)
                    {
                        MessageBox.Show("Eliminado correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarDatos();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }

            }
            else
            {
                MessageBox.Show("Selecciona un registro de la lista", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            string columnaFiltro = cboFiltro.SelectedItem.ToString();
            (dgvdata.DataSource as DataTable).DefaultView.RowFilter = string.Format("[" + columnaFiltro + "] like '%{0}%'", txtFilter.Text);
        }

        private void Reestablecer()
        {
            gbdatos.Enabled = false;

            btnnuevo.Visible = true;
            btnguardar.Visible = false;

            btnEditar.Visible = true;
            btncancelar.Visible = false;

            btneliminar.Visible = true;
            
            txtiddocente.Text = "0";
            txtcodigo.Text = "";
            txtdocumentoidentidad.Text = "";
            txtnombres.Text = "";
            txtapellidos.Text = "";
            txtfechanacimiento.Value = DateTime.Now.Date;
            cbosexo.SelectedIndex = 0;
            txtgradoestudio.Text = "";
            txtciudad.Text = "";
            txtdireccion.Text = "";
            txtemail.Text = "";
            txtnumerotelefono.Text = "";
            cboestado.SelectedIndex = 0;
        }
    }
}
