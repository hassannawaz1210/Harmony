namespace SMS
{
    partial class login
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
            lower_bg_panel = new Panel();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            upper_bg_panel = new Panel();
            user_type = new ComboBox();
            goto_signup_label = new LinkLabel();
            login_button = new Button();
            show_pass_checkbox = new CheckBox();
            pass_field = new TextBox();
            user_field = new TextBox();
            pass_label = new Label();
            user_label = new Label();
            main_title = new Label();
            lower_bg_panel.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            upper_bg_panel.SuspendLayout();
            SuspendLayout();
            // 
            // lower_bg_panel
            // 
            lower_bg_panel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lower_bg_panel.BackColor = Color.FromArgb(18, 18, 18);
            lower_bg_panel.Controls.Add(panel1);
            lower_bg_panel.Controls.Add(upper_bg_panel);
            lower_bg_panel.Location = new Point(0, 0);
            lower_bg_panel.Margin = new Padding(0);
            lower_bg_panel.Name = "lower_bg_panel";
            lower_bg_panel.Size = new Size(939, 607);
            lower_bg_panel.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(240, 84, 84);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(71, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(377, 511);
            panel1.TabIndex = 3;
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
            // upper_bg_panel
            // 
            upper_bg_panel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            upper_bg_panel.BackColor = Color.FromArgb(240, 84, 84);
            upper_bg_panel.Controls.Add(user_type);
            upper_bg_panel.Controls.Add(goto_signup_label);
            upper_bg_panel.Controls.Add(login_button);
            upper_bg_panel.Controls.Add(show_pass_checkbox);
            upper_bg_panel.Controls.Add(pass_field);
            upper_bg_panel.Controls.Add(user_field);
            upper_bg_panel.Controls.Add(pass_label);
            upper_bg_panel.Controls.Add(user_label);
            upper_bg_panel.Controls.Add(main_title);
            upper_bg_panel.Location = new Point(492, 102);
            upper_bg_panel.Name = "upper_bg_panel";
            upper_bg_panel.Size = new Size(377, 505);
            upper_bg_panel.TabIndex = 1;
            // 
            // user_type
            // 
            user_type.FormattingEnabled = true;
            user_type.Items.AddRange(new object[] { "Admin", "Student" });
            user_type.Location = new Point(206, 264);
            user_type.Name = "user_type";
            user_type.Size = new Size(151, 28);
            user_type.TabIndex = 6;
            // 
            // goto_signup_label
            // 
            goto_signup_label.AutoSize = true;
            goto_signup_label.Location = new Point(125, 400);
            goto_signup_label.Name = "goto_signup_label";
            goto_signup_label.Size = new Size(139, 20);
            goto_signup_label.TabIndex = 8;
            goto_signup_label.TabStop = true;
            goto_signup_label.Text = "Register an account";
            goto_signup_label.LinkClicked += goto_signup_label_LinkClicked;
            // 
            // login_button
            // 
            login_button.BackColor = Color.FromArgb(18, 18, 18);
            login_button.ForeColor = Color.White;
            login_button.Location = new Point(125, 331);
            login_button.Name = "login_button";
            login_button.Size = new Size(123, 48);
            login_button.TabIndex = 7;
            login_button.Text = "Login";
            login_button.UseVisualStyleBackColor = false;
            login_button.Click += login_button_Click;
            // 
            // show_pass_checkbox
            // 
            show_pass_checkbox.AutoSize = true;
            show_pass_checkbox.ForeColor = Color.Black;
            show_pass_checkbox.Location = new Point(21, 264);
            show_pass_checkbox.Name = "show_pass_checkbox";
            show_pass_checkbox.Size = new Size(132, 24);
            show_pass_checkbox.TabIndex = 5;
            show_pass_checkbox.Text = "Show Password";
            show_pass_checkbox.UseVisualStyleBackColor = true;
            show_pass_checkbox.CheckedChanged += show_pass_checkbox_CheckedChanged;
            // 
            // pass_field
            // 
            pass_field.BackColor = Color.WhiteSmoke;
            pass_field.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pass_field.ForeColor = Color.Black;
            pass_field.Location = new Point(21, 215);
            pass_field.Name = "pass_field";
            pass_field.Size = new Size(336, 34);
            pass_field.TabIndex = 4;
            pass_field.UseSystemPasswordChar = true;
            // 
            // user_field
            // 
            user_field.BackColor = Color.WhiteSmoke;
            user_field.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            user_field.ForeColor = Color.Black;
            user_field.Location = new Point(21, 128);
            user_field.Name = "user_field";
            user_field.Size = new Size(336, 34);
            user_field.TabIndex = 3;
            // 
            // pass_label
            // 
            pass_label.AutoSize = true;
            pass_label.Font = new Font("Segoe UI", 15F);
            pass_label.ForeColor = Color.Black;
            pass_label.Location = new Point(21, 177);
            pass_label.Name = "pass_label";
            pass_label.Size = new Size(125, 35);
            pass_label.TabIndex = 2;
            pass_label.Text = "Password:";
            // 
            // user_label
            // 
            user_label.AutoSize = true;
            user_label.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            user_label.ForeColor = Color.Black;
            user_label.Location = new Point(21, 90);
            user_label.Name = "user_label";
            user_label.Size = new Size(132, 35);
            user_label.TabIndex = 1;
            user_label.Text = "Username:";
            // 
            // main_title
            // 
            main_title.AccessibleName = "main_heading";
            main_title.AutoSize = true;
            main_title.BackColor = Color.FromArgb(240, 84, 84);
            main_title.Font = new Font("Arial Rounded MT Bold", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            main_title.ForeColor = Color.Black;
            main_title.Location = new Point(61, 26);
            main_title.Name = "main_title";
            main_title.Size = new Size(258, 39);
            main_title.TabIndex = 0;
            main_title.Text = "Login Account";
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(939, 605);
            Controls.Add(lower_bg_panel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "login";
            lower_bg_panel.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            upper_bg_panel.ResumeLayout(false);
            upper_bg_panel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel lower_bg_panel;
        private Panel upper_bg_panel;
        private Label main_title;
        private TextBox user_field;
        private Label pass_label;
        private Label user_label;
        private TextBox pass_field;
        private CheckBox show_pass_checkbox;
        private Button login_button;
        private LinkLabel goto_signup_label;
        private ComboBox user_type;
        private PictureBox pictureBox1;
        private Panel panel1;
    }
}