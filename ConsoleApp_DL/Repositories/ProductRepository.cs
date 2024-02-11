using ConsoleApp_DL.Contexts;
using ConsoleApp_DL.Entities;

namespace ConsoleApp_DL.Repositories
{
    internal class ProductRepository : Repo<ProductEntity>
    {
        public ProductRepository(DataContext context) : base(context)
        {

        }
    }
}
