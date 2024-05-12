namespace SMS
{
    partial class ann_popup
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
            message_label = new Label();
            subject_label = new Label();
            message_laaabel = new Label();
            asd = new Label();
            label2 = new Label();
            label1 = new Label();
            close_button = new Button();
            ann_date_label = new Label();
            ann_time_label = new Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(18, 18, 18);
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28.87324F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 71.12676F));
            tableLayoutPanel1.Controls.Add(message_label, 1, 3);
            tableLayoutPanel1.Controls.Add(subject_label, 1, 2);
            tableLayoutPanel1.Controls.Add(message_laaabel, 0, 3);
            tableLayoutPanel1.Controls.Add(asd, 0, 2);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(close_button, 0, 4);
            tableLayoutPanel1.Controls.Add(ann_date_label, 1, 0);
            tableLayoutPanel1.Controls.Add(ann_time_label, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            tableLayoutPanel1.ForeColor = Color.White;
            tableLayoutPanel1.Location = new Point(10, 10);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(5);
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(427, 430);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // message_label
            // 
            message_label.AutoSize = true;
            message_label.Font = new Font("Segoe UI", 9F);
            message_label.Location = new Point(129, 173);
            message_label.Name = "message_label";
            message_label.Padding = new Padding(0, 10, 0, 0);
            message_label.Size = new Size(50, 30);
            message_label.TabIndex = 8;
            message_label.Text = "label6";
            // 
            // subject_label
            // 
            subject_label.AutoSize = true;
            subject_label.Font = new Font("Segoe UI", 9F);
            subject_label.Location = new Point(129, 90);
            subject_label.Name = "subject_label";
            subject_label.Padding = new Padding(0, 10, 0, 0);
            subject_label.Size = new Size(50, 30);
            subject_label.TabIndex = 7;
            subject_label.Text = "label6";
            // 
            // message_laaabel
            // 
            message_laaabel.AutoSize = true;
            message_laaabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            message_laaabel.ForeColor = Color.White;
            message_laaabel.Location = new Point(9, 173);
            message_laaabel.Name = "message_laaabel";
            message_laaabel.Padding = new Padding(0, 10, 0, 0);
            message_laaabel.Size = new Size(74, 30);
            message_laaabel.TabIndex = 3;
            message_laaabel.Text = "Message:";
            // 
            // asd
            // 
            asd.AutoSize = true;
            asd.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            asd.ForeColor = Color.White;
            asd.Location = new Point(9, 90);
            asd.Name = "asd";
            asd.Padding = new Padding(0, 10, 0, 0);
            asd.Size = new Size(60, 30);
            asd.TabIndex = 2;
            asd.Text = "Subject";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(9, 48);
            label2.Name = "label2";
            label2.Padding = new Padding(0, 10, 0, 0);
            label2.Size = new Size(48, 30);
            label2.TabIndex = 1;
            label2.Text = "Time:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(9, 6);
            label1.Name = "label1";
            label1.Padding = new Padding(0, 10, 0, 0);
            label1.Size = new Size(46, 30);
            label1.TabIndex = 0;
            label1.Text = "Date:";
            // 
            // close_button
            // 
            close_button.BackColor = Color.FromArgb(240, 84, 84);
            tableLayoutPanel1.SetColumnSpan(close_button, 2);
            close_button.Dock = DockStyle.Fill;
            close_button.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            close_button.Location = new Point(9, 384);
            close_button.Name = "close_button";
            close_button.Size = new Size(409, 37);
            close_button.TabIndex = 4;
            close_button.Text = "Close";
            close_button.UseVisualStyleBackColor = false;
            close_button.Click += close_button_Click;
            // 
            // ann_date_label
            // 
            ann_date_label.AutoSize = true;
            ann_date_label.Font = new Font("Segoe UI", 9F);
            ann_date_label.Location = new Point(129, 6);
            ann_date_label.Name = "ann_date_label";
            ann_date_label.Padding = new Padding(0, 10, 0, 0);
            ann_date_label.Size = new Size(50, 30);
            ann_date_label.TabIndex = 5;
            ann_date_label.Text = "label5";
            // 
            // ann_time_label
            // 
            ann_time_label.AutoSize = true;
            ann_time_label.Font = new Font("Segoe UI", 9F);
            ann_time_label.Location = new Point(129, 48);
            ann_time_label.Name = "ann_time_label";
            ann_time_label.Padding = new Padding(0, 10, 0, 0);
            ann_time_label.Size = new Size(50, 30);
            ann_time_label.TabIndex = 6;
            ann_time_label.Text = "label6";
            // 
            // ann_popup
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 84, 84);
            ClientSize = new Size(447, 450);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ann_popup";
            Padding = new Padding(10);
            StartPosition = FormStartPosition.CenterParent;
            Text = "ann_popup";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label message_laaabel;
        private Label asd;
        private Label label2;
        private Label label1;
        private Button close_button;
        private Label ann_date_label;
        private Label ann_time_label;
        private Label message_label;
        private Label subject_label;
    }
}