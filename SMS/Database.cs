using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;

namespace SMS
{
    internal class Database
    { 
        private static Database db;
        private SqlConnection connection;
        private string connectionString = "Data Source=DESKTOP-6RRGQRR\\SQLEXPRESS03;Initial Catalog=sms;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
        private Database()
        {}
        public static Database get_instance()
        {
            if (db == null)
            {
                db = new Database();
            }
            return db;
        }

        public void establish_connection()
        {
            connection = new SqlConnection(connectionString);
            connection.Open();
        }

        //get connection 
        public SqlConnection get_connection()
        {
            return connection;
        }
        
    }
}
