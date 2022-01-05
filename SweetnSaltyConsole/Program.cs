using System;

namespace sweetnsalty
{
    class Program
    {
        static void Main(string[] args)
        {
            int num_salts=0;
            int num_sweets=0;
            int num_sweetnsalts=0;
            for (int i = 1; i < 1001; i++)
            {
              

                if (i % 20 == 0)
                {

                    Console.WriteLine();
                }

                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.Write("Sweet and Salty ");
                    num_sweetnsalts++;

                }

                else if (i % 5 == 0)
                {
                    Console.Write("Salty ");
                    num_salts++;
                }

                else if (i%3==0)
                {
                    Console.Write("Sweet ");
                    num_sweets++;
                }

                else 
                {
                   Console.Write(i + " ");
                }
            }
            Console.WriteLine("     ");
            Console.WriteLine($"Number of Sweet's : {num_sweets}");
            Console.WriteLine($"Number of Salty's : {num_salts}");
            Console.WriteLine($"Number of Sweet 'n Salty's {num_sweetnsalts}");


        }
    }
}
