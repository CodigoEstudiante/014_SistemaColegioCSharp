namespace Sistema
{
    partial class frmCrearNivelDetalle
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
            this.lbporasignar = new System.Windows.Forms.ListBox();
            this.lbasignados = new System.Windows.Forms.ListBox();
            this.btnagregar = new System.Windows.Forms.Button();
            this.btnquitar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboperiodo = new System.Windows.Forms.ComboBox();
            this.cbonivel = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbporasignar
            // 
            this.lbporasignar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbporasignar.FormattingEnabled = true;
            this.lbporasignar.Location = new System.Drawing.Point(18, 82);
            this.lbporasignar.Name = "lbporasignar";
            this.lbporasignar.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbporasignar.Size = new System.Drawing.Size(165, 199);
            this.lbporasignar.TabIndex = 0;
            // 
            // lbasignados
            // 
            this.lbasignados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbasignados.FormattingEnabled = true;
            this.lbasignados.Location = new System.Drawing.Point(325, 79);
            this.lbasignados.Name = "lbasignados";
            this.lbasignados.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbasignados.Size = new System.Drawing.Size(165, 199);
            this.lbasignados.TabIndex = 1;
            // 
            // btnagregar
            // 
            this.btnagregar.BackColor = System.Drawing.Color.Orange;
            this.btnagregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnagregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnagregar.Location = new System.Drawing.Point(216, 133);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(75, 23);
            this.btnagregar.TabIndex = 2;
            this.btnagregar.Text = ">>";
            this.btnagregar.UseVisualStyleBackColor = false;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // btnquitar
            // 
            this.btnquitar.BackColor = System.Drawing.Color.Orange;
            this.btnquitar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnquitar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnquitar.Location = new System.Drawing.Point(216, 162);
            this.btnquitar.Name = "btnquitar";
            this.btnquitar.Size = new System.Drawing.Size(75, 23);
            this.btnquitar.TabIndex = 2;
            this.btnquitar.Text = "<<";
            this.btnquitar.UseVisualStyleBackColor = false;
            this.btnquitar.Click += new System.EventHandler(this.btnquitar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Periodo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(215, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nivel Academico:";
            // 
            // cboperiodo
            // 
            this.cboperiodo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboperiodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboperiodo.FormattingEnabled = true;
            this.cboperiodo.Location = new System.Drawing.Point(18, 30);
            this.cboperiodo.Name = "cboperiodo";
            this.cboperiodo.Size = new System.Drawing.Size(181, 21);
            this.cboperiodo.TabIndex = 5;
            // 
            // cbonivel
            // 
            this.cbonivel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbonivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbonivel.FormattingEnabled = true;
            this.cbonivel.Location = new System.Drawing.Point(218, 30);
            this.cbonivel.Name = "cbonivel";
            this.cbonivel.Size = new System.Drawing.Size(191, 21);
            this.cbonivel.TabIndex = 6;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(415, 28);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 7;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(15, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Grados Pendiente Asignar";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Green;
            this.btnGuardar.Enabled = false;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(325, 284);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(165, 23);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Guardar Cambios";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Green;
            this.label4.Location = new System.Drawing.Point(322, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Grados Asignados";
            // 
            // frmCrearNivelDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(509, 318);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.cbonivel);
            this.Controls.Add(this.cboperiodo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnquitar);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.lbasignados);
            this.Controls.Add(this.lbporasignar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmCrearNivelDetalle";
            this.Text = "Asignar Grados por Nivel Academico";
            this.Load += new System.EventHandler(this.frmCrearNivelDetalle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbporasignar;
        private System.Windows.Forms.ListBox lbasignados;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Button btnquitar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboperiodo;
        private System.Windows.Forms.ComboBox cbonivel;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label4;
    }
}