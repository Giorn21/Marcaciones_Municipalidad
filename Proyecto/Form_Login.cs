using common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class Form_Login : Form
    {
        
        public Form_Login()
        {
            InitializeComponent();

            //despues borrar
            txt_Usuario.Text = "admin";
            txt_Contrasena.Text = "admin000";
        }

        private bool validarText()
        {
            if(string.IsNullOrEmpty(txt_Contrasena.Text))
            {
                MessageBox.Show("Contraseña no puede estar vacia");
                return false;
            }
            if (string.IsNullOrEmpty(txt_Usuario.Text))
            {
                MessageBox.Show("Usuario no puede estar vacio");
                return false;
            }

            return true;

        }

        private void btn_login_Click(object sender, EventArgs e)
        {

            clsLoginUser cls = new clsLoginUser();

            if (!validarText())
            {
                return;
            }

            string user = txt_Usuario.Text;
            string contrasena = txt_Contrasena.Text;


            if (cls.Get(user, contrasena).Count == 1)
            {
                // Usuario encontrado, ocultar el formulario de login y mostrar el formulario principal
                this.Hide();
                Form_Menu Menu = new Form_Menu();
                Menu.Show(); ;
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.");
            }

            string usuarioIngresado = txt_Usuario.Text;
            string contrasenaIngresada = txt_Contrasena.Text;

        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}