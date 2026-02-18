namespace NHSUKFrontendRazor.ViewComponents
{
    using Microsoft.AspNetCore.Mvc;
    using NHSUKFrontendRazor.ViewModels;
    using System.Collections.Generic;
    using static System.Net.Mime.MediaTypeNames;

    public class ActionLinkViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(string? href = null, string? aspController = null, string? aspAction = null, Dictionary<string, string>? aspAllRouteData = null, string? linkText = null)
        {
            LinkViewModel? link = !string.IsNullOrWhiteSpace(href) ? new LinkViewModel(linkText, href)
                : !string.IsNullOrWhiteSpace(aspController) ? new LinkViewModel(aspController, aspAction ?? "", linkText, aspAllRouteData)
                : null;

            return View(link);
        }
    }
}
