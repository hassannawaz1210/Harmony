using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS
{
    internal class EventsDB
    {
        private SqlConnection conn;
        public EventsDB()
        {
            conn = Database.get_instance().get_connection();
        }

        public List<Event> fetch_events()
        {
           List<Event> events = new List<Event>();
            try
            {
                string query = "SELECT * FROM [events]";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Event e = new Event();
                    //using column name syntax
                    int id = Convert.ToInt32(reader["id"].ToString());
                    e.Id = id;
                    e.Name = reader["name"].ToString();
                    e.Description = reader["description"].ToString();
                    e.Date = reader["date"].ToString();
                    e.Time = reader["time"].ToString();
                    e.Venue = reader["venue"].ToString();
                    e.Logo = reader["logo"].ToString();
                    e.Sponsors = reader["sponsors"].ToString();
                    e.Fee = reader["reg_fee"].ToString();
                    e.Soc_id = Convert.ToInt32(reader["soc_id"].ToString());
                    events.Add(e);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return events;
        }
    }
}
