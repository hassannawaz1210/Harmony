namespace SMS
{
    partial class soc_profile
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(soc_profile));
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            soc_title = new Label();
            follow_button = new Button();
            join_button = new Button();
            soc_desc = new Label();
            soc_logo = new PictureBox();
            panel2 = new Panel();
            switch_window = new Panel();
            panel3 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            about_button = new Button();
            members_button = new Button();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)soc_logo).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(18, 18, 18);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Controls.Add(soc_logo);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(10);
            panel1.Size = new Size(1038, 230);
            panel1.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 148F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 608F));
            tableLayoutPanel1.Controls.Add(soc_title, 0, 0);
            tableLayoutPanel1.Controls.Add(follow_button, 0, 2);
            tableLayoutPanel1.Controls.Add(join_button, 1, 2);
            tableLayoutPanel1.Controls.Add(soc_desc, 0, 1);
            tableLayoutPanel1.Location = new Point(221, 10);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 49F));
            tableLayoutPanel1.Size = new Size(802, 210);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // soc_title
            // 
            soc_title.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(soc_title, 2);
            soc_title.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            soc_title.ForeColor = Color.White;
            soc_title.Location = new Point(3, 10);
            soc_title.Margin = new Padding(3, 10, 3, 10);
            soc_title.Name = "soc_title";
            soc_title.Size = new Size(130, 28);
            soc_title.TabIndex = 0;
            soc_title.Text = "Society Title";
            // 
            // follow_button
            // 
            follow_button.BackColor = Color.FromArgb(240, 84, 84);
            follow_button.Cursor = Cursors.Hand;
            follow_button.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            follow_button.Location = new Point(3, 164);
            follow_button.Name = "follow_button";
            follow_button.Size = new Size(130, 43);
            follow_button.TabIndex = 2;
            follow_button.Text = "Follow";
            follow_button.UseVisualStyleBackColor = false;
            follow_button.Click += follow_button_Click;
            // 
            // join_button
            // 
            join_button.BackColor = Color.FromArgb(240, 84, 84);
            join_button.Cursor = Cursors.Hand;
            join_button.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            join_button.Location = new Point(151, 164);
            join_button.Name = "join_button";
            join_button.Size = new Size(122, 43);
            join_button.TabIndex = 3;
            join_button.Text = "Join";
            join_button.UseVisualStyleBackColor = false;
            join_button.Click += join_button_Click;
            // 
            // soc_desc
            // 
            soc_desc.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(soc_desc, 2);
            soc_desc.ForeColor = Color.White;
            soc_desc.Location = new Point(3, 48);
            soc_desc.Name = "soc_desc";
            soc_desc.Size = new Size(794, 80);
            soc_desc.TabIndex = 1;
            soc_desc.Text = resources.GetString("soc_desc.Text");
            // 
            // soc_logo
            // 
            soc_logo.BackColor = Color.White;
            soc_logo.Dock = DockStyle.Left;
            soc_logo.Location = new Point(10, 10);
            soc_logo.Name = "soc_logo";
            soc_logo.Size = new Size(205, 208);
            soc_logo.SizeMode = PictureBoxSizeMode.StretchImage;
            soc_logo.TabIndex = 2;
            soc_logo.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(switch_window);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 230);
            panel2.Name = "panel2";
            panel2.Size = new Size(1038, 411);
            panel2.TabIndex = 3;
            // 
            // switch_window
            // 
            switch_window.BackColor = Color.FromArgb(18, 18, 18);
            switch_window.Dock = DockStyle.Fill;
            switch_window.Location = new Point(0, 59);
            switch_window.Name = "switch_window";
            switch_window.Padding = new Padding(5, 0, 5, 5);
            switch_window.Size = new Size(1038, 352);
            switch_window.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(18, 18, 18);
            panel3.Controls.Add(tableLayoutPanel2);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1038, 59);
            panel3.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.FromArgb(18, 18, 18);
            tableLayoutPanel2.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(about_button, 0, 0);
            tableLayoutPanel2.Controls.Add(members_button, 1, 0);
            tableLayoutPanel2.Location = new Point(3, 6);
            tableLayoutPanel2.Margin = new Padding(10);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(352, 49);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // about_button
            // 
            about_button.BackColor = Color.FromArgb(240, 84, 84);
            about_button.Dock = DockStyle.Fill;
            about_button.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            about_button.Location = new Point(5, 5);
            about_button.Name = "about_button";
            about_button.Size = new Size(167, 39);
            about_button.TabIndex = 0;
            about_button.Text = "About";
            about_button.UseVisualStyleBackColor = false;
            about_button.Click += about_button_Click;
            // 
            // members_button
            // 
            members_button.BackColor = Color.FromArgb(240, 84, 84);
            members_button.Dock = DockStyle.Fill;
            members_button.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            members_button.Location = new Point(180, 5);
            members_button.Name = "members_button";
            members_button.Size = new Size(167, 39);
            members_button.TabIndex = 1;
            members_button.Text = "Members";
            members_button.UseVisualStyleBackColor = false;
            members_button.Click += members_button_Click;
            // 
            // soc_profile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1038, 641);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "soc_profile";
            Text = "soc_profile";
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)soc_logo).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private PictureBox soc_logo;
        private TableLayoutPanel tableLayoutPanel1;
        private Label soc_title;
        private Label soc_desc;
        private Button follow_button;
        private Button join_button;
        private Panel panel2;
        private Panel switch_window;
        private Panel panel3;
        private TableLayoutPanel tableLayoutPanel2;
        private Button about_button;
        private Button members_button;
    }
}