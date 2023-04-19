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
    public partial class frmCrearPeriodo : Form
    {
        public frmCrearPeriodo()
        {
            InitializeComponent();
        }
        DataTable tabla = new DataTable();
        private void frmCrearPeriodo_Load(object sender, EventArgs e)
        {
            txtidperiodo.Text = "0";
            cboestado.Items.Add(new ComboBoxItem() { Value = true, Text = "Activo" });
            cboestado.Items.Add(new ComboBoxItem() { Value = false, Text = "No Activo" });
            cboestado.DisplayMember = "Text";
            cboestado.ValueMember = "Value";
            cboestado.SelectedIndex = 0;

            CargarDatos();
        }

        private void CargarDatos()
        {

            List<Periodo> oListaPeriodo = CD_Periodo.Listar();
            if (oListaPeriodo == null)
                return;

            if (oListaPeriodo.Count > 0)
            {
                tabla = new DataTable();
                tabla.Columns.Clear();
                tabla.Rows.Clear();
                cboFiltro.Items.Clear();

                lblTotalRegistros.Text = oListaPeriodo.Count.ToString();

                tabla.Columns.Add("IdPeriodo", typeof(int));
                tabla.Columns.Add("Descripcion", typeof(string));
                tabla.Columns.Add("Fecha Inicio", typeof(string));
                tabla.Columns.Add("Fecha Fin", typeof(string));
                tabla.Columns.Add("Estado", typeof(string));
                tabla.Columns.Add("Activo", typeof(bool));

                foreach (Periodo row in oListaPeriodo)
                {
                    tabla.Rows.Add(row.IdPeriodo, row.Descripcion, row.FechaInicio.Date.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture),
                         row.FechaFin.Date.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture), row.Activo == true ? "Activo" : "No Activo", row.Activo);
                }

                dgvdata.DataSource = tabla;

                dgvdata.Columns["IdPeriodo"].Visible = false;
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

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (dgvdata.SelectedRows.Count > 0)
            {
                DataGridViewRow currentRow = dgvdata.SelectedRows[0];
                int index = currentRow.Index;
                if (MessageBox.Show("¿Desea eliminar el Periodo  '" + dgvdata.Rows[index].Cells["Descripcion"].Value.ToString() + "'?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int idPeriodo = Convert.ToInt32(dgvdata.Rows[index].Cells["IdPeriodo"].Value.ToString());

                    bool respuesta = CD_Periodo.Eliminar(idPeriodo);
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

            txtidperiodo.Text = "0";
            txtdescripcion.Text = "";
            txtfechainicio.Value = DateTime.Now.Date;
            txtfechafin.Value = DateTime.Now.Date;
         
            cboestado.SelectedIndex = 0;
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            bool eseditar = Convert.ToInt32(txtidperiodo.Text) != 0 ? true : false;

            Periodo oPeriodo = new Periodo()
            {
                IdPeriodo = Convert.ToInt32(txtidperiodo.Text),
                Descripcion = txtdescripcion.Text,
                FechaInicio = txtfechainicio.Value,
                FechaFin = txtfechafin.Value,
                Activo = Convert.ToBoolean(((ComboBoxItem)cboestado.SelectedItem).Value)
            };

            bool respuesta = false;

            string msgOk = "";
            string msgError = "";

            if (eseditar)
            {
                respuesta = CD_Periodo.Editar(oPeriodo);
                msgOk = "Se guardaron los cambios";
                msgError = "No se pudo guardar los cambios, solo debe existir un periodo activo";

            }
            else
            {
                respuesta = CD_Periodo.Registrar(oPeriodo);
                msgOk = "Registro exitoso";
                msgError = "No se pudo registrar, solo debe existir un periodo activo";
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
            gbdatos.Enabled = true;

            btnnuevo.Visible = false;
            btnguardar.Visible = true;

            btnEditar.Visible = false;
            btncancelar.Visible = true;

            btneliminar.Visible = false;
            cboestado.Enabled = true;

            if (dgvdata.SelectedRows.Count > 0)
            {
                DataGridViewRow currentRow = dgvdata.SelectedRows[0];
                int index = currentRow.Index;


                txtidperiodo.Text = dgvdata.Rows[index].Cells["IdPeriodo"].Value.ToString();
                txtdescripcion.Text = dgvdata.Rows[index].Cells["Descripcion"].Value.ToString();
                txtfechainicio.Text = dgvdata.Rows[index].Cells["Fecha Inicio"].Value.ToString();
                txtfechafin.Text = dgvdata.Rows[index].Cells["Fecha Fin"].Value.ToString();

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
            }
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            string columnaFiltro = cboFiltro.SelectedItem.ToString();
            (dgvdata.DataSource as DataTable).DefaultView.RowFilter = string.Format("[" + columnaFiltro + "] like '%{0}%'", txtFilter.Text);
        }
    }
}
