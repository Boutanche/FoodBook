using DAL.Repository;
using DAL.UOW;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace DAL
{
    public static class DALExtension
    {
        public static IServiceCollection AddDAL(this IServiceCollection services)
        {
            // Ses propres services
            services.AddScoped<DbSession>((services) => new DbSession(services.GetRequiredService<IConfiguration>(), "DefaultConnection"));
            services.AddTransient<IUnitOfWork, UnitOfWork>();

            //Repositories
            services.AddTransient<IBookRepository, BookRepository>();
            services.AddTransient<IIngredientRepository, IngredientRepository>();
            services.AddTransient<IDishRepository, DishRepository>();
            services.AddTransient<ITypeOfDishRepository, TypeOfDishRepository>();

            return services;
        }
    }
}
