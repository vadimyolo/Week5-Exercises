using System;

namespace OneToHundred
{
    class Program
    {
        static void Main(string[] args)
        {
            //kuvab konsoolis 1 kuni 100.
            //kasutab for loopi.

            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine($"{i + 1}");
            }
        }
    }
}
