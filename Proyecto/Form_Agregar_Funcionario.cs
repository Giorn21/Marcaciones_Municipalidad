using common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static common.clsAgregar_Funcionarios;

namespace Proyecto
{
    public partial class Form_Agregar_Funcionario : Form
    {
        public Form_Agregar_Funcionario()
        {
            InitializeComponent();
        }

        private void btn_Volver_Click(object sender, EventArgs e)
        {
            Form_Funcionarios funcionarios = new Form_Funcionarios();
            funcionarios.Show();
            this.Close();
        }

        private void Form_Agregar_Funcionario_Load(object sender, EventArgs e)
        {

        }

        private void txt_Rut_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Registro_Click(object sender, EventArgs e)
        {
            {
                // Crear una instancia de la clase clsInsertarFuncionario
                clsInsertarFuncionario insertar = new clsInsertarFuncionario();

                // Obtener los datos de los controles
                string rutCompleto = txt_Rut.Text;
                string nombres = txt_Nombre.Text;
                string apellidoPaterno = txt_Apellido_Paterno.Text;
                string apellidoMaterno = txt_Apellido_Materno.Text;
                //byte[] foto = pbFoto.Image != null ? ImageToByteArray(pbFoto.Image) : null; // Convertir imagen a byte[]
                string email = txt_Email.Text;
                int tipoContrato = (int)cbox_Tipo_Contrato.SelectedValue;
                int idCargo = (int)cbox_Tipo_Cargo.SelectedValue;
                int idDispositivo = (int)cbox_IdDispositivo.SelectedValue;

                // Llamar a la función de insertar funcionario
                //insertar.InsertarFuncionario(rutCompleto, nombres, apellidoPaterno, apellidoMaterno, foto, email, tipoContrato, idCargo, idDispositivo);
            }
            /*
            // Método para convertir imagen a byte[]
            private byte[] ImageToByteArray(Image imageIn)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    return ms.ToArray();
                }
            }
            */
        }

        private void txt_Id_Dispositivo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
