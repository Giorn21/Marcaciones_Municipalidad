using common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static common.clsAgregar_Funcionarios;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

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

            string rutCompleto = txt_Rut.Text.Trim(); // Obtenemos el texto del TextBox
            if (!txt_Email.Text.Contains("@"))
            {
                MessageBox.Show("Correo electrónico no válido. Debe incluir '@'.");
            }
            if (rutCompleto.Contains("-"))
            {
                string[] partesRut = rutCompleto.Split('-');
                string idEmpleado = partesRut[0]; // Parte numérica antes del guion
                string dv = partesRut[1]; // Dígito verificador (puede ser k)
                                          // Asegúrate de almacenar idEmpleado y rutCompleto en la base de datos
            }
            else
            {
                MessageBox.Show("Formato de RUT incorrecto. Debe incluir guion.");
            }

            // Crear una instancia de clsInsertarFuncionario
            clsInsertarFuncionario nuevoUsuario = new clsInsertarFuncionario();

            try
            {
                // Procesar y validar RUT
                nuevoUsuario.ProcesarRut(txt_Rut.Text);

                // Validar correo electrónico
                nuevoUsuario.ValidarCorreo(txt_Email.Text);

                // Asignar los valores adicionales de los TextBox
                nuevoUsuario.DatosFuncionario.Nombre = txt_Nombre.Text;
                nuevoUsuario.DatosFuncionario.ApellidoPaterno = txt_Apellido_Paterno.Text;
                nuevoUsuario.DatosFuncionario.ApellidoMaterno = txt_Apellido_Materno.Text;

                // Obtener y asignar los valores seleccionados en las ComboBox
                nuevoUsuario.SeleccionarTipoContrato((int)cbox_Tipo_Contrato.SelectedValue);
                nuevoUsuario.SeleccionarTipoCargo((int)cbox_Tipo_Cargo.SelectedValue);
                nuevoUsuario.SeleccionarUnidad((int)cbox_IdUnidad.SelectedValue);
                nuevoUsuario.SeleccionarDispositivo((int)cbox_IdDispositivo.SelectedValue);

                // Registrar el usuario en la base de datos
                if (nuevoUsuario.RegistrarUsuario())
                {
                    MessageBox.Show("Usuario registrado exitosamente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void txt_Id_Dispositivo_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_Hora_Salida_M_Click(object sender, EventArgs e)
        {

        }

        private void txt_Email_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void cbox_Tipo_Contrato_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Cargar datos en el ComboBox de Tipo de Contrato
            var tiposContratos = new Dictionary<int, string>
            {
                { 1, "Código del Trabajo" },
                { 5, "Plazo Fijo" },
                { 6, "Reemplazo" },
                { 7, "Indefinidos" },
                { 10, "Honorarios" }
            };

            cbox_Tipo_Contrato.DataSource = new BindingSource(tiposContratos, null);
            cbox_Tipo_Contrato.DisplayMember = "Value";
            cbox_Tipo_Contrato.ValueMember = "Key";

            // Obtener el ID del Tipo de Contrato seleccionado
            int tipoContratoSeleccionado = ((KeyValuePair<int, string>)cbox_Tipo_Contrato.SelectedItem).Key;
        }

        private void cbox_Tipo_Cargo_SelectedIndexChanged(object sender, EventArgs e)
        {
            var unidades = new Dictionary<int, string>
            {
                { 0, "No configurado" },
                { 1, "Administrativo" },
                { 15, "Ingeniero en informática" },
                { 16, "Desarrollo" }
                // Agrega el resto de las unidades...
            };

            cbox_Tipo_Cargo.DataSource = new BindingSource(unidades, null);
            cbox_Tipo_Cargo.DisplayMember = "Value";
            cbox_Tipo_Cargo.ValueMember = "Key";

            // Obtener el ID de la Unidad seleccionada
            int idUnidadSeleccionada = ((KeyValuePair<int, string>)cbox_Tipo_Cargo.SelectedItem).Key;
        }

        private void cbox_IdUnidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            var unidades = new Dictionary<int, string>
            {
                { 1, "Administración" },
                { 2, "Remuneraciones" },
                { 3, "Adquisiciones" },
                { 4, "Movilización" },
                { 5, "Mantención" },
                { 6, "Tesorería" },
                { 7, "INFORMATICA" },
                { 8, "D.A.S.M."},
                { 9, "CECOSF MILLALEMU" },
                { 10, "CENTRO DE ESTERILIZACION" },
                { 11, "CENTRO PODOLOGICO SUR" },
                { 12, "CESFAM LA GRANJA" },
                { 13, "CESFAM MALAQUIAS CONCHA" },
                { 14, "CESFAM PADRE ESTEBAN GUMUSCIO" },
                { 15, "CONST PADRE ESTEBAN GUMUCIO" },
                { 16, "COSAM "},
                { 17, "DIRECCION DE SALUD"},
                { 18, "DROGUERIA"} ,
                { 19, "HIPOTERAPIA"},
                { 20, "PODOLOGICO GRANJA"},
                { 21, "SAPU DENTAL"},
                { 22, "UAPO"},
                { 23, "CENTRO SALUD MENTAL"},
                { 24, "CONST.PADRE ESTEBAN GUMUCIO"},
                { 25, "CECOSF SAN GREGORIO"},
                { 26, "PROMOCION DE SALUD"},
                { 27, "AMBULANCIAS Y CONSULTORIOS"},
                { 28, "CECOSF YUNGAY"},
                { 29, "CCR VIDA BUENA"},
                { 30, "DROGUERÍA"},
                { 31, "CCR SAN GREGORIO"},
                { 32, "CECOSF VILLA LA SERENA"},
                { 33, "CESFAM GRANJA SUR"},
                { 34, "CCR LA GRANJA"},
                { 35, "FARMACIA COMUNAL"},
                { 36, "CESFAM PADRE ESTEBAN GUMUCIO"}
                
            };

            cbox_IdUnidad.DataSource = new BindingSource(unidades, null);
            cbox_IdUnidad.DisplayMember = "Value";
            cbox_IdUnidad.ValueMember = "Key";

            // Obtener el ID de la Unidad seleccionada
            int idUnidadSeleccionada = ((KeyValuePair<int, string>)cbox_IdUnidad.SelectedItem).Key;
        }

        private void cbox_IdDispositivo_SelectedIndexChanged(object sender, EventArgs e)
        {
            var dispositivos = new Dictionary<int, string>
            {
                { 1, "uFace800" }
                // Agrega los demás dispositivos si es necesario...
            };

            cbox_IdDispositivo.DataSource = new BindingSource(dispositivos, null);
            cbox_IdDispositivo.DisplayMember = "Value";
            cbox_IdDispositivo.ValueMember = "Key";

            // Obtener el ID del dispositivo seleccionado
            int idDispositivoSeleccionado = ((KeyValuePair<int, string>)cbox_IdDispositivo.SelectedItem).Key;
        }
    }
    
}

