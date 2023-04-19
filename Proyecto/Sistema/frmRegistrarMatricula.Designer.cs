namespace Sistema
{
    partial class frmRegistrarMatricula
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
            this.txtcodigomatricula = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbosituacion = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbosexo_alu = new System.Windows.Forms.ComboBox();
            this.txtfechanacimiento_alu = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtciudad_alu = new System.Windows.Forms.TextBox();
            this.txtdireccion_alu = new System.Windows.Forms.TextBox();
            this.txtnombres_alu = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtapellidos_alu = new System.Windows.Forms.TextBox();
            this.txtdocumentoidentidad_alu = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.txtidalumno = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtapellidos_apo = new System.Windows.Forms.TextBox();
            this.txtnombres_apo = new System.Windows.Forms.TextBox();
            this.txtdocumentoidentidad_apo = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cbotiporelacion_apo = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cboestadocivil_apo = new System.Windows.Forms.ComboBox();
            this.cbosexo_apo = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtfechanacimiento_apo = new System.Windows.Forms.DateTimePicker();
            this.txtciudad_apo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtdireccion_apo = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtgradoseccion = new System.Windows.Forms.TextBox();
            this.txtnivelacademico = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.cboesrepitente = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtinstitucionprocedencia = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.btnregistrar = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(610, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo Matricula:";
            // 
            // txtcodigomatricula
            // 
            this.txtcodigomatricula.ForeColor = System.Drawing.Color.Red;
            this.txtcodigomatricula.Location = new System.Drawing.Point(700, 9);
            this.txtcodigomatricula.Name = "txtcodigomatricula";
            this.txtcodigomatricula.ReadOnly = true;
            this.txtcodigomatricula.Size = new System.Drawing.Size(125, 20);
            this.txtcodigomatricula.TabIndex = 100;
            this.txtcodigomatricula.Text = "Autogenerado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Situación Alumno:";
            // 
            // cbosituacion
            // 
            this.cbosituacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbosituacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbosituacion.FormattingEnabled = true;
            this.cbosituacion.Location = new System.Drawing.Point(106, 6);
            this.cbosituacion.Name = "cbosituacion";
            this.cbosituacion.Size = new System.Drawing.Size(149, 21);
            this.cbosituacion.TabIndex = 1;
            this.cbosituacion.SelectionChangeCommitted += new System.EventHandler(this.cbosituacion_SelectionChangeCommitted);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(149, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Nombres:";
            // 
            // cbosexo_alu
            // 
            this.cbosexo_alu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbosexo_alu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbosexo_alu.FormattingEnabled = true;
            this.cbosexo_alu.Location = new System.Drawing.Point(152, 75);
            this.cbosexo_alu.Name = "cbosexo_alu";
            this.cbosexo_alu.Size = new System.Drawing.Size(167, 21);
            this.cbosexo_alu.TabIndex = 8;
            // 
            // txtfechanacimiento_alu
            // 
            this.txtfechanacimiento_alu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtfechanacimiento_alu.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtfechanacimiento_alu.Location = new System.Drawing.Point(9, 76);
            this.txtfechanacimiento_alu.Name = "txtfechanacimiento_alu";
            this.txtfechanacimiento_alu.Size = new System.Drawing.Size(129, 20);
            this.txtfechanacimiento_alu.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(152, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Sexo:";
            // 
            // txtciudad_alu
            // 
            this.txtciudad_alu.Location = new System.Drawing.Point(332, 75);
            this.txtciudad_alu.Name = "txtciudad_alu";
            this.txtciudad_alu.Size = new System.Drawing.Size(199, 20);
            this.txtciudad_alu.TabIndex = 9;
            // 
            // txtdireccion_alu
            // 
            this.txtdireccion_alu.Location = new System.Drawing.Point(547, 75);
            this.txtdireccion_alu.Name = "txtdireccion_alu";
            this.txtdireccion_alu.Size = new System.Drawing.Size(261, 20);
            this.txtdireccion_alu.TabIndex = 10;
            // 
            // txtnombres_alu
            // 
            this.txtnombres_alu.Location = new System.Drawing.Point(152, 34);
            this.txtnombres_alu.Name = "txtnombres_alu";
            this.txtnombres_alu.Size = new System.Drawing.Size(167, 20);
            this.txtnombres_alu.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(6, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Documento Identidad:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(544, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Direccion:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(329, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Apellidos:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(329, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Ciudad:";
            // 
            // txtapellidos_alu
            // 
            this.txtapellidos_alu.Location = new System.Drawing.Point(332, 34);
            this.txtapellidos_alu.Name = "txtapellidos_alu";
            this.txtapellidos_alu.Size = new System.Drawing.Size(199, 20);
            this.txtapellidos_alu.TabIndex = 6;
            // 
            // txtdocumentoidentidad_alu
            // 
            this.txtdocumentoidentidad_alu.Location = new System.Drawing.Point(9, 34);
            this.txtdocumentoidentidad_alu.Name = "txtdocumentoidentidad_alu";
            this.txtdocumentoidentidad_alu.Size = new System.Drawing.Size(129, 20);
            this.txtdocumentoidentidad_alu.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(6, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Fecha Nacimiento:";
            // 
            // btnbuscar
            // 
            this.btnbuscar.BackColor = System.Drawing.Color.LightGray;
            this.btnbuscar.Cursor = System.Windows.Forms.Cursors.No;
            this.btnbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnbuscar.ForeColor = System.Drawing.Color.White;
            this.btnbuscar.Location = new System.Drawing.Point(547, 32);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(103, 23);
            this.btnbuscar.TabIndex = 100;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = false;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnlimpiar);
            this.groupBox1.Controls.Add(this.txtidalumno);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnbuscar);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtdocumentoidentidad_alu);
            this.groupBox1.Controls.Add(this.cbosexo_alu);
            this.groupBox1.Controls.Add(this.txtapellidos_alu);
            this.groupBox1.Controls.Add(this.txtfechanacimiento_alu);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtciudad_alu);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtdireccion_alu);
            this.groupBox1.Controls.Add(this.txtnombres_alu);
            this.groupBox1.Location = new System.Drawing.Point(8, 106);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(817, 108);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Alumno";
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.BackColor = System.Drawing.Color.LightGray;
            this.btnlimpiar.Cursor = System.Windows.Forms.Cursors.No;
            this.btnlimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnlimpiar.ForeColor = System.Drawing.Color.White;
            this.btnlimpiar.Location = new System.Drawing.Point(657, 32);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(103, 23);
            this.btnlimpiar.TabIndex = 100;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = false;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // txtidalumno
            // 
            this.txtidalumno.Location = new System.Drawing.Point(766, 34);
            this.txtidalumno.Name = "txtidalumno";
            this.txtidalumno.Size = new System.Drawing.Size(25, 20);
            this.txtidalumno.TabIndex = 29;
            this.txtidalumno.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.txtapellidos_apo);
            this.groupBox2.Controls.Add(this.txtnombres_apo);
            this.groupBox2.Controls.Add(this.txtdocumentoidentidad_apo);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.cbotiporelacion_apo);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.cboestadocivil_apo);
            this.groupBox2.Controls.Add(this.cbosexo_apo);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txtfechanacimiento_apo);
            this.groupBox2.Controls.Add(this.txtciudad_apo);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.txtdireccion_apo);
            this.groupBox2.Location = new System.Drawing.Point(8, 220);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(817, 108);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos del Apoderado";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(149, 61);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(62, 13);
            this.label16.TabIndex = 28;
            this.label16.Text = "Estado Civil";
            // 
            // txtapellidos_apo
            // 
            this.txtapellidos_apo.Location = new System.Drawing.Point(490, 38);
            this.txtapellidos_apo.Name = "txtapellidos_apo";
            this.txtapellidos_apo.Size = new System.Drawing.Size(160, 20);
            this.txtapellidos_apo.TabIndex = 14;
            // 
            // txtnombres_apo
            // 
            this.txtnombres_apo.Location = new System.Drawing.Point(315, 38);
            this.txtnombres_apo.Name = "txtnombres_apo";
            this.txtnombres_apo.Size = new System.Drawing.Size(162, 20);
            this.txtnombres_apo.TabIndex = 13;
            // 
            // txtdocumentoidentidad_apo
            // 
            this.txtdocumentoidentidad_apo.Location = new System.Drawing.Point(152, 38);
            this.txtdocumentoidentidad_apo.Name = "txtdocumentoidentidad_apo";
            this.txtdocumentoidentidad_apo.Size = new System.Drawing.Size(150, 20);
            this.txtdocumentoidentidad_apo.TabIndex = 12;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(662, 22);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(96, 13);
            this.label15.TabIndex = 17;
            this.label15.Text = "Fecha Nacimiento:";
            // 
            // cbotiporelacion_apo
            // 
            this.cbotiporelacion_apo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbotiporelacion_apo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbotiporelacion_apo.FormattingEnabled = true;
            this.cbotiporelacion_apo.ItemHeight = 13;
            this.cbotiporelacion_apo.Location = new System.Drawing.Point(9, 37);
            this.cbotiporelacion_apo.Name = "cbotiporelacion_apo";
            this.cbotiporelacion_apo.Size = new System.Drawing.Size(129, 21);
            this.cbotiporelacion_apo.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(149, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(112, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Documento Identidad:";
            // 
            // cboestadocivil_apo
            // 
            this.cboestadocivil_apo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboestadocivil_apo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboestadocivil_apo.FormattingEnabled = true;
            this.cboestadocivil_apo.Location = new System.Drawing.Point(152, 77);
            this.cboestadocivil_apo.Name = "cboestadocivil_apo";
            this.cboestadocivil_apo.Size = new System.Drawing.Size(150, 21);
            this.cboestadocivil_apo.TabIndex = 17;
            // 
            // cbosexo_apo
            // 
            this.cbosexo_apo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbosexo_apo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbosexo_apo.FormattingEnabled = true;
            this.cbosexo_apo.Location = new System.Drawing.Point(9, 77);
            this.cbosexo_apo.Name = "cbosexo_apo";
            this.cbosexo_apo.Size = new System.Drawing.Size(129, 21);
            this.cbosexo_apo.TabIndex = 16;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(312, 61);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(43, 13);
            this.label18.TabIndex = 19;
            this.label18.Text = "Ciudad:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(312, 21);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "Nombres:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(487, 21);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 13);
            this.label13.TabIndex = 18;
            this.label13.Text = "Apellidos:";
            // 
            // txtfechanacimiento_apo
            // 
            this.txtfechanacimiento_apo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtfechanacimiento_apo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtfechanacimiento_apo.Location = new System.Drawing.Point(665, 38);
            this.txtfechanacimiento_apo.Name = "txtfechanacimiento_apo";
            this.txtfechanacimiento_apo.Size = new System.Drawing.Size(143, 20);
            this.txtfechanacimiento_apo.TabIndex = 15;
            // 
            // txtciudad_apo
            // 
            this.txtciudad_apo.Location = new System.Drawing.Point(315, 78);
            this.txtciudad_apo.Name = "txtciudad_apo";
            this.txtciudad_apo.Size = new System.Drawing.Size(162, 20);
            this.txtciudad_apo.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Tipo Relacion";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(487, 62);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(55, 13);
            this.label17.TabIndex = 20;
            this.label17.Text = "Direccion:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(8, 61);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(34, 13);
            this.label14.TabIndex = 18;
            this.label14.Text = "Sexo:";
            // 
            // txtdireccion_apo
            // 
            this.txtdireccion_apo.Location = new System.Drawing.Point(490, 78);
            this.txtdireccion_apo.Name = "txtdireccion_apo";
            this.txtdireccion_apo.Size = new System.Drawing.Size(318, 20);
            this.txtdireccion_apo.TabIndex = 19;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtgradoseccion);
            this.groupBox3.Controls.Add(this.txtnivelacademico);
            this.groupBox3.Controls.Add(this.label22);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Controls.Add(this.cboesrepitente);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.txtinstitucionprocedencia);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Location = new System.Drawing.Point(9, 33);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(816, 67);
            this.groupBox3.TabIndex = 31;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos Academicos";
            // 
            // txtgradoseccion
            // 
            this.txtgradoseccion.Location = new System.Drawing.Point(562, 33);
            this.txtgradoseccion.Name = "txtgradoseccion";
            this.txtgradoseccion.ReadOnly = true;
            this.txtgradoseccion.Size = new System.Drawing.Size(152, 20);
            this.txtgradoseccion.TabIndex = 100;
            // 
            // txtnivelacademico
            // 
            this.txtnivelacademico.Location = new System.Drawing.Point(387, 33);
            this.txtnivelacademico.Name = "txtnivelacademico";
            this.txtnivelacademico.ReadOnly = true;
            this.txtnivelacademico.Size = new System.Drawing.Size(152, 20);
            this.txtnivelacademico.TabIndex = 100;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(559, 15);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(81, 13);
            this.label22.TabIndex = 6;
            this.label22.Text = "Grado Sección:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(384, 16);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(90, 13);
            this.label21.TabIndex = 4;
            this.label21.Text = "Nivel Academico:";
            // 
            // cboesrepitente
            // 
            this.cboesrepitente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboesrepitente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboesrepitente.FormattingEnabled = true;
            this.cboesrepitente.Location = new System.Drawing.Point(224, 32);
            this.cboesrepitente.Name = "cboesrepitente";
            this.cboesrepitente.Size = new System.Drawing.Size(150, 21);
            this.cboesrepitente.TabIndex = 3;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(224, 16);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(71, 13);
            this.label20.TabIndex = 2;
            this.label20.Text = "Es Repitente:";
            // 
            // txtinstitucionprocedencia
            // 
            this.txtinstitucionprocedencia.Location = new System.Drawing.Point(8, 33);
            this.txtinstitucionprocedencia.Name = "txtinstitucionprocedencia";
            this.txtinstitucionprocedencia.Size = new System.Drawing.Size(202, 20);
            this.txtinstitucionprocedencia.TabIndex = 2;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(7, 17);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(120, 13);
            this.label19.TabIndex = 0;
            this.label19.Text = "Institución procedencia:";
            // 
            // btnregistrar
            // 
            this.btnregistrar.BackColor = System.Drawing.Color.Green;
            this.btnregistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnregistrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnregistrar.ForeColor = System.Drawing.Color.White;
            this.btnregistrar.Location = new System.Drawing.Point(555, 334);
            this.btnregistrar.Name = "btnregistrar";
            this.btnregistrar.Size = new System.Drawing.Size(160, 23);
            this.btnregistrar.TabIndex = 32;
            this.btnregistrar.Text = "Registrar Matricula";
            this.btnregistrar.UseVisualStyleBackColor = false;
            this.btnregistrar.Click += new System.EventHandler(this.btnregistrar_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.BackColor = System.Drawing.Color.Red;
            this.btnsalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsalir.ForeColor = System.Drawing.Color.White;
            this.btnsalir.Location = new System.Drawing.Point(721, 334);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(104, 23);
            this.btnsalir.TabIndex = 33;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = false;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // frmRegistrarMatricula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(832, 369);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnregistrar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbosituacion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtcodigomatricula);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmRegistrarMatricula";
            this.Text = "Crear Matricula";
            this.Load += new System.EventHandler(this.frmRegistrarMatricula_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcodigomatricula;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbosituacion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbosexo_alu;
        private System.Windows.Forms.DateTimePicker txtfechanacimiento_alu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtciudad_alu;
        private System.Windows.Forms.TextBox txtdireccion_alu;
        private System.Windows.Forms.TextBox txtnombres_alu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtapellidos_alu;
        private System.Windows.Forms.TextBox txtdocumentoidentidad_alu;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtidalumno;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtdocumentoidentidad_apo;
        private System.Windows.Forms.ComboBox cbotiporelacion_apo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtapellidos_apo;
        private System.Windows.Forms.TextBox txtnombres_apo;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cboestadocivil_apo;
        private System.Windows.Forms.ComboBox cbosexo_apo;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DateTimePicker txtfechanacimiento_apo;
        private System.Windows.Forms.TextBox txtciudad_apo;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtdireccion_apo;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox cboesrepitente;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtinstitucionprocedencia;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtgradoseccion;
        private System.Windows.Forms.TextBox txtnivelacademico;
        private System.Windows.Forms.Button btnregistrar;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Button btnsalir;
    }
}