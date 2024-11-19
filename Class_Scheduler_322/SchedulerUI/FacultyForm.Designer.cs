namespace SchedulerUI
{
    partial class FacultyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FacultyForm));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.closeBtn = new System.Windows.Forms.Panel();
            this.editCourseBtn = new System.Windows.Forms.Button();
            this.createCourseBtn = new System.Windows.Forms.Button();
            this.dashBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.myCourseBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.p1 = new System.Windows.Forms.Panel();
            this.l1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.myCoursePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.editPanel = new System.Windows.Forms.Panel();
            this.deleteCourseBtn = new System.Windows.Forms.Button();
            this.confirmEditBtn = new System.Windows.Forms.Button();
            this.cancleBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.editEnd = new System.Windows.Forms.TextBox();
            this.editDays = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.editStart = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.editSeating = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.editSection = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.editName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.editNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.closeBtn.SuspendLayout();
            this.panel2.SuspendLayout();
            this.p1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.editPanel.SuspendLayout();
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
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.closeBtn.Controls.Add(this.editCourseBtn);
            this.closeBtn.Controls.Add(this.createCourseBtn);
            this.closeBtn.Controls.Add(this.dashBtn);
            this.closeBtn.Controls.Add(this.panel2);
            this.closeBtn.Controls.Add(this.myCourseBtn);
            this.closeBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.closeBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.closeBtn.Location = new System.Drawing.Point(0, 0);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(151, 600);
            this.closeBtn.TabIndex = 5;
            // 
            // editCourseBtn
            // 
            this.editCourseBtn.BackColor = System.Drawing.Color.Firebrick;
            this.editCourseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editCourseBtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.editCourseBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.editCourseBtn.Location = new System.Drawing.Point(12, 392);
            this.editCourseBtn.Name = "editCourseBtn";
            this.editCourseBtn.Size = new System.Drawing.Size(124, 49);
            this.editCourseBtn.TabIndex = 3;
            this.editCourseBtn.Text = "Edit";
            this.editCourseBtn.UseVisualStyleBackColor = false;
            this.editCourseBtn.Click += new System.EventHandler(this.editCourseBtn_Click);
            // 
            // createCourseBtn
            // 
            this.createCourseBtn.BackColor = System.Drawing.Color.Firebrick;
            this.createCourseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createCourseBtn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.createCourseBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.createCourseBtn.Location = new System.Drawing.Point(13, 310);
            this.createCourseBtn.Name = "createCourseBtn";
            this.createCourseBtn.Size = new System.Drawing.Size(123, 76);
            this.createCourseBtn.TabIndex = 1;
            this.createCourseBtn.Text = "Create Course";
            this.createCourseBtn.UseVisualStyleBackColor = false;
            this.createCourseBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // dashBtn
            // 
            this.dashBtn.BackColor = System.Drawing.Color.Firebrick;
            this.dashBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashBtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dashBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.dashBtn.Location = new System.Drawing.Point(12, 175);
            this.dashBtn.Name = "dashBtn";
            this.dashBtn.Size = new System.Drawing.Size(124, 49);
            this.dashBtn.TabIndex = 2;
            this.dashBtn.Text = "Dashboard";
            this.dashBtn.UseVisualStyleBackColor = false;
            this.dashBtn.Click += new System.EventHandler(this.dashBtn_Click);
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
            // myCourseBtn
            // 
            this.myCourseBtn.BackColor = System.Drawing.Color.Firebrick;
            this.myCourseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.myCourseBtn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.myCourseBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.myCourseBtn.Location = new System.Drawing.Point(13, 230);
            this.myCourseBtn.Name = "myCourseBtn";
            this.myCourseBtn.Size = new System.Drawing.Size(123, 74);
            this.myCourseBtn.TabIndex = 3;
            this.myCourseBtn.Text = "My Courses";
            this.myCourseBtn.UseVisualStyleBackColor = false;
            this.myCourseBtn.Click += new System.EventHandler(this.myCourseBtn_Click);
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
            this.button2.TabIndex = 6;
            this.button2.Text = "X";
            this.button2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // p1
            // 
            this.p1.BackColor = System.Drawing.Color.Firebrick;
            this.p1.Controls.Add(this.l1);
            this.p1.Location = new System.Drawing.Point(157, 19);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(803, 78);
            this.p1.TabIndex = 0;
            // 
            // l1
            // 
            this.l1.AutoSize = true;
            this.l1.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.l1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.l1.Location = new System.Drawing.Point(12, 15);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(210, 47);
            this.l1.TabIndex = 0;
            this.l1.Text = "My Courses";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-81, -331);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1200, 1152);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // myCoursePanel
            // 
            this.myCoursePanel.AutoScroll = true;
            this.myCoursePanel.Location = new System.Drawing.Point(157, 97);
            this.myCoursePanel.Name = "myCoursePanel";
            this.myCoursePanel.Size = new System.Drawing.Size(670, 0);
            this.myCoursePanel.TabIndex = 7;
            // 
            // editPanel
            // 
            this.editPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.editPanel.Controls.Add(this.deleteCourseBtn);
            this.editPanel.Controls.Add(this.confirmEditBtn);
            this.editPanel.Controls.Add(this.cancleBtn);
            this.editPanel.Controls.Add(this.label6);
            this.editPanel.Controls.Add(this.editEnd);
            this.editPanel.Controls.Add(this.editDays);
            this.editPanel.Controls.Add(this.label8);
            this.editPanel.Controls.Add(this.editStart);
            this.editPanel.Controls.Add(this.label9);
            this.editPanel.Controls.Add(this.editSeating);
            this.editPanel.Controls.Add(this.label4);
            this.editPanel.Controls.Add(this.editSection);
            this.editPanel.Controls.Add(this.label5);
            this.editPanel.Controls.Add(this.editName);
            this.editPanel.Controls.Add(this.label3);
            this.editPanel.Controls.Add(this.editNumber);
            this.editPanel.Controls.Add(this.label2);
            this.editPanel.Location = new System.Drawing.Point(310, 103);
            this.editPanel.Name = "editPanel";
            this.editPanel.Size = new System.Drawing.Size(486, 485);
            this.editPanel.TabIndex = 4;
            // 
            // deleteCourseBtn
            // 
            this.deleteCourseBtn.BackColor = System.Drawing.Color.Firebrick;
            this.deleteCourseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteCourseBtn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deleteCourseBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.deleteCourseBtn.Location = new System.Drawing.Point(345, 424);
            this.deleteCourseBtn.Name = "deleteCourseBtn";
            this.deleteCourseBtn.Size = new System.Drawing.Size(124, 49);
            this.deleteCourseBtn.TabIndex = 31;
            this.deleteCourseBtn.Text = "Delete";
            this.deleteCourseBtn.UseVisualStyleBackColor = false;
            this.deleteCourseBtn.Click += new System.EventHandler(this.deleteCourseBtn_Click);
            // 
            // confirmEditBtn
            // 
            this.confirmEditBtn.BackColor = System.Drawing.Color.Firebrick;
            this.confirmEditBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirmEditBtn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.confirmEditBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.confirmEditBtn.Location = new System.Drawing.Point(345, 369);
            this.confirmEditBtn.Name = "confirmEditBtn";
            this.confirmEditBtn.Size = new System.Drawing.Size(124, 49);
            this.confirmEditBtn.TabIndex = 30;
            this.confirmEditBtn.Text = "Confirm";
            this.confirmEditBtn.UseVisualStyleBackColor = false;
            this.confirmEditBtn.Click += new System.EventHandler(this.confirmEditBtn_Click);
            // 
            // cancleBtn
            // 
            this.cancleBtn.BackColor = System.Drawing.Color.Firebrick;
            this.cancleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancleBtn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cancleBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cancleBtn.Location = new System.Drawing.Point(12, 424);
            this.cancleBtn.Name = "cancleBtn";
            this.cancleBtn.Size = new System.Drawing.Size(124, 49);
            this.cancleBtn.TabIndex = 29;
            this.cancleBtn.Text = "Cancle";
            this.cancleBtn.UseVisualStyleBackColor = false;
            this.cancleBtn.Click += new System.EventHandler(this.cancleBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label6.Location = new System.Drawing.Point(311, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 21);
            this.label6.TabIndex = 28;
            this.label6.Text = "--";
            // 
            // editEnd
            // 
            this.editEnd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.editEnd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.editEnd.Location = new System.Drawing.Point(339, 150);
            this.editEnd.Name = "editEnd";
            this.editEnd.PlaceholderText = "End Time";
            this.editEnd.Size = new System.Drawing.Size(130, 29);
            this.editEnd.TabIndex = 27;
            // 
            // editDays
            // 
            this.editDays.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.editDays.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.editDays.Location = new System.Drawing.Point(175, 185);
            this.editDays.Name = "editDays";
            this.editDays.PlaceholderText = "M, T, W, Th, F";
            this.editDays.Size = new System.Drawing.Size(130, 29);
            this.editDays.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label8.Location = new System.Drawing.Point(12, 188);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 21);
            this.label8.TabIndex = 25;
            this.label8.Text = "Meeting Days   ----";
            // 
            // editStart
            // 
            this.editStart.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.editStart.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.editStart.Location = new System.Drawing.Point(175, 150);
            this.editStart.Name = "editStart";
            this.editStart.PlaceholderText = "Start Time";
            this.editStart.Size = new System.Drawing.Size(130, 29);
            this.editStart.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label9.Location = new System.Drawing.Point(12, 153);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(155, 21);
            this.label9.TabIndex = 23;
            this.label9.Text = "Start/End Times----";
            // 
            // editSeating
            // 
            this.editSeating.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.editSeating.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.editSeating.Location = new System.Drawing.Point(175, 115);
            this.editSeating.Name = "editSeating";
            this.editSeating.PlaceholderText = "Course Size";
            this.editSeating.Size = new System.Drawing.Size(130, 29);
            this.editSeating.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label4.Location = new System.Drawing.Point(12, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 21);
            this.label4.TabIndex = 21;
            this.label4.Text = "Course Size        ----";
            // 
            // editSection
            // 
            this.editSection.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.editSection.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.editSection.Location = new System.Drawing.Point(175, 80);
            this.editSection.Name = "editSection";
            this.editSection.PlaceholderText = "Course Section";
            this.editSection.Size = new System.Drawing.Size(130, 29);
            this.editSection.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label5.Location = new System.Drawing.Point(12, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 21);
            this.label5.TabIndex = 19;
            this.label5.Text = "Course Section  ----";
            // 
            // editName
            // 
            this.editName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.editName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.editName.Location = new System.Drawing.Point(175, 45);
            this.editName.Name = "editName";
            this.editName.PlaceholderText = "Course Name";
            this.editName.Size = new System.Drawing.Size(130, 29);
            this.editName.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label3.Location = new System.Drawing.Point(12, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 21);
            this.label3.TabIndex = 17;
            this.label3.Text = "Course Name     ----";
            // 
            // editNumber
            // 
            this.editNumber.Enabled = false;
            this.editNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.editNumber.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.editNumber.Location = new System.Drawing.Point(175, 10);
            this.editNumber.Name = "editNumber";
            this.editNumber.PlaceholderText = "Course Number";
            this.editNumber.Size = new System.Drawing.Size(130, 29);
            this.editNumber.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(12, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 21);
            this.label2.TabIndex = 15;
            this.label2.Text = "Course Number ----";
            // 
            // FacultyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.editPanel);
            this.Controls.Add(this.myCoursePanel);
            this.Controls.Add(this.p1);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FacultyForm";
            this.Text = "FacultyForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.closeBtn.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.p1.ResumeLayout(false);
            this.p1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.editPanel.ResumeLayout(false);
            this.editPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox2;
        private Panel closeBtn;
        private Panel panel2;
        private TextBox txtUser;
        private Button button2;
        private Button myCourseBtn;
        private Button dashBtn;
        private Button createCourseBtn;
        private Panel p1;
        private Label l1;
        private PictureBox pictureBox1;
        private FlowLayoutPanel myCoursePanel;
        private Button editCourseBtn;
        private Panel editPanel;
        private Label label6;
        private TextBox editEnd;
        private TextBox editDays;
        private Label label8;
        private TextBox editStart;
        private Label label9;
        private TextBox editSeating;
        private Label label4;
        private TextBox editSection;
        private Label label5;
        private TextBox editName;
        private Label label3;
        private TextBox editNumber;
        private Label label2;
        private Button confirmEditBtn;
        private Button cancleBtn;
        private Button deleteCourseBtn;
    }
}