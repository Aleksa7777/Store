using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    public class Cashier
    {
        public void PrintReceipt(List<CartItem> products, DateTime purchaseDate)
        {
            double subtotal = 0;
            double discountTotal = 0;
            double total = 0;

            Console.WriteLine("Date: " + purchaseDate + "\n");
            Console.WriteLine("--Products--\n\n");

            foreach(CartItem cartItem in products)
            {
                double discount = 0;
                double totalPrice = cartItem.Quantity * cartItem.ProductItem.Price;

                subtotal += totalPrice;

                Console.WriteLine(cartItem.ProductItem.ToString());
                Console.WriteLine(cartItem.Quantity + " x $" + cartItem.ProductItem.Price + " = ${0:0.00}\n", totalPrice);

                discount = CalculateDiscount(cartItem, totalPrice, purchaseDate);

                discountTotal += discount;

                Console.WriteLine("\n");
            }

            total = subtotal - discountTotal;

            Console.WriteLine("\n------------------------------------------\n");
            Console.WriteLine("SUBTOTAL: ${0:0.00}\n", subtotal);
            Console.WriteLine("DISCOUNT: -${0:0.00}\n\n", discountTotal);
            Console.WriteLine("TOTAL: ${0:0.00}\n", total);
        }

        private double CalculateDiscount(CartItem cartItem, double totalPrice, DateTime purchaseDate)
        {
            double discount = 0;
            int discountType = 0;

            if (cartItem.ProductItem.ExDate == purchaseDate)
            {
                discount = totalPrice * 0.5;
                discountType = 50;
            }//FoodOrBeverage, day of expiration
            else if (cartItem.ProductItem.ExDate == purchaseDate.AddDays(5))
            {
                discount = totalPrice * 0.1;
                discountType = 10;
            }//FoodOrBeverage, 5 days until expiration
            else if (!String.IsNullOrEmpty(cartItem.ProductItem.Size) && purchaseDate.DayOfWeek != DayOfWeek.Saturday && purchaseDate.DayOfWeek != DayOfWeek.Sunday)
            {
                discount = totalPrice * 0.1;
                discountType = 10;
            }//Clothes, weekday dicsount
             //same body as previous, but separate IF statement for cleaner and more understandable code
            else if (!String.IsNullOrEmpty(cartItem.ProductItem.Model) && (purchaseDate.DayOfWeek == DayOfWeek.Saturday || purchaseDate.DayOfWeek == DayOfWeek.Sunday) && cartItem.ProductItem.Price > 999)
            {
                discount = totalPrice * 0.05;
                discountType = 5;
            }//Appliance, weekend discount over $999

            if (discount != 0 && discountType != 0)
            {
                Console.WriteLine("#discount " + discountType + "% -${0:0.00}\n", discount);
            }

            return discount;
        }
    }
}
