namespace Proyecto
{
    partial class Form_Agregar_Funcionario
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
            this.btn_Volver = new System.Windows.Forms.Button();
            this.tbc_Agregar_Funcionario = new System.Windows.Forms.TabControl();
            this.tabP_Datos_Personales = new System.Windows.Forms.TabPage();
            this.cbox_IdDispositivo = new System.Windows.Forms.ComboBox();
            this.btn_Registro = new System.Windows.Forms.Button();
            this.cbox_Tipo_Cargo = new System.Windows.Forms.ComboBox();
            this.cbox_Tipo_Contrato = new System.Windows.Forms.ComboBox();
            this.lbl_Id_Dispositivo = new System.Windows.Forms.Label();
            this.lbl_Id_Unidad = new System.Windows.Forms.Label();
            this.lbl_Cargo = new System.Windows.Forms.Label();
            this.lbl_Tipo_Contrato = new System.Windows.Forms.Label();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.txt_Apellido_Materno = new System.Windows.Forms.TextBox();
            this.lbl_Apellido_Materno = new System.Windows.Forms.Label();
            this.txt_Apellido_Paterno = new System.Windows.Forms.TextBox();
            this.lbl_Apellido_Paterno = new System.Windows.Forms.Label();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.txt_Rut = new System.Windows.Forms.TextBox();
            this.lbl_Rut = new System.Windows.Forms.Label();
            this.tabP_Horarios = new System.Windows.Forms.TabPage();
            this.sgM1DataSet1 = new Proyecto.SGM1DataSet();
            this.lbl_IdHorarios = new System.Windows.Forms.Label();
            this.cbox_IdUnidad = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.lbl_Descripcion = new System.Windows.Forms.Label();
            this.lbl_lunes = new System.Windows.Forms.Label();
            this.lbl_Martes = new System.Windows.Forms.Label();
            this.lbl_Miercoles = new System.Windows.Forms.Label();
            this.lbl_Sabado = new System.Windows.Forms.Label();
            this.lbl_Jueves = new System.Windows.Forms.Label();
            this.lbl_Viernes = new System.Windows.Forms.Label();
            this.lbl_Domingo = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.textBox19 = new System.Windows.Forms.TextBox();
            this.textBox20 = new System.Windows.Forms.TextBox();
            this.textBox21 = new System.Windows.Forms.TextBox();
            this.textBox22 = new System.Windows.Forms.TextBox();
            this.textBox23 = new System.Windows.Forms.TextBox();
            this.textBox24 = new System.Windows.Forms.TextBox();
            this.textBox25 = new System.Windows.Forms.TextBox();
            this.textBox26 = new System.Windows.Forms.TextBox();
            this.textBox27 = new System.Windows.Forms.TextBox();
            this.textBox28 = new System.Windows.Forms.TextBox();
            this.lbl_Hora_Entrada_M = new System.Windows.Forms.Label();
            this.lbl_Hora_Salida_M = new System.Windows.Forms.Label();
            this.lbl_Hora_Entrada_T = new System.Windows.Forms.Label();
            this.lbl_Hora_Salida_T = new System.Windows.Forms.Label();
            this.txt_IdHorario = new System.Windows.Forms.TextBox();
            this.tbc_Agregar_Funcionario.SuspendLayout();
            this.tabP_Datos_Personales.SuspendLayout();
            this.tabP_Horarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sgM1DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Volver
            // 
            this.btn_Volver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Volver.Location = new System.Drawing.Point(12, 12);
            this.btn_Volver.Name = "btn_Volver";
            this.btn_Volver.Size = new System.Drawing.Size(94, 23);
            this.btn_Volver.TabIndex = 0;
            this.btn_Volver.Text = "Volver";
            this.btn_Volver.UseVisualStyleBackColor = true;
            this.btn_Volver.Click += new System.EventHandler(this.btn_Volver_Click);
            // 
            // tbc_Agregar_Funcionario
            // 
            this.tbc_Agregar_Funcionario.Controls.Add(this.tabP_Datos_Personales);
            this.tbc_Agregar_Funcionario.Controls.Add(this.tabP_Horarios);
            this.tbc_Agregar_Funcionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbc_Agregar_Funcionario.Location = new System.Drawing.Point(12, 72);
            this.tbc_Agregar_Funcionario.Name = "tbc_Agregar_Funcionario";
            this.tbc_Agregar_Funcionario.SelectedIndex = 0;
            this.tbc_Agregar_Funcionario.Size = new System.Drawing.Size(1081, 347);
            this.tbc_Agregar_Funcionario.TabIndex = 1;
            this.tbc_Agregar_Funcionario.Tag = "";
            // 
            // tabP_Datos_Personales
            // 
            this.tabP_Datos_Personales.BackColor = System.Drawing.Color.Silver;
            this.tabP_Datos_Personales.Controls.Add(this.cbox_IdUnidad);
            this.tabP_Datos_Personales.Controls.Add(this.cbox_IdDispositivo);
            this.tabP_Datos_Personales.Controls.Add(this.cbox_Tipo_Cargo);
            this.tabP_Datos_Personales.Controls.Add(this.cbox_Tipo_Contrato);
            this.tabP_Datos_Personales.Controls.Add(this.lbl_Id_Dispositivo);
            this.tabP_Datos_Personales.Controls.Add(this.lbl_Id_Unidad);
            this.tabP_Datos_Personales.Controls.Add(this.lbl_Cargo);
            this.tabP_Datos_Personales.Controls.Add(this.lbl_Tipo_Contrato);
            this.tabP_Datos_Personales.Controls.Add(this.txt_Email);
            this.tabP_Datos_Personales.Controls.Add(this.lbl_Email);
            this.tabP_Datos_Personales.Controls.Add(this.txt_Apellido_Materno);
            this.tabP_Datos_Personales.Controls.Add(this.lbl_Apellido_Materno);
            this.tabP_Datos_Personales.Controls.Add(this.txt_Apellido_Paterno);
            this.tabP_Datos_Personales.Controls.Add(this.lbl_Apellido_Paterno);
            this.tabP_Datos_Personales.Controls.Add(this.txt_Nombre);
            this.tabP_Datos_Personales.Controls.Add(this.lbl_Nombre);
            this.tabP_Datos_Personales.Controls.Add(this.txt_Rut);
            this.tabP_Datos_Personales.Controls.Add(this.lbl_Rut);
            this.tabP_Datos_Personales.Location = new System.Drawing.Point(4, 25);
            this.tabP_Datos_Personales.Name = "tabP_Datos_Personales";
            this.tabP_Datos_Personales.Padding = new System.Windows.Forms.Padding(3);
            this.tabP_Datos_Personales.Size = new System.Drawing.Size(1073, 318);
            this.tabP_Datos_Personales.TabIndex = 0;
            this.tabP_Datos_Personales.Text = "Datos Personales";
            // 
            // cbox_IdDispositivo
            // 
            this.cbox_IdDispositivo.FormattingEnabled = true;
            this.cbox_IdDispositivo.Items.AddRange(new object[] {
            "uFace800"});
            this.cbox_IdDispositivo.Location = new System.Drawing.Point(786, 242);
            this.cbox_IdDispositivo.Name = "cbox_IdDispositivo";
            this.cbox_IdDispositivo.Size = new System.Drawing.Size(176, 24);
            this.cbox_IdDispositivo.TabIndex = 22;
            this.cbox_IdDispositivo.SelectedIndexChanged += new System.EventHandler(this.cbox_IdDispositivo_SelectedIndexChanged);
            // 
            // btn_Registro
            // 
            this.btn_Registro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Registro.Location = new System.Drawing.Point(967, 32);
            this.btn_Registro.Name = "btn_Registro";
            this.btn_Registro.Size = new System.Drawing.Size(119, 34);
            this.btn_Registro.TabIndex = 2;
            this.btn_Registro.Text = "Registar Usuario";
            this.btn_Registro.UseVisualStyleBackColor = true;
            this.btn_Registro.Click += new System.EventHandler(this.btn_Registro_Click);
            // 
            // cbox_Tipo_Cargo
            // 
            this.cbox_Tipo_Cargo.FormattingEnabled = true;
            this.cbox_Tipo_Cargo.Items.AddRange(new object[] {
            "No configurado",
            "Administrativo",
            "Ingeniero en informática",
            "Desarrollador"});
            this.cbox_Tipo_Cargo.Location = new System.Drawing.Point(786, 38);
            this.cbox_Tipo_Cargo.Name = "cbox_Tipo_Cargo";
            this.cbox_Tipo_Cargo.Size = new System.Drawing.Size(176, 24);
            this.cbox_Tipo_Cargo.TabIndex = 21;
            this.cbox_Tipo_Cargo.SelectedIndexChanged += new System.EventHandler(this.cbox_Tipo_Cargo_SelectedIndexChanged);
            // 
            // cbox_Tipo_Contrato
            // 
            this.cbox_Tipo_Contrato.FormattingEnabled = true;
            this.cbox_Tipo_Contrato.Items.AddRange(new object[] {
            "Código del Trabajo",
            "Plazo Fijo",
            "Reemplazo",
            "Indefinidos",
            "Honorarios"});
            this.cbox_Tipo_Contrato.Location = new System.Drawing.Point(435, 242);
            this.cbox_Tipo_Contrato.Name = "cbox_Tipo_Contrato";
            this.cbox_Tipo_Contrato.Size = new System.Drawing.Size(176, 24);
            this.cbox_Tipo_Contrato.TabIndex = 20;
            this.cbox_Tipo_Contrato.SelectedIndexChanged += new System.EventHandler(this.cbox_Tipo_Contrato_SelectedIndexChanged);
            // 
            // lbl_Id_Dispositivo
            // 
            this.lbl_Id_Dispositivo.AutoSize = true;
            this.lbl_Id_Dispositivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Id_Dispositivo.Location = new System.Drawing.Point(783, 223);
            this.lbl_Id_Dispositivo.Name = "lbl_Id_Dispositivo";
            this.lbl_Id_Dispositivo.Size = new System.Drawing.Size(90, 16);
            this.lbl_Id_Dispositivo.TabIndex = 18;
            this.lbl_Id_Dispositivo.Text = "ID Dispositivo";
            // 
            // lbl_Id_Unidad
            // 
            this.lbl_Id_Unidad.AutoSize = true;
            this.lbl_Id_Unidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Id_Unidad.Location = new System.Drawing.Point(783, 118);
            this.lbl_Id_Unidad.Name = "lbl_Id_Unidad";
            this.lbl_Id_Unidad.Size = new System.Drawing.Size(67, 16);
            this.lbl_Id_Unidad.TabIndex = 16;
            this.lbl_Id_Unidad.Text = "ID Unidad";
            // 
            // lbl_Cargo
            // 
            this.lbl_Cargo.AutoSize = true;
            this.lbl_Cargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Cargo.Location = new System.Drawing.Point(783, 19);
            this.lbl_Cargo.Name = "lbl_Cargo";
            this.lbl_Cargo.Size = new System.Drawing.Size(94, 16);
            this.lbl_Cargo.TabIndex = 14;
            this.lbl_Cargo.Text = "Tipo de Cargo";
            // 
            // lbl_Tipo_Contrato
            // 
            this.lbl_Tipo_Contrato.AutoSize = true;
            this.lbl_Tipo_Contrato.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Tipo_Contrato.Location = new System.Drawing.Point(432, 223);
            this.lbl_Tipo_Contrato.Name = "lbl_Tipo_Contrato";
            this.lbl_Tipo_Contrato.Size = new System.Drawing.Size(109, 16);
            this.lbl_Tipo_Contrato.TabIndex = 12;
            this.lbl_Tipo_Contrato.Text = "Tipo De Contrato";
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(435, 137);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(176, 22);
            this.txt_Email.TabIndex = 11;
            this.txt_Email.TextChanged += new System.EventHandler(this.txt_Email_TextChanged);
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Email.Location = new System.Drawing.Point(432, 118);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(163, 16);
            this.lbl_Email.TabIndex = 10;
            this.lbl_Email.Text = "Correo Electronico (Email)";
            // 
            // txt_Apellido_Materno
            // 
            this.txt_Apellido_Materno.Location = new System.Drawing.Point(431, 40);
            this.txt_Apellido_Materno.Name = "txt_Apellido_Materno";
            this.txt_Apellido_Materno.Size = new System.Drawing.Size(176, 22);
            this.txt_Apellido_Materno.TabIndex = 7;
            // 
            // lbl_Apellido_Materno
            // 
            this.lbl_Apellido_Materno.AutoSize = true;
            this.lbl_Apellido_Materno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Apellido_Materno.Location = new System.Drawing.Point(428, 19);
            this.lbl_Apellido_Materno.Name = "lbl_Apellido_Materno";
            this.lbl_Apellido_Materno.Size = new System.Drawing.Size(109, 16);
            this.lbl_Apellido_Materno.TabIndex = 6;
            this.lbl_Apellido_Materno.Text = "Apellido Materno";
            // 
            // txt_Apellido_Paterno
            // 
            this.txt_Apellido_Paterno.Location = new System.Drawing.Point(73, 242);
            this.txt_Apellido_Paterno.Name = "txt_Apellido_Paterno";
            this.txt_Apellido_Paterno.Size = new System.Drawing.Size(168, 22);
            this.txt_Apellido_Paterno.TabIndex = 5;
            // 
            // lbl_Apellido_Paterno
            // 
            this.lbl_Apellido_Paterno.AutoSize = true;
            this.lbl_Apellido_Paterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Apellido_Paterno.Location = new System.Drawing.Point(70, 223);
            this.lbl_Apellido_Paterno.Name = "lbl_Apellido_Paterno";
            this.lbl_Apellido_Paterno.Size = new System.Drawing.Size(107, 16);
            this.lbl_Apellido_Paterno.TabIndex = 4;
            this.lbl_Apellido_Paterno.Text = "Apellido Paterno";
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(73, 137);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(168, 22);
            this.txt_Nombre.TabIndex = 3;
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nombre.Location = new System.Drawing.Point(70, 118);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(56, 16);
            this.lbl_Nombre.TabIndex = 2;
            this.lbl_Nombre.Text = "Nombre";
            // 
            // txt_Rut
            // 
            this.txt_Rut.Location = new System.Drawing.Point(73, 40);
            this.txt_Rut.Name = "txt_Rut";
            this.txt_Rut.Size = new System.Drawing.Size(168, 22);
            this.txt_Rut.TabIndex = 1;
            this.txt_Rut.TextChanged += new System.EventHandler(this.txt_Rut_TextChanged);
            // 
            // lbl_Rut
            // 
            this.lbl_Rut.AutoSize = true;
            this.lbl_Rut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Rut.Location = new System.Drawing.Point(70, 21);
            this.lbl_Rut.Name = "lbl_Rut";
            this.lbl_Rut.Size = new System.Drawing.Size(27, 16);
            this.lbl_Rut.TabIndex = 0;
            this.lbl_Rut.Text = "Rut";
            // 
            // tabP_Horarios
            // 
            this.tabP_Horarios.BackColor = System.Drawing.Color.LightGray;
            this.tabP_Horarios.Controls.Add(this.txt_IdHorario);
            this.tabP_Horarios.Controls.Add(this.lbl_Hora_Salida_T);
            this.tabP_Horarios.Controls.Add(this.lbl_Hora_Entrada_T);
            this.tabP_Horarios.Controls.Add(this.lbl_Hora_Salida_M);
            this.tabP_Horarios.Controls.Add(this.lbl_Hora_Entrada_M);
            this.tabP_Horarios.Controls.Add(this.textBox22);
            this.tabP_Horarios.Controls.Add(this.textBox23);
            this.tabP_Horarios.Controls.Add(this.textBox24);
            this.tabP_Horarios.Controls.Add(this.textBox25);
            this.tabP_Horarios.Controls.Add(this.textBox26);
            this.tabP_Horarios.Controls.Add(this.textBox27);
            this.tabP_Horarios.Controls.Add(this.textBox28);
            this.tabP_Horarios.Controls.Add(this.textBox15);
            this.tabP_Horarios.Controls.Add(this.textBox16);
            this.tabP_Horarios.Controls.Add(this.textBox17);
            this.tabP_Horarios.Controls.Add(this.textBox18);
            this.tabP_Horarios.Controls.Add(this.textBox19);
            this.tabP_Horarios.Controls.Add(this.textBox20);
            this.tabP_Horarios.Controls.Add(this.textBox21);
            this.tabP_Horarios.Controls.Add(this.textBox8);
            this.tabP_Horarios.Controls.Add(this.textBox9);
            this.tabP_Horarios.Controls.Add(this.textBox10);
            this.tabP_Horarios.Controls.Add(this.textBox11);
            this.tabP_Horarios.Controls.Add(this.textBox12);
            this.tabP_Horarios.Controls.Add(this.textBox13);
            this.tabP_Horarios.Controls.Add(this.textBox14);
            this.tabP_Horarios.Controls.Add(this.textBox7);
            this.tabP_Horarios.Controls.Add(this.textBox6);
            this.tabP_Horarios.Controls.Add(this.textBox5);
            this.tabP_Horarios.Controls.Add(this.textBox4);
            this.tabP_Horarios.Controls.Add(this.textBox3);
            this.tabP_Horarios.Controls.Add(this.textBox2);
            this.tabP_Horarios.Controls.Add(this.textBox1);
            this.tabP_Horarios.Controls.Add(this.lbl_Domingo);
            this.tabP_Horarios.Controls.Add(this.lbl_Viernes);
            this.tabP_Horarios.Controls.Add(this.lbl_Jueves);
            this.tabP_Horarios.Controls.Add(this.lbl_Sabado);
            this.tabP_Horarios.Controls.Add(this.lbl_Miercoles);
            this.tabP_Horarios.Controls.Add(this.lbl_Martes);
            this.tabP_Horarios.Controls.Add(this.lbl_lunes);
            this.tabP_Horarios.Controls.Add(this.comboBox3);
            this.tabP_Horarios.Controls.Add(this.lbl_Descripcion);
            this.tabP_Horarios.Controls.Add(this.lbl_IdHorarios);
            this.tabP_Horarios.Location = new System.Drawing.Point(4, 25);
            this.tabP_Horarios.Name = "tabP_Horarios";
            this.tabP_Horarios.Padding = new System.Windows.Forms.Padding(3);
            this.tabP_Horarios.Size = new System.Drawing.Size(1073, 318);
            this.tabP_Horarios.TabIndex = 1;
            this.tabP_Horarios.Text = "Horarios";
            // 
            // sgM1DataSet1
            // 
            this.sgM1DataSet1.DataSetName = "SGM1DataSet";
            this.sgM1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lbl_IdHorarios
            // 
            this.lbl_IdHorarios.AutoSize = true;
            this.lbl_IdHorarios.Location = new System.Drawing.Point(26, 36);
            this.lbl_IdHorarios.Name = "lbl_IdHorarios";
            this.lbl_IdHorarios.Size = new System.Drawing.Size(147, 16);
            this.lbl_IdHorarios.TabIndex = 0;
            this.lbl_IdHorarios.Text = "ID del horario asignado";
            // 
            // cbox_IdUnidad
            // 
            this.cbox_IdUnidad.FormattingEnabled = true;
            this.cbox_IdUnidad.Items.AddRange(new object[] {
            "Adminitración",
            "Remuneraciones",
            "Adquisciones",
            "Movilización",
            "Mantención",
            "Tesorería",
            "INFORMATICA",
            "D.A.S.M.",
            "CECOSF MILLALEMU",
            "CENTRO DE ESTERILIZACION",
            "CENTRO PODOLOGICO SUR",
            "CESFAM LA GRANJA",
            "CESFAM MALAQUIAS CONCHA",
            "CESFAM PADRE ESTEBAN GUMUSCIO",
            "CONST PADRE ESTEBAN GUMUCIO",
            "COSAM",
            "DIRECCION DE SALUD",
            "DROGUERIA",
            "HIPOTERAPIA",
            "PODOLOGICO GRANJA",
            "SAPU DENTAL",
            "UAPO",
            "CENTRO SALUD MENTAL",
            "CONST. PADRE ESTEBAN GUMUCIO",
            "CECOSF SAN GREGORIO",
            "PROMOCION DE SALUD",
            "AMBULANCIAS Y CONSULTORIOS",
            "CECOSF YUNGAY ",
            "CCR VIDA BUENA",
            "DROGUERÍA",
            "CCR SAN GREGORIO",
            "CECOSF VILLA LA SERENA",
            "CESFAM GRANJA SUR",
            "CCR LA GRANJA",
            "FARMACIA COMUNAL",
            "CESFAM PADRE ESTEBAN GUMUCIO"});
            this.cbox_IdUnidad.Location = new System.Drawing.Point(786, 137);
            this.cbox_IdUnidad.Name = "cbox_IdUnidad";
            this.cbox_IdUnidad.Size = new System.Drawing.Size(176, 24);
            this.cbox_IdUnidad.TabIndex = 23;
            this.cbox_IdUnidad.SelectedIndexChanged += new System.EventHandler(this.cbox_IdUnidad_SelectedIndexChanged);
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(211, 55);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(148, 24);
            this.comboBox3.TabIndex = 3;
            // 
            // lbl_Descripcion
            // 
            this.lbl_Descripcion.AutoSize = true;
            this.lbl_Descripcion.Location = new System.Drawing.Point(208, 36);
            this.lbl_Descripcion.Name = "lbl_Descripcion";
            this.lbl_Descripcion.Size = new System.Drawing.Size(59, 16);
            this.lbl_Descripcion.TabIndex = 2;
            this.lbl_Descripcion.Text = "Horarios\r\n";
            // 
            // lbl_lunes
            // 
            this.lbl_lunes.AutoSize = true;
            this.lbl_lunes.Location = new System.Drawing.Point(23, 149);
            this.lbl_lunes.Name = "lbl_lunes";
            this.lbl_lunes.Size = new System.Drawing.Size(43, 16);
            this.lbl_lunes.TabIndex = 4;
            this.lbl_lunes.Text = "Lunes";
            // 
            // lbl_Martes
            // 
            this.lbl_Martes.AutoSize = true;
            this.lbl_Martes.Location = new System.Drawing.Point(147, 149);
            this.lbl_Martes.Name = "lbl_Martes";
            this.lbl_Martes.Size = new System.Drawing.Size(48, 16);
            this.lbl_Martes.TabIndex = 5;
            this.lbl_Martes.Text = "Martes";
            // 
            // lbl_Miercoles
            // 
            this.lbl_Miercoles.AutoSize = true;
            this.lbl_Miercoles.Location = new System.Drawing.Point(273, 149);
            this.lbl_Miercoles.Name = "lbl_Miercoles";
            this.lbl_Miercoles.Size = new System.Drawing.Size(66, 16);
            this.lbl_Miercoles.TabIndex = 6;
            this.lbl_Miercoles.Text = "Miercoles";
            // 
            // lbl_Sabado
            // 
            this.lbl_Sabado.AutoSize = true;
            this.lbl_Sabado.Location = new System.Drawing.Point(651, 149);
            this.lbl_Sabado.Name = "lbl_Sabado";
            this.lbl_Sabado.Size = new System.Drawing.Size(56, 16);
            this.lbl_Sabado.TabIndex = 7;
            this.lbl_Sabado.Text = "Sabado";
            // 
            // lbl_Jueves
            // 
            this.lbl_Jueves.AutoSize = true;
            this.lbl_Jueves.Location = new System.Drawing.Point(399, 149);
            this.lbl_Jueves.Name = "lbl_Jueves";
            this.lbl_Jueves.Size = new System.Drawing.Size(51, 16);
            this.lbl_Jueves.TabIndex = 7;
            this.lbl_Jueves.Text = "Jueves";
            // 
            // lbl_Viernes
            // 
            this.lbl_Viernes.AutoSize = true;
            this.lbl_Viernes.Location = new System.Drawing.Point(525, 149);
            this.lbl_Viernes.Name = "lbl_Viernes";
            this.lbl_Viernes.Size = new System.Drawing.Size(53, 16);
            this.lbl_Viernes.TabIndex = 8;
            this.lbl_Viernes.Text = "Viernes";
            // 
            // lbl_Domingo
            // 
            this.lbl_Domingo.AutoSize = true;
            this.lbl_Domingo.Location = new System.Drawing.Point(780, 149);
            this.lbl_Domingo.Name = "lbl_Domingo";
            this.lbl_Domingo.Size = new System.Drawing.Size(62, 16);
            this.lbl_Domingo.TabIndex = 9;
            this.lbl_Domingo.Text = "Domingo";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(23, 168);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(118, 22);
            this.textBox1.TabIndex = 10;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(147, 168);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(120, 22);
            this.textBox2.TabIndex = 11;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(273, 168);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(120, 22);
            this.textBox3.TabIndex = 12;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(399, 168);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(120, 22);
            this.textBox4.TabIndex = 13;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(525, 168);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(120, 22);
            this.textBox5.TabIndex = 14;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(651, 168);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(120, 22);
            this.textBox6.TabIndex = 15;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(777, 168);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(120, 22);
            this.textBox7.TabIndex = 16;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(777, 196);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(120, 22);
            this.textBox8.TabIndex = 23;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(651, 196);
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.Size = new System.Drawing.Size(120, 22);
            this.textBox9.TabIndex = 22;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(525, 196);
            this.textBox10.Name = "textBox10";
            this.textBox10.ReadOnly = true;
            this.textBox10.Size = new System.Drawing.Size(120, 22);
            this.textBox10.TabIndex = 21;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(399, 196);
            this.textBox11.Name = "textBox11";
            this.textBox11.ReadOnly = true;
            this.textBox11.Size = new System.Drawing.Size(120, 22);
            this.textBox11.TabIndex = 20;
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(273, 196);
            this.textBox12.Name = "textBox12";
            this.textBox12.ReadOnly = true;
            this.textBox12.Size = new System.Drawing.Size(120, 22);
            this.textBox12.TabIndex = 19;
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(147, 196);
            this.textBox13.Name = "textBox13";
            this.textBox13.ReadOnly = true;
            this.textBox13.Size = new System.Drawing.Size(120, 22);
            this.textBox13.TabIndex = 18;
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(23, 196);
            this.textBox14.Name = "textBox14";
            this.textBox14.ReadOnly = true;
            this.textBox14.Size = new System.Drawing.Size(118, 22);
            this.textBox14.TabIndex = 17;
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(777, 224);
            this.textBox15.Name = "textBox15";
            this.textBox15.ReadOnly = true;
            this.textBox15.Size = new System.Drawing.Size(120, 22);
            this.textBox15.TabIndex = 30;
            // 
            // textBox16
            // 
            this.textBox16.Location = new System.Drawing.Point(651, 224);
            this.textBox16.Name = "textBox16";
            this.textBox16.ReadOnly = true;
            this.textBox16.Size = new System.Drawing.Size(120, 22);
            this.textBox16.TabIndex = 29;
            // 
            // textBox17
            // 
            this.textBox17.Location = new System.Drawing.Point(525, 224);
            this.textBox17.Name = "textBox17";
            this.textBox17.ReadOnly = true;
            this.textBox17.Size = new System.Drawing.Size(120, 22);
            this.textBox17.TabIndex = 28;
            // 
            // textBox18
            // 
            this.textBox18.Location = new System.Drawing.Point(399, 224);
            this.textBox18.Name = "textBox18";
            this.textBox18.ReadOnly = true;
            this.textBox18.Size = new System.Drawing.Size(120, 22);
            this.textBox18.TabIndex = 27;
            // 
            // textBox19
            // 
            this.textBox19.Location = new System.Drawing.Point(273, 224);
            this.textBox19.Name = "textBox19";
            this.textBox19.ReadOnly = true;
            this.textBox19.Size = new System.Drawing.Size(120, 22);
            this.textBox19.TabIndex = 26;
            // 
            // textBox20
            // 
            this.textBox20.Location = new System.Drawing.Point(147, 224);
            this.textBox20.Name = "textBox20";
            this.textBox20.ReadOnly = true;
            this.textBox20.Size = new System.Drawing.Size(120, 22);
            this.textBox20.TabIndex = 25;
            // 
            // textBox21
            // 
            this.textBox21.Location = new System.Drawing.Point(23, 224);
            this.textBox21.Name = "textBox21";
            this.textBox21.ReadOnly = true;
            this.textBox21.Size = new System.Drawing.Size(118, 22);
            this.textBox21.TabIndex = 24;
            // 
            // textBox22
            // 
            this.textBox22.Location = new System.Drawing.Point(777, 252);
            this.textBox22.Name = "textBox22";
            this.textBox22.ReadOnly = true;
            this.textBox22.Size = new System.Drawing.Size(120, 22);
            this.textBox22.TabIndex = 37;
            // 
            // textBox23
            // 
            this.textBox23.Location = new System.Drawing.Point(651, 252);
            this.textBox23.Name = "textBox23";
            this.textBox23.ReadOnly = true;
            this.textBox23.Size = new System.Drawing.Size(120, 22);
            this.textBox23.TabIndex = 36;
            // 
            // textBox24
            // 
            this.textBox24.Location = new System.Drawing.Point(525, 252);
            this.textBox24.Name = "textBox24";
            this.textBox24.ReadOnly = true;
            this.textBox24.Size = new System.Drawing.Size(120, 22);
            this.textBox24.TabIndex = 35;
            // 
            // textBox25
            // 
            this.textBox25.Location = new System.Drawing.Point(399, 252);
            this.textBox25.Name = "textBox25";
            this.textBox25.ReadOnly = true;
            this.textBox25.Size = new System.Drawing.Size(120, 22);
            this.textBox25.TabIndex = 34;
            // 
            // textBox26
            // 
            this.textBox26.Location = new System.Drawing.Point(273, 252);
            this.textBox26.Name = "textBox26";
            this.textBox26.ReadOnly = true;
            this.textBox26.Size = new System.Drawing.Size(120, 22);
            this.textBox26.TabIndex = 33;
            // 
            // textBox27
            // 
            this.textBox27.Location = new System.Drawing.Point(147, 252);
            this.textBox27.Name = "textBox27";
            this.textBox27.ReadOnly = true;
            this.textBox27.Size = new System.Drawing.Size(120, 22);
            this.textBox27.TabIndex = 32;
            // 
            // textBox28
            // 
            this.textBox28.Location = new System.Drawing.Point(23, 252);
            this.textBox28.Name = "textBox28";
            this.textBox28.ReadOnly = true;
            this.textBox28.Size = new System.Drawing.Size(118, 22);
            this.textBox28.TabIndex = 31;
            // 
            // lbl_Hora_Entrada_M
            // 
            this.lbl_Hora_Entrada_M.AutoSize = true;
            this.lbl_Hora_Entrada_M.Location = new System.Drawing.Point(903, 171);
            this.lbl_Hora_Entrada_M.Name = "lbl_Hora_Entrada_M";
            this.lbl_Hora_Entrada_M.Size = new System.Drawing.Size(138, 16);
            this.lbl_Hora_Entrada_M.TabIndex = 38;
            this.lbl_Hora_Entrada_M.Text = "Entrada en la Mañana";
            // 
            // lbl_Hora_Salida_M
            // 
            this.lbl_Hora_Salida_M.AutoSize = true;
            this.lbl_Hora_Salida_M.Location = new System.Drawing.Point(903, 199);
            this.lbl_Hora_Salida_M.Name = "lbl_Hora_Salida_M";
            this.lbl_Hora_Salida_M.Size = new System.Drawing.Size(130, 16);
            this.lbl_Hora_Salida_M.TabIndex = 39;
            this.lbl_Hora_Salida_M.Text = "Salida en la Mañana";
            this.lbl_Hora_Salida_M.Click += new System.EventHandler(this.lbl_Hora_Salida_M_Click);
            // 
            // lbl_Hora_Entrada_T
            // 
            this.lbl_Hora_Entrada_T.AutoSize = true;
            this.lbl_Hora_Entrada_T.Location = new System.Drawing.Point(903, 227);
            this.lbl_Hora_Entrada_T.Name = "lbl_Hora_Entrada_T";
            this.lbl_Hora_Entrada_T.Size = new System.Drawing.Size(126, 16);
            this.lbl_Hora_Entrada_T.TabIndex = 40;
            this.lbl_Hora_Entrada_T.Text = "Entrada en la Tarde";
            // 
            // lbl_Hora_Salida_T
            // 
            this.lbl_Hora_Salida_T.AutoSize = true;
            this.lbl_Hora_Salida_T.Location = new System.Drawing.Point(903, 255);
            this.lbl_Hora_Salida_T.Name = "lbl_Hora_Salida_T";
            this.lbl_Hora_Salida_T.Size = new System.Drawing.Size(118, 16);
            this.lbl_Hora_Salida_T.TabIndex = 41;
            this.lbl_Hora_Salida_T.Text = "Salida en la Tarde";
            // 
            // txt_IdHorario
            // 
            this.txt_IdHorario.Location = new System.Drawing.Point(29, 57);
            this.txt_IdHorario.Name = "txt_IdHorario";
            this.txt_IdHorario.ReadOnly = true;
            this.txt_IdHorario.Size = new System.Drawing.Size(144, 22);
            this.txt_IdHorario.TabIndex = 42;
            // 
            // Form_Agregar_Funcionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 450);
            this.Controls.Add(this.tbc_Agregar_Funcionario);
            this.Controls.Add(this.btn_Volver);
            this.Controls.Add(this.btn_Registro);
            this.Name = "Form_Agregar_Funcionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Agregar_Funcionario";
            this.Load += new System.EventHandler(this.Form_Agregar_Funcionario_Load);
            this.tbc_Agregar_Funcionario.ResumeLayout(false);
            this.tabP_Datos_Personales.ResumeLayout(false);
            this.tabP_Datos_Personales.PerformLayout();
            this.tabP_Horarios.ResumeLayout(false);
            this.tabP_Horarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sgM1DataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Volver;
        private System.Windows.Forms.TabControl tbc_Agregar_Funcionario;
        private System.Windows.Forms.TabPage tabP_Datos_Personales;
        private System.Windows.Forms.TabPage tabP_Horarios;
        private System.Windows.Forms.TextBox txt_Apellido_Materno;
        private System.Windows.Forms.Label lbl_Apellido_Materno;
        private System.Windows.Forms.TextBox txt_Apellido_Paterno;
        private System.Windows.Forms.Label lbl_Apellido_Paterno;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.Label lbl_Nombre;
        private System.Windows.Forms.TextBox txt_Rut;
        private System.Windows.Forms.Label lbl_Rut;
        private System.Windows.Forms.Label lbl_Id_Unidad;
        private System.Windows.Forms.Label lbl_Cargo;
        private System.Windows.Forms.Label lbl_Tipo_Contrato;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.ComboBox cbox_Tipo_Contrato;
        private System.Windows.Forms.Label lbl_Id_Dispositivo;
        private System.Windows.Forms.ComboBox cbox_Tipo_Cargo;
        private System.Windows.Forms.Button btn_Registro;
        private System.Windows.Forms.ComboBox cbox_IdDispositivo;
        private System.Windows.Forms.Label lbl_IdHorarios;
        private SGM1DataSet sgM1DataSet1;
        private System.Windows.Forms.ComboBox cbox_IdUnidad;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label lbl_Descripcion;
        private System.Windows.Forms.Label lbl_Domingo;
        private System.Windows.Forms.Label lbl_Viernes;
        private System.Windows.Forms.Label lbl_Jueves;
        private System.Windows.Forms.Label lbl_Sabado;
        private System.Windows.Forms.Label lbl_Miercoles;
        private System.Windows.Forms.Label lbl_Martes;
        private System.Windows.Forms.Label lbl_lunes;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbl_Hora_Salida_T;
        private System.Windows.Forms.Label lbl_Hora_Entrada_T;
        private System.Windows.Forms.Label lbl_Hora_Salida_M;
        private System.Windows.Forms.Label lbl_Hora_Entrada_M;
        private System.Windows.Forms.TextBox textBox22;
        private System.Windows.Forms.TextBox textBox23;
        private System.Windows.Forms.TextBox textBox24;
        private System.Windows.Forms.TextBox textBox25;
        private System.Windows.Forms.TextBox textBox26;
        private System.Windows.Forms.TextBox textBox27;
        private System.Windows.Forms.TextBox textBox28;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.TextBox textBox17;
        private System.Windows.Forms.TextBox textBox18;
        private System.Windows.Forms.TextBox textBox19;
        private System.Windows.Forms.TextBox textBox20;
        private System.Windows.Forms.TextBox textBox21;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txt_IdHorario;
    }
}