﻿using System;
using System.IO;
using System.Linq;

namespace _6_FlowControl
{
    public class Program
    {
       public static string username;
       public  static  string password;
        static void Main(string[] args)
        {
            Register();
            Login();
            int temperature = GetValidTemperature();
            GiveActivityAdvice(temperature);
            GetTemperatureTernary(temperature);
        }

        /// <summary>
        /// This method gets a valid temperature between -40 asnd 135 inclusive from the user
        /// and returns the valid int. 
        /// </summary>
        /// <returns></returns>
        public static int GetValidTemperature()
        {
            int userint;
            string userinput;
            Console.WriteLine("Please input a temperature");
            bool valid_input;
            userinput = Console.ReadLine();
          valid_input=  int.TryParse(userinput, out userint);
            while (userint < -40 || userint > 135)
            {

                Console.WriteLine("Invalid input please reinput");
                userinput = Console.ReadLine();
            
            
            }

            return userint;

            //throw new NotImplementedException($"GetValidTemperature() has not been implemented.");
        }

        /// <summary>
        /// This method has one int parameter
        /// It prints outdoor activity advice and temperature opinion to the console 
        /// based on 20 degree increments starting at -20 and ending at 135 
        /// n < -20, Console.Write("hella cold");
        /// -20 <= n < 0, Console.Write("pretty cold");
        ///  0 <= n < 20, Console.Write("cold");
        /// 20 <= n < 40, Console.Write("thawed out");
        /// 40 <= n < 60, Console.Write("feels like Autumn");
        /// 60 <= n < 80, Console.Write("perfect outdoor workout temperature");
        /// 80 <= n < 90, Console.Write("niiice");
        /// 90 <= n < 100, Console.Write("hella hot");
        /// 100 <= n < 135, Console.Write("hottest");
        /// </summary>
        /// <param name="temp"></param>
        public static void GiveActivityAdvice(int temp)
        {
            
                if (temp < -20)
                    Console.WriteLine("hella cold");
                else if (-20 <= temp && temp < 0)
                    Console.WriteLine("pretty cold");
                else if (0 <= temp && temp < 20)
                    Console.WriteLine("cold");
                else if (20 <= temp && temp < 40)
                    Console.WriteLine("thawed out");
                else if (40 <= temp && temp < 60)
                    Console.WriteLine("feels like Autumn");
                else if (60 <= temp && temp < 80)
                    Console.WriteLine("perfect outdoor workout temperature");
                else if (80 <= temp && temp < 90)
                    Console.WriteLine("niiice");
                else if (90 <= temp && temp < 100)
                    Console.WriteLine("hella hot");
                else if (100 <= temp && temp <= 135)
                    Console.WriteLine("hottest");
            

          //  throw new NotImplementedException($"GiveActivityAdvice() has not been implemented.");

        }

        /// <summary>
        /// This method gets a username and password from the user
        /// and stores that data in the global variables of the 
        /// names in the method.
        /// </summary>
        public static void Register()
        {

            username = Console.ReadLine();
            password = Console.ReadLine();


            throw new NotImplementedException($"Register() has not been implemented.");
        }

        /// <summary>
        /// This method gets username and password from the user and
        /// compares them with the username and password names provided in Register().
        /// If the password and username match, the method returns true. 
        /// If they do not match, the user is reprompted for the username and password
        /// until the exact matches are inputted.
        /// </summary>
        /// <returns></returns>
        public static bool Login()
        {
            string temp_username = Console.ReadLine();
            string temp_password = Console.ReadLine();
            if (temp_username == username && temp_password == password)
            {
                return true;
            }
            else 
            {
                return false;
            }
        //    throw new NotImplementedException($"Login() has not been implemented.");
        }

        /// <summary>
        /// This method has one int parameter.
        /// It checks if the int is <=42, Console.WriteLine($"{temp} is too cold!");
        /// between 43 and 78 inclusive, Console.WriteLine($"{temp} is an ok temperature");
        /// or > 78, Console.WriteLine($"{temp} is too hot!");
        /// For each temperature range, a different advice is given. 
        /// </summary>
        /// <param name="temp"></param>
        public static void GetTemperatureTernary(int temp)
        {
            string x;
          x =  temp <= 42 ? $"{temp} is too cold!" : temp >= 43 && temp <= 78 ? $"{temp} is an ok temperature" : $"{temp} is too hot!";
            Console.WriteLine(x);

          //  throw new NotImplementedException($"GetTemperatureTernary() has not been implemented.");
        }
    }//EoP
}//EoN
