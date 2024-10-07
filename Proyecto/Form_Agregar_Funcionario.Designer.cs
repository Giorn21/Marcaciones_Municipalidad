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
            this.cbox_IdUnidad = new System.Windows.Forms.ComboBox();
            this.cbox_IdDispositivo = new System.Windows.Forms.ComboBox();
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
            this.lbl_Horario_Titulo = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cbox_Horarios = new System.Windows.Forms.ComboBox();
            this.lbl_Asignar_Horario = new System.Windows.Forms.Label();
            this.btn_Registro = new System.Windows.Forms.Button();
            this.btn_Limpiar = new System.Windows.Forms.Button();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.lbl_FechaTiempoReal = new System.Windows.Forms.Label();
            this.lbl_Fecha = new System.Windows.Forms.Label();
            this.tbc_Agregar_Funcionario.SuspendLayout();
            this.tabP_Datos_Personales.SuspendLayout();
            this.tabP_Horarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Volver
            // 
            this.btn_Volver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Volver.Location = new System.Drawing.Point(12, 461);
            this.btn_Volver.Name = "btn_Volver";
            this.btn_Volver.Size = new System.Drawing.Size(74, 33);
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
            this.tbc_Agregar_Funcionario.Location = new System.Drawing.Point(12, 68);
            this.tbc_Agregar_Funcionario.Name = "tbc_Agregar_Funcionario";
            this.tbc_Agregar_Funcionario.SelectedIndex = 0;
            this.tbc_Agregar_Funcionario.Size = new System.Drawing.Size(1081, 378);
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
            this.tabP_Datos_Personales.Size = new System.Drawing.Size(1073, 349);
            this.tabP_Datos_Personales.TabIndex = 0;
            this.tabP_Datos_Personales.Text = "Datos Personales";
            // 
            // cbox_IdUnidad
            // 
            this.cbox_IdUnidad.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbox_IdUnidad.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbox_IdUnidad.FormattingEnabled = true;
            this.cbox_IdUnidad.Items.AddRange(new object[] {
            "Seleccione un dato"});
            this.cbox_IdUnidad.Location = new System.Drawing.Point(785, 151);
            this.cbox_IdUnidad.Name = "cbox_IdUnidad";
            this.cbox_IdUnidad.Size = new System.Drawing.Size(176, 24);
            this.cbox_IdUnidad.TabIndex = 23;
            this.cbox_IdUnidad.SelectedIndexChanged += new System.EventHandler(this.cbox_IdUnidad_SelectedIndexChanged);
            // 
            // cbox_IdDispositivo
            // 
            this.cbox_IdDispositivo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbox_IdDispositivo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbox_IdDispositivo.FormattingEnabled = true;
            this.cbox_IdDispositivo.Items.AddRange(new object[] {
            "Seleccione un dato"});
            this.cbox_IdDispositivo.Location = new System.Drawing.Point(785, 256);
            this.cbox_IdDispositivo.Name = "cbox_IdDispositivo";
            this.cbox_IdDispositivo.Size = new System.Drawing.Size(176, 24);
            this.cbox_IdDispositivo.TabIndex = 22;
            this.cbox_IdDispositivo.SelectedIndexChanged += new System.EventHandler(this.cbox_IdDispositivo_SelectedIndexChanged);
            // 
            // cbox_Tipo_Cargo
            // 
            this.cbox_Tipo_Cargo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbox_Tipo_Cargo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbox_Tipo_Cargo.FormattingEnabled = true;
            this.cbox_Tipo_Cargo.Items.AddRange(new object[] {
            "Seleccione un dato"});
            this.cbox_Tipo_Cargo.Location = new System.Drawing.Point(785, 52);
            this.cbox_Tipo_Cargo.Name = "cbox_Tipo_Cargo";
            this.cbox_Tipo_Cargo.Size = new System.Drawing.Size(176, 24);
            this.cbox_Tipo_Cargo.TabIndex = 21;
            this.cbox_Tipo_Cargo.SelectedIndexChanged += new System.EventHandler(this.cbox_Tipo_Cargo_SelectedIndexChanged);
            // 
            // cbox_Tipo_Contrato
            // 
            this.cbox_Tipo_Contrato.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbox_Tipo_Contrato.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbox_Tipo_Contrato.FormattingEnabled = true;
            this.cbox_Tipo_Contrato.Items.AddRange(new object[] {
            "Seleccione un dato"});
            this.cbox_Tipo_Contrato.Location = new System.Drawing.Point(434, 256);
            this.cbox_Tipo_Contrato.Name = "cbox_Tipo_Contrato";
            this.cbox_Tipo_Contrato.Size = new System.Drawing.Size(176, 24);
            this.cbox_Tipo_Contrato.TabIndex = 20;
            this.cbox_Tipo_Contrato.SelectedIndexChanged += new System.EventHandler(this.cbox_Tipo_Contrato_SelectedIndexChanged);
            // 
            // lbl_Id_Dispositivo
            // 
            this.lbl_Id_Dispositivo.AutoSize = true;
            this.lbl_Id_Dispositivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Id_Dispositivo.Location = new System.Drawing.Point(782, 237);
            this.lbl_Id_Dispositivo.Name = "lbl_Id_Dispositivo";
            this.lbl_Id_Dispositivo.Size = new System.Drawing.Size(90, 16);
            this.lbl_Id_Dispositivo.TabIndex = 18;
            this.lbl_Id_Dispositivo.Text = "ID Dispositivo";
            // 
            // lbl_Id_Unidad
            // 
            this.lbl_Id_Unidad.AutoSize = true;
            this.lbl_Id_Unidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Id_Unidad.Location = new System.Drawing.Point(782, 132);
            this.lbl_Id_Unidad.Name = "lbl_Id_Unidad";
            this.lbl_Id_Unidad.Size = new System.Drawing.Size(44, 16);
            this.lbl_Id_Unidad.TabIndex = 16;
            this.lbl_Id_Unidad.Text = "Cargo";
            // 
            // lbl_Cargo
            // 
            this.lbl_Cargo.AutoSize = true;
            this.lbl_Cargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Cargo.Location = new System.Drawing.Point(782, 33);
            this.lbl_Cargo.Name = "lbl_Cargo";
            this.lbl_Cargo.Size = new System.Drawing.Size(94, 16);
            this.lbl_Cargo.TabIndex = 14;
            this.lbl_Cargo.Text = "Tipo de Cargo";
            // 
            // lbl_Tipo_Contrato
            // 
            this.lbl_Tipo_Contrato.AutoSize = true;
            this.lbl_Tipo_Contrato.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Tipo_Contrato.Location = new System.Drawing.Point(431, 237);
            this.lbl_Tipo_Contrato.Name = "lbl_Tipo_Contrato";
            this.lbl_Tipo_Contrato.Size = new System.Drawing.Size(109, 16);
            this.lbl_Tipo_Contrato.TabIndex = 12;
            this.lbl_Tipo_Contrato.Text = "Tipo De Contrato";
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(434, 151);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(176, 22);
            this.txt_Email.TabIndex = 11;
            this.txt_Email.TextChanged += new System.EventHandler(this.txt_Email_TextChanged);
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Email.Location = new System.Drawing.Point(431, 132);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(163, 16);
            this.lbl_Email.TabIndex = 10;
            this.lbl_Email.Text = "Correo Electronico (Email)";
            // 
            // txt_Apellido_Materno
            // 
            this.txt_Apellido_Materno.Location = new System.Drawing.Point(430, 54);
            this.txt_Apellido_Materno.Name = "txt_Apellido_Materno";
            this.txt_Apellido_Materno.Size = new System.Drawing.Size(176, 22);
            this.txt_Apellido_Materno.TabIndex = 7;
            // 
            // lbl_Apellido_Materno
            // 
            this.lbl_Apellido_Materno.AutoSize = true;
            this.lbl_Apellido_Materno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Apellido_Materno.Location = new System.Drawing.Point(427, 33);
            this.lbl_Apellido_Materno.Name = "lbl_Apellido_Materno";
            this.lbl_Apellido_Materno.Size = new System.Drawing.Size(109, 16);
            this.lbl_Apellido_Materno.TabIndex = 6;
            this.lbl_Apellido_Materno.Text = "Apellido Materno";
            // 
            // txt_Apellido_Paterno
            // 
            this.txt_Apellido_Paterno.Location = new System.Drawing.Point(72, 256);
            this.txt_Apellido_Paterno.Name = "txt_Apellido_Paterno";
            this.txt_Apellido_Paterno.Size = new System.Drawing.Size(168, 22);
            this.txt_Apellido_Paterno.TabIndex = 5;
            // 
            // lbl_Apellido_Paterno
            // 
            this.lbl_Apellido_Paterno.AutoSize = true;
            this.lbl_Apellido_Paterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Apellido_Paterno.Location = new System.Drawing.Point(69, 237);
            this.lbl_Apellido_Paterno.Name = "lbl_Apellido_Paterno";
            this.lbl_Apellido_Paterno.Size = new System.Drawing.Size(107, 16);
            this.lbl_Apellido_Paterno.TabIndex = 4;
            this.lbl_Apellido_Paterno.Text = "Apellido Paterno";
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(72, 151);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(168, 22);
            this.txt_Nombre.TabIndex = 3;
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nombre.Location = new System.Drawing.Point(69, 132);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(56, 16);
            this.lbl_Nombre.TabIndex = 2;
            this.lbl_Nombre.Text = "Nombre";
            // 
            // txt_Rut
            // 
            this.txt_Rut.Location = new System.Drawing.Point(72, 54);
            this.txt_Rut.Name = "txt_Rut";
            this.txt_Rut.Size = new System.Drawing.Size(168, 22);
            this.txt_Rut.TabIndex = 1;
            this.txt_Rut.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Rut_KeyPress);
            // 
            // lbl_Rut
            // 
            this.lbl_Rut.AutoSize = true;
            this.lbl_Rut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Rut.Location = new System.Drawing.Point(69, 35);
            this.lbl_Rut.Name = "lbl_Rut";
            this.lbl_Rut.Size = new System.Drawing.Size(27, 16);
            this.lbl_Rut.TabIndex = 0;
            this.lbl_Rut.Text = "Rut";
            // 
            // tabP_Horarios
            // 
            this.tabP_Horarios.BackColor = System.Drawing.Color.LightGray;
            this.tabP_Horarios.Controls.Add(this.lbl_Horario_Titulo);
            this.tabP_Horarios.Controls.Add(this.dataGridView1);
            this.tabP_Horarios.Controls.Add(this.cbox_Horarios);
            this.tabP_Horarios.Controls.Add(this.lbl_Asignar_Horario);
            this.tabP_Horarios.Location = new System.Drawing.Point(4, 25);
            this.tabP_Horarios.Name = "tabP_Horarios";
            this.tabP_Horarios.Padding = new System.Windows.Forms.Padding(3);
            this.tabP_Horarios.Size = new System.Drawing.Size(1073, 349);
            this.tabP_Horarios.TabIndex = 1;
            this.tabP_Horarios.Text = "Horarios";
            this.tabP_Horarios.Click += new System.EventHandler(this.tabP_Horarios_Click);
            // 
            // lbl_Horario_Titulo
            // 
            this.lbl_Horario_Titulo.AutoSize = true;
            this.lbl_Horario_Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Horario_Titulo.Location = new System.Drawing.Point(290, 11);
            this.lbl_Horario_Titulo.Name = "lbl_Horario_Titulo";
            this.lbl_Horario_Titulo.Size = new System.Drawing.Size(103, 31);
            this.lbl_Horario_Titulo.TabIndex = 44;
            this.lbl_Horario_Titulo.Text = "Horario";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(290, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(743, 254);
            this.dataGridView1.TabIndex = 43;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // cbox_Horarios
            // 
            this.cbox_Horarios.FormattingEnabled = true;
            this.cbox_Horarios.Location = new System.Drawing.Point(24, 35);
            this.cbox_Horarios.Name = "cbox_Horarios";
            this.cbox_Horarios.Size = new System.Drawing.Size(242, 24);
            this.cbox_Horarios.TabIndex = 3;
            this.cbox_Horarios.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // lbl_Asignar_Horario
            // 
            this.lbl_Asignar_Horario.AutoSize = true;
            this.lbl_Asignar_Horario.Location = new System.Drawing.Point(21, 16);
            this.lbl_Asignar_Horario.Name = "lbl_Asignar_Horario";
            this.lbl_Asignar_Horario.Size = new System.Drawing.Size(101, 16);
            this.lbl_Asignar_Horario.TabIndex = 2;
            this.lbl_Asignar_Horario.Text = "Asignar Horario";
            this.lbl_Asignar_Horario.Click += new System.EventHandler(this.lbl_Asignar_Horario_Click);
            // 
            // btn_Registro
            // 
            this.btn_Registro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Registro.Location = new System.Drawing.Point(952, 460);
            this.btn_Registro.Name = "btn_Registro";
            this.btn_Registro.Size = new System.Drawing.Size(118, 34);
            this.btn_Registro.TabIndex = 2;
            this.btn_Registro.Text = "Registar Usuario";
            this.btn_Registro.UseVisualStyleBackColor = true;
            this.btn_Registro.Click += new System.EventHandler(this.btn_Registro_Click);
            // 
            // sgM1DataSet1
            // 
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Limpiar.Location = new System.Drawing.Point(855, 471);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.Size = new System.Drawing.Size(68, 23);
            this.btn_Limpiar.TabIndex = 3;
            this.btn_Limpiar.Text = "Limpar";
            this.btn_Limpiar.UseVisualStyleBackColor = true;
            this.btn_Limpiar.Click += new System.EventHandler(this.btn_Limpiar_Click);
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.Location = new System.Drawing.Point(440, 9);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(210, 31);
            this.lbl_Titulo.TabIndex = 4;
            this.lbl_Titulo.Text = "Ingresar usuario";
            // 
            // lbl_FechaTiempoReal
            // 
            this.lbl_FechaTiempoReal.AutoSize = true;
            this.lbl_FechaTiempoReal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FechaTiempoReal.Location = new System.Drawing.Point(960, 49);
            this.lbl_FechaTiempoReal.Name = "lbl_FechaTiempoReal";
            this.lbl_FechaTiempoReal.Size = new System.Drawing.Size(75, 16);
            this.lbl_FechaTiempoReal.TabIndex = 5;
            this.lbl_FechaTiempoReal.Text = "date Fecha";
            // 
            // lbl_Fecha
            // 
            this.lbl_Fecha.AutoSize = true;
            this.lbl_Fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Fecha.Location = new System.Drawing.Point(959, 25);
            this.lbl_Fecha.Name = "lbl_Fecha";
            this.lbl_Fecha.Size = new System.Drawing.Size(64, 24);
            this.lbl_Fecha.TabIndex = 6;
            this.lbl_Fecha.Text = "Fecha";
            // 
            // Form_Agregar_Funcionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 506);
            this.Controls.Add(this.lbl_Fecha);
            this.Controls.Add(this.lbl_FechaTiempoReal);
            this.Controls.Add(this.lbl_Titulo);
            this.Controls.Add(this.btn_Volver);
            this.Controls.Add(this.btn_Limpiar);
            this.Controls.Add(this.tbc_Agregar_Funcionario);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.ComboBox cbox_IdUnidad;
        private System.Windows.Forms.ComboBox cbox_Horarios;
        private System.Windows.Forms.Label lbl_Asignar_Horario;
        private System.Windows.Forms.Button btn_Limpiar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbl_Horario_Titulo;
        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.Label lbl_FechaTiempoReal;
        private System.Windows.Forms.Label lbl_Fecha;
    }
}