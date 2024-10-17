using common;
using common.BL;
using DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class Form_VerHorario : Form
    {
        cls_UPD_Horarios actualizarHorario = new cls_UPD_Horarios();
        Horario horarioActual = null;
        clsVer_Horarios verHorarios = new clsVer_Horarios();

        public Form_VerHorario()
        {
            InitializeComponent();
        }

        private void Form_VerHorario_Load_1(object sender, EventArgs e)
        {
            btn_Actualizar.Enabled = false;

            // Se configura el evento RowValidated del DataGridView
            dtv_Horarios.RowValidated += new DataGridViewCellEventHandler(dtv_Horarios_RowValidated);

            // Configurar el DataGridView para que las columnas ocupen todo el espacio
            dtv_Horarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Limpiar las columnas actuales
            dtv_Horarios.Columns.Clear();
            dtv_Horarios.AutoGenerateColumns = false;

            // Agregar columnas al DataGridView
            dtv_Horarios.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Día", DataPropertyName = "Dia" });
            dtv_Horarios.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Hora entrada en la mañana", DataPropertyName = "EntradaMañana" });
            dtv_Horarios.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Hora salida en la mañana", DataPropertyName = "SalidaMañana" });
            dtv_Horarios.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Hora entrada en la tarde", DataPropertyName = "EntradaTarde" });
            dtv_Horarios.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Hora salida en la tarde", DataPropertyName = "SalidaTarde" });
            dtv_Horarios.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Tolerancia entrada", DataPropertyName = "ToleranciaEntrada" });
            dtv_Horarios.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Total de horas trabajadas", DataPropertyName = "TotalHoras" });

            // Cargar los horarios en el ComboBox
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
            // Instancia de la clase que maneja la lógica para obtener el horario
            clsVer_Horarios horarioManager = new clsVer_Horarios();

            // Obtener la tabla formateada con los datos del horario
            DataTable dtFormatted = horarioManager.ObtenerHorarioFormateado(idHorario);

            // Asignar la tabla formateada al DataGridView
            dtv_Horarios.DataSource = dtFormatted;
        }

        private void cbox_Horarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Si hay un horario seleccionado en el ComboBox, actualizar el DataGridView
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
            btn_Actualizar.Enabled = true;
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Form_Menu menu = new Form_Menu();
            menu.Show();
            this.Close();
        }

        private void dtv_Horarios_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btn_Actualizar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dtv_Horarios.Rows)
            {
                if (row.IsNewRow) continue; // Evitar filas vacías

                // Capturar los valores de las celdas para todos los días de la semana

                // Lunes
                TimeSpan lunesEntradaManana = TimeSpan.Parse(row.Cells[1].Value.ToString());
                TimeSpan lunesSalidaManana = TimeSpan.Parse(row.Cells[2].Value.ToString());
                TimeSpan lunesEntradaTarde = TimeSpan.Parse(row.Cells[3].Value.ToString());
                TimeSpan lunesSalidaTarde = TimeSpan.Parse(row.Cells[4].Value.ToString());
                int lunesToleranciaEntrada = Convert.ToInt32(row.Cells[5].Value);


                // Martes
                TimeSpan martesEntradaManana = TimeSpan.Parse(row.Cells[1].Value.ToString());
                TimeSpan martesSalidaManana = TimeSpan.Parse(row.Cells[2].Value.ToString());
                TimeSpan martesEntradaTarde = TimeSpan.Parse(row.Cells[3].Value.ToString());
                TimeSpan martesSalidaTarde = TimeSpan.Parse(row.Cells[4].Value.ToString());
                int martesToleranciaEntrada = Convert.ToInt32(row.Cells[5].Value);


                // Miércoles
                TimeSpan miercolesEntradaManana = TimeSpan.Parse(row.Cells[1].Value.ToString());
                TimeSpan miercolesSalidaManana = TimeSpan.Parse(row.Cells[2].Value.ToString());
                TimeSpan miercolesEntradaTarde = TimeSpan.Parse(row.Cells[3].Value.ToString());
                TimeSpan miercolesSalidaTarde = TimeSpan.Parse(row.Cells[4].Value.ToString());
                int miercolesToleranciaEntrada = Convert.ToInt32(row.Cells[5].Value);


                // Jueves
                TimeSpan juevesEntradaManana = TimeSpan.Parse(row.Cells[1].Value.ToString());
                TimeSpan juevesSalidaManana = TimeSpan.Parse(row.Cells[2].Value.ToString());
                TimeSpan juevesEntradaTarde = TimeSpan.Parse(row.Cells[3].Value.ToString());
                TimeSpan juevesSalidaTarde = TimeSpan.Parse(row.Cells[4].Value.ToString());
                int juevesToleranciaEntrada = Convert.ToInt32(row.Cells[5].Value);


                // Viernes
                TimeSpan viernesEntradaManana = TimeSpan.Parse(row.Cells[1].Value.ToString());
                TimeSpan viernesSalidaManana = TimeSpan.Parse(row.Cells[2].Value.ToString());
                TimeSpan viernesEntradaTarde = TimeSpan.Parse(row.Cells[3].Value.ToString());
                TimeSpan viernesSalidaTarde = TimeSpan.Parse(row.Cells[4].Value.ToString());
                int viernesToleranciaEntrada = Convert.ToInt32(row.Cells[5].Value);


                // Sábado
                TimeSpan sabadoEntradaManana = TimeSpan.Parse(row.Cells[1].Value.ToString());
                TimeSpan sabadoSalidaManana = TimeSpan.Parse(row.Cells[2].Value.ToString());
                TimeSpan sabadoEntradaTarde = TimeSpan.Parse(row.Cells[3].Value.ToString());
                TimeSpan sabadoSalidaTarde = TimeSpan.Parse(row.Cells[4].Value.ToString());
                int sabadoToleranciaEntrada = Convert.ToInt32(row.Cells[5].Value);


                // Domingo
                TimeSpan domingoEntradaManana = TimeSpan.Parse(row.Cells[1].Value.ToString());
                TimeSpan domingoSalidaManana = TimeSpan.Parse(row.Cells[2].Value.ToString());
                TimeSpan domingoEntradaTarde = TimeSpan.Parse(row.Cells[3].Value.ToString());
                TimeSpan domingoSalidaTarde = TimeSpan.Parse(row.Cells[4].Value.ToString());
                int domingoToleranciaEntrada = Convert.ToInt32(row.Cells[5].Value);


                // Llamar al método que actualiza la base de datos
                ActualizarHorario( lunesEntradaManana, lunesSalidaManana, lunesEntradaTarde, lunesSalidaTarde, lunesToleranciaEntrada,
                    martesEntradaManana, martesSalidaManana, martesEntradaTarde, martesSalidaTarde, martesToleranciaEntrada,
                    miercolesEntradaManana, miercolesSalidaManana, miercolesEntradaTarde, miercolesSalidaTarde, miercolesToleranciaEntrada, 
                    juevesEntradaManana, juevesSalidaManana, juevesEntradaTarde, juevesSalidaTarde, juevesToleranciaEntrada, 
                    viernesEntradaManana, viernesSalidaManana, viernesEntradaTarde, viernesSalidaTarde, viernesToleranciaEntrada, 
                    sabadoEntradaManana, sabadoSalidaManana, sabadoEntradaTarde, sabadoSalidaTarde, sabadoToleranciaEntrada, 
                    domingoEntradaManana, domingoSalidaManana, domingoEntradaTarde, domingoSalidaTarde, domingoToleranciaEntrada);
            }

            // Deshabilitar el botón después de actualizar
            btn_Actualizar.Enabled = false;
        }

        private void ActualizarHorario(
            TimeSpan lunesEntradaManana, TimeSpan lunesSalidaManana, TimeSpan lunesEntradaTarde, TimeSpan lunesSalidaTarde, int lunesToleranciaEntrada, 
            TimeSpan martesEntradaManana, TimeSpan martesSalidaManana, TimeSpan martesEntradaTarde, TimeSpan martesSalidaTarde, int martesToleranciaEntrada, 
            TimeSpan miercolesEntradaManana, TimeSpan miercolesSalidaManana, TimeSpan miercolesEntradaTarde, TimeSpan miercolesSalidaTarde, int miercolesToleranciaEntrada, 
            TimeSpan juevesEntradaManana, TimeSpan juevesSalidaManana, TimeSpan juevesEntradaTarde, TimeSpan juevesSalidaTarde, int juevesToleranciaEntrada, 
            TimeSpan viernesEntradaManana, TimeSpan viernesSalidaManana, TimeSpan viernesEntradaTarde, TimeSpan viernesSalidaTarde, int viernesToleranciaEntrada, 
            TimeSpan sabadoEntradaManana, TimeSpan sabadoSalidaManana, TimeSpan sabadoEntradaTarde, TimeSpan sabadoSalidaTarde, int sabadoToleranciaEntrada, 
            TimeSpan domingoEntradaManana, TimeSpan domingoSalidaManana, TimeSpan domingoEntradaTarde, TimeSpan domingoSalidaTarde, int domingoToleranciaEntrada)
        {
            BaseDatos DB = new BaseDatos();
            DB.Conectar();
            SqlConnection conn = DB.Conectar();

            using (SqlCommand cmd = new SqlCommand("sp_UPD_Horario"))
            {

                cmd.CommandType = CommandType.StoredProcedure;


                cmd.Parameters.AddWithValue("@L_EntradaMañana", lunesEntradaManana);
                cmd.Parameters.AddWithValue("@L_SalidaMañana", lunesSalidaManana);
                cmd.Parameters.AddWithValue("@L_EntradaTarde", lunesEntradaTarde);
                cmd.Parameters.AddWithValue("@L_SalidaTarde", lunesSalidaTarde);
                cmd.Parameters.AddWithValue("@L_ToleranciaEntrada", lunesToleranciaEntrada);


                // Parámetros para el Martes
                cmd.Parameters.AddWithValue("@M_EntradaMañana", martesEntradaManana);
                cmd.Parameters.AddWithValue("@M_SalidaMañana", martesSalidaManana);
                cmd.Parameters.AddWithValue("@M_EntradaTarde", martesEntradaTarde);
                cmd.Parameters.AddWithValue("@M_SalidaTarde", martesSalidaTarde);
                cmd.Parameters.AddWithValue("@M_ToleranciaEntrada", martesToleranciaEntrada);


                // Parámetros para el Miércoles
                cmd.Parameters.AddWithValue("@X_EntradaMañana", miercolesEntradaManana);
                cmd.Parameters.AddWithValue("@X_SalidaMañana", miercolesSalidaManana);
                cmd.Parameters.AddWithValue("@X_EntradaTarde", miercolesEntradaTarde);
                cmd.Parameters.AddWithValue("@X_SalidaTarde", miercolesSalidaTarde);
                cmd.Parameters.AddWithValue("@X_ToleranciaEntrada", miercolesToleranciaEntrada);


                // Parámetros para el Jueves
                cmd.Parameters.AddWithValue("@J_EntradaMañana", juevesEntradaManana);
                cmd.Parameters.AddWithValue("@J_SalidaMañana", juevesSalidaManana);
                cmd.Parameters.AddWithValue("@J_EntradaTarde", juevesEntradaTarde);
                cmd.Parameters.AddWithValue("@J_SalidaTarde", juevesSalidaTarde);
                cmd.Parameters.AddWithValue("@J_ToleranciaEntrada", juevesToleranciaEntrada);


                // Parámetros para el Viernes
                cmd.Parameters.AddWithValue("@V_EntradaMañana", viernesEntradaManana);
                cmd.Parameters.AddWithValue("@V_SalidaMañana", viernesSalidaManana);
                cmd.Parameters.AddWithValue("@V_EntradaTarde", viernesEntradaTarde);
                cmd.Parameters.AddWithValue("@V_SalidaTarde", viernesSalidaTarde);
                cmd.Parameters.AddWithValue("@V_ToleranciaEntrada", viernesToleranciaEntrada);


                // Parámetros para el Sábado
                cmd.Parameters.AddWithValue("@S_EntradaMañana", sabadoEntradaManana);
                cmd.Parameters.AddWithValue("@S_SalidaMañana", sabadoSalidaManana);
                cmd.Parameters.AddWithValue("@S_EntradaTarde", sabadoEntradaTarde);
                cmd.Parameters.AddWithValue("@S_SalidaTarde", sabadoSalidaTarde);
                cmd.Parameters.AddWithValue("@S_ToleranciaEntrada", sabadoToleranciaEntrada);


                // Parámetros para el Domingo
                cmd.Parameters.AddWithValue("@D_EntradaMañana", domingoEntradaManana);
                cmd.Parameters.AddWithValue("@D_SalidaMañana", domingoSalidaManana);
                cmd.Parameters.AddWithValue("@D_EntradaTarde", domingoEntradaTarde);
                cmd.Parameters.AddWithValue("@D_SalidaTarde", domingoSalidaTarde);
                cmd.Parameters.AddWithValue("@D_ToleranciaEntrada", domingoToleranciaEntrada);

                cmd.ExecuteNonQuery(); 
            }

            DB.Desconectar();
        }

        private void dtv_Horarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
