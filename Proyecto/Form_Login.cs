﻿using common;
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

#if DEBUG
            //despues borrar
            txt_Usuario.Text = "admin";
            txt_Contrasena.Text = "admin000";
#endif
        }

        private void diseñoIconButton1_Click(object sender, EventArgs e)
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
                Form_Menú Menu = new Form_Menú();
                Menu.Show(); ;
            }
            else
            {
                logs.InsertarLog("ControlAcceso", "ErrLog", user, "Credencial invalida. Pass Usada: " + contrasena);
                MessageBox.Show("Usuario o contraseña incorrectos.");
            }
        }
    }
}