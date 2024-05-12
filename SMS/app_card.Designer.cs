using System.Drawing.Drawing2D;

namespace SMS
{
    partial class app_card
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(app_card));
            soc_logo = new PictureBox();
            panel1 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            soc_desc = new Label();
            soc_name = new Label();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            soc_president = new Label();
            soc_dos = new Label();
            ((System.ComponentModel.ISupportInitialize)soc_logo).BeginInit();
            panel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // soc_logo
            // 
            soc_logo.BackColor = SystemColors.ControlLight;
            soc_logo.BackgroundImageLayout = ImageLayout.Stretch;
            soc_logo.Dock = DockStyle.Left;
            soc_logo.Location = new Point(10, 10);
            soc_logo.Name = "soc_logo";
            soc_logo.Size = new Size(189, 235);
            soc_logo.TabIndex = 0;
            soc_logo.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(18, 18, 18);
            panel1.Controls.Add(tableLayoutPanel2);
            panel1.Controls.Add(soc_logo);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(10);
            panel1.Size = new Size(1057, 255);
            panel1.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.6540737F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 81.3459244F));
            tableLayoutPanel2.Controls.Add(soc_desc, 1, 3);
            tableLayoutPanel2.Controls.Add(soc_name, 0, 0);
            tableLayoutPanel2.Controls.Add(label2, 0, 1);
            tableLayoutPanel2.Controls.Add(label1, 0, 2);
            tableLayoutPanel2.Controls.Add(label3, 0, 3);
            tableLayoutPanel2.Controls.Add(soc_president, 1, 1);
            tableLayoutPanel2.Controls.Add(soc_dos, 1, 2);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(199, 10);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 4;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 26.8241367F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 18.8652744F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 18.5450821F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 35.7655144F));
            tableLayoutPanel2.Size = new Size(848, 235);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // soc_desc
            // 
            soc_desc.AutoSize = true;
            soc_desc.ForeColor = Color.White;
            soc_desc.Location = new Point(161, 150);
            soc_desc.Name = "soc_desc";
            soc_desc.Size = new Size(681, 60);
            soc_desc.TabIndex = 6;
            soc_desc.Text = resources.GetString("soc_desc.Text");
            // 
            // soc_name
            // 
            soc_name.AutoSize = true;
            tableLayoutPanel2.SetColumnSpan(soc_name, 2);
            soc_name.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            soc_name.ForeColor = Color.White;
            soc_name.Location = new Point(3, 0);
            soc_name.Name = "soc_name";
            soc_name.Size = new Size(265, 38);
            soc_name.TabIndex = 0;
            soc_name.Text = "Google Developers";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(3, 63);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 1;
            label2.Text = "President:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(3, 107);
            label1.Name = "label1";
            label1.Size = new Size(148, 20);
            label1.TabIndex = 2;
            label1.Text = "Date of submission:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(3, 150);
            label3.Name = "label3";
            label3.Size = new Size(93, 20);
            label3.TabIndex = 3;
            label3.Text = "Description:";
            // 
            // soc_president
            // 
            soc_president.AutoSize = true;
            soc_president.ForeColor = Color.White;
            soc_president.Location = new Point(161, 63);
            soc_president.Name = "soc_president";
            soc_president.Size = new Size(105, 20);
            soc_president.TabIndex = 4;
            soc_president.Text = "Hassan Nawaz";
            // 
            // soc_dos
            // 
            soc_dos.AutoSize = true;
            soc_dos.ForeColor = Color.White;
            soc_dos.Location = new Point(161, 107);
            soc_dos.Name = "soc_dos";
            soc_dos.Size = new Size(91, 20);
            soc_dos.TabIndex = 5;
            soc_dos.Text = "12 Dec 2024";
            // 
            // app_card
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Cursor = Cursors.Hand;
            Margin = new Padding(10);
            Name = "app_card";
            Size = new Size(1057, 255);
            ((System.ComponentModel.ISupportInitialize)soc_logo).EndInit();
            panel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
            Paint += rounded_corners;
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

        #endregion

        private PictureBox soc_logo;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label soc_desc;
        private Label soc_name;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label soc_president;
        private Label soc_dos;
    }
}
