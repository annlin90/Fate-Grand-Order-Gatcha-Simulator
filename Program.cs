using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool stop = true;
            Console.WriteLine("Welcome to Hell. Would you like to start?");
            string input1 = Console.ReadLine();
            if (input1 == "Yes")
              {
                Class1.rollTest();
                while (stop)
                {
                    Console.WriteLine("Roll again?"); 
                     if (Console.ReadLine() == "Y")   
                        {
                         Class1.rollTest();
                    }
                     else
                    {
                        stop =false;
                    }


                }
            }
            else if (input1 == "N")
            {
                Console.WriteLine("You've made the right choice.");
            }
        }
    }
}
