using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        class WrongOperator : Exception
        {
            public WrongOperator(string oper) : base("Wrong opertor pass to calculate")
            {
                Console.WriteLine($"Not a math operator: [{oper}]");
            }
        }

        class WrongOperands : Exception
        {
            public WrongOperands(string operands) : base("Wrong operands pass to calculate")
            {
                Console.WriteLine($"Not a value to calculate: [{operands}]");
            }
        }

        class TryDivideByZero : Exception
        {
            public TryDivideByZero() : base()
            {
                Console.WriteLine("Can't divide by zero");
            }
        }

        static float Calculate(float f1, float f2, string oper)
        {
            switch(oper)
            {
                case "+": return f1 + f2;
                case "-": return f1 - f2;
                case "*": return f1 * f2;
                case "/": if (f2 == 0) throw new TryDivideByZero();  return f1 / f2;
                case "^": return (float)Math.Pow(f1, f2);
                default: throw new WrongOperator(oper);
            }
        }

        static void Main(string[] args)
        {
            bool faile = false;
            Console.WriteLine("Simple calculator load...");
            Console.Write("First you write ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("left operand");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(", after, ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("operation ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("to calculate, and then ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("right operand\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Example: 2 + 2\n");
            do
            {
                try
                {
                    faile = false;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("left operand (float): ");
                    Console.ForegroundColor = ConsoleColor.White;
                    var left_out = Console.ReadLine();
                    if (!float.TryParse(left_out, out float left))
                        throw new WrongOperands(left_out);

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("math operation (+,-,*,/,^): ");
                    Console.ForegroundColor = ConsoleColor.White;
                    var oper = Console.ReadLine();

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("right operand (float): ");
                    Console.ForegroundColor = ConsoleColor.White;
                    var right_out = Console.ReadLine();
                    if (!float.TryParse(right_out, out float right))
                        throw new WrongOperands(right_out);

                    Console.WriteLine(Calculate(left, right, oper));

                } catch(Exception e) 
                {
                    faile = true; 
                    Console.WriteLine();
                }
            }    while (faile);
            Console.ReadLine();
        }
    }
}