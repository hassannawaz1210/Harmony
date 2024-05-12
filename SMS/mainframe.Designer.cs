using System.Drawing.Drawing2D;

namespace SMS
{
    partial class mainframe
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            logout_button = new Button();
            tableLayoutPanel4 = new TableLayoutPanel();
            events_button = new Button();
            ann_button = new Button();
            apply_button = new Button();
            browse_button = new Button();
            home_button = new Button();
            panel3 = new Panel();
            tableLayoutPanel3 = new TableLayoutPanel();
            search_box = new TextBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            page_title = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            username_label = new LinkLabel();
            role_label = new Label();
            profile_pic = new PictureBox();
            menu_buttons_holder = new Panel();
            body_panel = new Panel();
            tooltip = new ToolTip(components);
            panel1.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            panel3.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)profile_pic).BeginInit();
            menu_buttons_holder.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AccessibleName = "menuPanel";
            panel1.BackColor = Color.FromArgb(18, 18, 18);
            panel1.Controls.Add(logout_button);
            panel1.Controls.Add(tableLayoutPanel4);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(72, 824);
            panel1.TabIndex = 0;
            // 
            // logout_button
            // 
            logout_button.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            logout_button.BackColor = Color.Black;
            logout_button.BackgroundImage = Properties.Resources.logout;
            logout_button.BackgroundImageLayout = ImageLayout.Stretch;
            logout_button.Cursor = Cursors.Hand;
            logout_button.FlatAppearance.BorderSize = 0;
            logout_button.FlatStyle = FlatStyle.Flat;
            logout_button.Location = new Point(12, 752);
            logout_button.Name = "logout_button";
            logout_button.Padding = new Padding(10);
            logout_button.Size = new Size(50, 49);
            logout_button.TabIndex = 3;
            tooltip.SetToolTip(logout_button, "Logout");
            logout_button.UseVisualStyleBackColor = false;
            logout_button.Click += logout_button_Click;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.AutoScroll = true;
            tableLayoutPanel4.AutoSize = true;
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(events_button, 0, 4);
            tableLayoutPanel4.Controls.Add(ann_button, 0, 3);
            tableLayoutPanel4.Controls.Add(apply_button, 0, 2);
            tableLayoutPanel4.Controls.Add(browse_button, 0, 1);
            tableLayoutPanel4.Controls.Add(home_button, 0, 0);
            tableLayoutPanel4.Location = new Point(0, 0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.Padding = new Padding(13, 15, 0, 0);
            tableLayoutPanel4.RowCount = 5;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel4.Size = new Size(73, 325);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // events_button
            // 
            events_button.BackColor = Color.Black;
            events_button.BackgroundImage = Properties.Resources._event;
            events_button.BackgroundImageLayout = ImageLayout.Stretch;
            events_button.Cursor = Cursors.Hand;
            events_button.FlatAppearance.BorderSize = 0;
            events_button.FlatStyle = FlatStyle.Flat;
            events_button.Location = new Point(13, 273);
            events_button.Margin = new Padding(0, 10, 3, 3);
            events_button.Name = "events_button";
            events_button.Size = new Size(49, 49);
            events_button.TabIndex = 4;
            tooltip.SetToolTip(events_button, "View Events");
            events_button.UseVisualStyleBackColor = false;
            events_button.Click += event_button_Click;
            // 
            // ann_button
            // 
            ann_button.BackColor = Color.Black;
            ann_button.BackgroundImage = Properties.Resources.announcements1;
            ann_button.BackgroundImageLayout = ImageLayout.Stretch;
            ann_button.Cursor = Cursors.Hand;
            ann_button.FlatAppearance.BorderSize = 0;
            ann_button.FlatStyle = FlatStyle.Flat;
            ann_button.Location = new Point(16, 211);
            ann_button.Margin = new Padding(3, 10, 3, 3);
            ann_button.Name = "ann_button";
            ann_button.Size = new Size(37, 38);
            ann_button.TabIndex = 3;
            tooltip.SetToolTip(ann_button, "View Announcements");
            ann_button.UseVisualStyleBackColor = false;
            ann_button.Click += ann_button_Click;
            // 
            // apply_button
            // 
            apply_button.BackColor = Color.Black;
            apply_button.BackgroundImage = Properties.Resources.apply;
            apply_button.BackgroundImageLayout = ImageLayout.Stretch;
            apply_button.Cursor = Cursors.Hand;
            apply_button.FlatAppearance.BorderSize = 0;
            apply_button.FlatStyle = FlatStyle.Flat;
            apply_button.Location = new Point(16, 142);
            apply_button.Name = "apply_button";
            apply_button.Size = new Size(40, 49);
            apply_button.TabIndex = 2;
            tooltip.SetToolTip(apply_button, "Create Society");
            apply_button.UseVisualStyleBackColor = false;
            apply_button.Click += apply_button_Click;
            // 
            // browse_button
            // 
            browse_button.BackColor = Color.Black;
            browse_button.BackgroundImage = Properties.Resources.society;
            browse_button.BackgroundImageLayout = ImageLayout.Stretch;
            browse_button.Cursor = Cursors.Hand;
            browse_button.FlatAppearance.BorderSize = 0;
            browse_button.FlatStyle = FlatStyle.Flat;
            browse_button.Location = new Point(16, 80);
            browse_button.Name = "browse_button";
            browse_button.Size = new Size(40, 37);
            browse_button.TabIndex = 1;
            tooltip.SetToolTip(browse_button, "Browse Societies");
            browse_button.UseVisualStyleBackColor = false;
            browse_button.Click += browse_button_Click;
            // 
            // home_button
            // 
            home_button.BackColor = Color.Black;
            home_button.BackgroundImage = Properties.Resources.home;
            home_button.BackgroundImageLayout = ImageLayout.Stretch;
            home_button.Cursor = Cursors.Hand;
            home_button.FlatAppearance.BorderSize = 0;
            home_button.FlatStyle = FlatStyle.Flat;
            home_button.ForeColor = Color.Black;
            home_button.Location = new Point(13, 15);
            home_button.Margin = new Padding(0);
            home_button.Name = "home_button";
            home_button.Size = new Size(40, 40);
            home_button.TabIndex = 0;
            tooltip.SetToolTip(home_button, "Home");
            home_button.UseVisualStyleBackColor = false;
            home_button.Click += home_button_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(240, 84, 84);
            panel3.Controls.Add(tableLayoutPanel3);
            panel3.Controls.Add(tableLayoutPanel2);
            panel3.Controls.Add(tableLayoutPanel1);
            panel3.Controls.Add(profile_pic);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(72, 0);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(10);
            panel3.Size = new Size(1133, 80);
            panel3.TabIndex = 2;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(search_box, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(332, 10);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.Padding = new Padding(10, 5, 10, 0);
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(558, 60);
            tableLayoutPanel3.TabIndex = 3;
            // 
            // search_box
            // 
            tableLayoutPanel3.SetColumnSpan(search_box, 2);
            search_box.Dock = DockStyle.Fill;
            search_box.Enabled = false;
            search_box.Font = new Font("Segoe UI", 15F);
            search_box.Location = new Point(13, 8);
            search_box.Name = "search_box";
            search_box.Size = new Size(532, 41);
            search_box.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(page_title, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Left;
            tableLayoutPanel2.Location = new Point(10, 10);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(322, 60);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // page_title
            // 
            page_title.AutoSize = true;
            page_title.Dock = DockStyle.Left;
            page_title.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            page_title.Location = new Point(3, 0);
            page_title.Name = "page_title";
            page_title.Padding = new Padding(5, 12, 0, 0);
            page_title.Size = new Size(166, 60);
            page_title.TabIndex = 0;
            page_title.Text = "Dashboard";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(username_label, 0, 0);
            tableLayoutPanel1.Controls.Add(role_label, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Right;
            tableLayoutPanel1.Location = new Point(890, 10);
            tableLayoutPanel1.Margin = new Padding(5);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(5);
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 46.6666679F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 53.3333321F));
            tableLayoutPanel1.Size = new Size(161, 60);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // username_label
            // 
            username_label.AutoSize = true;
            username_label.Cursor = Cursors.Hand;
            username_label.Dock = DockStyle.Right;
            username_label.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            username_label.LinkColor = Color.Black;
            username_label.Location = new Point(77, 5);
            username_label.Name = "username_label";
            username_label.Size = new Size(76, 23);
            username_label.TabIndex = 0;
            username_label.TabStop = true;
            username_label.Text = "Full Name";
            username_label.LinkClicked += username_label_Click;
            // 
            // role_label
            // 
            role_label.AutoSize = true;
            role_label.Dock = DockStyle.Right;
            role_label.Location = new Point(82, 28);
            role_label.Name = "role_label";
            role_label.Size = new Size(71, 27);
            role_label.TabIndex = 1;
            role_label.Text = "User type";
            // 
            // profile_pic
            // 
            profile_pic.BackColor = Color.Transparent;
            profile_pic.BackgroundImage = Properties.Resources.default_profile2;
            profile_pic.BackgroundImageLayout = ImageLayout.Stretch;
            profile_pic.Cursor = Cursors.Hand;
            profile_pic.Dock = DockStyle.Right;
            profile_pic.InitialImage = Properties.Resources.default_profile1;
            profile_pic.Location = new Point(1051, 10);
            profile_pic.Name = "profile_pic";
            profile_pic.Size = new Size(72, 60);
            profile_pic.TabIndex = 0;
            profile_pic.TabStop = false;
            tooltip.SetToolTip(profile_pic, "View Profile");
            profile_pic.WaitOnLoad = true;
            profile_pic.Click += profile_picture_Click;
            profile_pic.Paint += profile_pic_Paint;
            // 
            // menu_buttons_holder
            // 
            menu_buttons_holder.AccessibleName = "bodyPanel";
            menu_buttons_holder.BackColor = Color.White;
            menu_buttons_holder.Controls.Add(body_panel);
            menu_buttons_holder.Dock = DockStyle.Fill;
            menu_buttons_holder.Location = new Point(72, 0);
            menu_buttons_holder.Name = "menu_buttons_holder";
            menu_buttons_holder.Size = new Size(1133, 824);
            menu_buttons_holder.TabIndex = 1;
            // 
            // body_panel
            // 
            body_panel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            body_panel.BackColor = SystemColors.Control;
            body_panel.Location = new Point(0, 79);
            body_panel.Name = "body_panel";
            body_panel.Size = new Size(1133, 745);
            body_panel.TabIndex = 1;
            // 
            // tooltip
            // 
            tooltip.AutoPopDelay = 5000;
            tooltip.InitialDelay = 100;
            tooltip.ReshowDelay = 100;
            tooltip.Tag = "";
            // 
            // mainframe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1205, 824);
            Controls.Add(panel3);
            Controls.Add(menu_buttons_holder);
            Controls.Add(panel1);
            Name = "mainframe";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)profile_pic).EndInit();
            menu_buttons_holder.ResumeLayout(false);
            ResumeLayout(false);
        }

        void profile_pic_Paint(object sender, PaintEventArgs e)
        {
            GraphicsPath gp = new GraphicsPath();
            gp.AddEllipse(0, 0, profile_pic.Width - 1, profile_pic.Height - 1);
            Region rg = new Region(gp);
            profile_pic.Region = rg;
        }

        private void Apply_button_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Panel menu_buttons_holder;
        private PictureBox profile_pic;
        private TableLayoutPanel tableLayoutPanel1;
        private LinkLabel username_label;
        private Label role_label;
        private TableLayoutPanel tableLayoutPanel3;
        private TextBox search_box;
        private TableLayoutPanel tableLayoutPanel2;
        private Label page_title;
        private TableLayoutPanel tableLayoutPanel4;
        private Button home_button;
        private Button browse_button;
        private Panel body_panel;
        private Button apply_button;
        private Button logout_button;
        private ToolTip tooltip;
        private Button ann_button;
        private Button events_button;
    }
}
