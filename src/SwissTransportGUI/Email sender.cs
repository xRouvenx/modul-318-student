using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace SwissTransportGUI
{
    public partial class Email : Form
    {
        public Email()
        {
            InitializeComponent();
        }

        private void Btnbrowse_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtattachment.Text = openFileDialog1.FileName.ToString();
            }
        }

        private void Btnsend_Click(object sender, EventArgs e)
        {
            try
            {
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587); // Works if you have a gmail account.
                MailMessage message = new MailMessage(); // Creating a new email object.
                message.From = new MailAddress(txtemail.Text); //your Email id.
                message.To.Add(txtreciever.Text); // Recievers email.
                message.Body = txtbody.Text; // Body of the email.
                message.Subject = txtsubject.Text; // Subject of the email.
                client.UseDefaultCredentials = false; // Overriding default redentials.
                client.EnableSsl = true; // enabling ssl security.

                if (txtattachment.Text != "") // checking whether attachment is added.
                {
                    message.Attachments.Add(new Attachment(txtattachment.Text));
                }
                client.Credentials = new System.Net.NetworkCredential(txtemail.Text, txtpassword.Text); // giving your login credentials.
                client.Send(message); // sending email.
                message = null; // freeing the memory of the message.
                MessageBox.Show("Message Sent");
            }

            catch(Exception s)
            {
            MessageBox.Show("Failed to send message");
            }
        }

    }
}
