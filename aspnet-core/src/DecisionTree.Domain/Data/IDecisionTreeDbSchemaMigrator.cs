using System.Threading.Tasks;

namespace DecisionTree.Data;

public interface IDecisionTreeDbSchemaMigrator
{
    Task MigrateAsync();
}
