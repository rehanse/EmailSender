using EmailSender.Models;
using System.Net.Mail;
using System.Net;
using System.Reflection;

namespace EmailSender.Repository
{
    public class Services : IServices
    {
        private readonly EmailHost _emailHost;
        public Services(EmailHost emailHost)
        {
                _emailHost = emailHost;
        }
        public Task<bool> SendTextService(TextRequestModel model)
        {
            if(!string.IsNullOrEmpty(model.To))
            {
                using (MailMessage mailMessage = new MailMessage(_emailHost.FromEmail, model.To))
                {
                    mailMessage.Subject = model.Subject;
                    mailMessage.Body = model.Body;
                    mailMessage.IsBodyHtml = false;

                    using (SmtpClient smtpClient = new SmtpClient())
                    {
                        smtpClient.Host = _emailHost.Host;
                        smtpClient.EnableSsl = true;
                        smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                        smtpClient.UseDefaultCredentials = false;
                        NetworkCredential cred = new NetworkCredential(_emailHost.FromEmail, _emailHost.FromPassword);
                        smtpClient.Credentials = cred;
                        smtpClient.Port = _emailHost.Port;
                        smtpClient.Send(mailMessage);
                    }
                }
            }
            if (!string.IsNullOrEmpty(Convert.ToString(model.Mobile)))
            {

            }
            return Task.FromResult(true);
        }
    }
}
