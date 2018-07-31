namespace Ninject
{
    internal class Logging : ILogging
    {
        public void Debug(string msg)
        {
            System.Console.WriteLine(msg);
        }
    }
}