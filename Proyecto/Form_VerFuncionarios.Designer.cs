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
            this.lbl_Buscador = new System.Windows.Forms.Label();
            this.txt_Buscador = new System.Windows.Forms.TextBox();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.btn_Volver = new System.Windows.Forms.Button();
            this.btn_desvincular = new System.Windows.Forms.Button();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtv_BaseDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // dtv_BaseDatos
            // 
            this.dtv_BaseDatos.AllowUserToAddRows = false;
            this.dtv_BaseDatos.AllowUserToDeleteRows = false;
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
            // lbl_Buscador
            // 
            this.lbl_Buscador.AutoSize = true;
            this.lbl_Buscador.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Buscador.Location = new System.Drawing.Point(14, 95);
            this.lbl_Buscador.Name = "lbl_Buscador";
            this.lbl_Buscador.Size = new System.Drawing.Size(34, 25);
            this.lbl_Buscador.TabIndex = 1;
            this.lbl_Buscador.Text = "🔎";
            // 
            // txt_Buscador
            // 
            this.txt_Buscador.Location = new System.Drawing.Point(54, 97);
            this.txt_Buscador.Name = "txt_Buscador";
            this.txt_Buscador.Size = new System.Drawing.Size(172, 20);
            this.txt_Buscador.TabIndex = 2;
            this.txt_Buscador.TextChanged += new System.EventHandler(this.txt_Buscador_TextChanged);
            this.txt_Buscador.Enter += new System.EventHandler(this.txt_Buscador_Enter);
            this.txt_Buscador.Leave += new System.EventHandler(this.txt_Buscador_Leave);
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Agregar.Location = new System.Drawing.Point(257, 90);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(98, 32);
            this.btn_Agregar.TabIndex = 5;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.UseVisualStyleBackColor = true;
            this.btn_Agregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Volver
            // 
            this.btn_Volver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Volver.Location = new System.Drawing.Point(12, 12);
            this.btn_Volver.Name = "btn_Volver";
            this.btn_Volver.Size = new System.Drawing.Size(108, 26);
            this.btn_Volver.TabIndex = 7;
            this.btn_Volver.Text = "Volver al menu";
            this.btn_Volver.UseVisualStyleBackColor = true;
            this.btn_Volver.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // btn_desvincular
            // 
            this.btn_desvincular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_desvincular.Location = new System.Drawing.Point(936, 92);
            this.btn_desvincular.Name = "btn_desvincular";
            this.btn_desvincular.Size = new System.Drawing.Size(106, 32);
            this.btn_desvincular.TabIndex = 8;
            this.btn_desvincular.Text = "Desvincular ";
            this.btn_desvincular.UseVisualStyleBackColor = true;
            this.btn_desvincular.Click += new System.EventHandler(this.btn_desvincular_Click);
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.Location = new System.Drawing.Point(445, 23);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(183, 33);
            this.lbl_Titulo.TabIndex = 9;
            this.lbl_Titulo.Text = "Funcionarios";
            // 
            // Form_VerFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 503);
            this.Controls.Add(this.lbl_Titulo);
            this.Controls.Add(this.btn_desvincular);
            this.Controls.Add(this.btn_Volver);
            this.Controls.Add(this.btn_Agregar);
            this.Controls.Add(this.txt_Buscador);
            this.Controls.Add(this.lbl_Buscador);
            this.Controls.Add(this.dtv_BaseDatos);
            this.Name = "Form_VerFuncionarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Funcionarios";
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtv_BaseDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtv_BaseDatos;
        private System.Windows.Forms.Label lbl_Buscador;
        private System.Windows.Forms.TextBox txt_Buscador;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.Button btn_Volver;
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
        private System.Windows.Forms.Button btn_desvincular;
        private System.Windows.Forms.Label lbl_Titulo;
    }
}