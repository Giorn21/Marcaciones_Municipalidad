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
    public partial class Form_Menú : Form
    {
        public Form_Menú()
        {
            InitializeComponent();
        }
        private void diseñoIconButton8_Click(object sender, EventArgs e)
        {
            Form_Login login = new Form_Login();
            login.Show();
            this.Close();
        }

        private void diseñoIconButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_VerFuncionarios Form2 = new Form_VerFuncionarios();
            Form2.Show();
        }

        private void diseñoIconButton2_Click(object sender, EventArgs e)
        {
            Form_Disp_Funcionario disp_Funcionario = new Form_Disp_Funcionario();
            disp_Funcionario.Show();
            this.Close();
        }

        private void diseñoIconButton3_Click(object sender, EventArgs e)
        {
            Form_VerMarcacion_Manual VerMarcacionManual = new Form_VerMarcacion_Manual();
            VerMarcacionManual.Show();
            this.Close(); 
        }

        private void diseñoIconButton4_Click(object sender, EventArgs e)
        {
            Form_Dispositivos dispositivos = new Form_Dispositivos();
            dispositivos.Show();
            this.Close();
        }

        private void diseñoIconButton5_Click(object sender, EventArgs e)
        {
            Form_VerMarcaciones marcaciones = new Form_VerMarcaciones();
            marcaciones.Show();
            this.Close();
        }

        private void diseñoIconButton6_Click(object sender, EventArgs e)
        {
            Form_buscador_Logs form_Buscador_Logs = new Form_buscador_Logs();
            form_Buscador_Logs.Show();
            this.Close();
        }

        private void diseñoIconButton7_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            contextMenuStrip1.Show(btn, new Point(-95, 35));
        }

        //----------------------------------Menu Del MOD-----------------------------------

        private void biometriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_VerBiometria biometria = new Form_VerBiometria();
            biometria.Show();
            this.Close();
        }

        private void marcasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_VerMarcas Marcas = new Form_VerMarcas();
            Marcas.Show();
            this.Close();
        }

        private void tipoContratoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_VerContrato tipoContrato = new Form_VerContrato();
            tipoContrato.Show();
            this.Close();
        }

        private void unidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_VerUnidad verUnidad = new Form_VerUnidad();
            verUnidad.Show();
            this.Close();
        }

        private void horarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_VerHorario verHorario = new Form_VerHorario();
            verHorario.Show();
            this.Close();
        }

        
    }
}
