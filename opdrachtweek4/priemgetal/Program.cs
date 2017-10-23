using System;

namespace priemgetal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int number = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= number; i++) {
                if (number % i == 0 && i != number && i != 1) {
                    Console.Clear();
                    string resultMessage = "{0} is not a prime number";
                    Console.WriteLine(resultMessage, number);
                    break;

                } else {
                    if (i == number) {
                        string resultMessage = "{0} is a prime number";
                        Console.WriteLine(resultMessage, number);
                    }
                };
            }
        }
    }
}
