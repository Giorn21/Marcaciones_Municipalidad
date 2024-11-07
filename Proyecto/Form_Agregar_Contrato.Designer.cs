namespace Proyecto
{
    partial class Form_Agregar_Contrato
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
            this.txt_TipoContrato = new System.Windows.Forms.TextBox();
            this.txt_Descripcion = new System.Windows.Forms.TextBox();
            this.lbl_IDContrato = new System.Windows.Forms.Label();
            this.lbl_Descripcion = new System.Windows.Forms.Label();
            this.diseñoIconButton1 = new Proyecto.Resources.DiseñoIconButton();
            this.diseñoButton2 = new Proyecto.Resources.DiseñoButton();
            this.SuspendLayout();
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.ForeColor = System.Drawing.Color.White;
            this.lbl_Titulo.Location = new System.Drawing.Point(12, 9);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(237, 33);
            this.lbl_Titulo.TabIndex = 2;
            this.lbl_Titulo.Text = "Agregar Contrato";
            // 
            // txt_TipoContrato
            // 
            this.txt_TipoContrato.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TipoContrato.Location = new System.Drawing.Point(38, 103);
            this.txt_TipoContrato.Name = "txt_TipoContrato";
            this.txt_TipoContrato.Size = new System.Drawing.Size(167, 24);
            this.txt_TipoContrato.TabIndex = 0;
            this.txt_TipoContrato.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_TipoContrato_KeyPress);
            // 
            // txt_Descripcion
            // 
            this.txt_Descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Descripcion.Location = new System.Drawing.Point(38, 167);
            this.txt_Descripcion.Name = "txt_Descripcion";
            this.txt_Descripcion.Size = new System.Drawing.Size(167, 24);
            this.txt_Descripcion.TabIndex = 1;
            // 
            // lbl_IDContrato
            // 
            this.lbl_IDContrato.AutoSize = true;
            this.lbl_IDContrato.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_IDContrato.ForeColor = System.Drawing.Color.White;
            this.lbl_IDContrato.Location = new System.Drawing.Point(35, 82);
            this.lbl_IDContrato.Name = "lbl_IDContrato";
            this.lbl_IDContrato.Size = new System.Drawing.Size(84, 18);
            this.lbl_IDContrato.TabIndex = 5;
            this.lbl_IDContrato.Text = "ID Contrato";
            // 
            // lbl_Descripcion
            // 
            this.lbl_Descripcion.AutoSize = true;
            this.lbl_Descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Descripcion.ForeColor = System.Drawing.Color.White;
            this.lbl_Descripcion.Location = new System.Drawing.Point(35, 146);
            this.lbl_Descripcion.Name = "lbl_Descripcion";
            this.lbl_Descripcion.Size = new System.Drawing.Size(99, 18);
            this.lbl_Descripcion.TabIndex = 6;
            this.lbl_Descripcion.Text = "Tipo Contrato";
            // 
            // diseñoIconButton1
            // 
            this.diseñoIconButton1.BackColor = System.Drawing.Color.OliveDrab;
            this.diseñoIconButton1.BackgroundColor = System.Drawing.Color.OliveDrab;
            this.diseñoIconButton1.BorderColor = System.Drawing.Color.Green;
            this.diseñoIconButton1.BorderRadius = 20;
            this.diseñoIconButton1.BorderSize = 2;
            this.diseñoIconButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.diseñoIconButton1.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.diseñoIconButton1.FlatAppearance.BorderSize = 3;
            this.diseñoIconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.diseñoIconButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diseñoIconButton1.ForeColor = System.Drawing.Color.White;
            this.diseñoIconButton1.IconChar = FontAwesome.Sharp.IconChar.FileCircleCheck;
            this.diseñoIconButton1.IconColor = System.Drawing.SystemColors.Window;
            this.diseñoIconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.diseñoIconButton1.IconSize = 35;
            this.diseñoIconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.diseñoIconButton1.Location = new System.Drawing.Point(48, 220);
            this.diseñoIconButton1.Name = "diseñoIconButton1";
            this.diseñoIconButton1.Size = new System.Drawing.Size(141, 41);
            this.diseñoIconButton1.TabIndex = 2;
            this.diseñoIconButton1.Text = "Confirmar Nuevo Contrato\r\n";
            this.diseñoIconButton1.TextColor = System.Drawing.Color.White;
            this.diseñoIconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.diseñoIconButton1.UseVisualStyleBackColor = false;
            this.diseñoIconButton1.Click += new System.EventHandler(this.diseñoIconButton1_Click);
            // 
            // diseñoButton2
            // 
            this.diseñoButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(61)))), ((int)(((byte)(125)))));
            this.diseñoButton2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(61)))), ((int)(((byte)(125)))));
            this.diseñoButton2.BorderColor = System.Drawing.Color.Gray;
            this.diseñoButton2.BorderRadius = 40;
            this.diseñoButton2.BorderSize = 0;
            this.diseñoButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.diseñoButton2.FlatAppearance.BorderSize = 0;
            this.diseñoButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.diseñoButton2.ForeColor = System.Drawing.Color.White;
            this.diseñoButton2.Location = new System.Drawing.Point(12, 287);
            this.diseñoButton2.Name = "diseñoButton2";
            this.diseñoButton2.Size = new System.Drawing.Size(67, 36);
            this.diseñoButton2.TabIndex = 3;
            this.diseñoButton2.Text = "Volver";
            this.diseñoButton2.TextColor = System.Drawing.Color.White;
            this.diseñoButton2.UseVisualStyleBackColor = true;
            this.diseñoButton2.Click += new System.EventHandler(this.diseñoButton2_Click);
            // 
            // Form_Agregar_Contrato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(61)))), ((int)(((byte)(125)))));
            this.ClientSize = new System.Drawing.Size(259, 335);
            this.Controls.Add(this.diseñoButton2);
            this.Controls.Add(this.diseñoIconButton1);
            this.Controls.Add(this.lbl_Descripcion);
            this.Controls.Add(this.lbl_IDContrato);
            this.Controls.Add(this.txt_Descripcion);
            this.Controls.Add(this.txt_TipoContrato);
            this.Controls.Add(this.lbl_Titulo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Agregar_Contrato";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Contrato";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.TextBox txt_TipoContrato;
        private System.Windows.Forms.TextBox txt_Descripcion;
        private System.Windows.Forms.Label lbl_IDContrato;
        private System.Windows.Forms.Label lbl_Descripcion;
        private Resources.DiseñoIconButton diseñoIconButton1;
        private Resources.DiseñoButton diseñoButton2;
    }
}