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
            this.btn_Volver = new System.Windows.Forms.Button();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtv_Biometria)).BeginInit();
            this.SuspendLayout();
            // 
            // dtv_Biometria
            // 
            this.dtv_Biometria.AllowUserToAddRows = false;
            this.dtv_Biometria.AllowUserToDeleteRows = false;
            this.dtv_Biometria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtv_Biometria.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_TipoBiometria,
            this.col_Descripcion});
            this.dtv_Biometria.Location = new System.Drawing.Point(12, 75);
            this.dtv_Biometria.Name = "dtv_Biometria";
            this.dtv_Biometria.ReadOnly = true;
            this.dtv_Biometria.Size = new System.Drawing.Size(330, 215);
            this.dtv_Biometria.TabIndex = 0;
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
            // btn_Volver
            // 
            this.btn_Volver.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Volver.Location = new System.Drawing.Point(12, 318);
            this.btn_Volver.Name = "btn_Volver";
            this.btn_Volver.Size = new System.Drawing.Size(75, 27);
            this.btn_Volver.TabIndex = 1;
            this.btn_Volver.Text = "Volver";
            this.btn_Volver.UseVisualStyleBackColor = true;
            this.btn_Volver.Click += new System.EventHandler(this.btn_Volver_Click);
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.Location = new System.Drawing.Point(62, 9);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(224, 37);
            this.lbl_Titulo.TabIndex = 2;
            this.lbl_Titulo.Text = "Tipo Biometria";
            // 
            // Form_VerBiometria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 357);
            this.Controls.Add(this.lbl_Titulo);
            this.Controls.Add(this.btn_Volver);
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
        private System.Windows.Forms.Button btn_Volver;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_TipoBiometria;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Descripcion;
        private System.Windows.Forms.Label lbl_Titulo;
    }
}