using common;
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
    public partial class Form_Funcionarios : Form
    {
        List<Funcionario> funcionarios = new List<Funcionario>();

        //texto con Informacion de que debe agregar para el BUSCAR_TEXTBOX
        private string placeholderText = "Buscar por RUT o Nombre";



        public Form_Funcionarios()
        {
            InitializeComponent();
        }

        private clsVerFuncionarios clsDataGrid = new clsVerFuncionarios();

        private void Home_Load(object sender, EventArgs e)
        {
            //el DataGridView se ajusta a la cantidad de datos
            this.dtv_BaseDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Asignar el texto de ejemplo
            // Cambiar el color para que parezca un placeholder
            txt_Buscador.Text = placeholderText;
            txt_Buscador.ForeColor = Color.Gray;

            try
            {
                // Obtener la lista de funcionarios
                funcionarios = clsDataGrid.ObtenerFuncionarios();

                // Limpiar las filas existentes, pero sin modificar las columnas
                dtv_BaseDatos.Rows.Clear();

                // Iterar sobre la lista de funcionarios y agregar cada uno al DataGridView
                foreach (var funcionario in funcionarios)
                {
                    // Crear una nueva fila basada en las columnas ya existentes en el DataGridView
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dtv_BaseDatos);

                    // Asignar valores a las celdas correspondientes
                    row.Cells[0].Value = funcionario.IdEmpleado;
                    row.Cells[1].Value = funcionario.Rut;
                    row.Cells[2].Value = funcionario.Nombres;
                    row.Cells[3].Value = funcionario.ApellidoPaterno;
                    row.Cells[4].Value = funcionario.ApellidoMaterno;
                    row.Cells[5].Value = funcionario.Foto;
                    row.Cells[6].Value = funcionario.Email;
                    row.Cells[7].Value = funcionario.Contrato;
                    row.Cells[8].Value = funcionario.Cargo;
                    row.Cells[9].Value = funcionario.IdDispositivo;
                    

                    // Agregar la fila al DataGridView
                    dtv_BaseDatos.Rows.Add(row);
                }
            }
            catch (Exception ex)
            {
                // Manejo de errores
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dtv_BaseDatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_Agregar_Funcionario agregar_Funcionario = new Form_Agregar_Funcionario();
            agregar_Funcionario.Show();
            this.Close();
        }

        private void FiltrarFuncionarios(string filtro)
        {
            // Convertir el filtro a minúsculas para hacer la búsqueda insensible a mayúsculas/minúsculas
            filtro = filtro.ToLower();

            // Filtrar la lista de funcionarios, buscando tanto por RUT como por Nombres
            var resultado = funcionarios.Where(f => f.Rut.ToLower().Contains(filtro) || f.Nombres.ToLower().Contains(filtro)).ToList();

            // Limpiar las filas existentes (sin afectar las columnas)
            dtv_BaseDatos.Rows.Clear();

            // Iterar sobre los funcionarios filtrados
            foreach (var f in resultado)
            {
                // Crear una nueva fila basada en las columnas existentes
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
                row.Cells[9].Value = f.IdDispositivo;

                // Agregar la fila al DataGridView
                dtv_BaseDatos.Rows.Add(row);
            }
        }

        private void txt_Buscador_TextChanged(object sender, EventArgs e)
        {

            if (txt_Buscador.Text == placeholderText) 
            {
                return;
            }
            // Si hay al menos un carácter en el cuadro de búsqueda
            if (txt_Buscador.TextLength >= 1)
            {
                FiltrarFuncionarios(txt_Buscador.Text);
            }
            else
            {
                // Desenlazar la fuente de datos antes de asignar la lista original
                dtv_BaseDatos.DataSource = null;

                dtv_BaseDatos.Rows.Clear();

                // Volver a mostrar todos los datos
                foreach (var f in funcionarios)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dtv_BaseDatos);

                    row.Cells[0].Value = f.IdEmpleado;
                    row.Cells[1].Value = f.Rut;
                    row.Cells[2].Value = f.Nombres;
                    row.Cells[3].Value = f.ApellidoPaterno;
                    row.Cells[4].Value = f.ApellidoMaterno;
                    row.Cells[5].Value = f.Foto;
                    row.Cells[6].Value = f.Email;
                    row.Cells[7].Value = f.Contrato;
                    row.Cells[8].Value = f.Cargo;
                    row.Cells[9].Value = f.IdDispositivo;

                    dtv_BaseDatos.Rows.Add(row);
                }
            }
        }


        private void dtv_BaseDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void txt_Buscador_Enter(object sender, EventArgs e)
        {
            if (txt_Buscador.Text == placeholderText) 
            { 
                txt_Buscador.Text = "";
                txt_Buscador.ForeColor = Color.Black;
            }
        }

        private void txt_Buscador_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_Buscador.Text)) 
            { 
                txt_Buscador.Text = placeholderText;
                txt_Buscador.ForeColor= Color.Gray;
            }
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Form_Menu menu = new Form_Menu();
            menu.Show();
            this.Close();
        }
    }
}
