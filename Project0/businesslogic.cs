using System;
using System.Collections.Generic;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Threading;


namespace Project0
{








    class businesslogic
    {


        consumer user;
        decimal total;
        List<Product> testlist = new List<Product>();
        List<consumer> comparlist = new List<consumer>();
        List<consumer> customerlist = new List<consumer>();
        List<Store> storelist = new List<Store>();
        Mapper mapper = new Mapper();
        
        
        bool cartbool = false;

        Databaseaccess blast = new Databaseaccess();
        

        









        public bool login_or_create_account()
        {


            bool login_successful;
          //
            Console.WriteLine("Please Login or Create a New Account.");
           
            string password;
            //else if(){}
            Console.WriteLine("Welcome to Strickland Propane");
            Console.WriteLine("First name please:");
            string firstname = Console.ReadLine();
            Console.WriteLine("Lastname please:");
            string lastname = Console.ReadLine();



            while (firstname.Any(char.IsDigit) == true || lastname.Any(char.IsDigit) == true || firstname.Any(char.IsPunctuation) == true || lastname.Any(char.IsPunctuation) == true)
            {
                Console.WriteLine("Error Invalid Input, please reinput first and or last name");
                firstname = Console.ReadLine();
                lastname = Console.ReadLine();
                login_successful = false;


            }

             user = new consumer(firstname, lastname);
          
           




            Console.WriteLine($"your user name is: {firstname}+ {lastname}");
            
            
            firstname = user.Fname;
            lastname = user.Lname;
            user.username = firstname + lastname;
            //comparlist = blast.storeallconsumers();
            
            this.customerlist.Add(user);
            Console.WriteLine("Please Enter a Password");
            password = Console.ReadLine();
            password = user.password;


            

            blast.addUser(user);
          
           return login_successful = true;


        }







       
        public void Menu(bool login_successful)
        {
            consumer user = new consumer();
            // Console.Clear();
            //testlist = blast.get_inventory();
            storelist = blast.get_storelist();
            Store selected_Store = new Store();
            
            
            
            
            
            
            

           // Console.WriteLine(selected_Store.Inventory.ToString());
            bool shopping = false;
            bool exit = false;
            string userinput;
            string locationchoice;
            Console.WriteLine("Welcome To Stickland, We sell Propane and Propane Accessories Press 1 for Inventory, 2 to see store locations, 3, to view cart, 4 to log out");

            if (login_successful == true);
            {

                do
                {
                    userinput = Console.ReadLine();

                    switch (userinput)
                    {
                        case "1":
                            Console.Clear();
                            blast.get_productlist();
                            break;
                        case "2":
                            blast.get_locations();
                            Console.WriteLine("Please Select a Store Location. Enter 1-6 ");
                            locationchoice = Console.ReadLine();
                            if (locationchoice == "1")
                            {
                                int choice = Convert.ToInt32(locationchoice);
                                selected_Store = storelist[0];
                                selected_Store.Inventory = blast.get_inventory(choice);
                                string selector;
                                Console.WriteLine("This executed just after the store list");
                              //  Console.WriteLine(blast.get_inventory[1]);
                                Console.WriteLine(selected_Store.AddressId);
                                
                              // Console.Clear();
                                Console.WriteLine("You have Selected the Arlen Location!");
                                Console.WriteLine("");
                                Console.WriteLine("Welcome to Stickland Arlen! We sell propane and propane accessories!");
                                Console.WriteLine("Here is our Inventory:");
                                selected_Store.get_list_inventory();

                                Console.WriteLine(selected_Store.Inventory.Count());
                                do
                                {
                                    shopping = true;
                                    Console.WriteLine("You are now shopping at the Stickland Arlen Location");
                                    Console.WriteLine("Press 1-6 to add a corresponding product into your cart, press 7 to exit");
                                    selector = Console.ReadLine();
                                    if (selector == "1")
                                    {
                                        Console.WriteLine("Purchasing a 20 pound propane tank");
                                       
                                        user.add_to_shoppingcart(selected_Store.Inventory[0]);
                                        user.viewshoppingcart();
                                        
                                       selected_Store.Inventory[0].product_quantity--;
                                        if (selected_Store.Inventory[0].product_quantity == 0)
                                        {
                                            Console.WriteLine("We're out of propane!");
                                        
                                        }
                                        selected_Store.get_list_inventory();


                                    }
                                   else if (selector == "2")
                                    {
                                        Console.WriteLine("Purchasing a 60 pound propane tank");

                                        user.add_to_shoppingcart(selected_Store.Inventory[1]);
                                        user.viewshoppingcart();

                                        selected_Store.Inventory[1].product_quantity--;
                                        if (selected_Store.Inventory[1].product_quantity == 0)
                                        {
                                            Console.WriteLine("We're out of propane!");

                                        }
                                        selected_Store.get_list_inventory();

                                    }
                                   else if (selector == "3")
                                    {

                                        Console.WriteLine("Purchasing a 60 pound propane tank");

                                        user.add_to_shoppingcart(selected_Store.Inventory[2]);
                                        user.viewshoppingcart();

                                        selected_Store.Inventory[2].product_quantity--;
                                        if (selected_Store.Inventory[2].product_quantity == 0)
                                        {
                                            Console.WriteLine("We're out of propane!");

                                        }
                                        selected_Store.get_list_inventory();
                                    }
                                   else if (selector == "4")
                                    {

                                        Console.WriteLine("Purchasing a 120 pound propane tank");

                                        user.add_to_shoppingcart(selected_Store.Inventory[3]);
                                        user.viewshoppingcart();

                                        selected_Store.Inventory[3].product_quantity--;
                                        if (selected_Store.Inventory[3].product_quantity == 0)
                                        {
                                            Console.WriteLine("We're out of propane!");

                                        }

                                        selected_Store.get_list_inventory();

                                    }
                                   else if (selector == "5")
                                    {
                                        Console.WriteLine("Purchasing a 250 pound propane tank");

                                        user.add_to_shoppingcart(selected_Store.Inventory[4]);
                                        user.viewshoppingcart();

                                        selected_Store.Inventory[4].product_quantity--;
                                        if (selected_Store.Inventory[4].product_quantity == 0)
                                        {
                                            Console.WriteLine("We're out of propane!");

                                        }


                                        selected_Store.get_list_inventory();


                                    }
                                   else if (selector == "6")
                                    {

                                        Console.WriteLine("You just bought the Charking imperial! Happy gilling");

                                        user.add_to_shoppingcart(selected_Store.Inventory[5]);
                                        user.viewshoppingcart();

                                        selected_Store.Inventory[5].product_quantity--;
                                        if (selected_Store.Inventory[5].product_quantity == 0)
                                        {
                                            Console.WriteLine("We're out of Charkings! but don't sweat it more are coming");

                                        }

                                        selected_Store.get_list_inventory();

                                    }
                                    else if (selector == "7")
                                    {
                                        shopping = false;
                                    }



                                    decimal total = user.CartTotal();
                                    Console.WriteLine(total);
                                   

                                }
                                while(shopping == true) ;



                               




                            }
                            else if (locationchoice == "2")
                            {

                                
                                int choice = Convert.ToInt32(locationchoice);
                                selected_Store = storelist[1];
                                selected_Store.Inventory = blast.get_inventory(choice);
                                string selector;
                           
                                Console.WriteLine("You have Selected the McMainerburry Lccation!");
                                Console.WriteLine("");
                                Console.WriteLine("Welcome to Stickland Mcmainerburry! We sell propane and propane accessories!");
                                Console.WriteLine("Here is our Inventory:");
                                selected_Store.get_list_inventory();
                                do
                                {
                                    shopping = true;
                                    Console.WriteLine("You are now shopping at the Stickland  Location");
                                    Console.WriteLine("Press 1-6 to add a corresponding product into your cart, press 7 to exit");
                                    selector = Console.ReadLine();
                                    if (selector == "1")
                                    {
                                        Console.WriteLine("Purchasing a 20 pound propane tank");

                                        user.add_to_shoppingcart(selected_Store.Inventory[0]);
                                        user.viewshoppingcart();

                                        selected_Store.Inventory[0].product_quantity--;
                                        if (selected_Store.Inventory[0].product_quantity == 0)
                                        {
                                            Console.WriteLine("We're out of propane!");

                                        }
                                        selected_Store.get_list_inventory();


                                    }
                                    else if (selector == "2")
                                    {
                                        Console.WriteLine("Purchasing a 60 pound propane tank");

                                        user.add_to_shoppingcart(selected_Store.Inventory[1]);
                                        user.viewshoppingcart();

                                        selected_Store.Inventory[1].product_quantity--;
                                        if (selected_Store.Inventory[1].product_quantity == 0)
                                        {
                                            Console.WriteLine("We're out of propane!");

                                        }
                                        selected_Store.get_list_inventory();

                                    }
                                    else if (selector == "3")
                                    {

                                        Console.WriteLine("Purchasing a 60 pound propane tank");

                                        user.add_to_shoppingcart(selected_Store.Inventory[2]);
                                        user.viewshoppingcart();

                                        selected_Store.Inventory[2].product_quantity--;
                                        if (selected_Store.Inventory[2].product_quantity == 0)
                                        {
                                            Console.WriteLine("We're out of propane!");

                                        }
                                        selected_Store.get_list_inventory();
                                    }
                                    else if (selector == "4")
                                    {

                                        Console.WriteLine("Purchasing a 120 pound propane tank");

                                        user.add_to_shoppingcart(selected_Store.Inventory[3]);
                                        user.viewshoppingcart();

                                        selected_Store.Inventory[3].product_quantity--;
                                        if (selected_Store.Inventory[3].product_quantity == 0)
                                        {
                                            Console.WriteLine("We're out of propane!");

                                        }

                                        selected_Store.get_list_inventory();

                                    }
                                    else if (selector == "5")
                                    {
                                        Console.WriteLine("Purchasing a 250 pound propane tank");

                                        user.add_to_shoppingcart(selected_Store.Inventory[4]);
                                        user.viewshoppingcart();

                                        selected_Store.Inventory[4].product_quantity--;
                                        if (selected_Store.Inventory[4].product_quantity == 0)
                                        {
                                            Console.WriteLine("We're out of propane!");

                                        }


                                        selected_Store.get_list_inventory();


                                    }
                                    else if (selector == "6")
                                    {

                                        Console.WriteLine("You just bought the Charking imperial! Happy gilling");

                                        user.add_to_shoppingcart(selected_Store.Inventory[5]);
                                        user.viewshoppingcart();

                                        selected_Store.Inventory[5].product_quantity--;
                                        if (selected_Store.Inventory[5].product_quantity == 0)
                                        {
                                            Console.WriteLine("We're out of Charkings! but don't sweat it more are coming");

                                        }

                                        selected_Store.get_list_inventory();

                                    }
                                    else if (selector == "7")
                                    {
                                        shopping = false;
                                    }

                                    decimal total = user.CartTotal();
                                    Console.WriteLine(total);
                                    
                                    


                                }
                                while (shopping == true);





                            }
                            else if (locationchoice == "3")
                            {

                                selected_Store = storelist[2];

                                int choice = Convert.ToInt32(locationchoice);
                                selected_Store.Inventory = blast.get_inventory(choice);
                                Console.Clear();
                                Console.WriteLine("You have Selected the Cedar Hill Lccation!");
                                Console.WriteLine("");
                                Console.WriteLine("Welcome to Stickland Cedar Hill! We sell propane and propane accessories!");
                                Console.WriteLine("Here is our Inventory:");
                                do
                                {
                                    shopping = true;
                                    Console.WriteLine("You are now shopping at the Stickland Cedar hill Location");
                                    Console.WriteLine("Press 1-6 to add a corresponding product into your cart, press 7 to exit");
                                   string selector = Console.ReadLine();
                                    if (selector == "1")
                                    {
                                        Console.WriteLine("Purchasing a 20 pound propane tank");

                                        user.add_to_shoppingcart(selected_Store.Inventory[0]);
                                        user.viewshoppingcart();

                                        selected_Store.Inventory[0].product_quantity--;
                                        while (selected_Store.Inventory[0].product_quantity == 0)
                                        {
                                            Console.WriteLine("We're out of propane!");

                                        }
                                        selected_Store.get_list_inventory();


                                    }
                                    else if (selector == "2")
                                    {
                                        Console.WriteLine("Purchasing a 60 pound propane tank");

                                        user.add_to_shoppingcart(selected_Store.Inventory[1]);
                                        user.viewshoppingcart();

                                        selected_Store.Inventory[1].product_quantity--;
                                        if (selected_Store.Inventory[1].product_quantity == 0)
                                        {
                                            Console.WriteLine("We're out of propane!");

                                        }
                                        selected_Store.get_list_inventory();

                                    }
                                    else if (selector == "3")
                                    {

                                        Console.WriteLine("Purchasing a 60 pound propane tank");

                                        user.add_to_shoppingcart(selected_Store.Inventory[2]);
                                        user.viewshoppingcart();

                                        selected_Store.Inventory[2].product_quantity--;
                                        if (selected_Store.Inventory[2].product_quantity == 0)
                                        {
                                            Console.WriteLine("We're out of propane!");

                                        }
                                        selected_Store.get_list_inventory();
                                    }
                                    else if (selector == "4")
                                    {

                                        Console.WriteLine("Purchasing a 120 pound propane tank");

                                        user.add_to_shoppingcart(selected_Store.Inventory[3]);
                                        user.viewshoppingcart();

                                        selected_Store.Inventory[3].product_quantity--;
                                        if (selected_Store.Inventory[3].product_quantity == 0)
                                        {
                                            Console.WriteLine("We're out of propane!");

                                        }

                                        selected_Store.get_list_inventory();

                                    }
                                    else if (selector == "5")
                                    {
                                        Console.WriteLine("Purchasing a 250 pound propane tank");

                                        user.add_to_shoppingcart(selected_Store.Inventory[4]);
                                        user.viewshoppingcart();

                                        selected_Store.Inventory[4].product_quantity--;
                                        if (selected_Store.Inventory[4].product_quantity == 0)
                                        {
                                            Console.WriteLine("We're out of propane!");

                                        }


                                        selected_Store.get_list_inventory();


                                    }
                                    else if (selector == "6")
                                    {

                                        Console.WriteLine("You just bought the Charking imperial! Happy gilling");

                                        user.add_to_shoppingcart(selected_Store.Inventory[5]);
                                        user.viewshoppingcart();

                                        selected_Store.Inventory[5].product_quantity--;
                                        if (selected_Store.Inventory[5].product_quantity == 0)
                                        {
                                            Console.WriteLine("We're out of Charkings! but don't sweat it more are coming");

                                        }

                                        selected_Store.get_list_inventory();

                                    }

                                    else if (selector == "7")
                                    {
                                        shopping = false;
                                    }


                                    decimal total = user.CartTotal();
                                    Console.WriteLine(total);


                                }
                                while (shopping == true);







                            }
                            else if (locationchoice == "4")
                            {
                                selected_Store = storelist[3];

                                int choice = Convert.ToInt32(locationchoice);
                               selected_Store.Inventory = blast.get_inventory(choice);
                                Console.Clear();
                                Console.WriteLine("You have Selected the Desoto Lccation!");
                                Console.WriteLine("");
                                Console.WriteLine("Welcome to Stickland DeSoto! We sell propane and propane accessories!");
                                Console.WriteLine("Here is our Inventory:");
                                //blast.get_productlist();
                                Console.WriteLine("You have Selected the DeSoto Lccation!");
                                Console.WriteLine("Welcome to Stickland DeSoto! We sell propane and propane accessories!");
                                Console.WriteLine("Here is our Inventory:");
                                do
                                {
                                    shopping = true;
                                    Console.WriteLine("You are now shopping at the Stickland Cedar hill Location");
                                    Console.WriteLine("Press 1-6 to add a corresponding product into your cart, press 7 to exit");
                                    string selector = Console.ReadLine();
                                    if (selector == "1")
                                    {
                                        Console.WriteLine("Purchasing a 20 pound propane tank");

                                        user.add_to_shoppingcart(selected_Store.Inventory[0]);
                                        user.viewshoppingcart();

                                        selected_Store.Inventory[0].product_quantity--;
                                        while (selected_Store.Inventory[0].product_quantity == 0)
                                        {
                                            Console.WriteLine("We're out of propane!");

                                        }
                                        selected_Store.get_list_inventory();


                                    }
                                    else if (selector == "2")
                                    {
                                        Console.WriteLine("Purchasing a 60 pound propane tank");

                                        user.add_to_shoppingcart(selected_Store.Inventory[1]);
                                        user.viewshoppingcart();

                                        selected_Store.Inventory[1].product_quantity--;
                                        if (selected_Store.Inventory[1].product_quantity == 0)
                                        {
                                            Console.WriteLine("We're out of propane!");

                                        }
                                        selected_Store.get_list_inventory();

                                    }
                                    else if (selector == "3")
                                    {

                                        Console.WriteLine("Purchasing a 60 pound propane tank");

                                        user.add_to_shoppingcart(selected_Store.Inventory[2]);
                                        user.viewshoppingcart();

                                        selected_Store.Inventory[2].product_quantity--;
                                        if (selected_Store.Inventory[2].product_quantity == 0)
                                        {
                                            Console.WriteLine("We're out of propane!");

                                        }
                                        selected_Store.get_list_inventory();
                                    }
                                    else if (selector == "4")
                                    {

                                        Console.WriteLine("Purchasing a 120 pound propane tank");

                                        user.add_to_shoppingcart(selected_Store.Inventory[3]);
                                        user.viewshoppingcart();

                                        selected_Store.Inventory[3].product_quantity--;
                                        if (selected_Store.Inventory[3].product_quantity == 0)
                                        {
                                            Console.WriteLine("We're out of propane!");

                                        }

                                        selected_Store.get_list_inventory();

                                    }
                                    else if (selector == "5")
                                    {
                                        Console.WriteLine("Purchasing a 250 pound propane tank");

                                        user.add_to_shoppingcart(selected_Store.Inventory[4]);
                                        user.viewshoppingcart();

                                        selected_Store.Inventory[4].product_quantity--;
                                        if (selected_Store.Inventory[4].product_quantity == 0)
                                        {
                                            Console.WriteLine("We're out of propane!");

                                        }


                                        selected_Store.get_list_inventory();


                                    }
                                    else if (selector == "6")
                                    {

                                        Console.WriteLine("You just bought the Charking imperial! Happy gilling");

                                        user.add_to_shoppingcart(selected_Store.Inventory[5]);
                                        user.viewshoppingcart();

                                        selected_Store.Inventory[5].product_quantity--;
                                        if (selected_Store.Inventory[5].product_quantity == 0)
                                        {
                                            Console.WriteLine("We're out of Charkings! but don't sweat it more are coming");

                                        }

                                        selected_Store.get_list_inventory();

                                    }
                                    else if (selector == "7")
                                    {
                                        shopping = false;
                                    }



                                    decimal total = user.CartTotal();
                                    Console.WriteLine(total);


                                }
                                while (shopping == true);











                            }
                            else if (locationchoice == "5")
                            {
                                selected_Store = storelist[4];

                                int choice = Convert.ToInt32(locationchoice);
                                selected_Store.Inventory = blast.get_inventory(choice);

                                Console.Clear();
                                Console.WriteLine("You have Selected the Dallas Lccation!");
                                Console.WriteLine("");
                                Console.WriteLine("Welcome to Stickland Dallas! We sell propane and propane accessories!");
                                Console.WriteLine("Here is our Inventory:");
                                do
                                {
                                    shopping = true;
                                    Console.WriteLine("You are now shopping at the Stickland Cedar hill Location");
                                    Console.WriteLine("Press 1-6 to add a corresponding product into your cart, press 7 to exit");
                                    string selector = Console.ReadLine();
                                    if (selector == "1")
                                    {
                                        Console.WriteLine("Purchasing a 20 pound propane tank");

                                        user.add_to_shoppingcart(selected_Store.Inventory[0]);
                                        user.viewshoppingcart();

                                        selected_Store.Inventory[0].product_quantity--;
                                        while (selected_Store.Inventory[0].product_quantity == 0)
                                        {
                                            Console.WriteLine("We're out of propane!");

                                        }
                                        selected_Store.get_list_inventory();


                                    }
                                    else if (selector == "2")
                                    {
                                        Console.WriteLine("Purchasing a 60 pound propane tank");

                                        user.add_to_shoppingcart(selected_Store.Inventory[1]);
                                        user.viewshoppingcart();

                                        selected_Store.Inventory[1].product_quantity--;
                                        if (selected_Store.Inventory[1].product_quantity == 0)
                                        {
                                            Console.WriteLine("We're out of propane!");

                                        }
                                        selected_Store.get_list_inventory();

                                    }
                                    else if (selector == "3")
                                    {

                                        Console.WriteLine("Purchasing a 60 pound propane tank");

                                        user.add_to_shoppingcart(selected_Store.Inventory[2]);
                                        user.viewshoppingcart();

                                        selected_Store.Inventory[2].product_quantity--;
                                        if (selected_Store.Inventory[2].product_quantity == 0)
                                        {
                                            Console.WriteLine("We're out of propane!");

                                        }
                                        selected_Store.get_list_inventory();
                                    }
                                    else if (selector == "4")
                                    {

                                        Console.WriteLine("Purchasing a 120 pound propane tank");

                                        user.add_to_shoppingcart(selected_Store.Inventory[3]);
                                        user.viewshoppingcart();

                                        selected_Store.Inventory[3].product_quantity--;
                                        if (selected_Store.Inventory[3].product_quantity == 0)
                                        {
                                            Console.WriteLine("We're out of propane!");

                                        }

                                        selected_Store.get_list_inventory();

                                    }
                                    else if (selector == "5")
                                    {
                                        Console.WriteLine("Purchasing a 250 pound propane tank");

                                        user.add_to_shoppingcart(selected_Store.Inventory[4]);
                                        user.viewshoppingcart();

                                        selected_Store.Inventory[4].product_quantity--;
                                        if (selected_Store.Inventory[4].product_quantity == 0)
                                        {
                                            Console.WriteLine("We're out of propane!");

                                        }


                                        selected_Store.get_list_inventory();


                                    }
                                    else if (selector == "6")
                                    {

                                        Console.WriteLine("You just bought the Charking imperial! Happy gilling");

                                        user.add_to_shoppingcart(selected_Store.Inventory[5]);
                                        user.viewshoppingcart();

                                        selected_Store.Inventory[5].product_quantity--;
                                        if (selected_Store.Inventory[5].product_quantity == 0)
                                        {
                                            Console.WriteLine("We're out of Charkings! but don't sweat it more are coming");

                                        }

                                        selected_Store.get_list_inventory();

                                    }

                                    else if (selector == "7")
                                    {
                                        shopping = false;
                                    }


                                    decimal total = user.CartTotal();
                                    Console.WriteLine(total);


                                }
                                while (shopping == true);



                            }
                            else if (locationchoice == "6")
                            {

                                selected_Store = storelist[5];
                                int choice = Convert.ToInt32(locationchoice);
                                selected_Store.Inventory = blast.get_inventory(choice);

                                Console.Clear();
                                Console.WriteLine("You have Selected the San Antonio Lccation!");
                                Console.WriteLine("");
                                Console.WriteLine("Welcome to Stickland San Antonio! We sell propane and propane accessories!");
                                Console.WriteLine("Here is our Inventory:");
                                do
                                {
                                    shopping = true;
                                    Console.WriteLine("You are now shopping at the Stickland Cedar hill Location");
                                    Console.WriteLine("Press 1-6 to add a corresponding product into your cart, press 7 to exit");
                                    string selector = Console.ReadLine();
                                    if (selector == "1")
                                    {
                                        Console.WriteLine("Purchasing a 20 pound propane tank");

                                        user.add_to_shoppingcart(selected_Store.Inventory[0]);
                                        user.viewshoppingcart();

                                        selected_Store.Inventory[0].product_quantity--;
                                        while (selected_Store.Inventory[0].product_quantity == 0)
                                        {
                                            Console.WriteLine("We're out of propane!");

                                        }
                                        selected_Store.get_list_inventory();


                                    }
                                    else if (selector == "2")
                                    {
                                        Console.WriteLine("Purchasing a 60 pound propane tank");

                                        user.add_to_shoppingcart(selected_Store.Inventory[1]);
                                        user.viewshoppingcart();

                                        selected_Store.Inventory[1].product_quantity--;
                                        if (selected_Store.Inventory[1].product_quantity == 0)
                                        {
                                            Console.WriteLine("We're out of propane!");

                                        }
                                        selected_Store.get_list_inventory();

                                    }
                                    else if (selector == "3")
                                    {

                                        Console.WriteLine("Purchasing a 60 pound propane tank");

                                        user.add_to_shoppingcart(selected_Store.Inventory[2]);
                                        user.viewshoppingcart();

                                        selected_Store.Inventory[2].product_quantity--;
                                        if (selected_Store.Inventory[2].product_quantity == 0)
                                        {
                                            Console.WriteLine("We're out of propane!");

                                        }
                                        selected_Store.get_list_inventory();
                                    }
                                    else if (selector == "4")
                                    {

                                        Console.WriteLine("Purchasing a 120 pound propane tank");

                                        user.add_to_shoppingcart(selected_Store.Inventory[3]);
                                        user.viewshoppingcart();

                                        selected_Store.Inventory[3].product_quantity--;
                                        if (selected_Store.Inventory[3].product_quantity == 0)
                                        {
                                            Console.WriteLine("We're out of propane!");

                                        }

                                        selected_Store.get_list_inventory();

                                    }
                                    else if (selector == "5")
                                    {
                                        Console.WriteLine("Purchasing a 250 pound propane tank");

                                        user.add_to_shoppingcart(selected_Store.Inventory[4]);
                                        user.viewshoppingcart();

                                        selected_Store.Inventory[4].product_quantity--;
                                        if (selected_Store.Inventory[4].product_quantity == 0)
                                        {
                                            Console.WriteLine("We're out of propane!");

                                        }


                                        selected_Store.get_list_inventory();


                                    }
                                    else if (selector == "6")
                                    {

                                        Console.WriteLine("You just bought the Charking imperial! Happy gilling");

                                        user.add_to_shoppingcart(selected_Store.Inventory[5]);
                                        user.viewshoppingcart();

                                        selected_Store.Inventory[5].product_quantity--;
                                        if (selected_Store.Inventory[5].product_quantity == 0)
                                        {
                                            Console.WriteLine("We're out of Charkings! but don't sweat it more are coming");

                                        }

                                        selected_Store.get_list_inventory();

                                    }

                                    else if (selector == "7")
                                    {
                                        shopping = false;
                                    }


                                    decimal total = user.CartTotal();
                                    Console.WriteLine(total);


                                }
                                while (shopping == true);




                            }
                            
                            
                            else
                            {
                                Console.WriteLine("You entered an invalid input");
                                goto case "2";
                            }
                            break;
                        case "3":
                            Console.WriteLine("Proceed to Checkout");
                             user.viewshoppingcart();
                            Order a = new Order(user, selected_Store);
                            blast.addOrder(a);
                           
         
                            
                            break;
                        case "4":
                            Console.WriteLine("Exiting program");
                            exit = true;
                            break;
                        default:
                            Console.WriteLine("Error invalid input");
                            break;
                    }

                }
                while (exit == false);
            }



        }












        


















        //menu features locations shopping cart order history ect


    }










}