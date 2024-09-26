using common;
using Microsoft.CSharp.RuntimeBinder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Proyecto
{
    public partial class Form_Agregar_Funcionario : Form
    {
        public Form_Agregar_Funcionario()
        {
            InitializeComponent();
            // Suscribir al evento KeyPress del TextBox
            txt_Rut.KeyPress += new KeyPressEventHandler(txt_Rut_KeyPress);
        }

        private void btn_Volver_Click(object sender, EventArgs e)
        {
            Form_Funcionarios funcionarios = new Form_Funcionarios();
            funcionarios.Show();
            this.Close();
        }

        private void Form_Agregar_Funcionario_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            dataGridView1.AutoGenerateColumns = false;

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Día", DataPropertyName = "Dia" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Hora entrada en la mañana", DataPropertyName = "EntradaMañana" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Hora salida en la mañana", DataPropertyName = "SalidaMañana" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Hora entrada en la tarde", DataPropertyName = "EntradaTarde" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Hora salida en la tarde", DataPropertyName = "SalidaTarde" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Tolerancia entrada", DataPropertyName = "ToleranciaEntrada" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Tolerancia salida", DataPropertyName = "ToleranciaSalida" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Total de horas trabajadas", DataPropertyName = "TotalHoras" });

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

            // Cargar datos Tipo Cargo
            var TipoCargo = new Dictionary<int, string>
            {
                { 0, "No configurado" },
                { 1, "Administrativo" },
                { 15, "Ingeniero en informática" },
                { 16, "Desarrollo" }

            };

            cbox_Tipo_Cargo.DataSource = new BindingSource(TipoCargo, null);
            cbox_Tipo_Cargo.DisplayMember = "Value";
            cbox_Tipo_Cargo.ValueMember = "Key";

            // Cargar datos de Cargo
            var Cargo = new Dictionary<int, string>
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

            cbox_IdUnidad.DataSource = new BindingSource(Cargo, null);
            cbox_IdUnidad.DisplayMember = "Value";
            cbox_IdUnidad.ValueMember = "Key";

            // Cargar Datos de Dispositivo
            var dispositivos = new Dictionary<int, string>
            {
                { 1, "uFace800" }
                // Agrega los demás dispositivos si es necesario...
            };

            cbox_IdDispositivo.DataSource = new BindingSource(dispositivos, null);
            cbox_IdDispositivo.DisplayMember = "Value";
            cbox_IdDispositivo.ValueMember = "Key";


            var Horarios = new Dictionary<int, string>
            {
                { 1, "HORARIO NORMAL 1 44 HRS " },
                { 2, "HORARIO NORMAL 2 44 HRS " },
                { 3, "HORARIO NORMAL 3 44 HRS " },
                { 4, "HORARIO 4  - 44HRS " },
                { 5, "HORARIO 5 - 44 HRS " },
                { 6, "HORARIO 6- 22HRS " },
                { 7, "HORARIO 7 - 44HRS " },
                { 8, "HORARIO 8 - 44HRS "},
                { 9, "HORARIO 9  - 44HRS " },
                { 10, "HORARIO 10  - 44HRS " },
                { 11, "HORARIO 11 - 44HRS " },
                { 12, "HORARIO 12 - 44HRS " },
                { 13, "HORARIO 13 - 44HRS " },
                { 14, "HORARIO 14 - 33HRS " },
                { 15, "HORARIO 15 - 44HRS " },
                { 16, "HORARIO 16 - 44HRS "},
                { 17, "HORARIO 17 - 44HRS "},
                { 18, "HORARIO 18 - 44HRS "} ,
                { 19, "HORARIO 19 - 44HRS "},
                { 20, "HORARIO 20 - 44HRS "},
                { 21, "HORARIO 21 - 44HRS "},
                { 22, "HORARIO 22 - 44HRS "},
                { 23, "HORARIO 23 - 44HRS "},
                { 24, "HORARIO 24 - 33HRS "},
                { 25, "HORARIO 25 - 44HRS "},
                { 26, "HORARIO 26 - 22HRS "},
                { 27, "HORARIO 27 - 33HRS "},
                { 28, "HORARIO 28 - 33HRS "},
                { 29, "HORARIO 29 - 44HRS "},
                { 30, "HORARIO 30 - 44HRS "},
                { 31, "HORARIO 31 - 22HRS "},
                { 32, "HORARIO 32 - 22HRS "},
                { 33, "HORARIO 33 - 30HRS "},
                { 34, "HORARIO 34 - 44HRS "},
                { 35, "HORARIO 35 - 44HRS "},
                { 36, "HORARIO 36 - 44HRS "},
                { 37, "HORARIO 37 - 33HRS "},
                { 38, "HORARIO 38 - 44HRS "},
                { 39, "HORARIO 39 - 40HRS "},
                { 40, "HORARIO 40 - 22HRS "},
                { 41, "HORARIO 41 - 22HRS "},
                { 42, "HORARIO 42 - 44HRS "},
                { 43, "HORARIO 43 - 44HRS "},
                { 44, "HORARIO 44 - 44HRS "},
                { 45, "HORARIO 45 - 44HRS "},
                { 46, "HORARIO 46 - 11HRS "},
                { 47, "HORARIO 47 - 18HRS "},
            };

            comboBox3.DataSource = new BindingSource(Horarios, null);
            comboBox3.DisplayMember = "Value";
            comboBox3.ValueMember = "Key";

            //Limpia las Combobox al inicar el formulario
            cbox_Tipo_Contrato.Text = "";
            cbox_Tipo_Cargo.Text = "";
            cbox_IdUnidad.Text = "";
            cbox_IdDispositivo.Text = "";
            comboBox3.Text = "";
        }

        private void txt_Rut_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_Registro_Click(object sender, EventArgs e)
        {
            if (txt_Rut.Text == "" || txt_Nombre.Text == "" || txt_Apellido_Paterno.Text == "" || txt_Apellido_Materno.Text == "" || txt_Email.Text == "" || cbox_Tipo_Contrato.Text == "" || cbox_Tipo_Cargo.Text == "" || cbox_IdUnidad.Text == "" || cbox_IdDispositivo.Text == "" || comboBox3.Text == "") 
            {
                MessageBox.Show("llene todas las casillas");

                return;
            }
            string rutCompleto = txt_Rut.Text.Trim(); // Obtenemos el texto del TextBox
            if (!txt_Email.Text.Contains("@"))
            {
                MessageBox.Show("Correo electrónico no válido. Debe incluir '@'.");

                return;
            }
            if (comboBox3.Text.Contains(""))
            {
                MessageBox.Show("Elija el tipo de Horario del Usuario");
                return;
            }
            if (rutCompleto.Contains("-"))
            {
                string[] partesRut = rutCompleto.Split('-');
                string idEmpleado = partesRut[0]; // Parte numérica antes del guion
                string dv = partesRut[1]; // Dígito verificador (puede ser k)
                                          // Asegúrate de almacenar idEmpleado y rutCompleto en la base de datos
                return;
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

            // Limpia las casillas cuando se logra registrar un usuario
            txt_Rut.Clear();
            txt_Nombre.Clear();
            txt_Apellido_Paterno.Clear();
            txt_Apellido_Materno.Clear();
            txt_Email.Clear();
            cbox_Tipo_Contrato.Items.Clear();
            cbox_Tipo_Cargo.Items.Clear();
            cbox_IdUnidad.Items.Clear();
            cbox_IdDispositivo.Items.Clear();
            comboBox3.Text = "";
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
            
            // Obtener el ID del Tipo de Contrato seleccionado
            int tipoContratoSeleccionado = ((KeyValuePair<int, string>)cbox_Tipo_Contrato.SelectedItem).Key;
        }

        private void cbox_Tipo_Cargo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            // Obtener el ID de la Unidad seleccionada
            int idUnidadSeleccionada = ((KeyValuePair<int, string>)cbox_Tipo_Cargo.SelectedItem).Key;
        }

        private void cbox_IdUnidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            ;
            // Obtener el ID de la Unidad seleccionada
            int idUnidadSeleccionada = ((KeyValuePair<int, string>)cbox_IdUnidad.SelectedItem).Key;
        }

        private void cbox_IdDispositivo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            // Obtener el ID del dispositivo seleccionado
            int idDispositivoSeleccionado = ((KeyValuePair<int, string>)cbox_IdDispositivo.SelectedItem).Key;
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            txt_Rut.Clear();
            txt_Nombre.Clear();
            txt_Apellido_Paterno.Clear();
            txt_Apellido_Materno.Clear();
            txt_Email.Clear();
            cbox_Tipo_Contrato.Text = "";
            cbox_Tipo_Cargo.Text = "";
            cbox_IdUnidad.Text = "";
            cbox_IdDispositivo.Text = "";
            comboBox3.Text = "";

        }

        private void tabP_Horarios_Click(object sender, EventArgs e)
        {

        }
        

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.SelectedItem != null)
            {
                // Asumiendo que el item es un KeyValuePair<int, string>
                if (comboBox3.SelectedItem is KeyValuePair<int, string> selectedPair)
                {
                    int selectedId = selectedPair.Key;
                    ActualizarDataGridView(selectedId);
                }
                // Alternativamente, si es un objeto personalizado
                else
                {
                    dynamic item = comboBox3.SelectedItem; // Asignar el objeto como dynamic
                    try
                    {
                        int selectedId = item.IdHorario; // Acceder a la propiedad del objeto dynamic
                        ActualizarDataGridView(selectedId);
                    }
                    catch (RuntimeBinderException ex)
                    {
                        MessageBox.Show("Error al acceder a la propiedad IdHorario: " + ex.Message);
                    }
                }
            }
        }

        private void ActualizarDataGridView(int idHorario)
        {
            
            clsVer_Horarios horarioManager = new clsVer_Horarios();

                // Obtener la tabla formateada con los datos del horario
            DataTable dtFormatted = horarioManager.ObtenerHorarioFormateado(idHorario);

                // Asignar la tabla formateada al DataGridView
            dataGridView1.DataSource = dtFormatted;
            
        }

        private void lbl_Asignar_Horario_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void txt_Rut_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si la tecla presionada es un número o el signo menos
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '-')
            {
                e.Handled = true; // Ignorar el carácter
            }
            // Permitir solo un signo menos al inicio
            if (e.KeyChar == '-' && txt_Rut.Text.Length < 8)
            {
                e.Handled = true; // Ignorar el signo menos si hay otros caracteres
            }
        }
    }
    
}

