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
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.lbl_FechaTiempoReal = new System.Windows.Forms.Label();
            this.lbl_Fecha = new System.Windows.Forms.Label();
            this.diseñoButton1 = new Proyecto.Resources.DiseñoButton();
            this.diseñoButton2 = new Proyecto.Resources.DiseñoButton();
            this.diseñoIconButton1 = new Proyecto.Resources.DiseñoIconButton();
            this.tbc_Agregar_Funcionario.SuspendLayout();
            this.tabP_Datos_Personales.SuspendLayout();
            this.tabP_Horarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbc_Agregar_Funcionario
            // 
            this.tbc_Agregar_Funcionario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbc_Agregar_Funcionario.Controls.Add(this.tabP_Datos_Personales);
            this.tbc_Agregar_Funcionario.Controls.Add(this.tabP_Horarios);
            this.tbc_Agregar_Funcionario.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbc_Agregar_Funcionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbc_Agregar_Funcionario.Location = new System.Drawing.Point(12, 68);
            this.tbc_Agregar_Funcionario.Name = "tbc_Agregar_Funcionario";
            this.tbc_Agregar_Funcionario.SelectedIndex = 0;
            this.tbc_Agregar_Funcionario.Size = new System.Drawing.Size(768, 378);
            this.tbc_Agregar_Funcionario.TabIndex = 1;
            this.tbc_Agregar_Funcionario.Tag = "";
            // 
            // tabP_Datos_Personales
            // 
            this.tabP_Datos_Personales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(61)))), ((int)(((byte)(125)))));
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
            this.tabP_Datos_Personales.ForeColor = System.Drawing.Color.White;
            this.tabP_Datos_Personales.Location = new System.Drawing.Point(4, 25);
            this.tabP_Datos_Personales.Name = "tabP_Datos_Personales";
            this.tabP_Datos_Personales.Padding = new System.Windows.Forms.Padding(3);
            this.tabP_Datos_Personales.Size = new System.Drawing.Size(760, 349);
            this.tabP_Datos_Personales.TabIndex = 0;
            this.tabP_Datos_Personales.Text = "Datos Personales";
            // 
            // cbox_IdUnidad
            // 
            this.cbox_IdUnidad.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cbox_IdUnidad.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbox_IdUnidad.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbox_IdUnidad.FormattingEnabled = true;
            this.cbox_IdUnidad.Items.AddRange(new object[] {
            "Seleccione un dato"});
            this.cbox_IdUnidad.Location = new System.Drawing.Point(552, 149);
            this.cbox_IdUnidad.Name = "cbox_IdUnidad";
            this.cbox_IdUnidad.Size = new System.Drawing.Size(176, 24);
            this.cbox_IdUnidad.TabIndex = 8;
            // 
            // cbox_IdDispositivo
            // 
            this.cbox_IdDispositivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbox_IdDispositivo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbox_IdDispositivo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbox_IdDispositivo.FormattingEnabled = true;
            this.cbox_IdDispositivo.Items.AddRange(new object[] {
            "Seleccione un dato"});
            this.cbox_IdDispositivo.Location = new System.Drawing.Point(552, 254);
            this.cbox_IdDispositivo.Name = "cbox_IdDispositivo";
            this.cbox_IdDispositivo.Size = new System.Drawing.Size(176, 24);
            this.cbox_IdDispositivo.TabIndex = 9;
            // 
            // cbox_Tipo_Cargo
            // 
            this.cbox_Tipo_Cargo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbox_Tipo_Cargo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbox_Tipo_Cargo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbox_Tipo_Cargo.FormattingEnabled = true;
            this.cbox_Tipo_Cargo.Items.AddRange(new object[] {
            "Seleccione un dato"});
            this.cbox_Tipo_Cargo.Location = new System.Drawing.Point(552, 50);
            this.cbox_Tipo_Cargo.Name = "cbox_Tipo_Cargo";
            this.cbox_Tipo_Cargo.Size = new System.Drawing.Size(176, 24);
            this.cbox_Tipo_Cargo.TabIndex = 7;
            // 
            // cbox_Tipo_Contrato
            // 
            this.cbox_Tipo_Contrato.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cbox_Tipo_Contrato.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbox_Tipo_Contrato.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbox_Tipo_Contrato.FormattingEnabled = true;
            this.cbox_Tipo_Contrato.Items.AddRange(new object[] {
            "Seleccione un dato"});
            this.cbox_Tipo_Contrato.Location = new System.Drawing.Point(298, 254);
            this.cbox_Tipo_Contrato.Name = "cbox_Tipo_Contrato";
            this.cbox_Tipo_Contrato.Size = new System.Drawing.Size(176, 24);
            this.cbox_Tipo_Contrato.TabIndex = 6;
            // 
            // lbl_Id_Dispositivo
            // 
            this.lbl_Id_Dispositivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Id_Dispositivo.AutoSize = true;
            this.lbl_Id_Dispositivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Id_Dispositivo.ForeColor = System.Drawing.Color.White;
            this.lbl_Id_Dispositivo.Location = new System.Drawing.Point(549, 235);
            this.lbl_Id_Dispositivo.Name = "lbl_Id_Dispositivo";
            this.lbl_Id_Dispositivo.Size = new System.Drawing.Size(90, 16);
            this.lbl_Id_Dispositivo.TabIndex = 18;
            this.lbl_Id_Dispositivo.Text = "ID Dispositivo";
            // 
            // lbl_Id_Unidad
            // 
            this.lbl_Id_Unidad.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_Id_Unidad.AutoSize = true;
            this.lbl_Id_Unidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Id_Unidad.ForeColor = System.Drawing.Color.White;
            this.lbl_Id_Unidad.Location = new System.Drawing.Point(549, 130);
            this.lbl_Id_Unidad.Name = "lbl_Id_Unidad";
            this.lbl_Id_Unidad.Size = new System.Drawing.Size(93, 16);
            this.lbl_Id_Unidad.TabIndex = 16;
            this.lbl_Id_Unidad.Text = "Departamento";
            // 
            // lbl_Cargo
            // 
            this.lbl_Cargo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Cargo.AutoSize = true;
            this.lbl_Cargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Cargo.ForeColor = System.Drawing.Color.White;
            this.lbl_Cargo.Location = new System.Drawing.Point(549, 31);
            this.lbl_Cargo.Name = "lbl_Cargo";
            this.lbl_Cargo.Size = new System.Drawing.Size(94, 16);
            this.lbl_Cargo.TabIndex = 14;
            this.lbl_Cargo.Text = "Tipo de Cargo";
            // 
            // lbl_Tipo_Contrato
            // 
            this.lbl_Tipo_Contrato.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_Tipo_Contrato.AutoSize = true;
            this.lbl_Tipo_Contrato.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Tipo_Contrato.ForeColor = System.Drawing.Color.White;
            this.lbl_Tipo_Contrato.Location = new System.Drawing.Point(295, 235);
            this.lbl_Tipo_Contrato.Name = "lbl_Tipo_Contrato";
            this.lbl_Tipo_Contrato.Size = new System.Drawing.Size(109, 16);
            this.lbl_Tipo_Contrato.TabIndex = 12;
            this.lbl_Tipo_Contrato.Text = "Tipo De Contrato";
            // 
            // txt_Email
            // 
            this.txt_Email.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Email.Location = new System.Drawing.Point(298, 149);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(176, 22);
            this.txt_Email.TabIndex = 5;
            // 
            // lbl_Email
            // 
            this.lbl_Email.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Email.ForeColor = System.Drawing.Color.White;
            this.lbl_Email.Location = new System.Drawing.Point(295, 130);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(163, 16);
            this.lbl_Email.TabIndex = 10;
            this.lbl_Email.Text = "Correo Electronico (Email)";
            // 
            // txt_Apellido_Materno
            // 
            this.txt_Apellido_Materno.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_Apellido_Materno.Location = new System.Drawing.Point(294, 52);
            this.txt_Apellido_Materno.Name = "txt_Apellido_Materno";
            this.txt_Apellido_Materno.Size = new System.Drawing.Size(176, 22);
            this.txt_Apellido_Materno.TabIndex = 4;
            // 
            // lbl_Apellido_Materno
            // 
            this.lbl_Apellido_Materno.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Apellido_Materno.AutoSize = true;
            this.lbl_Apellido_Materno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Apellido_Materno.ForeColor = System.Drawing.Color.White;
            this.lbl_Apellido_Materno.Location = new System.Drawing.Point(291, 31);
            this.lbl_Apellido_Materno.Name = "lbl_Apellido_Materno";
            this.lbl_Apellido_Materno.Size = new System.Drawing.Size(109, 16);
            this.lbl_Apellido_Materno.TabIndex = 6;
            this.lbl_Apellido_Materno.Text = "Apellido Materno";
            // 
            // txt_Apellido_Paterno
            // 
            this.txt_Apellido_Paterno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_Apellido_Paterno.Location = new System.Drawing.Point(28, 254);
            this.txt_Apellido_Paterno.Name = "txt_Apellido_Paterno";
            this.txt_Apellido_Paterno.Size = new System.Drawing.Size(176, 22);
            this.txt_Apellido_Paterno.TabIndex = 3;
            // 
            // lbl_Apellido_Paterno
            // 
            this.lbl_Apellido_Paterno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_Apellido_Paterno.AutoSize = true;
            this.lbl_Apellido_Paterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Apellido_Paterno.ForeColor = System.Drawing.Color.White;
            this.lbl_Apellido_Paterno.Location = new System.Drawing.Point(25, 235);
            this.lbl_Apellido_Paterno.Name = "lbl_Apellido_Paterno";
            this.lbl_Apellido_Paterno.Size = new System.Drawing.Size(107, 16);
            this.lbl_Apellido_Paterno.TabIndex = 4;
            this.lbl_Apellido_Paterno.Text = "Apellido Paterno";
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_Nombre.Location = new System.Drawing.Point(28, 149);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(176, 22);
            this.txt_Nombre.TabIndex = 2;
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nombre.ForeColor = System.Drawing.Color.White;
            this.lbl_Nombre.Location = new System.Drawing.Point(25, 130);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(56, 16);
            this.lbl_Nombre.TabIndex = 2;
            this.lbl_Nombre.Text = "Nombre";
            // 
            // txt_Rut
            // 
            this.txt_Rut.Location = new System.Drawing.Point(28, 52);
            this.txt_Rut.Name = "txt_Rut";
            this.txt_Rut.Size = new System.Drawing.Size(176, 22);
            this.txt_Rut.TabIndex = 1;
            this.txt_Rut.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Rut_KeyPress);
            // 
            // lbl_Rut
            // 
            this.lbl_Rut.AutoSize = true;
            this.lbl_Rut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Rut.ForeColor = System.Drawing.Color.White;
            this.lbl_Rut.Location = new System.Drawing.Point(25, 33);
            this.lbl_Rut.Name = "lbl_Rut";
            this.lbl_Rut.Size = new System.Drawing.Size(27, 16);
            this.lbl_Rut.TabIndex = 0;
            this.lbl_Rut.Text = "Rut";
            // 
            // tabP_Horarios
            // 
            this.tabP_Horarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(61)))), ((int)(((byte)(125)))));
            this.tabP_Horarios.Controls.Add(this.lbl_Horario_Titulo);
            this.tabP_Horarios.Controls.Add(this.dataGridView1);
            this.tabP_Horarios.Controls.Add(this.cbox_Horarios);
            this.tabP_Horarios.Controls.Add(this.lbl_Asignar_Horario);
            this.tabP_Horarios.Location = new System.Drawing.Point(4, 25);
            this.tabP_Horarios.Name = "tabP_Horarios";
            this.tabP_Horarios.Padding = new System.Windows.Forms.Padding(3);
            this.tabP_Horarios.Size = new System.Drawing.Size(760, 349);
            this.tabP_Horarios.TabIndex = 1;
            this.tabP_Horarios.Text = "Horarios";
            // 
            // lbl_Horario_Titulo
            // 
            this.lbl_Horario_Titulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Horario_Titulo.AutoSize = true;
            this.lbl_Horario_Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Horario_Titulo.ForeColor = System.Drawing.Color.White;
            this.lbl_Horario_Titulo.Location = new System.Drawing.Point(555, 31);
            this.lbl_Horario_Titulo.Name = "lbl_Horario_Titulo";
            this.lbl_Horario_Titulo.Size = new System.Drawing.Size(182, 55);
            this.lbl_Horario_Titulo.TabIndex = 44;
            this.lbl_Horario_Titulo.Text = "Horario";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.Black;
            this.dataGridView1.Location = new System.Drawing.Point(9, 89);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(743, 254);
            this.dataGridView1.TabIndex = 43;
            // 
            // cbox_Horarios
            // 
            this.cbox_Horarios.FormattingEnabled = true;
            this.cbox_Horarios.Location = new System.Drawing.Point(6, 45);
            this.cbox_Horarios.Name = "cbox_Horarios";
            this.cbox_Horarios.Size = new System.Drawing.Size(287, 24);
            this.cbox_Horarios.TabIndex = 10;
            this.cbox_Horarios.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // lbl_Asignar_Horario
            // 
            this.lbl_Asignar_Horario.AutoSize = true;
            this.lbl_Asignar_Horario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Asignar_Horario.ForeColor = System.Drawing.Color.White;
            this.lbl_Asignar_Horario.Location = new System.Drawing.Point(6, 24);
            this.lbl_Asignar_Horario.Name = "lbl_Asignar_Horario";
            this.lbl_Asignar_Horario.Size = new System.Drawing.Size(111, 18);
            this.lbl_Asignar_Horario.TabIndex = 2;
            this.lbl_Asignar_Horario.Text = "Asignar Horario";
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_Titulo.Location = new System.Drawing.Point(245, 9);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(307, 39);
            this.lbl_Titulo.TabIndex = 4;
            this.lbl_Titulo.Text = "Nuevo Funcionario";
            // 
            // lbl_FechaTiempoReal
            // 
            this.lbl_FechaTiempoReal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_FechaTiempoReal.AutoSize = true;
            this.lbl_FechaTiempoReal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FechaTiempoReal.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_FechaTiempoReal.Location = new System.Drawing.Point(690, 36);
            this.lbl_FechaTiempoReal.Name = "lbl_FechaTiempoReal";
            this.lbl_FechaTiempoReal.Size = new System.Drawing.Size(75, 16);
            this.lbl_FechaTiempoReal.TabIndex = 5;
            this.lbl_FechaTiempoReal.Text = "date Fecha";
            // 
            // lbl_Fecha
            // 
            this.lbl_Fecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Fecha.AutoSize = true;
            this.lbl_Fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Fecha.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_Fecha.Location = new System.Drawing.Point(689, 12);
            this.lbl_Fecha.Name = "lbl_Fecha";
            this.lbl_Fecha.Size = new System.Drawing.Size(64, 24);
            this.lbl_Fecha.TabIndex = 6;
            this.lbl_Fecha.Text = "Fecha";
            // 
            // diseñoButton1
            // 
            this.diseñoButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.diseñoButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(61)))), ((int)(((byte)(125)))));
            this.diseñoButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(61)))), ((int)(((byte)(125)))));
            this.diseñoButton1.BorderColor = System.Drawing.Color.Gray;
            this.diseñoButton1.BorderRadius = 40;
            this.diseñoButton1.BorderSize = 0;
            this.diseñoButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.diseñoButton1.FlatAppearance.BorderSize = 0;
            this.diseñoButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.diseñoButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diseñoButton1.ForeColor = System.Drawing.Color.White;
            this.diseñoButton1.Location = new System.Drawing.Point(12, 457);
            this.diseñoButton1.Name = "diseñoButton1";
            this.diseñoButton1.Size = new System.Drawing.Size(85, 40);
            this.diseñoButton1.TabIndex = 11;
            this.diseñoButton1.Text = "Volver ";
            this.diseñoButton1.TextColor = System.Drawing.Color.White;
            this.diseñoButton1.UseVisualStyleBackColor = true;
            this.diseñoButton1.Click += new System.EventHandler(this.diseñoButton1_Click);
            // 
            // diseñoButton2
            // 
            this.diseñoButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.diseñoButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(61)))), ((int)(((byte)(125)))));
            this.diseñoButton2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(61)))), ((int)(((byte)(125)))));
            this.diseñoButton2.BorderColor = System.Drawing.Color.Gold;
            this.diseñoButton2.BorderRadius = 25;
            this.diseñoButton2.BorderSize = 1;
            this.diseñoButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.diseñoButton2.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.diseñoButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.diseñoButton2.ForeColor = System.Drawing.Color.White;
            this.diseñoButton2.Location = new System.Drawing.Point(533, 469);
            this.diseñoButton2.Name = "diseñoButton2";
            this.diseñoButton2.Size = new System.Drawing.Size(76, 28);
            this.diseñoButton2.TabIndex = 12;
            this.diseñoButton2.Text = "Limpiar";
            this.diseñoButton2.TextColor = System.Drawing.Color.White;
            this.diseñoButton2.UseVisualStyleBackColor = false;
            this.diseñoButton2.Click += new System.EventHandler(this.diseñoButton2_Click);
            // 
            // diseñoIconButton1
            // 
            this.diseñoIconButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.diseñoIconButton1.BackColor = System.Drawing.Color.OliveDrab;
            this.diseñoIconButton1.BackgroundColor = System.Drawing.Color.OliveDrab;
            this.diseñoIconButton1.BorderColor = System.Drawing.Color.Green;
            this.diseñoIconButton1.BorderRadius = 25;
            this.diseñoIconButton1.BorderSize = 3;
            this.diseñoIconButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.diseñoIconButton1.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.diseñoIconButton1.FlatAppearance.BorderSize = 3;
            this.diseñoIconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.diseñoIconButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diseñoIconButton1.ForeColor = System.Drawing.Color.White;
            this.diseñoIconButton1.IconChar = FontAwesome.Sharp.IconChar.PersonCircleCheck;
            this.diseñoIconButton1.IconColor = System.Drawing.Color.White;
            this.diseñoIconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.diseñoIconButton1.IconSize = 35;
            this.diseñoIconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.diseñoIconButton1.Location = new System.Drawing.Point(630, 452);
            this.diseñoIconButton1.Name = "diseñoIconButton1";
            this.diseñoIconButton1.Size = new System.Drawing.Size(150, 48);
            this.diseñoIconButton1.TabIndex = 13;
            this.diseñoIconButton1.Text = "Registrar Usuario";
            this.diseñoIconButton1.TextColor = System.Drawing.Color.White;
            this.diseñoIconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.diseñoIconButton1.UseVisualStyleBackColor = false;
            this.diseñoIconButton1.Click += new System.EventHandler(this.diseñoIconButton1_Click);
            // 
            // Form_Agregar_Funcionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(61)))), ((int)(((byte)(125)))));
            this.ClientSize = new System.Drawing.Size(798, 506);
            this.Controls.Add(this.diseñoIconButton1);
            this.Controls.Add(this.diseñoButton2);
            this.Controls.Add(this.diseñoButton1);
            this.Controls.Add(this.lbl_Fecha);
            this.Controls.Add(this.lbl_FechaTiempoReal);
            this.Controls.Add(this.lbl_Titulo);
            this.Controls.Add(this.tbc_Agregar_Funcionario);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Agregar_Funcionario";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Funcionario";
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
        private System.Windows.Forms.ComboBox cbox_IdDispositivo;
        private System.Windows.Forms.ComboBox cbox_IdUnidad;
        private System.Windows.Forms.ComboBox cbox_Horarios;
        private System.Windows.Forms.Label lbl_Asignar_Horario;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbl_Horario_Titulo;
        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.Label lbl_FechaTiempoReal;
        private System.Windows.Forms.Label lbl_Fecha;
        private Resources.DiseñoButton diseñoButton1;
        private Resources.DiseñoButton diseñoButton2;
        private Resources.DiseñoIconButton diseñoIconButton1;
    }
}