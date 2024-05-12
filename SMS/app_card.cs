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
    public partial class app_card : UserControl
    {
        public app_card()
        {
            InitializeComponent();
        }

        public void set_card_data(string soc_name, string soc_president, string soc_dos, string soc_desc, string soc_logo)
        {
            this.soc_name.Text = soc_name;
            this.soc_president.Text = soc_president;
            this.soc_dos.Text = soc_dos;
            this.soc_desc.Text = soc_desc;
            this.soc_logo.BackgroundImage = Image.FromFile(soc_logo);
        }
        
        public void set_mouse_click(MouseEventHandler handler)
        {
            //set mouseclick property on each control
            foreach(Control child in this.panel1.Controls)
            {
                child.MouseClick += (sender, e) => handler(this, e);
            }
        }
        public string get_soc_name()
        {
            return (this.soc_name.Text);
        }
    }
}
