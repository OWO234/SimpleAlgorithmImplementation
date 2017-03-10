using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAlgorithmImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine(" 1.\tGenerate Fabonacci Series");
                Console.WriteLine(" 2.\tCalculate Factorial of a Number");
                Console.WriteLine(" 3.\tExit");
                Console.WriteLine("Please enter your choice");
                try
                {
                    int responds;
                    if (!int.TryParse(Console.ReadLine(), out responds))
                    { throw new FormatException(); }
                    switch (responds)
                    {
                        case 1:
                            Console.WriteLine("\n################# fabonacci Series #################");
                            Console.WriteLine("\nEnter length");
                            int len;
                            if (!int.TryParse(Console.ReadLine(), out len))
                            { throw new FormatException(); }
                            var numbers = new List<int>();
                            for (var i = 0; i < len; i++)
                            {
                                numbers.Add(FabonacciSeries(i));
                            }
                            Console.WriteLine($"Fabonacci series of lenght {len} is {string.Join(", ", numbers.ToArray())}");
                            break;
                        case 2:
                            Console.WriteLine("\n################# Factorial #################");
                            Console.WriteLine("\nEnter the number");
                            int num;
                            if (!int.TryParse(Console.ReadLine(), out num))
                            { throw new FormatException(); }
                            Console.WriteLine($"{num}! => {string.Join(" X ", Enumerable.Range(1, num).Reverse())} = {Factorial(num)}");
                            break;
                        case 3:
                            return;

                    }

                }
                catch (FormatException)
                {
                    Console.WriteLine("You've enter an invalid number, please try again.");
                }
                catch (Exception)
                {

                    Console.WriteLine("Unexpected error occur, please try again.");
                }
                Console.WriteLine("Press anykey to continue");
                Console.ReadKey();
            }
        }

        private static int FabonacciSeries(int i)
        {
            if ((i == 0) || (i == 1))
            {
                return i;
            }
            else
            {
                return FabonacciSeries(i - 1) + FabonacciSeries(i - 2);
            }
        }

        private static int Factorial(int i)
        {
            if ((i == 0) || (i == 1))
            {
                return 1;
            }
            else
            {
                return Factorial(i - 1) * i;
            }
        }
    }
}
