namespace Assignment1OOP
{
    partial class ConfirmPayment
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
            this.pcbVisa = new System.Windows.Forms.PictureBox();
            this.pcbAIB = new System.Windows.Forms.PictureBox();
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblPart1 = new System.Windows.Forms.Label();
            this.lblPart2 = new System.Windows.Forms.Label();
            this.lblStep1 = new System.Windows.Forms.Label();
            this.lblStep2 = new System.Windows.Forms.Label();
            this.btnApproved = new System.Windows.Forms.Button();
            this.lblPart3 = new System.Windows.Forms.Label();
            this.lblPart4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcbVisa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAIB)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbVisa
            // 
            this.pcbVisa.BackgroundImage = global::Assignment1OOP.Properties.Resources.visa_logo_800x450;
            this.pcbVisa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbVisa.Location = new System.Drawing.Point(355, 17);
            this.pcbVisa.Name = "pcbVisa";
            this.pcbVisa.Size = new System.Drawing.Size(154, 95);
            this.pcbVisa.TabIndex = 1;
            this.pcbVisa.TabStop = false;
            // 
            // pcbAIB
            // 
            this.pcbAIB.BackgroundImage = global::Assignment1OOP.Properties.Resources.AIB_Logo_2016;
            this.pcbAIB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbAIB.Location = new System.Drawing.Point(26, 17);
            this.pcbAIB.Name = "pcbAIB";
            this.pcbAIB.Size = new System.Drawing.Size(100, 95);
            this.pcbAIB.TabIndex = 0;
            this.pcbAIB.TabStop = false;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(148, 141);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(230, 25);
            this.lblHeader.TabIndex = 2;
            this.lblHeader.Text = "Confirm your purchase";
            // 
            // lblPart1
            // 
            this.lblPart1.AutoSize = true;
            this.lblPart1.Location = new System.Drawing.Point(45, 211);
            this.lblPart1.Name = "lblPart1";
            this.lblPart1.Size = new System.Drawing.Size(450, 20);
            this.lblPart1.TabIndex = 3;
            this.lblPart1.Text = "To confirm your payment with Lorem Ipsum University with card";
            // 
            // lblPart2
            // 
            this.lblPart2.AutoSize = true;
            this.lblPart2.Location = new System.Drawing.Point(176, 245);
            this.lblPart2.Name = "lblPart2";
            this.lblPart2.Size = new System.Drawing.Size(169, 20);
            this.lblPart2.TabIndex = 4;
            this.lblPart2.Text = "ending ************3214";
            // 
            // lblStep1
            // 
            this.lblStep1.AutoSize = true;
            this.lblStep1.Location = new System.Drawing.Point(77, 289);
            this.lblStep1.Name = "lblStep1";
            this.lblStep1.Size = new System.Drawing.Size(406, 20);
            this.lblStep1.TabIndex = 5;
            this.lblStep1.Text = "1. Open the notification we sent to your app and confirm.";
            // 
            // lblStep2
            // 
            this.lblStep2.AutoSize = true;
            this.lblStep2.Location = new System.Drawing.Point(149, 321);
            this.lblStep2.Name = "lblStep2";
            this.lblStep2.Size = new System.Drawing.Size(225, 20);
            this.lblStep2.TabIndex = 6;
            this.lblStep2.Text = "2. Confirm again in this screen:";
            // 
            // btnApproved
            // 
            this.btnApproved.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnApproved.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApproved.ForeColor = System.Drawing.Color.White;
            this.btnApproved.Location = new System.Drawing.Point(124, 360);
            this.btnApproved.Name = "btnApproved";
            this.btnApproved.Size = new System.Drawing.Size(289, 52);
            this.btnApproved.TabIndex = 7;
            this.btnApproved.Text = "I have approved in my app";
            this.btnApproved.UseVisualStyleBackColor = false;
            this.btnApproved.Click += new System.EventHandler(this.btnApproved_Click);
            // 
            // lblPart3
            // 
            this.lblPart3.AutoSize = true;
            this.lblPart3.Location = new System.Drawing.Point(205, 435);
            this.lblPart3.Name = "lblPart3";
            this.lblPart3.Size = new System.Drawing.Size(119, 20);
            this.lblPart3.TabIndex = 8;
            this.lblPart3.Text = "No notification?";
            // 
            // lblPart4
            // 
            this.lblPart4.AutoSize = true;
            this.lblPart4.Location = new System.Drawing.Point(149, 467);
            this.lblPart4.Name = "lblPart4";
            this.lblPart4.Size = new System.Drawing.Size(242, 20);
            this.lblPart4.TabIndex = 9;
            this.lblPart4.Text = "Go to aib.ie/confirm-my-purchase";
            // 
            // ConfirmPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(532, 527);
            this.Controls.Add(this.lblPart4);
            this.Controls.Add(this.lblPart3);
            this.Controls.Add(this.btnApproved);
            this.Controls.Add(this.lblStep2);
            this.Controls.Add(this.lblStep1);
            this.Controls.Add(this.lblPart2);
            this.Controls.Add(this.lblPart1);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.pcbVisa);
            this.Controls.Add(this.pcbAIB);
            this.Name = "ConfirmPayment";
            this.Text = "ConfirmPayment";
            this.Load += new System.EventHandler(this.ConfirmPayment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbVisa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAIB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbAIB;
        private System.Windows.Forms.PictureBox pcbVisa;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblPart1;
        private System.Windows.Forms.Label lblPart2;
        private System.Windows.Forms.Label lblStep1;
        private System.Windows.Forms.Label lblStep2;
        private System.Windows.Forms.Button btnApproved;
        private System.Windows.Forms.Label lblPart3;
        private System.Windows.Forms.Label lblPart4;
    }
}