namespace Proyecto
{
    partial class Form_Disp_Funcionario
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
            this.dtv_Disp_Funcionarios = new System.Windows.Forms.DataGridView();
            this.Col_IdDispositivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_IdEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Sync = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.diseñoButton1 = new Proyecto.Resources.DiseñoButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtv_Disp_Funcionarios)).BeginInit();
            this.SuspendLayout();
            // 
            // dtv_Disp_Funcionarios
            // 
            this.dtv_Disp_Funcionarios.AllowUserToAddRows = false;
            this.dtv_Disp_Funcionarios.AllowUserToDeleteRows = false;
            this.dtv_Disp_Funcionarios.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.dtv_Disp_Funcionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtv_Disp_Funcionarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_IdDispositivo,
            this.col_IdEmpleado,
            this.col_Sync});
            this.dtv_Disp_Funcionarios.GridColor = System.Drawing.Color.Black;
            this.dtv_Disp_Funcionarios.Location = new System.Drawing.Point(12, 100);
            this.dtv_Disp_Funcionarios.Name = "dtv_Disp_Funcionarios";
            this.dtv_Disp_Funcionarios.ReadOnly = true;
            this.dtv_Disp_Funcionarios.Size = new System.Drawing.Size(558, 243);
            this.dtv_Disp_Funcionarios.TabIndex = 9;
            this.dtv_Disp_Funcionarios.TabStop = false;
            // 
            // Col_IdDispositivo
            // 
            this.Col_IdDispositivo.HeaderText = "ID Dispositivo";
            this.Col_IdDispositivo.Name = "Col_IdDispositivo";
            this.Col_IdDispositivo.ReadOnly = true;
            // 
            // col_IdEmpleado
            // 
            this.col_IdEmpleado.HeaderText = "ID Empleado";
            this.col_IdEmpleado.Name = "col_IdEmpleado";
            this.col_IdEmpleado.ReadOnly = true;
            // 
            // col_Sync
            // 
            this.col_Sync.HeaderText = "Sync";
            this.col_Sync.Name = "col_Sync";
            this.col_Sync.ReadOnly = true;
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.ForeColor = System.Drawing.Color.White;
            this.lbl_Titulo.Location = new System.Drawing.Point(174, 9);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(396, 88);
            this.lbl_Titulo.TabIndex = 10;
            this.lbl_Titulo.Text = "Ver Funcionarios con Dispositivos Asignado\r\ns";
            this.lbl_Titulo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.diseñoButton1.Location = new System.Drawing.Point(12, 12);
            this.diseñoButton1.Name = "diseñoButton1";
            this.diseñoButton1.Size = new System.Drawing.Size(114, 39);
            this.diseñoButton1.TabIndex = 0;
            this.diseñoButton1.Text = "Volver al MENÚ";
            this.diseñoButton1.TextColor = System.Drawing.Color.White;
            this.diseñoButton1.UseVisualStyleBackColor = false;
            this.diseñoButton1.Click += new System.EventHandler(this.diseñoButton1_Click);
            // 
            // Form_Disp_Funcionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(61)))), ((int)(((byte)(125)))));
            this.ClientSize = new System.Drawing.Size(582, 352);
            this.Controls.Add(this.diseñoButton1);
            this.Controls.Add(this.lbl_Titulo);
            this.Controls.Add(this.dtv_Disp_Funcionarios);
            this.Name = "Form_Disp_Funcionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Disp_Funcionario";
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtv_Disp_Funcionarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dtv_Disp_Funcionarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_IdDispositivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_IdEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Sync;
        private System.Windows.Forms.Label lbl_Titulo;
        private Resources.DiseñoButton diseñoButton1;
    }
}