using common;
using common.BL;
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
    public partial class Form_UPD_Contrato : Form
    {
        cls_UPD_TipoContrato actualizarContrato = new cls_UPD_TipoContrato();
        public Form_UPD_Contrato()
        {
            InitializeComponent();
        }

        public void CargarDatos(int TipoContrato, string descripcion)
        {
            txt_TipoContrato.Text = TipoContrato.ToString();
            txt_Descripcion.Text = descripcion;
        }

        private void diseñoButton1_Click(object sender, EventArgs e)
        {
            Form_VerContrato contrato = new Form_VerContrato();
            contrato.Show();
            this.Close();
        }

        private void diseñoIconButton1_Click(object sender, EventArgs e)
        {
            clsAgregar_LogsApp logs = new clsAgregar_LogsApp();

            if (txt_Descripcion.Text == "")
            {
                MessageBox.Show("Ingrese un Contrato para Actualizar los datos");
                return;
            }
            int TipoContrato = Convert.ToInt32(txt_TipoContrato.Text);
            string nuevaDescripcion = txt_Descripcion.Text;

            bool exito = actualizarContrato.ActualizarTipoContrato(TipoContrato, nuevaDescripcion);

            if (exito)
            {
                MessageBox.Show("Contrato actualizado correctamente.");
                string Usuario = LoginUser.Usuario;
                logs.InsertarLog("Contrato", "Con Update", Usuario, "Se a Actualizado un Contrato");
                Form_VerContrato verContrato = new Form_VerContrato();
                verContrato.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Error al actualizar el contrato.");
                return;
            }
        }
    }
}
