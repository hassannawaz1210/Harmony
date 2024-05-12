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
    public partial class stu_profile : Form
    {
        IUser user;
        public stu_profile(ref IUser user)
        {
            InitializeComponent();
            this.user = user;

            //
            profile_pic.Parent = this;
            cover_pic.Parent = this;
            cover_pic.SendToBack();
            profile_pic.BringToFront();
            on_load(user);

        }

        //create a refresh callback function of stu_profile that will be passed to edit_profile

        private void on_load(IUser user) { 
            //set all labels
            Student stu = (Student)user;
            name_label.Text = stu.get_name();
            email_label.Text = stu.get_email();
            phone_label.Text = stu.get_phone();
            degree_label.Text = stu.get_degree();
            batch_label.Text = stu.get_batch();
            roll_label.Text = stu.get_roll_no();
            bio_label.Text = stu.get_bio() == "" ? "No bio" : stu.get_bio();
            if(stu.get_profile_pic() != "" && stu.get_profile_pic() != null  && System.IO.File.Exists(stu.get_profile_pic()))
            {
                profile_pic.BackgroundImage = Image.FromFile(stu.get_profile_pic());
            }
            else
            {
                profile_pic.BackgroundImage = Properties.Resources.default_profile;
            }
            //cover_pic.ImageLocation = stu.get_cover_pic();
        }

        private void edit_button_Click(object sender, EventArgs e)
        {
            edit_profile edit_Profile = new edit_profile(ref this.user, on_load);
            edit_Profile.StartPosition = FormStartPosition.CenterScreen;
            edit_Profile.ShowDialog();
        }

        
    }
}
