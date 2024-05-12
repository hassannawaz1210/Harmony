using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS
{
    internal class soc_applyBL
    {
        SqlConnection connection;
        public soc_applyBL()
        {
            connection = Database.get_instance().get_connection();
        }

        public bool SubmitApplication(string name, string email, string phone, string faculty, string mission, string web, string desc, string type, string student_id, string logo)
        {
            try
            {
            //---------- add society to Db----------//
                //make sure name is unique
                SqlCommand command = new SqlCommand("SELECT * FROM [society] WHERE name = @name", connection);
                command.Parameters.AddWithValue("@name", name);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Close();
                    MessageBox.Show("Society by this name already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                reader.Close();

                string founding_date = DateTime.Today.ToString("yyyy-MM-dd");
                string status = "Pending";
                int number_of_members = 1;
                int soc_id = 0;
                //insert society into database
                command = new SqlCommand("INSERT INTO [society](name, email, phone, faculty_advisor, mission, website, description, type, founding_date, num_of_members, president_id, logo, status) VALUES(@name, @email, @phone, @faculty, @mission, @web, @desc, @type, @founding_date, @number_of_members, @student_id, @logo, @status); SELECT SCOPE_IDENTITY();", connection);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@phone", phone);
                command.Parameters.AddWithValue("@faculty", faculty);
                command.Parameters.AddWithValue("@mission", mission);
                command.Parameters.AddWithValue("@web", web);
                command.Parameters.AddWithValue("@desc", desc);
                command.Parameters.AddWithValue("@type", type);
                command.Parameters.AddWithValue("@founding_date", founding_date);
                command.Parameters.AddWithValue("@number_of_members", number_of_members);
                command.Parameters.AddWithValue("@student_id", student_id);
                command.Parameters.AddWithValue("@logo", logo);
                command.Parameters.AddWithValue("@status", status);
                object result = command.ExecuteScalar();
                if (result != null)
                {
                    soc_id = Convert.ToInt32(result);
                }
            //--------------------//
            //----------- Add president to society_members table
                SqlCommand sqlCommand = new SqlCommand("INSERT INTO [members](soc_id, stu_id, role) VALUES(@soc_id, @stu_id, 'President')", connection);
                sqlCommand.Parameters.AddWithValue("@soc_id", soc_id);
                sqlCommand.Parameters.AddWithValue("@stu_id", student_id);
                sqlCommand.ExecuteNonQuery();

            //--------------------//
                return true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("An error occurred while submitting the society application: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
