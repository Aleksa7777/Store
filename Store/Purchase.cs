using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    public class Purchase
    {
        public List<CartItem> cart;
        public DateTime purchaseDate;
        public Purchase()
        {
            this.cart = new List<CartItem>();
        }
    }
}
