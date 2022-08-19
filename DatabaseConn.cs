using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace EP_Programirnaje_projekat___program
{
    class DatabaseConn
    {
        public static string conn = Properties.Settings.Default.autoperionicaConnectionString;
        SqlConnection konekcija = new SqlConnection(DatabaseConn.conn);        

        public string Login(string username,string password)
        {
            SqlConnection kon = new SqlConnection(DatabaseConn.conn);

            SqlDataReader rider = null;
            string query = $"SELECT * FROM korisnici WHERE korisnicko_ime = '{username}' and lozinka = '{password}'";
            SqlCommand command = new SqlCommand(query, kon);
            StringBuilder sb = new StringBuilder();
            kon.Open();
            rider = command.ExecuteReader();        


            if (rider.Read() == true)
            {
                return rider[0].ToString();
            }
            else
            {
                return "";
            }
        }

        public void Registracija(string user, string mail, string pass)
        {
            
            SqlCommand komanda;

            string s = $"INSERT INTO korisnici(korisnicko_ime, email, lozinka) VALUES('{user}','{mail}','{pass}');";//$"INSERT INTO korisnici (korisnicko_ime,email,lozinka) VALUES('{user}','{mail}','{pass}');";
            MessageBox.Show(s);
            komanda = new SqlCommand(s, konekcija);
            try
            {
                konekcija.Open();
                komanda.ExecuteNonQuery();
                konekcija.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Greska!");
                return;
            }
            MessageBox.Show("Podaci su ubaceni!");

        }
    }
}
