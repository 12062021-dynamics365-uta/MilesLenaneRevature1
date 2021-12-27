using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project0
{
    public interface idatabaseaccess
    {
        public void access();

        public void addUser(consumer c);


        public void get_productlist();


        public void get_locations();


        public List<Product> get_inventory(int storenumber);


        public List<Store> get_storelist();






    }

}
