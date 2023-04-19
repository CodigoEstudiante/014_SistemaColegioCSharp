namespace Sistema
{
    partial class frmReporteMatricula
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnexportar = new System.Windows.Forms.Button();
            this.dgvdata = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtapellidos = new System.Windows.Forms.TextBox();
            this.txtnombres = new System.Windows.Forms.TextBox();
            this.txtdocumentoidentidad = new System.Windows.Forms.TextBox();
            this.txtcodigoalumno = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtcodigomatricula = new System.Windows.Forms.TextBox();
            this.cbosituacionmatricula = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbonivelacademico = new System.Windows.Forms.ComboBox();
            this.cbogradoseccion = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cboperiodo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).BeginInit();
            this.SuspendLayout();
            // 
            // btnexportar
            // 
            this.btnexportar.BackColor = System.Drawing.Color.Green;
            this.btnexportar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnexportar.Enabled = false;
            this.btnexportar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnexportar.ForeColor = System.Drawing.Color.White;
            this.btnexportar.Location = new System.Drawing.Point(586, 392);
            this.btnexportar.Name = "btnexportar";
            this.btnexportar.Size = new System.Drawing.Size(165, 23);
            this.btnexportar.TabIndex = 26;
            this.btnexportar.Text = "Exportar";
            this.btnexportar.UseVisualStyleBackColor = false;
            this.btnexportar.Click += new System.EventHandler(this.btnexportar_Click);
            // 
            // dgvdata
            // 
            this.dgvdata.AllowUserToAddRows = false;
            this.dgvdata.AllowUserToDeleteRows = false;
            this.dgvdata.Location = new System.Drawing.Point(12, 141);
            this.dgvdata.MultiSelect = false;
            this.dgvdata.Name = "dgvdata";
            this.dgvdata.Size = new System.Drawing.Size(739, 245);
            this.dgvdata.TabIndex = 25;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(646, 112);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(105, 23);
            this.btnBuscar.TabIndex = 24;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtapellidos
            // 
            this.txtapellidos.Location = new System.Drawing.Point(486, 114);
            this.txtapellidos.Name = "txtapellidos";
            this.txtapellidos.Size = new System.Drawing.Size(141, 20);
            this.txtapellidos.TabIndex = 23;
            // 
            // txtnombres
            // 
            this.txtnombres.Location = new System.Drawing.Point(320, 114);
            this.txtnombres.Name = "txtnombres";
            this.txtnombres.Size = new System.Drawing.Size(145, 20);
            this.txtnombres.TabIndex = 22;
            // 
            // txtdocumentoidentidad
            // 
            this.txtdocumentoidentidad.Location = new System.Drawing.Point(150, 114);
            this.txtdocumentoidentidad.Name = "txtdocumentoidentidad";
            this.txtdocumentoidentidad.Size = new System.Drawing.Size(152, 20);
            this.txtdocumentoidentidad.TabIndex = 21;
            // 
            // txtcodigoalumno
            // 
            this.txtcodigoalumno.Location = new System.Drawing.Point(12, 114);
            this.txtcodigoalumno.Name = "txtcodigoalumno";
            this.txtcodigoalumno.Size = new System.Drawing.Size(121, 20);
            this.txtcodigoalumno.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(483, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Apellidos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(317, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Nombres:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(147, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Documento de Identidad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Código Alumno:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Codigo Matricula:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(147, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Situación Matricula:";
            // 
            // txtcodigomatricula
            // 
            this.txtcodigomatricula.Location = new System.Drawing.Point(12, 25);
            this.txtcodigomatricula.Name = "txtcodigomatricula";
            this.txtcodigomatricula.Size = new System.Drawing.Size(121, 20);
            this.txtcodigomatricula.TabIndex = 28;
            // 
            // cbosituacionmatricula
            // 
            this.cbosituacionmatricula.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbosituacionmatricula.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbosituacionmatricula.FormattingEnabled = true;
            this.cbosituacionmatricula.Location = new System.Drawing.Point(150, 25);
            this.cbosituacionmatricula.Name = "cbosituacionmatricula";
            this.cbosituacionmatricula.Size = new System.Drawing.Size(152, 21);
            this.cbosituacionmatricula.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(147, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Nivel Academico:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(317, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Grado y seccion:";
            // 
            // cbonivelacademico
            // 
            this.cbonivelacademico.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbonivelacademico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbonivelacademico.FormattingEnabled = true;
            this.cbonivelacademico.Location = new System.Drawing.Point(150, 69);
            this.cbonivelacademico.Name = "cbonivelacademico";
            this.cbonivelacademico.Size = new System.Drawing.Size(152, 21);
            this.cbonivelacademico.TabIndex = 30;
            this.cbonivelacademico.SelectionChangeCommitted += new System.EventHandler(this.cbonivelacademico_SelectionChangeCommitted);
            // 
            // cbogradoseccion
            // 
            this.cbogradoseccion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbogradoseccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbogradoseccion.FormattingEnabled = true;
            this.cbogradoseccion.Location = new System.Drawing.Point(320, 69);
            this.cbogradoseccion.Name = "cbogradoseccion";
            this.cbogradoseccion.Size = new System.Drawing.Size(145, 21);
            this.cbogradoseccion.TabIndex = 30;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 53);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Periodo:";
            // 
            // cboperiodo
            // 
            this.cboperiodo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboperiodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboperiodo.FormattingEnabled = true;
            this.cboperiodo.Location = new System.Drawing.Point(12, 69);
            this.cboperiodo.Name = "cboperiodo";
            this.cboperiodo.Size = new System.Drawing.Size(121, 21);
            this.cboperiodo.TabIndex = 31;
            this.cboperiodo.SelectionChangeCommitted += new System.EventHandler(this.cboperiodo_SelectionChangeCommitted);
            // 
            // frmReporteMatricula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(758, 426);
            this.Controls.Add(this.cboperiodo);
            this.Controls.Add(this.cbogradoseccion);
            this.Controls.Add(this.cbonivelacademico);
            this.Controls.Add(this.cbosituacionmatricula);
            this.Controls.Add(this.txtcodigomatricula);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnexportar);
            this.Controls.Add(this.dgvdata);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtapellidos);
            this.Controls.Add(this.txtnombres);
            this.Controls.Add(this.txtdocumentoidentidad);
            this.Controls.Add(this.txtcodigoalumno);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmReporteMatricula";
            this.Text = "Reporte Matricula";
            this.Load += new System.EventHandler(this.frmReporteMatricula_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnexportar;
        private System.Windows.Forms.DataGridView dgvdata;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtapellidos;
        private System.Windows.Forms.TextBox txtnombres;
        private System.Windows.Forms.TextBox txtdocumentoidentidad;
        private System.Windows.Forms.TextBox txtcodigoalumno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtcodigomatricula;
        private System.Windows.Forms.ComboBox cbosituacionmatricula;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbonivelacademico;
        private System.Windows.Forms.ComboBox cbogradoseccion;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cboperiodo;
    }
}