﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project0
{
    public class Order
    {
       public int productid { get; set; }
       public int consumerid { get; set; }
        public int storeid   {get; set;}
        public List<Product> custcart = new List<Product>();
        public int Orderid { get; set; }
        public decimal Ordertotal { get; set; }

        public Order(consumer c, Store s)

        {
            this.Orderid = c.consumerId + s.StoreId;
            this.consumerid = c.consumerId;
            this.Ordertotal = c.CartTotal();
            productid = c.shoppingcart[1].product_number;
            
        
        }
    
    
    
    
    
    }
    


        

}
