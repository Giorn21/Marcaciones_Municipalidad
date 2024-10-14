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
    public partial class Form_VerContrato : Form
    {
        clsVer_TipoContrato VerContratos = new clsVer_TipoContrato();
        List<TipoContrato> Contratos = new List<TipoContrato>();
        public Form_VerContrato()
        {
            InitializeComponent();
        }

        private void btn_Volver_Click(object sender, EventArgs e)
        {
            Form_Menu menu = new Form_Menu();
            menu.Show();
            this.Close();
        }

        private void Form_VerContrato_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void CargarDatos(string filtro = null)
        {
            dtv_TipoContrato.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            try
            {
                // Obtener la lista de funcionarios
                Contratos = VerContratos.ObtenerContrato();

                dtv_TipoContrato.Rows.Clear();

                foreach (var C in Contratos)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dtv_TipoContrato);

                    // Asignar valores a las celdas correspondientes
                    row.Cells[0].Value = C.Contrato;
                    row.Cells[1].Value = C.Descripcion;

                    dtv_TipoContrato.Rows.Add(row);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }
        }

        private void dtv_TipoContrato_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica que una fila válida haya sido seleccionada
            if (e.RowIndex >= 0)
            {
                int contratoId = Convert.ToInt32(dtv_TipoContrato.Rows[e.RowIndex].Cells[0].Value);
                string descripcion = dtv_TipoContrato.Rows[e.RowIndex].Cells[1].Value.ToString();

                // Crear una instancia del formulario de actualización
                Form_UPD_Contrato UPD_Contrato = new Form_UPD_Contrato();

                // Pasar los datos al formulario de actualización
                UPD_Contrato.CargarDatos(contratoId, descripcion);

                UPD_Contrato.ShowDialog();
                this.Close();
            }
        }
    }
}
