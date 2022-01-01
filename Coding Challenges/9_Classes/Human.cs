using System;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("9_ClassesChallenge.Tests")]
namespace _9_ClassesChallenge
{
    internal class Human
    {
        private string lastName = "Smyth";
        private string firstName = "Pat";








       public Human(string firstname, string lastname)
        {
            firstName = firstname;
            lastName = lastname;
        
        }

         public Human()
        { 
        
        }


        public string AboutMe() 
        {

            return $"My name is {firstName} {lastName}.";
        
        
        
        
        }
    }




    

           
    
    
    
    //end of class
}//end of namespace