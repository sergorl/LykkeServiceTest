using Autofac;
using Lykke.Common.MsSql;
using Lykke.Service.TestService.MsSqlRepositories;

namespace Lykke.Service.EmaarPropertyIntegration.AzureRepositories
{
    public class AutofacModule : Module
    {
        private readonly string _connectionString;

        public AutofacModule(string connectionString)
        {
            _connectionString = connectionString;
        }

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterMsSql(
                _connectionString,
                connString => new MyTestDbContext(connString, false),
                dbConn => new MyTestDbContext(dbConn));
        }
    }
}
