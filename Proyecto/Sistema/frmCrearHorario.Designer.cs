namespace Sistema
{
    partial class frmCrearHorario
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
            this.btnBuscar = new System.Windows.Forms.Button();
            this.cbogradoseccion = new System.Windows.Forms.ComboBox();
            this.cbonivel = new System.Windows.Forms.ComboBox();
            this.cboperiodo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblmax = new System.Windows.Forms.Label();
            this.lblmin = new System.Windows.Forms.Label();
            this.cbodiasemana = new System.Windows.Forms.ComboBox();
            this.btnasignar = new System.Windows.Forms.Button();
            this.txthorafin = new System.Windows.Forms.DateTimePicker();
            this.txthorainicio = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbocurso = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvdata = new System.Windows.Forms.DataGridView();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.cboFiltro = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(717, 33);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 26;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // cbogradoseccion
            // 
            this.cbogradoseccion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbogradoseccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbogradoseccion.FormattingEnabled = true;
            this.cbogradoseccion.Location = new System.Drawing.Point(466, 35);
            this.cbogradoseccion.Name = "cbogradoseccion";
            this.cbogradoseccion.Size = new System.Drawing.Size(227, 21);
            this.cbogradoseccion.TabIndex = 24;
            // 
            // cbonivel
            // 
            this.cbonivel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbonivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbonivel.FormattingEnabled = true;
            this.cbonivel.Location = new System.Drawing.Point(228, 35);
            this.cbonivel.Name = "cbonivel";
            this.cbonivel.Size = new System.Drawing.Size(212, 21);
            this.cbonivel.TabIndex = 25;
            this.cbonivel.SelectionChangeCommitted += new System.EventHandler(this.cbonivel_SelectionChangeCommitted);
            // 
            // cboperiodo
            // 
            this.cboperiodo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboperiodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboperiodo.FormattingEnabled = true;
            this.cboperiodo.Location = new System.Drawing.Point(8, 35);
            this.cboperiodo.Name = "cboperiodo";
            this.cboperiodo.Size = new System.Drawing.Size(200, 21);
            this.cboperiodo.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(463, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Grado Seccion:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(225, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Nivel Academico:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Periodo:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbonivel);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbogradoseccion);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cboperiodo);
            this.groupBox1.Location = new System.Drawing.Point(6, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(806, 69);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar por";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblmax);
            this.groupBox2.Controls.Add(this.lblmin);
            this.groupBox2.Controls.Add(this.cbodiasemana);
            this.groupBox2.Controls.Add(this.btnasignar);
            this.groupBox2.Controls.Add(this.txthorafin);
            this.groupBox2.Controls.Add(this.txthorainicio);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cbocurso);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(6, 79);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(806, 68);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalle";
            // 
            // lblmax
            // 
            this.lblmax.AutoSize = true;
            this.lblmax.ForeColor = System.Drawing.Color.Red;
            this.lblmax.Location = new System.Drawing.Point(610, 20);
            this.lblmax.Name = "lblmax";
            this.lblmax.Size = new System.Drawing.Size(10, 13);
            this.lblmax.TabIndex = 26;
            this.lblmax.Text = "-";
            // 
            // lblmin
            // 
            this.lblmin.AutoSize = true;
            this.lblmin.ForeColor = System.Drawing.Color.Red;
            this.lblmin.Location = new System.Drawing.Point(444, 20);
            this.lblmin.Name = "lblmin";
            this.lblmin.Size = new System.Drawing.Size(10, 13);
            this.lblmin.TabIndex = 26;
            this.lblmin.Text = "-";
            // 
            // cbodiasemana
            // 
            this.cbodiasemana.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbodiasemana.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbodiasemana.FormattingEnabled = true;
            this.cbodiasemana.Location = new System.Drawing.Point(8, 35);
            this.cbodiasemana.Name = "cbodiasemana";
            this.cbodiasemana.Size = new System.Drawing.Size(145, 21);
            this.cbodiasemana.TabIndex = 25;
            // 
            // btnasignar
            // 
            this.btnasignar.BackColor = System.Drawing.Color.Green;
            this.btnasignar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnasignar.ForeColor = System.Drawing.Color.White;
            this.btnasignar.Location = new System.Drawing.Point(717, 32);
            this.btnasignar.Name = "btnasignar";
            this.btnasignar.Size = new System.Drawing.Size(75, 23);
            this.btnasignar.TabIndex = 24;
            this.btnasignar.Text = "Asignar";
            this.btnasignar.UseVisualStyleBackColor = false;
            this.btnasignar.Click += new System.EventHandler(this.btnasignar_Click);
            // 
            // txthorafin
            // 
            this.txthorafin.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.txthorafin.Location = new System.Drawing.Point(554, 36);
            this.txthorafin.Name = "txthorafin";
            this.txthorafin.ShowUpDown = true;
            this.txthorafin.Size = new System.Drawing.Size(140, 20);
            this.txthorafin.TabIndex = 23;
            // 
            // txthorainicio
            // 
            this.txthorainicio.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.txthorainicio.Location = new System.Drawing.Point(380, 36);
            this.txthorainicio.Name = "txthorainicio";
            this.txthorainicio.ShowUpDown = true;
            this.txthorainicio.Size = new System.Drawing.Size(140, 20);
            this.txthorainicio.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(551, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Hora Fin:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Dia Semana:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(377, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Hora Inicio:";
            // 
            // cbocurso
            // 
            this.cbocurso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbocurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbocurso.FormattingEnabled = true;
            this.cbocurso.Location = new System.Drawing.Point(177, 34);
            this.cbocurso.Name = "cbocurso";
            this.cbocurso.Size = new System.Drawing.Size(175, 21);
            this.cbocurso.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(175, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Curso:";
            // 
            // dgvdata
            // 
            this.dgvdata.AllowUserToAddRows = false;
            this.dgvdata.AllowUserToDeleteRows = false;
            this.dgvdata.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdata.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvdata.Location = new System.Drawing.Point(6, 185);
            this.dgvdata.MultiSelect = false;
            this.dgvdata.Name = "dgvdata";
            this.dgvdata.ReadOnly = true;
            this.dgvdata.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvdata.Size = new System.Drawing.Size(806, 198);
            this.dgvdata.TabIndex = 29;
            this.dgvdata.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdata_CellContentClick);
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(658, 158);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(153, 20);
            this.txtFilter.TabIndex = 32;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // cboFiltro
            // 
            this.cboFiltro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFiltro.FormattingEnabled = true;
            this.cboFiltro.Location = new System.Drawing.Point(531, 158);
            this.cboFiltro.Name = "cboFiltro";
            this.cboFiltro.Size = new System.Drawing.Size(121, 21);
            this.cboFiltro.TabIndex = 31;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(469, 161);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 30;
            this.label10.Text = "Filtrar  por:";
            // 
            // frmCrearHorario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(821, 405);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.cboFiltro);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dgvdata);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmCrearHorario";
            this.Text = "Crear Horario";
            this.Load += new System.EventHandler(this.frmCrearHorario_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ComboBox cbogradoseccion;
        private System.Windows.Forms.ComboBox cbonivel;
        private System.Windows.Forms.ComboBox cboperiodo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnasignar;
        private System.Windows.Forms.DateTimePicker txthorafin;
        private System.Windows.Forms.DateTimePicker txthorainicio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbocurso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbodiasemana;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblmax;
        private System.Windows.Forms.Label lblmin;
        private System.Windows.Forms.DataGridView dgvdata;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.ComboBox cboFiltro;
        private System.Windows.Forms.Label label10;
    }
}