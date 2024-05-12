using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMS
{
    internal partial class event_popup : Form
    {
        private Event eve;
        private IUser user;
        private EventPopupDB eventPopupDB;
        public event_popup(Event eve, IUser user)
        {
            InitializeComponent();
            this.eve = eve;
            this.user = user;
            eventPopupDB = new EventPopupDB();

            Student student = (Student)user;
            int student_id = Convert.ToInt32(student.get_id());

            if (eventPopupDB.is_participating(eve.Id, student_id))
            {
                participate_button.Text = "Unregister";
            }
            else
            {
                participate_button.Text = "Participate";
            }
        }

        private void close_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void event_popup_Load(object sender, EventArgs e)
        {
            name_label.Text = eve.Name;
            desc_label.Text = eve.Description;
            date_label.Text = eve.Date;
            time_label.Text = eve.Time;
            venue_label.Text = eve.Venue;
            sponsors_label.Text = eve.Sponsors;
            fee_label.Text = eve.Fee;
            logo.BackgroundImage  = Image.FromFile(eve.Logo);
            society_label.Text = eventPopupDB.get_soc_name(eve.Soc_id);
        }

        private void participate_button_Click(object sender, EventArgs e)
        {

            Student student = (Student)user;
            int student_id = Convert.ToInt32(student.get_id());
            
            if (participate_button.Text == "Participate")
            {
                if (eventPopupDB.add_participant(eve.Id, student_id))
                {
                    MessageBox.Show("You have successfully registered for the event");
                    participate_button.Text = "Unregister";
                }
            }
            else if (participate_button.Text == "Unregister")
            {
                if(eventPopupDB.remove_participant(eve.Id, student_id))
                {
                    MessageBox.Show("You have successfully unregistered for the event");
                    participate_button.Text = "Participate";
                }
            }
        }
    }
}
