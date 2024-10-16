using common;
using common.BL;
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
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static common.clsAgregar_Funcionarios;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Text.RegularExpressions;
using System.Reflection.Emit;

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
            Form_VerFuncionarios funcionarios = new Form_VerFuncionarios();
            funcionarios.Show();
            this.Close();
        }

        private void Form_Agregar_Funcionario_Load(object sender, EventArgs e)
        {
            lbl_FechaTiempoReal.Text = DateTime.Now.ToString("dd/MM/yyyy");

            dataGridView1.Columns.Clear();
            dataGridView1.AutoGenerateColumns = false;

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Día", DataPropertyName = "Dia" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Hora entrada en la mañana", DataPropertyName = "EntradaMañana" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Hora salida en la mañana", DataPropertyName = "SalidaMañana" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Hora entrada en la tarde", DataPropertyName = "EntradaTarde" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Hora salida en la tarde", DataPropertyName = "SalidaTarde" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Tolerancia entrada", DataPropertyName = "ToleranciaEntrada" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Total de horas trabajadas", DataPropertyName = "TotalHoras" });

            clsDatos_cboxsAgrFuncionario Datos_Contratos = new clsDatos_cboxsAgrFuncionario();

            Datos_Contratos.CargarTiposContratos(cbox_Tipo_Contrato);
            // Verificar que el ComboBox tenga items después de cargar los datos
            if (cbox_Tipo_Contrato.Items.Count > 0)
            {
                cbox_Tipo_Contrato.SelectedIndex = 0; // Selecciona el primer elemento si es necesario
            }


            clsDatos_cboxsAgrFuncionario Datos_cargo = new clsDatos_cboxsAgrFuncionario();
            Datos_cargo.CargarTipoCargo(cbox_Tipo_Cargo);
            if (cbox_Tipo_Cargo.Items.Count > 0)
            {
                cbox_Tipo_Cargo.SelectedIndex = 0; 
            }


            clsDatos_cboxsAgrFuncionario Datos_unidad = new clsDatos_cboxsAgrFuncionario();
            Datos_unidad.CargarTipoUnidad(cbox_IdUnidad);
            if (cbox_IdUnidad.Items.Count > 0)
            {
                cbox_IdUnidad.SelectedIndex = 0; 
            }

            clsDatos_cboxsAgrFuncionario Datos_dispositivo = new clsDatos_cboxsAgrFuncionario();
            Datos_dispositivo.CargarDispositivos(cbox_IdDispositivo);
            if (cbox_IdDispositivo.Items.Count > 0)
            {
                cbox_IdDispositivo.SelectedIndex = 0; 
            }

            clsDatos_cboxsAgrFuncionario Datos_Horarios = new clsDatos_cboxsAgrFuncionario();
            Datos_Horarios.CargarHorarios(cbox_Horarios);
            if (cbox_Horarios.Items.Count > 0)
            {
                cbox_Horarios.SelectedIndex = 0; 
            }


            //Limpia las Combobox al inicar el formulario
            cbox_Tipo_Contrato.SelectedIndex = -1;
            cbox_Tipo_Cargo.SelectedIndex = -1;
            cbox_IdUnidad.SelectedIndex = -1;
            cbox_IdDispositivo.SelectedIndex = -1;
            cbox_Horarios.SelectedIndex = -1;

            if (cbox_Horarios.SelectedIndex == -1)
            {
                dataGridView1.DataSource = null; 
                dataGridView1.Rows.Clear();       
            }

        }

        private void btn_Registro_Click(object sender, EventArgs e)
        {
            if (txt_Rut.Text == "" || txt_Nombre.Text == "" || txt_Apellido_Paterno.Text == "" || txt_Apellido_Materno.Text == "" || txt_Email.Text == "" || cbox_Tipo_Contrato.Text == "" || cbox_Tipo_Cargo.Text == "" || cbox_IdUnidad.Text == "" || cbox_IdDispositivo.Text == "")
            {
                MessageBox.Show("!ALERTA¡ : Rellene todas las casillas");

                return;
            } else if (cbox_Horarios.Text == "") 
            {
                MessageBox.Show("!ALERTA¡ : Elija una Horario para el Funcionario");
                return;
            }

            clsInsertarFuncionario nuevoUsuario = new clsInsertarFuncionario();
            clsAgregar_LogsApp logs = new clsAgregar_LogsApp();


            try
            {

                nuevoUsuario.ProcesarRut(txt_Rut.Text);
                nuevoUsuario.ValidarCorreo(txt_Email.Text);
                nuevoUsuario.DatosFuncionario.Nombre = txt_Nombre.Text;
                nuevoUsuario.DatosFuncionario.ApellidoPaterno = txt_Apellido_Paterno.Text;
                nuevoUsuario.DatosFuncionario.ApellidoMaterno = txt_Apellido_Materno.Text;
                nuevoUsuario.SeleccionarTipoContrato((int)cbox_Tipo_Contrato.SelectedValue);
                nuevoUsuario.SeleccionarTipoCargo((int)cbox_Tipo_Cargo.SelectedValue);
                nuevoUsuario.SeleccionarUnidad((int)cbox_IdUnidad.SelectedValue);
                nuevoUsuario.SeleccionarDispositivo((int)cbox_IdDispositivo.SelectedValue);
                nuevoUsuario.SeleccionarHorario((int)cbox_Horarios.SelectedValue);
                nuevoUsuario.DatosFuncionario.Fecha = DateTime.Now;

                if (nuevoUsuario.RegistrarUsuario())
                {
                    MessageBox.Show("Usuario registrado exitosamente.");
                    string Usuario = LoginUser.Usuario;
                    logs.InsertarLog("funcionarios", "Agr Nuevo", Usuario, "Se a agregado un nuevo funcionario a la base de datos.");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                string Usuario = LoginUser.Usuario;
                logs.InsertarLog("funcionarios", "Err Agr", Usuario, ex.Message);
                return; 
            }

            // Limpia las casillas cuando se logra registrar un usuario
            txt_Rut.Clear();
            txt_Nombre.Clear();
            txt_Apellido_Paterno.Clear();
            txt_Apellido_Materno.Clear();
            txt_Email.Clear();
            cbox_Tipo_Contrato.SelectedIndex = -1;
            cbox_Tipo_Cargo.SelectedIndex = -1;
            cbox_IdUnidad.SelectedIndex = -1;
            cbox_IdDispositivo.SelectedIndex = -1;
            cbox_Horarios.SelectedIndex = -1;

            if (cbox_Horarios.SelectedIndex == -1)
            {
                // Limpia el DataGridView
                dataGridView1.DataSource = null; 
                dataGridView1.Rows.Clear();       
            }
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            txt_Rut.Clear();
            txt_Nombre.Clear();
            txt_Apellido_Paterno.Clear();
            txt_Apellido_Materno.Clear();
            txt_Email.Clear();
            cbox_Tipo_Contrato.SelectedIndex = -1;
            cbox_Tipo_Cargo.SelectedIndex = -1;
            cbox_IdUnidad.SelectedIndex = -1;
            cbox_IdDispositivo.SelectedIndex = -1;
            cbox_Horarios.SelectedIndex = -1;

            if (cbox_Horarios.SelectedIndex == -1)
            {
                // Limpia el DataGridView
                dataGridView1.DataSource = null; 
                dataGridView1.Rows.Clear();       
            }

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbox_Horarios.SelectedItem != null)
            {
                if (cbox_Horarios.SelectedValue is int selectedIdHorario)
                {

                    ActualizarDataGridView(selectedIdHorario);
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

        private void txt_Rut_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '-' && e.KeyChar != 'K' && e.KeyChar != 'k')
            {
                e.Handled = true; 
            }

            if (e.KeyChar == '-' && txt_Rut.Text.Contains("-"))
            {
                e.Handled = true; 
            }
        }
    }
    
}

