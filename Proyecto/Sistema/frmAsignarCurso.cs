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
    public partial class frmAsignarCurso : Form
    {
        public frmAsignarCurso()
        {
            InitializeComponent();
        }

        private void frmAsignarCurso_Load(object sender, EventArgs e)
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

            if (cbonivel.Items.Count > 0)
            {
                cbonivel.SelectedIndex = 0;
                int idnivel = Convert.ToInt32(((ComboBoxItem)cbonivel.SelectedItem).Value);
                List<NivelDetalle> oListaNivelDetalle = CD_NivelDetalle.Listar();
                cbogradoseccion.Items.Add(new ComboBoxItem() { Value = 0, Text = "Seleccione Grado - Seccion" });

                if (oListaNivelDetalle != null)
                {
                    oListaNivelDetalle = oListaNivelDetalle.Where(x => x.oNivel.IdNivel == idnivel).ToList();


                    if(oListaNivelDetalle.Count > 0)
                    {
                        foreach (NivelDetalle row in oListaNivelDetalle.Where(x => x.Activo == true))
                        {
                            cbogradoseccion.Items.Add(new ComboBoxItem() { Value = row.oGradoSeccion.IdGradoSeccion,
                                Text = row.oGradoSeccion.DescripcionGrado + " - " + row.oGradoSeccion.DescripcionSeccion });
                        }
                        
                    }

                }

                cbogradoseccion.DisplayMember = "Text";
                cbogradoseccion.ValueMember = "Value";
                cbogradoseccion.SelectedIndex = 0;
            }
        }

        private void CargarDatos()
        {
            lbasignados.Items.Clear();
            lbporasignar.Items.Clear();

            if (cbonivel.Items.Count < 1 || cboperiodo.Items.Count < 1 || cbogradoseccion.Items.Count < 1)
                return;


            int idnivel = Convert.ToInt32(((ComboBoxItem)cbonivel.SelectedItem).Value);
            if (idnivel == 0)
            {
                MessageBox.Show("Debe seleccionar un nivel academico", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            int idgradoseccion = Convert.ToInt32(((ComboBoxItem)cbogradoseccion.SelectedItem).Value);
            if (idgradoseccion == 0)
            {
                MessageBox.Show("Debe seleccionar un grado - seccion", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            //OBTENEMOS DATA

            List<Curso> oListaCursosPorAsignar = new List<Curso>();
            List<Curso> oListaCursosAsignados = new List<Curso>();

            List<Curso> oListaCurso = CD_Curso.Listar();
            List<NivelDetalleCurso> oListaNivelDetalleCurso = CD_NivelDetalleCurso.Listar();

            //FILTRAMOS SEGUN NUESTRO PARAMETROS DE FILTRO
            if (oListaNivelDetalleCurso != null)
            {
                oListaNivelDetalleCurso = oListaNivelDetalleCurso.Where(x => 
                x.oNivel.IdNivel == idnivel &&
                x.oGradoSeccion.IdGradoSeccion == idgradoseccion).ToList();

            }

            //OBTENEMOS LOS POR ASIGNAR Y LOS ASIGNADOS
            if(oListaCurso != null && oListaNivelDetalleCurso != null)
            {
                oListaCursosAsignados = (from a in oListaCurso
                                               join b in oListaNivelDetalleCurso on a.IdCurso equals b.oCurso.IdCurso
                                               select a).ToList();

                foreach (Curso a in oListaCurso)
                {
                    bool encontrado = false;
                    foreach (Curso b in oListaCursosAsignados)
                    {
                        if (a.IdCurso == b.IdCurso)
                        {
                            encontrado = true;
                            break;
                        }
                    }
                    if (!encontrado)
                        oListaCursosPorAsignar.Add(a);
                }
            }


            //PINTAMOS LOS POR ASIGNAR EN EL LISTBOX
            if (oListaCursosPorAsignar.Count > 0)
            {
                foreach (Curso row in oListaCursosPorAsignar.Where(x => x.Activo == true))
                {
                    lbporasignar.Items.Add(new ComboBoxItem() { Value = row.IdCurso, Text = row.Descripcion });
                }
                lbporasignar.DisplayMember = "Text";
                lbporasignar.ValueMember = "Value";

            }

            //PINTAMOS LOS ASIGNADOS EN EL LISTBOX
            if (oListaCursosAsignados.Count > 0)
            {
                foreach (Curso row in oListaCursosAsignados.Where(x => x.Activo == true))
                {
                    lbasignados.Items.Add(new ComboBoxItem() { Value = row.IdCurso, Text = row.Descripcion });
                }
                lbasignados.DisplayMember = "Text";
                lbasignados.ValueMember = "Value";
            }
            btnGuardar.Enabled = true;
        }



        private void cbonivel_SelectionChangeCommitted(object sender, EventArgs e)
        {

            cbogradoseccion.Items.Clear();

            int idnivel = Convert.ToInt32(((ComboBoxItem)cbonivel.SelectedItem).Value);
            List<NivelDetalle> oListaNivelDetalle = CD_NivelDetalle.Listar();
            cbogradoseccion.Items.Add(new ComboBoxItem() { Value = 0, Text = "Seleccione Grado - Seccion" });

            if (oListaNivelDetalle != null)
            {
                oListaNivelDetalle = oListaNivelDetalle.Where(x => x.oNivel.IdNivel == idnivel).ToList();


                if (oListaNivelDetalle.Count > 0)
                {
                    foreach (NivelDetalle row in oListaNivelDetalle.Where(x => x.Activo == true))
                    {
                        cbogradoseccion.Items.Add(new ComboBoxItem()
                        {
                            Value = row.oGradoSeccion.IdGradoSeccion,
                            Text = row.oGradoSeccion.DescripcionGrado + " - " + row.oGradoSeccion.DescripcionSeccion
                        });
                    }

                }

            }

            cbogradoseccion.DisplayMember = "Text";
            cbogradoseccion.ValueMember = "Value";
            cbogradoseccion.SelectedIndex = 0;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {

            List<ComboBoxItem> ListOptions = new List<ComboBoxItem>();

            foreach (ComboBoxItem option in lbporasignar.SelectedItems)
            {
                lbasignados.Items.Add(option);
                ListOptions.Add(option);
            }

            foreach (ComboBoxItem option in ListOptions)
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            XElement XML = new XElement("DETALLE");

            XML.Add(new XElement("NIVEL",
                new XElement("IdNivel", ((ComboBoxItem)cbonivel.SelectedItem).Value)
              ));

            XML.Add(new XElement("GRADOSECCION",
                new XElement("IdGradoSeccion", ((ComboBoxItem)cbogradoseccion.SelectedItem).Value)
              ));

            XElement CURSOS = new XElement("CURSOS");

            foreach (ComboBoxItem option in lbasignados.Items)
            {
                CURSOS.Add(new XElement("DATA",
                    new XElement("IdCurso", option.Value)
                    ));
            }

            XML.Add(CURSOS);


            bool resultado = CD_NivelDetalleCurso.Asignar(XML.ToString());

            if (resultado)
            {
                MessageBox.Show("Se guardaron los cambios", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnGuardar.Enabled = false;
                lbasignados.Items.Clear();
                lbporasignar.Items.Clear();
                cbonivel.SelectedIndex = 0;
                cbonivel_SelectionChangeCommitted(cbonivel, new EventArgs());
                cbogradoseccion.SelectedIndex = 0;
            }
            else
                MessageBox.Show("No se guardaron los cambios, Algunos cursos ya cuentan con un horario asignado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }
    }
}
