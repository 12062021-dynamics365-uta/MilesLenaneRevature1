using System;
using System.Collections.Generic;

namespace _7_GuessingGameChallenge
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int outcome;
            int userguess;
            int rounds_played=1;
            bool play_again;
            List<int> list_of_guesses_ = new List<int>();
            Console.WriteLine("Would you like to play guess game? Pick number between 1-100");
            
            do
            {

                while (rounds_played <= 10)
                {
                    userguess = GetUsersGuess();
                    list_of_guesses_.Add(userguess);
                    outcome = CompareNums(userguess, GetRandomNumber());
                    if (outcome == 0)
                    {
                        Console.WriteLine("You guessed correctly");
                        break;
                    }

                    else
                    {
                        Console.WriteLine("you guessed incorrectly");
                        rounds_played++;

                    }




                }
                play_again = PlayGameAgain();
            } 
            while (play_again);
           
        }

        /// <summary>
        /// This method returns a randomly chosen number between 1 and 100, inclusive.
        /// </summary>
        /// <returns></returns>
        public static int GetRandomNumber()
        {
            Random rand = new Random();
            int randomnum = rand.Next(1, 101);
            return randomnum;

            throw new NotImplementedException();
        }

        /// <summary>
        /// This method gets input from the user, 
        /// verifies that the input is valid and 
        /// returns an int.
        /// </summary>
        /// <returns></returns>
        public static int GetUsersGuess()
        {
            int userguess;
            string userinput;
            userinput = Console.ReadLine();
            bool validator;
            do
            {
                Console.WriteLine("Input number between 0 and 100:");
                validator = int.TryParse(Console.ReadLine(), out userguess);
                if (!validator)
                {
                    Console.WriteLine("Invalid input");
                }
                else if (userguess < 0 || userguess > 100)
                {
                    Console.WriteLine("Input out of bounds");
                    validator = false;
                }



            }
            while (!validator);
            return userguess;
           // throw new NotImplementedException();
        }

        /// <summary>
        /// This method will has two int parameters.
        /// It will:
        /// 1) compare the first number to the second number
        /// 2) return -1 if the first number is less than the second number
        /// 3) return 0 if the numbers are equal
        /// 4) return 1 if the first number is greater than the second number
        /// </summary>
        /// <param name="randomNum"></param>
        /// <param name="guess"></param>
        /// <returns></returns>
        public static int CompareNums(int randomNum, int guess)
        {
            if (randomNum < guess)
            {
                return -1;
            }
            else if (randomNum == guess)
            {
                return 0;

            }
            else
            {
                return 1;
            }
            throw new NotImplementedException();
        }

        /// <summary>
        /// This method offers the user the chance to play again. 
        /// It returns true if they want to play again and false if they do not.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static bool PlayGameAgain()
        {
            string userinput;
            bool play_again;
            Console.WriteLine("Would you like to play again? press 1 for yes, 2 for no");
            userinput = Console.ReadLine();
            if (userinput == "1")
            {
                return true;
            }

            else 
            {
                return false;
            }
            throw new NotImplementedException();
        }
    }
}
