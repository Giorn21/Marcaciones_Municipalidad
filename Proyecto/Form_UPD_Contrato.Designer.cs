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
            this.btn_Salir = new System.Windows.Forms.Button();
            this.btn_Acualizar = new System.Windows.Forms.Button();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.txt_TipoContrato = new System.Windows.Forms.TextBox();
            this.txt_Descripcion = new System.Windows.Forms.TextBox();
            this.lbl_IdTipoContrato = new System.Windows.Forms.Label();
            this.lbl_Descripcion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Salir
            // 
            this.btn_Salir.BackColor = System.Drawing.Color.LightCoral;
            this.btn_Salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Salir.Location = new System.Drawing.Point(196, 236);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(75, 31);
            this.btn_Salir.TabIndex = 0;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = false;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // btn_Acualizar
            // 
            this.btn_Acualizar.BackColor = System.Drawing.Color.Chartreuse;
            this.btn_Acualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Acualizar.Location = new System.Drawing.Point(27, 236);
            this.btn_Acualizar.Name = "btn_Acualizar";
            this.btn_Acualizar.Size = new System.Drawing.Size(75, 31);
            this.btn_Acualizar.TabIndex = 1;
            this.btn_Acualizar.Text = "Actualizar";
            this.btn_Acualizar.UseVisualStyleBackColor = false;
            this.btn_Acualizar.Click += new System.EventHandler(this.btn_Acualizar_Click);
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.Location = new System.Drawing.Point(22, 9);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(249, 25);
            this.lbl_Titulo.TabIndex = 2;
            this.lbl_Titulo.Text = "Edicion de Tipo Contrato";
            // 
            // txt_TipoContrato
            // 
            this.txt_TipoContrato.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TipoContrato.Location = new System.Drawing.Point(65, 86);
            this.txt_TipoContrato.Name = "txt_TipoContrato";
            this.txt_TipoContrato.ReadOnly = true;
            this.txt_TipoContrato.Size = new System.Drawing.Size(160, 22);
            this.txt_TipoContrato.TabIndex = 3;
            // 
            // txt_Descripcion
            // 
            this.txt_Descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Descripcion.Location = new System.Drawing.Point(65, 167);
            this.txt_Descripcion.Name = "txt_Descripcion";
            this.txt_Descripcion.Size = new System.Drawing.Size(160, 22);
            this.txt_Descripcion.TabIndex = 4;
            // 
            // lbl_IdTipoContrato
            // 
            this.lbl_IdTipoContrato.AutoSize = true;
            this.lbl_IdTipoContrato.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_IdTipoContrato.Location = new System.Drawing.Point(62, 70);
            this.lbl_IdTipoContrato.Name = "lbl_IdTipoContrato";
            this.lbl_IdTipoContrato.Size = new System.Drawing.Size(104, 16);
            this.lbl_IdTipoContrato.TabIndex = 5;
            this.lbl_IdTipoContrato.Text = "ID Tipo Contrato";
            // 
            // lbl_Descripcion
            // 
            this.lbl_Descripcion.AutoSize = true;
            this.lbl_Descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Descripcion.Location = new System.Drawing.Point(62, 148);
            this.lbl_Descripcion.Name = "lbl_Descripcion";
            this.lbl_Descripcion.Size = new System.Drawing.Size(79, 16);
            this.lbl_Descripcion.TabIndex = 6;
            this.lbl_Descripcion.Text = "Descripcion";
            // 
            // Form_UPD_Contrato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 287);
            this.Controls.Add(this.lbl_Descripcion);
            this.Controls.Add(this.lbl_IdTipoContrato);
            this.Controls.Add(this.txt_Descripcion);
            this.Controls.Add(this.txt_TipoContrato);
            this.Controls.Add(this.lbl_Titulo);
            this.Controls.Add(this.btn_Acualizar);
            this.Controls.Add(this.btn_Salir);
            this.Name = "Form_UPD_Contrato";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_UPD_Contrato";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Button btn_Acualizar;
        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.TextBox txt_TipoContrato;
        private System.Windows.Forms.TextBox txt_Descripcion;
        private System.Windows.Forms.Label lbl_IdTipoContrato;
        private System.Windows.Forms.Label lbl_Descripcion;
    }
}