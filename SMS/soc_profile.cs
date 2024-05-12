using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMS
{
    public partial class soc_profile : Form
    {
        private Society info;
        private IUser user;
        private Panel home_body_panel;
        private Label page_title;
        private SocProfileDB socProfileDB;

        public soc_profile(Label pg_title, Society info, Panel home_body_panel, IUser user)
        {
            InitializeComponent();
            this.info = info;
            this.user = user;
            this.page_title = pg_title;
            this.socProfileDB = new SocProfileDB();
            soc_profile_Load(info);
            this.home_body_panel = home_body_panel;
        }

        private void soc_profile_Load(Society info)
        {

            if (user.get_user_type() == "Admin")
            {
                join_button.Visible = false;
                follow_button.Visible = false;
            }
            else
            {
                Student stu = (Student)user;
                int stu_id = Convert.ToInt32(stu.get_id());
                if (socProfileDB.is_followed(stu_id, info.Id))
                {
                    follow_button.Text = "Unfollow";
                }
                else
                {
                    follow_button.Text = "Follow";
                }

                if(socProfileDB.is_joined(stu_id, info.Id))
                {
                    join_button.Text = "Leave Society";
                }
                else
                {
                    join_button.Text = "Join Society";
                }

                if (stu.get_id() == info.PresidentId || user.get_user_type() == "Admin")
                {
                    //presidents cant leave soc
                    join_button.Visible = false;
                    follow_button.Text = "Delete Society";
                    //4*175
                    tableLayoutPanel2.Width = 5* 200;
                    //
                    tableLayoutPanel2.ColumnCount = 5;
                    //
                    Button applicants_button = new Button();
                    applicants_button.BackColor = Color.FromArgb(240, 84, 84);
                    applicants_button.Dock = DockStyle.Fill;
                    applicants_button.Text = "Applicants";
                    applicants_button.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
                    applicants_button.Click += applicants_button_Click;
                    tableLayoutPanel2.Controls.Add(applicants_button, 2, 0);
                    //
                    Button annoucement_button = new Button();
                    annoucement_button.BackColor = Color.FromArgb(240, 84, 84);
                    annoucement_button.Dock = DockStyle.Fill;
                    annoucement_button.Text = "Make Announcement";
                    annoucement_button.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
                    tableLayoutPanel2.Controls.Add(annoucement_button, 3, 0);
                    annoucement_button.Click += (sender, e) =>
                    {
                        make_ann ann = new make_ann(info, user);
                        ann.TopLevel = false;
                        ann.AutoScroll = true;
                        ann.FormBorderStyle = FormBorderStyle.None;
                        ann.Dock = DockStyle.Fill;
                        switch_window.Controls.Clear();
                        switch_window.Controls.Add(ann);
                        ann.Show();
                    };

                    //
                    Button create_event_button = new Button();
                    create_event_button.BackColor = Color.FromArgb(240, 84, 84);
                    create_event_button.Dock = DockStyle.Fill;
                    create_event_button.Text = "Create Event";
                    create_event_button.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
                    tableLayoutPanel2.Controls.Add(create_event_button, 4, 0);
                    create_event_button.Click += (sender, e) =>
                    {
                        //create event popup
                        create_event createEvent = new create_event(info);
                        createEvent.ShowDialog();
                    };

                    //set columns to 20% each
                    tableLayoutPanel2.ColumnStyles.Clear();
                    tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
                    tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
                    tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
                    tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
                    tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));

                    

                }
            }


            soc_title.Text = info.Name;
            soc_desc.Text = info.Desc;
            //string resourcefolder = System.IO.Path.GetFullPath(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\Resources\"));
            soc_logo.Image = Image.FromFile(info.Logo);
            about_button_Click(null, null);
        }

        private void applicants_button_Click(object sender, EventArgs e)
        {
            join_apps_win join_App_Win = new join_apps_win(info, home_body_panel);
            join_App_Win.TopLevel = false;
            join_App_Win.TopMost = true;
            join_App_Win.AutoScroll = true;
            join_App_Win.FormBorderStyle = FormBorderStyle.None;
            join_App_Win.Dock = DockStyle.Fill;
            home_body_panel.Controls.Clear();
            home_body_panel.Controls.Add(join_App_Win);
            join_App_Win.Show();

            page_title.Text = "Applicants";
        }

        private void about_button_Click(object sender, EventArgs e)
        {
            about about = new about();
            about.update_values(info);
            about.TopLevel = false;
            about.AutoScroll = true;
            about.FormBorderStyle = FormBorderStyle.None;
            about.Dock = DockStyle.Fill;
            switch_window.Controls.Clear();
            switch_window.Controls.Add(about);
            about.Show();
        }
        private void members_button_Click(object sender, EventArgs e)
        {
            members members = new members(info) { TopLevel = false, TopMost = true };
            members.FormBorderStyle = FormBorderStyle.None;
            members.Dock = DockStyle.Fill;
            members.AutoScroll = true;
            switch_window.Controls.Clear();
            switch_window.Controls.Add(members);
            members.Show();
        }

        private void join_button_Click(object sender, EventArgs e)
        {
            if(join_button.Text == "Leave Society")
            {
               //are you sure
               DialogResult dialogResult = MessageBox.Show("Are you sure you want to leave this society?", "Leave Society", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Student stu = (Student)user;
                    int stu_id = Convert.ToInt32(stu.get_id());
                    socProfileDB.leave_society(stu_id, info.Id);
                    join_button.Text = "Join Society";
                }
            }
            else if(join_button.Text == "Join Society")
            {join_apply joinApplyPage = new join_apply(info, user);
            joinApplyPage.TopLevel = false;
            joinApplyPage.AutoScroll = true;
            joinApplyPage.FormBorderStyle = FormBorderStyle.None;
            joinApplyPage.Dock = DockStyle.Fill;
            home_body_panel.Controls.Clear();
            home_body_panel.Controls.Add(joinApplyPage);
                joinApplyPage.Show();
            }
        }

        private void follow_button_Click(object sender, EventArgs e)
        {
            if(follow_button.Text == "Delete Society")
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this society?", "Delete Society", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    socProfileDB.delete_society(info.Id);
                    home_body_panel.Controls.Clear();
                    page_title.Text = "Home";
                    homepage homepage = new homepage() { TopLevel = false, TopMost = true };
                    homepage.FormBorderStyle = FormBorderStyle.None;
                    home_body_panel.Controls.Add(homepage);
                    homepage.Dock = DockStyle.Fill;
                    homepage.Show();
                }
            }
            if(follow_button.Text == "Follow")
            {
                Student stu = (Student)user;
                int stu_id = Convert.ToInt32(stu.get_id());
                socProfileDB.follow_society(stu_id, info.Id);
                follow_button.Text = "Unfollow";
            }
            else
            {
                Student stu = (Student)user;
                int stu_id = Convert.ToInt32(stu.get_id());
                socProfileDB.unfollow_society(stu_id, info.Id);
                follow_button.Text = "Follow";
            }
        }
    }
}
