using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    class Program
    {
        static void Main(string[] args)
        {
            var productList = new List<Product>();
           
            productList.Add(new Product() { Name= "lettuce", Price=10.5, Quantity= 50, ProductType= "Leafy green" });
            productList.Add(new Product() { Name = "cabbage", Price =20, Quantity = 100, ProductType = " Cruciferous" });
            productList.Add(new Product() { Name = "pumpkin", Price = 30, Quantity = 30, ProductType = " Marrow" });
            productList.Add(new Product() { Name = "cauliflower", Price = 10, Quantity = 25, ProductType = " Cruciferous" });
            productList.Add(new Product() { Name = "zucchini,", Price = 20.5, Quantity = 50, ProductType = "Marrow" });
            productList.Add(new Product() { Name = "yam", Price = 30, Quantity = 50, ProductType = "Root" });
            productList.Add(new Product() { Name = "spinach,", Price = 10, Quantity = 100, ProductType = "Leafy green" });
            productList.Add(new Product() { Name = "broccoli", Price = 20.2, Quantity = 75, ProductType = " Cruciferous" });
            productList.Add(new Product() { Name = "garlic", Price = 30, Quantity = 20, ProductType = "Leafy green" });
            productList.Add(new Product() { Name = "silverbeet", Price = 10, Quantity = 50, ProductType = "Marrow" });


            //prints total numbers of products
            Console.WriteLine("total number of product in the list:");
            Console.WriteLine(productList.Count());

            //Adding a new product
            productList.Add(new Product() { Name = "Potato", Price = 10, Quantity = 50, ProductType = "Root" });

            Console.WriteLine($"After adding a new product..");
            
            //printing the list of all products
            Console.WriteLine("List of all products:");
            foreach(Product product in productList)
            {
                Console.WriteLine(product);
            }

            Console.WriteLine("total number of product in the list:");
            Console.WriteLine(productList.Count());

            //Print all the products of which have the type Leafy green.
            Console.WriteLine("The products of which have the type Leafy green");

            var productQuery = from p in productList
                               where p.ProductType.Contains("Leafy green")
                               select p;
            foreach(Product p in productQuery)
            Console.WriteLine(p);

            //remove Garlic 
            productList.RemoveAt(8);
            Console.WriteLine("After removing garlic from list,the total number of products:");
            Console.WriteLine(productList.Count());

            //adding 50 cabbages in the inventory, print the final quantity of cabbage in the inventory.
            Console.WriteLine("After adding 50 cabbages in the list,the total number of :");
            productList.ElementAt(1).Quantity = productList.ElementAt(1).Quantity + 50;
            Console.WriteLine(productList.ElementAt(1).Quantity);
            
            //calculation
            Console.WriteLine("After purchasing 1kg lettuce, 2 kg zucchini, 1 kg broccoli the round figure that need to pay");

            double totalPrice = productList.ElementAt(0).Price * 1
                + productList.ElementAt(4).Price * 2
                + productList.ElementAt(7).Price * 1;
                   Console.WriteLine(Math.Round(totalPrice));
            Console.ReadKey();

            
        }
       
    }
}
