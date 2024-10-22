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
    public partial class Form_Agregar__Horario : Form
    {
        public Form_Agregar__Horario()
        {
            InitializeComponent();

            foreach(Control c in this.Controls)
            {
                if (c is DateTimePicker)
                {
                    ((DateTimePicker)c).ShowUpDown = true;
                }
            }
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Form_VerHorario verHorario = new Form_VerHorario();
            verHorario.Show();
            this.Close();
        }
    }
}
