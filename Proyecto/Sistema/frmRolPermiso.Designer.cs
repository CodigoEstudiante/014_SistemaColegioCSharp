namespace Sistema
{
    partial class frmRolPermiso
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGuardarCambios = new System.Windows.Forms.Button();
            this.dgvPermisos = new System.Windows.Forms.DataGridView();
            this.btnBuscarPermisos = new System.Windows.Forms.Button();
            this.cboRol = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPermisos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Red;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(363, 347);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(101, 23);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnGuardarCambios
            // 
            this.btnGuardarCambios.BackColor = System.Drawing.Color.Green;
            this.btnGuardarCambios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarCambios.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardarCambios.ForeColor = System.Drawing.Color.White;
            this.btnGuardarCambios.Location = new System.Drawing.Point(232, 347);
            this.btnGuardarCambios.Name = "btnGuardarCambios";
            this.btnGuardarCambios.Size = new System.Drawing.Size(101, 23);
            this.btnGuardarCambios.TabIndex = 10;
            this.btnGuardarCambios.Text = "Guardar Cambios";
            this.btnGuardarCambios.UseVisualStyleBackColor = false;
            this.btnGuardarCambios.Click += new System.EventHandler(this.btnGuardarCambios_Click);
            // 
            // dgvPermisos
            // 
            this.dgvPermisos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPermisos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvPermisos.Location = new System.Drawing.Point(9, 44);
            this.dgvPermisos.Name = "dgvPermisos";
            this.dgvPermisos.Size = new System.Drawing.Size(455, 297);
            this.dgvPermisos.TabIndex = 8;
            this.dgvPermisos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPermisos_CellContentClick);
            // 
            // btnBuscarPermisos
            // 
            this.btnBuscarPermisos.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnBuscarPermisos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarPermisos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscarPermisos.ForeColor = System.Drawing.Color.White;
            this.btnBuscarPermisos.Location = new System.Drawing.Point(354, 6);
            this.btnBuscarPermisos.Name = "btnBuscarPermisos";
            this.btnBuscarPermisos.Size = new System.Drawing.Size(110, 23);
            this.btnBuscarPermisos.TabIndex = 7;
            this.btnBuscarPermisos.Text = "Buscar Permisos";
            this.btnBuscarPermisos.UseVisualStyleBackColor = false;
            this.btnBuscarPermisos.Click += new System.EventHandler(this.btnBuscarPermisos_Click);
            // 
            // cboRol
            // 
            this.cboRol.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRol.FormattingEnabled = true;
            this.cboRol.Location = new System.Drawing.Point(38, 8);
            this.cboRol.Name = "cboRol";
            this.cboRol.Size = new System.Drawing.Size(216, 21);
            this.cboRol.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Rol:";
            // 
            // frmRolPermiso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(473, 379);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnGuardarCambios);
            this.Controls.Add(this.dgvPermisos);
            this.Controls.Add(this.btnBuscarPermisos);
            this.Controls.Add(this.cboRol);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmRolPermiso";
            this.Text = "Asignar Rol Permiso";
            this.Load += new System.EventHandler(this.frmRolPermiso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPermisos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnGuardarCambios;
        private System.Windows.Forms.DataGridView dgvPermisos;
        private System.Windows.Forms.Button btnBuscarPermisos;
        private System.Windows.Forms.ComboBox cboRol;
        private System.Windows.Forms.Label label1;
    }
}