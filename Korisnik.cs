using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace EP_Programirnaje_projekat___program
{
    class Korisnik
    {

        public static string username;
        public static string password;
        /*public string Username { get => this.username; set { this.username = value; } }
        public string Password { get => this.password; set { this.password = value; } }*/

        public string VratiId()
        {
            DatabaseConn kon = new DatabaseConn();
            return kon.Login(username, password); ;
        }
        public string VratiEmail()
        {
            SqlConnection kon = new SqlConnection(DatabaseConn.conn);
            string query = $"SELECT * FROM korisnici WHERE korisnicko_ime = '{username}' and lozinka = '{password}'";
            SqlCommand command = new SqlCommand(query, kon);
            SqlDataReader rider;
            kon.Open();
            rider = command.ExecuteReader();

            if (rider.Read() == true)
            {
                return rider[2].ToString();
            }
            else
            {
                return "";
            }

        }
        /*
        public void Uzmiuser(string user)
        {
            this.username = user;
        }
        public void Uzmipass(string pass)
        {
            this.password = pass;
        }
        
        public string vratiUser()
        {
            MessageBox.Show(this.username);
            return this.username.ToString();
        }
        public string vratiPass()
        {
            MessageBox.Show(this.password);
            return this.password.ToString();
        }*/
    }
}
