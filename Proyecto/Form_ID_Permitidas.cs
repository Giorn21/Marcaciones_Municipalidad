using common.Models;
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
    public partial class Form_ID_Permitidas : Form
    {
        List<Marcaciones> ayuda = new List<Marcaciones>();
        private clsAyuda_ID_Nombres clsAyuda = new clsAyuda_ID_Nombres();

        public Form_ID_Permitidas()
        {
            InitializeComponent();
        }

        private void diseñoButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargarDatos()
        {
            dtv_Ayuda.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            try
            {
                // Obtener la lista de funcionarios
                ayuda = clsAyuda.ObtenerAyuda_Id_nombre();

                dtv_Ayuda.Rows.Clear();

                foreach (var b in ayuda)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dtv_Ayuda);

                    // Asignar valores a las celdas correspondientes
                    row.Cells[0].Value = b.ID;
                    row.Cells[1].Value = b.Nombre;

                    dtv_Ayuda.Rows.Add(row);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }
        }

        private void Form_ID_Permitidas_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }
    }
}
