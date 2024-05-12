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
    public partial class join_apply : Form
    {
        private Society soc;
        private IUser user;
        private JoinApplyDB joinApplyDB;
        public join_apply(Society society, IUser user)
        {
            InitializeComponent();
            this.user = user;
            this.soc = society;
            this.joinApplyDB = new JoinApplyDB();
        }

        private void submit_button_Click(object sender, EventArgs e)
        {
            Student stu = (Student)user;
            int stu_id = Convert.ToInt32(stu.get_id());
            joinApplyDB.add_to_db(name_field.Text, email_field.Text, phone_field.Text, roll_field.Text, why_join_field.Text, why_hire_field.Text, soc.Id, stu_id);
            MessageBox.Show("Application submitted successfully.");
            //clear fields
            name_field.Text = "";
            email_field.Text = "";
            phone_field.Text = "";
            roll_field.Text = "";
            why_hire_field.Text = "";
            why_join_field.Text = "";
        }

    }
}
