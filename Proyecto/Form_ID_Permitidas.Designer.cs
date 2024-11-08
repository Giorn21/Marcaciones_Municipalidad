namespace Proyecto
{
    partial class Form_ID_Permitidas
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
            this.dtv_Ayuda = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.diseñoButton1 = new Proyecto.Resources.DiseñoButton();
            this.col_IdPermitida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtv_Ayuda)).BeginInit();
            this.SuspendLayout();
            // 
            // dtv_Ayuda
            // 
            this.dtv_Ayuda.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.dtv_Ayuda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtv_Ayuda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_IdPermitida,
            this.col_Nombre});
            this.dtv_Ayuda.GridColor = System.Drawing.Color.Black;
            this.dtv_Ayuda.Location = new System.Drawing.Point(12, 54);
            this.dtv_Ayuda.Name = "dtv_Ayuda";
            this.dtv_Ayuda.Size = new System.Drawing.Size(291, 150);
            this.dtv_Ayuda.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(127, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // diseñoButton1
            // 
            this.diseñoButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(61)))), ((int)(((byte)(125)))));
            this.diseñoButton1.BorderColor = System.Drawing.Color.Gray;
            this.diseñoButton1.BorderRadius = 40;
            this.diseñoButton1.BorderSize = 0;
            this.diseñoButton1.FlatAppearance.BorderSize = 0;
            this.diseñoButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.diseñoButton1.ForeColor = System.Drawing.Color.White;
            this.diseñoButton1.Location = new System.Drawing.Point(12, 216);
            this.diseñoButton1.Name = "diseñoButton1";
            this.diseñoButton1.Size = new System.Drawing.Size(111, 40);
            this.diseñoButton1.TabIndex = 2;
            this.diseñoButton1.Text = "CERRAR";
            this.diseñoButton1.TextColor = System.Drawing.Color.White;
            this.diseñoButton1.UseVisualStyleBackColor = true;
            this.diseñoButton1.Click += new System.EventHandler(this.diseñoButton1_Click);
            // 
            // col_IdPermitida
            // 
            this.col_IdPermitida.HeaderText = "ID Permitidas";
            this.col_IdPermitida.Name = "col_IdPermitida";
            // 
            // col_Nombre
            // 
            this.col_Nombre.HeaderText = "Nombre";
            this.col_Nombre.Name = "col_Nombre";
            // 
            // Form_ID_Permitidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(61)))), ((int)(((byte)(125)))));
            this.ClientSize = new System.Drawing.Size(315, 268);
            this.Controls.Add(this.diseñoButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtv_Ayuda);
            this.Name = "Form_ID_Permitidas";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "ID Permitidas";
            this.Load += new System.EventHandler(this.Form_ID_Permitidas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtv_Ayuda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtv_Ayuda;
        private System.Windows.Forms.Label label1;
        private Resources.DiseñoButton diseñoButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_IdPermitida;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Nombre;
    }
}