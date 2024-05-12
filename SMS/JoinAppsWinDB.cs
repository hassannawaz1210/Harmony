using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS
{
    internal class JoinAppsWinDB
    {
        private SqlConnection conn;
        public JoinAppsWinDB()
        {
            conn = Database.get_instance().get_connection();
        }

        public List<JoinAppCont> get_applications(int soc_id)
        {
            try
            {
                List<JoinAppCont> joinApps = new List<JoinAppCont>();
                string query = "SELECT * from applicants where soc_id = @societyId";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@societyId", soc_id);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    //
                    JoinAppCont joinAppCont = new JoinAppCont();
                    joinAppCont.Name = reader["name"].ToString();
                    joinAppCont.Email = reader["email"].ToString();
                    joinAppCont.Phone = reader["phone"].ToString();
                    joinAppCont.Roll = reader["roll_number"].ToString();
                    joinAppCont.Why_join = reader["why_join"].ToString();
                    joinAppCont.Why_hire = reader["why_hire"].ToString();
                    joinAppCont.Status = reader["status"].ToString();
                    joinAppCont.Soc_id = Convert.ToInt32(reader["soc_id"]);
                    joinAppCont.Stu_id = Convert.ToInt32(reader["stu_id"]);
                    joinAppCont.Id = Convert.ToInt32(reader["id"]);
                    //
                    joinApps.Add(joinAppCont);

                }
                reader.Close();
                return joinApps;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while fetching society applications: " + ex.Message);
            }
            return new List<JoinAppCont>();
        }
    }
}
