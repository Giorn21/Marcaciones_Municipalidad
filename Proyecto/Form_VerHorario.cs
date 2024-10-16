using common;
using common.BL;
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
    public partial class Form_VerHorario : Form
    {
        public Form_VerHorario()
        {
            InitializeComponent();
        }
        private void Form_VerHorario_Load_1(object sender, EventArgs e)
        {
            dtv_Horarios.RowValidated += new DataGridViewCellEventHandler(dtv_Horarios_RowValidated);

            dtv_Horarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dtv_Horarios.Columns.Clear();
            dtv_Horarios.AutoGenerateColumns = false;

            dtv_Horarios.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Día", DataPropertyName = "Dia" });
            dtv_Horarios.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Hora entrada en la mañana", DataPropertyName = "EntradaMañana" });
            dtv_Horarios.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Hora salida en la mañana", DataPropertyName = "SalidaMañana" });
            dtv_Horarios.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Hora entrada en la tarde", DataPropertyName = "EntradaTarde" });
            dtv_Horarios.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Hora salida en la tarde", DataPropertyName = "SalidaTarde" });
            dtv_Horarios.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Tolerancia entrada", DataPropertyName = "ToleranciaEntrada" });
            dtv_Horarios.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Total de horas trabajadas", DataPropertyName = "TotalHoras" });

            clsDatos_cboxsAgrFuncionario Datos_Horarios = new clsDatos_cboxsAgrFuncionario();
            Datos_Horarios.CargarHorarios(cbox_Horarios);
            if (cbox_Horarios.Items.Count > 0)
            {
                cbox_Horarios.SelectedIndex = 0;
            }

            cbox_Horarios.SelectedIndex = -1;
        }

        private void ActualizarDataGridView(int idHorario)
        {

            clsVer_Horarios horarioManager = new clsVer_Horarios();

            // Obtener la tabla formateada con los datos del horario
            DataTable dtFormatted = horarioManager.ObtenerHorarioFormateado(idHorario);

            // Asignar la tabla formateada al DataGridView
            dtv_Horarios.DataSource = dtFormatted;

        }

        private void cbox_Horarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbox_Horarios.SelectedItem != null)
            {
                if (cbox_Horarios.SelectedValue is int selectedIdHorario)
                {
                    ActualizarDataGridView(selectedIdHorario);
                }
            }
        }

        private void dtv_Horarios_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Verificar que la fila no esté vacía o sin cambios importantes
                if (dtv_Horarios.Rows[e.RowIndex].IsNewRow) return;

                // Lunes
                TimeSpan lEntradaManana = (TimeSpan)dtv_Horarios.Rows[e.RowIndex].Cells["L_EntradaMañana"].Value;
                TimeSpan lSalidaManana = (TimeSpan)dtv_Horarios.Rows[e.RowIndex].Cells["L_SalidaMañana"].Value;
                TimeSpan lEntradaTarde = (TimeSpan)dtv_Horarios.Rows[e.RowIndex].Cells["L_EntradaTarde"].Value;
                TimeSpan lSalidaTarde = (TimeSpan)dtv_Horarios.Rows[e.RowIndex].Cells["L_SalidaTarde"].Value;
                int lToleranciaEntrada = Convert.ToInt32(dtv_Horarios.Rows[e.RowIndex].Cells["L_ToleranciaEntrada"].Value);
                int lToleranciaSalida = Convert.ToInt32(dtv_Horarios.Rows[e.RowIndex].Cells["L_ToleranciaSalida"].Value);

                // Martes
                TimeSpan mEntradaManana = (TimeSpan)dtv_Horarios.Rows[e.RowIndex].Cells["M_EntradaMañana"].Value;
                TimeSpan mSalidaManana = (TimeSpan)dtv_Horarios.Rows[e.RowIndex].Cells["M_SalidaMañana"].Value;
                TimeSpan mEntradaTarde = (TimeSpan)dtv_Horarios.Rows[e.RowIndex].Cells["M_EntradaTarde"].Value;
                TimeSpan mSalidaTarde = (TimeSpan)dtv_Horarios.Rows[e.RowIndex].Cells["M_SalidaTarde"].Value;
                int mToleranciaEntrada = Convert.ToInt32(dtv_Horarios.Rows[e.RowIndex].Cells["M_ToleranciaEntrada"].Value);
                int mToleranciaSalida = Convert.ToInt32(dtv_Horarios.Rows[e.RowIndex].Cells["M_ToleranciaSalida"].Value);

                // Miércoles
                TimeSpan xEntradaManana = (TimeSpan)dtv_Horarios.Rows[e.RowIndex].Cells["X_EntradaMañana"].Value;
                TimeSpan xSalidaManana = (TimeSpan)dtv_Horarios.Rows[e.RowIndex].Cells["X_SalidaMañana"].Value;
                TimeSpan xEntradaTarde = (TimeSpan)dtv_Horarios.Rows[e.RowIndex].Cells["X_EntradaTarde"].Value;
                TimeSpan xSalidaTarde = (TimeSpan)dtv_Horarios.Rows[e.RowIndex].Cells["X_SalidaTarde"].Value;
                int xToleranciaEntrada = Convert.ToInt32(dtv_Horarios.Rows[e.RowIndex].Cells["X_ToleranciaEntrada"].Value);
                int xToleranciaSalida = Convert.ToInt32(dtv_Horarios.Rows[e.RowIndex].Cells["X_ToleranciaSalida"].Value);

                // Jueves
                TimeSpan jEntradaManana = (TimeSpan)dtv_Horarios.Rows[e.RowIndex].Cells["J_EntradaMañana"].Value;
                TimeSpan jSalidaManana = (TimeSpan)dtv_Horarios.Rows[e.RowIndex].Cells["J_SalidaMañana"].Value;
                TimeSpan jEntradaTarde = (TimeSpan)dtv_Horarios.Rows[e.RowIndex].Cells["J_EntradaTarde"].Value;
                TimeSpan jSalidaTarde = (TimeSpan)dtv_Horarios.Rows[e.RowIndex].Cells["J_SalidaTarde"].Value;
                int jToleranciaEntrada = Convert.ToInt32(dtv_Horarios.Rows[e.RowIndex].Cells["J_ToleranciaEntrada"].Value);
                int jToleranciaSalida = Convert.ToInt32(dtv_Horarios.Rows[e.RowIndex].Cells["J_ToleranciaSalida"].Value);

                // Viernes
                TimeSpan vEntradaManana = (TimeSpan)dtv_Horarios.Rows[e.RowIndex].Cells["V_EntradaMañana"].Value;
                TimeSpan vSalidaManana = (TimeSpan)dtv_Horarios.Rows[e.RowIndex].Cells["V_SalidaMañana"].Value;
                TimeSpan vEntradaTarde = (TimeSpan)dtv_Horarios.Rows[e.RowIndex].Cells["V_EntradaTarde"].Value;
                TimeSpan vSalidaTarde = (TimeSpan)dtv_Horarios.Rows[e.RowIndex].Cells["V_SalidaTarde"].Value;
                int vToleranciaEntrada = Convert.ToInt32(dtv_Horarios.Rows[e.RowIndex].Cells["V_ToleranciaEntrada"].Value);
                int vToleranciaSalida = Convert.ToInt32(dtv_Horarios.Rows[e.RowIndex].Cells["V_ToleranciaSalida"].Value);

                // Sábado
                TimeSpan sEntradaManana = (TimeSpan)dtv_Horarios.Rows[e.RowIndex].Cells["S_EntradaMañana"].Value;
                TimeSpan sSalidaManana = (TimeSpan)dtv_Horarios.Rows[e.RowIndex].Cells["S_SalidaMañana"].Value;
                TimeSpan sEntradaTarde = (TimeSpan)dtv_Horarios.Rows[e.RowIndex].Cells["S_EntradaTarde"].Value;
                TimeSpan sSalidaTarde = (TimeSpan)dtv_Horarios.Rows[e.RowIndex].Cells["S_SalidaTarde"].Value;
                int sToleranciaEntrada = Convert.ToInt32(dtv_Horarios.Rows[e.RowIndex].Cells["S_ToleranciaEntrada"].Value);
                int sToleranciaSalida = Convert.ToInt32(dtv_Horarios.Rows[e.RowIndex].Cells["S_ToleranciaSalida"].Value);

                // Domingo
                TimeSpan dEntradaManana = (TimeSpan)dtv_Horarios.Rows[e.RowIndex].Cells["D_EntradaMañana"].Value;
                TimeSpan dSalidaManana = (TimeSpan)dtv_Horarios.Rows[e.RowIndex].Cells["D_SalidaMañana"].Value;
                TimeSpan dEntradaTarde = (TimeSpan)dtv_Horarios.Rows[e.RowIndex].Cells["D_EntradaTarde"].Value;
                TimeSpan dSalidaTarde = (TimeSpan)dtv_Horarios.Rows[e.RowIndex].Cells["D_SalidaTarde"].Value;
                int dToleranciaEntrada = Convert.ToInt32(dtv_Horarios.Rows[e.RowIndex].Cells["D_ToleranciaEntrada"].Value);
                int dToleranciaSalida = Convert.ToInt32(dtv_Horarios.Rows[e.RowIndex].Cells["D_ToleranciaSalida"].Value);

                // Total horas semanales
                decimal totalHorasSemanales = Convert.ToDecimal(dtv_Horarios.Rows[e.RowIndex].Cells["TotalHorasSemanales"].Value);

                // Instanciar la clase y llamar al método para actualizar en la base de datos
                cls_UPD_Horarios actualizarHorario = new cls_UPD_Horarios();
                actualizarHorario.ActualizarHorario(
                    lEntradaManana, lSalidaManana, lEntradaTarde, lSalidaTarde, lToleranciaEntrada, lToleranciaSalida,
                    mEntradaManana, mSalidaManana, mEntradaTarde, mSalidaTarde, mToleranciaEntrada, mToleranciaSalida,
                    xEntradaManana, xSalidaManana, xEntradaTarde, xSalidaTarde, xToleranciaEntrada, xToleranciaSalida,
                    jEntradaManana, jSalidaManana, jEntradaTarde, jSalidaTarde, jToleranciaEntrada, jToleranciaSalida,
                    vEntradaManana, vSalidaManana, vEntradaTarde, vSalidaTarde, vToleranciaEntrada, vToleranciaSalida,
                    sEntradaManana, sSalidaManana, sEntradaTarde, sSalidaTarde, sToleranciaEntrada, sToleranciaSalida,
                    dEntradaManana, dSalidaManana, dEntradaTarde, dSalidaTarde, dToleranciaEntrada, dToleranciaSalida,
                    totalHorasSemanales);

                // Mensaje de éxito (opcional)
                MessageBox.Show("Horario actualizado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el horario: " + ex.Message);
            }
        }
    }
}
