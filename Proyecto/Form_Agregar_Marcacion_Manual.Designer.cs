namespace Proyecto
{
    partial class Form_Agregar_Marcacion_Manual
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
            this.lbl_ID = new System.Windows.Forms.Label();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.lbl_Fecha = new System.Windows.Forms.Label();
            this.txt_Hora = new System.Windows.Forms.TextBox();
            this.lbl_Hora = new System.Windows.Forms.Label();
            this.lbl_Comentario = new System.Windows.Forms.Label();
            this.rtxt_Comentario = new System.Windows.Forms.RichTextBox();
            this.rbtn_Salida = new System.Windows.Forms.RadioButton();
            this.rbtn_Entrada = new System.Windows.Forms.RadioButton();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.DTP_Fecha = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Location = new System.Drawing.Point(74, 41);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(18, 13);
            this.lbl_ID.TabIndex = 0;
            this.lbl_ID.Text = "ID";
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(68, 57);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(145, 20);
            this.txt_ID.TabIndex = 1;
            this.txt_ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_ID_KeyPress);
            // 
            // lbl_Fecha
            // 
            this.lbl_Fecha.AutoSize = true;
            this.lbl_Fecha.Location = new System.Drawing.Point(268, 41);
            this.lbl_Fecha.Name = "lbl_Fecha";
            this.lbl_Fecha.Size = new System.Drawing.Size(37, 13);
            this.lbl_Fecha.TabIndex = 6;
            this.lbl_Fecha.Text = "Fecha";
            // 
            // txt_Hora
            // 
            this.txt_Hora.Location = new System.Drawing.Point(541, 57);
            this.txt_Hora.Name = "txt_Hora";
            this.txt_Hora.Size = new System.Drawing.Size(145, 20);
            this.txt_Hora.TabIndex = 9;
            this.txt_Hora.TextChanged += new System.EventHandler(this.txt_Hora_TextChanged);
            this.txt_Hora.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Hora_KeyPress);
            // 
            // lbl_Hora
            // 
            this.lbl_Hora.AutoSize = true;
            this.lbl_Hora.Location = new System.Drawing.Point(547, 41);
            this.lbl_Hora.Name = "lbl_Hora";
            this.lbl_Hora.Size = new System.Drawing.Size(30, 13);
            this.lbl_Hora.TabIndex = 8;
            this.lbl_Hora.Text = "Hora";
            // 
            // lbl_Comentario
            // 
            this.lbl_Comentario.AutoSize = true;
            this.lbl_Comentario.Location = new System.Drawing.Point(74, 124);
            this.lbl_Comentario.Name = "lbl_Comentario";
            this.lbl_Comentario.Size = new System.Drawing.Size(111, 13);
            this.lbl_Comentario.TabIndex = 10;
            this.lbl_Comentario.Text = "Comentario (Opcional)";
            // 
            // rtxt_Comentario
            // 
            this.rtxt_Comentario.Location = new System.Drawing.Point(68, 140);
            this.rtxt_Comentario.Name = "rtxt_Comentario";
            this.rtxt_Comentario.Size = new System.Drawing.Size(376, 125);
            this.rtxt_Comentario.TabIndex = 11;
            this.rtxt_Comentario.Text = "";
            // 
            // rbtn_Salida
            // 
            this.rbtn_Salida.AutoSize = true;
            this.rbtn_Salida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_Salida.Location = new System.Drawing.Point(636, 140);
            this.rbtn_Salida.Name = "rbtn_Salida";
            this.rbtn_Salida.Size = new System.Drawing.Size(71, 24);
            this.rbtn_Salida.TabIndex = 12;
            this.rbtn_Salida.TabStop = true;
            this.rbtn_Salida.Text = "Salida";
            this.rbtn_Salida.UseVisualStyleBackColor = true;
            // 
            // rbtn_Entrada
            // 
            this.rbtn_Entrada.AutoSize = true;
            this.rbtn_Entrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_Entrada.Location = new System.Drawing.Point(511, 140);
            this.rbtn_Entrada.Name = "rbtn_Entrada";
            this.rbtn_Entrada.Size = new System.Drawing.Size(84, 24);
            this.rbtn_Entrada.TabIndex = 13;
            this.rbtn_Entrada.TabStop = true;
            this.rbtn_Entrada.Text = "Entrada";
            this.rbtn_Entrada.UseVisualStyleBackColor = true;
            // 
            // btn_Salir
            // 
            this.btn_Salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Salir.Location = new System.Drawing.Point(12, 307);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(80, 33);
            this.btn_Salir.TabIndex = 14;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Guardar.Location = new System.Drawing.Point(559, 236);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(104, 29);
            this.btn_Guardar.TabIndex = 15;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // DTP_Fecha
            // 
            this.DTP_Fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTP_Fecha.Location = new System.Drawing.Point(271, 57);
            this.DTP_Fecha.Name = "DTP_Fecha";
            this.DTP_Fecha.Size = new System.Drawing.Size(200, 20);
            this.DTP_Fecha.TabIndex = 16;
            // 
            // Form_Agregar_Marcacion_Manual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 355);
            this.Controls.Add(this.DTP_Fecha);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.rbtn_Entrada);
            this.Controls.Add(this.rbtn_Salida);
            this.Controls.Add(this.rtxt_Comentario);
            this.Controls.Add(this.lbl_Comentario);
            this.Controls.Add(this.txt_Hora);
            this.Controls.Add(this.lbl_Hora);
            this.Controls.Add(this.lbl_Fecha);
            this.Controls.Add(this.txt_ID);
            this.Controls.Add(this.lbl_ID);
            this.Name = "Form_Agregar_Marcacion_Manual";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Marcaciones_update";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.Label lbl_Fecha;
        private System.Windows.Forms.TextBox txt_Hora;
        private System.Windows.Forms.Label lbl_Hora;
        private System.Windows.Forms.Label lbl_Comentario;
        private System.Windows.Forms.RichTextBox rtxt_Comentario;
        private System.Windows.Forms.RadioButton rbtn_Salida;
        private System.Windows.Forms.RadioButton rbtn_Entrada;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.DateTimePicker DTP_Fecha;
    }
}