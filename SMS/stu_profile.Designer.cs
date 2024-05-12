using System.Drawing.Drawing2D;

namespace SMS
{
    partial class stu_profile
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
            cover_pic = new Panel();
            profile_pic = new Panel();
            name_label = new Label();
            edit_button = new Button();
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            bio_label = new Label();
            label1 = new Label();
            panel2 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            degree_label = new Label();
            batch_label = new Label();
            phone_label = new Label();
            email_label = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            roll_label = new Label();
            cover_pic.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // cover_pic
            // 
            cover_pic.BackColor = SystemColors.ActiveCaptionText;
            cover_pic.Controls.Add(profile_pic);
            cover_pic.Dock = DockStyle.Top;
            cover_pic.Location = new Point(0, 0);
            cover_pic.Name = "cover_pic";
            cover_pic.Size = new Size(1038, 174);
            cover_pic.TabIndex = 0;
            // 
            // profile_pic
            // 
            profile_pic.BackColor = SystemColors.ActiveCaption;
            profile_pic.BackgroundImageLayout = ImageLayout.Stretch;
            profile_pic.Location = new Point(82, 74);
            profile_pic.Name = "profile_pic";
            profile_pic.Size = new Size(193, 163);
            profile_pic.TabIndex = 0;
            // 
            // name_label
            // 
            name_label.AutoSize = true;
            name_label.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            name_label.Location = new Point(281, 190);
            name_label.Name = "name_label";
            name_label.Size = new Size(79, 31);
            name_label.TabIndex = 1;
            name_label.Text = "label1";
            // 
            // edit_button
            // 
            edit_button.BackColor = Color.FromArgb(240, 84, 84);
            edit_button.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            edit_button.Location = new Point(880, 192);
            edit_button.Name = "edit_button";
            edit_button.Size = new Size(140, 55);
            edit_button.TabIndex = 2;
            edit_button.Text = "Edit Profile";
            edit_button.UseVisualStyleBackColor = false;
            edit_button.Click += edit_button_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = SystemColors.ControlText;
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Location = new Point(0, 258);
            panel1.Name = "panel1";
            panel1.Size = new Size(1038, 143);
            panel1.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(bio_label, 0, 1);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(10);
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25.4901962F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 74.5098F));
            tableLayoutPanel1.Size = new Size(1038, 143);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // bio_label
            // 
            bio_label.AutoSize = true;
            bio_label.ForeColor = Color.White;
            bio_label.Location = new Point(13, 41);
            bio_label.Name = "bio_label";
            bio_label.Size = new Size(50, 20);
            bio_label.TabIndex = 1;
            bio_label.Text = "label2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(13, 10);
            label1.Name = "label1";
            label1.Size = new Size(40, 25);
            label1.TabIndex = 0;
            label1.Text = "Bio";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(tableLayoutPanel2);
            panel2.Location = new Point(0, 413);
            panel2.Name = "panel2";
            panel2.Size = new Size(1038, 226);
            panel2.TabIndex = 4;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.Black;
            tableLayoutPanel2.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(degree_label, 1, 4);
            tableLayoutPanel2.Controls.Add(batch_label, 1, 3);
            tableLayoutPanel2.Controls.Add(phone_label, 1, 2);
            tableLayoutPanel2.Controls.Add(email_label, 1, 1);
            tableLayoutPanel2.Controls.Add(label3, 0, 0);
            tableLayoutPanel2.Controls.Add(label4, 0, 1);
            tableLayoutPanel2.Controls.Add(label5, 0, 2);
            tableLayoutPanel2.Controls.Add(label6, 0, 3);
            tableLayoutPanel2.Controls.Add(label7, 0, 4);
            tableLayoutPanel2.Controls.Add(roll_label, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.Padding = new Padding(10);
            tableLayoutPanel2.RowCount = 5;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.Size = new Size(1038, 226);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // degree_label
            // 
            degree_label.AutoSize = true;
            degree_label.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            degree_label.ForeColor = Color.White;
            degree_label.Location = new Point(522, 175);
            degree_label.Name = "degree_label";
            degree_label.Padding = new Padding(10, 5, 0, 0);
            degree_label.Size = new Size(79, 28);
            degree_label.TabIndex = 9;
            degree_label.Text = "label12";
            // 
            // batch_label
            // 
            batch_label.AutoSize = true;
            batch_label.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            batch_label.ForeColor = Color.White;
            batch_label.Location = new Point(522, 134);
            batch_label.Name = "batch_label";
            batch_label.Padding = new Padding(10, 5, 0, 0);
            batch_label.Size = new Size(79, 28);
            batch_label.TabIndex = 8;
            batch_label.Text = "label11";
            // 
            // phone_label
            // 
            phone_label.AutoSize = true;
            phone_label.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            phone_label.ForeColor = Color.White;
            phone_label.Location = new Point(522, 93);
            phone_label.Name = "phone_label";
            phone_label.Padding = new Padding(10, 5, 0, 0);
            phone_label.Size = new Size(79, 28);
            phone_label.TabIndex = 7;
            phone_label.Text = "label10";
            // 
            // email_label
            // 
            email_label.AutoSize = true;
            email_label.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            email_label.ForeColor = Color.White;
            email_label.Location = new Point(522, 52);
            email_label.Name = "email_label";
            email_label.Padding = new Padding(10, 5, 0, 0);
            email_label.Size = new Size(69, 28);
            email_label.TabIndex = 6;
            email_label.Text = "label9";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(14, 11);
            label3.Name = "label3";
            label3.Padding = new Padding(10, 5, 0, 0);
            label3.Size = new Size(122, 28);
            label3.TabIndex = 0;
            label3.Text = "Roll Number";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(14, 52);
            label4.Name = "label4";
            label4.Padding = new Padding(10, 5, 0, 0);
            label4.Size = new Size(64, 28);
            label4.TabIndex = 1;
            label4.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(14, 93);
            label5.Name = "label5";
            label5.Padding = new Padding(10, 5, 0, 0);
            label5.Size = new Size(69, 28);
            label5.TabIndex = 2;
            label5.Text = "Phone";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(14, 134);
            label6.Name = "label6";
            label6.Padding = new Padding(10, 5, 0, 0);
            label6.Size = new Size(65, 28);
            label6.TabIndex = 3;
            label6.Text = "Batch";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label7.ForeColor = Color.White;
            label7.Location = new Point(14, 175);
            label7.Name = "label7";
            label7.Padding = new Padding(10, 5, 0, 0);
            label7.Size = new Size(118, 28);
            label7.TabIndex = 4;
            label7.Text = "Department";
            // 
            // roll_label
            // 
            roll_label.AutoSize = true;
            roll_label.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            roll_label.ForeColor = Color.White;
            roll_label.Location = new Point(522, 11);
            roll_label.Name = "roll_label";
            roll_label.Padding = new Padding(10, 5, 0, 0);
            roll_label.Size = new Size(69, 28);
            roll_label.TabIndex = 5;
            roll_label.Text = "label8";
            // 
            // stu_profile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1038, 641);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(edit_button);
            Controls.Add(name_label);
            Controls.Add(cover_pic);
            Name = "stu_profile";
            Text = "stu_profile";
            Resize += Stu_profile_Resize;
            cover_pic.ResumeLayout(false);
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel2.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void Stu_profile_Resize(object sender, EventArgs e)
        {
            edit_button.Location = new Point(this.Width - 170, edit_button.Location.Y);
            if(this.Width < 600)
            {
                edit_button.Visible = false;
            }
            else
            {
                edit_button.Visible = true;
            }

            panel1.Location = new Point(panel1.Location.X, 258);
        }

        #endregion

        private Panel cover_pic;
        private Panel profile_pic;
        private Label name_label;
        private Button edit_button;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label bio_label;
        private Label label1;
        private Panel panel2;
        private TableLayoutPanel tableLayoutPanel2;
        private Label degree_label;
        private Label batch_label;
        private Label phone_label;
        private Label email_label;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label roll_label;
    }
}