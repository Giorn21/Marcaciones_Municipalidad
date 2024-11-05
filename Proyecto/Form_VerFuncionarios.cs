using common;
using NLog.Filters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class Form_VerFuncionarios : Form
    {
        List<Funcionario> funcionarios = new List<Funcionario>();
        private clsVer_Funcionarios verFuncionarios = new clsVer_Funcionarios();

        public Form_VerFuncionarios()
        {
            InitializeComponent();
        }

        private void CargarDatos(string filtro = null)
        {
            dtv_BaseDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            try
            {
                // Obtener la lista de funcionarios
                funcionarios = verFuncionarios.ObtenerFuncionarios();

                // Filtrar si hay un filtro proporcionado
                if (!string.IsNullOrEmpty(filtro))
                {
                    funcionarios = funcionarios
                    .Where(f => f.Rut.ToLower().Contains(filtro) || f.Nombres.ToLower().Contains(filtro))
                    .ToList();
                }

                dtv_BaseDatos.Rows.Clear();

                foreach (var f in funcionarios)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dtv_BaseDatos);

                    // Asignar valores a las celdas correspondientes
                    row.Cells[0].Value = f.IdEmpleado;
                    row.Cells[1].Value = f.Rut;
                    row.Cells[2].Value = f.Nombres;
                    row.Cells[3].Value = f.ApellidoPaterno;
                    row.Cells[4].Value = f.ApellidoMaterno;
                    row.Cells[5].Value = f.Foto;
                    row.Cells[6].Value = f.Email;
                    row.Cells[7].Value = f.Contrato;
                    row.Cells[8].Value = f.Cargo;
                    row.Cells[9].Value = f.Unidad;
                    row.Cells[10].Value = f.IdDispositivo;

                    dtv_BaseDatos.Rows.Add(row);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }
        }

        private void Home_Load(object sender, EventArgs e)
        {
            txt_Buscador.Text = textoinvisible;
            txt_Buscador.ForeColor = Color.Gray;

            CargarDatos();
        }

        private void diseñoIconButton1_Click(object sender, EventArgs e)
        {
            Form_Agregar_Funcionario agregar_Funcionario = new Form_Agregar_Funcionario();
            agregar_Funcionario.Show();
            this.Close();
        }

        //texto con Informacion 
        private string textoinvisible = "Buscar por RUT o Nombre";

        private void txt_Buscador_TextChanged(object sender, EventArgs e)
        {

            if (txt_Buscador.Text == textoinvisible)
            {
                return;
            }

            if (txt_Buscador.TextLength >= 1)
            {
                CargarDatos(txt_Buscador.Text);
            }
            else
            {
                CargarDatos();
            }
        }

        private void txt_Buscador_Enter(object sender, EventArgs e)
        {
            if (txt_Buscador.Text == textoinvisible) 
            { 
                txt_Buscador.Text = "";
                txt_Buscador.ForeColor = Color.Black;
            }
        }

        private void txt_Buscador_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_Buscador.Text)) 
            { 
                txt_Buscador.Text = textoinvisible;
                txt_Buscador.ForeColor= Color.Gray;
            }
        }

        private int IdEmpleado;

        private void diseñoButton1_Click(object sender, EventArgs e)
        {
            Form_Menu menu = new Form_Menu();
            menu.Show();
            this.Close();
        }

        private void diseñoIconButton2_Click(object sender, EventArgs e)
        {
            clsAgregar_LogsApp logs = new clsAgregar_LogsApp();

            if (IdEmpleado > 0)
            {
                // Mensaje de advertencia
                DialogResult result = MessageBox.Show(
                    "¿Estás seguro de que deseas desvincular a este funcionario?",
                    "Confirmación de Desvinculación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                // Si el usuario hace clic en "SI"
                if (result == DialogResult.Yes)
                {
                    clsDesvincularFuncionario funcionarioManager = new clsDesvincularFuncionario();
                    DateTime fechaDesvinculacion = DateTime.Now;

                    try
                    {
                        if (funcionarioManager.DesvincularFuncionario(IdEmpleado, fechaDesvinculacion))
                        {
                            MessageBox.Show("Funcionario desvinculado exitosamente.");
                            string Usuario = LoginUser.Usuario;
                            logs.InsertarLog("Funcionarios", "Desv Fun", Usuario, "Se a desvinculado un Funcionario");
                            CargarDatos();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                        string Usuario = LoginUser.Usuario;
                        logs.InsertarLog("Funcionarios", "ErrDesv", Usuario, ex.Message);
                        txt_Buscador.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Desvinculación cancelada.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un funcionario para desvincular.");
            }
        }

        private void dtv_BaseDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = dtv_BaseDatos.Rows[e.RowIndex];

                if (row.Cells[0].Value != null)
                {
                    IdEmpleado = Convert.ToInt32(row.Cells[0].Value);
                }
                else
                {
                    MessageBox.Show("No se pudo encontrar el valor de IdEmpleado en la fila seleccionada.");
                }
            }
        }
    }
}
