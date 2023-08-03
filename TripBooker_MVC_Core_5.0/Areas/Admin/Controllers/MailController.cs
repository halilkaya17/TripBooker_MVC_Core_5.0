using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using TripBooker_MVC_Core_5._0.Models;

namespace TripBooker_MVC_Core_5._0.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class MailController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(MailRequest mailRequest)
        {
            MimeMessage mimeMessage = new MimeMessage();
            MailboxAddress mailboxAddressFrom = new MailboxAddress("Admin","tripbooker17@gmail.com");

            mimeMessage.From.Add(mailboxAddressFrom);

            MailboxAddress mailboxAddressTo = new MailboxAddress("User", mailRequest.ReceiverMail);

            mimeMessage.To.Add(mailboxAddressTo);

            var bodyBuilder = new BodyBuilder();
            bodyBuilder.TextBody= mailRequest.Body;
            mimeMessage.Body = bodyBuilder.ToMessageBody();

            mimeMessage.Subject= mailRequest.Subject;

            SmtpClient client = new SmtpClient();

            client.Connect("smtp.gmail.com", 587, false);

           client.Authenticate("tripbooker17@gmail.com", "vodmwmoqxglrmczu");

            client.Send(mimeMessage);

            client.Disconnect(true);

      
            return View();
        }
    }
}
