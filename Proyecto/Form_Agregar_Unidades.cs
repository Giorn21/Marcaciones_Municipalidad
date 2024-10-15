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
    public partial class Form_Agregar_Unidades : Form
    {
        public Form_Agregar_Unidades()
        {
            InitializeComponent();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Form_VerUnidad verUnidad = new Form_VerUnidad();
            verUnidad.Show();
            this.Close();
        }

        private void Form_Agregar_Unidades_Load(object sender, EventArgs e)
        {
            clsDatos_cboxAgrUnidad Datos_Direccion = new clsDatos_cboxAgrUnidad();
            Datos_Direccion.CargarUnidadDireccion(cbox_Direccion);
            if (cbox_Direccion.Items.Count > 0)
            {
                cbox_Direccion.SelectedIndex = 0;
            }

            clsDatos_cboxAgrUnidad Datos_Ubicacion = new clsDatos_cboxAgrUnidad();
            Datos_Ubicacion.CargarUnidadUbicacino(cbox_Ubicacion);
            if (cbox_Ubicacion.Items.Count > 0)
            {
                cbox_Ubicacion.SelectedIndex = 0;
            }

            cbox_Direccion.Text = "Selecione";
            cbox_Ubicacion.Text = "";
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            if (cbox_Direccion.Text == "" || cbox_Direccion.Text == "Selecione" || txt_Descripcion.Text == "")
            {
                MessageBox.Show("!ALERTA¡ : Rellene las casillas Direccion y Descripcion");
                return;
            }
            else 
            {
                clsAgregar_Unidad agregarUnidad = new clsAgregar_Unidad();

                string Direccion = cbox_Direccion.SelectedValue.ToString();
                string descripcion = txt_Descripcion.Text;
                string ubicacion = cbox_Ubicacion.Text;
                if (cbox_Ubicacion.Text == "")
                {
                    ubicacion = null;
                }

                string telefono = txt_Telefono.Text;
                if (txt_Telefono.Text == "")
                {
                    telefono = null;
                }

                string email = txt_Email.Text;
                if (txt_Email.Text=="") 
                {
                    email = null;
                }

                agregarUnidad.AgregarUnidad(Direccion, descripcion, ubicacion, telefono, email);
            }
            
        }

        private void cbox_Direccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txt_Telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_Telefono_TextChanged(object sender, EventArgs e)
        {
            // Desuscribir el evento temporalmente para evitar bucles infinitos
            txt_Telefono.TextChanged -= txt_Telefono_TextChanged;

            string textoSinFormato = txt_Telefono.Text.Replace(",", "").Replace(" ", ""); 
            if (textoSinFormato.Length > 3)
            {
                string textoFormateado = "";
                for (int i = 0; i < textoSinFormato.Length; i++)
                {
                    textoFormateado += textoSinFormato[i];

                    // Cada 3 dígitos, agregar una coma y un espacio
                    if ((i + 1) % 3 == 0 && (i + 1) < textoSinFormato.Length)
                    {
                        textoFormateado += ", ";
                    }
                }

                txt_Telefono.Text = textoFormateado;
                txt_Telefono.SelectionStart = txt_Telefono.Text.Length;  
            }

            // Volver a suscribir el evento
            txt_Telefono.TextChanged += txt_Telefono_TextChanged;
        }

        private void txt_Email_Validating(object sender, CancelEventArgs e)
        {
            string email = txt_Email.Text.Trim();

            // Si el TextBox está vacío, no realizar ninguna validación
            if (string.IsNullOrEmpty(email))
            {
                return;
            }
            if (!email.Contains("@") ||
                !email.EndsWith("gmail.", StringComparison.OrdinalIgnoreCase) ||
                  email.EndsWith("hotmail.", StringComparison.OrdinalIgnoreCase) ||
                  email.EndsWith("email.", StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("Debe ingresar un correo válido con '@' y los dominios permitidos ( gmail., hotmail., email. )", "Email no válido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_Email.Clear();
                e.Cancel = true;
            }
        }
    }
}
