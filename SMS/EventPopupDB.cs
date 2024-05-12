using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS
{
    public class EventPopupDB
    {
        SqlConnection conn;
        public EventPopupDB()
        {
            conn = Database.get_instance().get_connection();
        }

        public string get_soc_name(int soc_id)
        {
            try
            {
                string query = "SELECT name FROM society WHERE id = @soc_id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@soc_id", soc_id);
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                string name = reader["name"].ToString();
                reader.Close();
                return name;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return "";
            }
        }

        public bool add_participant(int event_id, int student_id)
        {
            try
            {
                string query = "INSERT INTO participants (eve_id, stu_id) VALUES (@event_id, @student_id)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@event_id", event_id);
                cmd.Parameters.AddWithValue("@student_id", student_id);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public bool remove_participant(int event_id, int student_id)
        {
            try
            {
                string query = "DELETE FROM participants WHERE eve_id = @event_id AND stu_id = @student_id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@event_id", event_id);
                cmd.Parameters.AddWithValue("@student_id", student_id);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public bool is_participating(int event_id, int student_id)
        {
            try
            {
                string query = "SELECT * FROM participants WHERE eve_id = @event_id AND stu_id = @student_id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@event_id", event_id);
                cmd.Parameters.AddWithValue("@student_id", student_id);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    reader.Close();
                    return true;
                }
                reader.Close();
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
    }
    
}
