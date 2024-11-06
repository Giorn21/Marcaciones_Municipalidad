namespace Proyecto
{
    partial class Form_Agregar_Unidades
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
            this.txt_Descripcion = new System.Windows.Forms.TextBox();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.txt_Telefono = new System.Windows.Forms.TextBox();
            this.cbox_Direccion = new System.Windows.Forms.ComboBox();
            this.lbl_Direccion = new System.Windows.Forms.Label();
            this.lbl_Descripcion = new System.Windows.Forms.Label();
            this.lbl_Ubicacion = new System.Windows.Forms.Label();
            this.lbl_Telefono = new System.Windows.Forms.Label();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.cbox_Ubicacion = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.diseñoButton2 = new Proyecto.Resources.DiseñoButton();
            this.diseñoIconButton1 = new Proyecto.Resources.DiseñoIconButton();
            this.SuspendLayout();
            // 
            // txt_Descripcion
            // 
            this.txt_Descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Descripcion.Location = new System.Drawing.Point(51, 128);
            this.txt_Descripcion.Name = "txt_Descripcion";
            this.txt_Descripcion.Size = new System.Drawing.Size(177, 22);
            this.txt_Descripcion.TabIndex = 2;
            // 
            // txt_Email
            // 
            this.txt_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Email.Location = new System.Drawing.Point(51, 290);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(177, 22);
            this.txt_Email.TabIndex = 5;
            this.txt_Email.Validating += new System.ComponentModel.CancelEventHandler(this.txt_Email_Validating);
            // 
            // txt_Telefono
            // 
            this.txt_Telefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Telefono.Location = new System.Drawing.Point(51, 236);
            this.txt_Telefono.Name = "txt_Telefono";
            this.txt_Telefono.Size = new System.Drawing.Size(177, 22);
            this.txt_Telefono.TabIndex = 4;
            this.txt_Telefono.TextChanged += new System.EventHandler(this.txt_Telefono_TextChanged);
            this.txt_Telefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Telefono_KeyPress);
            // 
            // cbox_Direccion
            // 
            this.cbox_Direccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox_Direccion.FormattingEnabled = true;
            this.cbox_Direccion.Location = new System.Drawing.Point(51, 73);
            this.cbox_Direccion.Name = "cbox_Direccion";
            this.cbox_Direccion.Size = new System.Drawing.Size(177, 24);
            this.cbox_Direccion.TabIndex = 1;
            this.cbox_Direccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbox_Direccion_KeyPress);
            // 
            // lbl_Direccion
            // 
            this.lbl_Direccion.AutoSize = true;
            this.lbl_Direccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Direccion.ForeColor = System.Drawing.Color.White;
            this.lbl_Direccion.Location = new System.Drawing.Point(51, 52);
            this.lbl_Direccion.Name = "lbl_Direccion";
            this.lbl_Direccion.Size = new System.Drawing.Size(71, 18);
            this.lbl_Direccion.TabIndex = 5;
            this.lbl_Direccion.Text = "Direccion";
            // 
            // lbl_Descripcion
            // 
            this.lbl_Descripcion.AutoSize = true;
            this.lbl_Descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Descripcion.ForeColor = System.Drawing.Color.White;
            this.lbl_Descripcion.Location = new System.Drawing.Point(48, 107);
            this.lbl_Descripcion.Name = "lbl_Descripcion";
            this.lbl_Descripcion.Size = new System.Drawing.Size(131, 18);
            this.lbl_Descripcion.TabIndex = 6;
            this.lbl_Descripcion.Text = "Nombre de Centro";
            // 
            // lbl_Ubicacion
            // 
            this.lbl_Ubicacion.AutoSize = true;
            this.lbl_Ubicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Ubicacion.ForeColor = System.Drawing.Color.White;
            this.lbl_Ubicacion.Location = new System.Drawing.Point(48, 161);
            this.lbl_Ubicacion.Name = "lbl_Ubicacion";
            this.lbl_Ubicacion.Size = new System.Drawing.Size(74, 18);
            this.lbl_Ubicacion.TabIndex = 7;
            this.lbl_Ubicacion.Text = "Ubicacion";
            // 
            // lbl_Telefono
            // 
            this.lbl_Telefono.AutoSize = true;
            this.lbl_Telefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Telefono.ForeColor = System.Drawing.Color.White;
            this.lbl_Telefono.Location = new System.Drawing.Point(48, 215);
            this.lbl_Telefono.Name = "lbl_Telefono";
            this.lbl_Telefono.Size = new System.Drawing.Size(66, 18);
            this.lbl_Telefono.TabIndex = 8;
            this.lbl_Telefono.Text = "Telefono";
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Email.ForeColor = System.Drawing.Color.White;
            this.lbl_Email.Location = new System.Drawing.Point(48, 269);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(45, 18);
            this.lbl_Email.TabIndex = 9;
            this.lbl_Email.Text = "Email";
            // 
            // cbox_Ubicacion
            // 
            this.cbox_Ubicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox_Ubicacion.FormattingEnabled = true;
            this.cbox_Ubicacion.Location = new System.Drawing.Point(51, 182);
            this.cbox_Ubicacion.Name = "cbox_Ubicacion";
            this.cbox_Ubicacion.Size = new System.Drawing.Size(177, 24);
            this.cbox_Ubicacion.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(35, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 31);
            this.label1.TabIndex = 28;
            this.label1.Text = "Agregar Unidad";
            // 
            // diseñoButton2
            // 
            this.diseñoButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(61)))), ((int)(((byte)(125)))));
            this.diseñoButton2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(61)))), ((int)(((byte)(125)))));
            this.diseñoButton2.BorderColor = System.Drawing.Color.Red;
            this.diseñoButton2.BorderRadius = 40;
            this.diseñoButton2.BorderSize = 0;
            this.diseñoButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.diseñoButton2.FlatAppearance.BorderSize = 0;
            this.diseñoButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.diseñoButton2.ForeColor = System.Drawing.Color.White;
            this.diseñoButton2.Location = new System.Drawing.Point(12, 349);
            this.diseñoButton2.Name = "diseñoButton2";
            this.diseñoButton2.Size = new System.Drawing.Size(80, 37);
            this.diseñoButton2.TabIndex = 7;
            this.diseñoButton2.Text = "Volver";
            this.diseñoButton2.TextColor = System.Drawing.Color.White;
            this.diseñoButton2.UseVisualStyleBackColor = true;
            this.diseñoButton2.Click += new System.EventHandler(this.diseñoButton2_Click);
            // 
            // diseñoIconButton1
            // 
            this.diseñoIconButton1.BackColor = System.Drawing.Color.OliveDrab;
            this.diseñoIconButton1.BackgroundColor = System.Drawing.Color.OliveDrab;
            this.diseñoIconButton1.BorderColor = System.Drawing.Color.Green;
            this.diseñoIconButton1.BorderRadius = 25;
            this.diseñoIconButton1.BorderSize = 3;
            this.diseñoIconButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.diseñoIconButton1.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.diseñoIconButton1.FlatAppearance.BorderSize = 3;
            this.diseñoIconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.diseñoIconButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diseñoIconButton1.ForeColor = System.Drawing.Color.White;
            this.diseñoIconButton1.IconChar = FontAwesome.Sharp.IconChar.BuildingCircleCheck;
            this.diseñoIconButton1.IconColor = System.Drawing.Color.White;
            this.diseñoIconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.diseñoIconButton1.IconSize = 25;
            this.diseñoIconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.diseñoIconButton1.Location = new System.Drawing.Point(175, 349);
            this.diseñoIconButton1.Name = "diseñoIconButton1";
            this.diseñoIconButton1.Size = new System.Drawing.Size(100, 37);
            this.diseñoIconButton1.TabIndex = 6;
            this.diseñoIconButton1.Text = "Agregar";
            this.diseñoIconButton1.TextColor = System.Drawing.Color.White;
            this.diseñoIconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.diseñoIconButton1.UseVisualStyleBackColor = false;
            this.diseñoIconButton1.Click += new System.EventHandler(this.diseñoIconButton1_Click);
            // 
            // Form_Agregar_Unidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(61)))), ((int)(((byte)(125)))));
            this.ClientSize = new System.Drawing.Size(297, 407);
            this.Controls.Add(this.diseñoIconButton1);
            this.Controls.Add(this.diseñoButton2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbox_Ubicacion);
            this.Controls.Add(this.lbl_Email);
            this.Controls.Add(this.lbl_Telefono);
            this.Controls.Add(this.lbl_Ubicacion);
            this.Controls.Add(this.lbl_Descripcion);
            this.Controls.Add(this.lbl_Direccion);
            this.Controls.Add(this.cbox_Direccion);
            this.Controls.Add(this.txt_Telefono);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.txt_Descripcion);
            this.Name = "Form_Agregar_Unidades";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Agregar_Unidades";
            this.Load += new System.EventHandler(this.Form_Agregar_Unidades_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Descripcion;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.TextBox txt_Telefono;
        private System.Windows.Forms.ComboBox cbox_Direccion;
        private System.Windows.Forms.Label lbl_Direccion;
        private System.Windows.Forms.Label lbl_Descripcion;
        private System.Windows.Forms.Label lbl_Ubicacion;
        private System.Windows.Forms.Label lbl_Telefono;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.ComboBox cbox_Ubicacion;
        private System.Windows.Forms.Label label1;
        private Resources.DiseñoButton diseñoButton2;
        private Resources.DiseñoIconButton diseñoIconButton1;
    }
}