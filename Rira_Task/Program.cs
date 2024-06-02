using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rira_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>
            {
               new Product {id= 1, name="productA", category=Categories.Categories1, price=100 },
               new Product {id= 2, name="productB", category=Categories.Categories1, price=150 },
               new Product {id= 3, name="productC", category=Categories.Categories2, price=120 },
               new Product {id= 4, name="productD", category=Categories.Categories3, price=200 },
               new Product {id= 5, name="productE", category=Categories.Categories1, price=80 },
            };


            //get products with categories1
            var result = (from p in products where p.category == Categories.Categories1 select p).ToList();

            //find maximum price
            var max = (from p in products select p.price).Max();

            //find  product with maximum price
            var maxproduct = (from p in products where p.price == max select p).First();

            //calculate sum of prices
            var sum = (from p in products select p.price).Sum();

            //calculate  average of prices
            var average = (from p in products select p.price).Average();

            //sort products by category
            var order = (from p in products orderby p.category select p).ToList();

            //write  information of products with categories1
            Console.WriteLine(" information of products  with categories1:");
            foreach (var r in result)
                Console.WriteLine($"id : {r.id}  name : {r.name} category: {r.category} price : {r.price}");

            //write product with maximum price
            Console.WriteLine();

            Console.WriteLine("product with maximum price is:");

            Console.WriteLine($"id : {maxproduct.id}  name : {maxproduct.name} category: {maxproduct.category} price : {maxproduct.price}");

            Console.WriteLine();

            //write total price of products
            Console.WriteLine($"total price is {sum}");

            Console.WriteLine();

            //write average price of products
            Console.WriteLine($"average price of products is {average}");

            Console.WriteLine();

            //write sorted products by category
            Console.WriteLine("products order by category :");
            foreach (var o in order)
                Console.WriteLine($"id : {o.id}  name : {o.name} category: {o.category} price : {o.price}");
            Console.ReadKey();

            #region lambda 
            /*
            //get products with categories1
            var result = products.Where(p => p.category == Categories.Categories1).ToList();

            //find maximum price
            var max = products.Max(P => P.price);

            //find  product with maximum price
            var maxproduct = products.Find(p => p.price == max);

            //calculate sum of prices
            var sum = products.Sum(p => p.price);

            //calculate  average of prices
            var average = products.Average(n => n.price);

            //ordering products by category
            var order = products.OrderBy(p => p.category).ToList();

             //write  information of products with categories1
            Console.WriteLine(" information of products  with categories1:");
            foreach (var r in result)
                Console.WriteLine($"id : {r.id}  name : {r.name} category: {r.category} price : {r.price}");

            //write product with maximum price
            Console.WriteLine();

            Console.WriteLine("product with maximum price is:");

            Console.WriteLine($"id : {maxproduct.id}  name : {maxproduct.name} category: {maxproduct.category} price : {maxproduct.price}");

            Console.WriteLine();

            //write total price of products
            Console.WriteLine($"total price is {sum}");

            Console.WriteLine();

            //write average price of products
            Console.WriteLine($"average price of products is {average}");

            Console.WriteLine();

            //write sorted products by category
            Console.WriteLine("products order by category :");
            foreach (var o in order)
                Console.WriteLine($"id : {o.id}  name : {o.name} category: {o.category} price : {o.price}");
            */
            #endregion
        }
    }
}
