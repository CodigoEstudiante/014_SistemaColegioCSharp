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
using System.Xml.Linq;
using static Sistema.Reutilizable.EnumModelo;

namespace Sistema
{
    public partial class frmRegistrarMatricula : Form
    {
        public frmRegistrarMatricula()
        {
            InitializeComponent();
        }
        public static object oObjecto;

        public int Pidperiodo;
        public int Pidnivel;
        public int Pidgradosseccion;
        public string Pdescripcionnivel;
        public string Pdescripciongradoseccion;

        private void frmRegistrarMatricula_Load(object sender, EventArgs e)
        {
            txtfechanacimiento_alu.Value = Convert.ToDateTime("01/01/1990", new CultureInfo("es-ES"));
            txtfechanacimiento_apo.Value = Convert.ToDateTime("01/01/1990", new CultureInfo("es-ES"));
            txtidalumno.Text = "0";
            txtnivelacademico.Text = Pdescripcionnivel;
            txtgradoseccion.Text = Pdescripciongradoseccion;


            cbosituacion.Items.Add(new ComboBoxItem() { Value = "Nuevo", Text = "Nuevo" });
            cbosituacion.Items.Add(new ComboBoxItem() { Value = "Antiguo", Text = "Antiguo" });
            cbosituacion.DisplayMember = "Text";
            cbosituacion.ValueMember = "Value";
            cbosituacion.SelectedIndex = 0;

            cboesrepitente.Items.Add(new ComboBoxItem() { Value = "NO", Text = "NO" });
            cboesrepitente.Items.Add(new ComboBoxItem() { Value = "SI", Text = "SI" });
            cboesrepitente.DisplayMember = "Text";
            cboesrepitente.ValueMember = "Value";
            cboesrepitente.SelectedIndex = 0;

            cbosexo_alu.Items.Add(new ComboBoxItem() { Value = "Masculino", Text = "Masculino" });
            cbosexo_alu.Items.Add(new ComboBoxItem() { Value = "Femenino", Text = "Femenino" });
            cbosexo_alu.DisplayMember = "Text";
            cbosexo_alu.ValueMember = "Value";
            cbosexo_alu.SelectedIndex = 0;

            cbosexo_apo.Items.Add(new ComboBoxItem() { Value = "Masculino", Text = "Masculino" });
            cbosexo_apo.Items.Add(new ComboBoxItem() { Value = "Femenino", Text = "Femenino" });
            cbosexo_apo.DisplayMember = "Text";
            cbosexo_apo.ValueMember = "Value";
            cbosexo_apo.SelectedIndex = 0;

            cbotiporelacion_apo.Items.Add(new ComboBoxItem() { Value = "Madre", Text = "Madre" });
            cbotiporelacion_apo.Items.Add(new ComboBoxItem() { Value = "Padre", Text = "Padre" });
            cbotiporelacion_apo.Items.Add(new ComboBoxItem() { Value = "Tio", Text = "Tio" });
            cbotiporelacion_apo.Items.Add(new ComboBoxItem() { Value = "Tia", Text = "Tia" });
            cbotiporelacion_apo.Items.Add(new ComboBoxItem() { Value = "Abuelo", Text = "Abuelo" });
            cbotiporelacion_apo.Items.Add(new ComboBoxItem() { Value = "Abuela", Text = "Abuela" });
            cbotiporelacion_apo.DisplayMember = "Text";
            cbotiporelacion_apo.ValueMember = "Value";
            cbotiporelacion_apo.SelectedIndex = 0;

            cboestadocivil_apo.Items.Add(new ComboBoxItem() { Value = "Casado(a)", Text = "Casado(a)" });
            cboestadocivil_apo.Items.Add(new ComboBoxItem() { Value = "Divorciado(a)", Text = "Divorciado(a)" });
            cboestadocivil_apo.Items.Add(new ComboBoxItem() { Value = "Soltero(a)", Text = "Soltero(a)" });
            cboestadocivil_apo.DisplayMember = "Text";
            cboestadocivil_apo.ValueMember = "Value";
            cboestadocivil_apo.SelectedIndex = 0;

        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            if (btnbuscar.Cursor == Cursors.No)
                return;

            oObjecto = null;
            frmBusqueda frm = new frmBusqueda(Modelo.Alumno);
            frm.ShowDialog();

            if (oObjecto != null)
            {
                Alumno oAlumno = (Alumno)oObjecto;
                if (oAlumno != null)
                {
                    txtidalumno.Text = oAlumno.IdAlumno.ToString();
                    txtdocumentoidentidad_alu.Text = oAlumno.DocumentoIdentidad;
                    txtnombres_alu.Text = oAlumno.Nombres;
                    txtapellidos_alu.Text = oAlumno.Apellidos;
                    txtfechanacimiento_alu.Value = oAlumno.FechaNacimiento;

                    foreach (ComboBoxItem item in cbosexo_alu.Items)
                    {
                        if ((string)item.Value == oAlumno.Sexo)
                        {
                            int id = cbosexo_alu.Items.IndexOf(item);
                            cbosexo_alu.SelectedIndex = id;
                            break;
                        }
                    }
                    txtciudad_alu.Text = oAlumno.Ciudad;
                    txtdireccion_alu.Text = oAlumno.Direccion;

                    txtdocumentoidentidad_alu.Enabled = false;
                    txtnombres_alu.Enabled = false;
                    txtapellidos_alu.Enabled = false;
                    txtfechanacimiento_alu.Enabled = false;
                    cbosexo_alu.Enabled = false;
                    txtciudad_alu.Enabled = false;
                    txtdireccion_alu.Enabled = false;
                }
            }
        }

