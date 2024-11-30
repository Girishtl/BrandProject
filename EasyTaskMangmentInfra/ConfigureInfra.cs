using EasyTaskMangmentDomain.Infra.Repository;
using EasyTaskMangmentDomain.Infra.Util;
using EasyTaskMangmentDomain.Models.Config;
using EasyTaskMangmentDomain.Queries;
using EasyTaskMangmentInfra.Queries;
using EasyTaskMangmentInfra.Repository;
using EasyTaskMangmentInfra.Util;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace EasyTaskMangmentInfra
{
    public static class ConfigureInfra
    {
        public static IServiceCollection AddInfraDependecy(this IServiceCollection serviceProvider, IConfiguration configuration)
        {
            serviceProvider.Configure<DbConfiguration>(op => op.Connection = configuration["DbConfiguration:Connection"]);
            serviceProvider.AddTransient<IDapperExecutor, DapperExecutor>();
            serviceProvider.AddTransient<IUserRepository, UserRepository>();
            serviceProvider.AddTransient<ILeadsRepository, LeadsRepository>();
            serviceProvider.AddTransient<IUserServiceRepository, UserServiceRepository>();
            serviceProvider.AddTransient<IUserWorkRepository, UserWorkRepository>();
            serviceProvider.AddScoped<IUserQueries, UserQuery>();
            serviceProvider.AddScoped<IUserWorkQuery, UserWorkQuery>();
            serviceProvider.AddScoped<ILeadsQuery, LeadsQuery>();
            serviceProvider.AddScoped<IUserServiceQueries, UserServiceQuery>();
            serviceProvider.AddScoped<IMeetingQuery, MeetingQuery>();   
            serviceProvider.AddScoped<IMeetingRepository, MeetingRepository>();

            return serviceProvider;
        }
    }
}
