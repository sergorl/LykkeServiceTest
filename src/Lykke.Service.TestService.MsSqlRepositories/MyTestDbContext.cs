using System.Data.Common;
using JetBrains.Annotations;
using Lykke.Common.MsSql;
using Lykke.Service.TestService.Domain;
using Microsoft.EntityFrameworkCore;

namespace Lykke.Service.TestService.MsSqlRepositories
{
    public class MyTestDbContext : MsSqlContext
    {
        private const string Schema = "foo";

        public DbSet<TranscationCoins> AgentRegister { get; set; }

        // empty constructor needed for migrations
        [UsedImplicitly]
        public MyTestDbContext() : base(Schema)
        {
        }

        public MyTestDbContext(string connectionString, bool isTraceEnabled)
            : base(Schema, connectionString, isTraceEnabled)
        {
        }

        //Needed constructor for using InMemoryDatabase for tests
        public MyTestDbContext(DbContextOptions options)
            : base(Schema, options)
        {
        }

        public MyTestDbContext(DbConnection dbConnection)
            : base(Schema, dbConnection)
        {
        }

        protected override void OnLykkeModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TranscationCoins>()
                .HasIndex(t => t.Id);
        }
    }
}
