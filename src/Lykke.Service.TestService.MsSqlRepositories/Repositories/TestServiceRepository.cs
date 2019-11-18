using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lykke.Common.MsSql;
using Lykke.Service.TestService.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Lykke.Service.TestService.MsSqlRepositories.Repositories
{
    public class TestServiceRepository : ITestServiceRepository
    {
        private readonly IDbContextFactory<MyTestDbContext> _contextFactory;

        public TestServiceRepository(IDbContextFactory<MyTestDbContext> contextFactory)
        {
            _contextFactory = contextFactory;
        }

        
    }
}
