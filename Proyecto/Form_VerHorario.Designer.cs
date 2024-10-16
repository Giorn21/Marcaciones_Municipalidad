namespace Proyecto
{
    partial class Form_VerHorario
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
            this.dtv_Horarios = new System.Windows.Forms.DataGridView();
            this.cbox_Horarios = new System.Windows.Forms.ComboBox();
            this.lbl_horarios = new System.Windows.Forms.Label();
            this.btn_Salir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtv_Horarios)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.Location = new System.Drawing.Point(227, 9);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(179, 33);
            this.lbl_Titulo.TabIndex = 0;
            this.lbl_Titulo.Text = "Ver Horarios";
            // 
            // dtv_Horarios
            // 
            this.dtv_Horarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtv_Horarios.Location = new System.Drawing.Point(12, 122);
            this.dtv_Horarios.Name = "dtv_Horarios";
            this.dtv_Horarios.Size = new System.Drawing.Size(629, 218);
            this.dtv_Horarios.TabIndex = 1;
            // 
            // cbox_Horarios
            // 
            this.cbox_Horarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox_Horarios.FormattingEnabled = true;
            this.cbox_Horarios.Location = new System.Drawing.Point(12, 79);
            this.cbox_Horarios.Name = "cbox_Horarios";
            this.cbox_Horarios.Size = new System.Drawing.Size(182, 26);
            this.cbox_Horarios.TabIndex = 2;
            // 
            // lbl_horarios
            // 
            this.lbl_horarios.AutoSize = true;
            this.lbl_horarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_horarios.Location = new System.Drawing.Point(9, 58);
            this.lbl_horarios.Name = "lbl_horarios";
            this.lbl_horarios.Size = new System.Drawing.Size(66, 18);
            this.lbl_horarios.TabIndex = 3;
            this.lbl_horarios.Text = "Horarios";
            // 
            // btn_Salir
            // 
            this.btn_Salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Salir.Location = new System.Drawing.Point(12, 366);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(75, 27);
            this.btn_Salir.TabIndex = 4;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = true;
            // 
            // Form_VerHorario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 405);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.lbl_horarios);
            this.Controls.Add(this.cbox_Horarios);
            this.Controls.Add(this.dtv_Horarios);
            this.Controls.Add(this.lbl_Titulo);
            this.Name = "Form_VerHorario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_VerHorario";
            ((System.ComponentModel.ISupportInitialize)(this.dtv_Horarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.DataGridView dtv_Horarios;
        private System.Windows.Forms.ComboBox cbox_Horarios;
        private System.Windows.Forms.Label lbl_horarios;
        private System.Windows.Forms.Button btn_Salir;
    }
}