namespace SchedulerUI
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.closeBtn = new System.Windows.Forms.Panel();
            this.deleteAnything = new System.Windows.Forms.Button();
            this.editAnything = new System.Windows.Forms.Button();
            this.Students = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.Courses = new System.Windows.Forms.Button();
            this.Faculty = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.searchPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.displayPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.closeBtn.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.closeBtn.Controls.Add(this.deleteAnything);
            this.closeBtn.Controls.Add(this.editAnything);
            this.closeBtn.Controls.Add(this.Students);
            this.closeBtn.Controls.Add(this.backBtn);
            this.closeBtn.Controls.Add(this.Courses);
            this.closeBtn.Controls.Add(this.Faculty);
            this.closeBtn.Controls.Add(this.panel2);
            this.closeBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.closeBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.closeBtn.Location = new System.Drawing.Point(0, 0);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(151, 600);
            this.closeBtn.TabIndex = 7;
            // 
            // deleteAnything
            // 
            this.deleteAnything.BackColor = System.Drawing.Color.Firebrick;
            this.deleteAnything.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteAnything.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deleteAnything.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.deleteAnything.Location = new System.Drawing.Point(12, 395);
            this.deleteAnything.Name = "deleteAnything";
            this.deleteAnything.Size = new System.Drawing.Size(124, 49);
            this.deleteAnything.TabIndex = 6;
            this.deleteAnything.Text = "Remove";
            this.deleteAnything.UseVisualStyleBackColor = false;
            this.deleteAnything.Click += new System.EventHandler(this.deleteAnything_Click);
            // 
            // editAnything
            // 
            this.editAnything.BackColor = System.Drawing.Color.Firebrick;
            this.editAnything.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editAnything.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.editAnything.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.editAnything.Location = new System.Drawing.Point(12, 340);
            this.editAnything.Name = "editAnything";
            this.editAnything.Size = new System.Drawing.Size(124, 49);
            this.editAnything.TabIndex = 5;
            this.editAnything.Text = "Edit";
            this.editAnything.UseVisualStyleBackColor = false;
            // 
            // Students
            // 
            this.Students.BackColor = System.Drawing.Color.Firebrick;
            this.Students.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Students.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Students.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Students.Location = new System.Drawing.Point(12, 285);
            this.Students.Name = "Students";
            this.Students.Size = new System.Drawing.Size(124, 49);
            this.Students.TabIndex = 4;
            this.Students.Text = "Students";
            this.Students.UseVisualStyleBackColor = false;
            this.Students.Click += new System.EventHandler(this.Students_Click);
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.Firebrick;
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.backBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.backBtn.Location = new System.Drawing.Point(12, 539);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(124, 49);
            this.backBtn.TabIndex = 3;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = false;
            // 
            // Courses
            // 
            this.Courses.BackColor = System.Drawing.Color.Firebrick;
            this.Courses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Courses.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Courses.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Courses.Location = new System.Drawing.Point(12, 175);
            this.Courses.Name = "Courses";
            this.Courses.Size = new System.Drawing.Size(124, 49);
            this.Courses.TabIndex = 2;
            this.Courses.Text = "Courses";
            this.Courses.UseVisualStyleBackColor = false;
            this.Courses.Click += new System.EventHandler(this.Courses_Click);
            // 
            // Faculty
            // 
            this.Faculty.BackColor = System.Drawing.Color.Firebrick;
            this.Faculty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Faculty.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Faculty.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Faculty.Location = new System.Drawing.Point(12, 230);
            this.Faculty.Name = "Faculty";
            this.Faculty.Size = new System.Drawing.Size(124, 49);
            this.Faculty.TabIndex = 1;
            this.Faculty.Text = "Faculty";
            this.Faculty.UseVisualStyleBackColor = false;
            this.Faculty.Click += new System.EventHandler(this.Faculty_Click);
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
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Firebrick;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button3.Location = new System.Drawing.Point(958, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(30, 30);
            this.button3.TabIndex = 12;
            this.button3.Text = "X";
            this.button3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // searchPanel
            // 
            this.searchPanel.AutoScroll = true;
            this.searchPanel.Location = new System.Drawing.Point(160, 97);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Size = new System.Drawing.Size(670, 0);
            this.searchPanel.TabIndex = 10;
            // 
            // displayPanel
            // 
            this.displayPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.displayPanel.Location = new System.Drawing.Point(157, 97);
            this.displayPanel.Name = "displayPanel";
            this.displayPanel.Size = new System.Drawing.Size(795, 491);
            this.displayPanel.TabIndex = 13;
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
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Firebrick;
            this.panel5.Controls.Add(this.label1);
            this.panel5.Location = new System.Drawing.Point(157, 12);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(670, 76);
            this.panel5.TabIndex = 14;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.displayPanel);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.searchPanel);
            this.Controls.Add(this.closeBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.closeBtn.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel closeBtn;
        private Button backBtn;
        private Button Courses;
        private Button Faculty;
        private Panel panel2;
        private TextBox txtUser;
        private PictureBox pictureBox2;
        private Button button3;
        private FlowLayoutPanel searchPanel;
        private Button editAnything;
        private Button Students;
        private Button deleteAnything;
        private FlowLayoutPanel displayPanel;
        private Label label1;
        private Panel panel5;
    }
}