using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS
{
    public class JoinAppCont
    {
        private string name;
        private string email;
        private string phone;
        private string roll;
        private string why_join;
        private string why_hire;
        private string status;
        private int soc_id;
        private int stu_id;
        private int id;

        public int Soc_id
        {
            get { return soc_id; }
            set { soc_id = value; }
        }
        public int Stu_id
        {
            get { return stu_id; }
            set { stu_id = value; }
        }

        public string Status
        {
            get { return status; }
            set { status = value; }
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
        public string Roll
        {
            get { return roll; }
            set { roll = value; }
        }
        public string Why_join
        {
            get { return why_join; }
            set { why_join = value; }
        }
        public string Why_hire
        {
            get { return why_hire; }
            set { why_hire = value; }
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

    }
}
