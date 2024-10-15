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
    public partial class Form_UPD_Unidad : Form
    {
        private int IdUnidad;
        public Form_UPD_Unidad()
        {
            InitializeComponent();
        }

        public void CargarDatos(int IdUnidad, string direccion, string descripcion, string ubicacion, string telefono, string email)
        {
            // Asignar los valores a los controles del formulario
            cbox_Direccion.SelectedValue = direccion;
            txt_Descripcion.Text = descripcion;
            cbox_Ubicacion.SelectedValue = ubicacion;
            txt_Telefono.Text = telefono;
            txt_Email.Text = email;

            // Puedes guardar el id si es necesario para actualizar la base de datos
            this.IdUnidad = IdUnidad;
        }

        private void btn_Actualizar_Click(object sender, EventArgs e)
        {
            // Crear una instancia de la clase cls_UPD_Unidad
            cls_UPD_Unidad actualizarUnidad = new cls_UPD_Unidad();

            // Llamar al método para actualizar los datos
            bool exito = actualizarUnidad.ActualizarUnidad(
                this.IdUnidad, // El ID de la unidad
                int.Parse(cbox_Direccion.SelectedValue.ToString()), // Dirección desde ComboBox
                txt_Descripcion.Text, // Descripción
                cbox_Ubicacion.SelectedValue.ToString(), // Ubicación desde ComboBox
                txt_Telefono.Text, // Teléfono
                txt_Email.Text // Email
            );

            // Verificar si la actualización fue exitosa
            if (exito)
            {
                MessageBox.Show("Unidad actualizada correctamente.");
            }
            else
            {
                MessageBox.Show("Error al actualizar la unidad.");
            }
        }

        private void Form_UPD_Unidad_Load(object sender, EventArgs e)
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
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Form_VerUnidad verUnidad = new Form_VerUnidad();
            verUnidad.Show();
            this.Close();
        }
    }
}
