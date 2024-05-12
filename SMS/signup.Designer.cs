namespace SMS
{
    partial class signup
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
            lower_panel = new Panel();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            upper_panel = new Panel();
            rollno_field = new TextBox();
            rollno_label = new Label();
            goto_login_label = new LinkLabel();
            signup_button = new Button();
            degree_field = new ComboBox();
            degree_label = new Label();
            batch_field = new ComboBox();
            batch_label = new Label();
            phone_field = new TextBox();
            phone_label = new Label();
            email_field = new TextBox();
            email_label = new Label();
            pass_field = new TextBox();
            pass_label = new Label();
            user_field = new TextBox();
            user_label = new Label();
            name_field = new TextBox();
            name_label = new Label();
            main_title = new Label();
            lower_panel.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            upper_panel.SuspendLayout();
            SuspendLayout();
            // 
            // lower_panel
            // 
            lower_panel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lower_panel.BackColor = Color.Black;
            lower_panel.Controls.Add(panel1);
            lower_panel.Controls.Add(upper_panel);
            lower_panel.Location = new Point(-4, -3);
            lower_panel.Name = "lower_panel";
            lower_panel.Size = new Size(945, 610);
            lower_panel.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(240, 84, 84);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(67, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(377, 511);
            panel1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.logo_black;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(3, 264);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(371, 244);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // upper_panel
            // 
            upper_panel.BackColor = Color.FromArgb(240, 84, 84);
            upper_panel.Controls.Add(rollno_field);
            upper_panel.Controls.Add(rollno_label);
            upper_panel.Controls.Add(goto_login_label);
            upper_panel.Controls.Add(signup_button);
            upper_panel.Controls.Add(degree_field);
            upper_panel.Controls.Add(degree_label);
            upper_panel.Controls.Add(batch_field);
            upper_panel.Controls.Add(batch_label);
            upper_panel.Controls.Add(phone_field);
            upper_panel.Controls.Add(phone_label);
            upper_panel.Controls.Add(email_field);
            upper_panel.Controls.Add(email_label);
            upper_panel.Controls.Add(pass_field);
            upper_panel.Controls.Add(pass_label);
            upper_panel.Controls.Add(user_field);
            upper_panel.Controls.Add(user_label);
            upper_panel.Controls.Add(name_field);
            upper_panel.Controls.Add(name_label);
            upper_panel.Controls.Add(main_title);
            upper_panel.Location = new Point(491, 38);
            upper_panel.Name = "upper_panel";
            upper_panel.Size = new Size(377, 572);
            upper_panel.TabIndex = 0;
            // 
            // rollno_field
            // 
            rollno_field.BackColor = Color.WhiteSmoke;
            rollno_field.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rollno_field.ForeColor = Color.Black;
            rollno_field.Location = new Point(18, 368);
            rollno_field.Name = "rollno_field";
            rollno_field.Size = new Size(341, 34);
            rollno_field.TabIndex = 14;
            // 
            // rollno_label
            // 
            rollno_label.AutoSize = true;
            rollno_label.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rollno_label.ForeColor = Color.Black;
            rollno_label.Location = new Point(18, 330);
            rollno_label.Name = "rollno_label";
            rollno_label.Size = new Size(95, 35);
            rollno_label.TabIndex = 20;
            rollno_label.Text = "RollNo:";
            // 
            // goto_login_label
            // 
            goto_login_label.AutoSize = true;
            goto_login_label.Location = new Point(98, 536);
            goto_login_label.Name = "goto_login_label";
            goto_login_label.Size = new Size(178, 20);
            goto_login_label.TabIndex = 19;
            goto_login_label.TabStop = true;
            goto_login_label.Text = "Already have an account?";
            goto_login_label.LinkClicked += goto_login_label_LinkClicked;
            // 
            // signup_button
            // 
            signup_button.BackColor = Color.FromArgb(18, 18, 18);
            signup_button.ForeColor = Color.White;
            signup_button.Location = new Point(120, 485);
            signup_button.Name = "signup_button";
            signup_button.Size = new Size(123, 48);
            signup_button.TabIndex = 18;
            signup_button.Text = "Signup";
            signup_button.UseVisualStyleBackColor = false;
            signup_button.Click += signup_button_Click;
            // 
            // degree_field
            // 
            degree_field.FormattingEnabled = true;
            degree_field.Items.AddRange(new object[] { "CS", "AI", "CY", "BA" });
            degree_field.Location = new Point(208, 443);
            degree_field.Name = "degree_field";
            degree_field.Size = new Size(151, 28);
            degree_field.TabIndex = 17;
            // 
            // degree_label
            // 
            degree_label.AutoSize = true;
            degree_label.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            degree_label.ForeColor = Color.Black;
            degree_label.Location = new Point(211, 405);
            degree_label.Name = "degree_label";
            degree_label.Size = new Size(101, 35);
            degree_label.TabIndex = 16;
            degree_label.Text = "Degree:";
            // 
            // batch_field
            // 
            batch_field.FormattingEnabled = true;
            batch_field.Items.AddRange(new object[] { "2020", "2021", "2022", "2023" });
            batch_field.Location = new Point(18, 443);
            batch_field.Name = "batch_field";
            batch_field.Size = new Size(151, 28);
            batch_field.TabIndex = 15;
            // 
            // batch_label
            // 
            batch_label.AutoSize = true;
            batch_label.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            batch_label.ForeColor = Color.Black;
            batch_label.Location = new Point(21, 405);
            batch_label.Name = "batch_label";
            batch_label.Size = new Size(81, 35);
            batch_label.TabIndex = 14;
            batch_label.Text = "Batch:";
            // 
            // phone_field
            // 
            phone_field.BackColor = Color.WhiteSmoke;
            phone_field.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            phone_field.ForeColor = Color.Black;
            phone_field.Location = new Point(18, 293);
            phone_field.Name = "phone_field";
            phone_field.Size = new Size(341, 34);
            phone_field.TabIndex = 13;
            // 
            // phone_label
            // 
            phone_label.AutoSize = true;
            phone_label.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            phone_label.ForeColor = Color.Black;
            phone_label.Location = new Point(18, 255);
            phone_label.Name = "phone_label";
            phone_label.Size = new Size(90, 35);
            phone_label.TabIndex = 12;
            phone_label.Text = "Phone:";
            // 
            // email_field
            // 
            email_field.BackColor = Color.WhiteSmoke;
            email_field.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            email_field.ForeColor = Color.Black;
            email_field.Location = new Point(18, 218);
            email_field.Name = "email_field";
            email_field.Size = new Size(341, 34);
            email_field.TabIndex = 11;
            // 
            // email_label
            // 
            email_label.AutoSize = true;
            email_label.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            email_label.ForeColor = Color.Black;
            email_label.Location = new Point(18, 180);
            email_label.Name = "email_label";
            email_label.Size = new Size(80, 35);
            email_label.TabIndex = 10;
            email_label.Text = "Email:";
            // 
            // pass_field
            // 
            pass_field.BackColor = Color.WhiteSmoke;
            pass_field.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pass_field.ForeColor = Color.Black;
            pass_field.Location = new Point(201, 147);
            pass_field.Name = "pass_field";
            pass_field.Size = new Size(158, 34);
            pass_field.TabIndex = 9;
            // 
            // pass_label
            // 
            pass_label.AutoSize = true;
            pass_label.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pass_label.ForeColor = Color.Black;
            pass_label.Location = new Point(201, 109);
            pass_label.Name = "pass_label";
            pass_label.Size = new Size(125, 35);
            pass_label.TabIndex = 8;
            pass_label.Text = "Password:";
            // 
            // user_field
            // 
            user_field.BackColor = Color.WhiteSmoke;
            user_field.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            user_field.ForeColor = Color.Black;
            user_field.Location = new Point(18, 147);
            user_field.Name = "user_field";
            user_field.Size = new Size(152, 34);
            user_field.TabIndex = 7;
            // 
            // user_label
            // 
            user_label.AutoSize = true;
            user_label.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            user_label.ForeColor = Color.Black;
            user_label.Location = new Point(18, 109);
            user_label.Name = "user_label";
            user_label.Size = new Size(132, 35);
            user_label.TabIndex = 6;
            user_label.Text = "Username:";
            // 
            // name_field
            // 
            name_field.BackColor = Color.WhiteSmoke;
            name_field.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            name_field.ForeColor = Color.Black;
            name_field.Location = new Point(18, 74);
            name_field.Name = "name_field";
            name_field.Size = new Size(341, 34);
            name_field.TabIndex = 5;
            // 
            // name_label
            // 
            name_label.AutoSize = true;
            name_label.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            name_label.ForeColor = Color.Black;
            name_label.Location = new Point(18, 36);
            name_label.Name = "name_label";
            name_label.Size = new Size(87, 35);
            name_label.TabIndex = 4;
            name_label.Text = "Name:";
            // 
            // main_title
            // 
            main_title.AccessibleName = "main_heading";
            main_title.AutoSize = true;
            main_title.BackColor = Color.FromArgb(240, 84, 84);
            main_title.Font = new Font("Arial Rounded MT Bold", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            main_title.ForeColor = Color.Black;
            main_title.Location = new Point(120, 9);
            main_title.Name = "main_title";
            main_title.Size = new Size(133, 39);
            main_title.TabIndex = 1;
            main_title.Text = "Signup";
            // 
            // signup
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(939, 605);
            Controls.Add(lower_panel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "signup";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "signup";
            lower_panel.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            upper_panel.ResumeLayout(false);
            upper_panel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel lower_panel;
        private Panel upper_panel;
        private Label main_title;
        private TextBox user_field;
        private Label user_label;
        private TextBox name_field;
        private Label name_label;
        private TextBox pass_field;
        private Label pass_label;
        private TextBox email_field;
        private Label email_label;
        private TextBox phone_field;
        private Label phone_label;
        private ComboBox batch_field;
        private Label batch_label;
        private ComboBox degree_field;
        private Label degree_label;
        private Button signup_button;
        private LinkLabel goto_login_label;
        private TextBox rollno_field;
        private Label rollno_label;
        private Panel panel1;
        private PictureBox pictureBox1;
    }
}