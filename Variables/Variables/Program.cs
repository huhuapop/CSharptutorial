using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int x = 0;
                int y = 0;
                x = 7;
                y = x + 3;

                Console.WriteLine(y);

                string myFirstName="";
                Console.WriteLine("Please type your first name");
                myFirstName = Console.ReadLine();

                string myLastname = "";
                Console.WriteLine("Please type your last name");
                myLastname = Console.ReadLine();

                Console.WriteLine("hello: " + myFirstName +" "+ myLastname);
                Console.ReadLine();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {

            }
        }
    }
}
