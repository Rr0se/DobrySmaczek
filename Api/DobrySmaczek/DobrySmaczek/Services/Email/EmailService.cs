using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace DobrySmaczek.Services.Email
{
    public class EmailService
    {
        public void SendEmail(string userEmail, string bodyContent, string subject)
        {
            var smtp = "";
            var email = "";
            var password = "";
            var port = "587";

            var mail = new MailMessage();
            var smtpServer = new SmtpClient(smtp)
            {
                Credentials = new NetworkCredential(email, password),
                Port = int.Parse(port),
                EnableSsl = false
            };
            mail.From = new MailAddress(email);
            mail.To.Add(userEmail);
            mail.Subject = subject;
            mail.IsBodyHtml = true;
            mail.SubjectEncoding = System.Text.Encoding.UTF8;
            mail.Body = bodyContent;

            smtpServer.Send(mail);
        }
    }
}
