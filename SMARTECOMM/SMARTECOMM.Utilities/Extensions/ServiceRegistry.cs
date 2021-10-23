using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SMARTECOMM.Infrastructure.Context;
using SMARTECOMM.Repository.Interface;
using SMARTECOMM.Service.Services;

namespace SMARTECOMM.Service.Extensions
{
    using SMARTECOMM.Service.Interface;
    using System;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.AspNetCore.Identity;

    public static class ServiceRegistry
    {
        public static void AddServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IAccount, AccountService>();
            services.AddTransient<IUnitOfWork, UnitOfWork>();
           // services.AddTransient(typeof(IBaseRepository<>));


            //services.AddDbContext<DataBaseContext>
            //    (options =>
            //          options.UseSqlServer(configuration.GetConnectionString("DBConnection"))
            //    );

            //services.AddDbContext<DataBaseContext>
            //   (options => options.UseNpgsql(configuration.GetConnectionString("DBConnection"))
            //   );

            services.AddDbContext<DataBaseContext>(
                    options => options.UseNpgsql(configuration.GetConnectionString("DbConnections")
                    //sqlServerOptions => sqlServerOptions.CommandTimeout(60))
                ));

            services.AddIdentity<IdentityUser, IdentityRole>(options=>{
                options.Password.RequiredLength = 8;
            }).AddEntityFrameworkStores<DataBaseContext>();
        }
    }
}
