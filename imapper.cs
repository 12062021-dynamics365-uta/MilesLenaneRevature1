using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Project0
{
    internal interface imapper
    {
        public List<consumer> Entity_to_ConsumerList(SqlDataReader dr);
        List<Product> Entity_to_InventoryList(SqlDataReader dr);
        List<Store> Entity_to_StoreList(SqlDataReader dr);
    }
}
