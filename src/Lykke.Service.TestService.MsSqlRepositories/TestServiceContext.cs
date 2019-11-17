using System;
using System.Data.Common;
using JetBrains.Annotations;
using Lykke.Common.MsSql;
using Microsoft.EntityFrameworkCore;

namespace Lykke.Service.TestService.MsSqlRepositories
{
    public class TestServiceContext : MsSqlContext
    {
        private const string Schema = ""; // TODO put proper schema name here

        // empty constructor needed for EF migrations
        [UsedImplicitly]
        public TestServiceContext()
            : base(Schema)
        {
        }

        public TestServiceContext(string connectionString, bool isTraceEnabled)
            : base(Schema, connectionString, isTraceEnabled)
        {
        }

        //Needed constructor for using InMemoryDatabase for tests
        public TestServiceContext(DbContextOptions options)
            : base(Schema, options)
        {
        }

        public TestServiceContext(DbConnection dbConnection)
            : base(Schema, dbConnection)
        {
        }

        protected override void OnLykkeModelCreating(ModelBuilder modelBuilder)
        {
            // TODO put db entities models building code here
        }
    }
}
