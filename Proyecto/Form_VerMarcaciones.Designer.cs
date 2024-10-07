namespace Proyecto
{
    partial class Form_VerMarcaciones
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
            this.dtv_Marcaciones = new System.Windows.Forms.DataGridView();
            this.col_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_TipoMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_Buscador = new System.Windows.Forms.TextBox();
            this.lbl_Buscador = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtv_Marcaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Volver
            // 
            this.btn_Volver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Volver.Location = new System.Drawing.Point(10, 359);
            this.btn_Volver.Name = "btn_Volver";
            this.btn_Volver.Size = new System.Drawing.Size(115, 30);
            this.btn_Volver.TabIndex = 8;
            this.btn_Volver.Text = "Volver al menu\r\n";
            this.btn_Volver.UseVisualStyleBackColor = true;
            this.btn_Volver.Click += new System.EventHandler(this.btn_Volver_Click);
            // 
            // dtv_Marcaciones
            // 
            this.dtv_Marcaciones.AllowUserToAddRows = false;
            this.dtv_Marcaciones.AllowUserToDeleteRows = false;
            this.dtv_Marcaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtv_Marcaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_ID,
            this.col_Nombre,
            this.col_apellido,
            this.col_fecha,
            this.col_Hora,
            this.col_TipoMarca});
            this.dtv_Marcaciones.Location = new System.Drawing.Point(12, 64);
            this.dtv_Marcaciones.Name = "dtv_Marcaciones";
            this.dtv_Marcaciones.ReadOnly = true;
            this.dtv_Marcaciones.Size = new System.Drawing.Size(776, 267);
            this.dtv_Marcaciones.TabIndex = 9;
            // 
            // col_ID
            // 
            this.col_ID.HeaderText = "ID";
            this.col_ID.Name = "col_ID";
            this.col_ID.ReadOnly = true;
            // 
            // col_Nombre
            // 
            this.col_Nombre.HeaderText = "Nombre";
            this.col_Nombre.Name = "col_Nombre";
            this.col_Nombre.ReadOnly = true;
            // 
            // col_apellido
            // 
            this.col_apellido.HeaderText = "Apellido";
            this.col_apellido.Name = "col_apellido";
            this.col_apellido.ReadOnly = true;
            // 
            // col_fecha
            // 
            this.col_fecha.HeaderText = "Fecha";
            this.col_fecha.Name = "col_fecha";
            this.col_fecha.ReadOnly = true;
            // 
            // col_Hora
            // 
            this.col_Hora.HeaderText = "Hora";
            this.col_Hora.Name = "col_Hora";
            this.col_Hora.ReadOnly = true;
            // 
            // col_TipoMarca
            // 
            this.col_TipoMarca.HeaderText = "Marcaciones";
            this.col_TipoMarca.Name = "col_TipoMarca";
            this.col_TipoMarca.ReadOnly = true;
            // 
            // txt_Buscador
            // 
            this.txt_Buscador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Buscador.Location = new System.Drawing.Point(48, 25);
            this.txt_Buscador.Name = "txt_Buscador";
            this.txt_Buscador.Size = new System.Drawing.Size(180, 22);
            this.txt_Buscador.TabIndex = 11;
            this.txt_Buscador.TextChanged += new System.EventHandler(this.txt_Buscador_TextChanged);
            this.txt_Buscador.Enter += new System.EventHandler(this.txt_Buscador_Enter);
            this.txt_Buscador.Leave += new System.EventHandler(this.txt_Buscador_Leave);
            // 
            // lbl_Buscador
            // 
            this.lbl_Buscador.AutoSize = true;
            this.lbl_Buscador.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Buscador.Location = new System.Drawing.Point(8, 23);
            this.lbl_Buscador.Name = "lbl_Buscador";
            this.lbl_Buscador.Size = new System.Drawing.Size(34, 25);
            this.lbl_Buscador.TabIndex = 10;
            this.lbl_Buscador.Text = "🔎";
            // 
            // Form_VerMarcaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 402);
            this.Controls.Add(this.txt_Buscador);
            this.Controls.Add(this.lbl_Buscador);
            this.Controls.Add(this.dtv_Marcaciones);
            this.Controls.Add(this.btn_Volver);
            this.Name = "Form_VerMarcaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Marcaciones";
            this.Load += new System.EventHandler(this.Form_Marcaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtv_Marcaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Volver;
        private System.Windows.Forms.DataGridView dtv_Marcaciones;
        private System.Windows.Forms.TextBox txt_Buscador;
        private System.Windows.Forms.Label lbl_Buscador;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Hora;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_TipoMarca;
    }
}