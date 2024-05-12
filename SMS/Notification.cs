using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS
{
    internal class Notification
    {
        private string subject;
        private string message;
        private string date;
        private string time;
        private int stu_id;
        private int soc_id;

        public Notification()
        {
        }
        public Notification(string subject, string message, string date, string time, int stu_id, int soc_id)
        {
            this.subject = subject;
            this.message = message;
            this.date = date;
            this.time = time;
            this.stu_id = stu_id;
            this.soc_id = soc_id;
        }

        public string Subject { get => subject; set => subject = value; }
        public string Message { get => message; set => message = value; }
        public string Date { get => date; set => date = value; }
        public string Time { get => time; set => time = value; }
        public int Stu_id { get => stu_id; set => stu_id = value; }
        public int Soc_id { get => soc_id; set => soc_id = value; }
            
    }
}
