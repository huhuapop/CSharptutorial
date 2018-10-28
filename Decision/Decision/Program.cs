using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decision
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("bob's big giveaway");
            Console.WriteLine("choose a door:1,2 or 3");

            string userValue = Console.ReadLine();
            string message = "";
            if (userValue == "1")
            {
                 message = "you win a new car";
                Console.WriteLine(message);
            }
            else if(userValue=="2")
            {
                 message = "You win a new cat";
                Console.WriteLine(message);
            }
            else if (userValue == "3")
            {
                 message = "You win a new boat";
                Console.WriteLine(message);
            }
            else 
            {
                 message = "Sorry, We didn't understand";
                Console.WriteLine(message);
            }
            Console.ReadLine();
        }
    }
}
