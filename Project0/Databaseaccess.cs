using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;



namespace Project0
{

    public class Databaseaccess
    {

        public readonly string str = "Data source = DESKTOP-O9829S0\\SQLEXPRESS01; initial Catalog=Vendor; integrated security =true";
        private readonly SqlConnection conn;
        private readonly imapper _mapper;

        public Databaseaccess()
        {
            conn = new SqlConnection(str);
            conn.Open();
            this._mapper = new Mapper();

        }

        internal List<consumer> storeallconsumers()
        {
            string query = "SELECT * FROM Customers";
            List <consumer> customerlist = new List<consumer>();
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                SqlDataReader dr = cmd.ExecuteReader();
                customerlist = this._mapper.Entity_to_ConsumerList(dr);
             //   this.conn.Close();
            }
            
            return customerlist;

        }


        public void access()
        {

            String productquerystring = "SELECT * from PRODUCTS";
            SqlCommand cmd = new SqlCommand(productquerystring, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {

                Console.WriteLine(dr[0].ToString() + " " + dr[1].ToString() + " ");

            }


            dr.Close();

        }

        public void addUser(consumer c)
        {
            
            string s = "propaneprogain";
            
            Console.WriteLine($"{c.Fname}, {c.Lname}, {c.username}, {c.password}");
            string querystring = $"INSERT INTO CUSTOMERS (FirstName,LastName,Username,Password) VALUES ('{c.Fname}', '{c.Lname}', '{c.username}','{c.password}');";
            SqlCommand command = new SqlCommand(querystring, conn);
            SqlDataReader dr = command.ExecuteReader();
            dr.Read();



            dr.Close();
        }

        public void addOrder(Order a)
        {
            //Console.WriteLine($"{a.Orderid}, {a.consumerid}, {a.Ordertotal},{a.productid}");
            string querystring = $"INSERT INTO Orders (OrderId,CustomerId,SaleTotal,ProductId) VALUES ('{a.Orderid}', '{a.consumerid}', '{a.Ordertotal}','{a.productid}');";
            SqlCommand command = new SqlCommand(querystring, conn);
            SqlDataReader dr = command.ExecuteReader();
            dr.Read();



            dr.Close();




        }




        public void get_productlist()
        {

            SqlCommand command;

            command = conn.CreateCommand();
            String productquerystring = "SELECT * from PRODUCTS";
            //   command.ExecuteNonQuery();
            using (command = new SqlCommand(productquerystring, conn))
            {
                using (SqlDataReader dr = command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        for (int i = 0; i < dr.FieldCount; i++)
                        {
                            Console.Write(dr.GetValue(i) + "\n");
                        }
                        Console.WriteLine("----------------");
                        
                    }
                     dr.Close();
                }
                
            }
          //  conn.Close();
        }

        public void get_locations()
        {



            SqlCommand command;

            command = conn.CreateCommand();
            String productquerystring = "SELECT * from STORES";
            //   command.ExecuteNonQuery();
            using (command = new SqlCommand(productquerystring, conn))
            {
                using (SqlDataReader dr = command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        for (int i = 0; i < dr.FieldCount; i++)
                        {
                            Console.Write(dr.GetValue(i) + "\t");
                        }
                        Console.WriteLine();
                    }

                    dr.Close();
                }

            }
           
        }








        public List<Product> get_inventory(int storenumber)
        {
            List<Product> inventory = new List<Product>();
            SqlCommand command;
            command = conn.CreateCommand();          
            string query = $"SELECT * FROM STORES INNER JOIN INVENTORY ON STORES.StoreId = INVENTORY.StoreId " +
                $"INNER JOIN PRODUCTS ON INVENTORY.ProductId = PRODUCTS.ProductId WHERE INVENTORY.StoreId = {storenumber}; ";
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                SqlDataReader dr = cmd.ExecuteReader();
                inventory = this._mapper.Entity_to_InventoryList(dr);
                dr.Close();
            }

            return inventory;





        }



        public List<Store> get_storelist()
        {
            
            SqlCommand command;
            command = conn.CreateCommand();
            string query = "SELECT * FROM STORES";
            List<Store> Storelist = new List<Store>();
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                SqlDataReader dr = cmd.ExecuteReader();
                Storelist = this._mapper.Entity_to_StoreList(dr);
                dr.Close();
            }
            
            return Storelist;





        }
















    }
}
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /*  public void Get_products()

        {

            String str = "Data source = DESKTOP-O9829S0\\SQLEXPRESS01; initial Catalog=Vendor; integrated security =true";
            SqlConnection conn = new SqlConnection(str);
            String productquerystring = "SELECT * from PRODUCTS";
            conn.Open();
            SqlCommand cmd = new SqlCommand(productquerystring, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {

                for (int i = 0; i < dr.FieldCount; i++)
                {
                    Console.WriteLine(SqlDataReader.GetValue(i)); //Console.WriteLine(dr[0].ToString() + " " + dr[1].ToString() + " ");

                }
                Console.WriteLine();
            }
            */
        


