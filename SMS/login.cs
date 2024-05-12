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

    public partial class login : Form
    {
        LoginBL loginBL;
        public login()
        {
            InitializeComponent();
            loginBL = new LoginBL();
            user_field.Text = "hassan";
            pass_field.Text = "1234";
            user_type.Text = "Student";
        }

        private void show_pass_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (show_pass_checkbox.Checked)
            {
                pass_field.UseSystemPasswordChar = false;
            }
            else
            {
                pass_field.UseSystemPasswordChar = true;
            }
        }

        private void goto_signup_label_LinkClicked (object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            signup signup = new signup();
            signup.Show();
        }

        private bool fields_not_empty()
        {
            if (user_field.Text == "" || pass_field.Text == "" || user_type.Text == "")
            {
                MessageBox.Show("Please fill in all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private void login_button_Click(object sender, EventArgs e)
        {
            if(fields_not_empty() && isValidUser(user_type.Text))
            {
                if(loginBL.login(user_field.Text, pass_field.Text, user_type.Text))
                {
                    //go to home
                    this.Hide();
                    IUser user = new User(user_field.Text, pass_field.Text, user_type.Text);
                    mainframe home = new mainframe(user);
                    home.Show();
                    //clear fields
                    user_field.Text = "";
                    pass_field.Text = "";
                }
            }   
        }

        private bool isValidUser(string user_type)
        {
            if (user_type == "Student" || user_type == "Admin")
            {
                return true;
            }
            MessageBox.Show("Invalid user type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
        
    }
}
