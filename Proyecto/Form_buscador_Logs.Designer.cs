namespace Proyecto
{
    partial class Form_buscador_Logs
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
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.txt_Descripcion = new System.Windows.Forms.TextBox();
            this.cbox_Proceso = new System.Windows.Forms.ComboBox();
            this.cbox_Usuario = new System.Windows.Forms.ComboBox();
            this.DTP_Desde = new System.Windows.Forms.DateTimePicker();
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_FullDate = new System.Windows.Forms.Button();
            this.DTP_Hasta = new System.Windows.Forms.DateTimePicker();
            this.lbl_Desde = new System.Windows.Forms.Label();
            this.lbl_Hasta = new System.Windows.Forms.Label();
            this.lbl_Proceso = new System.Windows.Forms.Label();
            this.lbl_Descripcion = new System.Windows.Forms.Label();
            this.lbl_Usuario = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.Location = new System.Drawing.Point(31, 9);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(251, 25);
            this.lbl_Titulo.TabIndex = 0;
            this.lbl_Titulo.Text = "Formulario de busqueda ";
            // 
            // txt_Descripcion
            // 
            this.txt_Descripcion.Location = new System.Drawing.Point(51, 207);
            this.txt_Descripcion.Name = "txt_Descripcion";
            this.txt_Descripcion.Size = new System.Drawing.Size(200, 20);
            this.txt_Descripcion.TabIndex = 1;
            // 
            // cbox_Proceso
            // 
            this.cbox_Proceso.FormattingEnabled = true;
            this.cbox_Proceso.Location = new System.Drawing.Point(51, 154);
            this.cbox_Proceso.Name = "cbox_Proceso";
            this.cbox_Proceso.Size = new System.Drawing.Size(200, 21);
            this.cbox_Proceso.TabIndex = 2;
            // 
            // cbox_Usuario
            // 
            this.cbox_Usuario.FormattingEnabled = true;
            this.cbox_Usuario.Location = new System.Drawing.Point(51, 262);
            this.cbox_Usuario.Name = "cbox_Usuario";
            this.cbox_Usuario.Size = new System.Drawing.Size(200, 21);
            this.cbox_Usuario.TabIndex = 3;
            // 
            // DTP_Desde
            // 
            this.DTP_Desde.Location = new System.Drawing.Point(51, 59);
            this.DTP_Desde.Name = "DTP_Desde";
            this.DTP_Desde.Size = new System.Drawing.Size(200, 20);
            this.DTP_Desde.TabIndex = 17;
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.BackColor = System.Drawing.Color.YellowGreen;
            this.btn_Aceptar.Location = new System.Drawing.Point(36, 316);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(75, 23);
            this.btn_Aceptar.TabIndex = 18;
            this.btn_Aceptar.Text = "Iniciar";
            this.btn_Aceptar.UseVisualStyleBackColor = false;
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.BackColor = System.Drawing.Color.LightCoral;
            this.btn_Cancelar.Location = new System.Drawing.Point(188, 316);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancelar.TabIndex = 19;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = false;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_FullDate
            // 
            this.btn_FullDate.BackColor = System.Drawing.Color.Khaki;
            this.btn_FullDate.Location = new System.Drawing.Point(81, 364);
            this.btn_FullDate.Name = "btn_FullDate";
            this.btn_FullDate.Size = new System.Drawing.Size(138, 23);
            this.btn_FullDate.TabIndex = 20;
            this.btn_FullDate.Text = "Ver todos los Datos";
            this.btn_FullDate.UseVisualStyleBackColor = false;
            // 
            // DTP_Hasta
            // 
            this.DTP_Hasta.Location = new System.Drawing.Point(51, 98);
            this.DTP_Hasta.Name = "DTP_Hasta";
            this.DTP_Hasta.Size = new System.Drawing.Size(200, 20);
            this.DTP_Hasta.TabIndex = 21;
            // 
            // lbl_Desde
            // 
            this.lbl_Desde.AutoSize = true;
            this.lbl_Desde.Location = new System.Drawing.Point(9, 65);
            this.lbl_Desde.Name = "lbl_Desde";
            this.lbl_Desde.Size = new System.Drawing.Size(38, 13);
            this.lbl_Desde.TabIndex = 22;
            this.lbl_Desde.Text = "Desde";
            // 
            // lbl_Hasta
            // 
            this.lbl_Hasta.AutoSize = true;
            this.lbl_Hasta.Location = new System.Drawing.Point(12, 104);
            this.lbl_Hasta.Name = "lbl_Hasta";
            this.lbl_Hasta.Size = new System.Drawing.Size(35, 13);
            this.lbl_Hasta.TabIndex = 23;
            this.lbl_Hasta.Text = "Hasta";
            // 
            // lbl_Proceso
            // 
            this.lbl_Proceso.AutoSize = true;
            this.lbl_Proceso.Location = new System.Drawing.Point(48, 138);
            this.lbl_Proceso.Name = "lbl_Proceso";
            this.lbl_Proceso.Size = new System.Drawing.Size(46, 13);
            this.lbl_Proceso.TabIndex = 24;
            this.lbl_Proceso.Text = "Proceso";
            // 
            // lbl_Descripcion
            // 
            this.lbl_Descripcion.AutoSize = true;
            this.lbl_Descripcion.Location = new System.Drawing.Point(48, 191);
            this.lbl_Descripcion.Name = "lbl_Descripcion";
            this.lbl_Descripcion.Size = new System.Drawing.Size(63, 13);
            this.lbl_Descripcion.TabIndex = 25;
            this.lbl_Descripcion.Text = "Descripcion";
            // 
            // lbl_Usuario
            // 
            this.lbl_Usuario.AutoSize = true;
            this.lbl_Usuario.Location = new System.Drawing.Point(48, 246);
            this.lbl_Usuario.Name = "lbl_Usuario";
            this.lbl_Usuario.Size = new System.Drawing.Size(43, 13);
            this.lbl_Usuario.TabIndex = 26;
            this.lbl_Usuario.Text = "Usuario";
            // 
            // Form_buscador_Logs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 389);
            this.Controls.Add(this.lbl_Usuario);
            this.Controls.Add(this.lbl_Descripcion);
            this.Controls.Add(this.lbl_Proceso);
            this.Controls.Add(this.lbl_Hasta);
            this.Controls.Add(this.lbl_Desde);
            this.Controls.Add(this.DTP_Hasta);
            this.Controls.Add(this.btn_FullDate);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Aceptar);
            this.Controls.Add(this.DTP_Desde);
            this.Controls.Add(this.cbox_Usuario);
            this.Controls.Add(this.cbox_Proceso);
            this.Controls.Add(this.txt_Descripcion);
            this.Controls.Add(this.lbl_Titulo);
            this.Name = "Form_buscador_Logs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_buscador_Logs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.TextBox txt_Descripcion;
        private System.Windows.Forms.ComboBox cbox_Proceso;
        private System.Windows.Forms.ComboBox cbox_Usuario;
        private System.Windows.Forms.DateTimePicker DTP_Desde;
        private System.Windows.Forms.Button btn_Aceptar;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_FullDate;
        private System.Windows.Forms.DateTimePicker DTP_Hasta;
        private System.Windows.Forms.Label lbl_Desde;
        private System.Windows.Forms.Label lbl_Hasta;
        private System.Windows.Forms.Label lbl_Proceso;
        private System.Windows.Forms.Label lbl_Descripcion;
        private System.Windows.Forms.Label lbl_Usuario;
    }
}