        private void cbosituacion_SelectionChangeCommitted(object sender, EventArgs e)
        {
           if( ((ComboBoxItem)cbosituacion.SelectedItem).Value.ToString() == "Antiguo")
            {
                btnbuscar.BackColor = Color.DodgerBlue;
                btnlimpiar.BackColor = Color.DodgerBlue;
                btnbuscar.Cursor = Cursors.Hand;
                btnlimpiar.Cursor = Cursors.Hand;
            }
            else
            {
                btnbuscar.BackColor = Color.LightGray;
                btnlimpiar.BackColor = Color.LightGray;
                btnbuscar.Cursor = Cursors.No;
                btnlimpiar.Cursor = Cursors.No;
            }
            limpiardata();
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            if (btnlimpiar.Cursor == Cursors.No)
                return;

            limpiardata();


        }

        private void limpiardata()
        {
            txtidalumno.Text = "0";
            txtdocumentoidentidad_alu.Enabled = true;
            txtnombres_alu.Enabled = true;
            txtapellidos_alu.Enabled = true;
            txtfechanacimiento_alu.Enabled = true;
            cbosexo_alu.Enabled = true;
            txtciudad_alu.Enabled = true;
            txtdireccion_alu.Enabled = true;

            txtdocumentoidentidad_alu.Text = "";
            txtnombres_alu.Text = "";
            txtapellidos_alu.Text = "";
            txtfechanacimiento_alu.Value = Convert.ToDateTime("01/01/1990", new CultureInfo("es-ES"));
            cbosexo_alu.SelectedIndex = 0;
            txtciudad_alu.Text = "";
            txtdireccion_alu.Text = "";
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            if (txtnombres_alu.Text == "" || txtnombres_alu.Text == "" ||
                txtdocumentoidentidad_apo.Text == "" || txtnombres_apo.Text == "" || txtapellidos_apo.Text == "") {
                MessageBox.Show("Falta Completar Datos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            XElement xml = new XElement("DATA");

            xml.Add(new XElement("ACADEMICO",
                        new XElement("situacion",((ComboBoxItem)cbosituacion.SelectedItem).Text.ToString()),
                        new XElement("idperiodo", Pidperiodo),
                        new XElement("idnivel", Pidnivel),
                        new XElement("idgradoseccion", Pidgradosseccion),
                        new XElement("institucionprocedencia", txtinstitucionprocedencia.Text),
                        new XElement("esrepitente", ((ComboBoxItem)cboesrepitente.SelectedItem).Text.ToString())
                        ));

            xml.Add(new XElement("ALUMNO",
                        new XElement("idalumno", txtidalumno.Text),
                        new XElement("documentoidentidad", txtdocumentoidentidad_alu.Text),
                        new XElement("nombres", txtnombres_alu.Text),
                        new XElement("apellidos", txtapellidos_alu.Text),
                        new XElement("fechanacimiento", txtfechanacimiento_alu.Text ),
                        new XElement("sexo", ((ComboBoxItem)cbosexo_alu.SelectedItem).Text.ToString()),
                        new XElement("ciudad", txtciudad_alu.Text ),
                        new XElement("direccion", txtdireccion_alu.Text )
                        ));

            xml.Add(new XElement("APODERADO",
                        new XElement("tiporelacion", ((ComboBoxItem)cbotiporelacion_apo.SelectedItem).Text.ToString()),
                        new XElement("documentoidentidad", txtdocumentoidentidad_apo.Text),
                        new XElement("nombres", txtnombres_apo.Text),
                        new XElement("apellidos", txtapellidos_apo.Text),
                        new XElement("fechanacimiento", txtfechanacimiento_apo.Text),
                        new XElement("sexo", ((ComboBoxItem)cbosexo_apo.SelectedItem).Text.ToString()),
                        new XElement("estadocivil", ((ComboBoxItem)cbosexo_apo.SelectedItem).Text.ToString()),
                        new XElement("ciudad", txtciudad_apo.Text),
                        new XElement("direccion", txtdireccion_apo.Text)
                        ));

            int Respuesta = CD_Matricula.Registrar(xml.ToString());

            if (Respuesta != 0)
            {
                MessageBox.Show("Matricula Registrada", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Error al registrar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
