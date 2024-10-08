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
    public partial class Form_buscador_Logs : Form
    {
        public Form_buscador_Logs()
        {
            InitializeComponent();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            Form_Menu menu = new Form_Menu();
            menu.Show();
            this.Close();
        }
    }
}
