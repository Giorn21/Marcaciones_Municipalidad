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

            foreach (DataGridViewColumn c in dtv_Horarios.Columns)
            {
                c.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
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
            // Lunes
            string lunesEntradaManana = dtv_Horarios.Rows[0].Cells[1].Value.ToString();
            string lunesSalidaManana = dtv_Horarios.Rows[0].Cells[2].Value.ToString();
            string lunesEntradaTarde = dtv_Horarios.Rows[0].Cells[3].Value.ToString();
            string lunesSalidaTarde = dtv_Horarios.Rows[0].Cells[4].Value.ToString();
            int lunesToleranciaEntrada = Convert.ToInt32(dtv_Horarios.Rows[0].Cells[5].Value.ToString());

            // Martes
            string martesEntradaManana = dtv_Horarios.Rows[1].Cells[1].Value.ToString();
            string martesSalidaManana = dtv_Horarios.Rows[1].Cells[2].Value.ToString();
            string martesEntradaTarde = dtv_Horarios.Rows[1].Cells[3].Value.ToString();
            string martesSalidaTarde = dtv_Horarios.Rows[1].Cells[4].Value.ToString();
            int martesToleranciaEntrada = Convert.ToInt32(dtv_Horarios.Rows[1].Cells[5].Value.ToString());

            // Miércoles
            string miercolesEntradaManana = dtv_Horarios.Rows[2].Cells[1].Value.ToString();
            string miercolesSalidaManana = dtv_Horarios.Rows[2].Cells[2].Value.ToString();
            string miercolesEntradaTarde = dtv_Horarios.Rows[2].Cells[3].Value.ToString();
            string miercolesSalidaTarde = dtv_Horarios.Rows[2].Cells[4].Value.ToString();
            int miercolesToleranciaEntrada = Convert.ToInt32(dtv_Horarios.Rows[2].Cells[5].Value.ToString());

            // Jueves
            string juevesEntradaManana = dtv_Horarios.Rows[3].Cells[1].Value.ToString();
            string juevesSalidaManana = dtv_Horarios.Rows[3].Cells[2].Value.ToString();
            string juevesEntradaTarde = dtv_Horarios.Rows[3].Cells[3].Value.ToString();
            string juevesSalidaTarde = dtv_Horarios.Rows[3].Cells[4].Value.ToString();
            int juevesToleranciaEntrada = Convert.ToInt32(dtv_Horarios.Rows[3].Cells[5].Value.ToString());

            // Viernes
            string viernesEntradaManana = dtv_Horarios.Rows[4].Cells[1].Value.ToString();
            string viernesSalidaManana = dtv_Horarios.Rows[4].Cells[2].Value.ToString();
            string viernesEntradaTarde = dtv_Horarios.Rows[4].Cells[3].Value.ToString();
            string viernesSalidaTarde = dtv_Horarios.Rows[4].Cells[4].Value.ToString();
            int viernesToleranciaEntrada = Convert.ToInt32(dtv_Horarios.Rows[4].Cells[5].Value.ToString());

            // Sábado
            string sabadoEntradaManana = dtv_Horarios.Rows[5].Cells[1].Value.ToString();
            string sabadoSalidaManana = dtv_Horarios.Rows[5].Cells[2].Value.ToString();
            string sabadoEntradaTarde = dtv_Horarios.Rows[5].Cells[3].Value.ToString();
            string sabadoSalidaTarde = dtv_Horarios.Rows[5].Cells[4].Value.ToString();
            int sabadoToleranciaEntrada = Convert.ToInt32(dtv_Horarios.Rows[5].Cells[5].Value.ToString());

            // Domingo
            string domingoEntradaManana = dtv_Horarios.Rows[6].Cells[1].Value.ToString();
            string domingoSalidaManana = dtv_Horarios.Rows[6].Cells[2].Value.ToString();
            string domingoEntradaTarde = dtv_Horarios.Rows[6].Cells[3].Value.ToString();
            string domingoSalidaTarde = dtv_Horarios.Rows[6].Cells[4].Value.ToString();
            int domingoToleranciaEntrada = Convert.ToInt32(dtv_Horarios.Rows[6].Cells[5].Value.ToString());

            // Llamar al método que actualiza la base de datos
            ActualizarHorario(int.Parse(cbox_Horarios.SelectedValue.ToString()), lunesEntradaManana, lunesSalidaManana, lunesEntradaTarde, lunesSalidaTarde, lunesToleranciaEntrada,
                martesEntradaManana, martesSalidaManana, martesEntradaTarde, martesSalidaTarde, martesToleranciaEntrada,
                miercolesEntradaManana, miercolesSalidaManana, miercolesEntradaTarde, miercolesSalidaTarde, miercolesToleranciaEntrada, 
                juevesEntradaManana, juevesSalidaManana, juevesEntradaTarde, juevesSalidaTarde, juevesToleranciaEntrada, 
                viernesEntradaManana, viernesSalidaManana, viernesEntradaTarde, viernesSalidaTarde, viernesToleranciaEntrada, 
                sabadoEntradaManana, sabadoSalidaManana, sabadoEntradaTarde, sabadoSalidaTarde, sabadoToleranciaEntrada, 
                domingoEntradaManana, domingoSalidaManana, domingoEntradaTarde, domingoSalidaTarde, domingoToleranciaEntrada);


            // Deshabilitar el botón después de actualizar
            btn_Actualizar.Enabled = false;

        }

        private DateTime? formatoFecha(int fila, int col)
        {
            if (string.IsNullOrEmpty(dtv_Horarios.Rows[fila].Cells[col].Value.ToString()))
            {
                return null;
            }
            else
            {
                return DateTime.Parse(dtv_Horarios.Rows[fila].Cells[col].Value.ToString());

            }
        }

        private void ActualizarHorario( int horario,
        string lunesEntradaManana, string lunesSalidaManana, string lunesEntradaTarde, string lunesSalidaTarde, int lunesToleranciaEntrada,
        string martesEntradaManana, string martesSalidaManana, string martesEntradaTarde, string martesSalidaTarde, int martesToleranciaEntrada,
        string miercolesEntradaManana, string miercolesSalidaManana, string miercolesEntradaTarde, string miercolesSalidaTarde, int miercolesToleranciaEntrada,
        string juevesEntradaManana, string juevesSalidaManana, string juevesEntradaTarde, string juevesSalidaTarde, int juevesToleranciaEntrada,
        string viernesEntradaManana, string viernesSalidaManana, string viernesEntradaTarde, string viernesSalidaTarde, int viernesToleranciaEntrada,
        string sabadoEntradaManana, string sabadoSalidaManana, string sabadoEntradaTarde, string sabadoSalidaTarde, int sabadoToleranciaEntrada,
        string domingoEntradaManana, string domingoSalidaManana, string domingoEntradaTarde, string domingoSalidaTarde, int domingoToleranciaEntrada)
        {
            BaseDatos DB = new BaseDatos();
            DB.Conectar();

            DB.CrearComando("sp_UPD_Horario @IdHorario," +
            " @L_EntradaMañana, @L_SalidaMañana, @L_EntradaTarde, @L_SalidaTarde, @L_ToleranciaEntrada," +
            " @M_EntradaMañana, @M_SalidaMañana, @M_EntradaTarde, @M_SalidaTarde, @M_ToleranciaEntrada," +
            " @X_EntradaMañana, @X_SalidaMañana, @X_EntradaTarde, @X_SalidaTarde, @X_ToleranciaEntrada," +
            " @J_EntradaMañana, @J_SalidaMañana, @J_EntradaTarde, @J_SalidaTarde, @J_ToleranciaEntrada," +
            " @V_EntradaMañana, @V_SalidaMañana, @V_EntradaTarde, @V_SalidaTarde, @V_ToleranciaEntrada," +
            " @S_EntradaMañana, @S_SalidaMañana, @S_EntradaTarde, @S_SalidaTarde, @S_ToleranciaEntrada," +
            " @D_EntradaMañana, @D_SalidaMañana, @D_EntradaTarde, @D_SalidaTarde, @D_ToleranciaEntrada");

            // Parámetros para Lunes
            DB.AsignarParametroEntero("@IdHorario", horario);

            DB.AsignarParametroCadena("@L_EntradaMañana", lunesEntradaManana);
            DB.AsignarParametroCadena("@L_SalidaMañana", lunesSalidaManana);
            DB.AsignarParametroCadena("@L_EntradaTarde", lunesEntradaTarde);
            DB.AsignarParametroCadena("@L_SalidaTarde", lunesSalidaTarde);
            DB.AgregarParametro("@L_ToleranciaEntrada", lunesToleranciaEntrada);

            // Parámetros para Martes
            DB.AsignarParametroCadena("@M_EntradaMañana", martesEntradaManana);
            DB.AsignarParametroCadena("@M_SalidaMañana", martesSalidaManana);
            DB.AsignarParametroCadena("@M_EntradaTarde", martesEntradaTarde);
            DB.AsignarParametroCadena("@M_SalidaTarde", martesSalidaTarde);
            DB.AgregarParametro("@M_ToleranciaEntrada", martesToleranciaEntrada);

            // Parámetros para Miércoles
            DB.AsignarParametroCadena("@X_EntradaMañana", miercolesEntradaManana);
            DB.AsignarParametroCadena("@X_SalidaMañana", miercolesSalidaManana);
            DB.AsignarParametroCadena("@X_EntradaTarde", miercolesEntradaTarde);
            DB.AsignarParametroCadena("@X_SalidaTarde", miercolesSalidaTarde);
            DB.AgregarParametro("@X_ToleranciaEntrada", miercolesToleranciaEntrada);

            // Parámetros para Jueves
            DB.AsignarParametroCadena("@J_EntradaMañana", juevesEntradaManana);
            DB.AsignarParametroCadena("@J_SalidaMañana", juevesSalidaManana);
            DB.AsignarParametroCadena("@J_EntradaTarde", juevesEntradaTarde);
            DB.AsignarParametroCadena("@J_SalidaTarde", juevesSalidaTarde);
            DB.AgregarParametro("@J_ToleranciaEntrada", juevesToleranciaEntrada);

            // Parámetros para Viernes
            DB.AsignarParametroCadena("@V_EntradaMañana", viernesEntradaManana);
            DB.AsignarParametroCadena("@V_SalidaMañana", viernesSalidaManana);
            DB.AsignarParametroCadena("@V_EntradaTarde", viernesEntradaTarde);
            DB.AsignarParametroCadena("@V_SalidaTarde", viernesSalidaTarde);
            DB.AgregarParametro("@V_ToleranciaEntrada", viernesToleranciaEntrada);

            // Parámetros para Sábado
            DB.AsignarParametroCadena("@S_EntradaMañana", sabadoEntradaManana);
            DB.AsignarParametroCadena("@S_SalidaMañana", sabadoSalidaManana);
            DB.AsignarParametroCadena("@S_EntradaTarde", sabadoEntradaTarde);
            DB.AsignarParametroCadena("@S_SalidaTarde", sabadoSalidaTarde);
            DB.AgregarParametro("@S_ToleranciaEntrada", sabadoToleranciaEntrada);

            // Parámetros para Domingo
            DB.AsignarParametroCadena("@D_EntradaMañana", domingoEntradaManana);
            DB.AsignarParametroCadena("@D_SalidaMañana", domingoSalidaManana);
            DB.AsignarParametroCadena("@D_EntradaTarde", domingoEntradaTarde);
            DB.AsignarParametroCadena("@D_SalidaTarde", domingoSalidaTarde);
            DB.AgregarParametro("@D_ToleranciaEntrada", domingoToleranciaEntrada);

            // Ejecutar el procedimiento almacenado
            DB.EjecutarComando();

            DB.Desconectar();
        }

        private void dtv_Horarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            Form_Agregar__Horario AgrHorario = new Form_Agregar__Horario();
            AgrHorario.Show();
            this.Close();
        }

        private void dtv_Horarios_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // Verificamos que las columnas editables son las columnas [1] a [4]
            if (e.ColumnIndex >= 1 && e.ColumnIndex <= 4)
            {
                var cellValue = dtv_Horarios.Rows[e.RowIndex].Cells[e.ColumnIndex].Value?.ToString().Trim();

                // Si la celda está vacía o es nula, almacenamos como null
                if (string.IsNullOrEmpty(cellValue))
                {
                    dtv_Horarios.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = DBNull.Value;
                    return; // Salimos del método
                }

                // Solo se permite ingresar números y los dos puntos (:)
                if (!System.Text.RegularExpressions.Regex.IsMatch(cellValue, @"^[0-9: ]+$"))
                {
                    MessageBox.Show("Solo se permiten números y el símbolo ':'", "Entrada no válida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dtv_Horarios.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = DBNull.Value;
                    return;
                }

                // Quitamos los espacios en caso de que haya algún espacio innecesario
                cellValue = cellValue.Replace(" ", "");

                // Tratamos las entradas según el formato
                string formattedTime = "";
                if (cellValue.Length == 2) // Entrada con solo hora (ej: "12")
                {
                    formattedTime = cellValue + ":00:00"; // Asumimos minutos y segundos como 00
                }
                else if (cellValue.Length == 4 && !cellValue.Contains(":")) // Entrada tipo "1230"
                {
                    formattedTime = cellValue.Insert(2, ":") + ":00"; // Convertimos "1230" en "12:30:00"
                }
                else if (cellValue.Contains(":")) // Entrada que ya contiene un separador (ej: "12:30")
                {
                    if (cellValue.Count(c => c == ':') == 1) // Solo tiene una separación
                    {
                        formattedTime = cellValue + ":00"; // Si es "12:30", convertimos en "12:30:00"
                    }
                    else
                    {
                        formattedTime = cellValue; // Si ya tiene el formato completo, lo dejamos tal cual
                    }
                }

                // Intentamos parsear a DateTime para asegurarnos que es válido
                if (DateTime.TryParse(formattedTime, out DateTime parsedTime))
                {
                    dtv_Horarios.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = parsedTime.ToString("HH:mm:ss");
                }
                else
                {
                    MessageBox.Show("La hora ingresada no es válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dtv_Horarios.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = DBNull.Value;
                }
            }
        }

        private void dtv_Horarios_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                e.Cancel = true;
            }

            if (e.ColumnIndex == 6)
            {
                e.Cancel = true;
            }

            if (e.RowIndex == 7) 
            {
                e.Cancel = true; 
            }
        }

        private void cbox_Horarios_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void dtv_Horarios_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; 
            }
        }

        private void dtv_Horarios_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dtv_Horarios.CurrentCell.ColumnIndex >= 1 && dtv_Horarios.CurrentCell.ColumnIndex <= 5)
            {
                TextBox txt = e.Control as TextBox;
                if (txt != null)
                {
                    txt.KeyPress -= dtv_Horarios_KeyPress;
                    txt.KeyPress += dtv_Horarios_KeyPress;
                }
            }
        }
    }
}
