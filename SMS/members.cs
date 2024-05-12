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
    public partial class members : Form
    {
        private Society soc;
        private List<string> names;
        private List<string> roles;
        private membersDB memDb;
        public members(Society society)
        {
            InitializeComponent();
            this.memDb = new membersDB();
            this.soc = society;
            this.names = new List<string>();
            this.roles = new List<string>();
            load_members();
        }

        private void load_members()
        {
            memDb.get_members(soc, names, roles);
            for (int i = 0; i < names.Count; i++)
            {
                tableLayoutPanel1.RowCount++;
                tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
                Label name = new Label();
                name.Padding = new Padding(0, 10, 0, 0);
                name.Text = names[i];
                name.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
                name.ForeColor = Color.White;
                name.AutoSize = true;
                tableLayoutPanel1.Controls.Add(name, 0, i + 1);
                Label role = new Label();
                role.Padding = new Padding(0, 10, 0, 0);
                role.Text = roles[i];
                role.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
                role.ForeColor = Color.White;
                role.AutoSize = true;
                tableLayoutPanel1.Controls.Add(role, 1, i + 1);
            }
            //loop thorugh each row and set its size to 45
            foreach (RowStyle rs in tableLayoutPanel1.RowStyles)
            {
                rs.SizeType = SizeType.Absolute;
                rs.Height = 45;
            }
        }


    }
}
