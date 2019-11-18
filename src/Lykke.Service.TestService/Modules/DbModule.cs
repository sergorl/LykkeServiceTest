using Autofac;
using JetBrains.Annotations;
using Lykke.Common.MsSql;
using Lykke.Service.TestService.Domain.Repositories;
using Lykke.Service.TestService.MsSqlRepositories;
using Lykke.Service.TestService.MsSqlRepositories.Repositories;
using Lykke.Service.TestService.Settings;
using Lykke.SettingsReader;

namespace Lykke.Service.TestService.Modules
{
    [UsedImplicitly]
    public class DbModule : Module
    {
        private readonly string _connectionString;

        public DbModule(IReloadingManager<AppSettings> appSettings)
        {
            _connectionString = appSettings.CurrentValue.TestServiceService.Db.SqlDbConnString;
        }

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<TestServiceRepository>()
                .As<ITestServiceRepository>()
                .SingleInstance();

            builder.RegisterMsSql(
                _connectionString,
                connString => new MyTestDbContext(connString, false), 
                dbConn => new MyTestDbContext(dbConn));
        }
    }
}
