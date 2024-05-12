namespace SMS
{
    partial class anns
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
            no_anns_label = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            SuspendLayout();
            // 
            // no_anns_label
            // 
            no_anns_label.Anchor = AnchorStyles.None;
            no_anns_label.AutoSize = true;
            no_anns_label.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            no_anns_label.Location = new Point(337, 345);
            no_anns_label.Name = "no_anns_label";
            no_anns_label.Size = new Size(319, 31);
            no_anns_label.TabIndex = 0;
            no_anns_label.Text = "No announcements to show.";
            no_anns_label.Click += label1_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Location = new Point(5, 6);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(10);
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(988, 99);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // anns
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(995, 718);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(no_anns_label);
            Name = "anns";
            Text = "anns";
            Load += on_load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label no_anns_label;
        private TableLayoutPanel tableLayoutPanel1;
    }
}