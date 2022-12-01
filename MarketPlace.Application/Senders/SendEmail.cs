using MailKit.Security;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace MarketPlace.Application.Senders
{
    public class SendEmail
    {
        public static void Send(string to, string subject, string body)
        {

            //MailMessage mail = new MailMessage();
            //SmtpClient SmtpServer = new SmtpClient("Bagherinezhada906@gmail.com");
            //mail.From = new MailAddress("Bagherinezhada906@gmail.com", "تاپ لرن");
            //mail.To.Add(to);
            //mail.Subject = subject;
            //mail.Body = body;
            //mail.IsBodyHtml = true;

            ////System.Net.Mail.Attachment attachment;
            //// attachment = new System.Net.Mail.Attachment("c:/textfile.txt");
            //// mail.Attachments.Add(attachment);

            //SmtpServer.Port = 587;
            //SmtpServer.Credentials = new System.Net.NetworkCredential("Bagherinezhada906@gmail.com", "Amin061bvb");

            //SmtpServer.Send(mail);



            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("فروشگاه جانکو", "Microfiles23@gmail.com"));
            //message.To.Add(new MailboxAddress(to));
            message.To.Add(MailboxAddress.Parse(to));
            message.Subject = subject;

            message.Body = new TextPart(MimeKit.Text.TextFormat.Html) { Text = body };

            using (var client = new MailKit.Net.Smtp.SmtpClient())
            {
                client.Connect("smtp.gmail.com", 587, false);

                // Note: only needed if the SMTP server requires authentication
                client.Authenticate("Microfiles23@gmail.com", "Amin23bvb");//TODO EMAIL WITH HOST OR PERSON

                client.Send(message);
                client.Disconnect(true);
            }

        }
    }
}