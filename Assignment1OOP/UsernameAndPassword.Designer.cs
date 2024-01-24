namespace Assignment1OOP
{
    partial class UsernameAndPassword
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
            this.lblUsername = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUsernameDisplay = new System.Windows.Forms.Label();
            this.lblPassDisplay = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(61)))), ((int)(((byte)(97)))));
            this.lblUsername.Location = new System.Drawing.Point(48, 52);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(117, 25);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Username:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(61)))), ((int)(((byte)(97)))));
            this.label1.Location = new System.Drawing.Point(48, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Password*:";
            // 
            // lblUsernameDisplay
            // 
            this.lblUsernameDisplay.AutoSize = true;
            this.lblUsernameDisplay.BackColor = System.Drawing.Color.Linen;
            this.lblUsernameDisplay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(61)))), ((int)(((byte)(97)))));
            this.lblUsernameDisplay.Location = new System.Drawing.Point(187, 56);
            this.lblUsernameDisplay.Name = "lblUsernameDisplay";
            this.lblUsernameDisplay.Size = new System.Drawing.Size(0, 20);
            this.lblUsernameDisplay.TabIndex = 2;
            // 
            // lblPassDisplay
            // 
            this.lblPassDisplay.AutoSize = true;
            this.lblPassDisplay.BackColor = System.Drawing.Color.Linen;
            this.lblPassDisplay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(61)))), ((int)(((byte)(97)))));
            this.lblPassDisplay.Location = new System.Drawing.Point(187, 107);
            this.lblPassDisplay.Name = "lblPassDisplay";
            this.lblPassDisplay.Size = new System.Drawing.Size(0, 20);
            this.lblPassDisplay.TabIndex = 3;
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.Linen;
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(61)))), ((int)(((byte)(97)))));
            this.btnOk.Location = new System.Drawing.Point(174, 144);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(124, 59);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(61)))), ((int)(((byte)(97)))));
            this.lblMessage.Location = new System.Drawing.Point(49, 235);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(402, 20);
            this.lblMessage.TabIndex = 5;
            this.lblMessage.Text = "*You can change your password at the Student\'s Profile";
            // 
            // UsernameAndPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(490, 276);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lblPassDisplay);
            this.Controls.Add(this.lblUsernameDisplay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblUsername);
            this.Name = "UsernameAndPassword";
            this.Text = "UsernameAndPassword";
            this.Load += new System.EventHandler(this.UsernameAndPassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUsernameDisplay;
        private System.Windows.Forms.Label lblPassDisplay;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label lblMessage;
    }
}