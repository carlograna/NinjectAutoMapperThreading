using System;
using System.Reflection;
using Ninject;
using Ninject.Modules;
namespace Ninject
{
    class Program
    {
        static void Main(string[] args)
        {
            //IMailSender mailSender = new MockMailSender();

            var kernel = new StandardKernel();
            //kernel.Load(Assembly.GetExecutingAssembly());
            //kernel.Bind<IMailSender>().To<MockMailSender>();
            //var mailSender = kernel.Get<IMailSender>();
            kernel.Bind<IMailSender>().To<MailSender>();
            kernel.Bind<ILogging>().To<Logging>();
            var mailSender = kernel.Get<IMailSender>();

            FormHandler formHandler = new FormHandler(mailSender);
            formHandler.Handle("test@test.com");

            Console.ReadLine();
        }
    }
}
