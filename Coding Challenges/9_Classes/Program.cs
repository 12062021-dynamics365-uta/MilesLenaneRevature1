using System;

namespace _9_ClassesChallenge
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Human one = new Human("Blaster", "Mctopperson");
            Human two = new Human();
            Human2 hank = new Human2("Hank", "Hill", "Brown");
            Human2 peggy = new Human2("Peggy", "Hill", 33);
            Human2 bobby = new Human2("Bobby", "Hill", "Blue", 13);
            hank.AboutMe2();
            peggy.AboutMe2();
            bobby.AboutMe2();
            int weight=160;
            bobby.set_weight(weight);
            Console.WriteLine($"{bobby.get_weight()}");


        }
    }
}
