using System;
using System.Collections.Generic;
using System.Text;
using DecisionTree.Localization;
using Volo.Abp.Application.Services;

namespace DecisionTree;

/* Inherit your application services from this class.
 */
public abstract class DecisionTreeAppService : ApplicationService
{
    protected DecisionTreeAppService()
    {
        LocalizationResource = typeof(DecisionTreeResource);
    }
}
