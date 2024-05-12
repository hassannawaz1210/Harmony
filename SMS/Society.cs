using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS
{
    public class Society
    {
        private int id;
        private string name;
        private string email;
        private string phone;
        private string faculty;
        private string mission;
        private string web;
        private string desc;
        private string type;
        private string founding_date;
        private int number_of_members;
        private string president_id;
        private string logo;

        public Society(int id, string name, string email, string phone, string faculty, string mission, string web, string desc, string type, string founding_date, int number_of_members, string president_id, string logo)
        {
            this.id = id;
            this.name = name;
            this.email = email;
            this.phone = phone;
            this.faculty = faculty;
            this.mission = mission;
            this.web = web;
            this.desc = desc;
            this.type = type;
            this.founding_date = founding_date;
            this.number_of_members = number_of_members;
            this.president_id = president_id;
            this.logo = logo;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        public string Faculty
        {
            get { return faculty; }
            set { faculty = value; }
        }

        public string Mission
        {
            get { return mission; }
            set { mission = value; }
        }

        public string Web
        {
            get { return web; }
            set { web = value; }
        }

        public string Desc
        {
            get { return desc; }
            set { desc = value; }
        }

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public string FoundingDate
        {
            get { return founding_date; }
            set { founding_date = value; }
        }

        public int NumberOfMembers
        {
            get { return number_of_members; }
            set { number_of_members = value; }
        }

        public string PresidentId
        {
            get { return president_id; }
            set { president_id = value; }
        }

        public string Logo
        {
            get { return logo; }
            set { logo = value; }
        }
    }
}
