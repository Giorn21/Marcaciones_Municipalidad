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
            this.btn_Registro = new System.Windows.Forms.Button();
            this.cbox_Tipo_Cargo = new System.Windows.Forms.ComboBox();
            this.cbox_Tipo_Contrato = new System.Windows.Forms.ComboBox();
            this.lbl_Id_Dispositivo = new System.Windows.Forms.Label();
            this.txt_Id_Unidad = new System.Windows.Forms.TextBox();
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
            this.cbox_IdDispositivo = new System.Windows.Forms.ComboBox();
            this.tbc_Agregar_Funcionario.SuspendLayout();
            this.tabP_Datos_Personales.SuspendLayout();
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
            this.tbc_Agregar_Funcionario.Size = new System.Drawing.Size(765, 347);
            this.tbc_Agregar_Funcionario.TabIndex = 1;
            this.tbc_Agregar_Funcionario.Tag = "";
            // 
            // tabP_Datos_Personales
            // 
            this.tabP_Datos_Personales.BackColor = System.Drawing.Color.Silver;
            this.tabP_Datos_Personales.Controls.Add(this.cbox_IdDispositivo);
            this.tabP_Datos_Personales.Controls.Add(this.btn_Registro);
            this.tabP_Datos_Personales.Controls.Add(this.cbox_Tipo_Cargo);
            this.tabP_Datos_Personales.Controls.Add(this.cbox_Tipo_Contrato);
            this.tabP_Datos_Personales.Controls.Add(this.lbl_Id_Dispositivo);
            this.tabP_Datos_Personales.Controls.Add(this.txt_Id_Unidad);
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
            this.tabP_Datos_Personales.Size = new System.Drawing.Size(757, 318);
            this.tabP_Datos_Personales.TabIndex = 0;
            this.tabP_Datos_Personales.Text = "Datos Personales";
            // 
            // btn_Registro
            // 
            this.btn_Registro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Registro.Location = new System.Drawing.Point(515, 140);
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
            "Seleccione Contrato",
            "0 = No configurado",
            "1 = Administrativo",
            "15 = Ingeniero en informática",
            "16 = Desarrollador"});
            this.cbox_Tipo_Cargo.Location = new System.Drawing.Point(258, 177);
            this.cbox_Tipo_Cargo.Name = "cbox_Tipo_Cargo";
            this.cbox_Tipo_Cargo.Size = new System.Drawing.Size(168, 24);
            this.cbox_Tipo_Cargo.TabIndex = 21;
            // 
            // cbox_Tipo_Contrato
            // 
            this.cbox_Tipo_Contrato.FormattingEnabled = true;
            this.cbox_Tipo_Contrato.Items.AddRange(new object[] {
            "Seleccione Contrato",
            "1 = Código del Trabajo",
            "5 = Plazo Fijo",
            "6 = Reemplazo",
            "7 = Indefinidos",
            "10 = Honorarios"});
            this.cbox_Tipo_Contrato.Location = new System.Drawing.Point(258, 105);
            this.cbox_Tipo_Contrato.Name = "cbox_Tipo_Contrato";
            this.cbox_Tipo_Contrato.Size = new System.Drawing.Size(168, 24);
            this.cbox_Tipo_Contrato.TabIndex = 20;
            // 
            // lbl_Id_Dispositivo
            // 
            this.lbl_Id_Dispositivo.AutoSize = true;
            this.lbl_Id_Dispositivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Id_Dispositivo.Location = new System.Drawing.Point(482, 20);
            this.lbl_Id_Dispositivo.Name = "lbl_Id_Dispositivo";
            this.lbl_Id_Dispositivo.Size = new System.Drawing.Size(90, 16);
            this.lbl_Id_Dispositivo.TabIndex = 18;
            this.lbl_Id_Dispositivo.Text = "ID Dispositivo";
            // 
            // txt_Id_Unidad
            // 
            this.txt_Id_Unidad.Location = new System.Drawing.Point(258, 243);
            this.txt_Id_Unidad.Name = "txt_Id_Unidad";
            this.txt_Id_Unidad.Size = new System.Drawing.Size(168, 22);
            this.txt_Id_Unidad.TabIndex = 17;
            // 
            // lbl_Id_Unidad
            // 
            this.lbl_Id_Unidad.AutoSize = true;
            this.lbl_Id_Unidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Id_Unidad.Location = new System.Drawing.Point(255, 224);
            this.lbl_Id_Unidad.Name = "lbl_Id_Unidad";
            this.lbl_Id_Unidad.Size = new System.Drawing.Size(67, 16);
            this.lbl_Id_Unidad.TabIndex = 16;
            this.lbl_Id_Unidad.Text = "ID Unidad";
            // 
            // lbl_Cargo
            // 
            this.lbl_Cargo.AutoSize = true;
            this.lbl_Cargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Cargo.Location = new System.Drawing.Point(255, 158);
            this.lbl_Cargo.Name = "lbl_Cargo";
            this.lbl_Cargo.Size = new System.Drawing.Size(94, 16);
            this.lbl_Cargo.TabIndex = 14;
            this.lbl_Cargo.Text = "Tipo de Cargo";
            // 
            // lbl_Tipo_Contrato
            // 
            this.lbl_Tipo_Contrato.AutoSize = true;
            this.lbl_Tipo_Contrato.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Tipo_Contrato.Location = new System.Drawing.Point(255, 86);
            this.lbl_Tipo_Contrato.Name = "lbl_Tipo_Contrato";
            this.lbl_Tipo_Contrato.Size = new System.Drawing.Size(109, 16);
            this.lbl_Tipo_Contrato.TabIndex = 12;
            this.lbl_Tipo_Contrato.Text = "Tipo De Contrato";
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(258, 39);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(168, 22);
            this.txt_Email.TabIndex = 11;
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Email.Location = new System.Drawing.Point(255, 20);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(118, 16);
            this.lbl_Email.TabIndex = 10;
            this.lbl_Email.Text = "Correo Electronico";
            // 
            // txt_Apellido_Materno
            // 
            this.txt_Apellido_Materno.Location = new System.Drawing.Point(23, 243);
            this.txt_Apellido_Materno.Name = "txt_Apellido_Materno";
            this.txt_Apellido_Materno.Size = new System.Drawing.Size(168, 22);
            this.txt_Apellido_Materno.TabIndex = 7;
            // 
            // lbl_Apellido_Materno
            // 
            this.lbl_Apellido_Materno.AutoSize = true;
            this.lbl_Apellido_Materno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Apellido_Materno.Location = new System.Drawing.Point(20, 224);
            this.lbl_Apellido_Materno.Name = "lbl_Apellido_Materno";
            this.lbl_Apellido_Materno.Size = new System.Drawing.Size(109, 16);
            this.lbl_Apellido_Materno.TabIndex = 6;
            this.lbl_Apellido_Materno.Text = "Apellido Materno";
            // 
            // txt_Apellido_Paterno
            // 
            this.txt_Apellido_Paterno.Location = new System.Drawing.Point(23, 177);
            this.txt_Apellido_Paterno.Name = "txt_Apellido_Paterno";
            this.txt_Apellido_Paterno.Size = new System.Drawing.Size(168, 22);
            this.txt_Apellido_Paterno.TabIndex = 5;
            // 
            // lbl_Apellido_Paterno
            // 
            this.lbl_Apellido_Paterno.AutoSize = true;
            this.lbl_Apellido_Paterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Apellido_Paterno.Location = new System.Drawing.Point(20, 158);
            this.lbl_Apellido_Paterno.Name = "lbl_Apellido_Paterno";
            this.lbl_Apellido_Paterno.Size = new System.Drawing.Size(107, 16);
            this.lbl_Apellido_Paterno.TabIndex = 4;
            this.lbl_Apellido_Paterno.Text = "Apellido Paterno";
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(23, 105);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(168, 22);
            this.txt_Nombre.TabIndex = 3;
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nombre.Location = new System.Drawing.Point(20, 86);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(56, 16);
            this.lbl_Nombre.TabIndex = 2;
            this.lbl_Nombre.Text = "Nombre";
            // 
            // txt_Rut
            // 
            this.txt_Rut.Location = new System.Drawing.Point(23, 39);
            this.txt_Rut.Name = "txt_Rut";
            this.txt_Rut.Size = new System.Drawing.Size(168, 22);
            this.txt_Rut.TabIndex = 1;
            this.txt_Rut.TextChanged += new System.EventHandler(this.txt_Rut_TextChanged);
            // 
            // lbl_Rut
            // 
            this.lbl_Rut.AutoSize = true;
            this.lbl_Rut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Rut.Location = new System.Drawing.Point(20, 20);
            this.lbl_Rut.Name = "lbl_Rut";
            this.lbl_Rut.Size = new System.Drawing.Size(27, 16);
            this.lbl_Rut.TabIndex = 0;
            this.lbl_Rut.Text = "Rut";
            // 
            // tabP_Horarios
            // 
            this.tabP_Horarios.Location = new System.Drawing.Point(4, 25);
            this.tabP_Horarios.Name = "tabP_Horarios";
            this.tabP_Horarios.Padding = new System.Windows.Forms.Padding(3);
            this.tabP_Horarios.Size = new System.Drawing.Size(757, 318);
            this.tabP_Horarios.TabIndex = 1;
            this.tabP_Horarios.Text = "Horarios";
            this.tabP_Horarios.UseVisualStyleBackColor = true;
            // 
            // cbox_IdDispositivo
            // 
            this.cbox_IdDispositivo.FormattingEnabled = true;
            this.cbox_IdDispositivo.Location = new System.Drawing.Point(485, 39);
            this.cbox_IdDispositivo.Name = "cbox_IdDispositivo";
            this.cbox_IdDispositivo.Size = new System.Drawing.Size(176, 24);
            this.cbox_IdDispositivo.TabIndex = 22;
            // 
            // Form_Agregar_Funcionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbc_Agregar_Funcionario);
            this.Controls.Add(this.btn_Volver);
            this.Name = "Form_Agregar_Funcionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Agregar_Funcionario";
            this.Load += new System.EventHandler(this.Form_Agregar_Funcionario_Load);
            this.tbc_Agregar_Funcionario.ResumeLayout(false);
            this.tabP_Datos_Personales.ResumeLayout(false);
            this.tabP_Datos_Personales.PerformLayout();
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
        private System.Windows.Forms.TextBox txt_Id_Unidad;
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
    }
}