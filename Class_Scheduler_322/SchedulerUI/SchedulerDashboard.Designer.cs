namespace StudentDash
{
    partial class SchedulerDashboard
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SchedulerDashboard));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.closeBtn = new System.Windows.Forms.Panel();
            this.scheduleBtn = new System.Windows.Forms.Button();
            this.accountBtn = new System.Windows.Forms.Button();
            this.catalogBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.searchText = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.searchPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.closeBtn.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-148, -231);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1200, 1152);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.closeBtn.Controls.Add(this.scheduleBtn);
            this.closeBtn.Controls.Add(this.accountBtn);
            this.closeBtn.Controls.Add(this.catalogBtn);
            this.closeBtn.Controls.Add(this.panel2);
            this.closeBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.closeBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.closeBtn.Location = new System.Drawing.Point(0, 0);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(151, 600);
            this.closeBtn.TabIndex = 1;
            // 
            // scheduleBtn
            // 
            this.scheduleBtn.BackColor = System.Drawing.Color.Firebrick;
            this.scheduleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.scheduleBtn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.scheduleBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.scheduleBtn.Location = new System.Drawing.Point(12, 539);
            this.scheduleBtn.Name = "scheduleBtn";
            this.scheduleBtn.Size = new System.Drawing.Size(124, 49);
            this.scheduleBtn.TabIndex = 3;
            this.scheduleBtn.Text = "Schedule";
            this.scheduleBtn.UseVisualStyleBackColor = false;
            // 
            // accountBtn
            // 
            this.accountBtn.BackColor = System.Drawing.Color.Firebrick;
            this.accountBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.accountBtn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.accountBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.accountBtn.Location = new System.Drawing.Point(12, 175);
            this.accountBtn.Name = "accountBtn";
            this.accountBtn.Size = new System.Drawing.Size(124, 49);
            this.accountBtn.TabIndex = 2;
            this.accountBtn.Text = "Account";
            this.accountBtn.UseVisualStyleBackColor = false;
            this.accountBtn.Click += new System.EventHandler(this.accountBtn_Click);
            // 
            // catalogBtn
            // 
            this.catalogBtn.BackColor = System.Drawing.Color.Firebrick;
            this.catalogBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.catalogBtn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.catalogBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.catalogBtn.Location = new System.Drawing.Point(12, 230);
            this.catalogBtn.Name = "catalogBtn";
            this.catalogBtn.Size = new System.Drawing.Size(124, 49);
            this.catalogBtn.TabIndex = 1;
            this.catalogBtn.Text = "Catalog";
            this.catalogBtn.UseVisualStyleBackColor = false;
            this.catalogBtn.Click += new System.EventHandler(this.catalogBtn_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtUser);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(151, 169);
            this.panel2.TabIndex = 0;
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.Color.Firebrick;
            this.txtUser.Enabled = false;
            this.txtUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtUser.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtUser.Location = new System.Drawing.Point(12, 131);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(124, 29);
            this.txtUser.TabIndex = 1;
            this.txtUser.Text = "USER";
            this.txtUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(124, 114);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Firebrick;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button2.Location = new System.Drawing.Point(966, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(30, 30);
            this.button2.TabIndex = 3;
            this.button2.Text = "X";
            this.button2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Window;
            this.panel4.Controls.Add(this.searchText);
            this.panel4.Location = new System.Drawing.Point(13, 18);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(595, 40);
            this.panel4.TabIndex = 2;
            // 
            // searchText
            // 
            this.searchText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.searchText.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.searchText.Location = new System.Drawing.Point(3, 8);
            this.searchText.Name = "searchText";
            this.searchText.PlaceholderText = "Search Course";
            this.searchText.Size = new System.Drawing.Size(592, 22);
            this.searchText.TabIndex = 0;
            this.searchText.TextChanged += new System.EventHandler(this.searchText_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Firebrick;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Location = new System.Drawing.Point(614, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = ">>>";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // searchPanel
            // 
            this.searchPanel.AutoScroll = true;
            this.searchPanel.Location = new System.Drawing.Point(157, 91);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Size = new System.Drawing.Size(670, 0);
            this.searchPanel.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(157, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(670, 79);
            this.panel3.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Firebrick;
            this.panel5.Controls.Add(this.label1);
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(670, 76);
            this.panel5.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(3, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Course Catalog";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Location = new System.Drawing.Point(157, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(670, 79);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // SchedulerDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.searchPanel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SchedulerDashboard";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.closeBtn.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Panel closeBtn;
        private Button catalogBtn;
        private Panel panel2;
        private TextBox txtUser;
        private PictureBox pictureBox2;
        private Button scheduleBtn;
        private Button accountBtn;
        private Button button2;
        private Panel panel4;
        private TextBox searchText;
        private Button button1;
        private FlowLayoutPanel searchPanel;
        private Panel panel3;
        private Panel panel5;
        private Label label1;
        private Panel panel1;
    }
}