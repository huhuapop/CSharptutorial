using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            HelloWorld();
            Console.ReadLine();
        }

        private static void HelloWorld()
        {
            Console.WriteLine("hello world");
        }

        private static char[] stringTocharArrayThenReverse(string message)
        {
            char[] messageArray = message.ToCharArray();
            Array.Reverse(messageArray);

            return messageArray;
        }

      
    }
}
