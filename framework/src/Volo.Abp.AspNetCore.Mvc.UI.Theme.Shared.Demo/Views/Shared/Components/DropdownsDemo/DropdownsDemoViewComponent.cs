using Microsoft.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc.UI.Packages.Prismjs;
using Volo.Abp.AspNetCore.Mvc.UI.Widgets;

namespace Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared.Demo.Views.Shared.Components.DropdownsDemo;

[Widget(
    StyleTypes = new[] { typeof(PrismjsStyleBundleContributor) },
    ScriptTypes = new[] { typeof(PrismjsScriptBundleContributor) }
)]
public class DropdownsDemoViewComponent : AbpViewComponent
{
    public const string ViewPath = "/Views/Shared/Components/DropdownsDemo/Default.cshtml";

    public virtual IViewComponentResult Invoke()
    {
        var model = new DropDownDemoDemoModel();

        return View(ViewPath, model);
    }
}