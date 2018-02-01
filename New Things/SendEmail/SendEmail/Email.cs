using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SendEmail
{
    static class Email
    {


        public static void sendEmail()
        {
                var fromAddress = new MailAddress("saifullah.cs14@iba-suk.edu.pk", "Saifullah");
                var toAddress = new MailAddress("saifullah.cs14@iba-suk.edu.pk", "To me");
                const string fromPassword = "saif666?";
                const string subject = "Subject";
                const string body = "Body";

                var smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
                };

                using (var message = new MailMessage(fromAddress, toAddress)
                {
                    Subject = subject,
                    Body = body
                })
                {
                    smtp.Send(message);
                }

        }// end


        public static void email_send()
        {

            Console.WriteLine("Start");
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
            mail.From = new MailAddress("saifullah.cs14@iba-suk.edu.pk");
            mail.To.Add("saifullah.cs14@iba-suk.edu.pk");
            mail.To.Add("saifullahkatpar@gmail.com");
            mail.Subject = "Test Mail - 1";
            mail.Body = "mail with attachment";

            System.Net.Mail.Attachment attachment;
            attachment = new System.Net.Mail.Attachment(@"C:\Users\saifullah\Desktop\edited.jpg");
            mail.Attachments.Add(attachment);

            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential("saifullah.cs14@iba-suk.edu.pk", "saif666?");
            SmtpServer.EnableSsl = true;

            SmtpServer.Send(mail);
            Console.WriteLine("Sent");
            Console.ReadLine();

        }





    }
}

