using Autofac;
using JetBrains.Annotations;
using Lykke.Common.MsSql;
using Lykke.Sdk;
using Lykke.Sdk.Health;
using Lykke.Service.TestService.Domain.Services;
using Lykke.Service.TestService.DomainServices;
using Lykke.Service.TestService.MsSqlRepositories;
using Lykke.Service.TestService.Services;
using Lykke.Service.TestService.Settings;
using Lykke.SettingsReader;

namespace Lykke.Service.TestService.Modules
{
    [UsedImplicitly]
    public class ServiceModule : Module
    {
        private readonly IReloadingManager<AppSettings> _appSettings;
        private readonly string _connectionString;

        public ServiceModule(IReloadingManager<AppSettings> appSettings)
        {
            _appSettings = appSettings;
        }

        protected override void Load(ContainerBuilder builder)
        {
            // NOTE: Do not register entire settings in container, pass necessary settings to services which requires them

            builder.RegisterType<HealthService>()
                .As<IHealthService>()
                .SingleInstance();

            builder.RegisterType<StartupManager>()
                .As<IStartupManager>()
                .SingleInstance();

            builder.RegisterType<ShutdownManager>()
                .As<IShutdownManager>()
                .AutoActivate()
                .SingleInstance();

            // TODO: Add your dependencies here
            builder.RegisterType<HelloLogic>()
                .As<IHelloLogic>()
                .SingleInstance();
            
            builder.RegisterMsSql(
                _connectionString,
                connString => new MyTestDbContext(connString, false),
                dbConn => new MyTestDbContext(dbConn));
        }
    }
}
