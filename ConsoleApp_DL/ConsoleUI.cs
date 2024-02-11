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
    }
}
