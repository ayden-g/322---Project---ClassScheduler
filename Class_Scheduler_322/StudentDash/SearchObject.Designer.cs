namespace StudentDash
{
    partial class SearchObject
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
            this.labelNumber = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelSection = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelInstructor = new System.Windows.Forms.Label();
            this.labelSeats = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelEndT = new System.Windows.Forms.Label();
            this.labelStartT = new System.Windows.Forms.Label();
            this.labelDays = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelNumber.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelNumber.ForeColor = System.Drawing.Color.DimGray;
            this.labelNumber.Location = new System.Drawing.Point(0, 0);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(144, 37);
            this.labelNumber.TabIndex = 0;
            this.labelNumber.Text = "COURSE #";
            this.labelNumber.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelName.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelName.ForeColor = System.Drawing.Color.DimGray;
            this.labelName.Location = new System.Drawing.Point(128, 47);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(97, 37);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "NAME";
            this.labelName.Click += new System.EventHandler(this.labelName_Click);
            // 
            // labelSection
            // 
            this.labelSection.AutoSize = true;
            this.labelSection.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelSection.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSection.ForeColor = System.Drawing.Color.DimGray;
            this.labelSection.Location = new System.Drawing.Point(3, 47);
            this.labelSection.Name = "labelSection";
            this.labelSection.Size = new System.Drawing.Size(129, 37);
            this.labelSection.TabIndex = 2;
            this.labelSection.Text = "SECTION";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(270, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Instructor:";
            // 
            // labelInstructor
            // 
            this.labelInstructor.AutoSize = true;
            this.labelInstructor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelInstructor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelInstructor.ForeColor = System.Drawing.Color.DimGray;
            this.labelInstructor.Location = new System.Drawing.Point(356, 3);
            this.labelInstructor.Name = "labelInstructor";
            this.labelInstructor.Size = new System.Drawing.Size(89, 21);
            this.labelInstructor.TabIndex = 4;
            this.labelInstructor.Text = "Instructor:";
            // 
            // labelSeats
            // 
            this.labelSeats.AutoSize = true;
            this.labelSeats.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelSeats.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSeats.ForeColor = System.Drawing.Color.DimGray;
            this.labelSeats.Location = new System.Drawing.Point(356, 27);
            this.labelSeats.Name = "labelSeats";
            this.labelSeats.Size = new System.Drawing.Size(56, 21);
            this.labelSeats.TabIndex = 6;
            this.labelSeats.Text = "Seat #";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(270, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Seating:";
            // 
            // labelEndT
            // 
            this.labelEndT.AutoSize = true;
            this.labelEndT.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelEndT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelEndT.ForeColor = System.Drawing.Color.DimGray;
            this.labelEndT.Location = new System.Drawing.Point(356, 53);
            this.labelEndT.Name = "labelEndT";
            this.labelEndT.Size = new System.Drawing.Size(78, 21);
            this.labelEndT.TabIndex = 8;
            this.labelEndT.Text = "End time";
            // 
            // labelStartT
            // 
            this.labelStartT.AutoSize = true;
            this.labelStartT.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelStartT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelStartT.ForeColor = System.Drawing.Color.DimGray;
            this.labelStartT.Location = new System.Drawing.Point(270, 53);
            this.labelStartT.Name = "labelStartT";
            this.labelStartT.Size = new System.Drawing.Size(85, 21);
            this.labelStartT.TabIndex = 7;
            this.labelStartT.Text = "Start time";
            // 
            // labelDays
            // 
            this.labelDays.AutoSize = true;
            this.labelDays.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelDays.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelDays.ForeColor = System.Drawing.Color.DimGray;
            this.labelDays.Location = new System.Drawing.Point(270, 84);
            this.labelDays.Name = "labelDays";
            this.labelDays.Size = new System.Drawing.Size(115, 21);
            this.labelDays.TabIndex = 9;
            this.labelDays.Text = "Meeting Days";
            // 
            // SearchObject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.labelDays);
            this.Controls.Add(this.labelEndT);
            this.Controls.Add(this.labelStartT);
            this.Controls.Add(this.labelSeats);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelInstructor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelSection);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelNumber);
            this.Name = "SearchObject";
            this.Size = new System.Drawing.Size(452, 114);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelNumber;
        private Label labelName;
        private Label labelSection;
        private Label label1;
        private Label labelInstructor;
        private Label labelSeats;
        private Label label3;
        private Label labelEndT;
        private Label labelStartT;
        private Label labelDays;
    }
}
