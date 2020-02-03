using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challange1_Calculator_Application
{
    class Program
    {
        static int value1 = 0;
        static int value2 = 0;

        static void Main(string[] args)
        {
            Loop:
            Console.WriteLine("Press any following key to perform an arithmetic operation:");
            Console.WriteLine("");
            Console.WriteLine("1 - Addition");
            Console.WriteLine("2 - Subtraction");
            Console.WriteLine("3 - Multiplication");
            Console.WriteLine("4 - Division");
            Console.WriteLine("");
            
            int input = Convert.ToInt32(Console.ReadLine());
            

            Console.Write("Enter Value 1: ");
            value1 = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Enter Value 2: ");
            value2 = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine(" ");

            switch (input){
                case 1:
                    // code block
                    Console.WriteLine(value1 + "+" +value2 + "=" + (value1+value2));
                    break;
                case 2:
                    // code block
                    Console.WriteLine(value1 + "-" + value2 + "=" +( value1 - value2));
                    break;
                case 3:
                    // code block
                    Console.WriteLine(value1 + "*" + value2 + "=" + (value1 * value2));
                    break;
                case 4:
                    // code block
                    Console.WriteLine(value1 + "/" + value2 + "=" + (value1 / value2));
                    break;
                default:
                    // code block
                    Console.WriteLine("Wrong input!");
                    break;
            }

            Console.WriteLine(" ");

            Loop2:
            Console.WriteLine("Do you want to continue again (Y/N)?");
            String answer = Console.ReadLine();
            if (answer == "Y")
            {
                Console.WriteLine(" ");
                goto Loop;

            }
            else if (answer == "N")
            {
                Console.WriteLine(" ");
                Console.WriteLine("Thanks for playing !");
            }
            else
            {
                Console.WriteLine("Wrong input!");
                Console.WriteLine(" ");
                goto Loop2;
            }


        }
    }
}
