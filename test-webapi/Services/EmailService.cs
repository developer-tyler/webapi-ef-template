using System.Net.Mail;
using System.Net;
using Microsoft.Extensions.Options;

namespace test_webapi.Services
{
    public interface IEmailService
    {
        Task SendCertificateEmailAsync(byte[] pdfBytes, string toEmail, string filename = "certificate.pdf");
    }

    public class EmailService : IEmailService
    {
        private readonly EmailSettings _emailSettings;

        public EmailService(IOptions<EmailSettings> emailSettings)
        {
            _emailSettings = emailSettings.Value;
        }

        public async Task SendCertificateEmailAsync(byte[] pdfBytes, string toEmail, string filename = "certificate.pdf")
        {
            var fromAddress = new MailAddress(_emailSettings.FromEmail, _emailSettings.FromName);
            var toAddress = new MailAddress("malcolm@thetylers.co.uk", "Malcolm"); // Hardcoded for development
            const string subject = "Plant Inspection Certificate";
            const string body = "Please find attached your plant inspection certificate.";

            using var smtp = new SmtpClient
            {
                Host = _emailSettings.SmtpServer,
                Port = _emailSettings.SmtpPort,
                EnableSsl = _emailSettings.EnableSsl,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(_emailSettings.SmtpUsername, _emailSettings.SmtpPassword)
            };

            using var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                Body = body
            };

            // Attach the PDF with the provided filename
            using var ms = new MemoryStream(pdfBytes);
            message.Attachments.Add(new Attachment(ms, filename, "application/pdf"));

            await smtp.SendMailAsync(message);
        }
    }
}