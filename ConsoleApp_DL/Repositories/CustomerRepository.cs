using ConsoleApp_DL.Contexts;
using ConsoleApp_DL.Entities;

namespace ConsoleApp_DL.Repositories
{
    internal class CustomerRepository : Repo<CustomerEntity>
    {
        public CustomerRepository(DataContext context) : base(context)
        {

        }
    }
}
