using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace common.BL
{
    public class clsDatos_cboxsAgrFuncionario
    {
        // Método para cargar los tipos de contrato en el ComboBox
        public void CargarTiposContratos(ComboBox cboxTipoContrato)
        {
            var tiposContratos = new Dictionary<int, string>
            {
                { 1, "Código del Trabajo" },
                { 5, "Plazo Fijo" },
                { 6, "Reemplazo" },
                { 7, "Indefinidos" },
                { 10, "Honorarios" }
            };

            cboxTipoContrato.DataSource = new BindingSource(tiposContratos, null);
            cboxTipoContrato.DisplayMember = "Value";
            cboxTipoContrato.ValueMember = "Key";
        }

        public void CargarTipoCargo(ComboBox cboxTipoCargo) 
        {
            // Cargar datos Tipo Cargo
            var TipoCargo = new Dictionary<int, string>
            {
                { 0, "No configurado" },
                { 1, "Administrativo" },
                { 15, "Ingeniero en informática" },
                { 16, "Desarrollo" }

            };

            cboxTipoCargo.DataSource = new BindingSource(TipoCargo, null);
            cboxTipoCargo.DisplayMember = "Value";
            cboxTipoCargo.ValueMember = "Key";

        }

        public void CargarTipoUnidad(ComboBox cbox_IdUnidad) 
        {

            var Unidad = new Dictionary<int, string>
            {
                { 1, "Administración" },
                { 2, "Remuneraciones" },
                { 3, "Adquisiciones" },
                { 4, "Movilización" },
                { 5, "Mantención" },
                { 6, "Tesorería" },
                { 7, "INFORMATICA" },
                { 8, "D.A.S.M."},
                { 9, "CECOSF MILLALEMU" },
                { 10, "CENTRO DE ESTERILIZACION" },
                { 11, "CENTRO PODOLOGICO SUR" },
                { 12, "CESFAM LA GRANJA" },
                { 13, "CESFAM MALAQUIAS CONCHA" },
                { 14, "CESFAM PADRE ESTEBAN GUMUSCIO" },
                { 15, "CONST PADRE ESTEBAN GUMUCIO" },
                { 16, "COSAM "},
                { 17, "DIRECCION DE SALUD"},
                { 18, "DROGUERIA"} ,
                { 19, "HIPOTERAPIA"},
                { 20, "PODOLOGICO GRANJA"},
                { 21, "SAPU DENTAL"},
                { 22, "UAPO"},
                { 23, "CENTRO SALUD MENTAL"},
                { 24, "CONST.PADRE ESTEBAN GUMUCIO"},
                { 25, "CECOSF SAN GREGORIO"},
                { 26, "PROMOCION DE SALUD"},
                { 27, "AMBULANCIAS Y CONSULTORIOS"},
                { 28, "CECOSF YUNGAY"},
                { 29, "CCR VIDA BUENA"},
                { 30, "DROGUERÍA"},
                { 31, "CCR SAN GREGORIO"},
                { 32, "CECOSF VILLA LA SERENA"},
                { 33, "CESFAM GRANJA SUR"},
                { 34, "CCR LA GRANJA"},
                { 35, "FARMACIA COMUNAL"},
                { 36, "CESFAM PADRE ESTEBAN GUMUCIO"}

            };

            cbox_IdUnidad.DataSource = new BindingSource(Unidad, null);
            cbox_IdUnidad.DisplayMember = "Value";
            cbox_IdUnidad.ValueMember = "Key";

        }

        public void CargarDispositvos(ComboBox cbox_IdDispositivo) 
        {

            // Cargar Datos de Dispositivo
            var dispositivos = new Dictionary<int, string>
            {
                { 1, "uFace800" }
                // Agrega los demás dispositivos si es necesario...
            };

            cbox_IdDispositivo.DataSource = new BindingSource(dispositivos, null);
            cbox_IdDispositivo.DisplayMember = "Value";
            cbox_IdDispositivo.ValueMember = "Key";
        }

        public void CargarHorarios(ComboBox cbox_Horarios) 
        { 
            var Horarios = new Dictionary<int, string>
            {
                { 1, "HORARIO NORMAL 1 44 HRS " },
                { 2, "HORARIO NORMAL 2 44 HRS " },
                { 3, "HORARIO NORMAL 3 44 HRS " },
                { 4, "HORARIO 4  - 44HRS " },
                { 5, "HORARIO 5 - 44 HRS " },
                { 6, "HORARIO 6- 22HRS " },
                { 7, "HORARIO 7 - 44HRS " },
                { 8, "HORARIO 8 - 44HRS "},
                { 9, "HORARIO 9  - 44HRS " },
                { 10, "HORARIO 10  - 44HRS " },
                { 11, "HORARIO 11 - 44HRS " },
                { 12, "HORARIO 12 - 44HRS " },
                { 13, "HORARIO 13 - 44HRS " },
                { 14, "HORARIO 14 - 33HRS " },
                { 15, "HORARIO 15 - 44HRS " },
                { 16, "HORARIO 16 - 44HRS "},
                { 17, "HORARIO 17 - 44HRS "},
                { 18, "HORARIO 18 - 44HRS "} ,
                { 19, "HORARIO 19 - 44HRS "},
                { 20, "HORARIO 20 - 44HRS "},
                { 21, "HORARIO 21 - 44HRS "},
                { 22, "HORARIO 22 - 44HRS "},
                { 23, "HORARIO 23 - 44HRS "},
                { 24, "HORARIO 24 - 33HRS "},
                { 25, "HORARIO 25 - 44HRS "},
                { 26, "HORARIO 26 - 22HRS "},
                { 27, "HORARIO 27 - 33HRS "},
                { 28, "HORARIO 28 - 33HRS "},
                { 29, "HORARIO 29 - 44HRS "},
                { 30, "HORARIO 30 - 44HRS "},
                { 31, "HORARIO 31 - 22HRS "},
                { 32, "HORARIO 32 - 22HRS "},
                { 33, "HORARIO 33 - 30HRS "},
                { 34, "HORARIO 34 - 44HRS "},
                { 35, "HORARIO 35 - 44HRS "},
                { 36, "HORARIO 36 - 44HRS "},
                { 37, "HORARIO 37 - 33HRS "},
                { 38, "HORARIO 38 - 44HRS "},
                { 39, "HORARIO 39 - 40HRS "},
                { 40, "HORARIO 40 - 22HRS "},
                { 41, "HORARIO 41 - 22HRS "},
                { 42, "HORARIO 42 - 44HRS "},
                { 43, "HORARIO 43 - 44HRS "},
                { 44, "HORARIO 44 - 44HRS "},
                { 45, "HORARIO 45 - 44HRS "},
                { 46, "HORARIO 46 - 11HRS "},
                { 47, "HORARIO 47 - 18HRS "},
            };

            cbox_Horarios.DataSource = new BindingSource(Horarios, null);
            cbox_Horarios.DisplayMember = "Value";
            cbox_Horarios.ValueMember = "Key";

        }
    }
}
