using System;

namespace FiveLittleDucks
{
    class Program
    {
        static void Main(string[] args)
        {
            string ducks;
            for (int i = 5; i > 0; i--)
                
            {
                if (i > 2)
                {
                    ducks = "ducks.";
                }
                else
                {
                    ducks = "duck";
                }

                Console.WriteLine($"{i} little ducks went out one day " +
                    $"over the hill and far away, " +
                    $"mother duck said, \"quack quack quack quack\" but only {i - 1} little {ducks} came back.");
                if (i == 2)
                {
                    ducks = "duck";
                }
                if (i == 1)
                {
                    
                }
                


        }
            


        }
    }
}
