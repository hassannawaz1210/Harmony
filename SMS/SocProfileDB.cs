using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS
{
    internal class SocProfileDB
    {
        private SqlConnection conn;
        public SocProfileDB()
        {
            conn = Database.get_instance().get_connection();
        }
        public bool is_followed(int student_id, int society_id)
        {
            string query = "SELECT * FROM following WHERE stu_id = @student_id AND soc_id = @society_id";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@student_id", student_id);
            cmd.Parameters.AddWithValue("@society_id", society_id);
            SqlDataReader reader = cmd.ExecuteReader();
            bool is_followed = reader.HasRows;
            reader.Close();
            return is_followed;
        }
        
        public void follow_society(int student_id, int society_id)
        {
            string query = "INSERT INTO following (stu_id, soc_id) VALUES (@student_id, @society_id)";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@student_id", student_id);
            cmd.Parameters.AddWithValue("@society_id", society_id);
            cmd.ExecuteNonQuery();
        }

        public void unfollow_society(int student_id, int society_id)
        {
            string query = "DELETE FROM following WHERE stu_id = @student_id AND soc_id = @society_id";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@student_id", student_id);
            cmd.Parameters.AddWithValue("@society_id", society_id);
            cmd.ExecuteNonQuery();
        }

        public bool is_joined(int student_id, int society_id)
        {
            string query = "SELECT * FROM members WHERE stu_id = @student_id AND soc_id = @society_id";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@student_id", student_id);
            cmd.Parameters.AddWithValue("@society_id", society_id);
            SqlDataReader reader = cmd.ExecuteReader();
            bool is_joined = reader.HasRows;
            reader.Close();
            return is_joined;
        }

        public void leave_society(int student_id, int society_id)
        {
            string query = "DELETE FROM members WHERE stu_id = @student_id AND soc_id = @society_id";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@student_id", student_id);
            cmd.Parameters.AddWithValue("@society_id", society_id);
            cmd.ExecuteNonQuery();
        }

        public void delete_society(int society_id)
        {
            string query = "DELETE FROM society WHERE id = @society_id";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@society_id", society_id);
            cmd.ExecuteNonQuery();
        }
    }
}
