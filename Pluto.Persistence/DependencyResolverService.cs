using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Pluto.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pluto.Persistence
{
    public static class DependencyResolverService
    {
        public static void InfrastructurRegister(this IServiceCollection services, IConfiguration Configuration)
        {
            //services.AddDbContext<AppDbContext>(options =>
            //    options.UseSqlServer(Configuration.GetConnectionString("ApplicationConnection"),
            //    b => b.MigrationsAssembly(typeof(AppDbContext).Assembly.FullName)));
               
         
            services.AddDbContext<AppDbContext>(options =>
                options.UseNpgsql(Configuration.GetConnectionString("postgresql"), npgsqlOptions =>
                npgsqlOptions.MigrationsAssembly(typeof(AppDbContext).Assembly.FullName)));

            services.AddScoped<IAppDbContext, AppDbContext>();
        }

        public static void MigrateDatabase(IServiceProvider serviceProvider)
        {
            var dbContextOptions = serviceProvider.GetRequiredService<DbContextOptions<AppDbContext>>();
            using (var dbContext = new AppDbContext(dbContextOptions))
            {
                dbContext.Database.Migrate();
            }
        }
    }
}
