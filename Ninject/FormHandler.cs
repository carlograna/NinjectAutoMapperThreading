using System;
using System.Collections.Generic;
using System.Text;

namespace Ninject
{
    public class FormHandler
    {
        private readonly IMailSender mailSender;

        public FormHandler(IMailSender mailSender)
        {
            this.mailSender = mailSender;
        }

        public void Handle(string toAddress)
        {
            mailSender.Send(toAddress, "This is non-Ninject example");
        }
    }
}
