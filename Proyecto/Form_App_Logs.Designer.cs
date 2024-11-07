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
            this.dtv_LogsApp = new System.Windows.Forms.DataGridView();
            this.col_Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Proceso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Accion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Host = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.check_Login = new System.Windows.Forms.CheckBox();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.diseñoButton1 = new Proyecto.Resources.DiseñoButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtv_LogsApp)).BeginInit();
            this.SuspendLayout();
            // 
            // dtv_LogsApp
            // 
            this.dtv_LogsApp.AllowUserToAddRows = false;
            this.dtv_LogsApp.AllowUserToDeleteRows = false;
            this.dtv_LogsApp.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.dtv_LogsApp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtv_LogsApp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_Fecha,
            this.col_Proceso,
            this.col_Accion,
            this.col_Descripcion,
            this.col_Usuario,
            this.col_Host});
            this.dtv_LogsApp.GridColor = System.Drawing.Color.Black;
            this.dtv_LogsApp.Location = new System.Drawing.Point(12, 110);
            this.dtv_LogsApp.Name = "dtv_LogsApp";
            this.dtv_LogsApp.ReadOnly = true;
            this.dtv_LogsApp.Size = new System.Drawing.Size(776, 286);
            this.dtv_LogsApp.TabIndex = 10;
            this.dtv_LogsApp.TabStop = false;
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
            this.check_Login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.check_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_Login.ForeColor = System.Drawing.Color.White;
            this.check_Login.Location = new System.Drawing.Point(12, 80);
            this.check_Login.Name = "check_Login";
            this.check_Login.Size = new System.Drawing.Size(100, 24);
            this.check_Login.TabIndex = 0;
            this.check_Login.Text = "ver Logins";
            this.check_Login.UseVisualStyleBackColor = true;
            this.check_Login.CheckedChanged += new System.EventHandler(this.check_Login_CheckedChanged);
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.ForeColor = System.Drawing.Color.White;
            this.lbl_Titulo.Location = new System.Drawing.Point(215, 29);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(561, 62);
            this.lbl_Titulo.TabIndex = 13;
            this.lbl_Titulo.Text = "Bitácora de Acciones realizadas ";
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
            this.diseñoButton1.Location = new System.Drawing.Point(12, 419);
            this.diseñoButton1.Name = "diseñoButton1";
            this.diseñoButton1.Size = new System.Drawing.Size(114, 39);
            this.diseñoButton1.TabIndex = 1;
            this.diseñoButton1.Text = "Volver al MENÚ";
            this.diseñoButton1.TextColor = System.Drawing.Color.White;
            this.diseñoButton1.UseVisualStyleBackColor = false;
            this.diseñoButton1.Click += new System.EventHandler(this.diseñoButton1_Click);
            // 
            // Form_App_Logs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(61)))), ((int)(((byte)(125)))));
            this.ClientSize = new System.Drawing.Size(800, 470);
            this.Controls.Add(this.diseñoButton1);
            this.Controls.Add(this.lbl_Titulo);
            this.Controls.Add(this.check_Login);
            this.Controls.Add(this.dtv_LogsApp);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_App_Logs";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ver Logs";
            this.Load += new System.EventHandler(this.Form_App_Logs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtv_LogsApp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dtv_LogsApp;
        private System.Windows.Forms.CheckBox check_Login;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Proceso;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Accion;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Host;
        private System.Windows.Forms.Label lbl_Titulo;
        private Resources.DiseñoButton diseñoButton1;
    }
}