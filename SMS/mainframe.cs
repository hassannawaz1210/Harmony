using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.IO;

namespace SMS
{
    public partial class mainframe : Form
    {
        private IUser user;
        //
        private const UInt32 StdOutputHandle = 0xFFFFFFF5;
        [DllImport("kernel32.dll")]
        private static extern IntPtr GetStdHandle(UInt32 nStdHandle);
        [DllImport("kernel32.dll")]
        private static extern void SetStdHandle(UInt32 nStdHandle, IntPtr handle);
        [DllImport("kernel32")]
        static extern bool AllocConsole();
        public mainframe(IUser user)
        {
            InitializeComponent();
            try
            {
                AllocConsole();
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }

            //----- 
            this.user = user;
            Console.WriteLine("Home");
            role_label.Text = user.get_user_type();
            if (user.get_user_type().Equals("Student"))
            {
                this.user = new Student(user.get_username(), user.get_password(), user.get_user_type());
                Student student = (Student)this.user;
                student.display();
                set_profile(student.get_name(), student.get_profile_pic());
                apply_button.Visible = true;
            }
            else
            {
                //user = new Admin(user.get_username(), user.get_password(), user.get_user_type());
                //apply_button.Visible = false;
                username_label.Text = user.get_username();
            }
            //----- dipslay home page
            home_button_Click(null, null);
        }

        private void set_profile(string username, string profile_pic)
        {
            this.username_label.Text = username;
            this.profile_pic.BackColor = Color.Transparent;

            if (profile_pic != "" && File.Exists(profile_pic))
            {

                this.profile_pic.BackgroundImage = Image.FromFile(profile_pic);
            }
            else
            {
                this.profile_pic.BackgroundImage = Properties.Resources.default_profile;
            }
        }
        private void load_profile()
        {
            //if user is student, take them to student profile page
            if (this.user.get_user_type().Equals("Student"))
            {
                dispose_prev_form();
                page_title.Text = "Profile";
                stu_profile stu_Profile = new stu_profile(ref this.user) { TopLevel = false, TopMost = true };
                stu_Profile.FormBorderStyle = FormBorderStyle.None;
                body_panel.Controls.Add(stu_Profile);
                stu_Profile.Dock = DockStyle.Fill;
                stu_Profile.Show();
            }

        }
        private void profile_picture_Click(object sender, EventArgs e)
        {
            load_profile();
        }

        private void username_label_Click(object sender, EventArgs e)
        {
            load_profile();
        }

        private void dispose_prev_form()
        {
            Form form = body_panel.Controls.OfType<Form>().FirstOrDefault();
            if (form != null)
            {
                form.Close();
            }
        }

        private void home_button_Click(object sender, EventArgs e)
        {
            dispose_prev_form();
            page_title.Text = "Home";
            homepage homepage = new homepage() { TopLevel = false, TopMost = true };
            homepage.FormBorderStyle = FormBorderStyle.None;
            body_panel.Controls.Add(homepage);
            homepage.Dock = DockStyle.Fill;
            homepage.Show();
        }

        private void browse_button_Click(object sender, EventArgs e)
        {
            dispose_prev_form();
            page_title.Text = "Societies";
            browse browse_win = new browse(body_panel, page_title, user) { TopLevel = false, TopMost = true };
            browse_win.FormBorderStyle = FormBorderStyle.None;
            body_panel.Controls.Add(browse_win);
            browse_win.Dock = DockStyle.Fill;
            browse_win.Show();
        }

        private void apply_button_Click(object sender, EventArgs e)
        {
            // set window size
            this.Size = new Size(this.Size.Width, 800);
            //disable search
            search_box.Enabled = false;
            //
            if (this.user.get_user_type().Equals("Student"))
            {
                dispose_prev_form();
                page_title.Text = "Application";
                soc_apply application_win = new soc_apply(user) { TopLevel = false, TopMost = true };
                application_win.FormBorderStyle = FormBorderStyle.None;
                body_panel.Controls.Add(application_win);
                application_win.Dock = DockStyle.Fill;
                application_win.Show();
            }
            else if (this.user.get_user_type().Equals("Admin"))
            {
                dispose_prev_form();
                page_title.Text = "Applications";
                applications applications_win = new applications(body_panel) { TopLevel = false, TopMost = true };
                applications_win.FormBorderStyle = FormBorderStyle.None;
                body_panel.Controls.Add(applications_win);
                applications_win.Dock = DockStyle.Fill;
                applications_win.Show();
            }
        }

        private void ann_button_Click(object sender, EventArgs e)
        {
            //load anns page
            dispose_prev_form();
            page_title.Text = "Announcements";
            anns anns_win = new anns(user) { TopLevel = false, TopMost = true };
            anns_win.FormBorderStyle = FormBorderStyle.None;
            body_panel.Controls.Add(anns_win);
            anns_win.Dock = DockStyle.Fill;
            anns_win.Show();
        }

        private void logout_button_Click(object sender, EventArgs e)
        {
            this.Close();
            login login = new login();
            login.Show();
        }

        private void event_button_Click(object sender, EventArgs e)
        {
            page_title.Text = "Events";
            dispose_prev_form();
            events events_win = new events(user, body_panel) { TopLevel = false, TopMost = true };
            events_win.FormBorderStyle = FormBorderStyle.None;
            body_panel.Controls.Add(events_win);
            events_win.Dock = DockStyle.Fill;
            events_win.Show();
        }
    }
}
