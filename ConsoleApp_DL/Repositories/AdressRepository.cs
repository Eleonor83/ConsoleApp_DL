using ConsoleApp_DL.Contexts;
using ConsoleApp_DL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_DL.Repositories
{
    internal class AdressRepository : Repo<AdressEntity>
    {
        public AdressRepository(DataContext context) : base(context)
        {

        }
    }
}
