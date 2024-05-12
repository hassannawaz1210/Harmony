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
    public partial class join_app : UserControl
    {
        private JoinAppDB joinAppDB;
        JoinAppCont joinAppCont;
        private Society Society;
        private Panel home_body_panel;
        public join_app(Society soc, Panel panel)
        {
            InitializeComponent();
            joinAppDB = new JoinAppDB();
            home_body_panel = panel;
            Society = soc;
        }
        
        public void update(JoinAppCont joinAppCont)
        {
            this.joinAppCont = joinAppCont;
            //
            name_label.Text = joinAppCont.Name;
            email_label.Text = joinAppCont.Email;
            phone_label.Text = joinAppCont.Phone;
            roll_label.Text = joinAppCont.Roll;
            why_join_label.Text = joinAppCont.Why_join;
            why_hire_label.Text = joinAppCont.Why_hire;
        }


        private void refresh_win()
        {
            join_apps_win joinAppsWin = new join_apps_win(Society, home_body_panel) { TopLevel = false, TopMost = true };
            joinAppsWin.FormBorderStyle = FormBorderStyle.None;
            joinAppsWin.Dock = DockStyle.Fill;
            home_body_panel.Controls.Clear();
            home_body_panel.Controls.Add(joinAppsWin);
            joinAppsWin.Show();
        }
        private void accept_button_Click(object sender, EventArgs e)
        {
            //accept application
            joinAppDB.Accept(joinAppCont.Id, joinAppCont.Stu_id, joinAppCont.Soc_id);
            MessageBox.Show("Application accepted.");

            //refresh join apps
            refresh_win();
        }

        private void reject_button_Click(object sender, EventArgs e)
        {
            //reject application
            joinAppDB.Reject(joinAppCont.Id);
            MessageBox.Show("Application rejected.");
            //
            //refresh join apps
            refresh_win();
        }
    }
}
