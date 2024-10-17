namespace Proyecto
{
    partial class Form_VerHorario
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
            this.dtv_Horarios = new System.Windows.Forms.DataGridView();
            this.cbox_Horarios = new System.Windows.Forms.ComboBox();
            this.lbl_horarios = new System.Windows.Forms.Label();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.btn_Actualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtv_Horarios)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.Location = new System.Drawing.Point(213, 9);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(222, 33);
            this.lbl_Titulo.TabIndex = 0;
            this.lbl_Titulo.Text = "Horarios (MOD)";
            // 
            // dtv_Horarios
            // 
            this.dtv_Horarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtv_Horarios.Location = new System.Drawing.Point(12, 122);
            this.dtv_Horarios.Name = "dtv_Horarios";
            this.dtv_Horarios.Size = new System.Drawing.Size(658, 238);
            this.dtv_Horarios.TabIndex = 1;
            this.dtv_Horarios.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtv_Horarios_CellDoubleClick);
            this.dtv_Horarios.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtv_Horarios_CellValueChanged);
            this.dtv_Horarios.RowValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtv_Horarios_RowValidated);
            // 
            // cbox_Horarios
            // 
            this.cbox_Horarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox_Horarios.FormattingEnabled = true;
            this.cbox_Horarios.Location = new System.Drawing.Point(12, 90);
            this.cbox_Horarios.Name = "cbox_Horarios";
            this.cbox_Horarios.Size = new System.Drawing.Size(285, 26);
            this.cbox_Horarios.TabIndex = 2;
            this.cbox_Horarios.SelectedIndexChanged += new System.EventHandler(this.cbox_Horarios_SelectedIndexChanged);
            // 
            // lbl_horarios
            // 
            this.lbl_horarios.AutoSize = true;
            this.lbl_horarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_horarios.Location = new System.Drawing.Point(9, 69);
            this.lbl_horarios.Name = "lbl_horarios";
            this.lbl_horarios.Size = new System.Drawing.Size(248, 18);
            this.lbl_horarios.TabIndex = 3;
            this.lbl_horarios.Text = "seleccione un horario para modificar";
            // 
            // btn_Salir
            // 
            this.btn_Salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Salir.Location = new System.Drawing.Point(12, 366);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(75, 27);
            this.btn_Salir.TabIndex = 4;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // btn_Actualizar
            // 
            this.btn_Actualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Actualizar.Location = new System.Drawing.Point(576, 90);
            this.btn_Actualizar.Name = "btn_Actualizar";
            this.btn_Actualizar.Size = new System.Drawing.Size(81, 26);
            this.btn_Actualizar.TabIndex = 5;
            this.btn_Actualizar.Text = "Actualizar";
            this.btn_Actualizar.UseVisualStyleBackColor = true;
            this.btn_Actualizar.Click += new System.EventHandler(this.btn_Actualizar_Click);
            // 
            // Form_VerHorario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 408);
            this.Controls.Add(this.btn_Actualizar);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.lbl_horarios);
            this.Controls.Add(this.cbox_Horarios);
            this.Controls.Add(this.dtv_Horarios);
            this.Controls.Add(this.lbl_Titulo);
            this.Name = "Form_VerHorario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_VerHorario";
            this.Load += new System.EventHandler(this.Form_VerHorario_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dtv_Horarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.DataGridView dtv_Horarios;
        private System.Windows.Forms.ComboBox cbox_Horarios;
        private System.Windows.Forms.Label lbl_horarios;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Button btn_Actualizar;
    }
}