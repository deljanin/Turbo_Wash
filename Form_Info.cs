using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EP_Programirnaje_projekat___program
{
    public partial class Form_Info : Form
    {
        public Form_Info()
        {
            InitializeComponent();
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_Nazad_Click(object sender, EventArgs e)
        {
            this.Close();
            Form_Menu m = new Form_Menu();
            m.Show();
        }
    }
}
