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
            this.btn_Volver = new System.Windows.Forms.Button();
            this.dtv_Disp_Funcionarios = new System.Windows.Forms.DataGridView();
            this.Col_IdDispositivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_IdEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Sync = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtv_Disp_Funcionarios)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Volver
            // 
            this.btn_Volver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Volver.Location = new System.Drawing.Point(12, 12);
            this.btn_Volver.Name = "btn_Volver";
            this.btn_Volver.Size = new System.Drawing.Size(108, 26);
            this.btn_Volver.TabIndex = 8;
            this.btn_Volver.Text = "Volver al menu";
            this.btn_Volver.UseVisualStyleBackColor = true;
            this.btn_Volver.Click += new System.EventHandler(this.btn_Volver_Click);
            // 
            // dtv_Disp_Funcionarios
            // 
            this.dtv_Disp_Funcionarios.AllowUserToAddRows = false;
            this.dtv_Disp_Funcionarios.AllowUserToDeleteRows = false;
            this.dtv_Disp_Funcionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtv_Disp_Funcionarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_IdDispositivo,
            this.col_IdEmpleado,
            this.col_Sync});
            this.dtv_Disp_Funcionarios.Location = new System.Drawing.Point(12, 98);
            this.dtv_Disp_Funcionarios.Name = "dtv_Disp_Funcionarios";
            this.dtv_Disp_Funcionarios.ReadOnly = true;
            this.dtv_Disp_Funcionarios.Size = new System.Drawing.Size(776, 340);
            this.dtv_Disp_Funcionarios.TabIndex = 9;
            this.dtv_Disp_Funcionarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtv_Disp_Funcionarios_CellContentClick);
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
            // Form_Disp_Funcionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtv_Disp_Funcionarios);
            this.Controls.Add(this.btn_Volver);
            this.Name = "Form_Disp_Funcionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Disp_Funcionario";
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtv_Disp_Funcionarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Volver;
        private System.Windows.Forms.DataGridView dtv_Disp_Funcionarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_IdDispositivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_IdEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Sync;
    }
}