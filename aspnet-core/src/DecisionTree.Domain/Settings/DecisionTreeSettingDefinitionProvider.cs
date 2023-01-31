using Volo.Abp.Settings;

namespace DecisionTree.Settings;

public class DecisionTreeSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(DecisionTreeSettings.MySetting1));
    }
}
