namespace SchedulerUI
{
    partial class StudentsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentsForm));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.studentScheduleBtn = new System.Windows.Forms.Button();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.closeBtn = new System.Windows.Forms.Panel();
            this.enrollBtn = new System.Windows.Forms.Button();
            this.removeCourseFromSched = new System.Windows.Forms.Button();
            this.studentCatalogBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.p5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.searchPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.studentSearch = new System.Windows.Forms.TextBox();
            this.schedulePanel = new System.Windows.Forms.Panel();
            this.p1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.closeBtn.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.p5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.p1.SuspendLayout();
            this.SuspendLayout();
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
            // studentScheduleBtn
            // 
            this.studentScheduleBtn.BackColor = System.Drawing.Color.Firebrick;
            this.studentScheduleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.studentScheduleBtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.studentScheduleBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.studentScheduleBtn.Location = new System.Drawing.Point(12, 175);
            this.studentScheduleBtn.Name = "studentScheduleBtn";
            this.studentScheduleBtn.Size = new System.Drawing.Size(124, 49);
            this.studentScheduleBtn.TabIndex = 2;
            this.studentScheduleBtn.Text = "Schedule";
            this.studentScheduleBtn.UseVisualStyleBackColor = false;
            this.studentScheduleBtn.Click += new System.EventHandler(this.studentScheduleBtn_Click);
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
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.closeBtn.Controls.Add(this.enrollBtn);
            this.closeBtn.Controls.Add(this.removeCourseFromSched);
            this.closeBtn.Controls.Add(this.studentCatalogBtn);
            this.closeBtn.Controls.Add(this.studentScheduleBtn);
            this.closeBtn.Controls.Add(this.panel2);
            this.closeBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.closeBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.closeBtn.Location = new System.Drawing.Point(0, 0);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(151, 600);
            this.closeBtn.TabIndex = 5;
            // 
            // enrollBtn
            // 
            this.enrollBtn.BackColor = System.Drawing.Color.Firebrick;
            this.enrollBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enrollBtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.enrollBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.enrollBtn.Location = new System.Drawing.Point(12, 340);
            this.enrollBtn.Name = "enrollBtn";
            this.enrollBtn.Size = new System.Drawing.Size(124, 49);
            this.enrollBtn.TabIndex = 6;
            this.enrollBtn.Text = "Enroll";
            this.enrollBtn.UseVisualStyleBackColor = false;
            this.enrollBtn.Click += new System.EventHandler(this.enrollBtn_Click);
            // 
            // removeCourseFromSched
            // 
            this.removeCourseFromSched.BackColor = System.Drawing.Color.Firebrick;
            this.removeCourseFromSched.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeCourseFromSched.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.removeCourseFromSched.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.removeCourseFromSched.Location = new System.Drawing.Point(12, 285);
            this.removeCourseFromSched.Name = "removeCourseFromSched";
            this.removeCourseFromSched.Size = new System.Drawing.Size(124, 49);
            this.removeCourseFromSched.TabIndex = 5;
            this.removeCourseFromSched.Text = "Drop";
            this.removeCourseFromSched.UseVisualStyleBackColor = false;
            this.removeCourseFromSched.Click += new System.EventHandler(this.removeCourseFromSched_Click);
            // 
            // studentCatalogBtn
            // 
            this.studentCatalogBtn.BackColor = System.Drawing.Color.Firebrick;
            this.studentCatalogBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.studentCatalogBtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.studentCatalogBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.studentCatalogBtn.Location = new System.Drawing.Point(12, 230);
            this.studentCatalogBtn.Name = "studentCatalogBtn";
            this.studentCatalogBtn.Size = new System.Drawing.Size(124, 49);
            this.studentCatalogBtn.TabIndex = 3;
            this.studentCatalogBtn.Text = "Catalog";
            this.studentCatalogBtn.UseVisualStyleBackColor = false;
            this.studentCatalogBtn.Click += new System.EventHandler(this.studentCatalogBtn_Click);
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
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Firebrick;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button2.Location = new System.Drawing.Point(943, -73);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(30, 30);
            this.button2.TabIndex = 6;
            this.button2.Text = "X";
            this.button2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-108, -296);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1200, 1152);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Firebrick;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Location = new System.Drawing.Point(966, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 30);
            this.button1.TabIndex = 8;
            this.button1.Text = "X";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // p5
            // 
            this.p5.BackColor = System.Drawing.Color.Firebrick;
            this.p5.Controls.Add(this.label1);
            this.p5.Location = new System.Drawing.Point(169, 15);
            this.p5.Name = "p5";
            this.p5.Size = new System.Drawing.Size(670, 76);
            this.p5.TabIndex = 9;
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
            // searchPanel
            // 
            this.searchPanel.AutoScroll = true;
            this.searchPanel.Location = new System.Drawing.Point(168, 91);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Size = new System.Drawing.Size(670, 0);
            this.searchPanel.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(168, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(670, 79);
            this.panel3.TabIndex = 10;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Firebrick;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button3.Location = new System.Drawing.Point(614, 18);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(51, 40);
            this.button3.TabIndex = 1;
            this.button3.Text = ">>>";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Window;
            this.panel4.Controls.Add(this.studentSearch);
            this.panel4.Location = new System.Drawing.Point(13, 18);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(595, 40);
            this.panel4.TabIndex = 2;
            // 
            // studentSearch
            // 
            this.studentSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.studentSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.studentSearch.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.studentSearch.Location = new System.Drawing.Point(3, 8);
            this.studentSearch.Name = "studentSearch";
            this.studentSearch.PlaceholderText = "Search Course";
            this.studentSearch.Size = new System.Drawing.Size(592, 22);
            this.studentSearch.TabIndex = 0;
            this.studentSearch.TextChanged += new System.EventHandler(this.studentSearch_TextChanged);
            // 
            // schedulePanel
            // 
            this.schedulePanel.Location = new System.Drawing.Point(168, 97);
            this.schedulePanel.Name = "schedulePanel";
            this.schedulePanel.Size = new System.Drawing.Size(671, 491);
            this.schedulePanel.TabIndex = 4;
            // 
            // p1
            // 
            this.p1.BackColor = System.Drawing.Color.Firebrick;
            this.p1.Controls.Add(this.label2);
            this.p1.Location = new System.Drawing.Point(169, 15);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(670, 76);
            this.p1.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(3, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 45);
            this.label2.TabIndex = 0;
            this.label2.Text = "Your Schedule";
            // 
            // StudentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.p1);
            this.Controls.Add(this.schedulePanel);
            this.Controls.Add(this.searchPanel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.p5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudentsForm";
            this.Text = "StudentsForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.closeBtn.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.p5.ResumeLayout(false);
            this.p5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.p1.ResumeLayout(false);
            this.p1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox2;
        private Button studentScheduleBtn;
        private TextBox txtUser;
        private Panel closeBtn;
        private Button studentCatalogBtn;
        private Panel panel2;
        private Button button2;
        private PictureBox pictureBox1;
        private Button button1;
        private Panel p5;
        private Label label1;
        private FlowLayoutPanel searchPanel;
        private Panel panel3;
        private Button button3;
        private Panel panel4;
        private TextBox studentSearch;
        private Panel schedulePanel;
        private Panel p1;
        private Label label2;
        private Button removeCourseFromSched;
        private Button enrollBtn;
    }
}