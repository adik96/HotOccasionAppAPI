using Autofac;
using System.Reflection;
using HotOccasionApp.DB.Interfaces;
using HotOccasionApp.INFRASTRUCTURE.Interfaces;

namespace HotOccasionApp.INFRASTRUCTURE.IoC
{
    public class MainContainer : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            var assembly = typeof(MainContainer)
               .GetTypeInfo()
               .Assembly;

            builder.RegisterAssemblyTypes(assembly)
                .Where(x => x.IsAssignableTo<ITestRepository>())
                .AsImplementedInterfaces()
                .InstancePerLifetimeScope();

            builder.RegisterAssemblyTypes(assembly)
                .Where(x => x.IsAssignableTo<IService>())
                .AsImplementedInterfaces()
                .InstancePerLifetimeScope();

            builder.RegisterType<DB.Repositories.Dapper.DapperOccasionRepository>()
                .As<IDapperOccasionRepository>();

            //MapperConfig.Init();
        }
    }
}
