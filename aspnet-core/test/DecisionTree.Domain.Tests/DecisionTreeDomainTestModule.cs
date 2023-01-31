using DecisionTree.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace DecisionTree;

[DependsOn(
    typeof(DecisionTreeEntityFrameworkCoreTestModule)
    )]
public class DecisionTreeDomainTestModule : AbpModule
{

}
