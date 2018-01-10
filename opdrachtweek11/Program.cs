using System;
using System.Threading;
delegate int NumberReached(int x);


namespace opdrachtweek11
{
    class Program
    {
     
        event NumberReached MyEvent;
        public static int number = 0;

        public Program()
        {            
            this.MyEvent += new NumberReached(CheckNumber);
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Geef maximumwaarde  ");
            int x;
            if (int.TryParse(Console.ReadLine(), out x))
            {
                Program p1 = new Program();
                int result = p1.MyEvent(number);
        
                ThreadNaming(x);
            }
            else
            {
                Console.WriteLine("Het moet een getal zijn");
            }

        }
        public static void ThreadNaming(int z){
            Thread.CurrentThread.Name = "main";
            Thread worker = new Thread(()=>CheckNumber(z));
            worker.Name = "worker";
            Console.WriteLine(worker.Name);
            worker.Start();
        }

         public static int CheckNumber(int a)
            {

            while (number < a){
                number++;  
                Console.WriteLine(number);              
            };  

            if (number == a) {
                DateTime now = DateTime.Now;
                Console.WriteLine(now);
                Console.WriteLine("De maximumwaarde is " + a);
            }                
            return number;
        }
        
    }
}
