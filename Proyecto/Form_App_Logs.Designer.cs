namespace Proyecto
{
    partial class Form_App_Logs
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
            this.dtv_LogsApp = new System.Windows.Forms.DataGridView();
            this.col_Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Proceso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Accion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Host = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.check_Login = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtv_LogsApp)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Volver
            // 
            this.btn_Volver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Volver.Location = new System.Drawing.Point(12, 12);
            this.btn_Volver.Name = "btn_Volver";
            this.btn_Volver.Size = new System.Drawing.Size(108, 26);
            this.btn_Volver.TabIndex = 9;
            this.btn_Volver.Text = "Volver al menu";
            this.btn_Volver.UseVisualStyleBackColor = true;
            this.btn_Volver.Click += new System.EventHandler(this.btn_Volver_Click);
            // 
            // dtv_LogsApp
            // 
            this.dtv_LogsApp.AllowUserToAddRows = false;
            this.dtv_LogsApp.AllowUserToDeleteRows = false;
            this.dtv_LogsApp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtv_LogsApp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_Fecha,
            this.col_Proceso,
            this.col_Accion,
            this.col_Descripcion,
            this.col_Usuario,
            this.col_Host});
            this.dtv_LogsApp.Location = new System.Drawing.Point(12, 152);
            this.dtv_LogsApp.Name = "dtv_LogsApp";
            this.dtv_LogsApp.ReadOnly = true;
            this.dtv_LogsApp.Size = new System.Drawing.Size(776, 286);
            this.dtv_LogsApp.TabIndex = 10;
            // 
            // col_Fecha
            // 
            this.col_Fecha.HeaderText = "Fecha y Hora";
            this.col_Fecha.Name = "col_Fecha";
            this.col_Fecha.ReadOnly = true;
            // 
            // col_Proceso
            // 
            this.col_Proceso.HeaderText = "Proceso";
            this.col_Proceso.Name = "col_Proceso";
            this.col_Proceso.ReadOnly = true;
            // 
            // col_Accion
            // 
            this.col_Accion.HeaderText = "Accion";
            this.col_Accion.Name = "col_Accion";
            this.col_Accion.ReadOnly = true;
            // 
            // col_Descripcion
            // 
            this.col_Descripcion.HeaderText = "Descripcion";
            this.col_Descripcion.Name = "col_Descripcion";
            this.col_Descripcion.ReadOnly = true;
            // 
            // col_Usuario
            // 
            this.col_Usuario.HeaderText = "Usuario";
            this.col_Usuario.Name = "col_Usuario";
            this.col_Usuario.ReadOnly = true;
            // 
            // col_Host
            // 
            this.col_Host.HeaderText = "Host";
            this.col_Host.Name = "col_Host";
            this.col_Host.ReadOnly = true;
            // 
            // check_Login
            // 
            this.check_Login.AutoSize = true;
            this.check_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_Login.Location = new System.Drawing.Point(580, 122);
            this.check_Login.Name = "check_Login";
            this.check_Login.Size = new System.Drawing.Size(208, 24);
            this.check_Login.TabIndex = 12;
            this.check_Login.Text = "Dejar de ver Accion Login";
            this.check_Login.UseVisualStyleBackColor = true;
            this.check_Login.CheckedChanged += new System.EventHandler(this.check_Login_CheckedChanged);
            // 
            // Form_App_Logs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.check_Login);
            this.Controls.Add(this.dtv_LogsApp);
            this.Controls.Add(this.btn_Volver);
            this.Name = "Form_App_Logs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "App_Logs";
            this.Load += new System.EventHandler(this.Form_App_Logs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtv_LogsApp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Volver;
        private System.Windows.Forms.DataGridView dtv_LogsApp;
        private System.Windows.Forms.CheckBox check_Login;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Proceso;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Accion;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Host;
    }
}