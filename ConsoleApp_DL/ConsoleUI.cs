using ConsoleApp_DL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_DL
{
    internal class ConsoleUI
    {
        private readonly ProductService _productService;

        public ConsoleUI(ProductService productService)
        {
            _productService = productService;
        }

        public void CreateProduct_UI()
        {
            Console.Clear();
            Console.WriteLine("----- CREATE PRODUCT -----");

            Console.Write("Product Title: ");
            var title = Console.ReadLine()!;

            Console.Write("Product Price: ");
            decimal price = decimal.Parse(Console.ReadLine()!);

            Console.Write("Product Category: ");
            var categoryName = Console.ReadLine()!;

            var result = _productService.CreateProduct(title, price, categoryName);
            if (result != null)
            {
                Console.Clear();
                Console.WriteLine("Product was created.");
                Console.ReadKey();
            }
        }

        public void GetProducts_UI()
        {
            Console.Clear();

            var products = _productService.GetProducts();
            foreach (var product in products)
            {
                Console.WriteLine($"{product.Title} - {product.Category.CategoryName} ({product.Price} SEK)");
            }

            Console.ReadKey();
        }

        public void UpdateProduct_UI()
        {
            Console.Clear();
            Console.Write("Enter Product Id: ");
            var id = int.Parse(Console.ReadLine()!);
            var product = _productService.GetProductById(id);
            if (product != null)
            {
                Console.WriteLine($"{product.Title} - {product.Category.CategoryName} ({product.Price} SEK)");
                Console.WriteLine();

                Console.Write("New Product Title: ");
                product.Title = Console.ReadLine()!;
            
                var newProduct = _productService.UpdateProduct(product);
                Console.WriteLine($"{product.Title} - {product.Category.CategoryName} ({product.Price} SEK)");
            }
            else
            {
                Console.WriteLine("No product found. ");
            }

            Console.ReadKey();
        }
    }
}
