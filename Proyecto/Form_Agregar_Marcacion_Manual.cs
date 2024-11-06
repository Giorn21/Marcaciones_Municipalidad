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

            // Establecer mensajes de ayuda en los TextBox al inicializar el formulario
            txt_Hora.Text = "EJ: '0830' => 08:30";
            txt_Hora.ForeColor = Color.Gray;
            txt_ID.Text = "Es el RUT pero sin el verificador";
            txt_ID.ForeColor = Color.Gray;

            // Limitar el número de caracteres en txt_Hora
            txt_Hora.MaxLength = 5;

            // Asignar los eventos para simular el placeholder
            txt_Hora.Enter += Txt_Hora_Enter;
            txt_Hora.Leave += Txt_Hora_Leave;
            txt_ID.Enter += Txt_ID_Enter;
            txt_ID.Leave += Txt_ID_Leave;
        }

        // Evento Enter para txt_Hora: limpia el texto de ayuda cuando el usuario hace clic
        private void Txt_Hora_Enter(object sender, EventArgs e)
        {
            if (txt_Hora.Text == "EJ: '0830' => 08:30")
            {
                txt_Hora.Text = "";
                txt_Hora.ForeColor = Color.Black;
            }
        }

        // Evento Leave para txt_Hora: muestra el texto de ayuda si el campo está vacío
        private void Txt_Hora_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_Hora.Text))
            {
                txt_Hora.Text = "EJ: '0830' => 08:30";
                txt_Hora.ForeColor = Color.Gray;
            }
        }

        // Evento Enter para txt_ID: limpia el texto de ayuda cuando el usuario hace clic
        private void Txt_ID_Enter(object sender, EventArgs e)
        {
            if (txt_ID.Text == "Es el RUT pero sin el verificador")
            {
                txt_ID.Text = "";
                txt_ID.ForeColor = Color.Black;
            }
        }

        // Evento Leave para txt_ID: muestra el texto de ayuda si el campo está vacío
        private void Txt_ID_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_ID.Text))
            {
                txt_ID.Text = "Es el RUT pero sin el verificador";
                txt_ID.ForeColor = Color.Gray;
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

        private void diseñoIconButton1_Click(object sender, EventArgs e)
        {
            clsAgregar_LogsApp logs = new clsAgregar_LogsApp();
            try
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
                else if (rtxt_Comentario.Text == "")
                {
                    MessageBox.Show("DEBE INGRESAR UN COMENTARIO EXPLICATIVO");
                    return;
                }

                clsAgregar_TipoMarcasManual marcasManual = new clsAgregar_TipoMarcasManual();

                int id = Convert.ToInt32(txt_ID.Text);
                DateTime fecha = Convert.ToDateTime(DTP_Fecha.Text);
                TimeSpan hora = TimeSpan.Parse(txt_Hora.Text);
                bool tipoMarca = rbtn_Entrada.Checked ? true : false;
                string comentario = rtxt_Comentario.Text;

                string Usuario = LoginUser.Usuario;
                logs.InsertarLog("Marca Manual", "Marc Nuevo", Usuario, "Se a agregado una Marcacion Manual.");

                marcasManual.InsertarMarcacionManual(id, fecha, hora, tipoMarca, comentario);

                txt_ID.Clear();
                txt_Hora.Clear();
                rtxt_Comentario.Clear();
                rbtn_Entrada.Checked = false;
                rbtn_Salida.Checked = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                string Usuario = LoginUser.Usuario;
                logs.InsertarLog("Marca Manual", "Err_Marc", Usuario, ex.Message);
                return;
            }
        }

        private void diseñoButton1_Click(object sender, EventArgs e)
        {
            Form_VerMarcacion_Manual MarcacionesManual = new Form_VerMarcacion_Manual();
            MarcacionesManual.Show();
            this.Close();
        }

        private void txt_Hora_Leave(object sender, EventArgs e)
        {

        }
    }
}
