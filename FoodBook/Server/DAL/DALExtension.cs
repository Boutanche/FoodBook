using DAL.Repository;
using DAL.UOW;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace DAL
{
    /// <summary>
    /// Couche d'Acces aux Données : DATA ACCESS LAYER
    /// </summary>
    public static class DALExtension
    {
        /// <summary>
        /// Data Access Layer : Couche d'accés aux données : 
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddDAL(this IServiceCollection services)
        {
            //Notions pédagogique : Injecteur de dépendance et Inversion de controle

            // Ses propres services
            services.AddScoped<DbSession>((services) => new DbSession(services.GetRequiredService<IConfiguration>(), "DefaultConnection"));
            //Unit of Work qui va jouer le rôle de chef d'orchestre sur les repository
            services.AddTransient<IUnitOfWork, UnitOfWork>();

            //Repositories
            services.AddTransient<IIngredientRepository, IngredientRepository>();
            services.AddTransient<IDishRepository, DishRepository>();
            services.AddTransient<ITypeOfDishRepository, TypeOfDishRepository>();
            services.AddTransient<IListOfIngredientRepository, ListOfIngredientRepository>();
            services.AddTransient<IClientRepository, ClientRepository>();
            services.AddTransient<IServiceRepository, ServiceRepository>();
            services.AddTransient<IIsComposedRepository, IsComposedRepository>();
            
            return services;
        }
    }
}
