using common;
using common.Models;
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
    public partial class Form_VerMarcas : Form
    {
        List<TipoMarca> TipoMarcas = new List<TipoMarca>();
        clsVer_TipoMarca VerTipoMarca = new clsVer_TipoMarca();
        public Form_VerMarcas()
        {
            InitializeComponent();
        }

        private void Form_VerMarcas_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btn_Volver_Click_1(object sender, EventArgs e)
        {
            Form_Menú menu = new Form_Menú();
            menu.Show();
            this.Close();
        }

        private void CargarDatos()
        {
            dtv_TipoMarcas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            try
            {
                // Obtener la lista de funcionarios
                TipoMarcas = VerTipoMarca.ObtenerTipoMarca();

                dtv_TipoMarcas.Rows.Clear();

                foreach (var Tm in TipoMarcas)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dtv_TipoMarcas);

                    // Asignar valores a las celdas correspondientes
                    
                    row.Cells[0].Value = Tm.Descripcion;
                    row.Cells[1].Value = Tm.Autorizacion;

                    dtv_TipoMarcas.Rows.Add(row);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }
        }
    }
}
