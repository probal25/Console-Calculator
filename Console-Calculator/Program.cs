using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Console-Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What you would like to do(Use First Character)?");
            Console.WriteLine("Addtion, Subtraction, Multiplication, Division, Quit");
            Console.WriteLine();

            bool isQuit = false;
            while (!isQuit)
            {
                //Get the input from the user
                Console.Write("Enter Operation:");
                string input = Console.ReadLine();
                //grab the first character
                char firstCharacter = input[0];
                //check Quit or not
                if (firstCharacter == 'Q' || firstCharacter == 'q')
                {
                    break;
                }

                double firstNumber = 0;
                double secondNumber = 0;
                double result = 0;
                string error = string.Empty;

                Console.Write("Enter First Number:");
                //firstNumber =Convert.ToDouble(Console.ReadLine());
                double.TryParse(Console.ReadLine(), out firstNumber);

                Console.Write("Enter Second Number:");
                //secondNumber = Convert.ToDouble(Console.ReadLine());
                double.TryParse(Console.ReadLine(), out secondNumber);

                if (firstNumber == 0 && secondNumber == 0)
                {
                    Console.WriteLine("Your input is not correct.");
                    continue;
                }

                switch (firstCharacter)
                {
                    case 'A':
                    case 'a':
                        result = firstNumber + secondNumber;
                        break;
                    case 'S':
                    case 's':
                        result = firstNumber - secondNumber;
                        break;
                    case 'M':
                    case 'm':
                        result = firstNumber * secondNumber;
                        break;
                    case 'D':
                    case 'd':
                        if (secondNumber == 0)
                        {
                            error = "Denomerator can not be zero.";                            
                        }
                        else
                        {
                            result = firstNumber / secondNumber;                            
                        }
                        break;
                    default:
                        error = "Invalid Operation.";
                        break;
                }
                if (error != string.Empty)
                {
                    Console.WriteLine(error);
                }
                else
                {
                    Console.WriteLine("The result is:" + result);
                }
            }
        }
    }
}
