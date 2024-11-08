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
            this.DTP_Fecha = new System.Windows.Forms.DateTimePicker();
            this.diseñoButton1 = new Proyecto.Resources.DiseñoButton();
            this.diseñoIconButton1 = new Proyecto.Resources.DiseñoIconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.diseñoIconButton2 = new Proyecto.Resources.DiseñoIconButton();
            this.SuspendLayout();
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ID.ForeColor = System.Drawing.Color.White;
            this.lbl_ID.Location = new System.Drawing.Point(25, 82);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(22, 18);
            this.lbl_ID.TabIndex = 0;
            this.lbl_ID.Text = "ID";
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(28, 103);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(157, 20);
            this.txt_ID.TabIndex = 1;
            this.txt_ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_ID_KeyPress);
            // 
            // lbl_Fecha
            // 
            this.lbl_Fecha.AutoSize = true;
            this.lbl_Fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Fecha.ForeColor = System.Drawing.Color.White;
            this.lbl_Fecha.Location = new System.Drawing.Point(219, 82);
            this.lbl_Fecha.Name = "lbl_Fecha";
            this.lbl_Fecha.Size = new System.Drawing.Size(49, 18);
            this.lbl_Fecha.TabIndex = 6;
            this.lbl_Fecha.Text = "Fecha";
            // 
            // txt_Hora
            // 
            this.txt_Hora.Location = new System.Drawing.Point(28, 152);
            this.txt_Hora.Name = "txt_Hora";
            this.txt_Hora.Size = new System.Drawing.Size(157, 20);
            this.txt_Hora.TabIndex = 3;
            this.txt_Hora.TextChanged += new System.EventHandler(this.txt_Hora_TextChanged);
            this.txt_Hora.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Hora_KeyPress);
            // 
            // lbl_Hora
            // 
            this.lbl_Hora.AutoSize = true;
            this.lbl_Hora.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Hora.ForeColor = System.Drawing.Color.White;
            this.lbl_Hora.Location = new System.Drawing.Point(25, 131);
            this.lbl_Hora.Name = "lbl_Hora";
            this.lbl_Hora.Size = new System.Drawing.Size(41, 18);
            this.lbl_Hora.TabIndex = 8;
            this.lbl_Hora.Text = "Hora";
            // 
            // lbl_Comentario
            // 
            this.lbl_Comentario.AutoSize = true;
            this.lbl_Comentario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Comentario.ForeColor = System.Drawing.Color.White;
            this.lbl_Comentario.Location = new System.Drawing.Point(26, 185);
            this.lbl_Comentario.Name = "lbl_Comentario";
            this.lbl_Comentario.Size = new System.Drawing.Size(159, 18);
            this.lbl_Comentario.TabIndex = 10;
            this.lbl_Comentario.Text = "Comentario (Opcional)";
            // 
            // rtxt_Comentario
            // 
            this.rtxt_Comentario.Location = new System.Drawing.Point(29, 206);
            this.rtxt_Comentario.Name = "rtxt_Comentario";
            this.rtxt_Comentario.Size = new System.Drawing.Size(376, 125);
            this.rtxt_Comentario.TabIndex = 6;
            this.rtxt_Comentario.Text = "";
            // 
            // rbtn_Salida
            // 
            this.rbtn_Salida.AutoSize = true;
            this.rbtn_Salida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_Salida.ForeColor = System.Drawing.Color.White;
            this.rbtn_Salida.Location = new System.Drawing.Point(334, 152);
            this.rbtn_Salida.Name = "rbtn_Salida";
            this.rbtn_Salida.Size = new System.Drawing.Size(71, 24);
            this.rbtn_Salida.TabIndex = 5;
            this.rbtn_Salida.TabStop = true;
            this.rbtn_Salida.Text = "Salida";
            this.rbtn_Salida.UseVisualStyleBackColor = true;
            // 
            // rbtn_Entrada
            // 
            this.rbtn_Entrada.AutoSize = true;
            this.rbtn_Entrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_Entrada.ForeColor = System.Drawing.Color.White;
            this.rbtn_Entrada.Location = new System.Drawing.Point(222, 152);
            this.rbtn_Entrada.Name = "rbtn_Entrada";
            this.rbtn_Entrada.Size = new System.Drawing.Size(84, 24);
            this.rbtn_Entrada.TabIndex = 4;
            this.rbtn_Entrada.TabStop = true;
            this.rbtn_Entrada.Text = "Entrada";
            this.rbtn_Entrada.UseVisualStyleBackColor = true;
            // 
            // DTP_Fecha
            // 
            this.DTP_Fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTP_Fecha.Location = new System.Drawing.Point(222, 103);
            this.DTP_Fecha.Name = "DTP_Fecha";
            this.DTP_Fecha.Size = new System.Drawing.Size(183, 20);
            this.DTP_Fecha.TabIndex = 2;
            // 
            // diseñoButton1
            // 
            this.diseñoButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(61)))), ((int)(((byte)(125)))));
            this.diseñoButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(61)))), ((int)(((byte)(125)))));
            this.diseñoButton1.BorderColor = System.Drawing.Color.Gray;
            this.diseñoButton1.BorderRadius = 40;
            this.diseñoButton1.BorderSize = 0;
            this.diseñoButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.diseñoButton1.FlatAppearance.BorderSize = 0;
            this.diseñoButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.diseñoButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diseñoButton1.ForeColor = System.Drawing.Color.White;
            this.diseñoButton1.Location = new System.Drawing.Point(13, 367);
            this.diseñoButton1.Name = "diseñoButton1";
            this.diseñoButton1.Size = new System.Drawing.Size(114, 39);
            this.diseñoButton1.TabIndex = 8;
            this.diseñoButton1.Text = "Volver al MENÚ";
            this.diseñoButton1.TextColor = System.Drawing.Color.White;
            this.diseñoButton1.UseVisualStyleBackColor = false;
            this.diseñoButton1.Click += new System.EventHandler(this.diseñoButton1_Click);
            // 
            // diseñoIconButton1
            // 
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
            this.diseñoIconButton1.IconChar = FontAwesome.Sharp.IconChar.HandPointUp;
            this.diseñoIconButton1.IconColor = System.Drawing.Color.White;
            this.diseñoIconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.diseñoIconButton1.IconSize = 35;
            this.diseñoIconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.diseñoIconButton1.Location = new System.Drawing.Point(289, 358);
            this.diseñoIconButton1.Name = "diseñoIconButton1";
            this.diseñoIconButton1.Size = new System.Drawing.Size(116, 48);
            this.diseñoIconButton1.TabIndex = 7;
            this.diseñoIconButton1.Text = "Ingresar Marcacion";
            this.diseñoIconButton1.TextColor = System.Drawing.Color.White;
            this.diseñoIconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.diseñoIconButton1.UseVisualStyleBackColor = false;
            this.diseñoIconButton1.Click += new System.EventHandler(this.diseñoIconButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(432, 39);
            this.label1.TabIndex = 11;
            this.label1.Text = "Agregar Marcacion Manual";
            // 
            // diseñoIconButton2
            // 
            this.diseñoIconButton2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(61)))), ((int)(((byte)(125)))));
            this.diseñoIconButton2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.diseñoIconButton2.BorderRadius = 40;
            this.diseñoIconButton2.BorderSize = 0;
            this.diseñoIconButton2.FlatAppearance.BorderSize = 0;
            this.diseñoIconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.diseñoIconButton2.ForeColor = System.Drawing.Color.White;
            this.diseñoIconButton2.IconChar = FontAwesome.Sharp.IconChar.Question;
            this.diseñoIconButton2.IconColor = System.Drawing.Color.White;
            this.diseñoIconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.diseñoIconButton2.IconSize = 20;
            this.diseñoIconButton2.Location = new System.Drawing.Point(151, 68);
            this.diseñoIconButton2.Name = "diseñoIconButton2";
            this.diseñoIconButton2.Size = new System.Drawing.Size(34, 32);
            this.diseñoIconButton2.TabIndex = 12;
            this.diseñoIconButton2.TextColor = System.Drawing.Color.White;
            this.diseñoIconButton2.UseVisualStyleBackColor = true;
            this.diseñoIconButton2.Click += new System.EventHandler(this.diseñoIconButton2_Click);
            // 
            // Form_Agregar_Marcacion_Manual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(61)))), ((int)(((byte)(125)))));
            this.ClientSize = new System.Drawing.Size(447, 434);
            this.Controls.Add(this.diseñoIconButton2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.diseñoButton1);
            this.Controls.Add(this.diseñoIconButton1);
            this.Controls.Add(this.DTP_Fecha);
            this.Controls.Add(this.rbtn_Entrada);
            this.Controls.Add(this.rbtn_Salida);
            this.Controls.Add(this.rtxt_Comentario);
            this.Controls.Add(this.lbl_Comentario);
            this.Controls.Add(this.txt_Hora);
            this.Controls.Add(this.lbl_Hora);
            this.Controls.Add(this.lbl_Fecha);
            this.Controls.Add(this.txt_ID);
            this.Controls.Add(this.lbl_ID);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Agregar_Marcacion_Manual";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nueva Marcacion Manual";
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
        private System.Windows.Forms.DateTimePicker DTP_Fecha;
        private Resources.DiseñoIconButton diseñoIconButton1;
        private Resources.DiseñoButton diseñoButton1;
        private System.Windows.Forms.Label label1;
        private Resources.DiseñoIconButton diseñoIconButton2;
    }
}