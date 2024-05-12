using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS
{
    internal class MakeAnnDB
    {
        SqlConnection conn;
        public MakeAnnDB()
        {
            conn = Database.get_instance().get_connection();
        }
        public void MakeAnnouncement(string subject, string message, int stu_id, int soc_id)
        {
           try
            {
                string date = DateTime.Now.ToString("yyyy-MM-dd");
                string time = DateTime.Now.ToString("hh:mm tt");
                SqlCommand cmd = new SqlCommand("INSERT INTO announcements (subject, message, ann_date, ann_time, stu_id, soc_id) VALUES (@subject, @message, @date, @time, @stu_name, @soc_id)", conn);
                cmd.Parameters.AddWithValue("@subject", subject);
                cmd.Parameters.AddWithValue("@message", message);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@time", time);
                cmd.Parameters.AddWithValue("@stu_name", stu_id);
                cmd.Parameters.AddWithValue("@soc_id", soc_id);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
