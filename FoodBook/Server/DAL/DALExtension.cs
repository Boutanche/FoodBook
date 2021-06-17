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
            services.AddTransient<IListOfIngredientRepository, ListOfIngredientRepository>();
            services.AddTransient<IClientRepository, ClientRepository>();
            services.AddTransient<IServiceRepository, ServiceRepository>();
            
            //Avec les nouvelles data il n'y a plus de menu :
            services.AddTransient<IMenuRepository, MenuRepository>();

            return services;
        }
    }
}
