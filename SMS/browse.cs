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
    public partial class browse : Form
    {
        List<Society> societies;
        IUser user;
        BrowseBL browseBL;
        Label page_title;
        private Panel home_body_panel;

        public browse(Panel panel, Label pg_title, IUser user)
        {
            InitializeComponent();
            browseBL = new BrowseBL();
            this.user = user;
            page_title = pg_title;
            home_body_panel = panel;
            display_societies();
        }

        private void display_societies()
        {
            societies = browseBL.fetch_societies();
            create_cards();
        }

        private void create_cards()
        {
            foreach (Society society in societies)
            {
                card card = new card();
                card.set_title(society.Name);
                card.set_img(society.Logo);
                card.set_mouse_click(card_mouse_Click);
                //card.MouseHover += (sender, e) => card.Size = new Size(400, 400);
               // card.MouseClick += card_mouse_Click;

                //add card to flowlayoutpanel
                flowLayoutPanel1.Controls.Add(card);
            }
        }

        private void card_mouse_Click(object sender, MouseEventArgs e)
        {
            //card card = (card)sender;
            //string title = card.get_title();
            Label label = (Label)sender;
            string title = label.Text;
            Society society = societies.Find(s => s.Name == title); //find society object by title in "societies" list
            soc_profile profile = new soc_profile(page_title, society, home_body_panel, user);
            profile.TopLevel = false;
            profile.AutoScroll = true;
            profile.FormBorderStyle = FormBorderStyle.None;
            profile.Dock = DockStyle.Fill;
            home_body_panel.Controls.Clear();
            home_body_panel.Controls.Add(profile);
            profile.Show();
        }
    }
}
