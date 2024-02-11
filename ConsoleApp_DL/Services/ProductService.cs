using ConsoleApp_DL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_DL.Services
{
    internal class ProductService
    {
        private readonly ProductRepository _productRepository;
        private readonly CategoryService _categoryService;

        public ProductService(ProductRepository productRepository, CategoryService categoryService)
        {
            _productRepository = productRepository;
            _categoryService = categoryService;
        }
    }
}
