namespace Proyecto
{
    partial class Form_VerUnidad
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
            this.dtv_TipoUnidad = new System.Windows.Forms.DataGridView();
            this.col_Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_IDUnidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Ubicacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diseñoIconButton1 = new Proyecto.Resources.DiseñoIconButton();
            this.diseñoButton1 = new Proyecto.Resources.DiseñoButton();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtv_TipoUnidad)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.ForeColor = System.Drawing.Color.White;
            this.lbl_Titulo.Location = new System.Drawing.Point(159, 9);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(296, 37);
            this.lbl_Titulo.TabIndex = 7;
            this.lbl_Titulo.Text = "Tipo Unidad (MOD)";
            // 
            // dtv_TipoUnidad
            // 
            this.dtv_TipoUnidad.AllowUserToAddRows = false;
            this.dtv_TipoUnidad.AllowUserToDeleteRows = false;
            this.dtv_TipoUnidad.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.dtv_TipoUnidad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtv_TipoUnidad.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_Direccion,
            this.col_IDUnidad,
            this.col_Descripcion,
            this.col_Ubicacion,
            this.col_Telefono,
            this.Col_Email});
            this.dtv_TipoUnidad.GridColor = System.Drawing.Color.Black;
            this.dtv_TipoUnidad.Location = new System.Drawing.Point(12, 82);
            this.dtv_TipoUnidad.Name = "dtv_TipoUnidad";
            this.dtv_TipoUnidad.ReadOnly = true;
            this.dtv_TipoUnidad.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtv_TipoUnidad.Size = new System.Drawing.Size(608, 215);
            this.dtv_TipoUnidad.TabIndex = 6;
            this.dtv_TipoUnidad.TabStop = false;
            this.dtv_TipoUnidad.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtv_TipoUnidad_CellDoubleClick);
            // 
            // col_Direccion
            // 
            this.col_Direccion.HeaderText = "Direccion";
            this.col_Direccion.Name = "col_Direccion";
            this.col_Direccion.ReadOnly = true;
            // 
            // col_IDUnidad
            // 
            this.col_IDUnidad.HeaderText = "ID Unidad";
            this.col_IDUnidad.Name = "col_IDUnidad";
            this.col_IDUnidad.ReadOnly = true;
            // 
            // col_Descripcion
            // 
            this.col_Descripcion.HeaderText = "Descripcion";
            this.col_Descripcion.Name = "col_Descripcion";
            this.col_Descripcion.ReadOnly = true;
            // 
            // col_Ubicacion
            // 
            this.col_Ubicacion.HeaderText = "Ubicacion";
            this.col_Ubicacion.Name = "col_Ubicacion";
            this.col_Ubicacion.ReadOnly = true;
            // 
            // col_Telefono
            // 
            this.col_Telefono.HeaderText = "Telefono";
            this.col_Telefono.Name = "col_Telefono";
            this.col_Telefono.ReadOnly = true;
            // 
            // Col_Email
            // 
            this.Col_Email.HeaderText = "Correo Electronico";
            this.Col_Email.Name = "Col_Email";
            this.Col_Email.ReadOnly = true;
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
            this.diseñoIconButton1.IconChar = FontAwesome.Sharp.IconChar.Building;
            this.diseñoIconButton1.IconColor = System.Drawing.SystemColors.Window;
            this.diseñoIconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.diseñoIconButton1.IconSize = 35;
            this.diseñoIconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.diseñoIconButton1.Location = new System.Drawing.Point(479, 312);
            this.diseñoIconButton1.Name = "diseñoIconButton1";
            this.diseñoIconButton1.Size = new System.Drawing.Size(141, 41);
            this.diseñoIconButton1.TabIndex = 0;
            this.diseñoIconButton1.Text = "Agregar Nueva Unidad";
            this.diseñoIconButton1.TextColor = System.Drawing.Color.White;
            this.diseñoIconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.diseñoIconButton1.UseVisualStyleBackColor = false;
            this.diseñoIconButton1.Click += new System.EventHandler(this.diseñoIconButton1_Click);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 16);
            this.label1.TabIndex = 24;
            this.label1.Text = "Doble Click para Editar Una Unida";
            // 
            // Form_VerUnidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(61)))), ((int)(((byte)(125)))));
            this.ClientSize = new System.Drawing.Size(632, 365);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.diseñoButton1);
            this.Controls.Add(this.diseñoIconButton1);
            this.Controls.Add(this.lbl_Titulo);
            this.Controls.Add(this.dtv_TipoUnidad);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_VerUnidad";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ver Unidad";
            this.Load += new System.EventHandler(this.Form_VerUnidad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtv_TipoUnidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.DataGridView dtv_TipoUnidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_IDUnidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Ubicacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Email;
        private Resources.DiseñoIconButton diseñoIconButton1;
        private Resources.DiseñoButton diseñoButton1;
        private System.Windows.Forms.Label label1;
    }
}