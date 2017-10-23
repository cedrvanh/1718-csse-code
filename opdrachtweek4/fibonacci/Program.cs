using System;

namespace fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < length; i++){ 
                Console.WriteLine(Fibonacci(i));
            }

            int Fibonacci(int n) {
                int a = 0;
                int b = 1;

                for (int i = 0; i < n; i++) {
                    int temp = a;
                    a = b;
                    b = temp + b;
                }
                return a;
            }
        }
    }
}
