namespace Proyecto
{
    partial class Form_Menu
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
            this.lbl_TituloMenu = new System.Windows.Forms.Label();
            this.btn_Funcionarios = new System.Windows.Forms.Button();
            this.btn_Disp_Funcionarios = new System.Windows.Forms.Button();
            this.btn_Dispositivos = new System.Windows.Forms.Button();
            this.btn_Marcaciones = new System.Windows.Forms.Button();
            this.btn_App_Logs = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.btn_Opciones = new System.Windows.Forms.Button();
            this.btn_AgregarMarcaciones = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_TituloMenu
            // 
            this.lbl_TituloMenu.AutoSize = true;
            this.lbl_TituloMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TituloMenu.Location = new System.Drawing.Point(206, 12);
            this.lbl_TituloMenu.Name = "lbl_TituloMenu";
            this.lbl_TituloMenu.Size = new System.Drawing.Size(111, 37);
            this.lbl_TituloMenu.TabIndex = 0;
            this.lbl_TituloMenu.Text = "MENU";
            // 
            // btn_Funcionarios
            // 
            this.btn_Funcionarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Funcionarios.Location = new System.Drawing.Point(12, 54);
            this.btn_Funcionarios.Name = "btn_Funcionarios";
            this.btn_Funcionarios.Size = new System.Drawing.Size(124, 29);
            this.btn_Funcionarios.TabIndex = 1;
            this.btn_Funcionarios.Text = "Funcionarios ";
            this.btn_Funcionarios.UseVisualStyleBackColor = true;
            this.btn_Funcionarios.Click += new System.EventHandler(this.btn_Funcionarios_Click);
            // 
            // btn_Disp_Funcionarios
            // 
            this.btn_Disp_Funcionarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Disp_Funcionarios.Location = new System.Drawing.Point(12, 102);
            this.btn_Disp_Funcionarios.Name = "btn_Disp_Funcionarios";
            this.btn_Disp_Funcionarios.Size = new System.Drawing.Size(124, 45);
            this.btn_Disp_Funcionarios.TabIndex = 2;
            this.btn_Disp_Funcionarios.Text = "Funcionarios con dispositivos";
            this.btn_Disp_Funcionarios.UseVisualStyleBackColor = true;
            this.btn_Disp_Funcionarios.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_Dispositivos
            // 
            this.btn_Dispositivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Dispositivos.Location = new System.Drawing.Point(12, 230);
            this.btn_Dispositivos.Name = "btn_Dispositivos";
            this.btn_Dispositivos.Size = new System.Drawing.Size(124, 31);
            this.btn_Dispositivos.TabIndex = 3;
            this.btn_Dispositivos.Text = "Ver Dispositivos";
            this.btn_Dispositivos.UseVisualStyleBackColor = true;
            this.btn_Dispositivos.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_Marcaciones
            // 
            this.btn_Marcaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Marcaciones.Location = new System.Drawing.Point(12, 281);
            this.btn_Marcaciones.Name = "btn_Marcaciones";
            this.btn_Marcaciones.Size = new System.Drawing.Size(124, 29);
            this.btn_Marcaciones.TabIndex = 4;
            this.btn_Marcaciones.Text = "Ver Marcaciones";
            this.btn_Marcaciones.UseVisualStyleBackColor = true;
            this.btn_Marcaciones.Click += new System.EventHandler(this.btn_Marcaciones_Click);
            // 
            // btn_App_Logs
            // 
            this.btn_App_Logs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_App_Logs.Location = new System.Drawing.Point(12, 326);
            this.btn_App_Logs.Name = "btn_App_Logs";
            this.btn_App_Logs.Size = new System.Drawing.Size(124, 29);
            this.btn_App_Logs.TabIndex = 5;
            this.btn_App_Logs.Text = "App Logs";
            this.btn_App_Logs.UseVisualStyleBackColor = true;
            this.btn_App_Logs.Click += new System.EventHandler(this.btn_App_Logs_Click);
            // 
            // btn_Salir
            // 
            this.btn_Salir.Location = new System.Drawing.Point(498, 354);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(75, 23);
            this.btn_Salir.TabIndex = 6;
            this.btn_Salir.Text = "SALIR";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // btn_Opciones
            // 
            this.btn_Opciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Opciones.Location = new System.Drawing.Point(526, 12);
            this.btn_Opciones.Name = "btn_Opciones";
            this.btn_Opciones.Size = new System.Drawing.Size(47, 48);
            this.btn_Opciones.TabIndex = 8;
            this.btn_Opciones.Text = "⚙️";
            this.btn_Opciones.UseVisualStyleBackColor = true;
            this.btn_Opciones.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_AgregarMarcaciones
            // 
            this.btn_AgregarMarcaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AgregarMarcaciones.Location = new System.Drawing.Point(12, 165);
            this.btn_AgregarMarcaciones.Name = "btn_AgregarMarcaciones";
            this.btn_AgregarMarcaciones.Size = new System.Drawing.Size(123, 45);
            this.btn_AgregarMarcaciones.TabIndex = 9;
            this.btn_AgregarMarcaciones.Text = "Marcaciones Manuales";
            this.btn_AgregarMarcaciones.UseVisualStyleBackColor = true;
            this.btn_AgregarMarcaciones.Click += new System.EventHandler(this.btn_AgregarMarcaciones_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proyecto.Properties.Resources.logo_la_granja_buena_vida;
            this.pictureBox1.Location = new System.Drawing.Point(201, 81);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(292, 231);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Form_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(585, 389);
            this.Controls.Add(this.btn_AgregarMarcaciones);
            this.Controls.Add(this.btn_Opciones);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.btn_App_Logs);
            this.Controls.Add(this.btn_Marcaciones);
            this.Controls.Add(this.btn_Dispositivos);
            this.Controls.Add(this.btn_Disp_Funcionarios);
            this.Controls.Add(this.btn_Funcionarios);
            this.Controls.Add(this.lbl_TituloMenu);
            this.Name = "Form_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_TituloMenu;
        private System.Windows.Forms.Button btn_Funcionarios;
        private System.Windows.Forms.Button btn_Disp_Funcionarios;
        private System.Windows.Forms.Button btn_Dispositivos;
        private System.Windows.Forms.Button btn_Marcaciones;
        private System.Windows.Forms.Button btn_App_Logs;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_Opciones;
        private System.Windows.Forms.Button btn_AgregarMarcaciones;
    }
}