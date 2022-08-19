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
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();            
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }        

        private void button_nov_termin_Click(object sender, EventArgs e)
        {
            Form_Registracija formReg = new Form_Registracija();
            this.Hide();
            formReg.Show();
        }
        public string vratiUsername()
        {
            String username = textBoxUsername.Text;            
            return username;
        }
        public string vratiPassword()
        {
            String password = textBoxPassword.Text;
            return password;
        }

        private void button_Prijava_Click(object sender, EventArgs e)
        {

            String username = textBoxUsername.Text;
            String password = textBoxPassword.Text;
            DatabaseConn dc = new DatabaseConn();

            string v = dc.Login(username,password);
            
            if (v!="")
            {               
                
                Korisnik.username = textBoxUsername.Text; ;
                Korisnik.password = textBoxPassword.Text;
                
                
                
                this.Hide();
                Form_Menu mainform = new Form_Menu();                
                mainform.Show();
            }
            else
            {
                MessageBox.Show("Greška!");
            }

        }        
    }
}