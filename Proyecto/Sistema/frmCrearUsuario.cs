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
using static Sistema.Reutilizable.EnumModelo;

namespace Sistema
{
    public partial class frmCrearUsuario : Form
    {
        public frmCrearUsuario()
        {
            InitializeComponent();
        }
        public static object oObjecto;
        DataTable tabla = new DataTable();
        private void frmCrearUsuario_Load(object sender, EventArgs e)
        {
            txtidreferencia.Text = "0";
            txtidusuario.Text = "0";
            cboreferencia.Items.Add(new ComboBoxItem() { Value = "NINGUNA", Text = "NINGUNA" });
            cboreferencia.Items.Add(new ComboBoxItem() { Value = "ALUMNO", Text = "ALUMNO" });
            cboreferencia.Items.Add(new ComboBoxItem() { Value = "DOCENTE", Text = "DOCENTE" });
            cboreferencia.DisplayMember = "Text";
            cboreferencia.ValueMember = "Value";
            cboreferencia.SelectedIndex = 0;

            cboestado.Items.Add(new ComboBoxItem() { Value = true, Text = "Activo" });
            cboestado.Items.Add(new ComboBoxItem() { Value = false, Text = "No Activo" });
            cboestado.DisplayMember = "Text";
            cboestado.ValueMember = "Value";
            cboestado.SelectedIndex = 0;

            List<Rol> oListaRol = CD_Rol.Listar();

            cborol.Items.Add(new ComboBoxItem() { Value = 0, Text = "Seleccione Rol" });
            foreach (Rol row in oListaRol.Where(x => x.Activo == true))
            {
                cborol.Items.Add(new ComboBoxItem() { Value = row.IdRol, Text = row.Descripcion });
            }
            cborol.DisplayMember = "Text";
            cborol.ValueMember = "Value";
            cborol.SelectedIndex = 0;
            CargarDatos();
        }

