using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    public class Product
    {
        public string Name { get; }
        public string Brand { get; }
        public double Price { get; }

        //FoodOrBeverage
        public DateTime ExDate { get; }

        //Clothes
        public string Size { get; }
        public string Color { get; }

        //Appliance
        public string Model { get; }
        public DateTime ProductionDate { get; }
        public double Weight { get; }

        public Product(string name, string brand, double price, DateTime exDate)
        {
            this.Name = name;
            this.Brand = brand;
            this.Price = price;
            this.ExDate = exDate;
        }//FoodOrBeverage
        
        public Product(string name, string brand, double price, string size, string color)
        {
            this.Name = name;
            this.Brand = brand;
            this.Price = price;
            this.Size = size;
            this.Color = color;
        }//Clothes
        public Product(string name, string brand, double price, string model, DateTime productionDate, double weight)
        {
            this.Name = name;
            this.Brand = brand;
            this.Price = price;
            this.Model = model;
            this.ProductionDate = productionDate;
            this.Weight = weight;
        }//Appliance
        public override string ToString()
        {
            if (!String.IsNullOrEmpty(Color) && !String.IsNullOrEmpty(Size))
            {
                return Name + " " + Brand + " " + Size + " " + Color + "\n";
            }//Clothes

            else if(!String.IsNullOrEmpty(Model))
            {
                return Name + " " + Brand + " " + Model + "\n";
            }//Appliance

            else
            {
                return Name + " " + Brand + "\n";
            }//FoodOrBeverage
        }
    }
}

