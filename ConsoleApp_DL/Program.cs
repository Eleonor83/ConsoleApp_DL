using ConsoleApp_DL.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = Host.CreateDefaultBuilder().ConfigureServices (services =>
{

    services.AddDbContext<DataContext>(x => x.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\EC_Education\Datalagring\ConsoleApp_DL\ConsoleApp_DL\Data\database.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True"));
}
).Build ();