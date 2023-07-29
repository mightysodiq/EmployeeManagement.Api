using EmployeeManagement.Api.Context;
using EmployeeManagement.Api.Implementations;
using EmployeeManagement.Api.Models;
using EmployeeManagement.Api.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagement.Api.Extensions
{
    public static class ConfigureService
    {
        public static IServiceCollection AddDepencies(this IServiceCollection service, IConfiguration configuration)
        {
            service.AddDbContext<ApplicationContext>(opts => opts.
            UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            service.AddScoped<IEmployeeRepository, EmployeeRepository>();
            service.AddScoped<IUserRepository, UserRepository>();

            service.AddIdentity<AppUser, IdentityRole>()
                .AddEntityFrameworkStores<ApplicationContext>()
                .AddDefaultTokenProviders();

            //service.AddIdentity

            return service;
        }
    }
}
