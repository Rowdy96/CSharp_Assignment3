using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    class Product
    {
        string name;
        double price;
        int quantity;
        string productType;

        public string ProductType { get => productType; set => productType = value; }
        public string Name { get => name; set => name = value; }
        public double Price { get => price; set => price = value; }
        public int Quantity { get => quantity; set => quantity = value; }

        public Product()
        {
            //Console.WriteLine("Enter the Product Name");
            //this.Name = Console.ReadLine();
            //Console.WriteLine("Enter the Product Price");
            //this.Price = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the Product Quantity");
            //this.Quantity = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the Product Type");
            //this.ProductType = Console.ReadLine();
        }
       
        public override string ToString()
        {
            return "Product: " + Name + " " + Price+" RS "+Quantity+" "+ProductType; ;
        }

       
    }
}
