using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


 
namespace Project0
{
    public class consumer
    {   
        public string username { get; set; }
        public string password { get; set; }
        public int consumerId { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Address { get; set; }
        public string last_order { get; set;}
        public List<Product> shoppingcart = new List<Product>();
       
        
        public consumer(string fname, string lname)
        {
            Fname=fname;
            Lname=lname;
             
        }

        public void viewshoppingcart()
        {
            foreach(Product x in this.shoppingcart)
            {
                Console.WriteLine(x.product_name);
            }
        
        }

        public void add_to_shoppingcart(Product s)
        {
            this.shoppingcart.Add(s);
        }



        public void remove_from_shoppingcart(Product s)
        {
            this.shoppingcart.Remove(s);
        }




        public consumer()
        { 
        
        
        }



        internal decimal CartTotal()
        {
            decimal totalCost;
            return totalCost = Math.Round(shoppingcart.Sum(p => p.price), 2); //pretty sure I got this from Daniel or Aldo. One of them.
        }




    }




    
}

