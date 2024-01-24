namespace Assignment1OOP
{
    partial class ChangePassword
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
            this.lblActualPass = new System.Windows.Forms.Label();
            this.lblNewPass = new System.Windows.Forms.Label();
            this.txtOldPass = new System.Windows.Forms.TextBox();
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.btnChangePass = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblActualPass
            // 
            this.lblActualPass.AutoSize = true;
            this.lblActualPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActualPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(61)))), ((int)(((byte)(97)))));
            this.lblActualPass.Location = new System.Drawing.Point(39, 50);
            this.lblActualPass.Name = "lblActualPass";
            this.lblActualPass.Size = new System.Drawing.Size(113, 25);
            this.lblActualPass.TabIndex = 0;
            this.lblActualPass.Text = "Password:";
            // 
            // lblNewPass
            // 
            this.lblNewPass.AutoSize = true;
            this.lblNewPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(61)))), ((int)(((byte)(97)))));
            this.lblNewPass.Location = new System.Drawing.Point(39, 100);
            this.lblNewPass.Name = "lblNewPass";
            this.lblNewPass.Size = new System.Drawing.Size(161, 25);
            this.lblNewPass.TabIndex = 1;
            this.lblNewPass.Text = "New Password:";
            // 
            // txtOldPass
            // 
            this.txtOldPass.BackColor = System.Drawing.Color.Linen;
            this.txtOldPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(61)))), ((int)(((byte)(97)))));
            this.txtOldPass.Location = new System.Drawing.Point(214, 51);
            this.txtOldPass.Name = "txtOldPass";
            this.txtOldPass.Size = new System.Drawing.Size(271, 26);
            this.txtOldPass.TabIndex = 2;
            // 
            // txtNewPass
            // 
            this.txtNewPass.BackColor = System.Drawing.Color.Linen;
            this.txtNewPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(61)))), ((int)(((byte)(97)))));
            this.txtNewPass.Location = new System.Drawing.Point(214, 101);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.Size = new System.Drawing.Size(271, 26);
            this.txtNewPass.TabIndex = 3;
            // 
            // btnChangePass
            // 
            this.btnChangePass.BackColor = System.Drawing.Color.Linen;
            this.btnChangePass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(61)))), ((int)(((byte)(97)))));
            this.btnChangePass.Location = new System.Drawing.Point(176, 181);
            this.btnChangePass.Name = "btnChangePass";
            this.btnChangePass.Size = new System.Drawing.Size(194, 72);
            this.btnChangePass.TabIndex = 4;
            this.btnChangePass.Text = "Change Password";
            this.btnChangePass.UseVisualStyleBackColor = false;
            this.btnChangePass.Click += new System.EventHandler(this.btnChangePass_Click);
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(536, 292);
            this.Controls.Add(this.btnChangePass);
            this.Controls.Add(this.txtNewPass);
            this.Controls.Add(this.txtOldPass);
            this.Controls.Add(this.lblNewPass);
            this.Controls.Add(this.lblActualPass);
            this.Name = "ChangePassword";
            this.Text = "ChangePassword";
            this.Load += new System.EventHandler(this.ChangePassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblActualPass;
        private System.Windows.Forms.Label lblNewPass;
        private System.Windows.Forms.TextBox txtOldPass;
        private System.Windows.Forms.TextBox txtNewPass;
        private System.Windows.Forms.Button btnChangePass;
    }
}