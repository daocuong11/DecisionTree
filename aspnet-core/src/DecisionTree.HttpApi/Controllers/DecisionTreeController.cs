using DecisionTree.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace DecisionTree.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class DecisionTreeController : AbpControllerBase
{
    protected DecisionTreeController()
    {
        LocalizationResource = typeof(DecisionTreeResource);
    }
}
