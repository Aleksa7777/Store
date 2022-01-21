using System;
using System.Collections.Generic;

namespace Store
{
    class Program
    {
        static void Main(string[] args)
        {
            Product food = new("Apples", "BrandA", 1.50, Convert.ToDateTime("21-Jan-22"));
            Product beverage = new("Milk", "BrandM", 0.99, Convert.ToDateTime("02-Feb-22"));
            Product clothes = new("T-shirt", "BrandT", 15.99, "M", "violet");
            Product appliance = new("Laptop", "BrandL", 2345, "ModelL", Convert.ToDateTime("03-Mar-21"), 1.125);

            Purchase purchase = new Purchase();

            purchase.cart.Add(new CartItem(food, 2.45));
            purchase.cart.Add(new CartItem(beverage, 3));
            purchase.cart.Add(new CartItem(clothes, 2));
            purchase.cart.Add(new CartItem(appliance, 1));

            purchase.purchaseDate = DateTime.Today;

            Cashier cashier = new Cashier();
            cashier.PrintReceipt(purchase.cart, purchase.purchaseDate);
        }
    }
}
