using System;
using System.Collections.Generic;
using System.Text;

namespace Ninject
{
    public interface IMailSender
    {
        void Send(string toAddress, string subject);
    }
}
