using BLL.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using DAL;

namespace BLL
{
    /// <summary>
    /// 
    /// </summary>
    public static class BLLExtension
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddBLL(this IServiceCollection services)
        {
            services.AddDAL();

            //Les Services liés à la BLL
            services.AddTransient<ILibrairiService, LibrairiService>();
            services.AddTransient<IRestaurantService, RestaurantService>();

            return services;
        }
    }
}
