namespace SMS
{
    partial class make_ann
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
            label1 = new Label();
            label2 = new Label();
            subject_field = new TextBox();
            message_field = new TextBox();
            announce_button = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(18, 18, 18);
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(subject_field, 1, 0);
            tableLayoutPanel1.Controls.Add(message_field, 1, 1);
            tableLayoutPanel1.Controls.Add(announce_button, 1, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.ForeColor = Color.White;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.88023949F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 80.2395248F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.88023949F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(4, 1);
            label1.Name = "label1";
            label1.Size = new Size(95, 31);
            label1.TabIndex = 0;
            label1.Text = "Subject:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(4, 46);
            label2.Name = "label2";
            label2.Size = new Size(113, 32);
            label2.TabIndex = 1;
            label2.Text = "Message:";
            // 
            // subject_field
            // 
            subject_field.Dock = DockStyle.Fill;
            subject_field.Location = new Point(155, 4);
            subject_field.Multiline = true;
            subject_field.Name = "subject_field";
            subject_field.Size = new Size(641, 38);
            subject_field.TabIndex = 2;
            // 
            // message_field
            // 
            message_field.Dock = DockStyle.Fill;
            message_field.Location = new Point(155, 49);
            message_field.Multiline = true;
            message_field.Name = "message_field";
            message_field.Size = new Size(641, 351);
            message_field.TabIndex = 3;
            // 
            // announce_button
            // 
            announce_button.BackColor = Color.FromArgb(240, 84, 84);
            announce_button.Dock = DockStyle.Fill;
            announce_button.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            announce_button.ForeColor = Color.Black;
            announce_button.Location = new Point(155, 407);
            announce_button.Name = "announce_button";
            announce_button.Size = new Size(641, 39);
            announce_button.TabIndex = 4;
            announce_button.Text = "Announce";
            announce_button.UseVisualStyleBackColor = false;
            announce_button.Click += ann_button_Click;
            // 
            // make_ann
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "make_ann";
            Text = "announcement";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private TextBox subject_field;
        private TextBox message_field;
        private Button announce_button;
    }
}