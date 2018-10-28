using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];

            numbers[0] = 4;
            numbers[1] = 8;
            numbers[2] = 15;
            numbers[3] = 16;
            numbers[4] = 23;

            int[] newnumbers = new int[] { 1, 2, 3, 4, 5 };

            string[] name = new string[] { "Jody", "Alex", "Lee", "Tammie", "Green" };

            foreach(string _name in name)
            {
                Console.WriteLine(_name);
            }

            string zip = "hello, this is only a array test";
            char[] charArray = zip.ToCharArray();
            Array.Reverse(charArray);

            foreach (char zipchar in charArray)
            {
                Console.WriteLine(zipchar);
            }

            Console.ReadLine();
        }
    }
}
