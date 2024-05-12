namespace SMS
{
    partial class create_event
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
            close_button = new Button();
            desc_field = new TextBox();
            fee_field = new TextBox();
            sponsors_field = new TextBox();
            venue_field = new TextBox();
            time_field = new TextBox();
            date_field = new TextBox();
            name_field = new TextBox();
            submit_button = new Button();
            label1 = new Label();
            upload_button = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(close_button, 0, 9);
            tableLayoutPanel1.Controls.Add(desc_field, 0, 7);
            tableLayoutPanel1.Controls.Add(fee_field, 0, 5);
            tableLayoutPanel1.Controls.Add(sponsors_field, 0, 4);
            tableLayoutPanel1.Controls.Add(venue_field, 0, 3);
            tableLayoutPanel1.Controls.Add(time_field, 0, 2);
            tableLayoutPanel1.Controls.Add(date_field, 0, 1);
            tableLayoutPanel1.Controls.Add(name_field, 0, 0);
            tableLayoutPanel1.Controls.Add(submit_button, 0, 8);
            tableLayoutPanel1.Controls.Add(label1, 0, 6);
            tableLayoutPanel1.Controls.Add(upload_button, 1, 6);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(10, 10);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 10;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.641693F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.641693F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.641693F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.641693F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.641693F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.641693F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.641693F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 30.5667725F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 8.165097F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.776283F));
            tableLayoutPanel1.Size = new Size(398, 568);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // close_button
            // 
            close_button.BackColor = Color.FromArgb(240, 84, 84);
            tableLayoutPanel1.SetColumnSpan(close_button, 2);
            close_button.Dock = DockStyle.Fill;
            close_button.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            close_button.Location = new Point(4, 522);
            close_button.Name = "close_button";
            close_button.Size = new Size(390, 42);
            close_button.TabIndex = 9;
            close_button.Text = "Close";
            close_button.UseVisualStyleBackColor = false;
            close_button.Click += close_button_Click;
            // 
            // desc_field
            // 
            tableLayoutPanel1.SetColumnSpan(desc_field, 2);
            desc_field.Dock = DockStyle.Fill;
            desc_field.Font = new Font("Segoe UI", 10F);
            desc_field.Location = new Point(4, 305);
            desc_field.Multiline = true;
            desc_field.Name = "desc_field";
            desc_field.PlaceholderText = "Description";
            desc_field.Size = new Size(390, 164);
            desc_field.TabIndex = 7;
            // 
            // fee_field
            // 
            tableLayoutPanel1.SetColumnSpan(fee_field, 2);
            fee_field.Dock = DockStyle.Fill;
            fee_field.Font = new Font("Segoe UI", 10F);
            fee_field.Location = new Point(4, 219);
            fee_field.Multiline = true;
            fee_field.Name = "fee_field";
            fee_field.PlaceholderText = "Registration fee";
            fee_field.Size = new Size(390, 36);
            fee_field.TabIndex = 5;
            // 
            // sponsors_field
            // 
            tableLayoutPanel1.SetColumnSpan(sponsors_field, 2);
            sponsors_field.Dock = DockStyle.Fill;
            sponsors_field.Font = new Font("Segoe UI", 10F);
            sponsors_field.Location = new Point(4, 176);
            sponsors_field.Multiline = true;
            sponsors_field.Name = "sponsors_field";
            sponsors_field.PlaceholderText = "Sponsors";
            sponsors_field.Size = new Size(390, 36);
            sponsors_field.TabIndex = 4;
            // 
            // venue_field
            // 
            tableLayoutPanel1.SetColumnSpan(venue_field, 2);
            venue_field.Dock = DockStyle.Fill;
            venue_field.Font = new Font("Segoe UI", 10F);
            venue_field.Location = new Point(4, 133);
            venue_field.Multiline = true;
            venue_field.Name = "venue_field";
            venue_field.PlaceholderText = "Venue";
            venue_field.Size = new Size(390, 36);
            venue_field.TabIndex = 3;
            // 
            // time_field
            // 
            tableLayoutPanel1.SetColumnSpan(time_field, 2);
            time_field.Dock = DockStyle.Fill;
            time_field.Font = new Font("Segoe UI", 10F);
            time_field.Location = new Point(4, 90);
            time_field.Multiline = true;
            time_field.Name = "time_field";
            time_field.PlaceholderText = "Timing";
            time_field.Size = new Size(390, 36);
            time_field.TabIndex = 2;
            // 
            // date_field
            // 
            tableLayoutPanel1.SetColumnSpan(date_field, 2);
            date_field.Dock = DockStyle.Fill;
            date_field.Font = new Font("Segoe UI", 10F);
            date_field.Location = new Point(4, 47);
            date_field.Multiline = true;
            date_field.Name = "date_field";
            date_field.PlaceholderText = "Date";
            date_field.Size = new Size(390, 36);
            date_field.TabIndex = 1;
            // 
            // name_field
            // 
            tableLayoutPanel1.SetColumnSpan(name_field, 2);
            name_field.Dock = DockStyle.Fill;
            name_field.Font = new Font("Segoe UI", 10F);
            name_field.Location = new Point(4, 4);
            name_field.Multiline = true;
            name_field.Name = "name_field";
            name_field.PlaceholderText = "Name";
            name_field.Size = new Size(390, 36);
            name_field.TabIndex = 0;
            // 
            // submit_button
            // 
            submit_button.BackColor = Color.FromArgb(240, 84, 84);
            tableLayoutPanel1.SetColumnSpan(submit_button, 2);
            submit_button.Dock = DockStyle.Fill;
            submit_button.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            submit_button.Location = new Point(4, 476);
            submit_button.Name = "submit_button";
            submit_button.Size = new Size(390, 39);
            submit_button.TabIndex = 8;
            submit_button.Text = "Submit";
            submit_button.UseVisualStyleBackColor = false;
            submit_button.Click += submit_button_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(4, 259);
            label1.Name = "label1";
            label1.Padding = new Padding(15, 10, 0, 0);
            label1.Size = new Size(129, 33);
            label1.TabIndex = 10;
            label1.Text = "Upload logo:";
            // 
            // upload_button
            // 
            upload_button.BackColor = Color.FromArgb(240, 84, 84);
            upload_button.Dock = DockStyle.Fill;
            upload_button.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            upload_button.Location = new Point(202, 262);
            upload_button.Name = "upload_button";
            upload_button.Size = new Size(192, 36);
            upload_button.TabIndex = 11;
            upload_button.Text = "upload";
            upload_button.UseVisualStyleBackColor = false;
            upload_button.Click += upload_button_Click;
            // 
            // create_event
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(18, 18, 18);
            ClientSize = new Size(418, 588);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "create_event";
            Padding = new Padding(10);
            StartPosition = FormStartPosition.CenterParent;
            Text = "create_event";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button close_button;
        private TextBox desc_field;
        private TextBox fee_field;
        private TextBox sponsors_field;
        private TextBox venue_field;
        private TextBox time_field;
        private TextBox date_field;
        private TextBox name_field;
        private Button submit_button;
        private Label label1;
        private Button upload_button;
    }
}