using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS
{
    internal class AppDetailsBL
    {
        private SqlConnection conn;
        public AppDetailsBL()
        {
            conn = Database.get_instance().get_connection();
        }
        public void accept(Society soc)
        {
            SqlCommand command = new SqlCommand("UPDATE [society] SET status = 'Approved' WHERE id = @id", conn);
            command.Parameters.AddWithValue("@id", soc.Id);
            try
            {
                command.ExecuteNonQuery();

                //adding the president to the "following" table
                command = new SqlCommand("INSERT INTO [following] (stu_id, soc_id) VALUES (@stu_id, @soc_id)", conn);
                command.Parameters.AddWithValue("@stu_id", soc.PresidentId);
                command.Parameters.AddWithValue("@soc_id", soc.Id);
                command.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("An error occurred while accepting application: " + ex.Message);
            }
        }

        public void reject(Society soc)
        {
            SqlCommand command = new SqlCommand("UPDATE [society] SET status = 'Rejected' WHERE id = @id", conn);
            command.Parameters.AddWithValue("@id", soc.Id);
            try
            {
                command.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("An error occurred while rejecting application: " + ex.Message);
            }
        }
    }
}
