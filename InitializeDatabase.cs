using System;
using System.Linq;
using Microsoft.Extensions.DependencyInjection;
using NetCoreWorkshop1.Contexts;
using NetCoreWorkshop1.Models;

namespace NetCoreWorkshop1
{
    public static class InitializeDatabase
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            var context = serviceProvider.GetRequiredService<NetCoreWorkshopContext>();
            if (!context.Books.Any())
            {
                context.Books.Add(new Book { Id = 1, Title = "The Great Gatsby" });
                context.SaveChanges();
            }
            if (!context.People.Any())
            {
                context.People.Add(
                    new Person { Id = 1, FirstName = "Francis Scott", MiddleName = "Key", LastName = "Fitzgerald" }
                );
                context.SaveChanges();
            }
        }
    }
}