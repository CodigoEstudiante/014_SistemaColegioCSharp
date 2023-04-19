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
    public partial class frmCrearNivel : Form
    {
        public frmCrearNivel()
        {
            InitializeComponent();
        }
        DataTable tabla = new DataTable();
        private void frmCrearNivel_Load(object sender, EventArgs e)
        {
            txthorainicio.Value = DateTime.Now.Date;
            txthorafin.Value = DateTime.Now.Date;

            txtidnivel.Text = "0";
            cboestado.Items.Add(new ComboBoxItem() { Value = true, Text = "Activo" });
            cboestado.Items.Add(new ComboBoxItem() { Value = false, Text = "No Activo" });
            cboestado.DisplayMember = "Text";
            cboestado.ValueMember = "Value";
            cboestado.SelectedIndex = 0;


            List<Periodo> oListaPeriodo = CD_Periodo.Listar();

            cboperiodo.Items.Add(new ComboBoxItem() { Value = 0, Text = "Seleccione un periodo" });
            foreach (Periodo row in oListaPeriodo.Where(x => x.Activo == true))
            {
                cboperiodo.Items.Add(new ComboBoxItem() { Value = row.IdPeriodo, Text = row.Descripcion });
            }
            cboperiodo.DisplayMember = "Text";
            cboperiodo.ValueMember = "Value";
            cboperiodo.SelectedIndex = 0;

            CargarDatos();
        }

        private void CargarDatos()
        {

            List<Nivel> oListaNivel = CD_Nivel.Listar();
            if (oListaNivel == null)
                return;

            if (oListaNivel.Count > 0)
            {
                tabla = new DataTable();
                tabla.Columns.Clear();
                tabla.Rows.Clear();
                cboFiltro.Items.Clear();

                lblTotalRegistros.Text = oListaNivel.Count.ToString();

                tabla.Columns.Add("IdNivel", typeof(int));
                tabla.Columns.Add("IdPeriodo", typeof(int));
                tabla.Columns.Add("Descripcion Periodo", typeof(string));
                tabla.Columns.Add("Descripcion Nivel", typeof(string));
                tabla.Columns.Add("Descripcion Turno", typeof(string));
                tabla.Columns.Add("Hora Inicio", typeof(string));
                tabla.Columns.Add("Hora Fin", typeof(string));
                tabla.Columns.Add("Estado", typeof(string));
                tabla.Columns.Add("Activo", typeof(bool));

                foreach (Nivel row in oListaNivel)
                {
                    tabla.Rows.Add(row.IdNivel, row.oPeriodo.IdPeriodo,row.oPeriodo.Descripcion,
                        row.DescripcionNivel,row.DescripcionTurno,
                        row.HoraInicio.ToString("H:mm:ss"),
                        row.HoraFin.ToString("H:mm:ss"),
                        row.Activo == true ? "Activo" : "No Activo", row.Activo);
                }

                dgvdata.DataSource = tabla;

                dgvdata.Columns["IdNivel"].Visible = false;
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

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if(Convert.ToInt32(((ComboBoxItem)cboperiodo.SelectedItem).Value) ==0)
            {
                MessageBox.Show("Debe seleccionar un periodo correcto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            bool eseditar = Convert.ToInt32(txtidnivel.Text) != 0 ? true : false;

            Nivel oNivel = new Nivel()
            {
                IdNivel = Convert.ToInt32(txtidnivel.Text),
                oPeriodo = new Periodo()
                {
                    IdPeriodo = Convert.ToInt32(((ComboBoxItem)cboperiodo.SelectedItem).Value)
                },
                DescripcionNivel = txtdescripcionnivel.Text,
                DescripcionTurno = txtdescripcionturno.Text,
                HoraInicio = txthorainicio.Value,
                HoraFin = txthorafin.Value,
                Activo = Convert.ToBoolean(((ComboBoxItem)cboestado.SelectedItem).Value)
            };

            bool respuesta = false;

            string msgOk = "";
            string msgError = "";

            if (eseditar)
            {
                respuesta = CD_Nivel.Editar(oNivel);
                msgOk = "Se guardaron los cambios";
                msgError = "No se pudo guardar los cambios, solo debe existir un Nivel activo";

            }
            else
            {
                respuesta = CD_Nivel.Registrar(oNivel);
                msgOk = "Registro exitoso";
                msgError = "No se pudo registrar, solo debe existir un Nivel activo";
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

                txtidnivel.Text = dgvdata.Rows[index].Cells["IdNivel"].Value.ToString();

                foreach (ComboBoxItem item in cboperiodo.Items)
                {
                    if (Convert.ToInt32(item.Value) == Convert.ToInt32(dgvdata.Rows[index].Cells["IdPeriodo"].Value))
                    {
                        int id = cboperiodo.Items.IndexOf(item);
                        cboperiodo.SelectedIndex = id;
                        break;
                    }
                }

                txtdescripcionnivel.Text = dgvdata.Rows[index].Cells["Descripcion Nivel"].Value.ToString();
                txtdescripcionturno.Text = dgvdata.Rows[index].Cells["Descripcion Turno"].Value.ToString();
                txthorainicio.Text = dgvdata.Rows[index].Cells["Hora Inicio"].Value.ToString();
                txthorafin.Text = dgvdata.Rows[index].Cells["Hora Fin"].Value.ToString();

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
                if (MessageBox.Show("¿Desea eliminar el Nivel  '" + dgvdata.Rows[index].Cells["Descripcion Nivel"].Value.ToString() + "'?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int idNivel = Convert.ToInt32(dgvdata.Rows[index].Cells["IdNivel"].Value.ToString());

                    bool respuesta = CD_Nivel.Eliminar(idNivel);
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

        private void Reestablecer()
        {
            gbdatos.Enabled = false;

            btnnuevo.Visible = true;
            btnguardar.Visible = false;

            btnEditar.Visible = true;
            btncancelar.Visible = false;

            btneliminar.Visible = true;

            txtidnivel.Text = "0";
            cboperiodo.SelectedIndex = 0;

            txtdescripcionnivel.Text = "";
            txtdescripcionturno.Text = "";
            txthorainicio.Value = DateTime.Now.Date;
            txthorafin.Value = DateTime.Now.Date;

            cboestado.SelectedIndex = 0;
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            string columnaFiltro = cboFiltro.SelectedItem.ToString();
            (dgvdata.DataSource as DataTable).DefaultView.RowFilter = string.Format("["+columnaFiltro + "] like '%{0}%'", txtFilter.Text);
        }
    }
}
