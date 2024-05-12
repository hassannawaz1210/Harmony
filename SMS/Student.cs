using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS
{
    internal class Student : User, IUser
    {
        private string id;
        private string name;
        private string roll_no;
        private string email;
        private string phone;
        private string batch;
        private string bio;
        private string degree;
        private string profile_pic;
        private string cover_pic;

        public Student() { }

        public Student(string username, string password, string user_type) : base(username, password, user_type)
        {
            fetch_data();
        }

        public void fetch_data()
        {
            SqlConnection connection = Database.get_instance().get_connection();
            SqlCommand command = new SqlCommand("SELECT * FROM student WHERE userid = (SELECT id FROM [user] WHERE username = @username)", connection);
            command.Parameters.AddWithValue("@username", get_username());
            SqlDataReader reader;
            try { reader = command.ExecuteReader(); }
            catch (SqlException ex)
            {
                Console.WriteLine("An error occurred while fetching student data: " + ex.Message);
                return;
            }
            if (reader.HasRows)
            {
                reader.Read();
                id = reader["id"].ToString();
                name = reader["name"].ToString();
                roll_no = reader["rollno"].ToString();
                email = reader["email"].ToString();
                phone = reader["phone"].ToString();
                batch = reader["batch"].ToString();
                bio = reader["bio"].ToString();
                degree = reader["degree"].ToString();
                profile_pic = reader["profile_pic"].ToString();
                cover_pic = reader["cover_pic"].ToString();

                reader.Close();
            }
        }

        public void display()
        {
            Console.WriteLine("ID: " + id);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Roll No: " + roll_no);
            Console.WriteLine("Email: " + email);
            Console.WriteLine("Phone: " + phone);
            Console.WriteLine("Batch: " + batch);
            Console.WriteLine("Bio: " + bio);
            Console.WriteLine("Degree: " + degree);
            Console.WriteLine("Profile Pic: " + profile_pic);
            Console.WriteLine("Cover Pic: " + cover_pic);
        }

        public string get_id()
        {
            return id;
        }
        public string get_name()
        {
            return name;
        }
        public string get_roll_no()
        {
            return roll_no;
        }
        public string get_email()
        {
            return email;
        }
        public string get_phone()
        {
            return phone;
        }
        public string get_batch()
        {
            return batch;
        }
        public string get_bio()
        {
            return bio;
        }
        public string get_degree()
        {
            return degree;
        }
        public string get_profile_pic()
        {
            return profile_pic;
        }
        public string get_cover_pic()
        {
            return cover_pic;
        }

        public void set_name(string name)
        {
            this.name = name;
        }
        public void set_roll_no(string roll_no)
        {
            this.roll_no = roll_no;
        }
        public void set_email(string email)
        {
            this.email = email;
        }
        public void set_phone(string phone)
        {
            this.phone = phone;
        }
        public void set_batch(string batch)
        {
            this.batch = batch;
        }
        public void set_bio(string bio)
        {
            this.bio = bio;
        }
        public void set_degree(string degree)
        {
            this.degree = degree;
        }
        public void set_profile_pic(string profile_pic)
        {
            this.profile_pic = profile_pic;
        }
        public void set_cover_pic(string cover_pic)
        {
            this.cover_pic = cover_pic;
        }

    }
}
