﻿using System;

namespace GuessingGameThreeTries
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int cpuRandom = rnd.Next(1, 11);
            
            int i = 0;



            while (i < 3)
            {
                Console.WriteLine("Vali number 1-10");
                int userNumber = Convert.ToInt32(Console.ReadLine());

                if (cpuRandom == userNumber)
                {
                    Console.WriteLine("Oled võitnud.");

                    i = 3;
                }
                else
                {
                    i = i + 1;
                    Console.WriteLine($"Proovi jälle, sul {3 - i} katset jäänud.");
                }
                

            }
            Console.WriteLine("Head aega, good luck.");
        }
    }
}
