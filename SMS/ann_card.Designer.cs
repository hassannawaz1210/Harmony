namespace SMS
{
    partial class ann_card
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
            profile_pic = new PictureBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            date_label = new Label();
            time_label = new Label();
            notification_label = new Label();
            ((System.ComponentModel.ISupportInitialize)profile_pic).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // profile_pic
            // 
            profile_pic.BackgroundImageLayout = ImageLayout.Stretch;
            profile_pic.Cursor = Cursors.Hand;
            profile_pic.Dock = DockStyle.Left;
            profile_pic.Location = new Point(10, 10);
            profile_pic.Name = "profile_pic";
            profile_pic.Size = new Size(73, 68);
            profile_pic.TabIndex = 0;
            profile_pic.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(date_label, 0, 2);
            tableLayoutPanel1.Controls.Add(time_label, 0, 1);
            tableLayoutPanel1.Controls.Add(notification_label, 0, 0);
            tableLayoutPanel1.Cursor = Cursors.Hand;
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(83, 10);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Size = new Size(774, 68);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // date_label
            // 
            date_label.AutoSize = true;
            date_label.ForeColor = Color.White;
            date_label.Location = new Point(3, 51);
            date_label.Name = "date_label";
            date_label.Size = new Size(50, 17);
            date_label.TabIndex = 2;
            date_label.Text = "label3";
            // 
            // time_label
            // 
            time_label.AutoSize = true;
            time_label.ForeColor = Color.White;
            time_label.Location = new Point(3, 34);
            time_label.Name = "time_label";
            time_label.Size = new Size(50, 17);
            time_label.TabIndex = 1;
            time_label.Text = "label2";
            // 
            // notification_label
            // 
            notification_label.AutoSize = true;
            notification_label.ForeColor = Color.White;
            notification_label.Location = new Point(3, 0);
            notification_label.Name = "notification_label";
            notification_label.Size = new Size(50, 20);
            notification_label.TabIndex = 0;
            notification_label.Text = "label1";
            // 
            // ann_card
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(18, 18, 18);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(profile_pic);
            Margin = new Padding(3, 3, 3, 15);
            Name = "ann_card";
            Padding = new Padding(10);
            Size = new Size(867, 88);
            ((System.ComponentModel.ISupportInitialize)profile_pic).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox profile_pic;
        private TableLayoutPanel tableLayoutPanel1;
        private Label date_label;
        private Label time_label;
        private Label notification_label;
    }
}
