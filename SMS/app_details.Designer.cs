namespace SMS
{
    partial class app_details
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
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            reject_button = new Button();
            soc_logo = new PictureBox();
            soc_title = new Label();
            accept_button = new Button();
            panel2 = new Panel();
            panel3 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            label2 = new Label();
            soc_desc = new Label();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)soc_logo).BeginInit();
            panel2.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(10, 10);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(0, 0, 10, 10);
            panel1.Size = new Size(288, 581);
            panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(18, 18, 18);
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(reject_button, 0, 4);
            tableLayoutPanel1.Controls.Add(soc_logo, 0, 0);
            tableLayoutPanel1.Controls.Add(soc_title, 0, 1);
            tableLayoutPanel1.Controls.Add(accept_button, 0, 3);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(7);
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 82.1305847F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 17.8694172F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 9F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.Size = new Size(278, 405);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // reject_button
            // 
            reject_button.BackColor = Color.FromArgb(240, 84, 84);
            reject_button.Dock = DockStyle.Fill;
            reject_button.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            reject_button.Location = new Point(10, 350);
            reject_button.Name = "reject_button";
            reject_button.Size = new Size(258, 45);
            reject_button.TabIndex = 3;
            reject_button.Text = "Reject";
            reject_button.UseVisualStyleBackColor = false;
            reject_button.Click += reject_button_Click;
            // 
            // soc_logo
            // 
            soc_logo.BackgroundImageLayout = ImageLayout.Stretch;
            soc_logo.Dock = DockStyle.Fill;
            soc_logo.Location = new Point(10, 10);
            soc_logo.Name = "soc_logo";
            soc_logo.Size = new Size(258, 225);
            soc_logo.TabIndex = 0;
            soc_logo.TabStop = false;
            // 
            // soc_title
            // 
            soc_title.AutoSize = true;
            soc_title.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            soc_title.ForeColor = Color.White;
            soc_title.Location = new Point(10, 238);
            soc_title.Name = "soc_title";
            soc_title.Size = new Size(70, 28);
            soc_title.TabIndex = 1;
            soc_title.Text = "label1";
            // 
            // accept_button
            // 
            accept_button.BackColor = Color.FromArgb(240, 84, 84);
            accept_button.Dock = DockStyle.Fill;
            accept_button.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            accept_button.Location = new Point(10, 300);
            accept_button.Name = "accept_button";
            accept_button.Size = new Size(258, 44);
            accept_button.TabIndex = 2;
            accept_button.Text = "Accept";
            accept_button.UseVisualStyleBackColor = false;
            accept_button.Click += accept_button_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(tableLayoutPanel2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(298, 10);
            panel2.Name = "panel2";
            panel2.Size = new Size(768, 581);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 112);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(0, 10, 0, 0);
            panel3.Size = new Size(768, 469);
            panel3.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.FromArgb(18, 18, 18);
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(label2, 0, 0);
            tableLayoutPanel2.Controls.Add(soc_desc, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Top;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.Padding = new Padding(5);
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 30.3571434F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 69.64286F));
            tableLayoutPanel2.Size = new Size(768, 112);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(8, 5);
            label2.Name = "label2";
            label2.Size = new Size(93, 20);
            label2.TabIndex = 0;
            label2.Text = "Description:";
            // 
            // soc_desc
            // 
            soc_desc.AutoSize = true;
            soc_desc.ForeColor = Color.White;
            soc_desc.Location = new Point(8, 35);
            soc_desc.Name = "soc_desc";
            soc_desc.Size = new Size(50, 20);
            soc_desc.TabIndex = 1;
            soc_desc.Text = "label1";
            // 
            // app_details
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1076, 601);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "app_details";
            Padding = new Padding(10);
            Text = "app_details";
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)soc_logo).EndInit();
            panel2.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox soc_logo;
        private Label soc_title;
        private Panel panel2;
        private TableLayoutPanel tableLayoutPanel2;
        private Button accept_button;
        private Panel panel3;
        private Label label2;
        private Button reject_button;
        private Label soc_desc;
    }
}