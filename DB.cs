using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace EP_Programirnaje_projekat___program
{
    class DB
    {
        // the connection
        private MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=;password=root;database=autoperionica");


        // create a function to open the connection
        public void openConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        // create a function to close the connection
        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

        // create a function to return the connection
        public MySqlConnection getConnection()
        {
            return connection;
        }
    }
}
