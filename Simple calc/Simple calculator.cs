using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_calc
{
    class Simple_calculator
    {
        int number1;
        int number2;
        int total;
        string math = "";
        public void Start()
        {
            Console.WriteLine("Hello, Welcome to the calculator. What would you like to calculate? (Addition/Subtraction/Multiplication/Division/End)");
            math = Console.ReadLine();
            Console.WriteLine("");

            while (math != "End" || math != "end") {
                //addition
                if (math== "End" || math == "end")
                {
                    Console.WriteLine("The Program is now ending");
                   // Console.
                }
                if (math == "Addition" || math == "addition")
                {
                    Console.WriteLine("First Number- ");
                    number1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("");
                    Console.WriteLine("Second Number- ");
                    number2 = Convert.ToInt32(Console.ReadLine());
                    total = number1 + number2;
                    Console.WriteLine(number1 + " + " + number2 + " = " + total);
                }

                //subtraction
                else if (math == "Subtraction" || math == "subtraction")
                {
                    Console.WriteLine("First Number- ");
                    number1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("");
                    Console.WriteLine("Second Number- ");
                    number2 = Convert.ToInt32(Console.ReadLine());
                    total = number1 - number2;
                    Console.WriteLine(number1 + " - " + number2 + " = " + total);
                }

                //multiplication
                else if (math == "Multiplication" || math == "multiplication")
                {
                    Console.WriteLine("First Number- ");
                    number1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("");
                    Console.WriteLine("Second Number- ");
                    number2 = Convert.ToInt32(Console.ReadLine());
                    total = number1 * number2;
                    Console.WriteLine(number1 + " * " + number2 + " = " + total);
                }

                //division
                else if (math == "Division" || math == "division")
                {
                    Console.WriteLine("First Number- ");
                    number1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("");
                    Console.WriteLine("Second Number- ");
                    number2 = Convert.ToInt32(Console.ReadLine());
                    total = number1 / number2;
                    Console.WriteLine(number1 + " / " + number2 + " = " + total);
                }
                else
                {
                    Console.WriteLine("Hello, Welcome to the calculator. What would you like to calculate? (Addition/Subtraction/Multiplication/Division/End)");
                    math = Console.ReadLine();
                    Console.WriteLine("");
                }

              
            }
        }


    }
}
