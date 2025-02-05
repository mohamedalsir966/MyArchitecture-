using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using Service.Mapper;
using AutoMapper;

namespace Service
{
    public static class DependencyInjection
    {
        public static void AddServiceLayer(this IServiceCollection services)
        {
            //services.AddMediatR(Assembly.GetExecutingAssembly());
            //AssemblyScanner.FindValidatorsInAssembly(Assembly.GetExecutingAssembly())
            //     .ForEach(item => services.AddScoped(item.InterfaceType, item.ValidatorType));

            services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()));

            var config = new MapperConfiguration(c =>
            {
                c.AddProfile<LookupProfile>();
            });
            services.AddSingleton<IMapper>(s => config.CreateMapper());

        }

    }
}
