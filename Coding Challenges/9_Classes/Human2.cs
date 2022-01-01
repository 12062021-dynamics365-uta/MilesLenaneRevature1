using System;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("9_ClassesChallenge.Tests")]
namespace _9_ClassesChallenge
{
    internal class Human2
    {
        private string first_name="Pat";
        private string last_name="Smyth";
        private string eye_color;
        private int age_;
        public int weight;
      
        
       public int get_weight()
        {

            return weight;
        }
        
       
        
      public  void set_weight(int weight_)
        {
            if (weight_ > 0 && weight_ < 400)
            {
                weight = weight_;
            }

            else
            {
                weight = 0;
            }
            
        }
        
        public Human2()
        { 
        
        
        }


        


        public Human2 (string firstname, string lastname,string eyecolor, int age)
        {
            first_name = firstname;
            last_name = lastname;
            eye_color = eyecolor;
            age_ = age;





        }


        public Human2(string firstname, string lastname, int age)
        {

            first_name = firstname;
            last_name = lastname;
           
            age_ = age;


        }


        public Human2(string firstname, string lastname, string eyecolor)
        {

            first_name = firstname;
            last_name = lastname;
            eye_color = eyecolor;
            

        }

        public string AboutMe2()

        {
            if (eye_color == null && age_ == 0)
            {
                return $"My name is {first_name} {last_name}.";


            }

            else if (eye_color == null)
            {

                return $"My name is {first_name} {last_name}. My age is {age_}.";

            }


            else if (age_ == 0)
            {
                return $"My name is {first_name} {last_name}. My eye color is {eye_color}.";


            }

            else 
            {
                return $"My name is {first_name} {last_name}. My age is {age_}. My eye color is {eye_color}.";

            }
        
        }







    }
}