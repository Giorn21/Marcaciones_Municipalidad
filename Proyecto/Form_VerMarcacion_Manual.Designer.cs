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
            this.txt_Buscador = new System.Windows.Forms.TextBox();
            this.TSM_Registro = new System.Windows.Forms.ToolStripMenuItem();
            this.TSM_Nuevo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.col_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_TipoMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Comentario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diseñoButton1 = new Proyecto.Resources.DiseñoButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtv_Marcaciones_Manuales)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtv_Marcaciones_Manuales
            // 
            this.dtv_Marcaciones_Manuales.AllowUserToAddRows = false;
            this.dtv_Marcaciones_Manuales.AllowUserToDeleteRows = false;
            this.dtv_Marcaciones_Manuales.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtv_Marcaciones_Manuales.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.dtv_Marcaciones_Manuales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtv_Marcaciones_Manuales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_ID,
            this.col_Nombre,
            this.col_Apellido,
            this.col_Fecha,
            this.col_Hora,
            this.col_TipoMarca,
            this.col_Comentario});
            this.dtv_Marcaciones_Manuales.GridColor = System.Drawing.Color.Black;
            this.dtv_Marcaciones_Manuales.Location = new System.Drawing.Point(12, 150);
            this.dtv_Marcaciones_Manuales.Name = "dtv_Marcaciones_Manuales";
            this.dtv_Marcaciones_Manuales.ReadOnly = true;
            this.dtv_Marcaciones_Manuales.Size = new System.Drawing.Size(814, 290);
            this.dtv_Marcaciones_Manuales.TabIndex = 0;
            this.dtv_Marcaciones_Manuales.TabStop = false;
            // 
            // txt_Buscador
            // 
            this.txt_Buscador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Buscador.Location = new System.Drawing.Point(53, 114);
            this.txt_Buscador.Name = "txt_Buscador";
            this.txt_Buscador.Size = new System.Drawing.Size(207, 22);
            this.txt_Buscador.TabIndex = 0;
            this.txt_Buscador.TextChanged += new System.EventHandler(this.txt_Buscador_TextChanged);
            this.txt_Buscador.Enter += new System.EventHandler(this.txt_Buscador_Enter);
            this.txt_Buscador.Leave += new System.EventHandler(this.txt_Buscador_Leave);
            // 
            // TSM_Registro
            // 
            this.TSM_Registro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TSM_Registro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSM_Nuevo});
            this.TSM_Registro.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TSM_Registro.ForeColor = System.Drawing.Color.Black;
            this.TSM_Registro.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.TSM_Registro.Name = "TSM_Registro";
            this.TSM_Registro.Size = new System.Drawing.Size(94, 25);
            this.TSM_Registro.Text = "REGISTRO";
            // 
            // TSM_Nuevo
            // 
            this.TSM_Nuevo.BackColor = System.Drawing.SystemColors.Control;
            this.TSM_Nuevo.Name = "TSM_Nuevo";
            this.TSM_Nuevo.Size = new System.Drawing.Size(180, 26);
            this.TSM_Nuevo.Text = "NUEVO +";
            this.TSM_Nuevo.Click += new System.EventHandler(this.TSM_Nuevo_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(61)))), ((int)(((byte)(125)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSM_Registro});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(838, 29);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.ForeColor = System.Drawing.Color.White;
            this.lbl_Titulo.Location = new System.Drawing.Point(0, 29);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(838, 59);
            this.lbl_Titulo.TabIndex = 5;
            this.lbl_Titulo.Text = "Ver Marcaciones Manuales";
            this.lbl_Titulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(61)))), ((int)(((byte)(125)))));
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.Window;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 38;
            this.iconPictureBox1.Location = new System.Drawing.Point(9, 103);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(38, 41);
            this.iconPictureBox1.TabIndex = 13;
            this.iconPictureBox1.TabStop = false;
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
            this.col_Comentario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_Comentario.HeaderText = "Comentario";
            this.col_Comentario.Name = "col_Comentario";
            this.col_Comentario.ReadOnly = true;
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
            this.diseñoButton1.Location = new System.Drawing.Point(12, 449);
            this.diseñoButton1.Name = "diseñoButton1";
            this.diseñoButton1.Size = new System.Drawing.Size(114, 39);
            this.diseñoButton1.TabIndex = 1;
            this.diseñoButton1.Text = "Volver al MENÚ";
            this.diseñoButton1.TextColor = System.Drawing.Color.White;
            this.diseñoButton1.UseVisualStyleBackColor = true;
            this.diseñoButton1.Click += new System.EventHandler(this.diseñoButton1_Click);
            // 
            // Form_VerMarcacion_Manual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(61)))), ((int)(((byte)(125)))));
            this.ClientSize = new System.Drawing.Size(838, 500);
            this.Controls.Add(this.diseñoButton1);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.lbl_Titulo);
            this.Controls.Add(this.txt_Buscador);
            this.Controls.Add(this.dtv_Marcaciones_Manuales);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_VerMarcacion_Manual";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Marcaciones Manuales";
            this.Load += new System.EventHandler(this.Form_VerMarcacion_Manual_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtv_Marcaciones_Manuales)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtv_Marcaciones_Manuales;
        private System.Windows.Forms.TextBox txt_Buscador;
        private System.Windows.Forms.ToolStripMenuItem TSM_Registro;
        private System.Windows.Forms.ToolStripMenuItem TSM_Nuevo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label lbl_Titulo;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Resources.DiseñoButton diseñoButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Hora;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_TipoMarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Comentario;
    }
}