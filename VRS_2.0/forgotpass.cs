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
using System.Net;

namespace VRS_2._0
{
    public partial class forgotpass : Form
    {
        private string generatedOTP;
        public forgotpass()
        {
            InitializeComponent();
        }

        private void btnotp_Click(object sender, EventArgs e)
        {
            try
            {
                // Generate OTP
                Random random = new Random();
                generatedOTP = random.Next(100000, 999999).ToString(); // Store OTP in the class-level variable

                // Send the OTP to the user's email (example shown earlier)
                string senderEmail = "violationrecordsystem@gmail.com";
                string recipientEmail = tbemail.Text;

                string subject = "Your OTP Code";
                string body = $"Your OTP code is: {generatedOTP}";

                using (MailMessage mail = new MailMessage())
                {
                    mail.From = new MailAddress(senderEmail);
                    mail.To.Add(recipientEmail);
                    mail.Subject = subject;
                    mail.Body = body;

                    using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                    {
                        smtp.Credentials = new NetworkCredential(senderEmail, "taca wjfv jzrj llvi");
                        smtp.EnableSsl = true;
                        smtp.Send(mail);
                    }
                }

                MessageBox.Show("OTP has been sent to your email.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnverify_Click_1(object sender, EventArgs e)
        {
            // Verify the OTP entered by the user
            string enteredOTP = tbotp.Text;

            if (generatedOTP == enteredOTP)
            {
                MessageBox.Show("OTP verified successfully!");
                // Redirect to reset password form
                string email = tbemail.Text;
                ressetpass resetPasswordForm = new ressetpass(email);
                resetPasswordForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect OTP. Please try again.");
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            tbemail.Clear();
            tbotp.Clear();
        }
    }
}
