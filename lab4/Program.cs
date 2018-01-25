using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    class Program
    {
        static void Main(string[] args)
        {

       
            string answer;

            Console.WriteLine("Welcom to the Factorial Calculator!\n\n");
            


            do
            {
                
                Console.Write("Please enter an integer that greater than 0 and less than 21: ");
                int number = int.Parse(Console.ReadLine());

                long factorial = 1;
                for (int i = 1; i <= number; i++)
                {
                    factorial *= i;
                }

                Console.WriteLine($"The factorial of {number} is {factorial}.\n\n");
                Console.Write("countinue?(y/n): ");
                answer = Console.ReadLine();
                if (answer == "n" || answer == "N")
                {
                    Console.WriteLine("Bye");
                    break;
                }
            }
            while (answer == "Y" || answer == "y");
        }

        /* public static int factorial (int x)
        {
            if (x == 1)
                return 1;
            return x * factorial(x - 1);


        }
  */



    }
}
