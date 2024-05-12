using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;

namespace SMS
{
    internal class LoginBL
    {
        private SqlConnection connection;

        public bool login(string username, string password, string usertype)
        {
            connection = Database.get_instance().get_connection();
            SqlCommand command = new SqlCommand("SELECT * FROM [user] WHERE username = @username AND password = @password AND usertype = @usertype", connection);
            command.Parameters.AddWithValue("@username", username);
            command.Parameters.AddWithValue("@password", password);
            command.Parameters.AddWithValue("@usertype", usertype);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Close();
                Console.WriteLine("Login successful");
                return true;
            }
            else
            {
                reader.Close();
                Console.WriteLine("Login failed");
                MessageBox.Show("Login failed\nIncorrect password or username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

    }
}
