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
    internal partial class ann_card : UserControl
    {
        private Notification ann;
        public ann_card()
        {
            InitializeComponent();

            //add event listener to the whole card
            this.MouseClick += new MouseEventHandler(on_mouse_click);
            foreach (Control control in this.Controls)
            {
                control.MouseClick += new MouseEventHandler(on_mouse_click);
            }
        }

        public void set_data(Notification notification, Society society)
        {
            ann = notification;
            //
            profile_pic.BackgroundImage = Image.FromFile(society.Logo);
            notification_label.Text = "An announcement was made in " + society.Name + " regarding " + notification.Subject + ".";
            time_label.Text = notification.Time;
            date_label.Text = notification.Date;
        }

        public void on_mouse_click(object sender, MouseEventArgs e)
        {
            //open the announcement pop up
            ann_popup popup = new ann_popup(ann.Date, ann.Time, ann.Subject, ann.Message);
            popup.ShowDialog();

        }
      
    }
}
