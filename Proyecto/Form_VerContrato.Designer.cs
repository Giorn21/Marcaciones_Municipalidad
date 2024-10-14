namespace Proyecto
{
    partial class Form_VerContrato
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
            this.btn_Volver = new System.Windows.Forms.Button();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.dtv_TipoContrato = new System.Windows.Forms.DataGridView();
            this.col_TipoContrato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtv_TipoContrato)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Volver
            // 
            this.btn_Volver.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Volver.Location = new System.Drawing.Point(12, 318);
            this.btn_Volver.Name = "btn_Volver";
            this.btn_Volver.Size = new System.Drawing.Size(75, 27);
            this.btn_Volver.TabIndex = 5;
            this.btn_Volver.Text = "Volver";
            this.btn_Volver.UseVisualStyleBackColor = true;
            this.btn_Volver.Click += new System.EventHandler(this.btn_Volver_Click);
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.Location = new System.Drawing.Point(72, 9);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(213, 37);
            this.lbl_Titulo.TabIndex = 4;
            this.lbl_Titulo.Text = "Tipo Contrato";
            // 
            // dtv_TipoContrato
            // 
            this.dtv_TipoContrato.AllowUserToAddRows = false;
            this.dtv_TipoContrato.AllowUserToDeleteRows = false;
            this.dtv_TipoContrato.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtv_TipoContrato.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_TipoContrato,
            this.col_Descripcion});
            this.dtv_TipoContrato.Location = new System.Drawing.Point(12, 77);
            this.dtv_TipoContrato.Name = "dtv_TipoContrato";
            this.dtv_TipoContrato.ReadOnly = true;
            this.dtv_TipoContrato.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtv_TipoContrato.Size = new System.Drawing.Size(334, 215);
            this.dtv_TipoContrato.TabIndex = 3;
            this.dtv_TipoContrato.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtv_TipoContrato_CellDoubleClick);
            // 
            // col_TipoContrato
            // 
            this.col_TipoContrato.HeaderText = "Tipo Contrato";
            this.col_TipoContrato.Name = "col_TipoContrato";
            // 
            // col_Descripcion
            // 
            this.col_Descripcion.HeaderText = "Descripcion";
            this.col_Descripcion.Name = "col_Descripcion";
            // 
            // Form_VerContrato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 357);
            this.Controls.Add(this.btn_Volver);
            this.Controls.Add(this.lbl_Titulo);
            this.Controls.Add(this.dtv_TipoContrato);
            this.Name = "Form_VerContrato";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_TipoContrato";
            this.Load += new System.EventHandler(this.Form_VerContrato_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtv_TipoContrato)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Volver;
        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.DataGridView dtv_TipoContrato;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_TipoContrato;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Descripcion;
    }
}