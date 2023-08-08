using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TripBooker_MVC_Core_5._0.Models
{
    public class MailRequest
    {
        public string Name { get; set; }
        public string SenderMail { get; set; }
        public string ReceiverMail { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
    }
}