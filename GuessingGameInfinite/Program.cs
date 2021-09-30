using System;

namespace GuessingGameInfinite
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int correctnumber = rnd.Next(1, 11);
            int guess = 0;
            Console.WriteLine("Vali oma number 1-11");
            
            
            while (guess != correctnumber)

            {
                string input = Console.ReadLine();
                if(!int.TryParse(input, out guess))
                    Console.WriteLine("Palun sisesta oma number.");

                if (guess != correctnumber)
                {
                    Console.WriteLine("Vale number.");
                }


                
            }
            Console.WriteLine("Võitsid semu, võitsid.");

        }
    }
}
