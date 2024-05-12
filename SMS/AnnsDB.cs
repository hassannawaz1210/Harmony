using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS
{
    internal class AnnsDB
    {
        SqlConnection conn;
        public AnnsDB()
        {
            conn = Database.get_instance().get_connection();
        }

        public List<Society> get_following_socs(int stu_id)
        {
            string query = "SELECT * FROM Following WHERE stu_id = @stu_id";
            SqlCommand cmd = new SqlCommand(query, conn);
            try
            {
                List< Society > following_socs = new List<Society>();
                List <int> following_socs_ids = new List<int>();
                cmd.Parameters.AddWithValue("@stu_id", stu_id);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    following_socs_ids.Add(Convert.ToInt32(reader["soc_id"]));
                }
                reader.Close();

                foreach (int soc_id in following_socs_ids)
                {
                    query = "SELECT * FROM Society WHERE Id = @soc_id";
                    cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@soc_id", soc_id);
                    reader = cmd.ExecuteReader();
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

                        following_socs.Add(society);
                    }
                    reader.Close();
                }
                return following_socs;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return new List<Society>();
            }
            
        }

        public List<Notification> get_notifications(List<Society> following_socs)
        {
            try
            {
                List<Notification> notifications = new List<Notification>();
                foreach (Society society in following_socs)
                {
                    string query = "SELECT * FROM announcements WHERE soc_id = @soc_id";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@soc_id", society.Id);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Notification notification = new Notification();
                        notification.Subject = reader["subject"].ToString();
                        notification.Message = reader["message"].ToString();
                        notification.Date = reader["ann_date"].ToString();
                        notification.Time = reader["ann_time"].ToString();
                        notification.Soc_id = Convert.ToInt32(reader["soc_id"]);
                        notification.Stu_id = Convert.ToInt32(reader["stu_id"]);

                        notifications.Add(notification);
                    }
                    reader.Close();
                }
                return notifications;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return new List<Notification>();
            }
        }

    }
}
