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
using System.Net.Mail;
using System.Net;

namespace EP_Programirnaje_projekat___program
{
    public partial class Form_Nov_Termin : Form
    {
        public Form_Nov_Termin()
        {
            InitializeComponent();
            dateTimePicker.MinDate = DateTime.Today.AddDays(1);
            dateTimePicker1.MinDate = DateTime.Parse("8:00:00");            
            dateTimePicker1.MaxDate = DateTime.Parse("22:00:00");
            dateTimePicker1.Value = DateTime.Parse("8:00:00");
            mPrevDate = dateTimePicker1.Value;
            dateTimePicker1.ValueChanged += new EventHandler(dateTimePicker1_ValueChanged);
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_Odustani_Click(object sender, EventArgs e)
        {
            DialogResult rezult = MessageBox.Show("Da li ste sigurni da želite da odustanete?", "Potvrda", MessageBoxButtons.YesNo);
            if(rezult == DialogResult.Yes)
            { 
                Form_Menu formaMeni = new Form_Menu();
                this.Hide();
                formaMeni.Show();
            }
        }

        private void dateTimePicker_DropDown(object sender, EventArgs e)
        {
            dateTimePicker.MinDate = DateTime.Now;
        }        

        private void button_Potvrdi_Click(object sender, EventArgs e)
        {
            //validacija za sva uneta polja pre slanja podataka u bazu
            if (maskedTextBox_Grad.Text == "")
            {
                MessageBox.Show("Grad na tablicama mora biti popunjen!");
                maskedTextBox_Grad.Focus();
            }
            else if (maskedTextBox_Broj.Text == "")
            {
                MessageBox.Show("Broj na tablicama mora biti popunjen!");
                maskedTextBox_Broj.Focus();
            }
            else if (maskedTextBox_Slova.Text == "")
            {
                MessageBox.Show("Slova na tablicama moraju biti popunjena!");
                maskedTextBox_Slova.Focus();
            }
            else
            {                
                string grad = maskedTextBox_Grad.Text.ToUpper();
                string slova = maskedTextBox_Slova.Text.ToUpper();

                string brojtablica = grad + maskedTextBox_Broj.Text + slova;//////////////////////

                string radb;///////////////////////////
                if (radioButton1.Checked) radb = radioButton1.Text;
                else if (radioButton2.Checked) radb = radioButton2.Text;
                else radb = radioButton3.Text;
                DateTime aasea = dateTimePicker.Value;
                var dat = aasea.Date;
                string datum = dat.ToString("dd/MM/yyyy");

                string vreme = dateTimePicker1.Value.TimeOfDay.ToString();///////////////////////
                string vreme_datum = datum +" "+ vreme;

                string majil = new Korisnik().VratiEmail();               
                

                if (radb != radioButton3.Text)
                {
                    SqlConnection kon = new SqlConnection(DatabaseConn.conn);
                    string checkd = $"SELECT * FROM termini WHERE vreme_datum = '{vreme_datum}'";
                    SqlCommand dc = new SqlCommand(checkd, kon);
                    SqlDataReader reader;
                    DataTable table = new DataTable();
                    kon.Open();
                    reader = dc.ExecuteReader();
                    table.Load(reader);
                    if (table.Rows.Count >= 3)
                    {
                        MessageBox.Show("Ovaj termin je već popunjen.", "Registracija termina", MessageBoxButtons.OK);
                        kon.Close();
                    }
                    else
                    {
                        kon.Close();
                        try
                        {

                            string kk = new Korisnik().VratiId();
                            string Query = $"INSERT INTO termini(broj_tab, tip_pranja, vreme_datum, id_korisnik) VALUES('{brojtablica}','{radb}','{vreme_datum}','{kk}');";

                            SqlCommand MyCommand2 = new SqlCommand(Query, kon);
                            SqlDataReader MyReader2;
                            kon.Open();
                            MyReader2 = MyCommand2.ExecuteReader();    // Here our query will be executed and data saved into the database.  
                            while (MyReader2.Read()) { }
                            kon.Close();

                            MailMessage message = new MailMessage();
                            message.To.Add(majil);
                            message.From = new MailAddress("deljanin741@gmail.com");
                            message.Body = $"Poštovani,\n\n Registrovali ste nov termin na našoj aplikaciji u ovo vreme:'{vreme_datum}'\n Hvala vam što koristite našu aplikaciju\n\nSrdačan pozdrav, \nPetar Deljanin";
                            message.Subject = "Registracija termina za pranje kola, Turbo Wash";
                            SmtpClient client = new SmtpClient("Smtp.gmail.com", 587);
                            client.EnableSsl = true;
                            client.UseDefaultCredentials = false;
                            client.Credentials = new NetworkCredential("deljanin741@gmail.com", "L0newolf43ver");
                            try
                            {
                                client.Send(message);
                                MessageBox.Show("Uspešno ste registrovali vaš termin!");
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }

                            Form_Menu m = new Form_Menu();
                            this.Close();
                            m.Show();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
                else
                {
                    string d = dateTimePicker.Value.Date.ToString();//////////////////////
                    DateTime v = dateTimePicker1.Value.AddHours(3);                    
                    
                    string datm = d + v.ToString();


                    SqlConnection kon = new SqlConnection(DatabaseConn.conn);
                    string checks = $"SELECT * FROM termini WHERE vreme_datum = '{vreme_datum}'";
                    string checke = $"SELECT * FROM termini WHERE vreme_datum = '{datm}'";
                    
                    
                    //SqlDataReader reader;
                    bool checkstart()
                    {
                        SqlDataReader reader1;
                        kon.Open();                        
                        SqlCommand dc = new SqlCommand(checks, kon);
                        reader1 = dc.ExecuteReader();

                        if (reader1.Read()) { kon.Close(); return false; }
                        else kon.Close(); return true;
                    }
                    bool checkend()
                    {
                        SqlDataReader reader2;
                        kon.Open();
                        SqlCommand de = new SqlCommand(checke, kon);
                        reader2 = de.ExecuteReader();

                        if (reader2.Read()) { kon.Close(); return false; }
                        else kon.Close(); return true;
                    }

                    if (checkstart() || checkend())
                    {
                        MessageBox.Show("Ovaj termin je već popunjen.", "Registracija termina", MessageBoxButtons.OK);
                        kon.Close();
                    }
                    else
                    {
                        kon.Close();
                        try
                        {

                            string kk = new Korisnik().VratiId();
                            string Query = $"INSERT INTO termini(broj_tab, tip_pranja, vreme_datum, id_korisnik) VALUES('{brojtablica}','{radb}','{vreme_datum}','{kk}');";

                            SqlCommand MyCommand2 = new SqlCommand(Query, kon);
                            SqlDataReader MyReader2;
                            kon.Open();
                            MyReader2 = MyCommand2.ExecuteReader();    // Here our query will be executed and data saved into the database.  
                            while (MyReader2.Read()) { }
                            kon.Close();

                            MailMessage message = new MailMessage();
                            message.To.Add(majil);
                            message.From = new MailAddress("deljanin741@gmail.com");
                            message.Body = $"Poštovani,\n\n Registrovali ste nov termin na našoj aplikaciji u ovo vreme:'{vreme_datum}'\n Hvala vam što koristite našu aplikaciju\n\nSrdačan pozdrav, \nPetar Deljanin";
                            message.Subject = "Registracija termina za pranje kola, Turbo Wash";
                            SmtpClient client = new SmtpClient("Smtp.gmail.com", 587);
                            client.EnableSsl = true;
                            client.UseDefaultCredentials = false;
                            client.Credentials = new NetworkCredential("deljanin741@gmail.com", "L0newolf43ver");
                            try
                            {
                                client.Send(message);
                                MessageBox.Show("Uspešno ste registrovali vaš termin!");
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }

                            Form_Menu m = new Form_Menu();
                            this.Close();
                            m.Show();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
            }
        }
        
        private DateTime mPrevDate;
        private bool mBusy;
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (!mBusy)
            {
                mBusy = true;
                DateTime dt = dateTimePicker1.Value;
                if ((dt.Minute * 60 + dt.Second) % 300 != 0)
                {
                    TimeSpan diff = dt - mPrevDate;
                    if (diff.Ticks < 0) dateTimePicker1.Value = mPrevDate.AddMinutes(-15);
                    else dateTimePicker1.Value = mPrevDate.AddMinutes(15);
                }
                mBusy = false;
            }
            mPrevDate = dateTimePicker1.Value;
        }
    }
    
}
