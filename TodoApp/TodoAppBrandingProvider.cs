using Microsoft.Extensions.Localization;
using TodoApp.Localization;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace TodoApp;

[Dependency(ReplaceServices = true)]
public class TodoAppBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<TodoAppResource> _localizer;

    public TodoAppBrandingProvider(IStringLocalizer<TodoAppResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
    public override string? LogoUrl => "/images/logo/leptonxlite/logo-light.png";
}
