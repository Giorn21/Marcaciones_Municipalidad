using common;
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
    public partial class Form_Agregar_Contrato : Form
    {
        public Form_Agregar_Contrato()
        {
            InitializeComponent();
        }

        private void txt_TipoContrato_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Si no es un número, se cancela el evento
                e.Handled = true;
            }
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Form_VerContrato verContrato = new Form_VerContrato();
            verContrato.Show();
            this.Close();
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            clsAgregar_LogsApp logs = new clsAgregar_LogsApp();
            try
            {
                if (txt_TipoContrato.Text == "" || txt_Descripcion.Text == "")
                {
                    MessageBox.Show("POR FAVOR LLENE LAS CASILLAS DE TIPO DE CONTRATO Y DESCRIPCIÓN.");
                    return;
                }
                clsAgregar_Contrato AgrContrato = new clsAgregar_Contrato();

                int IdContrato = Convert.ToInt32(txt_TipoContrato.Text);
                string descripcion = txt_Descripcion.Text;

                AgrContrato.InsertarContrato(IdContrato, descripcion);

                txt_TipoContrato.Clear();
                txt_Descripcion.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return;
            }
        }
    }
}
