using ConsoleApp_DL.Contexts;
using ConsoleApp_DL.Entities;

namespace ConsoleApp_DL.Repositories
{
    internal class RoleRepository : Repo<RoleEntity>
    {
        public RoleRepository(DataContext context) : base(context)
        {

        }
    }
}
