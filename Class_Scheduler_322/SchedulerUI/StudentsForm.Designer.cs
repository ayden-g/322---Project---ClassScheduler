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
            pictureBox2 = new PictureBox();
            studentScheduleBtn = new Button();
            txtUser = new TextBox();
            closeBtn = new Panel();
            enrollBtn = new Button();
            removeCourseFromSched = new Button();
            studentCatalogBtn = new Button();
            panel2 = new Panel();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            p5 = new Panel();
            label1 = new Label();
            searchPanel = new FlowLayoutPanel();
            panel3 = new Panel();
            button3 = new Button();
            panel4 = new Panel();
            studentSearch = new TextBox();
            schedulePanel = new Panel();
            p1 = new Panel();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            closeBtn.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            p5.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            p1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(12, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(124, 114);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // studentScheduleBtn
            // 
            studentScheduleBtn.BackColor = Color.Firebrick;
            studentScheduleBtn.FlatStyle = FlatStyle.Flat;
            studentScheduleBtn.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            studentScheduleBtn.ForeColor = Color.WhiteSmoke;
            studentScheduleBtn.Location = new Point(12, 175);
            studentScheduleBtn.Name = "studentScheduleBtn";
            studentScheduleBtn.Size = new Size(124, 49);
            studentScheduleBtn.TabIndex = 2;
            studentScheduleBtn.Text = "Schedule";
            studentScheduleBtn.UseVisualStyleBackColor = false;
            studentScheduleBtn.Click += studentScheduleBtn_Click;
            // 
            // txtUser
            // 
            txtUser.BackColor = Color.Firebrick;
            txtUser.Enabled = false;
            txtUser.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtUser.ForeColor = Color.WhiteSmoke;
            txtUser.Location = new Point(12, 131);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(124, 29);
            txtUser.TabIndex = 1;
            txtUser.Text = "USER";
            txtUser.TextAlign = HorizontalAlignment.Center;
            // 
            // closeBtn
            // 
            closeBtn.BackColor = Color.FromArgb(30, 30, 30);
            closeBtn.Controls.Add(enrollBtn);
            closeBtn.Controls.Add(removeCourseFromSched);
            closeBtn.Controls.Add(studentCatalogBtn);
            closeBtn.Controls.Add(studentScheduleBtn);
            closeBtn.Controls.Add(panel2);
            closeBtn.Dock = DockStyle.Left;
            closeBtn.ForeColor = SystemColors.ControlText;
            closeBtn.Location = new Point(0, 0);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(151, 600);
            closeBtn.TabIndex = 5;
            // 
            // enrollBtn
            // 
            enrollBtn.BackColor = Color.Firebrick;
            enrollBtn.FlatStyle = FlatStyle.Flat;
            enrollBtn.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            enrollBtn.ForeColor = Color.WhiteSmoke;
            enrollBtn.Location = new Point(12, 340);
            enrollBtn.Name = "enrollBtn";
            enrollBtn.Size = new Size(124, 49);
            enrollBtn.TabIndex = 6;
            enrollBtn.Text = "Enroll";
            enrollBtn.UseVisualStyleBackColor = false;
            enrollBtn.Click += enrollBtn_Click;
            // 
            // removeCourseFromSched
            // 
            removeCourseFromSched.BackColor = Color.Firebrick;
            removeCourseFromSched.FlatStyle = FlatStyle.Flat;
            removeCourseFromSched.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            removeCourseFromSched.ForeColor = Color.WhiteSmoke;
            removeCourseFromSched.Location = new Point(12, 285);
            removeCourseFromSched.Name = "removeCourseFromSched";
            removeCourseFromSched.Size = new Size(124, 49);
            removeCourseFromSched.TabIndex = 5;
            removeCourseFromSched.Text = "Drop";
            removeCourseFromSched.UseVisualStyleBackColor = false;
            removeCourseFromSched.Click += removeCourseFromSched_Click;
            // 
            // studentCatalogBtn
            // 
            studentCatalogBtn.BackColor = Color.Firebrick;
            studentCatalogBtn.FlatStyle = FlatStyle.Flat;
            studentCatalogBtn.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            studentCatalogBtn.ForeColor = Color.WhiteSmoke;
            studentCatalogBtn.Location = new Point(12, 230);
            studentCatalogBtn.Name = "studentCatalogBtn";
            studentCatalogBtn.Size = new Size(124, 49);
            studentCatalogBtn.TabIndex = 3;
            studentCatalogBtn.Text = "Catalog";
            studentCatalogBtn.UseVisualStyleBackColor = false;
            studentCatalogBtn.Click += studentCatalogBtn_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(txtUser);
            panel2.Controls.Add(pictureBox2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(151, 169);
            panel2.TabIndex = 0;
            // 
            // button2
            // 
            button2.BackColor = Color.Firebrick;
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.WhiteSmoke;
            button2.Location = new Point(943, -73);
            button2.Name = "button2";
            button2.Size = new Size(30, 30);
            button2.TabIndex = 6;
            button2.Text = "X";
            button2.TextAlign = ContentAlignment.TopCenter;
            button2.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.WhiteSmoke;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-108, -296);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1200, 1152);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Firebrick;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.WhiteSmoke;
            button1.Location = new Point(966, 3);
            button1.Name = "button1";
            button1.Size = new Size(30, 30);
            button1.TabIndex = 8;
            button1.Text = "X";
            button1.TextAlign = ContentAlignment.TopCenter;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // p5
            // 
            p5.BackColor = Color.Firebrick;
            p5.Controls.Add(label1);
            p5.Location = new Point(169, 15);
            p5.Name = "p5";
            p5.Size = new Size(670, 76);
            p5.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(3, 15);
            label1.Name = "label1";
            label1.Size = new Size(247, 45);
            label1.TabIndex = 0;
            label1.Text = "Course Catalog";
            // 
            // searchPanel
            // 
            searchPanel.AutoScroll = true;
            searchPanel.Location = new Point(168, 91);
            searchPanel.Name = "searchPanel";
            searchPanel.Size = new Size(670, 0);
            searchPanel.TabIndex = 11;
            // 
            // panel3
            // 
            panel3.Controls.Add(button3);
            panel3.Controls.Add(panel4);
            panel3.Location = new Point(168, 12);
            panel3.Name = "panel3";
            panel3.Size = new Size(670, 79);
            panel3.TabIndex = 10;
            // 
            // button3
            // 
            button3.BackColor = Color.Firebrick;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.WhiteSmoke;
            button3.Location = new Point(614, 18);
            button3.Name = "button3";
            button3.Size = new Size(51, 40);
            button3.TabIndex = 1;
            button3.Text = ">>>";
            button3.TextAlign = ContentAlignment.BottomCenter;
            button3.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.Window;
            panel4.Controls.Add(studentSearch);
            panel4.Location = new Point(13, 18);
            panel4.Name = "panel4";
            panel4.Size = new Size(595, 40);
            panel4.TabIndex = 2;
            // 
            // studentSearch
            // 
            studentSearch.BorderStyle = BorderStyle.None;
            studentSearch.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            studentSearch.ForeColor = SystemColors.ControlDarkDark;
            studentSearch.Location = new Point(3, 8);
            studentSearch.Name = "studentSearch";
            studentSearch.PlaceholderText = "Search Course";
            studentSearch.Size = new Size(592, 22);
            studentSearch.TabIndex = 0;
            studentSearch.TextChanged += studentSearch_TextChanged;
            // 
            // schedulePanel
            // 
            schedulePanel.Location = new Point(168, 97);
            schedulePanel.Name = "schedulePanel";
            schedulePanel.Size = new Size(671, 491);
            schedulePanel.TabIndex = 4;
            // 
            // p1
            // 
            p1.BackColor = Color.Firebrick;
            p1.Controls.Add(label2);
            p1.Location = new Point(169, 15);
            p1.Name = "p1";
            p1.Size = new Size(670, 76);
            p1.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.FlatStyle = FlatStyle.Popup;
            label2.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(3, 15);
            label2.Name = "label2";
            label2.Size = new Size(231, 45);
            label2.TabIndex = 0;
            label2.Text = "Your Schedule";
            // 
            // StudentsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 600);
            Controls.Add(p1);
            Controls.Add(schedulePanel);
            Controls.Add(searchPanel);
            Controls.Add(button1);
            Controls.Add(closeBtn);
            Controls.Add(button2);
            Controls.Add(p5);
            Controls.Add(panel3);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "StudentsForm";
            Text = "StudentsForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            closeBtn.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            p5.ResumeLayout(false);
            p5.PerformLayout();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            p1.ResumeLayout(false);
            p1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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