/*
 * Welcome to my calculator
 * 
 * Compile with csc Program.cs
 * Run with mono ./Program.exe
 * 
 */
using System;

namespace SimpleCalculator
{
    class Calculator
    {
        float add(float a, float b){
            return a + b;
        }

        float sub(float a, float b){
            return a - b;
        }

        float mult(float a, float b){
            return a * b;
        }

        float div(float a, float b){
            if (b == 0.0){
                Console.WriteLine("Can not divide by zero");
                return 0;
            }
            return a / b;
        }

        float expon(double a, double b){
            return (float)Math.Pow(a, b);
        }

        public static void Main(string[] args)
        {
            Calculator c = new Calculator();
            float a = 0;
            float b = 0;
            String opp = " ";
            bool keepGoing = true;
            float total = 0;

            Console.WriteLine("WELCOME TO BASIC CALCULATOR!");
            while(keepGoing){
                
                Console.WriteLine("Type q to stop calculating!");
                String quit = Console.ReadLine();
                if (quit.Equals("q"))
                {
                    Console.WriteLine("Sorry to see you go");
                    break;
                }
                Console.WriteLine("The format is a *operator* b ");

                //finding a
                Console.WriteLine("What is a");
                a = float.Parse(Console.ReadLine());

                //finding b
                Console.WriteLine("What is b");
                b = float.Parse(Console.ReadLine());

                //finding the opp
                Console.WriteLine("What is the opperator symbol");
                opp = Console.ReadLine();

                switch(opp){
                    case "+":
                        total = c.add(a, b);
                        break;

                    case "-":
                        total = c.sub(a, b);
                        break;

                    case "*":
                        total = c.mult(a, b);
                        break;

                    case "/":
                        if(c.div(a, b) != 0)
                            total = c.div(a, b);
                        break;

                    case "^":
                        total = c.expon((double)a, (double)b);
                        break;

                    default:
                        Console.WriteLine("No valid operator given");
                        break;
                }

                Console.WriteLine("Your total is: " + total);
            }
        }
    }
}
