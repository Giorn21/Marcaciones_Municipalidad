using common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class Form_VerMarcaciones : Form
    {
        private clsVer_Marcaciones verMarcaciones = new clsVer_Marcaciones();

        List<Marcaciones> marcaciones = new List<Marcaciones>();

        public Form_VerMarcaciones()
        {
            InitializeComponent();
        }

        private void Form_Marcaciones_Load(object sender, EventArgs e)
        {
            this.dtv_Marcaciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            txt_Buscador.Text = placeholderText;
            txt_Buscador.ForeColor = Color.Gray;

            try
            {
                marcaciones = verMarcaciones.ObtenerMarcaciones();
                dtv_Marcaciones.Rows.Clear();

                foreach (var M in marcaciones)
                {

                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dtv_Marcaciones);

                    row.Cells[0].Value = M.ID;
                    row.Cells[1].Value = M.Nombre;
                    row.Cells[2].Value = M.Apellido;
                    row.Cells[3].Value = M.fecha;
                    row.Cells[4].Value = M.hora;
                    row.Cells[5].Value = M.TipoMarca;

                    dtv_Marcaciones.Rows.Add(row);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }
        }

        private void btn_Volver_Click(object sender, EventArgs e)
        {
            Form_Menu menu = new Form_Menu();
            menu.Show();
            this.Close();
        }

        private string placeholderText = "Buscar por RUT o Nombre";

        private void txt_Buscador_TextChanged(object sender, EventArgs e)
        {

            if (txt_Buscador.Text == placeholderText)
            {
                return;
            }

            if (txt_Buscador.TextLength >= 1)
            {
                FiltrarMarcanciones(txt_Buscador.Text);
            }
            else
            {
                List<Funcionario> f = new List<Funcionario>();
                dtv_Marcaciones.Rows.Clear();

                foreach (var M in marcaciones)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dtv_Marcaciones);

                    row.Cells[0].Value = M.ID;
                    row.Cells[1].Value = M.Nombre;
                    row.Cells[2].Value = M.Apellido;
                    row.Cells[3].Value = M.fecha;
                    row.Cells[4].Value = M.hora;
                    row.Cells[5].Value = M.TipoMarca;

                    dtv_Marcaciones.Rows.Add(row);
                }
            }
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
                txt_Buscador.ForeColor = Color.Gray;
            }
        }
        private void FiltrarMarcanciones(string filtro)
        {
            var resultado = marcaciones.Where(M => M.ID.ToString().Contains(filtro) || M.Nombre.ToLower().Contains(filtro)).ToList();
            dtv_Marcaciones.Rows.Clear();

            foreach (var R in resultado)
            {
                // Crear una nueva fila
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dtv_Marcaciones);

                row.Cells[0].Value = R.ID;
                row.Cells[1].Value = R.Nombre;
                row.Cells[2].Value = R.Apellido;
                row.Cells[3].Value = R.fecha;
                row.Cells[4].Value = R.hora;
                row.Cells[5].Value = R.TipoMarca;

                dtv_Marcaciones.Rows.Add(row);
            }
        }
    }
}
