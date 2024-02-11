using ConsoleApp_DL.Contexts;
using ConsoleApp_DL.Entities;

namespace ConsoleApp_DL.Repositories
{
    internal class CategoryRepository : Repo<CategoryEntity>
    {
        public CategoryRepository(DataContext context) : base(context)
        {

        }
    }
}
