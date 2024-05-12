using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS
{
    internal class membersDB
    {
        private SqlConnection conn;

        public membersDB()
        {
            conn = Database.get_instance().get_connection();   
        }

        public void get_members(Society soc, List<string> members, List<string> roles)
        {
            try
            {
                string query = "SELECT student.name, members.role FROM members INNER JOIN student ON members.stu_id = student.id WHERE soc_id = @societyId";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@societyId", soc.Id);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    members.Add(reader.GetString(0));
                    roles.Add(reader.GetString(1));
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while fetching society members: " + ex.Message);
            }
        }
    }
}
