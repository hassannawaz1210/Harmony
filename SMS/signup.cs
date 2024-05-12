using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMS
{
    public partial class signup : Form
    {
        [DllImport("kernel32.dll")]
        static extern bool AllocConsole();
        private SignupBL signupBL;
        public signup()
        {
            InitializeComponent();
            AllocConsole();
            signupBL = new SignupBL();
        }

        private void goto_login_label_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            login login = new login();
            login.Show();
        }

        private bool fields_not_empty()
        {
            if (name_field.Text == "" || user_field.Text == "" || pass_field.Text == "" || email_field.Text == "" || phone_field.Text == "" || rollno_field.Text == "" || batch_field.Text == "" || degree_field.Text == "")
            {
                MessageBox.Show("Please fill in all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private void signup_button_Click(object sender, EventArgs e)
        {
            if (fields_not_empty() && IsValidName(name_field.Text) && IsValidUsername(user_field.Text) && IsValidPassword(pass_field.Text)  && IsValidEmail(email_field.Text) && IsValidPhoneNumber(phone_field.Text) && IsValidRollNumber(rollno_field.Text) && IsValidBatch(batch_field.Text) && IsValidDegree(degree_field.Text))
            {
                if (signupBL.signup(name_field.Text, user_field.Text, pass_field.Text, email_field.Text, phone_field.Text, rollno_field.Text, batch_field.Text, degree_field.Text))
                {
                    //go to home
                    this.Hide();
                    User user = new User(user_field.Text, pass_field.Text, "Student");
                    mainframe home = new mainframe(user);
                    home.Show();
                    //clear fields
                    name_field.Text = "";
                    user_field.Text = "";
                    pass_field.Text = "";
                    email_field.Text = "";
                    phone_field.Text = "";
                    rollno_field.Text = "";
                    batch_field.Text = "";
                    degree_field.Text = "";
                }
            }

        }

        private  bool IsValidUsername(string username)
        {
            string pattern = @"^(?=[a-zA-Z0-9]{8,20}$)[a-zA-Z]+[0-9]*$";
            Regex regex = new Regex(pattern);
            bool result = regex.IsMatch(username);
            if (!result)
            {
                MessageBox.Show("Username must be 8-20 characters long and can only contain alphabets and numbers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;
        }

        private bool IsValidPassword(string password)
        {
            string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{7,}$";
            Regex regex = new Regex(pattern);
            bool result = regex.IsMatch(password);
            if (!result)
            {
                MessageBox.Show("Password must be at least 7 characters long and must contain at least one uppercase letter, one lowercase letter, one digit and one special character", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;
        }
        public  bool IsValidName(string name)
        {
            string pattern = @"^[a-zA-Z ]+$";
            Regex regex = new Regex(pattern);
            bool result = regex.IsMatch(name);
            if (!result)
            {
                MessageBox.Show("Name can only contain alphabets and spaces", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;
        }

        public  bool IsValidEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            Regex regex = new Regex(pattern);
            bool result = regex.IsMatch(email);
            if (!result)
            {
                MessageBox.Show("Invalid email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;
        }

        public  bool IsValidPhoneNumber(string phoneNumber)
        {
            string pattern = @"^((\+92)|(0092)|0)?3[0-9]{2}[0-9]{7}$";
            Regex regex = new Regex(pattern);
            bool result = regex.IsMatch(phoneNumber);
            if (!result)
            {
                MessageBox.Show("Invalid phone number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;
        }

        public  bool IsValidRollNumber(string rollNumber)
        {
            string pattern = @"^\d{4}$";
            Regex regex = new Regex(pattern);
            bool result = regex.IsMatch(rollNumber);
            if (!result)
            {
                MessageBox.Show("Invalid roll number, use digits.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;
        }

        public bool IsValidBatch(string batch)
        {
            string[] batches = new string[] { "2020", "2021", "2022", "2023" };
           foreach(string b in batches)
            {
                if (b == batch)
                {
                    return true;
                }
            }
           MessageBox.Show("Invalid batch", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
           return false;
        }

        public bool IsValidDegree(string degree)
        {
            string[] degrees = new string[] { "CS", "BA", "AI", "CY"};
            foreach (string d in degrees)
            {
                if (d == degree)
                {
                    return true;
                }
            }
            MessageBox.Show("Invalid degree", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
    }
}
