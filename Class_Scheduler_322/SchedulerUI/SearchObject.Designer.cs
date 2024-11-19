namespace StudentDash
{
    partial class SearchObject : UserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lMeetingDays = new System.Windows.Forms.Label();
            this.lEndTime = new System.Windows.Forms.Label();
            this.lStartTime = new System.Windows.Forms.Label();
            this.lSeats = new System.Windows.Forms.Label();
            this.lInstructor = new System.Windows.Forms.Label();
            this.lSection = new System.Windows.Forms.Label();
            this.lName = new System.Windows.Forms.Label();
            this.lCourseNum = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.lMeetingDays);
            this.panel1.Controls.Add(this.lEndTime);
            this.panel1.Controls.Add(this.lStartTime);
            this.panel1.Controls.Add(this.lSeats);
            this.panel1.Controls.Add(this.lInstructor);
            this.panel1.Controls.Add(this.lSection);
            this.panel1.Controls.Add(this.lName);
            this.panel1.Controls.Add(this.lCourseNum);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(293, 111);
            this.panel1.TabIndex = 0;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            this.panel1.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
            this.panel1.MouseHover += new System.EventHandler(this.panel1_MouseHover);
            // 
            // lMeetingDays
            // 
            this.lMeetingDays.AutoSize = true;
            this.lMeetingDays.Enabled = false;
            this.lMeetingDays.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lMeetingDays.Location = new System.Drawing.Point(178, 48);
            this.lMeetingDays.Name = "lMeetingDays";
            this.lMeetingDays.Size = new System.Drawing.Size(85, 15);
            this.lMeetingDays.TabIndex = 15;
            this.lMeetingDays.Text = "course days";
            // 
            // lEndTime
            // 
            this.lEndTime.AutoSize = true;
            this.lEndTime.Enabled = false;
            this.lEndTime.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lEndTime.Location = new System.Drawing.Point(178, 24);
            this.lEndTime.Name = "lEndTime";
            this.lEndTime.Size = new System.Drawing.Size(115, 15);
            this.lEndTime.TabIndex = 14;
            this.lEndTime.Text = "course starttime";
            // 
            // lStartTime
            // 
            this.lStartTime.AutoSize = true;
            this.lStartTime.Enabled = false;
            this.lStartTime.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lStartTime.Location = new System.Drawing.Point(178, 0);
            this.lStartTime.Name = "lStartTime";
            this.lStartTime.Size = new System.Drawing.Size(115, 15);
            this.lStartTime.TabIndex = 13;
            this.lStartTime.Text = "course starttime";
            // 
            // lSeats
            // 
            this.lSeats.AutoSize = true;
            this.lSeats.Enabled = false;
            this.lSeats.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lSeats.Location = new System.Drawing.Point(0, 87);
            this.lSeats.Name = "lSeats";
            this.lSeats.Size = new System.Drawing.Size(103, 15);
            this.lSeats.TabIndex = 12;
            this.lSeats.Text = "course seating";
            // 
            // lInstructor
            // 
            this.lInstructor.AutoSize = true;
            this.lInstructor.Enabled = false;
            this.lInstructor.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lInstructor.Location = new System.Drawing.Point(-1, 72);
            this.lInstructor.Name = "lInstructor";
            this.lInstructor.Size = new System.Drawing.Size(120, 15);
            this.lInstructor.TabIndex = 11;
            this.lInstructor.Text = "course instructor";
            // 
            // lSection
            // 
            this.lSection.AutoSize = true;
            this.lSection.Enabled = false;
            this.lSection.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lSection.Location = new System.Drawing.Point(-1, 48);
            this.lSection.Name = "lSection";
            this.lSection.Size = new System.Drawing.Size(103, 15);
            this.lSection.TabIndex = 10;
            this.lSection.Text = "course section";
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Enabled = false;
            this.lName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lName.Location = new System.Drawing.Point(-1, 24);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(91, 15);
            this.lName.TabIndex = 9;
            this.lName.Text = "course name";
            // 
            // lCourseNum
            // 
            this.lCourseNum.AutoSize = true;
            this.lCourseNum.Enabled = false;
            this.lCourseNum.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lCourseNum.Location = new System.Drawing.Point(-1, 0);
            this.lCourseNum.Name = "lCourseNum";
            this.lCourseNum.Size = new System.Drawing.Size(62, 15);
            this.lCourseNum.TabIndex = 8;
            this.lCourseNum.Text = "course #";
            // 
            // SearchObject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "SearchObject";
            this.Size = new System.Drawing.Size(299, 117);
            this.Load += new System.EventHandler(this.SearchObject_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label lMeetingDays;
        private Label lEndTime;
        private Label lStartTime;
        private Label lSeats;
        private Label lInstructor;
        private Label lSection;
        private Label lName;
        private Label lCourseNum;
    }
}
