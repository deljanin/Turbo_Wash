using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Data.SqlClient;


namespace EP_Programirnaje_projekat___program
{
    public partial class Form_Registracija : Form
    {
        public Form_Registracija()
        {
            InitializeComponent();
        }
        


        private void button_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public bool IsEmailValid(string emailaddress)
        {
            try
            {
                MailAddress m = new MailAddress(emailaddress);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
        
        private void button_potvrdi_Click(object sender, EventArgs e)
        {
            //skupi sve sa forme ako je sve puno i salje u bazu, posle na log in formi ona iz baze cita     
            
            string errors = "";            
            
            if (textBox_Username.TextLength > 30)
            {
                errors = "Korisničko ime je predugačko! ";                
                textBox_Username.Focus();
                MessageBox.Show(errors.ToString());
            }
            else if (textBox_Username.Text == "")
            {
                errors = "Polje za korisničko ime mora biti popunjeno!";                
                textBox_Username.Focus();
                MessageBox.Show(errors.ToString());
            }
            else if (textBox_Email.Text == "")
            {
                errors += "\nPolje za Email adresu mora biti popunjeno";                
                textBox_Email.Focus();
                MessageBox.Show(errors.ToString());
            }
            else if (IsEmailValid(textBox_Email.Text) == false)
            {
                errors += "\nEmail adresa nije validna!";                
                textBox_Email.Focus();
                MessageBox.Show(errors.ToString());
            }            
            else if(textBox_Pass1.Text != textBox_Pass2.Text)
            {
                errors += "\nLozinke se ne podudaraju!";                
                textBox_Pass1.Focus();
                MessageBox.Show(errors.ToString());
            }
            else if(textBox_Pass1.TextLength > 30 || textBox_Pass2.TextLength > 30)
            {
                errors += "Lozinka je predugačka!";                
                textBox_Pass1.Focus();
                MessageBox.Show(errors.ToString());
            }
            else if(textBox_Pass1.Text == "" || textBox_Pass2.Text == "")
            {
                errors += "\nPolja za lozinku moraju biti popunjena!";                
                textBox_Pass1.Focus();
                MessageBox.Show(errors.ToString());
            }
            
            else
            {   
                string user = textBox_Username.Text;
                string emajil = textBox_Email.Text;
                string pass = textBox_Pass1.Text;

                try
                {
                    string Insert = $"INSERT INTO korisnici(korisnicko_ime, email, lozinka) VALUES('{user}', '{emajil}', '{pass}');";
                    string checkuser = $"SELECT * FROM korisnici WHERE korisnicko_ime = '{user}'";
                    string checkemail = $"SELECT * FROM korisnici WHERE email = '{emajil}'";

                    SqlConnection kon = new SqlConnection(DatabaseConn.conn);                    
                    SqlCommand proverauser = new SqlCommand(checkuser, kon);
                    SqlCommand proveramail = new SqlCommand(checkemail, kon);
                    SqlCommand insert = new SqlCommand(Insert, kon);
                    SqlDataReader reader;

                    bool cu()
                    {
                        
                        SqlDataReader reader1;
                        kon.Open();
                        reader1 = proverauser.ExecuteReader();
                        if (reader1.Read())
                        {
                            kon.Close();
                            return true;
                        }
                        else {
                            kon.Close();
                            return false;
                        }                    
                    }
                    bool ce()
                    {
                        
                        SqlDataReader reader2;
                        kon.Open();
                        reader2 = proveramail.ExecuteReader();
                        if (reader2.Read())
                        {
                            kon.Close();
                            return true;
                        }
                        else
                        {
                            kon.Close();
                            return false;
                        }
                    }
                    if (cu() == true)
                    {
                        MessageBox.Show("Korisničko ime je zauzeto!", "Registracija", MessageBoxButtons.OK);
                    }                    
                    
                    else if (ce()== true)
                    {
                        MessageBox.Show("Nalog je vec registrovan na ovoj email adresi!", "Registracija", MessageBoxButtons.OK);                        
                    }
                    
                    else
                    {
                        kon.Open();
                        reader = insert.ExecuteReader();     // Here our query will be executed and data saved into the database.  
                        
                        while (reader.Read())
                        {
                        }
                        kon.Close();
                        MailMessage message = new MailMessage();
                        message.To.Add(emajil);
                        message.From = new MailAddress("deljanin741@gmail.com");
                        message.Body = $"Poštovani,\n\n Registrovali ste nalog za našu aplikaciju sa ovim korisničkim imenom: '{user}' i ovom lozinkom '{pass}'.\n Hvala vam što koristite našu aplikaciju\n\nSrdačan pozdrav, \nPetar Deljanin";
                        message.Subject = "Registracija za auto perionicu Turbo Wash";
                        SmtpClient client = new SmtpClient("Smtp.gmail.com", 587);
                        client.EnableSsl = true;
                        client.UseDefaultCredentials = false;
                        client.Credentials = new NetworkCredential("deljanin741@gmail.com", "L0newolf43ver");
                        try
                        {
                            client.Send(message);
                            MessageBox.Show("Uspešno ste se registrovali!", "Registracija", MessageBoxButtons.OK);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }

                        Form_Login formLogin = new Form_Login();
                        this.Close();
                        formLogin.Show();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }            
        }
    }
}
