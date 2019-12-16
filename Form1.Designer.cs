namespace MyMailer
{
    partial class Form1
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
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblRecepient = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.txtSender = new System.Windows.Forms.TextBox();
            this.txtRecipient = new System.Windows.Forms.TextBox();
            this.rtxtMessage = new System.Windows.Forms.RichTextBox();
            this.lblStatusSending = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.lblSubject = new System.Windows.Forms.Label();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(23, 25);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(41, 13);
            this.lblFrom.TabIndex = 0;
            this.lblFrom.Text = "Sender";
            // 
            // lblRecepient
            // 
            this.lblRecepient.AutoSize = true;
            this.lblRecepient.Location = new System.Drawing.Point(23, 71);
            this.lblRecepient.Name = "lblRecepient";
            this.lblRecepient.Size = new System.Drawing.Size(50, 13);
            this.lblRecepient.TabIndex = 0;
            this.lblRecepient.Text = "Receiver";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(23, 151);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(50, 13);
            this.lblMessage.TabIndex = 0;
            this.lblMessage.Text = "Message";
            // 
            // txtSender
            // 
            this.txtSender.Location = new System.Drawing.Point(79, 18);
            this.txtSender.Name = "txtSender";
            this.txtSender.Size = new System.Drawing.Size(244, 20);
            this.txtSender.TabIndex = 1;
            // 
            // txtRecipient
            // 
            this.txtRecipient.Location = new System.Drawing.Point(79, 64);
            this.txtRecipient.Name = "txtRecipient";
            this.txtRecipient.Size = new System.Drawing.Size(244, 20);
            this.txtRecipient.TabIndex = 1;
            // 
            // rtxtMessage
            // 
            this.rtxtMessage.Location = new System.Drawing.Point(79, 148);
            this.rtxtMessage.Name = "rtxtMessage";
            this.rtxtMessage.Size = new System.Drawing.Size(500, 250);
            this.rtxtMessage.TabIndex = 2;
            this.rtxtMessage.Text = "";
            // 
            // lblStatusSending
            // 
            this.lblStatusSending.AutoSize = true;
            this.lblStatusSending.Location = new System.Drawing.Point(76, 429);
            this.lblStatusSending.Name = "lblStatusSending";
            this.lblStatusSending.Size = new System.Drawing.Size(0, 13);
            this.lblStatusSending.TabIndex = 3;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(377, 53);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(149, 66);
            this.btnSend.TabIndex = 4;
            this.btnSend.Text = "SEND";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Location = new System.Drawing.Point(23, 117);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(43, 13);
            this.lblSubject.TabIndex = 0;
            this.lblSubject.Text = "Subject";
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(79, 110);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(276, 20);
            this.txtSubject.TabIndex = 1;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(367, 25);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 0;
            this.lblPassword.Text = "Password";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(439, 18);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(178, 20);
            this.txtPass.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.lblStatusSending);
            this.Controls.Add(this.rtxtMessage);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.txtRecipient);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtSender);
            this.Controls.Add(this.lblSubject);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lblRecepient);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblFrom);
            this.Name = "Form1";
            this.Text = "MyMailer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblRecepient;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.TextBox txtSender;
        private System.Windows.Forms.TextBox txtRecipient;
        private System.Windows.Forms.RichTextBox rtxtMessage;
        private System.Windows.Forms.Label lblStatusSending;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPass;
    }
}

