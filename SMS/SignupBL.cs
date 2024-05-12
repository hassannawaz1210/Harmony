using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS
{
    internal class SignupBL
    {
        SqlConnection connection;
        public SignupBL()
        {
            connection = Database.get_instance().get_connection();
        }
        public bool signup(string name, string username, string password, string email, string phone, string rollno, string batch, string degree)
        {
          //check that the username is unique
            SqlCommand command = new SqlCommand("SELECT * FROM [user] WHERE username = @username", connection);
            command.Parameters.AddWithValue("@username", username);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Close();
                MessageBox.Show("Username already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            reader.Close();
            //insert user into database
            command = new SqlCommand("INSERT INTO [user](username, password, usertype) VALUES (@username, @password, 'Student'); SELECT SCOPE_IDENTITY();", connection);
            command.Parameters.AddWithValue("@username", username);
            command.Parameters.AddWithValue("@password", password);
            int userid = 0;
            try
            {
                object result = command.ExecuteScalar();
                if (result != null)
                {
                    userid = Convert.ToInt32(result);
                    Console.WriteLine("Newly inserted ID: " + userid);
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("An error occurred while adding to user table: " + ex.Message);
            }
            //insert rest to student
            command = new SqlCommand("INSERT INTO student(name, email, phone, batch, degree, rollno, userid) VALUES (@name, @email, @phone, @batch, @degree, @rollno, @userid)", connection);
            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue("@email", email);
            command.Parameters.AddWithValue("@phone", phone);
            command.Parameters.AddWithValue("@batch", batch);
            command.Parameters.AddWithValue("@degree", degree);
            command.Parameters.AddWithValue("@rollno", rollno);
            command.Parameters.AddWithValue("@userid", userid);

            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Signup successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Console.WriteLine("Student added to database");

                return true;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("An error occurred while adding data to student table: " + ex.Message);
            }

            return false;
        }
    }
}
