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
        private readonly IDbContextFactory<TestServiceContext> _contextFactory;

        public TestServiceRepository(IDbContextFactory<TestServiceContext> contextFactory)
        {
            _contextFactory = contextFactory;
        }

        
    }
}
