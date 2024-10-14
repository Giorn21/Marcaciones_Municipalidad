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
            this.btn_Volver = new System.Windows.Forms.Button();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.dtv_TipoUnidad = new System.Windows.Forms.DataGridView();
            this.col_Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_IDUnidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Ubicacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Agregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtv_TipoUnidad)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Volver
            // 
            this.btn_Volver.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Volver.Location = new System.Drawing.Point(12, 318);
            this.btn_Volver.Name = "btn_Volver";
            this.btn_Volver.Size = new System.Drawing.Size(75, 27);
            this.btn_Volver.TabIndex = 8;
            this.btn_Volver.Text = "Volver";
            this.btn_Volver.UseVisualStyleBackColor = true;
            this.btn_Volver.Click += new System.EventHandler(this.btn_Volver_Click);
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.Location = new System.Drawing.Point(206, 9);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(191, 37);
            this.lbl_Titulo.TabIndex = 7;
            this.lbl_Titulo.Text = "Tipo Unidad";
            // 
            // dtv_TipoUnidad
            // 
            this.dtv_TipoUnidad.AllowUserToAddRows = false;
            this.dtv_TipoUnidad.AllowUserToDeleteRows = false;
            this.dtv_TipoUnidad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtv_TipoUnidad.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_Direccion,
            this.col_IDUnidad,
            this.col_Descripcion,
            this.col_Ubicacion,
            this.col_Telefono,
            this.Col_Email});
            this.dtv_TipoUnidad.Location = new System.Drawing.Point(12, 76);
            this.dtv_TipoUnidad.Name = "dtv_TipoUnidad";
            this.dtv_TipoUnidad.ReadOnly = true;
            this.dtv_TipoUnidad.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtv_TipoUnidad.Size = new System.Drawing.Size(608, 215);
            this.dtv_TipoUnidad.TabIndex = 6;
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
            // btn_Agregar
            // 
            this.btn_Agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Agregar.Location = new System.Drawing.Point(545, 318);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(75, 27);
            this.btn_Agregar.TabIndex = 9;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.UseVisualStyleBackColor = true;
            // 
            // Form_VerUnidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 357);
            this.Controls.Add(this.btn_Agregar);
            this.Controls.Add(this.btn_Volver);
            this.Controls.Add(this.lbl_Titulo);
            this.Controls.Add(this.dtv_TipoUnidad);
            this.Name = "Form_VerUnidad";
            this.Text = "Form_VerUnidad";
            ((System.ComponentModel.ISupportInitialize)(this.dtv_TipoUnidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Volver;
        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.DataGridView dtv_TipoUnidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_IDUnidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Ubicacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Email;
        private System.Windows.Forms.Button btn_Agregar;
    }
}