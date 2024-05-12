using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS
{
    internal class JoinApplyDB
    {
        private SqlConnection conn;
        public JoinApplyDB()
        {
            conn = Database.get_instance().get_connection();
        }

        public void add_to_db(string name, string email, string phone, string roll, string why_join, string why_hire, int soc_id, int stu_id)
        {
            try
            {
                string query = "INSERT INTO applicants (name, email, phone, roll_number, status, why_join, why_hire, soc_id, stu_id) VALUES (@name, @email, @phone, @roll, @status, @why_join, @why_hire, @soc_id, @stu_id)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@phone", phone);
                cmd.Parameters.AddWithValue("@roll", roll);
                cmd.Parameters.AddWithValue("@status", "Pending");
                cmd.Parameters.AddWithValue("@why_join", why_join);
                cmd.Parameters.AddWithValue("@why_hire", why_hire);
                cmd.Parameters.AddWithValue("@soc_id", soc_id);
                cmd.Parameters.AddWithValue("@stu_id", stu_id);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while adding join application to DB: " + ex.Message);
            }

            
        }
    }
}
