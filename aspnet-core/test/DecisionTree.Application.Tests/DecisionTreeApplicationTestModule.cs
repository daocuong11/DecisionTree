using Volo.Abp.Modularity;

namespace DecisionTree;

[DependsOn(
    typeof(DecisionTreeApplicationModule),
    typeof(DecisionTreeDomainTestModule)
    )]
public class DecisionTreeApplicationTestModule : AbpModule
{

}
