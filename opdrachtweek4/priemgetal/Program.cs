using System;

namespace priemgetal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geef een getal in die kleiner is dan 100");
            int number = Convert.ToInt32(Console.ReadLine());

            if(number > 100) {
                Console.WriteLine("Geef een getal kleiner dan 100 in.");

            } else {
                int i;
                for(i = 0; i <= number; i++) {
                    Console.WriteLine(i);
                }
                if(number % i == 0){
                    Console.WriteLine("geen priemgetal");
                } else {
                    Console.WriteLine("priemgetal");
                }
            }
        }
    }
}
