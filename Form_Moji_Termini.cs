using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EP_Programirnaje_projekat___program
{
    public partial class Form_Moji_Termini : Form
    {
        public Form_Moji_Termini()
        {
            InitializeComponent();
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_nazad_Click(object sender, EventArgs e)
        {
            Form_Menu formameni = new Form_Menu();
            this.Close();
            formameni.Show();
        }

        private void Form_Moji_Termini_Load(object sender, EventArgs e)
        {            
            SqlConnection k = new SqlConnection(DatabaseConn.conn);
            string korid = new Korisnik().VratiId();
            string query = $"SELECT broj_tab as 'Broj Tablica',tip_pranja as 'Tip Pranja',vreme_datum as 'Vreme i Datum' FROM termini where id_korisnik = '{korid}'";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query,k);
            k.Open();
            da.Fill(ds, "termini");
            dataGridView1.DataSource = ds.Tables["termini"].DefaultView;
            k.Close();
            int counter = 1;
           
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {                
                if (counter == 7)
                {
                    label2.Text = "Imate besplatno\npranje!";
                }
                else if (counter > 7)
                {
                    counter = 1;
                    label2.Text = "";
                }
                counter += 1;
            }
            
        }
    }
}
