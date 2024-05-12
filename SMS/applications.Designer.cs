namespace SMS
{
    partial class applications
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
            no_pending_label = new Label();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(10, 10);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1062, 183);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // no_pending_label
            // 
            no_pending_label.Anchor = AnchorStyles.None;
            no_pending_label.AutoSize = true;
            no_pending_label.BackColor = SystemColors.Control;
            no_pending_label.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            no_pending_label.Location = new Point(404, 326);
            no_pending_label.Name = "no_pending_label";
            no_pending_label.Size = new Size(281, 31);
            no_pending_label.TabIndex = 1;
            no_pending_label.Text = "No Pending Applications";
            // 
            // applications
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1082, 687);
            Controls.Add(no_pending_label);
            Controls.Add(tableLayoutPanel1);
            Name = "applications";
            Padding = new Padding(10);
            Text = "applications";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label no_pending_label;
    }
}