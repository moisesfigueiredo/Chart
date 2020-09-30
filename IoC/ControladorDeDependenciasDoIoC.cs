using Domain;
using IoC.Extensions;
using Microsoft.Extensions.DependencyInjection;
using Service.Bases;

namespace IoC
{
    public static class ControladorDeDependenciasDoIoC
    {
        public static IServiceCollection RegistrarDependenciasDoIoC(this IServiceCollection service)
        {
            //service.AddScoped(x => CustomDbContextBuilder.BuildDbContext());

            service.InjetarClassesQueImplementam(typeof(IService))
                   .InjetarClassesQueImplementam(typeof(IRepositorio));

            return service;
        }
    }
}