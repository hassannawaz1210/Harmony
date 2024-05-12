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
    public partial class anns : Form
    {
        IUser user;
        AnnsDB annsDB;
        List<Society> following_socs;
        List<Notification> notifications;
        public anns(IUser user)
        {
            InitializeComponent();
            this.user = user;
            this.annsDB = new AnnsDB();
            tableLayoutPanel1.Visible = false;
        }

        private void on_load(object sender, EventArgs e)
        {
            if (user.get_user_type().Equals("Admin"))
            {
                return;
            }
            Student student = (Student)user;
            int stu_id = Convert.ToInt32(student.get_id());

            following_socs = annsDB.get_following_socs(stu_id);
            if (following_socs.Count > 0)
            {
                notifications = new List<Notification>();
                notifications = annsDB.get_notifications(following_socs);
                if (notifications.Count > 0)
                {
                    no_anns_label.Visible = false;
                    tableLayoutPanel1.Visible = true;
                    tableLayoutPanel1.RowCount = notifications.Count + 1;
                    //set each row height to 110
                    tableLayoutPanel1.Height = 110 * notifications.Count + 30;
                    tableLayoutPanel1.RowStyles.Clear();
                    for (int i = 0; i < notifications.Count; i++)
                    {
                        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 110));
                    }
                }
                foreach (Notification notification in notifications)
                {
                    ann_card card = new ann_card();
                    Society society = following_socs.Find(soc => soc.Id == notification.Soc_id);
                    card.set_data(notification, society);
                    card.Dock = DockStyle.Fill;
                    tableLayoutPanel1.Controls.Add(card);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
