using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS
{
    internal class JoinAppDB
    {
        private SqlConnection conn;

        public JoinAppDB()
        {
            conn = Database.get_instance().get_connection();
        }

        public void Accept(int app_id, int stu_id, int soc_id)
        {
            try
            {
                string query = "insert into members (stu_id, soc_id, role) values (@stu_id, @soc_id, 'Rookie')";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@stu_id", stu_id);
                cmd.Parameters.AddWithValue("@soc_id", soc_id);
                cmd.ExecuteNonQuery();
                Reject(app_id);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while accepting application: " + ex.Message);
            }
        }

        public void Reject(int app_id)
        {
            try
            {
                string query = "delete from applicants where id = @app_id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@app_id", app_id);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while rejecting application: " + ex.Message);
            }
        }
    }
}
