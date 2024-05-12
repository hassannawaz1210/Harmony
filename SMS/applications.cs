using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMS
{
    public partial class applications : Form
    {
        private applicationsBL appBL;
        private List<Society> pending_socs;
        private Panel body_panel;

        //-=============  //
        private const UInt32 StdOutputHandle = 0xFFFFFFF5;
        [DllImport("kernel32.dll")]
        private static extern IntPtr GetStdHandle(UInt32 nStdHandle);
        [DllImport("kernel32.dll")]
        private static extern void SetStdHandle(UInt32 nStdHandle, IntPtr handle);
        [DllImport("kernel32")]
        static extern bool AllocConsole();
        public applications(Panel panel)
        {
            InitializeComponent();
            AllocConsole();
            appBL = new applicationsBL();
            body_panel = panel;
            run();
        }

        private void run()
        {
            //----
            no_pending_label.Visible = false;
            //-----
            pending_socs = appBL.fetch_societies();
            //table modifications
            tableLayoutPanel1.RowCount = pending_socs.Count + 1;

            foreach (Society soc in pending_socs)
            {
                app_card card = new app_card();
                card.set_card_data(soc.Name, soc.PresidentId, soc.FoundingDate, soc.Desc, soc.Logo);
                card.Dock = DockStyle.Fill;
                card.set_mouse_click(app_card_mouse_Click);
                //tableLayoutPanel1.Controls.Add(card);

                tableLayoutPanel1.Controls.Add(card, 0, pending_socs.IndexOf(soc));
            }
            //make table height equal to number of rows*225
            tableLayoutPanel1.Height = tableLayoutPanel1.RowCount * 225;

            //make rows of equal size
            foreach (RowStyle rs in tableLayoutPanel1.RowStyles)
            {
                rs.SizeType = SizeType.Absolute;
                rs.Height = 225;
            }
            
            if (pending_socs.Count == 0)
            {
                no_pending_label.Visible = true;
            }

        }

        private void app_card_mouse_Click(object sender, MouseEventArgs e)
        {
            Console.WriteLine("Clicked");
            //get the app card that was clicked
            app_card card = (app_card)sender;
            string title = card.get_soc_name();

            //find society by th
            Society soc = pending_socs.Find(s => s.Name == title);

            //create app details page
            app_details app_Details = new app_details(soc, body_panel) { TopLevel = false, TopMost = true };
            app_Details.FormBorderStyle = FormBorderStyle.None;
            Form form = body_panel.Controls.OfType<Form>().FirstOrDefault();
            try
            {
                form.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Couldn't close form in \"applications\" because: ", ex);
            }
            body_panel.Controls.Add(app_Details);
            app_Details.Dock = DockStyle.Fill;
            app_Details.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
