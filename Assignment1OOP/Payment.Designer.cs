namespace Assignment1OOP
{
    partial class Payment
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
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.btnPay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(61)))), ((int)(((byte)(97)))));
            this.lblBalance.Location = new System.Drawing.Point(30, 41);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(135, 20);
            this.lblBalance.TabIndex = 0;
            this.lblBalance.Text = "Remaining Fee:";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(61)))), ((int)(((byte)(97)))));
            this.lblAmount.Location = new System.Drawing.Point(33, 89);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(76, 20);
            this.lblAmount.TabIndex = 2;
            this.lblAmount.Text = "Amount:";
            // 
            // txtAmount
            // 
            this.txtAmount.BackColor = System.Drawing.Color.Linen;
            this.txtAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(61)))), ((int)(((byte)(97)))));
            this.txtAmount.Location = new System.Drawing.Point(171, 83);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(222, 26);
            this.txtAmount.TabIndex = 3;
            // 
            // txtBalance
            // 
            this.txtBalance.BackColor = System.Drawing.Color.Linen;
            this.txtBalance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(61)))), ((int)(((byte)(97)))));
            this.txtBalance.Location = new System.Drawing.Point(171, 41);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(222, 26);
            this.txtBalance.TabIndex = 4;
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.Linen;
            this.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(61)))), ((int)(((byte)(97)))));
            this.btnPay.Location = new System.Drawing.Point(140, 142);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(121, 55);
            this.btnPay.TabIndex = 5;
            this.btnPay.Text = "Pay";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(423, 225);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.txtBalance);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblBalance);
            this.Name = "Payment";
            this.Text = "Payment";
            this.Load += new System.EventHandler(this.Payment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.Button btnPay;
    }
}