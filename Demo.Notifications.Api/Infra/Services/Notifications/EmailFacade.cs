using SendGrid;
using SendGrid.Helpers.Mail;

namespace Demo.Notifications.Api.Infra.Services
{
    public class EmailFacade : INotificationFacade
    {
        private readonly ISendGridClient _sendGridclient;

        public EmailFacade(ISendGridClient sendGridclient)
        {
            _sendGridclient = sendGridclient;
        }

        public async Task SendAsync(string destination, string content)
        {
            var message = new SendGridMessage{
            From = new EmailAddress("test@gmail.com","Test"),
            Subject = "Testing e-mail POC",
            PlainTextContent = $"Hello! {content}"

            };

            message.AddTo(destination, destination);

            await _sendGridclient.SendEmailAsync(message);
        }
    }
}