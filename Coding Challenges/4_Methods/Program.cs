using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Threading;


namespace _4_MethodsChallenge
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /**
                YOUR CODE HERE.
            **/
        }

        public static string GetName()
        {
            Console.WriteLine("Input name");
            string input = Console.ReadLine();
            return input;

            throw new NotImplementedException("GetName() is not implemented yet0");
        }

        public static string GreetFriend(string name)
        {
            string output;
            output = $"Hello, {name}. You are my friend.";
            return output;
            throw new NotImplementedException("GreetFriend() is not implemented yet");
        }

        public static double GetNumber()
        {
            string input = Console.ReadLine();
            while (input.Any(char.IsDigit)==false)
            {
                Console.WriteLine("Please input a number");    
            
            }
           return Convert.ToDouble(input);
           


            throw new NotImplementedException("GetNumber() is not implemented yet");

        }

        public static int GetAction()
        {
            bool is_valid = false;
            int selector;
            bool re_prompt = false;
            do
            {
                Console.WriteLine("Enter a number 1-4. 1 for addition, 2 for subtraction , 3 for multiplication , 4 for division");
                string userinput = Console.ReadLine();
               is_valid = int.
               TryParse(userinput, out selector);
                if (is_valid == false)
                {
                    Console.WriteLine("Invalid Input");

                }

                else if (is_valid == true)
                {
                    return selector;
                
                }



            }
            while (!re_prompt);
            return selector;


           



            throw new NotImplementedException("GetAction() is not implemented yet");
        }

        //private static int TryParse(string userinput, out int selector)
        //{

        //    throw new NotImplementedException();
        //}

        public static double DoAction(double x, double y, int action)
        {
            double result;
            switch (action)
            {

                case 1:
                    result = (x + y);
                    return result;
                    
                case 2:
                    result = (y - x );
                    return result;
                    
                case 3:
                    result = (x * y);
                    return result;
                    
                case 4:
                    result = (x / y);
                    return result;
                   

                default:

                    throw new FormatException("typeof(System.FormatException");



            }

        }
    }
}
