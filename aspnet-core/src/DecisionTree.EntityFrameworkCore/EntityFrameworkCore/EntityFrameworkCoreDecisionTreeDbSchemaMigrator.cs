using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using DecisionTree.Data;
using Volo.Abp.DependencyInjection;

namespace DecisionTree.EntityFrameworkCore;

public class EntityFrameworkCoreDecisionTreeDbSchemaMigrator
    : IDecisionTreeDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreDecisionTreeDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the DecisionTreeDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<DecisionTreeDbContext>()
            .Database
            .MigrateAsync();
    }
}
