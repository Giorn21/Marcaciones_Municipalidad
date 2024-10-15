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
    public partial class Form_VerUnidad : Form
    {
        clsVer_TipoUnidad VerUnidad = new clsVer_TipoUnidad();
        List<TipoUnidad> Unidad = new List<TipoUnidad>();
        public Form_VerUnidad()
        {
            InitializeComponent();
        }

        private void btn_Volver_Click(object sender, EventArgs e)
        {
            Form_Menu menu = new Form_Menu();
            menu.Show();
            this.Close();
        }

        private void CargarDatos()
        {
            dtv_TipoUnidad.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            try
            {
                // Obtener la lista de funcionarios
                Unidad = VerUnidad.ObtenerUnidad();

                dtv_TipoUnidad.Rows.Clear();

                foreach (var U in Unidad)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dtv_TipoUnidad);

                    // Asignar valores a las celdas correspondientes
                    row.Cells[0].Value = U.Direccion;
                    row.Cells[1].Value = U.IdUnidad;
                    row.Cells[2].Value = U.Descripcion;
                    row.Cells[3].Value = U.Ubicacion;
                    row.Cells[4].Value = U.Telefono;
                    row.Cells[5].Value = U.Email;

                    dtv_TipoUnidad.Rows.Add(row);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }
        }

        private void Form_VerUnidad_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                    "¿Estás seguro de que deseas Agregar una nueva Unidad?",
                    "Confirmación de Desvinculación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

            // Si el usuario hace clic en "SI"
            if (result == DialogResult.Yes)
            {
                Form_Agregar_Unidades AgrUnidades = new Form_Agregar_Unidades();
                AgrUnidades.Show();
                this.Close();
            }
            
        }
        private void dtv_TipoUnidad_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Obtener los valores de la fila seleccionada
                string direccion = dtv_TipoUnidad.Rows[e.RowIndex].Cells[0].Value.ToString();
                int IdUnidad = Convert.ToInt32(dtv_TipoUnidad.Rows[e.RowIndex].Cells[1].Value);
                string descripcion = dtv_TipoUnidad.Rows[e.RowIndex].Cells[2].Value.ToString();
                string ubicacion = dtv_TipoUnidad.Rows[e.RowIndex].Cells[3].Value.ToString();
                string telefono = dtv_TipoUnidad.Rows[e.RowIndex].Cells[4].Value.ToString();
                string email = dtv_TipoUnidad.Rows[e.RowIndex].Cells[5].Value.ToString();

                // Crear una instancia del formulario de actualización
                Form_UPD_Unidad UPD_Unidad = new Form_UPD_Unidad();

                // Pasar los datos al formulario de actualización
                UPD_Unidad.CargarDatos(IdUnidad, direccion, descripcion, ubicacion, telefono, email);
                UPD_Unidad.Show();
                this.Close();
            }
        }
    }
}
