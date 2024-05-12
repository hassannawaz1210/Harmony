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
    public partial class app_details : Form
    {
        private Society society;
        private AppDetailsBL appDetailsBL;
        private Panel body_panel;
        public app_details(Society soc, Panel panel)
        {
            InitializeComponent();
            //--
            appDetailsBL = new AppDetailsBL();
            this.society = soc;
            this.body_panel = panel;
            //-----
            this.soc_title.Text = soc.Name;
            this.soc_desc.Text = soc.Desc;
            this.soc_logo.BackgroundImage = Image.FromFile(soc.Logo);
            about about = new about() { TopLevel = false, TopMost = true };
            about.update_values(soc);
            about.FormBorderStyle = FormBorderStyle.None;
            about.Dock = DockStyle.Fill;
            this.panel3.Controls.Add(about);
            about.Show();
            //---
        }
        private void accept_button_Click(object sender, EventArgs e)
        {
            appDetailsBL.accept(this.society);
            Console.WriteLine("Application Accepted");
            //go back to applications page
            switch_to_apps_win();
        }

        private void reject_button_Click(object sender, EventArgs e)
        {
            appDetailsBL.reject(this.society);
            Console.WriteLine("Application Rejected");
            //
            switch_to_apps_win();
        }

        private void switch_to_apps_win()
        {
            body_panel.Controls.Clear();
            applications applications_win = new applications(body_panel) { TopLevel = false, TopMost = true };
            applications_win.FormBorderStyle = FormBorderStyle.None;
            body_panel.Controls.Add(applications_win);
            applications_win.Dock = DockStyle.Fill;
            applications_win.Show();
        }
    }
}
