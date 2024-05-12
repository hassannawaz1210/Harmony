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
    public partial class join_apps_win : Form
    {
        private JoinAppsWinDB joinAppsWinDB;
        private Society soc;
        private List<JoinAppCont> joinApps;
        private Panel home_body_panel;
        public join_apps_win(Society society, Panel home_body_panel)
        {
            InitializeComponent();
            joinAppsWinDB = new JoinAppsWinDB();
            this.soc = society;
            this.home_body_panel = home_body_panel;
            onLoad();
        }

        private void onLoad()
        {
            joinApps = joinAppsWinDB.get_applications(soc.Id);
            if(joinApps.Count == 0)
            {
                this.Controls.Clear();
                Label no_apps = new Label();
                no_apps.Text = "No applications found.";
                no_apps.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
                no_apps.AutoSize = true;
                no_apps.Location = new Point(((this.Width - no_apps.Width) / 2)-40, ((this.Height - no_apps.Height) / 2)-30);
                no_apps.Anchor = AnchorStyles.None;
                this.Controls.Add(no_apps);
                return;
            }
            tableLayoutPanel1.RowCount = 0;
            foreach (JoinAppCont joinApp in joinApps)
            {
                join_app joinAppControl = new join_app(this.soc, home_body_panel);
                //joinAppControl.update(joinApp.Name, joinApp.Email, joinApp.Phone, joinApp.Roll, joinApp.Why_join, joinApp.Why_hire);
                joinAppControl.update(joinApp);
                //add to row and make dock fill
                joinAppControl.Dock = DockStyle.Top;
                tableLayoutPanel1.RowCount++;
                tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 460F));
                tableLayoutPanel1.Controls.Add(joinAppControl, 0, tableLayoutPanel1.RowCount - 1);
            }
            //set each row size to 955, 462
            foreach (RowStyle rs in tableLayoutPanel1.RowStyles)
            {
                rs.SizeType = SizeType.Absolute;
                rs.Height = 460;
            }
        }
    }
}
