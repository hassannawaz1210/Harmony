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
    public partial class events : Form
    {
        private List<Event> eventsList;
        private EventsDB eventsDB;
        private IUser user;
        private Panel home_body_panel;
        public events(IUser user, Panel panel)
        {
            InitializeComponent();
            this.user = user;
            eventsDB = new EventsDB();
            eventsList = new List<Event>();
            flowLayoutPanel1.Visible = false;
        }

        private void on_load(object sender, EventArgs e)
        {
            eventsList = eventsDB.fetch_events();
            if (eventsList.Count > 0)
            {
                no_events_label.Visible = false;
                flowLayoutPanel1.Visible = true;
            }
            foreach (Event eve in eventsList)
            {
                card card = new card();
                card.set_title(eve.Name);
                card.set_img(eve.Logo);
                card.set_mouse_click(card_mouse_Click);

                flowLayoutPanel1.Controls.Add(card);
            }
        }

        private void card_mouse_Click(object sender, MouseEventArgs e)
        {
            Label label = (Label)sender;
            string title = label.Text;
            Event eve = eventsList.Find(e => e.Name == title);
            event_popup popup = new event_popup(eve , user);
            //give popup a shadow

            popup.ShowDialog();
        }
    }
}
