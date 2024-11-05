namespace Proyecto
{
    partial class Form_VerFuncionarios
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
            this.dtv_BaseDatos = new System.Windows.Forms.DataGridView();
            this.Col_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Rut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_ApellidoPaterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_ApellidoMaterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Foto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_TipoContrato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_IdCargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_IdUnidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_IdDispositivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_Buscador = new System.Windows.Forms.TextBox();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.diseñoIconButton1 = new Proyecto.Resources.DiseñoIconButton();
            this.diseñoIconButton2 = new Proyecto.Resources.DiseñoIconButton();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.diseñoButton1 = new Proyecto.Resources.DiseñoButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtv_BaseDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtv_BaseDatos
            // 
            this.dtv_BaseDatos.AllowUserToAddRows = false;
            this.dtv_BaseDatos.AllowUserToDeleteRows = false;
            this.dtv_BaseDatos.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.dtv_BaseDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtv_BaseDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_Id,
            this.Col_Rut,
            this.Col_Nombre,
            this.Col_ApellidoPaterno,
            this.Col_ApellidoMaterno,
            this.col_Foto,
            this.col_Email,
            this.col_TipoContrato,
            this.col_IdCargo,
            this.col_IdUnidad,
            this.col_IdDispositivo});
            this.dtv_BaseDatos.GridColor = System.Drawing.Color.Black;
            this.dtv_BaseDatos.Location = new System.Drawing.Point(12, 135);
            this.dtv_BaseDatos.Name = "dtv_BaseDatos";
            this.dtv_BaseDatos.ReadOnly = true;
            this.dtv_BaseDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtv_BaseDatos.Size = new System.Drawing.Size(1050, 356);
            this.dtv_BaseDatos.TabIndex = 0;
            this.dtv_BaseDatos.AlternatingRowsDefaultCellStyleChanged += new System.EventHandler(this.txt_Buscador_TextChanged);
            this.dtv_BaseDatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtv_BaseDatos_CellContentClick);
            // 
            // Col_Id
            // 
            this.Col_Id.HeaderText = "IdEmpleado";
            this.Col_Id.Name = "Col_Id";
            this.Col_Id.ReadOnly = true;
            // 
            // Col_Rut
            // 
            this.Col_Rut.HeaderText = "Rut";
            this.Col_Rut.Name = "Col_Rut";
            this.Col_Rut.ReadOnly = true;
            // 
            // Col_Nombre
            // 
            this.Col_Nombre.HeaderText = "Nombres";
            this.Col_Nombre.Name = "Col_Nombre";
            this.Col_Nombre.ReadOnly = true;
            // 
            // Col_ApellidoPaterno
            // 
            this.Col_ApellidoPaterno.HeaderText = "Apellido Paterno";
            this.Col_ApellidoPaterno.Name = "Col_ApellidoPaterno";
            this.Col_ApellidoPaterno.ReadOnly = true;
            // 
            // Col_ApellidoMaterno
            // 
            this.Col_ApellidoMaterno.HeaderText = "Apellido Materno";
            this.Col_ApellidoMaterno.Name = "Col_ApellidoMaterno";
            this.Col_ApellidoMaterno.ReadOnly = true;
            // 
            // col_Foto
            // 
            this.col_Foto.HeaderText = "Foto";
            this.col_Foto.Name = "col_Foto";
            this.col_Foto.ReadOnly = true;
            // 
            // col_Email
            // 
            this.col_Email.HeaderText = "Email";
            this.col_Email.Name = "col_Email";
            this.col_Email.ReadOnly = true;
            // 
            // col_TipoContrato
            // 
            this.col_TipoContrato.HeaderText = "Tipo de Contrato";
            this.col_TipoContrato.Name = "col_TipoContrato";
            this.col_TipoContrato.ReadOnly = true;
            // 
            // col_IdCargo
            // 
            this.col_IdCargo.HeaderText = "Cargo";
            this.col_IdCargo.Name = "col_IdCargo";
            this.col_IdCargo.ReadOnly = true;
            // 
            // col_IdUnidad
            // 
            this.col_IdUnidad.HeaderText = "Unidad";
            this.col_IdUnidad.Name = "col_IdUnidad";
            this.col_IdUnidad.ReadOnly = true;
            // 
            // col_IdDispositivo
            // 
            this.col_IdDispositivo.HeaderText = "ID Dispositivo";
            this.col_IdDispositivo.Name = "col_IdDispositivo";
            this.col_IdDispositivo.ReadOnly = true;
            // 
            // txt_Buscador
            // 
            this.txt_Buscador.Location = new System.Drawing.Point(56, 95);
            this.txt_Buscador.Name = "txt_Buscador";
            this.txt_Buscador.Size = new System.Drawing.Size(198, 20);
            this.txt_Buscador.TabIndex = 2;
            this.txt_Buscador.TextChanged += new System.EventHandler(this.txt_Buscador_TextChanged);
            this.txt_Buscador.Enter += new System.EventHandler(this.txt_Buscador_Enter);
            this.txt_Buscador.Leave += new System.EventHandler(this.txt_Buscador_Leave);
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_Titulo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_Titulo.Location = new System.Drawing.Point(559, 9);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(503, 116);
            this.lbl_Titulo.TabIndex = 9;
            this.lbl_Titulo.Text = "Lista De Funcionarios";
            this.lbl_Titulo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.diseñoIconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.diseñoIconButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diseñoIconButton1.ForeColor = System.Drawing.Color.White;
            this.diseñoIconButton1.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.diseñoIconButton1.IconColor = System.Drawing.SystemColors.Window;
            this.diseñoIconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.diseñoIconButton1.IconSize = 35;
            this.diseñoIconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.diseñoIconButton1.Location = new System.Drawing.Point(274, 84);
            this.diseñoIconButton1.Name = "diseñoIconButton1";
            this.diseñoIconButton1.Size = new System.Drawing.Size(125, 41);
            this.diseñoIconButton1.TabIndex = 10;
            this.diseñoIconButton1.Text = "Agregar Funcionario";
            this.diseñoIconButton1.TextColor = System.Drawing.Color.White;
            this.diseñoIconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.diseñoIconButton1.UseVisualStyleBackColor = false;
            this.diseñoIconButton1.Click += new System.EventHandler(this.diseñoIconButton1_Click);
            // 
            // diseñoIconButton2
            // 
            this.diseñoIconButton2.BackColor = System.Drawing.Color.IndianRed;
            this.diseñoIconButton2.BackgroundColor = System.Drawing.Color.IndianRed;
            this.diseñoIconButton2.BorderColor = System.Drawing.Color.Red;
            this.diseñoIconButton2.BorderRadius = 20;
            this.diseñoIconButton2.BorderSize = 2;
            this.diseñoIconButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.diseñoIconButton2.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.diseñoIconButton2.FlatAppearance.BorderSize = 2;
            this.diseñoIconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.diseñoIconButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diseñoIconButton2.ForeColor = System.Drawing.Color.White;
            this.diseñoIconButton2.IconChar = FontAwesome.Sharp.IconChar.UserSlash;
            this.diseñoIconButton2.IconColor = System.Drawing.SystemColors.Window;
            this.diseñoIconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.diseñoIconButton2.IconSize = 35;
            this.diseñoIconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.diseñoIconButton2.Location = new System.Drawing.Point(428, 84);
            this.diseñoIconButton2.Name = "diseñoIconButton2";
            this.diseñoIconButton2.Size = new System.Drawing.Size(125, 41);
            this.diseñoIconButton2.TabIndex = 10;
            this.diseñoIconButton2.Text = "Desvincular Usuario";
            this.diseñoIconButton2.TextColor = System.Drawing.Color.White;
            this.diseñoIconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.diseñoIconButton2.UseVisualStyleBackColor = false;
            this.diseñoIconButton2.Click += new System.EventHandler(this.diseñoIconButton2_Click);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(61)))), ((int)(((byte)(125)))));
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.Window;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 38;
            this.iconPictureBox1.Location = new System.Drawing.Point(12, 88);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(38, 41);
            this.iconPictureBox1.TabIndex = 12;
            this.iconPictureBox1.TabStop = false;
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
            this.diseñoButton1.Location = new System.Drawing.Point(12, 9);
            this.diseñoButton1.Name = "diseñoButton1";
            this.diseñoButton1.Size = new System.Drawing.Size(114, 39);
            this.diseñoButton1.TabIndex = 13;
            this.diseñoButton1.Text = "Volver al MENÚ";
            this.diseñoButton1.TextColor = System.Drawing.Color.White;
            this.diseñoButton1.UseVisualStyleBackColor = true;
            this.diseñoButton1.Click += new System.EventHandler(this.diseñoButton1_Click);
            // 
            // Form_VerFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(61)))), ((int)(((byte)(125)))));
            this.ClientSize = new System.Drawing.Size(1074, 503);
            this.Controls.Add(this.diseñoButton1);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.diseñoIconButton2);
            this.Controls.Add(this.diseñoIconButton1);
            this.Controls.Add(this.lbl_Titulo);
            this.Controls.Add(this.txt_Buscador);
            this.Controls.Add(this.dtv_BaseDatos);
            this.Name = "Form_VerFuncionarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Funcionarios";
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtv_BaseDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtv_BaseDatos;
        private System.Windows.Forms.TextBox txt_Buscador;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Rut;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_ApellidoPaterno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_ApellidoMaterno;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Foto;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_TipoContrato;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_IdCargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_IdUnidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_IdDispositivo;
        private System.Windows.Forms.Label lbl_Titulo;
        private Resources.DiseñoIconButton diseñoIconButton1;
        private Resources.DiseñoIconButton diseñoIconButton2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Resources.DiseñoButton diseñoButton1;
    }
}