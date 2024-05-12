namespace SMS
{
    partial class edit_profile
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
            tableLayoutPanel1 = new TableLayoutPanel();
            cancel_button = new Button();
            bio_field = new TextBox();
            dept_field = new TextBox();
            batch_field = new TextBox();
            roll_field = new TextBox();
            email_field = new TextBox();
            phone_field = new TextBox();
            name_field = new TextBox();
            pass_field = new TextBox();
            username_field = new TextBox();
            save_button = new Button();
            label1 = new Label();
            upload_button = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(18, 18, 18);
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(cancel_button, 1, 10);
            tableLayoutPanel1.Controls.Add(bio_field, 0, 8);
            tableLayoutPanel1.Controls.Add(dept_field, 0, 7);
            tableLayoutPanel1.Controls.Add(batch_field, 0, 6);
            tableLayoutPanel1.Controls.Add(roll_field, 0, 5);
            tableLayoutPanel1.Controls.Add(email_field, 0, 4);
            tableLayoutPanel1.Controls.Add(phone_field, 0, 3);
            tableLayoutPanel1.Controls.Add(name_field, 0, 2);
            tableLayoutPanel1.Controls.Add(pass_field, 0, 1);
            tableLayoutPanel1.Controls.Add(username_field, 0, 0);
            tableLayoutPanel1.Controls.Add(save_button, 0, 10);
            tableLayoutPanel1.Controls.Add(label1, 0, 9);
            tableLayoutPanel1.Controls.Add(upload_button, 1, 9);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(10, 10);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(10);
            tableLayoutPanel1.RowCount = 11;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 8.41064F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 8.41064F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 8.41064F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 8.41064F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 8.41064F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 8.41064F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 8.41064F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 8.41064F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15.8961086F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 8.40813351F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 8.41064F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(455, 612);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // cancel_button
            // 
            cancel_button.BackColor = Color.FromArgb(240, 84, 84);
            cancel_button.Dock = DockStyle.Fill;
            cancel_button.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            cancel_button.Location = new Point(230, 548);
            cancel_button.Name = "cancel_button";
            cancel_button.Size = new Size(212, 51);
            cancel_button.TabIndex = 10;
            cancel_button.Text = "Cancel";
            cancel_button.UseVisualStyleBackColor = false;
            cancel_button.Click += cancel_button_Click;
            // 
            // bio_field
            // 
            tableLayoutPanel1.SetColumnSpan(bio_field, 2);
            bio_field.Dock = DockStyle.Fill;
            bio_field.Font = new Font("Segoe UI", 12F);
            bio_field.Location = new Point(13, 405);
            bio_field.Multiline = true;
            bio_field.Name = "bio_field";
            bio_field.PlaceholderText = "Bio";
            bio_field.Size = new Size(429, 88);
            bio_field.TabIndex = 8;
            // 
            // dept_field
            // 
            tableLayoutPanel1.SetColumnSpan(dept_field, 2);
            dept_field.Dock = DockStyle.Fill;
            dept_field.Font = new Font("Segoe UI", 10.8F);
            dept_field.Location = new Point(13, 356);
            dept_field.Multiline = true;
            dept_field.Name = "dept_field";
            dept_field.PlaceholderText = "Department";
            dept_field.Size = new Size(429, 43);
            dept_field.TabIndex = 7;
            // 
            // batch_field
            // 
            tableLayoutPanel1.SetColumnSpan(batch_field, 2);
            batch_field.Dock = DockStyle.Fill;
            batch_field.Font = new Font("Segoe UI", 10.8F);
            batch_field.Location = new Point(13, 307);
            batch_field.Multiline = true;
            batch_field.Name = "batch_field";
            batch_field.PlaceholderText = "Batch";
            batch_field.Size = new Size(429, 43);
            batch_field.TabIndex = 6;
            // 
            // roll_field
            // 
            tableLayoutPanel1.SetColumnSpan(roll_field, 2);
            roll_field.Dock = DockStyle.Fill;
            roll_field.Font = new Font("Segoe UI", 10.8F);
            roll_field.Location = new Point(13, 258);
            roll_field.Multiline = true;
            roll_field.Name = "roll_field";
            roll_field.PlaceholderText = "Roll Number";
            roll_field.Size = new Size(429, 43);
            roll_field.TabIndex = 5;
            // 
            // email_field
            // 
            tableLayoutPanel1.SetColumnSpan(email_field, 2);
            email_field.Dock = DockStyle.Fill;
            email_field.Font = new Font("Segoe UI", 10.8F);
            email_field.Location = new Point(13, 209);
            email_field.Multiline = true;
            email_field.Name = "email_field";
            email_field.PlaceholderText = "Email";
            email_field.Size = new Size(429, 43);
            email_field.TabIndex = 4;
            // 
            // phone_field
            // 
            tableLayoutPanel1.SetColumnSpan(phone_field, 2);
            phone_field.Dock = DockStyle.Fill;
            phone_field.Font = new Font("Segoe UI", 10.8F);
            phone_field.Location = new Point(13, 160);
            phone_field.Multiline = true;
            phone_field.Name = "phone_field";
            phone_field.PlaceholderText = "Phone number";
            phone_field.Size = new Size(429, 43);
            phone_field.TabIndex = 3;
            // 
            // name_field
            // 
            tableLayoutPanel1.SetColumnSpan(name_field, 2);
            name_field.Dock = DockStyle.Fill;
            name_field.Font = new Font("Segoe UI", 10.8F);
            name_field.Location = new Point(13, 111);
            name_field.Multiline = true;
            name_field.Name = "name_field";
            name_field.PlaceholderText = "Name";
            name_field.Size = new Size(429, 43);
            name_field.TabIndex = 2;
            // 
            // pass_field
            // 
            tableLayoutPanel1.SetColumnSpan(pass_field, 2);
            pass_field.Dock = DockStyle.Fill;
            pass_field.Font = new Font("Segoe UI", 10.8F);
            pass_field.Location = new Point(13, 62);
            pass_field.Multiline = true;
            pass_field.Name = "pass_field";
            pass_field.PlaceholderText = "Password";
            pass_field.Size = new Size(429, 43);
            pass_field.TabIndex = 1;
            // 
            // username_field
            // 
            username_field.BorderStyle = BorderStyle.None;
            tableLayoutPanel1.SetColumnSpan(username_field, 2);
            username_field.Dock = DockStyle.Fill;
            username_field.Font = new Font("Segoe UI", 10.8F);
            username_field.Location = new Point(13, 13);
            username_field.Multiline = true;
            username_field.Name = "username_field";
            username_field.PlaceholderText = "Username";
            username_field.Size = new Size(429, 43);
            username_field.TabIndex = 0;
            // 
            // save_button
            // 
            save_button.BackColor = Color.FromArgb(240, 84, 84);
            save_button.Dock = DockStyle.Fill;
            save_button.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            save_button.Location = new Point(13, 548);
            save_button.Name = "save_button";
            save_button.Size = new Size(211, 51);
            save_button.TabIndex = 9;
            save_button.Text = "Save";
            save_button.UseVisualStyleBackColor = false;
            save_button.Click += save_button_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(13, 496);
            label1.Name = "label1";
            label1.Padding = new Padding(0, 10, 0, 0);
            label1.Size = new Size(96, 33);
            label1.TabIndex = 11;
            label1.Text = "Profile Pic:";
            // 
            // upload_button
            // 
            upload_button.BackColor = Color.FromArgb(240, 84, 84);
            upload_button.Dock = DockStyle.Fill;
            upload_button.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            upload_button.Location = new Point(230, 499);
            upload_button.Name = "upload_button";
            upload_button.Size = new Size(212, 43);
            upload_button.TabIndex = 12;
            upload_button.Text = "Upload";
            upload_button.UseVisualStyleBackColor = false;
            upload_button.Click += upload_button_Click;
            // 
            // edit_profile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 84, 84);
            ClientSize = new Size(475, 632);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "edit_profile";
            Padding = new Padding(10);
            Text = "edit_profile";
            Load += on_load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TextBox phone_field;
        private TextBox name_field;
        private TextBox pass_field;
        private TextBox username_field;
        private TextBox dept_field;
        private TextBox batch_field;
        private TextBox roll_field;
        private TextBox email_field;
        private TextBox bio_field;
        private Button cancel_button;
        private Button save_button;
        private Label label1;
        private Button upload_button;
    }
}