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
    public partial class Form_VerBiometria : Form
    {
        List<TipoBiometria> biometrias = new List<TipoBiometria>();
        private clsVer_TipoBiometria verBiometria = new clsVer_TipoBiometria();
        public Form_VerBiometria()
        {
            InitializeComponent();
        }

        private void btn_Volver_Click(object sender, EventArgs e)
        {
            Form_Menu Menu = new Form_Menu();
            Menu.Show();
            this.Close();
        }

        private void Form_VerBiometria_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }
        private void CargarDatos(string filtro = null)
        {
            dtv_Biometria.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            try
            {
                // Obtener la lista de funcionarios
                biometrias = verBiometria.ObtenerBiometria();

                dtv_Biometria.Rows.Clear();

                foreach (var b in biometrias)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dtv_Biometria);

                    // Asignar valores a las celdas correspondientes
                    row.Cells[0].Value = b.Biometria;
                    row.Cells[1].Value = b.Descripcion;

                    dtv_Biometria.Rows.Add(row);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }
        }
    }
}
