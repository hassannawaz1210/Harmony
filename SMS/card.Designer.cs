using System.Drawing.Drawing2D;

namespace SMS
{
    partial class card
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            society_pp = new PictureBox();
            society_title = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)society_pp).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // society_pp
            // 
            society_pp.BackColor = SystemColors.ActiveCaption;
            society_pp.Dock = DockStyle.Top;
            society_pp.Location = new Point(20, 20);
            society_pp.Name = "society_pp";
            society_pp.Size = new Size(209, 187);
            society_pp.SizeMode = PictureBoxSizeMode.StretchImage;
            society_pp.TabIndex = 0;
            society_pp.TabStop = false;
            // 
            // society_title
            // 
            society_title.AutoSize = true;
            society_title.BackColor = Color.Transparent;
            society_title.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            society_title.ForeColor = Color.FromArgb(240, 84, 84);
            society_title.Location = new Point(3, 0);
            society_title.Name = "society_title";
            society_title.Padding = new Padding(10);
            society_title.Size = new Size(114, 40);
            society_title.TabIndex = 1;
            society_title.Text = "Sample Text";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.Controls.Add(society_title);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(20, 207);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(209, 43);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // card
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(flowLayoutPanel1);
            Controls.Add(society_pp);
            Cursor = Cursors.Hand;
            Margin = new Padding(10);
            Name = "card";
            Padding = new Padding(20);
            Size = new Size(249, 270);
            Load += card_Load;
            Paint += rounded_corners;
            ((System.ComponentModel.ISupportInitialize)society_pp).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void rounded_corners(object sender, PaintEventArgs e)
        {
            Rectangle r = new Rectangle(0, 0, this.Width, this.Height);
            int radius = 20;
            GraphicsPath gp = new GraphicsPath();
            gp.AddArc(r.X, r.Y, radius, radius, 180, 90);
            gp.AddArc(r.X + r.Width - radius, r.Y, radius, radius, 270, 90);
            gp.AddArc(r.X + r.Width - radius, r.Y + r.Height - radius, radius, radius, 0, 90);
            gp.AddArc(r.X, r.Y + r.Height - radius, radius, radius, 90, 90);
            this.Region = new Region(gp);
        }
        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_DROPSHADOW = 0x00020000;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }

        #endregion

        private PictureBox society_pp;
        private Label society_title;
        private FlowLayoutPanel flowLayoutPanel1;

        public string get_title()
        {
            return society_title.Text;
        }
    }
}
