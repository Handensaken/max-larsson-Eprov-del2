using System;
using System.Threading;
using System.Collections;
using System.Collections.Generic;

namespace max_larsson_Eprov_del2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("somewhat homofil");
            Console.WriteLine("homofil");
        }
        static int Limit() //metod som tar in användarens input för hur mycket den ska kunna bära
        {
            int weightLimitInt = 0;
            bool success = false;
            while (!success)
            {
                Console.WriteLine("enter carry weight limit");
                string weightLimitString = Console.ReadLine();
                success = int.TryParse(weightLimitString, out weightLimitInt);
                if (!success)
                {
                    Console.WriteLine("enter a number");
                }
                Press();
            }
            return weightLimitInt;
        }
        static int Market(string[] names, int[] weight)    //List metod som skriver ut vad sakerna heter samt deras pris
        {
            //sätter limiten till limitmetoden
            int weightLimit = Limit();
            List<string> inventory = new List<string>();
            for (int i = 0; i < weight.Length; i++)
            {
                //slumpar vikten på de olika föremålen
                weight[i] = rand.Next(1, 101);
                //lägger till namnet på de objekt rollpersonen kan bära i listan som returneras
                if (weight[i] <= weightLimit)
                {
                    inventory.Add(names[i]);
                }
                Console.WriteLine(names[i] + ": " + weight[i]);

                Press();
            }
            Press();
            var dict = new Dictionary<string, int>
            {
                {"hje", 1 },
                {"hej", 2 },
                {"jhe", 3 }
            };
            return dict["hje"];
        }
        static void Press() //metod som gör det lite tydligare vad spelaren ska göra när ett knapptryck förväntas
        {
            Console.WriteLine("press any key to continue");
            Console.ReadKey(true);
            Console.Clear();
        }
        static Random rand = new Random();
    }
}
