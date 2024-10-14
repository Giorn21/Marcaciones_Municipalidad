namespace Proyecto
{
    partial class Form_VerMarcas
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
            this.dtv_TipoMarcas = new System.Windows.Forms.DataGridView();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.btn_Volver = new System.Windows.Forms.Button();
            this.col_Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Autorizacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtv_TipoMarcas)).BeginInit();
            this.SuspendLayout();
            // 
            // dtv_TipoMarcas
            // 
            this.dtv_TipoMarcas.AllowUserToAddRows = false;
            this.dtv_TipoMarcas.AllowUserToDeleteRows = false;
            this.dtv_TipoMarcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtv_TipoMarcas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_Descripcion,
            this.col_Autorizacion});
            this.dtv_TipoMarcas.Location = new System.Drawing.Point(12, 77);
            this.dtv_TipoMarcas.Name = "dtv_TipoMarcas";
            this.dtv_TipoMarcas.ReadOnly = true;
            this.dtv_TipoMarcas.Size = new System.Drawing.Size(334, 215);
            this.dtv_TipoMarcas.TabIndex = 0;
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.Location = new System.Drawing.Point(72, 9);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(194, 37);
            this.lbl_Titulo.TabIndex = 1;
            this.lbl_Titulo.Text = "Tipo Marcas";
            // 
            // btn_Volver
            // 
            this.btn_Volver.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Volver.Location = new System.Drawing.Point(12, 318);
            this.btn_Volver.Name = "btn_Volver";
            this.btn_Volver.Size = new System.Drawing.Size(75, 27);
            this.btn_Volver.TabIndex = 2;
            this.btn_Volver.Text = "Volver";
            this.btn_Volver.UseVisualStyleBackColor = true;
            this.btn_Volver.Click += new System.EventHandler(this.btn_Volver_Click_1);
            // 
            // col_Descripcion
            // 
            this.col_Descripcion.HeaderText = "Descripcion";
            this.col_Descripcion.Name = "col_Descripcion";
            // 
            // col_Autorizacion
            // 
            this.col_Autorizacion.HeaderText = "Autorizacion";
            this.col_Autorizacion.Name = "col_Autorizacion";
            // 
            // Form_VerMarcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 357);
            this.Controls.Add(this.btn_Volver);
            this.Controls.Add(this.lbl_Titulo);
            this.Controls.Add(this.dtv_TipoMarcas);
            this.Name = "Form_VerMarcas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_VerMarcas";
            this.Load += new System.EventHandler(this.Form_VerMarcas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtv_TipoMarcas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtv_TipoMarcas;
        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.Button btn_Volver;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Autorizacion;
    }
}