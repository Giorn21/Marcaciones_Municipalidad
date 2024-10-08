using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class Form_Menu : Form
    {
        public Form_Menu()
        {
            InitializeComponent();
        }

        private void btn_Funcionarios_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_VerFuncionarios Form2 = new Form_VerFuncionarios();
            Form2.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Form_Login login = new Form_Login();
            login.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form_Disp_Funcionario disp_Funcionario = new Form_Disp_Funcionario();
            disp_Funcionario.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form_Dispositivos dispositivos = new Form_Dispositivos();
            dispositivos.Show();
            this.Close();
        }

        private void btn_Marcaciones_Click(object sender, EventArgs e)
        {
            Form_VerMarcaciones marcaciones = new Form_VerMarcaciones();
            marcaciones.Show();
            this.Close();
        }

        private void btn_App_Logs_Click(object sender, EventArgs e)
        {
            Form_buscador_Logs form_Buscador_Logs = new Form_buscador_Logs();
            form_Buscador_Logs.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_Opciones opciones = new Form_Opciones();
            opciones.Show();
            this.Close();
        }

        private void btn_AgregarMarcaciones_Click(object sender, EventArgs e)
        {
            Form_VerMarcacion_Manual VerMarcacionManual = new Form_VerMarcacion_Manual();
            VerMarcacionManual.Show();
            this.Close();
        }
    }
}
