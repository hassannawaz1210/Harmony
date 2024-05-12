using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS
{
    internal class applicationsBL
    {
        SqlConnection connection;
        public applicationsBL()
        {
            connection = Database.get_instance().get_connection();
        }
        public List<Society> fetch_societies()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM [society] where status = 'Pending'", connection);
            SqlDataReader reader = null;
            try
            {
                reader = command.ExecuteReader();
                List<Society> societies = new List<Society>();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int id = Convert.ToInt32(reader["id"]);
                        string name = reader["name"].ToString();
                        string email = reader["email"].ToString();
                        string phone = reader["phone"].ToString();
                        string faculty = reader["faculty_advisor"].ToString();
                        string mission = reader["mission"].ToString();
                        string web = reader["website"].ToString();
                        string desc = reader["description"].ToString();
                        string type = reader["type"].ToString();
                        string founding_date = reader["founding_date"].ToString();
                        int number_of_members = Convert.ToInt32(reader["num_of_members"]);
                        string president_id = reader["president_id"].ToString();
                        string logo = reader["logo"].ToString();
                        Society society = new Society(id, name, email, phone, faculty, mission, web, desc, type, founding_date, number_of_members, president_id, logo);
                        societies.Add(society);
                    }
                    Console.WriteLine("ApplicationsDB: Societies data fetched succesfully");
                }
                return societies;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("An error occurred while fetching societies: " + ex.Message);
                //return empty 
                return new List<Society>();
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
            }
        }
    }
}
