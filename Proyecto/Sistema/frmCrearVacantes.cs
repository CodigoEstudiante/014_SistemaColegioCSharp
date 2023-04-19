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
    public partial class frmCrearVacantes : Form
    {
        public frmCrearVacantes()
        {
            InitializeComponent();
        }

        DataTable tabla = new DataTable();
        private void frmCrearVacantes_Load(object sender, EventArgs e)
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
        }

        private void cargardatos()
        {
            if (cbonivel.Items.Count < 1 && cboperiodo.Items.Count < 1)
                return;


            int idnivel = Convert.ToInt32(((ComboBoxItem)cbonivel.SelectedItem).Value);
            if (idnivel == 0)
            {
                MessageBox.Show("Debe seleccionar un nivel academico", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            tabla = new DataTable();
            tabla.Columns.Clear();
            tabla.Rows.Clear();
            dgvdata.DataSource = tabla;

            List<NivelDetalle> oListaNivelDetalle = CD_NivelDetalle.Listar();

            if (oListaNivelDetalle != null)
            {
                oListaNivelDetalle = oListaNivelDetalle.Where(x => x.oNivel.IdNivel == idnivel).ToList();

            }


            if (oListaNivelDetalle.Count > 0)
            {
                tabla = new DataTable();
                tabla.Columns.Clear();
                tabla.Rows.Clear();

                tabla.Columns.Add("IdNivelDetalle", typeof(int)).ReadOnly = true;
                tabla.Columns.Add("IdNivel", typeof(int)).ReadOnly = true;
                tabla.Columns.Add("Descripcion Nivel", typeof(string)).ReadOnly = true;
                tabla.Columns.Add("Descripcion Turno", typeof(string)).ReadOnly = true;

                tabla.Columns.Add("IdGradoSeccion", typeof(string)).ReadOnly = true;
                tabla.Columns.Add("Descripcion Grado", typeof(string)).ReadOnly = true;
                tabla.Columns.Add("Descripcion Seccion", typeof(string)).ReadOnly = true;

                tabla.Columns.Add("Total Vacantes", typeof(string));

                
                //.DefaultCellStyle.ForeColor = Color.Gray;

                //tabla.Columns.Add("Estado", typeof(string));
                tabla.Columns.Add("Activo", typeof(bool));

                foreach (NivelDetalle row in oListaNivelDetalle)
                {
                    tabla.Rows.Add(row.IdNivelDetalle,
                        row.oNivel.IdNivel,
                        row.oNivel.DescripcionNivel,
                        row.oNivel.DescripcionTurno,
                        row.oGradoSeccion.IdGradoSeccion,
                        row.oGradoSeccion.DescripcionGrado,
                        row.oGradoSeccion.DescripcionSeccion,
                        row.TotalVacantes,
                        //row.Activo == true ? "Activo" : "No Activo", 
                        row.Activo);
                }

                dgvdata.DataSource = tabla;

                dgvdata.Columns["IdNivelDetalle"].Visible = false;
                dgvdata.Columns["IdNivel"].Visible = false;
                dgvdata.Columns["IdGradoSeccion"].Visible = false;
                dgvdata.Columns["Activo"].Visible = false;
                dgvdata.Columns["Total Vacantes"].DefaultCellStyle.BackColor = Color.LightYellow;

            }

            btnGuardar.Enabled = true;

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            cargardatos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            XElement DETALLE = new XElement("DETALLE");

            foreach (DataGridViewRow row in dgvdata.Rows)
            {
                DETALLE.Add(new XElement("DATA",
                    new XElement("IdNivelDetalle", row.Cells["IdNivelDetalle"].Value),
                    new XElement("TotalVacantes", row.Cells["Total Vacantes"].Value)
                    ));
            }


            bool resultado = CD_NivelDetalle.RegistrarVacantes(DETALLE.ToString());

            if (resultado)
            {
                MessageBox.Show("Se guardaron los cambios", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnGuardar.Enabled = false;
                tabla = new DataTable();
                tabla.Columns.Clear();
                tabla.Rows.Clear();
                dgvdata.DataSource = tabla;
                cbonivel.SelectedIndex = 0;
            }
            else
                MessageBox.Show("No se guardaron los cambios", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }
    }
}
