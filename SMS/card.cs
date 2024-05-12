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
    public partial class card : UserControl
    {
        public card()
        {
            InitializeComponent();
        }

        public void set_title(string title)
        {
            society_title.Text = title;
        }

        public void set_img(string img)
        {
            if (img == null || img == "")
            {
                return;
            }
            //string resourcefolder = System.IO.Path.GetFullPath(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\Resources\"));
            //society_pp.Image = Image.FromFile(resourcefolder + img);
            society_pp.Image = Image.FromFile(img);
        }

        //receive a mouse click function
        public void set_mouse_click(Action<object, MouseEventArgs> action)
        {
            society_pp.MouseClick += (sender, e) => action(society_title, e);
            flowLayoutPanel1.MouseClick += (sender, e) => action(society_title, e);
            //this.MouseHover += (sender, e) => this.Size = new Size(400, 400);
        }

        private void card_Load(object sender, EventArgs e)
        {

        }

        //private void mouse_hover(object sender, EventArgs e)
        //{
        //    this.Size = new Size(400,400);
        //}

    }
}
