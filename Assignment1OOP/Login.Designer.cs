namespace Assignment1OOP
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbLecturer = new System.Windows.Forms.RadioButton();
            this.rbStudent = new System.Windows.Forms.RadioButton();
            this.ckbPassword = new System.Windows.Forms.CheckBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtIdNumber = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblStudentID = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbLecturer);
            this.groupBox1.Controls.Add(this.rbStudent);
            this.groupBox1.Controls.Add(this.ckbPassword);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.txtIdNumber);
            this.groupBox1.Controls.Add(this.lblPassword);
            this.groupBox1.Controls.Add(this.lblStudentID);
            this.groupBox1.Location = new System.Drawing.Point(58, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(447, 194);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // rbLecturer
            // 
            this.rbLecturer.AutoSize = true;
            this.rbLecturer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbLecturer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbLecturer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(61)))), ((int)(((byte)(97)))));
            this.rbLecturer.Location = new System.Drawing.Point(308, 0);
            this.rbLecturer.Name = "rbLecturer";
            this.rbLecturer.Size = new System.Drawing.Size(114, 29);
            this.rbLecturer.TabIndex = 18;
            this.rbLecturer.Text = "Lecturer";
            this.rbLecturer.UseVisualStyleBackColor = true;
            // 
            // rbStudent
            // 
            this.rbStudent.AutoSize = true;
            this.rbStudent.Checked = true;
            this.rbStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbStudent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(61)))), ((int)(((byte)(97)))));
            this.rbStudent.Location = new System.Drawing.Point(9, 0);
            this.rbStudent.Name = "rbStudent";
            this.rbStudent.Size = new System.Drawing.Size(110, 29);
            this.rbStudent.TabIndex = 8;
            this.rbStudent.TabStop = true;
            this.rbStudent.Text = "Student";
            this.rbStudent.UseVisualStyleBackColor = true;
            // 
            // ckbPassword
            // 
            this.ckbPassword.AutoSize = true;
            this.ckbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(61)))), ((int)(((byte)(97)))));
            this.ckbPassword.Location = new System.Drawing.Point(212, 154);
            this.ckbPassword.Name = "ckbPassword";
            this.ckbPassword.Size = new System.Drawing.Size(161, 24);
            this.ckbPassword.TabIndex = 7;
            this.ckbPassword.Text = "Show Password";
            this.ckbPassword.UseVisualStyleBackColor = true;
            this.ckbPassword.CheckedChanged += new System.EventHandler(this.ckbPassword_CheckedChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.Linen;
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(61)))), ((int)(((byte)(97)))));
            this.txtPassword.Location = new System.Drawing.Point(212, 104);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(206, 26);
            this.txtPassword.TabIndex = 6;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtIdNumber
            // 
            this.txtIdNumber.BackColor = System.Drawing.Color.Linen;
            this.txtIdNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(61)))), ((int)(((byte)(97)))));
            this.txtIdNumber.Location = new System.Drawing.Point(212, 58);
            this.txtIdNumber.Name = "txtIdNumber";
            this.txtIdNumber.Size = new System.Drawing.Size(206, 26);
            this.txtIdNumber.TabIndex = 5;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(61)))), ((int)(((byte)(97)))));
            this.lblPassword.Location = new System.Drawing.Point(18, 103);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(113, 25);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Password:";
            // 
            // lblStudentID
            // 
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(61)))), ((int)(((byte)(97)))));
            this.lblStudentID.Location = new System.Drawing.Point(18, 57);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(117, 25);
            this.lblStudentID.TabIndex = 3;
            this.lblStudentID.Text = "Username:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(618, 23);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(281, 366);
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(61)))), ((int)(((byte)(97)))));
            this.label1.Location = new System.Drawing.Point(201, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(570, 46);
            this.label1.TabIndex = 16;
            this.label1.Text = "LOREM IPSUM UNIVERSITY";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Linen;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(61)))), ((int)(((byte)(97)))));
            this.btnLogin.Location = new System.Drawing.Point(209, 316);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(145, 44);
            this.btnLogin.TabIndex = 17;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackgroundImage = global::Assignment1OOP.Properties.Resources.backSymbol;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.PeachPuff;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Location = new System.Drawing.Point(31, 13);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(77, 42);
            this.btnBack.TabIndex = 18;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(950, 372);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtIdNumber;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.CheckBox ckbPassword;
        private System.Windows.Forms.RadioButton rbLecturer;
        private System.Windows.Forms.RadioButton rbStudent;
        private System.Windows.Forms.Button btnBack;
    }
}