using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS
{
    internal class Event
    {
        private string name;
        private string description;
        private string date;
        private string time;
        private string venue;
        private string logo;
        private string sponsors;
        private string fee;
        private int id;
        private int soc_id;


        public Event()
        {
            this.name = "";
            this.description = "";
            this.date = "";
            this.time = "";
            this.venue = "";
            this.logo = "";
            this.sponsors = "";
            this.fee = "";
            this.id = -1;
            this.soc_id = -1;
        }
        public Event(string name, string description, string date, string time, string venue, string logo, string sponsors, string fee, int soc_id)
        {
            this.name = name;
            this.description = description;
            this.date = date;
            this.time = time;
            this.venue = venue;
            this.logo = logo;
            this.sponsors = sponsors;
            this.fee = fee;
            this.soc_id = soc_id;
        }
        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public string Date { get => date; set => date = value; }
        public string Time { get => time; set => time = value; }
        public string Venue { get => venue; set => venue = value; }
        public string Logo { get => logo; set => logo = value; }
        public string Sponsors { get => sponsors; set => sponsors = value; }
        public string Fee { get => fee; set => fee = value; }
        public int Id { get => id; set => id = value; }
        public int Soc_id { get => soc_id; set => soc_id = value; }



    }
}
