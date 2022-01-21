using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    public class CartItem
    {
        public Product ProductItem { get; }
        public double Quantity { get; }

        public CartItem(Product productItem, double quantity)
        {
            this.ProductItem = productItem;
            this.Quantity = quantity;
        }
    }
}
