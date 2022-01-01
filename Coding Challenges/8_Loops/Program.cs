using System;
using System.Collections.Generic;

namespace _8_LoopsChallenge
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /* Your code here */

        }

        /// <summary>
        /// Return the number of elements in the List<int> that are odd.
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static int UseFor(List<int> x)
        {
            int num_of_odds=0;
            for (int i = 0; i < x.Count; i++)
            {
                if (x[i] % 2 != 0)
                {
                    num_of_odds++;
                }
                
            }
            return num_of_odds;
            //throw new NotImplementedException("UseFor() is not implemented yet.");
        }

        /// <summary>
        /// This method counts the even entries from the provided List<object> 
        /// and returns the total number found.
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static int UseForEach(List<object> x)
        {
            int evens = 0;
            foreach (object y in x)
            {
                if ((Int16)y % 2 == 0)
                {
                    evens++;

                }
                else if ((UInt16)y % 2 == 0)
                {
                    evens++;
                }

                else if ((Int32)y % 2 == 0)
                {
                    evens++;
                }
                else if ((UInt32)y % 2 == 0)
                {
                    evens++;
                }
                else if ((Int64)y % 2 == 0)
                {
                    evens++;
                }
                else if ((UInt64)y % 2 == 0)
                {
                    evens++;
                }
                
            
            }

            return evens;

          //  throw new NotImplementedException("UseForEach() is not implemented yet.");
        }

        /// <summary>
        /// This method counts the multiples of 4 from the provided List<int>. 
        /// Exit the loop when the integer 1234 is found.
        /// Return the total number of multiples of 4.
        /// </summary>
        /// <param name="x"></param>
        public static int UseWhile(List<int> x)
        {
            bool complete = false;
            int num_of_iderations = 0;
            int count = 0;
            while (num_of_iderations<x.Count)
            {
                if (x[num_of_iderations] % 4 == 0)
                {
                    count++;



                    if (x[num_of_iderations] == 1234)
                    {
                        break;
                        count++;
                    }

                }

              

                
            }
            return count;

           //throw new NotImplementedException("UseFor() is not implemented yet.");
        }

        /// <summary>
        /// This method will evaluate the Int Array provided and return how many of its 
        /// values are multiples of 3 and 4.
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static int UseForThreeFour(int[] x)
        {
            int int_of_times=0;

            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] % 4 == 0 && x[i] % 3 == 0)
                {
                    int_of_times++;
                }

                
            }
            return int_of_times;
        }

        /// <summary>
        /// This method takes an array of List<string>'s. 
        /// It concatenates all the strings, with a space between each, in the Lists and returns the resulting string.
        /// </summary>
        /// <param name="stringListArray"></param>
        /// <returns></returns>
        public static string LoopdyLoop(List<string>[] stringListArray)
        {
            string full_sent = "";
            foreach (List<string> blast in stringListArray)
            {
                foreach (string strr in blast)
                {
                    full_sent += strr + "";
                
                }
            
            }

            return full_sent;

        }
    }
}