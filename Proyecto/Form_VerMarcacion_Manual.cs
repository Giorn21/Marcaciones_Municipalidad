using common;
using NLog.Filters;
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

        private clsVer_MacacionesManuales verMarcacionesManuales = new clsVer_MacacionesManuales();

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

        private void CargarDatosMarcacionesManuales(string filtro = null)
        {
            dtv_Marcaciones_Manuales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            try
            {
                // Obtener las marcaciones manuales
                marcaciones = verMarcacionesManuales.ObtenerMarcacionesManuales();

                // Filtrar si hay un filtro proporcionado
                if (!string.IsNullOrEmpty(filtro))
                {
                    marcaciones = marcaciones.Where(M => M.ID.ToString().Contains(filtro) || M.Nombre.ToLower().Contains(filtro)).ToList();
                }

                dtv_Marcaciones_Manuales.Rows.Clear();

                // Llenar el DataGridView con las marcaciones obtenidas
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

        private void Form_VerMarcacion_Manual_Load(object sender, EventArgs e)
        {
            txt_Buscador.Text = placeholderText;
            txt_Buscador.ForeColor = Color.Gray;

            CargarDatosMarcacionesManuales();
        }

        private void btn_Volver_Click(object sender, EventArgs e)
        {
            Form_Menú menu = new Form_Menú();
            menu.Show();
            this.Close();
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

        private string placeholderText = "Buscar por RUT o Nombre";

        private void txt_Buscador_TextChanged(object sender, EventArgs e)
        {
            if (txt_Buscador.Text == placeholderText)
            {
                return;
            }

            if (txt_Buscador.TextLength >= 1)
            {
                CargarDatosMarcacionesManuales(txt_Buscador.Text);
            }
            else
            {
                CargarDatosMarcacionesManuales(); 
            }
        }
    }
}
