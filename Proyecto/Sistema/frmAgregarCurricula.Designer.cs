namespace Sistema
{
    partial class frmAgregarCurricula
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbonivel = new System.Windows.Forms.ComboBox();
            this.cbogradoseccion = new System.Windows.Forms.ComboBox();
            this.cboperiodo = new System.Windows.Forms.ComboBox();
            this.cbocurso = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.btnagregar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvdata = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.cbodocente = new System.Windows.Forms.ComboBox();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Periodo:";
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(189, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Grado Seccion:";
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
            // cboperiodo
            // 
            this.cboperiodo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboperiodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboperiodo.FormattingEnabled = true;
            this.cboperiodo.Location = new System.Drawing.Point(64, 12);
            this.cboperiodo.Name = "cboperiodo";
            this.cboperiodo.Size = new System.Drawing.Size(191, 21);
            this.cboperiodo.TabIndex = 27;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Concepto curricula:";
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.Location = new System.Drawing.Point(8, 82);
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(364, 20);
            this.txtdescripcion.TabIndex = 32;
            // 
            // btnagregar
            // 
            this.btnagregar.BackColor = System.Drawing.Color.Green;
            this.btnagregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnagregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnagregar.ForeColor = System.Drawing.Color.White;
            this.btnagregar.Location = new System.Drawing.Point(378, 80);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(175, 23);
            this.btnagregar.TabIndex = 33;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = false;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnbuscar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnagregar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtdescripcion);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbogradoseccion);
            this.groupBox1.Controls.Add(this.cbocurso);
            this.groupBox1.Controls.Add(this.cbonivel);
            this.groupBox1.Location = new System.Drawing.Point(12, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(660, 111);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // dgvdata
            // 
            this.dgvdata.AllowUserToAddRows = false;
            this.dgvdata.AllowUserToDeleteRows = false;
            this.dgvdata.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdata.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvdata.Location = new System.Drawing.Point(12, 156);
            this.dgvdata.MultiSelect = false;
            this.dgvdata.Name = "dgvdata";
            this.dgvdata.ReadOnly = true;
            this.dgvdata.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvdata.Size = new System.Drawing.Size(660, 198);
            this.dgvdata.TabIndex = 35;
            this.dgvdata.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdata_CellContentClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(261, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "Docente:";
            // 
            // cbodocente
            // 
            this.cbodocente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbodocente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbodocente.FormattingEnabled = true;
            this.cbodocente.Location = new System.Drawing.Point(318, 12);
            this.cbodocente.Name = "cbodocente";
            this.cbodocente.Size = new System.Drawing.Size(256, 21);
            this.cbodocente.TabIndex = 37;
            this.cbodocente.SelectionChangeCommitted += new System.EventHandler(this.cbodocente_SelectionChangeCommitted);
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
            // frmAgregarCurricula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(682, 376);
            this.Controls.Add(this.cbodocente);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvdata);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cboperiodo);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmAgregarCurricula";
            this.Text = "Agregar Curricula";
            this.Load += new System.EventHandler(this.frmAgregarCurricula_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbonivel;
        private System.Windows.Forms.ComboBox cbogradoseccion;
        private System.Windows.Forms.ComboBox cboperiodo;
        private System.Windows.Forms.ComboBox cbocurso;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtdescripcion;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvdata;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbodocente;
        private System.Windows.Forms.Button btnbuscar;
    }
}