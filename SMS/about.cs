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
    public partial class about : Form
    {
        public about()
        {
            InitializeComponent();
        }

        public void update_values(Society info)
        {
            president_label.Text = info.PresidentId;
            date_label.Text = info.FoundingDate;
            phone_label .Text = info.Phone;
            email_label.Text = info.Email;
            type_label.Text = info.Type;
            faculty_label.Text = info.Faculty;
            mission_label.Text = info.Mission;
            website_label.Text = info.Web;
            total_mem_label.Text = info.NumberOfMembers.ToString();
        }
    }
}
