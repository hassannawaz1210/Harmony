using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS
{
    internal class EditProfileDB
    {
        private SqlConnection connection;
        public EditProfileDB()
        {
            connection = Database.get_instance().get_connection();
        }

        public void update_profile(IUser old_student, IUser new_student)
        {
            try
            {
                Student old_stu = (Student)old_student;
                Student new_stu = (Student)new_student;
                string query1 = "UPDATE [user] SET username = @new_username, password = @password WHERE username = @old_username";
                SqlCommand command1 = new SqlCommand(query1, connection);
                command1.Parameters.AddWithValue("@old_username", old_stu.get_username());
                command1.Parameters.AddWithValue("@new_username", new_stu.get_username());
                command1.Parameters.AddWithValue("@password", new_stu.get_password());
                command1.ExecuteNonQuery();

                string query2 = "UPDATE [student] SET name = @name, profile_pic = @profile_pic, cover_pic = @cover_pic, email = @email, phone = @phone, degree = @degree, batch = @batch, rollno = @rollno, bio = @bio WHERE id = @id";
                SqlCommand command2 = new SqlCommand(query2, connection);
                command2.Parameters.AddWithValue("@id", old_stu.get_id());
                command2.Parameters.AddWithValue("@name", new_stu.get_name());
                command2.Parameters.AddWithValue("@email", new_stu.get_email());
                command2.Parameters.AddWithValue("@phone", new_stu.get_phone());
                command2.Parameters.AddWithValue("@degree", new_stu.get_degree());
                command2.Parameters.AddWithValue("@batch", new_stu.get_batch());
                command2.Parameters.AddWithValue("@rollno", new_stu.get_roll_no());
                command2.Parameters.AddWithValue("@bio", new_stu.get_bio());
                if(new_stu.get_profile_pic() != null)
                { command2.Parameters.AddWithValue("@profile_pic", new_stu.get_profile_pic()); }
                else
                { command2.Parameters.AddWithValue("@profile_pic", DBNull.Value); }
                if (new_stu.get_cover_pic() != null && new_stu.get_cover_pic() != "")
                { command2.Parameters.AddWithValue("@cover_pic", new_stu.get_cover_pic()); }
                else
                { command2.Parameters.AddWithValue("@cover_pic", DBNull.Value); }
                command2.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // Handle the exception
                MessageBox.Show("An error occurred while update student's profile: " + ex.Message);
            }
        }
    }
}
