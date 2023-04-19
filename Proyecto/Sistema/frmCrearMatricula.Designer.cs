namespace Sistema
{
    partial class frmCrearMatricula
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
            this.cbogradoseccion = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.cbonivelacademico = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblperiodo = new System.Windows.Forms.Label();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtvacantes = new System.Windows.Forms.TextBox();
            this.btncontinuar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbogradoseccion
            // 
            this.cbogradoseccion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbogradoseccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbogradoseccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbogradoseccion.FormattingEnabled = true;
            this.cbogradoseccion.Location = new System.Drawing.Point(191, 56);
            this.cbogradoseccion.Name = "cbogradoseccion";
            this.cbogradoseccion.Size = new System.Drawing.Size(160, 23);
            this.cbogradoseccion.TabIndex = 11;
            this.cbogradoseccion.SelectionChangeCommitted += new System.EventHandler(this.cbogradoseccion_SelectionChangeCommitted);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(188, 38);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(91, 15);
            this.label22.TabIndex = 10;
            this.label22.Text = "Grado Sección:";
            // 
            // cbonivelacademico
            // 
            this.cbonivelacademico.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbonivelacademico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbonivelacademico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbonivelacademico.FormattingEnabled = true;
            this.cbonivelacademico.Location = new System.Drawing.Point(16, 56);
            this.cbonivelacademico.Name = "cbonivelacademico";
            this.cbonivelacademico.Size = new System.Drawing.Size(162, 23);
            this.cbonivelacademico.TabIndex = 9;
            this.cbonivelacademico.SelectionChangeCommitted += new System.EventHandler(this.cbonivelacademico_SelectionChangeCommitted);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(13, 38);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(101, 15);
            this.label21.TabIndex = 8;
            this.label21.Text = "Nivel Academico:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Periodo:";
            // 
            // lblperiodo
            // 
            this.lblperiodo.AutoSize = true;
            this.lblperiodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblperiodo.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblperiodo.Location = new System.Drawing.Point(68, 11);
            this.lblperiodo.Name = "lblperiodo";
            this.lblperiodo.Size = new System.Drawing.Size(133, 15);
            this.lblperiodo.TabIndex = 13;
            this.lblperiodo.Text = "PERIODO ELEGIDO";
            // 
            // btnbuscar
            // 
            this.btnbuscar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnbuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnbuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscar.ForeColor = System.Drawing.Color.White;
            this.btnbuscar.Location = new System.Drawing.Point(367, 56);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(75, 23);
            this.btnbuscar.TabIndex = 14;
            this.btnbuscar.Text = "Buscar Vacantes";
            this.btnbuscar.UseVisualStyleBackColor = false;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(124, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "Total Vacantes:";
            // 
            // txtvacantes
            // 
            this.txtvacantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtvacantes.Location = new System.Drawing.Point(220, 98);
            this.txtvacantes.Name = "txtvacantes";
            this.txtvacantes.ReadOnly = true;
            this.txtvacantes.Size = new System.Drawing.Size(94, 21);
            this.txtvacantes.TabIndex = 16;
            // 
            // btncontinuar
            // 
            this.btncontinuar.BackColor = System.Drawing.Color.Green;
            this.btncontinuar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncontinuar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btncontinuar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncontinuar.ForeColor = System.Drawing.Color.White;
            this.btncontinuar.Location = new System.Drawing.Point(127, 127);
            this.btncontinuar.Name = "btncontinuar";
            this.btncontinuar.Size = new System.Drawing.Size(187, 31);
            this.btncontinuar.TabIndex = 17;
            this.btncontinuar.Text = "Continuar";
            this.btncontinuar.UseVisualStyleBackColor = false;
            this.btncontinuar.Click += new System.EventHandler(this.btncontinuar_Click);
            // 
            // frmCrearMatricula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(463, 171);
            this.Controls.Add(this.btncontinuar);
            this.Controls.Add(this.txtvacantes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.lblperiodo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbogradoseccion);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.cbonivelacademico);
            this.Controls.Add(this.label21);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmCrearMatricula";
            this.Text = "Crear Matricula";
            this.Load += new System.EventHandler(this.frmCrearMatricula_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbogradoseccion;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ComboBox cbonivelacademico;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblperiodo;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtvacantes;
        private System.Windows.Forms.Button btncontinuar;
    }
}