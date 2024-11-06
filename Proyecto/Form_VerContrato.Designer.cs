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
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.dtv_TipoContrato = new System.Windows.Forms.DataGridView();
            this.col_TipoContrato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diseñoButton1 = new Proyecto.Resources.DiseñoButton();
            this.diseñoIconButton1 = new Proyecto.Resources.DiseñoIconButton();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtv_TipoContrato)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.ForeColor = System.Drawing.Color.White;
            this.lbl_Titulo.Location = new System.Drawing.Point(12, 9);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(318, 37);
            this.lbl_Titulo.TabIndex = 4;
            this.lbl_Titulo.Text = "Tipo Contrato (MOD)";
            // 
            // dtv_TipoContrato
            // 
            this.dtv_TipoContrato.AllowUserToAddRows = false;
            this.dtv_TipoContrato.AllowUserToDeleteRows = false;
            this.dtv_TipoContrato.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.dtv_TipoContrato.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtv_TipoContrato.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_TipoContrato,
            this.col_Descripcion});
            this.dtv_TipoContrato.GridColor = System.Drawing.Color.Black;
            this.dtv_TipoContrato.Location = new System.Drawing.Point(12, 87);
            this.dtv_TipoContrato.Name = "dtv_TipoContrato";
            this.dtv_TipoContrato.ReadOnly = true;
            this.dtv_TipoContrato.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtv_TipoContrato.Size = new System.Drawing.Size(334, 205);
            this.dtv_TipoContrato.TabIndex = 3;
            this.dtv_TipoContrato.TabStop = false;
            this.dtv_TipoContrato.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtv_TipoContrato_CellDoubleClick);
            // 
            // col_TipoContrato
            // 
            this.col_TipoContrato.HeaderText = "Tipo Contrato";
            this.col_TipoContrato.Name = "col_TipoContrato";
            this.col_TipoContrato.ReadOnly = true;
            // 
            // col_Descripcion
            // 
            this.col_Descripcion.HeaderText = "Descripcion";
            this.col_Descripcion.Name = "col_Descripcion";
            this.col_Descripcion.ReadOnly = true;
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
            this.diseñoButton1.Location = new System.Drawing.Point(12, 312);
            this.diseñoButton1.Name = "diseñoButton1";
            this.diseñoButton1.Size = new System.Drawing.Size(114, 39);
            this.diseñoButton1.TabIndex = 1;
            this.diseñoButton1.Text = "Volver al MENÚ";
            this.diseñoButton1.TextColor = System.Drawing.Color.White;
            this.diseñoButton1.UseVisualStyleBackColor = false;
            this.diseñoButton1.Click += new System.EventHandler(this.diseñoButton1_Click);
            // 
            // diseñoIconButton1
            // 
            this.diseñoIconButton1.BackColor = System.Drawing.Color.OliveDrab;
            this.diseñoIconButton1.BackgroundColor = System.Drawing.Color.OliveDrab;
            this.diseñoIconButton1.BorderColor = System.Drawing.Color.Green;
            this.diseñoIconButton1.BorderRadius = 20;
            this.diseñoIconButton1.BorderSize = 2;
            this.diseñoIconButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.diseñoIconButton1.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.diseñoIconButton1.FlatAppearance.BorderSize = 3;
            this.diseñoIconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.diseñoIconButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diseñoIconButton1.ForeColor = System.Drawing.Color.White;
            this.diseñoIconButton1.IconChar = FontAwesome.Sharp.IconChar.FileCirclePlus;
            this.diseñoIconButton1.IconColor = System.Drawing.SystemColors.Window;
            this.diseñoIconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.diseñoIconButton1.IconSize = 35;
            this.diseñoIconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.diseñoIconButton1.Location = new System.Drawing.Point(205, 312);
            this.diseñoIconButton1.Name = "diseñoIconButton1";
            this.diseñoIconButton1.Size = new System.Drawing.Size(141, 41);
            this.diseñoIconButton1.TabIndex = 0;
            this.diseñoIconButton1.Text = "Agregar Nuevo Contrato";
            this.diseñoIconButton1.TextColor = System.Drawing.Color.White;
            this.diseñoIconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.diseñoIconButton1.UseVisualStyleBackColor = false;
            this.diseñoIconButton1.Click += new System.EventHandler(this.diseñoIconButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "Doble Click para Editar la Descripcion";
            // 
            // Form_VerContrato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(61)))), ((int)(((byte)(125)))));
            this.ClientSize = new System.Drawing.Size(358, 357);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.diseñoIconButton1);
            this.Controls.Add(this.diseñoButton1);
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
        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.DataGridView dtv_TipoContrato;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_TipoContrato;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Descripcion;
        private Resources.DiseñoButton diseñoButton1;
        private Resources.DiseñoIconButton diseñoIconButton1;
        private System.Windows.Forms.Label label1;
    }
}