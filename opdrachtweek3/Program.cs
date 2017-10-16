using System;
using System.Collections; //required for hashtable

namespace opdrachtweek3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to show the multiplication table");
            int table = Convert.ToInt32(Console.ReadLine());

            //creating a hashtable for results
            Hashtable hash = new Hashtable(); 
            //creating an array for results
            string[] arr = new string[11]; 
            Console.WriteLine("-");
            Console.WriteLine("Results:");
            for (int i = 0; i <= 10; i++){
                int result = table * i;
                string resultString = i + "x" + table + "=" + result;
                Console.WriteLine(resultString);

                arr[i] = resultString; 
                hash[i] = resultString;
            }
            
            Console.WriteLine("-");
            Console.WriteLine("Results from array:");
            foreach (string j in arr)
            {
                Console.WriteLine(j);
            }
            Console.WriteLine("-");
            Console.WriteLine("Results from hashtable:");
            foreach (DictionaryEntry e in hash)
            {
                Console.WriteLine(e.Value);
            }
        }
    }
}