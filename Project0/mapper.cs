using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Project0
{
   internal class Mapper : imapper
    {
        public List<consumer> Entity_to_ConsumerList(SqlDataReader dr)
        {
            List<consumer> consumers = new List<consumer>();
            while (dr.Read())
            {
                consumer c = new consumer()
                {
                    consumerId = Convert.ToInt32(dr[0].ToString()),
                    Fname = dr[1].ToString(),
                    Lname = dr[2].ToString(),
                    
                    



               };

               consumers.Add(c);
                Console.WriteLine(c.Fname, c.Lname);

            }
            dr.Close();
            return consumers;
        }


        public List<Product> Entity_to_InventoryList(SqlDataReader dr)
        {
            List<Product> inventory = new List<Product>();
            while (dr.Read())
            {
                Product p = new Product()
                {
                    product_quantity =Convert.ToInt32(dr[4].ToString()),
                    product_number = Convert.ToInt32(dr[5].ToString()),
                    product_name = dr[6].ToString(),
                    product_description = dr[7].ToString(),
                    price = Convert.ToDecimal(dr[8].ToString()),

                    



                };
                inventory.Add(p);
                                

            }
           // dr.Close();
            return inventory;
        }


        public List<Store> Entity_to_StoreList(SqlDataReader dr)
        {
            List<Store> storelist = new List<Store>();
            while (dr.Read())
            {
                Store s = new Store()
                { 
                    StoreId = Convert.ToInt32(dr[0].ToString()),
                    AddressId = dr[1].ToString(),



                };
                storelist.Add(s);            
            
            }
            dr.Close();
            return storelist; 

        }    
    }




}


