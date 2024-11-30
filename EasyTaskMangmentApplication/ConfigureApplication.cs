using EasyTaskMangmentApplication.Handler;
using EasyTaskMangmentApplication.Map;
using EasyTaskMangmentDomain.Handler;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace EasyTaskMangmentApplication
{
    public static class ConfigureApplication
    {
        public static IServiceCollection AddApplicationDependecy(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient<ILoginHandler, LoginHandler>();
            services.AddTransient<IUserHanlder, UserHandler>();
            services.AddTransient<IUserServieHandler, UserServieHandler>();
            services.AddTransient<IUserWorkHandler, UserWorkerHandler>();
            services.AddTransient<ILeadsHandler, LeadsHandler>();
            services.AddTransient<IMeetingHandler, MeetingHandler>();
        
            services.AddAutoMapper(typeof(MappingProfile));
            return services;
        }
    }
}
