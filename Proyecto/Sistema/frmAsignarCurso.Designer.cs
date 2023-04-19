namespace Sistema
{
    partial class frmAsignarCurso
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
            this.label4 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.cbonivel = new System.Windows.Forms.ComboBox();
            this.cboperiodo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnquitar = new System.Windows.Forms.Button();
            this.btnagregar = new System.Windows.Forms.Button();
            this.lbasignados = new System.Windows.Forms.ListBox();
            this.lbporasignar = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbogradoseccion = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Green;
            this.label4.Location = new System.Drawing.Point(434, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Cursos Asignados";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Green;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.Enabled = false;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(437, 296);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(223, 23);
            this.btnGuardar.TabIndex = 21;
            this.btnGuardar.Text = "Guardar Cambios";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(12, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Cursos por Asignar";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(585, 27);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 19;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // cbonivel
            // 
            this.cbonivel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbonivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbonivel.FormattingEnabled = true;
            this.cbonivel.Location = new System.Drawing.Point(196, 29);
            this.cbonivel.Name = "cbonivel";
            this.cbonivel.Size = new System.Drawing.Size(174, 21);
            this.cbonivel.TabIndex = 18;
            this.cbonivel.SelectionChangeCommitted += new System.EventHandler(this.cbonivel_SelectionChangeCommitted);
            // 
            // cboperiodo
            // 
            this.cboperiodo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboperiodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboperiodo.FormattingEnabled = true;
            this.cboperiodo.Location = new System.Drawing.Point(12, 29);
            this.cboperiodo.Name = "cboperiodo";
            this.cboperiodo.Size = new System.Drawing.Size(165, 21);
            this.cboperiodo.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(193, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Nivel Academico:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Periodo:";
            // 
            // btnquitar
            // 
            this.btnquitar.BackColor = System.Drawing.Color.Orange;
            this.btnquitar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnquitar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnquitar.Location = new System.Drawing.Point(314, 172);
            this.btnquitar.Name = "btnquitar";
            this.btnquitar.Size = new System.Drawing.Size(75, 23);
            this.btnquitar.TabIndex = 13;
            this.btnquitar.Text = "<<";
            this.btnquitar.UseVisualStyleBackColor = false;
            this.btnquitar.Click += new System.EventHandler(this.btnquitar_Click);
            // 
            // btnagregar
            // 
            this.btnagregar.BackColor = System.Drawing.Color.Orange;
            this.btnagregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnagregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnagregar.Location = new System.Drawing.Point(314, 143);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(75, 23);
            this.btnagregar.TabIndex = 14;
            this.btnagregar.Text = ">>";
            this.btnagregar.UseVisualStyleBackColor = false;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // lbasignados
            // 
            this.lbasignados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbasignados.FormattingEnabled = true;
            this.lbasignados.Location = new System.Drawing.Point(437, 81);
            this.lbasignados.Name = "lbasignados";
            this.lbasignados.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbasignados.Size = new System.Drawing.Size(223, 199);
            this.lbasignados.TabIndex = 12;
            // 
            // lbporasignar
            // 
            this.lbporasignar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbporasignar.FormattingEnabled = true;
            this.lbporasignar.Location = new System.Drawing.Point(15, 81);
            this.lbporasignar.Name = "lbporasignar";
            this.lbporasignar.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbporasignar.Size = new System.Drawing.Size(254, 199);
            this.lbporasignar.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(385, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Grado Seccion:";
            // 
            // cbogradoseccion
            // 
            this.cbogradoseccion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbogradoseccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbogradoseccion.FormattingEnabled = true;
            this.cbogradoseccion.Location = new System.Drawing.Point(388, 29);
            this.cbogradoseccion.Name = "cbogradoseccion";
            this.cbogradoseccion.Size = new System.Drawing.Size(191, 21);
            this.cbogradoseccion.TabIndex = 18;
            // 
            // frmAsignarCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(672, 331);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.cbogradoseccion);
            this.Controls.Add(this.cbonivel);
            this.Controls.Add(this.cboperiodo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnquitar);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.lbasignados);
            this.Controls.Add(this.lbporasignar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmAsignarCurso";
            this.Text = "Asignar Curso";
            this.Load += new System.EventHandler(this.frmAsignarCurso_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ComboBox cbonivel;
        private System.Windows.Forms.ComboBox cboperiodo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnquitar;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.ListBox lbasignados;
        private System.Windows.Forms.ListBox lbporasignar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbogradoseccion;
    }
}