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
    public partial class ann_popup : Form
    {   

        public ann_popup(string date, string time, string subject, string msg)
        {
            InitializeComponent();
            ann_date_label.Text = date;
            ann_time_label.Text = time;
            subject_label.Text = subject;
            message_label.Text = msg;
        }

        private void close_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
