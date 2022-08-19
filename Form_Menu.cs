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
    public partial class Form_Menu : Form
    {
        public Form_Menu()
        {
            InitializeComponent();
        }        

        private void button_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_nov_termin_Click(object sender, EventArgs e)
        {
            Form_Nov_Termin formaTermin = new Form_Nov_Termin();
            this.Hide();
            formaTermin.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form_Login formaLogin = new Form_Login();
            this.Close();
            formaLogin.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_Moji_Termini formMojiTerm = new Form_Moji_Termini();
            this.Hide();
            formMojiTerm.Show();
        }

        private void button_Cenovnik_Click(object sender, EventArgs e)
        {
            Form_Cenovnik m = new Form_Cenovnik();
            this.Hide();
            m.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Info i = new Form_Info();
            i.Show();
        }
    }
}
