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
            this.diseñoIconButton1 = new Proyecto.Resources.DiseñoIconButton();
            this.diseñoButton1 = new Proyecto.Resources.DiseñoButton();
            this.diseñoIconButton2 = new Proyecto.Resources.DiseñoIconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtv_Horarios)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.ForeColor = System.Drawing.Color.White;
            this.lbl_Titulo.Location = new System.Drawing.Point(233, 9);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(222, 33);
            this.lbl_Titulo.TabIndex = 0;
            this.lbl_Titulo.Text = "Horarios (MOD)";
            // 
            // dtv_Horarios
            // 
            this.dtv_Horarios.AllowUserToAddRows = false;
            this.dtv_Horarios.AllowUserToDeleteRows = false;
            this.dtv_Horarios.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(61)))), ((int)(((byte)(125)))));
            this.dtv_Horarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtv_Horarios.GridColor = System.Drawing.Color.Black;
            this.dtv_Horarios.Location = new System.Drawing.Point(12, 122);
            this.dtv_Horarios.Name = "dtv_Horarios";
            this.dtv_Horarios.Size = new System.Drawing.Size(658, 226);
            this.dtv_Horarios.TabIndex = 1;
            this.dtv_Horarios.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dtv_Horarios_CellBeginEdit);
            this.dtv_Horarios.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtv_Horarios_CellEndEdit);
            this.dtv_Horarios.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dtv_Horarios_EditingControlShowing);
            this.dtv_Horarios.RowValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtv_Horarios_RowValidated);
            this.dtv_Horarios.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtv_Horarios_KeyPress);
            // 
            // cbox_Horarios
            // 
            this.cbox_Horarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox_Horarios.FormattingEnabled = true;
            this.cbox_Horarios.Location = new System.Drawing.Point(12, 90);
            this.cbox_Horarios.Name = "cbox_Horarios";
            this.cbox_Horarios.Size = new System.Drawing.Size(485, 26);
            this.cbox_Horarios.TabIndex = 2;
            this.cbox_Horarios.SelectedIndexChanged += new System.EventHandler(this.cbox_Horarios_SelectedIndexChanged);
            this.cbox_Horarios.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbox_Horarios_KeyPress);
            // 
            // lbl_horarios
            // 
            this.lbl_horarios.AutoSize = true;
            this.lbl_horarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_horarios.ForeColor = System.Drawing.Color.White;
            this.lbl_horarios.Location = new System.Drawing.Point(9, 69);
            this.lbl_horarios.Name = "lbl_horarios";
            this.lbl_horarios.Size = new System.Drawing.Size(248, 18);
            this.lbl_horarios.TabIndex = 3;
            this.lbl_horarios.Text = "seleccione un horario para modificar";
            // 
            // diseñoIconButton1
            // 
            this.diseñoIconButton1.BackColor = System.Drawing.Color.Olive;
            this.diseñoIconButton1.BackgroundColor = System.Drawing.Color.Olive;
            this.diseñoIconButton1.BorderColor = System.Drawing.Color.Yellow;
            this.diseñoIconButton1.BorderRadius = 45;
            this.diseñoIconButton1.BorderSize = 3;
            this.diseñoIconButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.diseñoIconButton1.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.diseñoIconButton1.FlatAppearance.BorderSize = 3;
            this.diseñoIconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.diseñoIconButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diseñoIconButton1.ForeColor = System.Drawing.Color.White;
            this.diseñoIconButton1.IconChar = FontAwesome.Sharp.IconChar.Redo;
            this.diseñoIconButton1.IconColor = System.Drawing.Color.White;
            this.diseñoIconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.diseñoIconButton1.IconSize = 20;
            this.diseñoIconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.diseñoIconButton1.Location = new System.Drawing.Point(569, 69);
            this.diseñoIconButton1.Name = "diseñoIconButton1";
            this.diseñoIconButton1.Size = new System.Drawing.Size(101, 44);
            this.diseñoIconButton1.TabIndex = 19;
            this.diseñoIconButton1.Text = "Actualizar";
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
            this.diseñoButton1.Location = new System.Drawing.Point(12, 365);
            this.diseñoButton1.Name = "diseñoButton1";
            this.diseñoButton1.Size = new System.Drawing.Size(114, 39);
            this.diseñoButton1.TabIndex = 20;
            this.diseñoButton1.Text = "Volver al MENÚ";
            this.diseñoButton1.TextColor = System.Drawing.Color.White;
            this.diseñoButton1.UseVisualStyleBackColor = false;
            this.diseñoButton1.Click += new System.EventHandler(this.diseñoButton1_Click);
            // 
            // diseñoIconButton2
            // 
            this.diseñoIconButton2.BackColor = System.Drawing.Color.OliveDrab;
            this.diseñoIconButton2.BackgroundColor = System.Drawing.Color.OliveDrab;
            this.diseñoIconButton2.BorderColor = System.Drawing.Color.Green;
            this.diseñoIconButton2.BorderRadius = 25;
            this.diseñoIconButton2.BorderSize = 3;
            this.diseñoIconButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.diseñoIconButton2.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.diseñoIconButton2.FlatAppearance.BorderSize = 3;
            this.diseñoIconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.diseñoIconButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diseñoIconButton2.ForeColor = System.Drawing.Color.White;
            this.diseñoIconButton2.IconChar = FontAwesome.Sharp.IconChar.ClockFour;
            this.diseñoIconButton2.IconColor = System.Drawing.Color.White;
            this.diseñoIconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.diseñoIconButton2.IconSize = 35;
            this.diseñoIconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.diseñoIconButton2.Location = new System.Drawing.Point(516, 363);
            this.diseñoIconButton2.Name = "diseñoIconButton2";
            this.diseñoIconButton2.Size = new System.Drawing.Size(154, 44);
            this.diseñoIconButton2.TabIndex = 21;
            this.diseñoIconButton2.Text = "Nuevo Horario";
            this.diseñoIconButton2.TextColor = System.Drawing.Color.White;
            this.diseñoIconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.diseñoIconButton2.UseVisualStyleBackColor = false;
            this.diseñoIconButton2.Click += new System.EventHandler(this.diseñoIconButton2_Click);
            // 
            // Form_VerHorario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(61)))), ((int)(((byte)(125)))));
            this.ClientSize = new System.Drawing.Size(682, 417);
            this.Controls.Add(this.diseñoIconButton2);
            this.Controls.Add(this.diseñoButton1);
            this.Controls.Add(this.diseñoIconButton1);
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
        private Resources.DiseñoIconButton diseñoIconButton1;
        private Resources.DiseñoButton diseñoButton1;
        private Resources.DiseñoIconButton diseñoIconButton2;
    }
}