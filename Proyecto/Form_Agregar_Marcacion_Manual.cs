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
using static common.clsAgregar_Funcionarios;

namespace Proyecto
{
    public partial class Form_Agregar_Marcacion_Manual : Form
    {
        public Form_Agregar_Marcacion_Manual()
        {
            InitializeComponent();
        }
        public AgregarDatos DatosMarcasManuales { get; private set; }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Form_VerMarcacion_Manual MarcacionesManual = new Form_VerMarcacion_Manual();
            MarcacionesManual.Show();
            this.Close();
        }


        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            if (txt_ID.Text == "" || txt_Hora.Text == "")
            {
                MessageBox.Show("POR FAVOR LLENE LAS CASILLAS DE ID Y HORA.");
                return;
            }
            else if (rbtn_Entrada.Checked == false && rbtn_Salida.Checked == false)
            {
                MessageBox.Show("MARQUE UNA OPCION");
                return;
            }

            clsAgregar_TipoMarcasManual marcasManual = new clsAgregar_TipoMarcasManual();

            int id = Convert.ToInt32(txt_ID.Text);
            DateTime fecha = Convert.ToDateTime(DTP_Fecha.Text);
            TimeSpan hora = TimeSpan.Parse(txt_Hora.Text);
            bool tipoMarca = rbtn_Entrada.Checked ? true : false;
            string comentario = rtxt_Comentario.Text;

            marcasManual.InsertarMarcacionManual(id, fecha, hora, tipoMarca, comentario);

            txt_ID.Clear();
            txt_Hora.Clear();
            rtxt_Comentario.Clear();
            rbtn_Entrada.Checked = false;
            rbtn_Salida.Checked = false;
            
        }

        private void rbtn_Entrada_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txt_ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_Hora_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_Hora_TextChanged(object sender, EventArgs e)
        {
            if (txt_Hora.Text.Length == 4 && !txt_Hora.Text.Contains(":"))
            {
                txt_Hora.Text = txt_Hora.Text.Insert(2, ":");
                txt_Hora.SelectionStart = txt_Hora.Text.Length;
            }
            else if (txt_Hora.Text.Length < 5 && txt_Hora.Text.Contains(":"))
            {
                txt_Hora.Text = txt_Hora.Text.Replace(":", "");
                txt_Hora.SelectionStart = txt_Hora.Text.Length;
            }
        }
    }
}
