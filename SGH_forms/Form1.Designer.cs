namespace SGH_forms
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvPacientes = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.cmbSexo = new System.Windows.Forms.ComboBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tvMedicos = new System.Windows.Forms.TreeView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRegistrarMedico = new System.Windows.Forms.Button();
            this.cmbEspecialidad = new System.Windows.Forms.ComboBox();
            this.txtNombreMedico = new System.Windows.Forms.TextBox();
            this.txtCodigoMedico = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvCitas = new System.Windows.Forms.DataGridView();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRegistrarCita = new System.Windows.Forms.Button();
            this.dtpFechaCita = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbMedicoCita = new System.Windows.Forms.ComboBox();
            this.lblNombrePacienteCita = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnBuscarPacienteCita = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDniCita = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lstColaEspera = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnGuardarTriaje = new System.Windows.Forms.Button();
            this.txtTemperatura = new System.Windows.Forms.TextBox();
            this.txtPresion = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblPacienteEnTriaje = new System.Windows.Forms.Label();
            this.btnAtenderSiguiente = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.btnBuscarHistorial = new System.Windows.Forms.Button();
            this.txtDniHistorial = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.dgvHistorial = new System.Windows.Forms.DataGridView();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCitas)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(16, 15);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(987, 548);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = global::SGH_forms.Properties.Resources.gestion_de_pacientes;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dgvPacientes);
            this.tabPage1.Controls.Add(this.btnEliminar);
            this.tabPage1.Controls.Add(this.btnModificar);
            this.tabPage1.Controls.Add(this.btnBuscar);
            this.tabPage1.Controls.Add(this.btnRegistrar);
            this.tabPage1.Controls.Add(this.txtTelefono);
            this.tabPage1.Controls.Add(this.cmbSexo);
            this.tabPage1.Controls.Add(this.txtDni);
            this.tabPage1.Controls.Add(this.txtEdad);
            this.tabPage1.Controls.Add(this.txtNombre);
            this.tabPage1.Controls.Add(this.txtCodigo);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(979, 519);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Gestion de Pacientes";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.DarkGray;
            this.label6.Location = new System.Drawing.Point(63, 191);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Sexo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.DarkGray;
            this.label5.Location = new System.Drawing.Point(61, 158);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Telefono:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DarkGray;
            this.label4.Location = new System.Drawing.Point(61, 126);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "DNI:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkGray;
            this.label3.Location = new System.Drawing.Point(61, 94);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Edad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkGray;
            this.label2.Location = new System.Drawing.Point(61, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(61, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "ID de Registro:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dgvPacientes
            // 
            this.dgvPacientes.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPacientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column3,
            this.Column6,
            this.Column5});
            this.dgvPacientes.Location = new System.Drawing.Point(65, 234);
            this.dgvPacientes.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPacientes.Name = "dgvPacientes";
            this.dgvPacientes.RowHeadersWidth = 51;
            this.dgvPacientes.Size = new System.Drawing.Size(857, 261);
            this.dgvPacientes.TabIndex = 10;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "NOMBRE";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "DNI";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "EDAD";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "SEXO";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "TELEFONO";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.IndianRed;
            this.btnEliminar.Location = new System.Drawing.Point(697, 112);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(165, 54);
            this.btnEliminar.TabIndex = 9;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.DarkCyan;
            this.btnModificar.Location = new System.Drawing.Point(697, 26);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(165, 52);
            this.btnModificar.TabIndex = 8;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.DarkCyan;
            this.btnBuscar.Location = new System.Drawing.Point(479, 117);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(171, 49);
            this.btnBuscar.TabIndex = 7;
            this.btnBuscar.Text = "Buscar Por DNI";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.DarkCyan;
            this.btnRegistrar.Location = new System.Drawing.Point(479, 26);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(171, 52);
            this.btnRegistrar.TabIndex = 6;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(193, 149);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(249, 22);
            this.txtTelefono.TabIndex = 5;
            // 
            // cmbSexo
            // 
            this.cmbSexo.FormattingEnabled = true;
            this.cmbSexo.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.cmbSexo.Location = new System.Drawing.Point(193, 181);
            this.cmbSexo.Margin = new System.Windows.Forms.Padding(4);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(251, 24);
            this.cmbSexo.TabIndex = 4;
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(193, 117);
            this.txtDni.Margin = new System.Windows.Forms.Padding(4);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(249, 22);
            this.txtDni.TabIndex = 3;
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(193, 85);
            this.txtEdad.Margin = new System.Windows.Forms.Padding(4);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(249, 22);
            this.txtEdad.TabIndex = 2;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(193, 53);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(249, 22);
            this.txtNombre.TabIndex = 1;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(193, 22);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(249, 22);
            this.txtCodigo.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = global::SGH_forms.Properties.Resources.medicos;
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage2.Controls.Add(this.tvMedicos);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(979, 519);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Personal Medico";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tvMedicos
            // 
            this.tvMedicos.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tvMedicos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tvMedicos.Location = new System.Drawing.Point(412, 27);
            this.tvMedicos.Margin = new System.Windows.Forms.Padding(4);
            this.tvMedicos.Name = "tvMedicos";
            this.tvMedicos.Size = new System.Drawing.Size(445, 414);
            this.tvMedicos.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRegistrarMedico);
            this.groupBox1.Controls.Add(this.cmbEspecialidad);
            this.groupBox1.Controls.Add(this.txtNombreMedico);
            this.groupBox1.Controls.Add(this.txtCodigoMedico);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(24, 22);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(361, 266);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registro Medicos";
            // 
            // btnRegistrarMedico
            // 
            this.btnRegistrarMedico.BackColor = System.Drawing.Color.DarkCyan;
            this.btnRegistrarMedico.Location = new System.Drawing.Point(65, 170);
            this.btnRegistrarMedico.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegistrarMedico.Name = "btnRegistrarMedico";
            this.btnRegistrarMedico.Size = new System.Drawing.Size(191, 46);
            this.btnRegistrarMedico.TabIndex = 6;
            this.btnRegistrarMedico.Text = "Registrar Medico";
            this.btnRegistrarMedico.UseVisualStyleBackColor = false;
            this.btnRegistrarMedico.Click += new System.EventHandler(this.btnRegistrarMedico_Click);
            // 
            // cmbEspecialidad
            // 
            this.cmbEspecialidad.FormattingEnabled = true;
            this.cmbEspecialidad.Items.AddRange(new object[] {
            "Medicina Interna",
            "Pediatria",
            "Cardiologia",
            "Endocrinologia",
            "Cirugia General",
            "Obstetricia y Ginecologia",
            "Urologia",
            "Radiologia",
            "Patologia"});
            this.cmbEspecialidad.Location = new System.Drawing.Point(116, 98);
            this.cmbEspecialidad.Margin = new System.Windows.Forms.Padding(4);
            this.cmbEspecialidad.Name = "cmbEspecialidad";
            this.cmbEspecialidad.Size = new System.Drawing.Size(191, 24);
            this.cmbEspecialidad.TabIndex = 5;
            // 
            // txtNombreMedico
            // 
            this.txtNombreMedico.Location = new System.Drawing.Point(84, 57);
            this.txtNombreMedico.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreMedico.Name = "txtNombreMedico";
            this.txtNombreMedico.Size = new System.Drawing.Size(223, 22);
            this.txtNombreMedico.TabIndex = 4;
            // 
            // txtCodigoMedico
            // 
            this.txtCodigoMedico.Location = new System.Drawing.Point(65, 22);
            this.txtCodigoMedico.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigoMedico.Name = "txtCodigoMedico";
            this.txtCodigoMedico.Size = new System.Drawing.Size(241, 22);
            this.txtCodigoMedico.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.DarkGray;
            this.label9.Location = new System.Drawing.Point(13, 98);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 16);
            this.label9.TabIndex = 2;
            this.label9.Text = "Especialidad:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.DarkGray;
            this.label8.Location = new System.Drawing.Point(13, 65);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 16);
            this.label8.TabIndex = 1;
            this.label8.Text = "Nombre:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.DarkGray;
            this.label7.Location = new System.Drawing.Point(17, 31);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "ID:";
            // 
            // tabPage3
            // 
            this.tabPage3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage3.BackgroundImage")));
            this.tabPage3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage3.Size = new System.Drawing.Size(979, 519);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Citas Medicas";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvCitas);
            this.groupBox3.Location = new System.Drawing.Point(397, 32);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(591, 433);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Citas Cronologicas";
            // 
            // dgvCitas
            // 
            this.dgvCitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCitas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10});
            this.dgvCitas.Location = new System.Drawing.Point(12, 43);
            this.dgvCitas.Margin = new System.Windows.Forms.Padding(4);
            this.dgvCitas.Name = "dgvCitas";
            this.dgvCitas.RowHeadersWidth = 51;
            this.dgvCitas.Size = new System.Drawing.Size(559, 370);
            this.dgvCitas.TabIndex = 0;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Ticket";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 125;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Paciente";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.Width = 125;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Medico";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.Width = 125;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Fecha/Hora";
            this.Column10.MinimumWidth = 6;
            this.Column10.Name = "Column10";
            this.Column10.Width = 125;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRegistrarCita);
            this.groupBox2.Controls.Add(this.dtpFechaCita);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.cmbMedicoCita);
            this.groupBox2.Controls.Add(this.lblNombrePacienteCita);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.btnBuscarPacienteCita);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtDniCita);
            this.groupBox2.Location = new System.Drawing.Point(8, 32);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(381, 433);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Programar Nueva Cita:";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btnRegistrarCita
            // 
            this.btnRegistrarCita.BackColor = System.Drawing.Color.DarkCyan;
            this.btnRegistrarCita.Location = new System.Drawing.Point(111, 288);
            this.btnRegistrarCita.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegistrarCita.Name = "btnRegistrarCita";
            this.btnRegistrarCita.Size = new System.Drawing.Size(193, 54);
            this.btnRegistrarCita.TabIndex = 8;
            this.btnRegistrarCita.Text = "Generar Cita/Ticket";
            this.btnRegistrarCita.UseVisualStyleBackColor = false;
            this.btnRegistrarCita.Click += new System.EventHandler(this.btnRegistrarCita_Click);
            // 
            // dtpFechaCita
            // 
            this.dtpFechaCita.Location = new System.Drawing.Point(111, 242);
            this.dtpFechaCita.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechaCita.Name = "dtpFechaCita";
            this.dtpFechaCita.Size = new System.Drawing.Size(257, 22);
            this.dtpFechaCita.TabIndex = 7;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.DarkGray;
            this.label13.Location = new System.Drawing.Point(8, 186);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(93, 16);
            this.label13.TabIndex = 6;
            this.label13.Text = "Medicos Disp:";
            // 
            // cmbMedicoCita
            // 
            this.cmbMedicoCita.FormattingEnabled = true;
            this.cmbMedicoCita.Location = new System.Drawing.Point(115, 186);
            this.cmbMedicoCita.Margin = new System.Windows.Forms.Padding(4);
            this.cmbMedicoCita.Name = "cmbMedicoCita";
            this.cmbMedicoCita.Size = new System.Drawing.Size(253, 24);
            this.cmbMedicoCita.TabIndex = 5;
            // 
            // lblNombrePacienteCita
            // 
            this.lblNombrePacienteCita.AutoSize = true;
            this.lblNombrePacienteCita.BackColor = System.Drawing.Color.Coral;
            this.lblNombrePacienteCita.Location = new System.Drawing.Point(92, 138);
            this.lblNombrePacienteCita.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombrePacienteCita.Name = "lblNombrePacienteCita";
            this.lblNombrePacienteCita.Size = new System.Drawing.Size(195, 16);
            this.lblNombrePacienteCita.TabIndex = 4;
            this.lblNombrePacienteCita.Text = "Paciente(NO SELECCIONADO)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(28, 160);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 16);
            this.label11.TabIndex = 3;
            // 
            // btnBuscarPacienteCita
            // 
            this.btnBuscarPacienteCita.BackColor = System.Drawing.Color.DarkCyan;
            this.btnBuscarPacienteCita.Location = new System.Drawing.Point(115, 75);
            this.btnBuscarPacienteCita.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarPacienteCita.Name = "btnBuscarPacienteCita";
            this.btnBuscarPacienteCita.Size = new System.Drawing.Size(171, 46);
            this.btnBuscarPacienteCita.TabIndex = 2;
            this.btnBuscarPacienteCita.Text = "Verificar Paciente";
            this.btnBuscarPacienteCita.UseVisualStyleBackColor = false;
            this.btnBuscarPacienteCita.Click += new System.EventHandler(this.btnBuscarPacienteCita_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.DarkGray;
            this.label10.Location = new System.Drawing.Point(8, 47);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 16);
            this.label10.TabIndex = 1;
            this.label10.Text = "Dni Paciente:";
            // 
            // txtDniCita
            // 
            this.txtDniCita.Location = new System.Drawing.Point(115, 43);
            this.txtDniCita.Margin = new System.Windows.Forms.Padding(4);
            this.txtDniCita.Name = "txtDniCita";
            this.txtDniCita.Size = new System.Drawing.Size(253, 22);
            this.txtDniCita.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.BackgroundImage = global::SGH_forms.Properties.Resources.Gemini_Generated_Image_z3duc7z3duc7z3du;
            this.tabPage4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage4.Controls.Add(this.groupBox5);
            this.tabPage4.Controls.Add(this.groupBox4);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage4.Size = new System.Drawing.Size(979, 519);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Emergencias";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lstColaEspera);
            this.groupBox5.Location = new System.Drawing.Point(505, 43);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox5.Size = new System.Drawing.Size(408, 336);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "SALA DE ESPERA";
            // 
            // lstColaEspera
            // 
            this.lstColaEspera.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lstColaEspera.FormattingEnabled = true;
            this.lstColaEspera.ItemHeight = 16;
            this.lstColaEspera.Location = new System.Drawing.Point(45, 37);
            this.lstColaEspera.Margin = new System.Windows.Forms.Padding(4);
            this.lstColaEspera.Name = "lstColaEspera";
            this.lstColaEspera.Size = new System.Drawing.Size(333, 276);
            this.lstColaEspera.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnGuardarTriaje);
            this.groupBox4.Controls.Add(this.txtTemperatura);
            this.groupBox4.Controls.Add(this.txtPresion);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.lblPacienteEnTriaje);
            this.groupBox4.Controls.Add(this.btnAtenderSiguiente);
            this.groupBox4.Location = new System.Drawing.Point(53, 43);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(373, 347);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Llamar paciente";
            // 
            // btnGuardarTriaje
            // 
            this.btnGuardarTriaje.BackColor = System.Drawing.Color.DarkCyan;
            this.btnGuardarTriaje.Location = new System.Drawing.Point(85, 218);
            this.btnGuardarTriaje.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardarTriaje.Name = "btnGuardarTriaje";
            this.btnGuardarTriaje.Size = new System.Drawing.Size(171, 48);
            this.btnGuardarTriaje.TabIndex = 6;
            this.btnGuardarTriaje.Text = "Enviar a Historial";
            this.btnGuardarTriaje.UseVisualStyleBackColor = false;
            this.btnGuardarTriaje.Click += new System.EventHandler(this.btnGuardarTriaje_Click);
            // 
            // txtTemperatura
            // 
            this.txtTemperatura.Location = new System.Drawing.Point(181, 143);
            this.txtTemperatura.Margin = new System.Windows.Forms.Padding(4);
            this.txtTemperatura.Name = "txtTemperatura";
            this.txtTemperatura.Size = new System.Drawing.Size(132, 22);
            this.txtTemperatura.TabIndex = 5;
            // 
            // txtPresion
            // 
            this.txtPresion.Location = new System.Drawing.Point(144, 108);
            this.txtPresion.Margin = new System.Windows.Forms.Padding(4);
            this.txtPresion.Name = "txtPresion";
            this.txtPresion.Size = new System.Drawing.Size(169, 22);
            this.txtPresion.TabIndex = 4;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.DarkGray;
            this.label14.Location = new System.Drawing.Point(29, 146);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(136, 16);
            this.label14.TabIndex = 3;
            this.label14.Text = "Ingrese Temperatura:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.DarkGray;
            this.label12.Location = new System.Drawing.Point(25, 108);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(104, 16);
            this.label12.TabIndex = 2;
            this.label12.Text = "Ingrese Presion:";
            // 
            // lblPacienteEnTriaje
            // 
            this.lblPacienteEnTriaje.AutoSize = true;
            this.lblPacienteEnTriaje.BackColor = System.Drawing.Color.LightCoral;
            this.lblPacienteEnTriaje.Location = new System.Drawing.Point(81, 66);
            this.lblPacienteEnTriaje.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPacienteEnTriaje.Name = "lblPacienteEnTriaje";
            this.lblPacienteEnTriaje.Size = new System.Drawing.Size(160, 16);
            this.lblPacienteEnTriaje.TabIndex = 1;
            this.lblPacienteEnTriaje.Text = "Atendiendo a: ( Ninguno ) ";
            // 
            // btnAtenderSiguiente
            // 
            this.btnAtenderSiguiente.BackColor = System.Drawing.Color.DarkCyan;
            this.btnAtenderSiguiente.Location = new System.Drawing.Point(79, 23);
            this.btnAtenderSiguiente.Margin = new System.Windows.Forms.Padding(4);
            this.btnAtenderSiguiente.Name = "btnAtenderSiguiente";
            this.btnAtenderSiguiente.Size = new System.Drawing.Size(177, 28);
            this.btnAtenderSiguiente.TabIndex = 0;
            this.btnAtenderSiguiente.Text = "LLAMAR PACIENTE";
            this.btnAtenderSiguiente.UseVisualStyleBackColor = false;
            this.btnAtenderSiguiente.Click += new System.EventHandler(this.btnAtenderSiguiente_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.BackgroundImage = global::SGH_forms.Properties.Resources.historial;
            this.tabPage5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage5.Controls.Add(this.btnBuscarHistorial);
            this.tabPage5.Controls.Add(this.txtDniHistorial);
            this.tabPage5.Controls.Add(this.label15);
            this.tabPage5.Controls.Add(this.dgvHistorial);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage5.Size = new System.Drawing.Size(979, 519);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Historial Clinico";
            this.tabPage5.UseVisualStyleBackColor = true;
            this.tabPage5.Click += new System.EventHandler(this.tabPage5_Click);
            // 
            // btnBuscarHistorial
            // 
            this.btnBuscarHistorial.BackColor = System.Drawing.Color.DarkCyan;
            this.btnBuscarHistorial.Location = new System.Drawing.Point(501, 16);
            this.btnBuscarHistorial.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarHistorial.Name = "btnBuscarHistorial";
            this.btnBuscarHistorial.Size = new System.Drawing.Size(156, 46);
            this.btnBuscarHistorial.TabIndex = 3;
            this.btnBuscarHistorial.Text = "BUSCAR ";
            this.btnBuscarHistorial.UseVisualStyleBackColor = false;
            this.btnBuscarHistorial.Click += new System.EventHandler(this.btnBuscarHistorial_Click);
            // 
            // txtDniHistorial
            // 
            this.txtDniHistorial.Location = new System.Drawing.Point(208, 28);
            this.txtDniHistorial.Margin = new System.Windows.Forms.Padding(4);
            this.txtDniHistorial.Name = "txtDniHistorial";
            this.txtDniHistorial.Size = new System.Drawing.Size(184, 22);
            this.txtDniHistorial.TabIndex = 2;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.DarkGray;
            this.label15.Location = new System.Drawing.Point(28, 31);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(159, 16);
            this.label15.TabIndex = 1;
            this.label15.Text = "Ingrese DNI del Paciente:";
            // 
            // dgvHistorial
            // 
            this.dgvHistorial.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistorial.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column11,
            this.Column12,
            this.Column13});
            this.dgvHistorial.Location = new System.Drawing.Point(32, 78);
            this.dgvHistorial.Margin = new System.Windows.Forms.Padding(4);
            this.dgvHistorial.Name = "dgvHistorial";
            this.dgvHistorial.RowHeadersWidth = 51;
            this.dgvHistorial.Size = new System.Drawing.Size(916, 416);
            this.dgvHistorial.TabIndex = 0;
            this.dgvHistorial.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHistorial_CellContentClick);
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Fecha/Hora";
            this.Column11.MinimumWidth = 6;
            this.Column11.Name = "Column11";
            this.Column11.Width = 215;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Presion";
            this.Column12.MinimumWidth = 6;
            this.Column12.Name = "Column12";
            this.Column12.Width = 215;
            // 
            // Column13
            // 
            this.Column13.HeaderText = "Temperatura";
            this.Column13.MinimumWidth = 6;
            this.Column13.Name = "Column13";
            this.Column13.Width = 215;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1019, 578);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "SISTEMA GESTION DE HOSPITAL";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCitas)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.ComboBox cmbSexo;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.DataGridView dgvPacientes;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbEspecialidad;
        private System.Windows.Forms.TextBox txtNombreMedico;
        private System.Windows.Forms.TextBox txtCodigoMedico;
        private System.Windows.Forms.Button btnRegistrarMedico;
        private System.Windows.Forms.TreeView tvMedicos;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtDniCita;
        private System.Windows.Forms.Button btnBuscarPacienteCita;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblNombrePacienteCita;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbMedicoCita;
        private System.Windows.Forms.Button btnRegistrarCita;
        private System.Windows.Forms.DateTimePicker dtpFechaCita;
        private System.Windows.Forms.DataGridView dgvCitas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtTemperatura;
        private System.Windows.Forms.TextBox txtPresion;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblPacienteEnTriaje;
        private System.Windows.Forms.Button btnAtenderSiguiente;
        private System.Windows.Forms.Button btnGuardarTriaje;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ListBox lstColaEspera;
        private System.Windows.Forms.DataGridView dgvHistorial;
        private System.Windows.Forms.TextBox txtDniHistorial;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnBuscarHistorial;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
    }
}

