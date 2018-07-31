using System;
using System.Collections.Generic;
using System.Text;

namespace Ninject
{
    public class MailSender : IMailSender
    {
        private ILogging _logging;

        public MailSender(ILogging logging)
        {
            this._logging = logging;
        }
        public void Send(string toAddress, string subject)
        {
            _logging.Debug("Send Mail");
            Console.WriteLine("Sending mail to [{0}] with subject [{1}]", toAddress, subject);
        }
    }
}
