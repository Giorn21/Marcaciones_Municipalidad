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
        clsAgregar_LogsApp logs = new clsAgregar_LogsApp();
        public Form_Login()
        {
            InitializeComponent();

            //despues borrar
            txt_Usuario.Text = "admin";
            txt_Contrasena.Text = "admin000";
        }

        private void btn_login_Click(object sender, EventArgs e)
        {

            clsLoginUser login = new clsLoginUser();

            //verifico que los campos no estén vacíos
            if (string.IsNullOrEmpty(txt_Usuario.Text) || string.IsNullOrEmpty(txt_Contrasena.Text))
            {
                MessageBox.Show("las casillas no pueden estar vacias");
                return;
            }

            string user = txt_Usuario.Text;
            string contrasena = txt_Contrasena.Text;
            LoginUser.Usuario = txt_Usuario.Text;

            if (login.Get(user, contrasena).Count == 1)
            {
                
                //logs.InsertarLog("ControlAcceso", "Login", user, "El usuario se ha conectado correctamente.");

                this.Hide();
                Form_Menu Menu = new Form_Menu();
                Menu.Show(); ;
            }
            else
            {
                logs.InsertarLog("ControlAcceso", "ErrLog", user, "Credencial invalida. Pass Usada: " + contrasena);
                MessageBox.Show("Usuario o contraseña incorrectos.");
            }

        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}