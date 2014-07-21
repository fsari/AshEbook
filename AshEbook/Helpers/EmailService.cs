using System;
using System.Configuration;

namespace AshEbook.Helpers
{
    public class EmailService
    {
        private static readonly String ToEmail = ConfigurationManager.AppSettings["EmailToSend"];
        private static readonly String FromEmail = ConfigurationManager.AppSettings["FromEmail"];
        private static readonly String Password = ConfigurationManager.AppSettings["Password"];

        /*public static void SendEmail(Contact contact)
        {
            var fromAddress = new MailAddress(FromEmail, "Nihat Tosun Contact");
            var toAddress = new MailAddress(ToEmail, "Nihat Tosun Contact");
            string fromPassword = Password;
            const string subject = "Nihat Tosun Contact";
            var body = "\n Name : " + contact.Name + "\n Email : " + contact.Email + "\n Subject:" + contact.Subject + "\n Message: " + contact.Message;

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
        }*/

    }
}