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
    public partial class make_ann : Form
    {
        Society society;
        IUser user;
        MakeAnnDB makeAnnDB;
        public make_ann(Society society, IUser user)
        {
            InitializeComponent();
            this.society = society;
            this.user = user;
            this.makeAnnDB = new MakeAnnDB();
        }
        private void ann_button_Click(object sender, EventArgs e)
        {
            if (subject_field.Text == "" || message_field.Text == "")
            {
                MessageBox.Show("Please fill in all fields!");
                return;
            }
            Student student = (Student)user;
            int stu_id = Convert.ToInt32(student.get_id());
            int soc_id = society.Id;
            string subject = subject_field.Text;
            string message = message_field.Text;
            makeAnnDB.MakeAnnouncement(subject, message, stu_id, soc_id);
            MessageBox.Show("Announcement made successfully!");
            subject_field.Text = "";
            message_field.Text = "";

        }
    }


}
