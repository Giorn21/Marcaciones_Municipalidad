namespace Proyecto
{
    partial class Form_VerMarcacion_Manual
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
            this.dtv_Marcaciones_Manuales = new System.Windows.Forms.DataGridView();
            this.col_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_TipoMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Comentario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Volver = new System.Windows.Forms.Button();
            this.txt_Buscador = new System.Windows.Forms.TextBox();
            this.lbl_Buscador = new System.Windows.Forms.Label();
            this.TSM_Registro = new System.Windows.Forms.ToolStripMenuItem();
            this.TSM_Nuevo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            ((System.ComponentModel.ISupportInitialize)(this.dtv_Marcaciones_Manuales)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtv_Marcaciones_Manuales
            // 
            this.dtv_Marcaciones_Manuales.AllowUserToAddRows = false;
            this.dtv_Marcaciones_Manuales.AllowUserToDeleteRows = false;
            this.dtv_Marcaciones_Manuales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtv_Marcaciones_Manuales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_ID,
            this.col_Nombre,
            this.col_Apellido,
            this.col_Fecha,
            this.col_Hora,
            this.col_TipoMarca,
            this.col_Comentario});
            this.dtv_Marcaciones_Manuales.Location = new System.Drawing.Point(12, 118);
            this.dtv_Marcaciones_Manuales.Name = "dtv_Marcaciones_Manuales";
            this.dtv_Marcaciones_Manuales.ReadOnly = true;
            this.dtv_Marcaciones_Manuales.Size = new System.Drawing.Size(776, 270);
            this.dtv_Marcaciones_Manuales.TabIndex = 0;
            // 
            // col_ID
            // 
            this.col_ID.HeaderText = "ID Funcionario";
            this.col_ID.Name = "col_ID";
            this.col_ID.ReadOnly = true;
            // 
            // col_Nombre
            // 
            this.col_Nombre.HeaderText = "Nombre";
            this.col_Nombre.Name = "col_Nombre";
            this.col_Nombre.ReadOnly = true;
            // 
            // col_Apellido
            // 
            this.col_Apellido.HeaderText = "Apellido";
            this.col_Apellido.Name = "col_Apellido";
            this.col_Apellido.ReadOnly = true;
            // 
            // col_Fecha
            // 
            this.col_Fecha.HeaderText = "Fecha";
            this.col_Fecha.Name = "col_Fecha";
            this.col_Fecha.ReadOnly = true;
            // 
            // col_Hora
            // 
            this.col_Hora.HeaderText = "Hora";
            this.col_Hora.Name = "col_Hora";
            this.col_Hora.ReadOnly = true;
            // 
            // col_TipoMarca
            // 
            this.col_TipoMarca.HeaderText = "TipoMarca";
            this.col_TipoMarca.Name = "col_TipoMarca";
            this.col_TipoMarca.ReadOnly = true;
            // 
            // col_Comentario
            // 
            this.col_Comentario.HeaderText = "Comentario";
            this.col_Comentario.Name = "col_Comentario";
            this.col_Comentario.ReadOnly = true;
            // 
            // btn_Volver
            // 
            this.btn_Volver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Volver.Location = new System.Drawing.Point(12, 410);
            this.btn_Volver.Name = "btn_Volver";
            this.btn_Volver.Size = new System.Drawing.Size(80, 31);
            this.btn_Volver.TabIndex = 2;
            this.btn_Volver.Text = "Volver";
            this.btn_Volver.UseVisualStyleBackColor = true;
            this.btn_Volver.Click += new System.EventHandler(this.btn_Volver_Click);
            // 
            // txt_Buscador
            // 
            this.txt_Buscador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Buscador.Location = new System.Drawing.Point(51, 82);
            this.txt_Buscador.Name = "txt_Buscador";
            this.txt_Buscador.Size = new System.Drawing.Size(202, 22);
            this.txt_Buscador.TabIndex = 4;
            this.txt_Buscador.TextChanged += new System.EventHandler(this.txt_Buscador_TextChanged);
            this.txt_Buscador.Enter += new System.EventHandler(this.txt_Buscador_Enter);
            this.txt_Buscador.Leave += new System.EventHandler(this.txt_Buscador_Leave);
            // 
            // lbl_Buscador
            // 
            this.lbl_Buscador.AutoSize = true;
            this.lbl_Buscador.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Buscador.Location = new System.Drawing.Point(11, 80);
            this.lbl_Buscador.Name = "lbl_Buscador";
            this.lbl_Buscador.Size = new System.Drawing.Size(34, 25);
            this.lbl_Buscador.TabIndex = 3;
            this.lbl_Buscador.Text = "🔎";
            // 
            // TSM_Registro
            // 
            this.TSM_Registro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSM_Nuevo});
            this.TSM_Registro.Name = "TSM_Registro";
            this.TSM_Registro.Size = new System.Drawing.Size(59, 20);
            this.TSM_Registro.Text = "registro";
            // 
            // TSM_Nuevo
            // 
            this.TSM_Nuevo.Name = "TSM_Nuevo";
            this.TSM_Nuevo.Size = new System.Drawing.Size(124, 22);
            this.TSM_Nuevo.Text = "NUEVO +";
            this.TSM_Nuevo.Click += new System.EventHandler(this.TSM_Nuevo_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSM_Registro});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Form_VerMarcacion_Manual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 453);
            this.Controls.Add(this.txt_Buscador);
            this.Controls.Add(this.lbl_Buscador);
            this.Controls.Add(this.btn_Volver);
            this.Controls.Add(this.dtv_Marcaciones_Manuales);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form_VerMarcacion_Manual";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_VerMarcacion_Manual";
            this.Load += new System.EventHandler(this.Form_VerMarcacion_Manual_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtv_Marcaciones_Manuales)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtv_Marcaciones_Manuales;
        private System.Windows.Forms.Button btn_Volver;
        private System.Windows.Forms.TextBox txt_Buscador;
        private System.Windows.Forms.Label lbl_Buscador;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Hora;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_TipoMarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Comentario;
        private System.Windows.Forms.ToolStripMenuItem TSM_Registro;
        private System.Windows.Forms.ToolStripMenuItem TSM_Nuevo;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}