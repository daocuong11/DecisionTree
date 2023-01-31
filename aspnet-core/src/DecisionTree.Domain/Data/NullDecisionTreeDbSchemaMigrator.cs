using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace DecisionTree.Data;

/* This is used if database provider does't define
 * IDecisionTreeDbSchemaMigrator implementation.
 */
public class NullDecisionTreeDbSchemaMigrator : IDecisionTreeDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
