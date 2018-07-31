using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Threading
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Example();
                string result = Console.ReadLine();
                Console.WriteLine("You typed: " + result);
            }
            //Console.Read();
        }

        private static async void Example()
        {
            int t = await Task.Run(() => Allocate());
            Console.WriteLine("compute: " + t);
        }

        static int Allocate()
        {
            // Compute total count of digits in strings.
            int size = 0;
            for (int z = 0; z < 100; z++)
            {
                for (int i = 0; i < 1000000; i++)
                {
                    string value = i.ToString();
                    size += value.Length;
                }
            }
            return size;
        }
    }
}