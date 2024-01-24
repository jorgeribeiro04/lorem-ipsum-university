namespace Assignment1OOP
{
    partial class LecProfile
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblLecName = new System.Windows.Forms.Label();
            this.lblLecNameDisplay = new System.Windows.Forms.Label();
            this.lblCourse = new System.Windows.Forms.Label();
            this.lblCourseDisplay = new System.Windows.Forms.Label();
            this.lblModule = new System.Windows.Forms.Label();
            this.lblModuleDisplay = new System.Windows.Forms.Label();
            this.btnStudents = new System.Windows.Forms.Button();
            this.btnMyStudents = new System.Windows.Forms.Button();
            this.btnStuGrades = new System.Windows.Forms.Button();
            this.btnInDebt = new System.Windows.Forms.Button();
            this.dgvLecturer = new System.Windows.Forms.DataGridView();
            this.lblFilter = new System.Windows.Forms.Label();
            this.cboFilter = new System.Windows.Forms.ComboBox();
            this.cboFilters = new System.Windows.Forms.ComboBox();
            this.btnGradeStudent = new System.Windows.Forms.Button();
            this.lblLecIDDisplay = new System.Windows.Forms.Label();
            this.lblLecID = new System.Windows.Forms.Label();
            this.btnChangePassword = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLecturer)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(61)))), ((int)(((byte)(97)))));
            this.label1.Location = new System.Drawing.Point(135, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(570, 46);
            this.label1.TabIndex = 18;
            this.label1.Text = "LOREM IPSUM UNIVERSITY";
            // 
            // lblLecName
            // 
            this.lblLecName.AutoSize = true;
            this.lblLecName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLecName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(61)))), ((int)(((byte)(97)))));
            this.lblLecName.Location = new System.Drawing.Point(12, 80);
            this.lblLecName.Name = "lblLecName";
            this.lblLecName.Size = new System.Drawing.Size(81, 20);
            this.lblLecName.TabIndex = 19;
            this.lblLecName.Text = "Lecturer:";
            // 
            // lblLecNameDisplay
            // 
            this.lblLecNameDisplay.BackColor = System.Drawing.Color.Linen;
            this.lblLecNameDisplay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(61)))), ((int)(((byte)(97)))));
            this.lblLecNameDisplay.Location = new System.Drawing.Point(99, 80);
            this.lblLecNameDisplay.Name = "lblLecNameDisplay";
            this.lblLecNameDisplay.Size = new System.Drawing.Size(175, 23);
            this.lblLecNameDisplay.TabIndex = 20;
            // 
            // lblCourse
            // 
            this.lblCourse.AutoSize = true;
            this.lblCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(61)))), ((int)(((byte)(97)))));
            this.lblCourse.Location = new System.Drawing.Point(12, 134);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(71, 20);
            this.lblCourse.TabIndex = 23;
            this.lblCourse.Text = "Course:";
            // 
            // lblCourseDisplay
            // 
            this.lblCourseDisplay.BackColor = System.Drawing.Color.Linen;
            this.lblCourseDisplay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(61)))), ((int)(((byte)(97)))));
            this.lblCourseDisplay.Location = new System.Drawing.Point(99, 134);
            this.lblCourseDisplay.Name = "lblCourseDisplay";
            this.lblCourseDisplay.Size = new System.Drawing.Size(175, 23);
            this.lblCourseDisplay.TabIndex = 24;
            // 
            // lblModule
            // 
            this.lblModule.AutoSize = true;
            this.lblModule.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModule.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(61)))), ((int)(((byte)(97)))));
            this.lblModule.Location = new System.Drawing.Point(449, 137);
            this.lblModule.Name = "lblModule";
            this.lblModule.Size = new System.Drawing.Size(72, 20);
            this.lblModule.TabIndex = 25;
            this.lblModule.Text = "Module:";
            // 
            // lblModuleDisplay
            // 
            this.lblModuleDisplay.AutoSize = true;
            this.lblModuleDisplay.BackColor = System.Drawing.Color.Linen;
            this.lblModuleDisplay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(61)))), ((int)(((byte)(97)))));
            this.lblModuleDisplay.Location = new System.Drawing.Point(560, 137);
            this.lblModuleDisplay.Name = "lblModuleDisplay";
            this.lblModuleDisplay.Size = new System.Drawing.Size(0, 20);
            this.lblModuleDisplay.TabIndex = 26;
            // 
            // btnStudents
            // 
            this.btnStudents.FlatAppearance.BorderColor = System.Drawing.Color.PeachPuff;
            this.btnStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudents.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(61)))), ((int)(((byte)(97)))));
            this.btnStudents.Location = new System.Drawing.Point(16, 186);
            this.btnStudents.Name = "btnStudents";
            this.btnStudents.Size = new System.Drawing.Size(99, 42);
            this.btnStudents.TabIndex = 27;
            this.btnStudents.Text = "Students";
            this.btnStudents.UseVisualStyleBackColor = true;
            this.btnStudents.Click += new System.EventHandler(this.btnStudents_Click);
            // 
            // btnMyStudents
            // 
            this.btnMyStudents.FlatAppearance.BorderColor = System.Drawing.Color.PeachPuff;
            this.btnMyStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMyStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMyStudents.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(61)))), ((int)(((byte)(97)))));
            this.btnMyStudents.Location = new System.Drawing.Point(117, 186);
            this.btnMyStudents.Name = "btnMyStudents";
            this.btnMyStudents.Size = new System.Drawing.Size(131, 42);
            this.btnMyStudents.TabIndex = 28;
            this.btnMyStudents.Text = "My Students";
            this.btnMyStudents.UseVisualStyleBackColor = true;
            this.btnMyStudents.Click += new System.EventHandler(this.btnMyStudents_Click);
            // 
            // btnStuGrades
            // 
            this.btnStuGrades.FlatAppearance.BorderColor = System.Drawing.Color.PeachPuff;
            this.btnStuGrades.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStuGrades.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStuGrades.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(61)))), ((int)(((byte)(97)))));
            this.btnStuGrades.Location = new System.Drawing.Point(254, 188);
            this.btnStuGrades.Name = "btnStuGrades";
            this.btnStuGrades.Size = new System.Drawing.Size(177, 40);
            this.btnStuGrades.TabIndex = 29;
            this.btnStuGrades.Text = "Students Grades";
            this.btnStuGrades.UseVisualStyleBackColor = true;
            this.btnStuGrades.Click += new System.EventHandler(this.btnStuGrades_Click);
            // 
            // btnInDebt
            // 
            this.btnInDebt.FlatAppearance.BorderColor = System.Drawing.Color.PeachPuff;
            this.btnInDebt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInDebt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInDebt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(61)))), ((int)(((byte)(97)))));
            this.btnInDebt.Location = new System.Drawing.Point(426, 188);
            this.btnInDebt.Name = "btnInDebt";
            this.btnInDebt.Size = new System.Drawing.Size(177, 40);
            this.btnInDebt.TabIndex = 30;
            this.btnInDebt.Text = "Students in Debt";
            this.btnInDebt.UseVisualStyleBackColor = true;
            this.btnInDebt.Click += new System.EventHandler(this.btnInDebt_Click);
            // 
            // dgvLecturer
            // 
            this.dgvLecturer.BackgroundColor = System.Drawing.Color.PeachPuff;
            this.dgvLecturer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLecturer.Location = new System.Drawing.Point(12, 234);
            this.dgvLecturer.Name = "dgvLecturer";
            this.dgvLecturer.RowHeadersWidth = 62;
            this.dgvLecturer.RowTemplate.Height = 28;
            this.dgvLecturer.Size = new System.Drawing.Size(719, 412);
            this.dgvLecturer.TabIndex = 31;
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(61)))), ((int)(((byte)(97)))));
            this.lblFilter.Location = new System.Drawing.Point(820, 245);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(78, 20);
            this.lblFilter.TabIndex = 32;
            this.lblFilter.Text = "Filter by:";
            // 
            // cboFilter
            // 
            this.cboFilter.BackColor = System.Drawing.Color.PeachPuff;
            this.cboFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(61)))), ((int)(((byte)(97)))));
            this.cboFilter.FormattingEnabled = true;
            this.cboFilter.Location = new System.Drawing.Point(741, 281);
            this.cboFilter.Name = "cboFilter";
            this.cboFilter.Size = new System.Drawing.Size(230, 28);
            this.cboFilter.TabIndex = 33;
            this.cboFilter.SelectedIndexChanged += new System.EventHandler(this.cboFilter_SelectedIndexChanged);
            // 
            // cboFilters
            // 
            this.cboFilters.BackColor = System.Drawing.Color.PeachPuff;
            this.cboFilters.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(61)))), ((int)(((byte)(97)))));
            this.cboFilters.FormattingEnabled = true;
            this.cboFilters.Location = new System.Drawing.Point(741, 325);
            this.cboFilters.Name = "cboFilters";
            this.cboFilters.Size = new System.Drawing.Size(230, 28);
            this.cboFilters.TabIndex = 34;
            this.cboFilters.Visible = false;
            this.cboFilters.SelectedIndexChanged += new System.EventHandler(this.cboFilters_SelectedIndexChanged);
            // 
            // btnGradeStudent
            // 
            this.btnGradeStudent.BackColor = System.Drawing.Color.Linen;
            this.btnGradeStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGradeStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGradeStudent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(61)))), ((int)(((byte)(97)))));
            this.btnGradeStudent.Location = new System.Drawing.Point(742, 395);
            this.btnGradeStudent.Name = "btnGradeStudent";
            this.btnGradeStudent.Size = new System.Drawing.Size(229, 50);
            this.btnGradeStudent.TabIndex = 36;
            this.btnGradeStudent.Text = "Grade a Student";
            this.btnGradeStudent.UseVisualStyleBackColor = false;
            this.btnGradeStudent.Visible = false;
            this.btnGradeStudent.Click += new System.EventHandler(this.btnGradeStudent_Click);
            // 
            // lblLecIDDisplay
            // 
            this.lblLecIDDisplay.BackColor = System.Drawing.Color.Linen;
            this.lblLecIDDisplay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(61)))), ((int)(((byte)(97)))));
            this.lblLecIDDisplay.Location = new System.Drawing.Point(560, 80);
            this.lblLecIDDisplay.Name = "lblLecIDDisplay";
            this.lblLecIDDisplay.Size = new System.Drawing.Size(175, 23);
            this.lblLecIDDisplay.TabIndex = 22;
            // 
            // lblLecID
            // 
            this.lblLecID.AutoSize = true;
            this.lblLecID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLecID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(61)))), ((int)(((byte)(97)))));
            this.lblLecID.Location = new System.Drawing.Point(449, 80);
            this.lblLecID.Name = "lblLecID";
            this.lblLecID.Size = new System.Drawing.Size(105, 20);
            this.lblLecID.TabIndex = 21;
            this.lblLecID.Text = "Lecturer ID:";
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.BackColor = System.Drawing.Color.Linen;
            this.btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(61)))), ((int)(((byte)(97)))));
            this.btnChangePassword.Location = new System.Drawing.Point(765, 80);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(206, 54);
            this.btnChangePassword.TabIndex = 37;
            this.btnChangePassword.Text = "Change Password";
            this.btnChangePassword.UseVisualStyleBackColor = false;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // LecProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(983, 685);
            this.Controls.Add(this.btnChangePassword);
            this.Controls.Add(this.btnGradeStudent);
            this.Controls.Add(this.cboFilters);
            this.Controls.Add(this.cboFilter);
            this.Controls.Add(this.lblFilter);
            this.Controls.Add(this.dgvLecturer);
            this.Controls.Add(this.btnInDebt);
            this.Controls.Add(this.btnStuGrades);
            this.Controls.Add(this.btnMyStudents);
            this.Controls.Add(this.btnStudents);
            this.Controls.Add(this.lblModuleDisplay);
            this.Controls.Add(this.lblModule);
            this.Controls.Add(this.lblCourseDisplay);
            this.Controls.Add(this.lblCourse);
            this.Controls.Add(this.lblLecIDDisplay);
            this.Controls.Add(this.lblLecID);
            this.Controls.Add(this.lblLecNameDisplay);
            this.Controls.Add(this.lblLecName);
            this.Controls.Add(this.label1);
            this.Name = "LecProfile";
            this.Text = "LecProfile";
            this.Load += new System.EventHandler(this.LecProfile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLecturer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLecName;
        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.Label lblCourseDisplay;
        private System.Windows.Forms.Label lblModule;
        private System.Windows.Forms.Label lblModuleDisplay;
        private System.Windows.Forms.Button btnStudents;
        private System.Windows.Forms.Button btnMyStudents;
        private System.Windows.Forms.Button btnStuGrades;
        private System.Windows.Forms.Button btnInDebt;
        private System.Windows.Forms.DataGridView dgvLecturer;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.ComboBox cboFilter;
        private System.Windows.Forms.ComboBox cboFilters;
        private System.Windows.Forms.Button btnGradeStudent;
        private System.Windows.Forms.Label lblLecIDDisplay;
        private System.Windows.Forms.Label lblLecID;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Label lblLecNameDisplay;
    }
}