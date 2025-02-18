﻿namespace Proyecto
{
    partial class Form_Dispositivos
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
            this.dtv_Dispositivos = new System.Windows.Forms.DataGridView();
            this.col_IdDispositivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_IP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Mac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Ubicacino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_PushProtocol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_UploadFlag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_LastActivityLog = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_LastActivityOP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.diseñoButton1 = new Proyecto.Resources.DiseñoButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtv_Dispositivos)).BeginInit();
            this.SuspendLayout();
            // 
            // dtv_Dispositivos
            // 
            this.dtv_Dispositivos.AllowUserToAddRows = false;
            this.dtv_Dispositivos.AllowUserToDeleteRows = false;
            this.dtv_Dispositivos.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.dtv_Dispositivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtv_Dispositivos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_IdDispositivo,
            this.col_Descripcion,
            this.col_IP,
            this.col_Mac,
            this.col_Ubicacino,
            this.col_PushProtocol,
            this.col_UploadFlag,
            this.col_LastActivityLog,
            this.col_LastActivityOP});
            this.dtv_Dispositivos.GridColor = System.Drawing.Color.Black;
            this.dtv_Dispositivos.Location = new System.Drawing.Point(12, 81);
            this.dtv_Dispositivos.Name = "dtv_Dispositivos";
            this.dtv_Dispositivos.ReadOnly = true;
            this.dtv_Dispositivos.Size = new System.Drawing.Size(869, 310);
            this.dtv_Dispositivos.TabIndex = 9;
            this.dtv_Dispositivos.TabStop = false;
            // 
            // col_IdDispositivo
            // 
            this.col_IdDispositivo.HeaderText = "ID Dispositivo";
            this.col_IdDispositivo.Name = "col_IdDispositivo";
            this.col_IdDispositivo.ReadOnly = true;
            // 
            // col_Descripcion
            // 
            this.col_Descripcion.HeaderText = "Descripcion";
            this.col_Descripcion.Name = "col_Descripcion";
            this.col_Descripcion.ReadOnly = true;
            // 
            // col_IP
            // 
            this.col_IP.HeaderText = "IP";
            this.col_IP.Name = "col_IP";
            this.col_IP.ReadOnly = true;
            // 
            // col_Mac
            // 
            this.col_Mac.HeaderText = "MAC";
            this.col_Mac.Name = "col_Mac";
            this.col_Mac.ReadOnly = true;
            // 
            // col_Ubicacino
            // 
            this.col_Ubicacino.HeaderText = "Ubicacino";
            this.col_Ubicacino.Name = "col_Ubicacino";
            this.col_Ubicacino.ReadOnly = true;
            // 
            // col_PushProtocol
            // 
            this.col_PushProtocol.HeaderText = "PushProtocol";
            this.col_PushProtocol.Name = "col_PushProtocol";
            this.col_PushProtocol.ReadOnly = true;
            // 
            // col_UploadFlag
            // 
            this.col_UploadFlag.HeaderText = "UploadFlag";
            this.col_UploadFlag.Name = "col_UploadFlag";
            this.col_UploadFlag.ReadOnly = true;
            // 
            // col_LastActivityLog
            // 
            this.col_LastActivityLog.HeaderText = "Última actividad";
            this.col_LastActivityLog.Name = "col_LastActivityLog";
            this.col_LastActivityLog.ReadOnly = true;
            // 
            // col_LastActivityOP
            // 
            this.col_LastActivityOP.HeaderText = "ultima actualizacion";
            this.col_LastActivityOP.Name = "col_LastActivityOP";
            this.col_LastActivityOP.ReadOnly = true;
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.ForeColor = System.Drawing.Color.White;
            this.lbl_Titulo.Location = new System.Drawing.Point(271, 9);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(357, 42);
            this.lbl_Titulo.TabIndex = 10;
            this.lbl_Titulo.Text = "Ver Los Dispositivos";
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
            this.diseñoButton1.Location = new System.Drawing.Point(12, 412);
            this.diseñoButton1.Name = "diseñoButton1";
            this.diseñoButton1.Size = new System.Drawing.Size(114, 39);
            this.diseñoButton1.TabIndex = 0;
            this.diseñoButton1.Text = "Volver al MENÚ";
            this.diseñoButton1.TextColor = System.Drawing.Color.White;
            this.diseñoButton1.UseVisualStyleBackColor = true;
            this.diseñoButton1.Click += new System.EventHandler(this.diseñoButton1_Click);
            // 
            // Form_Dispositivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(61)))), ((int)(((byte)(125)))));
            this.ClientSize = new System.Drawing.Size(893, 463);
            this.Controls.Add(this.diseñoButton1);
            this.Controls.Add(this.lbl_Titulo);
            this.Controls.Add(this.dtv_Dispositivos);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Dispositivos";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ver Dispositivos";
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtv_Dispositivos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dtv_Dispositivos;
        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_IdDispositivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_IP;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Mac;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Ubicacino;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_PushProtocol;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_UploadFlag;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_LastActivityLog;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_LastActivityOP;
        private Resources.DiseñoButton diseñoButton1;
    }
}