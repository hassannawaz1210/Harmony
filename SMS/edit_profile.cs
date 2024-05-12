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
    public partial class edit_profile : Form
    {
        private EditProfileDB editProfileDB;
        IUser user;
        string profile_pic_path;
        //callback function
        Action<IUser> refreshCallback;
        public edit_profile(ref IUser user, Action<IUser> refreshCallback)
        {
            InitializeComponent();
            this.user = user;
            this.refreshCallback = refreshCallback;
            editProfileDB = new EditProfileDB();
        }

        private void on_load(object sender, EventArgs e)
        {
            Student stu = (Student)user;
            username_field.Text = stu.get_username();
            pass_field.Text = stu.get_password();
            name_field.Text = stu.get_name();
            email_field.Text = stu.get_email();
            phone_field.Text = stu.get_phone();
            dept_field.Text = stu.get_degree();
            batch_field.Text = stu.get_batch();
            roll_field.Text = stu.get_roll_no();
            bio_field.Text = stu.get_bio();
        }
        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool empty_fields()
        {
            if (pass_field.Text == "" || username_field.Text == "" || name_field.Text == "" || email_field.Text == "" || phone_field.Text == "" || dept_field.Text == "" || batch_field.Text == "" || roll_field.Text == "")
            {
                return true;
            }
            return false;
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            string username = username_field.Text;
            string password = pass_field.Text;
            string name = name_field.Text;
            string email = email_field.Text;
            string phone = phone_field.Text;
            string dept = dept_field.Text;
            string batch = batch_field.Text;
            string roll = roll_field.Text;
            string bio = bio_field.Text;
            string degree = dept_field.Text;
            string profile_pic = profile_pic_path;

            if (!empty_fields())
            {
                Student old_stu = (Student)this.user;
                Student new_stu = new Student(username, password, user.get_user_type());
                new_stu.set_username(username);
                new_stu.set_password(password);
                new_stu.set_name(name);
                new_stu.set_email(email);
                new_stu.set_phone(phone);
                new_stu.set_batch(batch);
                new_stu.set_bio(bio);
                new_stu.set_degree(degree);
                new_stu.set_roll_no(roll);
                new_stu.set_degree(dept);
                if(profile_pic_path == null)
                {
                    new_stu.set_profile_pic(old_stu.get_profile_pic());
                }
                else
                {
                    new_stu.set_profile_pic(profile_pic);
                }
                editProfileDB.update_profile(old_stu, new_stu);
                //
                refreshCallback(new_stu);
                MessageBox.Show("Profile updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Please fill all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //editProfileDB.update_profile(user);
        }

        private void upload_button_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Image Files(*.jpg; *.jpeg; *.png; *.bmp)|*.jpg; *.jpeg; *.png; *.bmp";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                profile_pic_path = fileDialog.FileName;
            }

        }

    }
}
