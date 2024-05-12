using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS
{
    internal class CreateEventDB
    {
        SqlConnection conn;
        public CreateEventDB()
        {
            conn = Database.get_instance().get_connection();
        }

        public void create_event(Event e)
        {
            try
            {
                string query = "INSERT INTO events (name, description, date, time, venue, logo, sponsors, reg_fee, soc_id) VALUES (@name, @description, @date, @time, @venue, @logo, @sponsors, @fee, @soc_id)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@name", e.Name);
                cmd.Parameters.AddWithValue("@description", e.Description);
                cmd.Parameters.AddWithValue("@date", e.Date);
                cmd.Parameters.AddWithValue("@time", e.Time);
                cmd.Parameters.AddWithValue("@venue", e.Venue);
                cmd.Parameters.AddWithValue("@logo", e.Logo);
                cmd.Parameters.AddWithValue("@sponsors", e.Sponsors);
                cmd.Parameters.AddWithValue("@fee", e.Fee);
                cmd.Parameters.AddWithValue("@soc_id", e.Soc_id);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
