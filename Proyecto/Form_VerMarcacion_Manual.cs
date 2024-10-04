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
    public partial class Form_VerMarcacion_Manual : Form
    {

        private clsVerMacacionesManuales verMarcacionesManuales = new clsVerMacacionesManuales();

        List<Marcaciones> marcaciones = new List<Marcaciones>();

        public Form_VerMarcacion_Manual()
        {
            InitializeComponent();
        }

        private void TSM_Nuevo_Click(object sender, EventArgs e)
        {
            Form_Agregar_Marcacion_Manual marcacionManual = new Form_Agregar_Marcacion_Manual();
            marcacionManual.Show();
            this.Close();
        }

        private void Form_VerMarcacion_Manual_Load(object sender, EventArgs e)
        {
            this.dtv_Marcaciones_Manuales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            try
            {
                marcaciones = verMarcacionesManuales.ObtenerMarcacionesManuales();
                dtv_Marcaciones_Manuales.Rows.Clear();

                foreach (var M in marcaciones)
                {

                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dtv_Marcaciones_Manuales);

                    row.Cells[0].Value = M.ID;
                    row.Cells[1].Value = M.Nombre;
                    row.Cells[2].Value = M.Apellido;
                    row.Cells[3].Value = M.fecha;
                    row.Cells[4].Value = M.hora;
                    row.Cells[5].Value = M.TipoMarca;
                    row.Cells[6].Value = M.Comentario;

                    dtv_Marcaciones_Manuales.Rows.Add(row);
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
        private string placeholderText = "Buscar por ID";

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

                dtv_Marcaciones_Manuales.Rows.Clear();

                // Cargar todos los datos de nuevo
                foreach (var M in marcaciones)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dtv_Marcaciones_Manuales);

                    row.Cells[0].Value = M.ID;
                    row.Cells[1].Value = M.Nombre;
                    row.Cells[2].Value = M.Apellido;
                    row.Cells[3].Value = M.fecha;
                    row.Cells[4].Value = M.hora;
                    row.Cells[5].Value = M.TipoMarca;
                    row.Cells[6].Value = M.Comentario;

                    dtv_Marcaciones_Manuales.Rows.Add(row);
                }
            }
        }
        private void FiltrarMarcanciones(string filtro)
        {
            var resultado = marcaciones.Where(M => M.ID.ToString().Contains(filtro) || M.Nombre.ToLower().Contains(filtro)).ToList();
            dtv_Marcaciones_Manuales.Rows.Clear();

            foreach (var R in resultado)
            {
                // Crear una nueva fila
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dtv_Marcaciones_Manuales);

                // Asignar valores a las celdas
                row.Cells[0].Value = R.ID;
                row.Cells[1].Value = R.Nombre;
                row.Cells[2].Value = R.Apellido;
                row.Cells[3].Value = R.fecha;
                row.Cells[4].Value = R.hora;
                row.Cells[5].Value = R.TipoMarca;
                row.Cells[6].Value = R.Comentario;

                dtv_Marcaciones_Manuales.Rows.Add(row);
            }
        }
    }
}
