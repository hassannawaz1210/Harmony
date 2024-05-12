namespace SMS
{
    partial class events
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
            no_events_label = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // no_events_label
            // 
            no_events_label.Anchor = AnchorStyles.None;
            no_events_label.AutoSize = true;
            no_events_label.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            no_events_label.Location = new Point(360, 293);
            no_events_label.Name = "no_events_label";
            no_events_label.Size = new Size(268, 38);
            no_events_label.TabIndex = 0;
            no_events_label.Text = "No events to show.";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(10);
            flowLayoutPanel1.Size = new Size(982, 638);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // events
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(982, 638);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(no_events_label);
            Name = "events";
            Text = "events";
            Load += on_load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label no_events_label;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}