namespace Sistema
{
    partial class frmAgregarCalificacion
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
            this.cbodocente = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbogradoseccion = new System.Windows.Forms.ComboBox();
            this.cbocurso = new System.Windows.Forms.ComboBox();
            this.cbonivel = new System.Windows.Forms.ComboBox();
            this.cboperiodo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvdata = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.cboalumno = new System.Windows.Forms.ComboBox();
            this.btnvernotas = new System.Windows.Forms.Button();
            this.btnguardarcambios = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).BeginInit();
            this.SuspendLayout();
            // 
            // cbodocente
            // 
            this.cbodocente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbodocente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbodocente.FormattingEnabled = true;
            this.cbodocente.Location = new System.Drawing.Point(66, 7);
            this.cbodocente.Name = "cbodocente";
            this.cbodocente.Size = new System.Drawing.Size(256, 21);
            this.cbodocente.TabIndex = 42;
            this.cbodocente.SelectionChangeCommitted += new System.EventHandler(this.cbodocente_SelectionChangeCommitted);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 41;
            this.label6.Text = "Docente:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnbuscar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbogradoseccion);
            this.groupBox1.Controls.Add(this.cbocurso);
            this.groupBox1.Controls.Add(this.cbonivel);
            this.groupBox1.Location = new System.Drawing.Point(7, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(660, 72);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // btnbuscar
            // 
            this.btnbuscar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnbuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnbuscar.ForeColor = System.Drawing.Color.White;
            this.btnbuscar.Location = new System.Drawing.Point(559, 36);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(91, 23);
            this.btnbuscar.TabIndex = 34;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = false;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Nivel Academico:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(379, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Curso:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(189, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Grado Seccion:";
            // 
            // cbogradoseccion
            // 
            this.cbogradoseccion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbogradoseccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbogradoseccion.FormattingEnabled = true;
            this.cbogradoseccion.Location = new System.Drawing.Point(192, 38);
            this.cbogradoseccion.Name = "cbogradoseccion";
            this.cbogradoseccion.Size = new System.Drawing.Size(180, 21);
            this.cbogradoseccion.TabIndex = 28;
            this.cbogradoseccion.SelectionChangeCommitted += new System.EventHandler(this.cbogradoseccion_SelectionChangeCommitted);
            // 
            // cbocurso
            // 
            this.cbocurso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbocurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbocurso.FormattingEnabled = true;
            this.cbocurso.Location = new System.Drawing.Point(378, 38);
            this.cbocurso.Name = "cbocurso";
            this.cbocurso.Size = new System.Drawing.Size(175, 21);
            this.cbocurso.TabIndex = 30;
            // 
            // cbonivel
            // 
            this.cbonivel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbonivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbonivel.FormattingEnabled = true;
            this.cbonivel.Location = new System.Drawing.Point(8, 38);
            this.cbonivel.Name = "cbonivel";
            this.cbonivel.Size = new System.Drawing.Size(178, 21);
            this.cbonivel.TabIndex = 29;
            this.cbonivel.SelectionChangeCommitted += new System.EventHandler(this.cbonivel_SelectionChangeCommitted);
            // 
            // cboperiodo
            // 
            this.cboperiodo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboperiodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboperiodo.FormattingEnabled = true;
            this.cboperiodo.Location = new System.Drawing.Point(389, 10);
            this.cboperiodo.Name = "cboperiodo";
            this.cboperiodo.Size = new System.Drawing.Size(191, 21);
            this.cboperiodo.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(337, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Periodo:";
            // 
            // dgvdata
            // 
            this.dgvdata.AllowUserToAddRows = false;
            this.dgvdata.AllowUserToDeleteRows = false;
            this.dgvdata.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdata.Location = new System.Drawing.Point(7, 150);
            this.dgvdata.MultiSelect = false;
            this.dgvdata.Name = "dgvdata";
            this.dgvdata.Size = new System.Drawing.Size(660, 245);
            this.dgvdata.TabIndex = 43;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 44;
            this.label4.Text = "Alumno(a):";
            // 
            // cboalumno
            // 
            this.cboalumno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboalumno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboalumno.FormattingEnabled = true;
            this.cboalumno.Location = new System.Drawing.Point(70, 114);
            this.cboalumno.Name = "cboalumno";
            this.cboalumno.Size = new System.Drawing.Size(268, 21);
            this.cboalumno.TabIndex = 45;
            // 
            // btnvernotas
            // 
            this.btnvernotas.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnvernotas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnvernotas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnvernotas.ForeColor = System.Drawing.Color.White;
            this.btnvernotas.Location = new System.Drawing.Point(345, 114);
            this.btnvernotas.Name = "btnvernotas";
            this.btnvernotas.Size = new System.Drawing.Size(108, 23);
            this.btnvernotas.TabIndex = 46;
            this.btnvernotas.Text = "Ver Notas";
            this.btnvernotas.UseVisualStyleBackColor = false;
            this.btnvernotas.Click += new System.EventHandler(this.btnvernotas_Click);
            // 
            // btnguardarcambios
            // 
            this.btnguardarcambios.BackColor = System.Drawing.Color.Green;
            this.btnguardarcambios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnguardarcambios.Enabled = false;
            this.btnguardarcambios.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnguardarcambios.ForeColor = System.Drawing.Color.White;
            this.btnguardarcambios.Location = new System.Drawing.Point(500, 402);
            this.btnguardarcambios.Name = "btnguardarcambios";
            this.btnguardarcambios.Size = new System.Drawing.Size(167, 23);
            this.btnguardarcambios.TabIndex = 47;
            this.btnguardarcambios.Text = "Guardar Cambios";
            this.btnguardarcambios.UseVisualStyleBackColor = false;
            this.btnguardarcambios.Click += new System.EventHandler(this.btnguardarcambios_Click);
            // 
            // frmAgregarCalificacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(676, 437);
            this.Controls.Add(this.btnguardarcambios);
            this.Controls.Add(this.btnvernotas);
            this.Controls.Add(this.cboalumno);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvdata);
            this.Controls.Add(this.cbodocente);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cboperiodo);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmAgregarCalificacion";
            this.Text = "Agregar Calificacion";
            this.Load += new System.EventHandler(this.frmAgregarCalificacion_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbodocente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbogradoseccion;
        private System.Windows.Forms.ComboBox cbocurso;
        private System.Windows.Forms.ComboBox cbonivel;
        private System.Windows.Forms.ComboBox cboperiodo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvdata;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboalumno;
        private System.Windows.Forms.Button btnvernotas;
        private System.Windows.Forms.Button btnguardarcambios;
    }
}