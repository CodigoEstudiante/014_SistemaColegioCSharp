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
    public partial class frmCrearNivelDetalle : Form
    {
        public frmCrearNivelDetalle()
        {
            InitializeComponent();
        }

        private void frmCrearNivelDetalle_Load(object sender, EventArgs e)
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

        private void CargarDatos()
        {
            lbasignados.Items.Clear();
            lbporasignar.Items.Clear();

            if (cbonivel.Items.Count < 1 && cboperiodo.Items.Count < 1)
                return;


            int idnivel = Convert.ToInt32(((ComboBoxItem)cbonivel.SelectedItem).Value);
            if(idnivel == 0)
            {
                MessageBox.Show("Debe seleccionar un nivel academico", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            
            //OBTENEMOS DATA

            List<GradoSeccion> oListaGradoSeccionPorAsignar = new List<GradoSeccion>();
            List<GradoSeccion> oListaGradoSeccionAsignados = new List<GradoSeccion>();

            List<GradoSeccion> oListaGradoSeccion = CD_GradoSeccion.Listar();
            List<NivelDetalle> oListaNivelDetalle = CD_NivelDetalle.Listar();

            //FILTRAMOS SEGUN NUESTRO PARAMETROS DE FILTRO
            if(oListaNivelDetalle != null)
            {
                oListaNivelDetalle = oListaNivelDetalle.Where(x => x.oNivel.IdNivel == idnivel).ToList();

            }

            //OBTENEMOS LOS POR ASIGNAR Y LOS ASIGNADOS
            if (oListaGradoSeccion != null && oListaNivelDetalle != null)
            {
                oListaGradoSeccionAsignados = (from a in oListaNivelDetalle
                                               join b in oListaGradoSeccion on a.oGradoSeccion.IdGradoSeccion equals b.IdGradoSeccion
                                               select b).ToList();

                foreach(GradoSeccion a in oListaGradoSeccion)
                {
                    bool encontrado = false;
                    foreach(GradoSeccion b in oListaGradoSeccionAsignados)
                    {
                        if(a.IdGradoSeccion == b.IdGradoSeccion)
                        {
                            encontrado = true;
                            break;
                        }
                    }
                    if(!encontrado)
                    oListaGradoSeccionPorAsignar.Add(a);
                }
            }

            //PINTAMOS LOS POR ASIGNAR EN EL LISTBOX
            if (oListaGradoSeccionPorAsignar.Count > 0)
            {
                foreach (GradoSeccion row in oListaGradoSeccionPorAsignar.Where(x => x.Activo == true))
                {
                    lbporasignar.Items.Add(new ComboBoxItem() { Value = row.IdGradoSeccion, Text = row.DescripcionGrado + " - " + row.DescripcionSeccion });
                }
                lbporasignar.DisplayMember = "Text";
                lbporasignar.ValueMember = "Value";

            }

            //PINTAMOS LOS ASIGNADOS EN EL LISTBOX
            if (oListaGradoSeccionAsignados.Count > 0)
            {
                foreach (GradoSeccion row in oListaGradoSeccionAsignados.Where(x => x.Activo == true))
                {
                    lbasignados.Items.Add(new ComboBoxItem() { Value = row.IdGradoSeccion, Text = row.DescripcionGrado + " - " + row.DescripcionSeccion });
                }
                lbasignados.DisplayMember = "Text";
                lbasignados.ValueMember = "Value";
            }


            btnGuardar.Enabled = true;
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            List<ComboBoxItem> ListOptions = new List<ComboBoxItem>();

            foreach(ComboBoxItem option in lbporasignar.SelectedItems)
            {
                lbasignados.Items.Add(option);
                ListOptions.Add(option);
            }
            
            foreach(ComboBoxItem option in ListOptions)
            {
                lbporasignar.Items.Remove(option);
                
            }
            lbasignados.DisplayMember = "Text";
            lbasignados.ValueMember = "Value";
        }

        private void btnquitar_Click(object sender, EventArgs e)
        {
            List<ComboBoxItem> ListOptions = new List<ComboBoxItem>();

            foreach (ComboBoxItem option in lbasignados.SelectedItems)
            {
                lbporasignar.Items.Add(option);
                ListOptions.Add(option);
            }

            foreach (ComboBoxItem option in ListOptions)
            {
                lbasignados.Items.Remove(option);

            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            XElement XML = new XElement("DETALLE",
              new XElement("DATA",
              new XElement("IdNivel", ((ComboBoxItem)cbonivel.SelectedItem).Value)
              ));

            XElement GradoSeccion = new XElement("GRADOSECCION");
            
            foreach (ComboBoxItem option in lbasignados.Items)
            {
                GradoSeccion.Add(new XElement("DATA",
                    new XElement("IdGradoSeccion", option.Value)
                    ));
            }

            XML.Add(GradoSeccion);

            bool resultado = CD_NivelDetalle.Registrar(XML.ToString());

            if (resultado)
            {
                MessageBox.Show("Se guardaron los cambios", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnGuardar.Enabled = false;
                lbasignados.Items.Clear();
                lbporasignar.Items.Clear();
                cbonivel.SelectedIndex = 0;
            }
            else
                MessageBox.Show("No se guardaron los cambios, algunos Niveles Academicos ya cuentas con Cursos asignados", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


        }
    }
}
