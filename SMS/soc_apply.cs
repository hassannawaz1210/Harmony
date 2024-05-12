using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMS
{

    public partial class soc_apply : Form
    {
        [DllImport("kernel32.dll")]
        static extern bool AllocConsole();

        IUser user;
        private string logo_path;
        private soc_applyBL appBL;
        public soc_apply(IUser user)
        {
            InitializeComponent();
            AllocConsole();
            this.user = user;
            appBL = new soc_applyBL();
        }

        private void upload_button_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image Files(*.jpg; *.jpeg; *.png; *.gif; *.bmp)|*.jpg; *.jpeg; *.png; *.gif; *.bmp";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                logo_path = dialog.FileName;

                //gui related
                string[] path = logo_path.Split('\\');
                string file_name = path[path.Length - 1];
                file_label.Text = file_name;
            }
        }   

        private bool fields_not_empty()
        {
            if (name_field.Text == "" || email_field.Text == "" || phone_field.Text == "" || faculty_field.Text == "" || mission_field.Text == "" || web_field.Text == "" || desc_field.Text == "" || type_field.Text == "" || logo_path == "")
            {
                MessageBox.Show("Please fill in all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }   

        private void submit_button_Click(object sender, EventArgs e)
        {
            if(fields_not_empty())
            {
                Student student = (Student)user;
                Console.WriteLine(student.get_id());
                if(appBL.SubmitApplication(name_field.Text, email_field.Text, phone_field.Text, faculty_field.Text, mission_field.Text, web_field.Text, desc_field.Text, type_field.Text, student.get_id(), logo_path))
                { 
                    MessageBox.Show("Application Submitted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //clear fields
                    name_field.Text = "";
                    email_field.Text = "";
                    phone_field.Text = "";
                    faculty_field.Text = "";
                    mission_field.Text = "";
                    web_field.Text = "";
                    desc_field.Text = "";
                    type_field.Text = "";
                    file_label.Text = "Choose a file";
                }
            }
        }
    }
}
