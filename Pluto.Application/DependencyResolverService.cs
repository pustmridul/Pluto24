using Microsoft.Extensions.DependencyInjection;
using Pluto.Application.AutoMapper;
using Pluto.Application.Interface;
using Pluto.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pluto.Application
{
    public static class DependencyResolverService
    {
        public static IServiceCollection ApplicationRegister(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(AutomapperProfile).Assembly);
            
            services.AddScoped<ITokenService, TokenService>();
            services.AddScoped<IMemberService, MemberService>();


            return services;
        }
    }
}