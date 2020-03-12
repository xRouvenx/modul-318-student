namespace SwissTransportGUI
{
    partial class Email
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
            this.lblcemail = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.txtreciever = new System.Windows.Forms.TextBox();
            this.txtattachment = new System.Windows.Forms.TextBox();
            this.txtsubject = new System.Windows.Forms.TextBox();
            this.txtbody = new System.Windows.Forms.TextBox();
            this.btnbrowse = new System.Windows.Forms.Button();
            this.btnsend = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // lblcemail
            // 
            this.lblcemail.AutoSize = true;
            this.lblcemail.Location = new System.Drawing.Point(12, 9);
            this.lblcemail.Name = "lblcemail";
            this.lblcemail.Size = new System.Drawing.Size(203, 32);
            this.lblcemail.TabIndex = 0;
            this.lblcemail.Text = "Your Email ID :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(816, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Your Password :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(247, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Reiciever\'s Email :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 376);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "Subject :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 522);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 32);
            this.label4.TabIndex = 4;
            this.label4.Text = "Body :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(232, 32);
            this.label5.TabIndex = 5;
            this.label5.Text = "Add Attachment :";
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(281, 6);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(529, 38);
            this.txtemail.TabIndex = 6;
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(1043, 6);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '*';
            this.txtpassword.Size = new System.Drawing.Size(529, 38);
            this.txtpassword.TabIndex = 7;
            // 
            // txtreciever
            // 
            this.txtreciever.Location = new System.Drawing.Point(281, 111);
            this.txtreciever.Name = "txtreciever";
            this.txtreciever.Size = new System.Drawing.Size(1291, 38);
            this.txtreciever.TabIndex = 8;
            // 
            // txtattachment
            // 
            this.txtattachment.Enabled = false;
            this.txtattachment.Location = new System.Drawing.Point(281, 243);
            this.txtattachment.Name = "txtattachment";
            this.txtattachment.Size = new System.Drawing.Size(1135, 38);
            this.txtattachment.TabIndex = 9;
            // 
            // txtsubject
            // 
            this.txtsubject.Location = new System.Drawing.Point(281, 373);
            this.txtsubject.Name = "txtsubject";
            this.txtsubject.Size = new System.Drawing.Size(1291, 38);
            this.txtsubject.TabIndex = 10;
            // 
            // txtbody
            // 
            this.txtbody.Location = new System.Drawing.Point(281, 519);
            this.txtbody.Multiline = true;
            this.txtbody.Name = "txtbody";
            this.txtbody.Size = new System.Drawing.Size(1291, 314);
            this.txtbody.TabIndex = 11;
            // 
            // btnbrowse
            // 
            this.btnbrowse.Location = new System.Drawing.Point(1442, 235);
            this.btnbrowse.Name = "btnbrowse";
            this.btnbrowse.Size = new System.Drawing.Size(146, 52);
            this.btnbrowse.TabIndex = 12;
            this.btnbrowse.Text = "Browse";
            this.btnbrowse.UseVisualStyleBackColor = true;
            this.btnbrowse.Click += new System.EventHandler(this.Btnbrowse_Click);
            // 
            // btnsend
            // 
            this.btnsend.Location = new System.Drawing.Point(1260, 867);
            this.btnsend.Name = "btnsend";
            this.btnsend.Size = new System.Drawing.Size(311, 50);
            this.btnsend.TabIndex = 13;
            this.btnsend.Text = "Send Email";
            this.btnsend.UseVisualStyleBackColor = true;
            this.btnsend.Click += new System.EventHandler(this.Btnsend_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Email
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1628, 991);
            this.Controls.Add(this.btnsend);
            this.Controls.Add(this.btnbrowse);
            this.Controls.Add(this.txtbody);
            this.Controls.Add(this.txtsubject);
            this.Controls.Add(this.txtattachment);
            this.Controls.Add(this.txtreciever);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblcemail);
            this.Name = "Email";
            this.Text = "Email sender";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblcemail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.TextBox txtreciever;
        private System.Windows.Forms.TextBox txtattachment;
        private System.Windows.Forms.TextBox txtsubject;
        private System.Windows.Forms.TextBox txtbody;
        private System.Windows.Forms.Button btnbrowse;
        private System.Windows.Forms.Button btnsend;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}