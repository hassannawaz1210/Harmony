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
    public partial class create_event : Form
    {
        Society soc;
        private CreateEventDB createEventDB;
        private string path = "";
        public create_event(Society soc)
        {
            InitializeComponent();
            createEventDB = new CreateEventDB();
            this.soc = soc;
        }

        private void close_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void upload_button_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                path = ofd.FileName;
            }
        }

        private void submit_button_Click(object sender, EventArgs e)
        {
            if (name_field.Text != "" && desc_field.Text != "" && date_field.Text != "" && time_field.Text != "" && venue_field.Text != "" && sponsors_field.Text != "" && fee_field.Text != "")
            {
                Event e1 = new Event(name_field.Text, desc_field.Text, date_field.Text, time_field.Text, venue_field.Text, path, sponsors_field.Text, fee_field.Text, soc.Id);
                createEventDB.create_event(e1);
                MessageBox.Show("Event created successfully");
                this.Close();
            }
            else
            {
                MessageBox.Show("Please fill all the fields");
            }
        }
    }
}
