namespace Proyecto
{
    partial class Form_UPD_Contrato
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
            this.lbl_IdTipoContrato = new System.Windows.Forms.Label();
            this.lbl_Descripcion = new System.Windows.Forms.Label();
            this.diseñoButton1 = new Proyecto.Resources.DiseñoButton();
            this.diseñoIconButton1 = new Proyecto.Resources.DiseñoIconButton();
            this.SuspendLayout();
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.ForeColor = System.Drawing.Color.White;
            this.lbl_Titulo.Location = new System.Drawing.Point(22, 9);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(249, 25);
            this.lbl_Titulo.TabIndex = 2;
            this.lbl_Titulo.Text = "Edición de Tipo Contrato";
            // 
            // txt_TipoContrato
            // 
            this.txt_TipoContrato.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TipoContrato.Location = new System.Drawing.Point(65, 86);
            this.txt_TipoContrato.Name = "txt_TipoContrato";
            this.txt_TipoContrato.ReadOnly = true;
            this.txt_TipoContrato.Size = new System.Drawing.Size(160, 22);
            this.txt_TipoContrato.TabIndex = 0;
            // 
            // txt_Descripcion
            // 
            this.txt_Descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Descripcion.Location = new System.Drawing.Point(65, 167);
            this.txt_Descripcion.Name = "txt_Descripcion";
            this.txt_Descripcion.Size = new System.Drawing.Size(160, 22);
            this.txt_Descripcion.TabIndex = 1;
            // 
            // lbl_IdTipoContrato
            // 
            this.lbl_IdTipoContrato.AutoSize = true;
            this.lbl_IdTipoContrato.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_IdTipoContrato.ForeColor = System.Drawing.Color.White;
            this.lbl_IdTipoContrato.Location = new System.Drawing.Point(62, 70);
            this.lbl_IdTipoContrato.Name = "lbl_IdTipoContrato";
            this.lbl_IdTipoContrato.Size = new System.Drawing.Size(73, 16);
            this.lbl_IdTipoContrato.TabIndex = 5;
            this.lbl_IdTipoContrato.Text = "ID Contrato";
            // 
            // lbl_Descripcion
            // 
            this.lbl_Descripcion.AutoSize = true;
            this.lbl_Descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Descripcion.ForeColor = System.Drawing.Color.White;
            this.lbl_Descripcion.Location = new System.Drawing.Point(62, 148);
            this.lbl_Descripcion.Name = "lbl_Descripcion";
            this.lbl_Descripcion.Size = new System.Drawing.Size(88, 16);
            this.lbl_Descripcion.TabIndex = 6;
            this.lbl_Descripcion.Text = "Tipo Contrato";
            // 
            // diseñoButton1
            // 
            this.diseñoButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(61)))), ((int)(((byte)(125)))));
            this.diseñoButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(61)))), ((int)(((byte)(125)))));
            this.diseñoButton1.BorderColor = System.Drawing.Color.Red;
            this.diseñoButton1.BorderRadius = 40;
            this.diseñoButton1.BorderSize = 0;
            this.diseñoButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.diseñoButton1.FlatAppearance.BorderSize = 0;
            this.diseñoButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.diseñoButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diseñoButton1.ForeColor = System.Drawing.Color.White;
            this.diseñoButton1.Location = new System.Drawing.Point(12, 236);
            this.diseñoButton1.Name = "diseñoButton1";
            this.diseñoButton1.Size = new System.Drawing.Size(75, 39);
            this.diseñoButton1.TabIndex = 4;
            this.diseñoButton1.Text = "Volver\r\n";
            this.diseñoButton1.TextColor = System.Drawing.Color.White;
            this.diseñoButton1.UseVisualStyleBackColor = false;
            this.diseñoButton1.Click += new System.EventHandler(this.diseñoButton1_Click);
            // 
            // diseñoIconButton1
            // 
            this.diseñoIconButton1.BackColor = System.Drawing.Color.Olive;
            this.diseñoIconButton1.BackgroundColor = System.Drawing.Color.Olive;
            this.diseñoIconButton1.BorderColor = System.Drawing.Color.Yellow;
            this.diseñoIconButton1.BorderRadius = 45;
            this.diseñoIconButton1.BorderSize = 3;
            this.diseñoIconButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.diseñoIconButton1.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.diseñoIconButton1.FlatAppearance.BorderSize = 3;
            this.diseñoIconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.diseñoIconButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diseñoIconButton1.ForeColor = System.Drawing.Color.White;
            this.diseñoIconButton1.IconChar = FontAwesome.Sharp.IconChar.Redo;
            this.diseñoIconButton1.IconColor = System.Drawing.Color.White;
            this.diseñoIconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.diseñoIconButton1.IconSize = 20;
            this.diseñoIconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.diseñoIconButton1.Location = new System.Drawing.Point(167, 231);
            this.diseñoIconButton1.Name = "diseñoIconButton1";
            this.diseñoIconButton1.Size = new System.Drawing.Size(104, 44);
            this.diseñoIconButton1.TabIndex = 2;
            this.diseñoIconButton1.Text = "Actualizar";
            this.diseñoIconButton1.TextColor = System.Drawing.Color.White;
            this.diseñoIconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.diseñoIconButton1.UseVisualStyleBackColor = false;
            this.diseñoIconButton1.Click += new System.EventHandler(this.diseñoIconButton1_Click);
            // 
            // Form_UPD_Contrato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(61)))), ((int)(((byte)(125)))));
            this.ClientSize = new System.Drawing.Size(298, 287);
            this.Controls.Add(this.diseñoIconButton1);
            this.Controls.Add(this.diseñoButton1);
            this.Controls.Add(this.lbl_Descripcion);
            this.Controls.Add(this.lbl_IdTipoContrato);
            this.Controls.Add(this.txt_Descripcion);
            this.Controls.Add(this.txt_TipoContrato);
            this.Controls.Add(this.lbl_Titulo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_UPD_Contrato";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Actualizar Contrato";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.TextBox txt_TipoContrato;
        private System.Windows.Forms.TextBox txt_Descripcion;
        private System.Windows.Forms.Label lbl_IdTipoContrato;
        private System.Windows.Forms.Label lbl_Descripcion;
        private Resources.DiseñoButton diseñoButton1;
        private Resources.DiseñoIconButton diseñoIconButton1;
    }
}