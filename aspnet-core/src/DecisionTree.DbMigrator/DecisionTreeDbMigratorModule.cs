using DecisionTree.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace DecisionTree.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(DecisionTreeEntityFrameworkCoreModule),
    typeof(DecisionTreeApplicationContractsModule)
    )]
public class DecisionTreeDbMigratorModule : AbpModule
{

}