        private void CargarDatos()
        {

            List<Usuario> oListaUsuario = CD_Usuario.ObtenerUsuarios();
            if (oListaUsuario == null)
                return;

            if (oListaUsuario.Count > 0)
            {
                tabla = new DataTable();
                tabla.Columns.Clear();
                tabla.Rows.Clear();
                cboFiltro.Items.Clear();

                lblTotalRegistros.Text = oListaUsuario.Count.ToString();

                tabla.Columns.Add("IdUsuario", typeof(int));
                tabla.Columns.Add("Nombres", typeof(string));
                tabla.Columns.Add("Apellidos", typeof(string));
                tabla.Columns.Add("Usuario", typeof(string));
                tabla.Columns.Add("Contraseña", typeof(string));
                tabla.Columns.Add("IdRol", typeof(int));
                tabla.Columns.Add("Rol", typeof(string));
                tabla.Columns.Add("DescripcionReferencia", typeof(string));
                tabla.Columns.Add("Estado", typeof(string));
                tabla.Columns.Add("Activo", typeof(bool));

                foreach (Usuario row in oListaUsuario)
                {
                    tabla.Rows.Add(row.IdUsuario,row.Nombres, row.Apellidos, row.LoginUsuario,row.Clave,row.IdRol,row.oRol.Descripcion,
                        row.DescripcionReferencia, row.Activo == true ? "Activo" : "No Activo", row.Activo);
                }

                dgvdata.DataSource = tabla;

                dgvdata.Columns["IdUsuario"].Visible = false;
                dgvdata.Columns["IdRol"].Visible = false;
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

        private void btnver_Click(object sender, EventArgs e)
        {
            oObjecto = null;
            frmBusqueda frm = new frmBusqueda(Modelo.Ninguno);
            if (((ComboBoxItem)cboreferencia.SelectedItem).Text == "NINGUNA")
            {
                return;
            }
            else if (((ComboBoxItem)cboreferencia.SelectedItem).Text == "ALUMNO")
            {
                frm = new frmBusqueda(Modelo.Alumno);
            }
            else if (((ComboBoxItem)cboreferencia.SelectedItem).Text == "DOCENTE")
            {
                frm = new frmBusqueda(Modelo.Docente);
            }

            frm.ShowDialog();


            if (oObjecto != null)
            {
                var t = oObjecto.GetType();

                if (t.Name == "Docente") {
                    Docente oDocente = (Docente)oObjecto;
                    if (oDocente != null)
                    {
                        txtnombres.Text = oDocente.Nombres;
                        txtapellidos.Text = oDocente.Apellidos;
                    }

                }
                else if (t.Name == "Alumno")
                {
                    Alumno oAlumno = (Alumno)oObjecto;
                    if (oAlumno != null)
                    {
                        txtnombres.Text = oAlumno.Nombres;
                        txtapellidos.Text = oAlumno.Apellidos;
                    }
                }

                txtnombres.Enabled = false;
                txtapellidos.Enabled = false;
               
            }
        }

        private void cboreferencia_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txtidreferencia.Text = "0";
            txtnombres.Text = "";
            txtapellidos.Text = "";
            
            
            txtnombres.Enabled = true;
            txtapellidos.Enabled = true;
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
            bool eseditar = Convert.ToInt32(txtidusuario.Text) != 0 ? true : false;

            Usuario oUsuario = new Usuario()
            {
                IdUsuario = Convert.ToInt32(txtidusuario.Text),
                Nombres = txtnombres.Text,
                Apellidos = txtapellidos.Text,
                IdRol = int.Parse(((ComboBoxItem)cborol.SelectedItem).Value.ToString()),
                LoginUsuario = txtusuario.Text,
                Clave = txtcontrasenia.Text,
                DescripcionReferencia = ((ComboBoxItem)cboreferencia.SelectedItem).Value.ToString(),
                IdReferencia = int.Parse( txtidreferencia.Text),
                Activo = Convert.ToBoolean(((ComboBoxItem)cboestado.SelectedItem).Value)
            };

            bool respuesta = false;

            string msgOk = "";
            string msgError = "";

            if (eseditar)
            {
                respuesta = CD_Usuario.ModificarUsuario(oUsuario);
                msgOk = "Se guardaron los cambios";
                msgError = "No se pudo guardar los cambios";

            }
            else
            {
                respuesta = CD_Usuario.RegistrarUsuario(oUsuario);
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


                txtidusuario.Text = dgvdata.Rows[index].Cells["IdUsuario"].Value.ToString();
                txtnombres.Text = dgvdata.Rows[index].Cells["Nombres"].Value.ToString();
                txtapellidos.Text = dgvdata.Rows[index].Cells["Apellidos"].Value.ToString();
                txtusuario.Text = dgvdata.Rows[index].Cells["Usuario"].Value.ToString();
                txtcontrasenia.Text = dgvdata.Rows[index].Cells["Contraseña"].Value.ToString();
                

                foreach (ComboBoxItem item in cboreferencia.Items)
                {
                    if ((string)item.Value == dgvdata.Rows[index].Cells["DescripcionReferencia"].Value.ToString())
                    {
                        int id = cboreferencia.Items.IndexOf(item);
                        cboreferencia.SelectedIndex = id;
                        break;
                    }
                }

                foreach (ComboBoxItem item in cborol.Items)
                {
                    if ((int)item.Value == (int)dgvdata.Rows[index].Cells["IdRol"].Value)
                    {
                        int id = cborol.Items.IndexOf(item);
                        cborol.SelectedIndex = id;
                        break;
                    }
                }

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

        private void Reestablecer()
        {
            gbdatos.Enabled = false;

            btnnuevo.Visible = true;
            btnguardar.Visible = false;

            btnEditar.Visible = true;
            btncancelar.Visible = false;

            btneliminar.Visible = true;

            txtidusuario.Text = "0";
            txtidreferencia.Text = "0";
            txtnombres.Text = "";
            txtapellidos.Text = "";
            txtusuario.Text = "";
            txtcontrasenia.Text = "";
            cboreferencia.SelectedIndex = 0;
            cborol.SelectedIndex = 0;
            cboestado.SelectedIndex = 0;
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (dgvdata.SelectedRows.Count > 0)
            {
                DataGridViewRow currentRow = dgvdata.SelectedRows[0];
                int index = currentRow.Index;
                if (MessageBox.Show("¿Desea eliminar el usuario " + dgvdata.Rows[index].Cells["Usuario"].Value.ToString() + "?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int idusuario = Convert.ToInt32(dgvdata.Rows[index].Cells["IdUsuario"].Value.ToString());

                    bool respuesta = CD_Usuario.EliminarUsuario(idusuario);
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
    }
}
