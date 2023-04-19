using CapaDatos;
using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema
{
    public partial class frmReporteAlumnos : Form
    {
        public frmReporteAlumnos()
        {
            InitializeComponent();
        }
        DataTable dt = new DataTable();
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dt = CD_Alumno.Reporte(txtnombres.Text, txtapellidos.Text, txtcodigo.Text, txtdocumentoidentidad.Text);

            if(dt.Rows.Count < 1){
                MessageBox.Show("No se encontraron resultados", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            dgvdata.DataSource = dt;
            btnexportar.Enabled = true;
        }

        private void btnexportar_Click(object sender, EventArgs e)
        {
            if (dgvdata.Rows.Count > 0)
            {
                SaveFileDialog savefile = new SaveFileDialog();
                savefile.FileName = string.Format("Reporte_{0}.xlsx", DateTime.Today.ToString("ddMMyyyy"));
                savefile.Filter = "Excel Files|*.xlsx";
                if (savefile.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string informe = "Informe";
                        XLWorkbook wb = new XLWorkbook();
                        wb.Worksheets.Add(dt, informe);
                        wb.SaveAs(savefile.FileName);
                        MessageBox.Show("Reporte Generado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch
                    {
                        MessageBox.Show("Error al generar reporte", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }


                }
            }
            else
            {
                MessageBox.Show("No existen datos para exportar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
