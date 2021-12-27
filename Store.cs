using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Project0
{
    public class Store
    {
        public int StoreId;
        public string AddressId;
       // public string StoreSaleID;
        public int productcount;
        public List<Product> Inventory=new List<Product>();


        public void get_list_inventory()
        {
            foreach (Product i in Inventory)
            {
                Console.WriteLine("---------------------------------------------------------------------------------");
                Console.WriteLine(i.product_name + ' ' + i.product_description + ' ' + i.price + ' ' + ' ' + ' '+ i.product_quantity);

            }


        }

        public Store(int StoreId, string AddressId, int productcount, List<Product> inventory)
        {
            this.StoreId = StoreId;
            this.AddressId = AddressId;
            this.productcount = productcount;
            this.Inventory = inventory;

        }

        public Store()
        { 
        
        }






    }
    
    
}

