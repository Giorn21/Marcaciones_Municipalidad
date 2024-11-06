namespace Proyecto
{
    partial class Form_VerBiometria
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
            this.dtv_Biometria = new System.Windows.Forms.DataGridView();
            this.col_TipoBiometria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.diseñoButton1 = new Proyecto.Resources.DiseñoButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtv_Biometria)).BeginInit();
            this.SuspendLayout();
            // 
            // dtv_Biometria
            // 
            this.dtv_Biometria.AllowUserToAddRows = false;
            this.dtv_Biometria.AllowUserToDeleteRows = false;
            this.dtv_Biometria.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.dtv_Biometria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtv_Biometria.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_TipoBiometria,
            this.col_Descripcion});
            this.dtv_Biometria.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dtv_Biometria.Location = new System.Drawing.Point(12, 75);
            this.dtv_Biometria.Name = "dtv_Biometria";
            this.dtv_Biometria.ReadOnly = true;
            this.dtv_Biometria.Size = new System.Drawing.Size(330, 215);
            this.dtv_Biometria.TabIndex = 10;
            this.dtv_Biometria.TabStop = false;
            // 
            // col_TipoBiometria
            // 
            this.col_TipoBiometria.HeaderText = "Tipo Biometria";
            this.col_TipoBiometria.Name = "col_TipoBiometria";
            this.col_TipoBiometria.ReadOnly = true;
            // 
            // col_Descripcion
            // 
            this.col_Descripcion.HeaderText = "Descripcion";
            this.col_Descripcion.Name = "col_Descripcion";
            this.col_Descripcion.ReadOnly = true;
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.ForeColor = System.Drawing.Color.White;
            this.lbl_Titulo.Location = new System.Drawing.Point(62, 9);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(224, 37);
            this.lbl_Titulo.TabIndex = 2;
            this.lbl_Titulo.Text = "Tipo Biometria";
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
            this.diseñoButton1.Location = new System.Drawing.Point(12, 306);
            this.diseñoButton1.Name = "diseñoButton1";
            this.diseñoButton1.Size = new System.Drawing.Size(114, 39);
            this.diseñoButton1.TabIndex = 1;
            this.diseñoButton1.Text = "Volver al MENÚ";
            this.diseñoButton1.TextColor = System.Drawing.Color.White;
            this.diseñoButton1.UseVisualStyleBackColor = true;
            this.diseñoButton1.Click += new System.EventHandler(this.diseñoButton1_Click);
            // 
            // Form_VerBiometria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(61)))), ((int)(((byte)(125)))));
            this.ClientSize = new System.Drawing.Size(358, 357);
            this.Controls.Add(this.diseñoButton1);
            this.Controls.Add(this.lbl_Titulo);
            this.Controls.Add(this.dtv_Biometria);
            this.Name = "Form_VerBiometria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_VerBiometria";
            this.Load += new System.EventHandler(this.Form_VerBiometria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtv_Biometria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtv_Biometria;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_TipoBiometria;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Descripcion;
        private System.Windows.Forms.Label lbl_Titulo;
        private Resources.DiseñoButton diseñoButton1;
    }
}