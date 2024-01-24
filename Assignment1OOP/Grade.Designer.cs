namespace Assignment1OOP
{
    partial class Grade
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
            this.lblModule = new System.Windows.Forms.Label();
            this.lblStudent = new System.Windows.Forms.Label();
            this.lblGrade = new System.Windows.Forms.Label();
            this.lblModuleDisplay = new System.Windows.Forms.Label();
            this.cboStudent = new System.Windows.Forms.ComboBox();
            this.txtGrade = new System.Windows.Forms.TextBox();
            this.btnMark = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblModule
            // 
            this.lblModule.AutoSize = true;
            this.lblModule.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModule.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(61)))), ((int)(((byte)(97)))));
            this.lblModule.Location = new System.Drawing.Point(31, 36);
            this.lblModule.Name = "lblModule";
            this.lblModule.Size = new System.Drawing.Size(90, 25);
            this.lblModule.TabIndex = 0;
            this.lblModule.Text = "Module:";
            // 
            // lblStudent
            // 
            this.lblStudent.AutoSize = true;
            this.lblStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(61)))), ((int)(((byte)(97)))));
            this.lblStudent.Location = new System.Drawing.Point(31, 86);
            this.lblStudent.Name = "lblStudent";
            this.lblStudent.Size = new System.Drawing.Size(94, 25);
            this.lblStudent.TabIndex = 1;
            this.lblStudent.Text = "Student:";
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(61)))), ((int)(((byte)(97)))));
            this.lblGrade.Location = new System.Drawing.Point(31, 138);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(78, 25);
            this.lblGrade.TabIndex = 2;
            this.lblGrade.Text = "Grade:";
            // 
            // lblModuleDisplay
            // 
            this.lblModuleDisplay.BackColor = System.Drawing.Color.Linen;
            this.lblModuleDisplay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(61)))), ((int)(((byte)(97)))));
            this.lblModuleDisplay.Location = new System.Drawing.Point(150, 38);
            this.lblModuleDisplay.Name = "lblModuleDisplay";
            this.lblModuleDisplay.Size = new System.Drawing.Size(269, 23);
            this.lblModuleDisplay.TabIndex = 3;
            // 
            // cboStudent
            // 
            this.cboStudent.BackColor = System.Drawing.Color.Linen;
            this.cboStudent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(61)))), ((int)(((byte)(97)))));
            this.cboStudent.FormattingEnabled = true;
            this.cboStudent.Location = new System.Drawing.Point(150, 86);
            this.cboStudent.Name = "cboStudent";
            this.cboStudent.Size = new System.Drawing.Size(269, 28);
            this.cboStudent.TabIndex = 4;
            // 
            // txtGrade
            // 
            this.txtGrade.BackColor = System.Drawing.Color.Linen;
            this.txtGrade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(61)))), ((int)(((byte)(97)))));
            this.txtGrade.Location = new System.Drawing.Point(150, 138);
            this.txtGrade.Name = "txtGrade";
            this.txtGrade.Size = new System.Drawing.Size(269, 26);
            this.txtGrade.TabIndex = 5;
            // 
            // btnMark
            // 
            this.btnMark.BackColor = System.Drawing.Color.Linen;
            this.btnMark.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMark.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMark.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(61)))), ((int)(((byte)(97)))));
            this.btnMark.Location = new System.Drawing.Point(193, 201);
            this.btnMark.Name = "btnMark";
            this.btnMark.Size = new System.Drawing.Size(145, 69);
            this.btnMark.TabIndex = 6;
            this.btnMark.Text = "Grade";
            this.btnMark.UseVisualStyleBackColor = false;
            this.btnMark.Click += new System.EventHandler(this.btnMark_Click);
            // 
            // Grade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(513, 318);
            this.Controls.Add(this.btnMark);
            this.Controls.Add(this.txtGrade);
            this.Controls.Add(this.cboStudent);
            this.Controls.Add(this.lblModuleDisplay);
            this.Controls.Add(this.lblGrade);
            this.Controls.Add(this.lblStudent);
            this.Controls.Add(this.lblModule);
            this.Name = "Grade";
            this.Text = "Grade";
            this.Load += new System.EventHandler(this.Grade_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblModule;
        private System.Windows.Forms.Label lblStudent;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.Label lblModuleDisplay;
        private System.Windows.Forms.ComboBox cboStudent;
        private System.Windows.Forms.TextBox txtGrade;
        private System.Windows.Forms.Button btnMark;
    }
}