using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace DecisionTree;

[Dependency(ReplaceServices = true)]
public class DecisionTreeBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "DecisionTree";
}
