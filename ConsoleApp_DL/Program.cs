﻿using ConsoleApp_DL;
using ConsoleApp_DL.Contexts;
using ConsoleApp_DL.Repositories;
using ConsoleApp_DL.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = Host.CreateDefaultBuilder().ConfigureServices (services =>
{

    services.AddDbContext<DataContext>(x => x.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\EC_Education\Datalagring\ConsoleApp_DL\ConsoleApp_DL\Data\database.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True"));

    services.AddScoped<AdressRepository>();
    services.AddScoped<CategoryRepository>();
    services.AddScoped<RoleRepository>();
    services.AddScoped<ProductRepository>();
    services.AddScoped<CustomerRepository>();

    services.AddScoped<AdressService>();
    services.AddScoped<CategoryService>();
    services.AddScoped<RoleService>();
    services.AddScoped<ProductService>();
    services.AddScoped<CustomerService>();

    services.AddSingleton<ConsoleUI>();
}

).Build ();

var consoleUI = builder.Services.GetRequiredService<ConsoleUI>();
//consoleUI.CreateProduct_UI();
//consoleUI.GetProducts_UI();
