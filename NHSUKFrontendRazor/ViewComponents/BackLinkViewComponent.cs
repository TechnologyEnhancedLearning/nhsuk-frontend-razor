namespace NHSUKFrontendRazor.ViewComponents
{
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Mvc;
    using NHSUKFrontendRazor.ViewModels;

    public class BackLinkViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(
            string? href = null,
            string? aspController = null,
            string? aspAction = null,
            Dictionary<string, string>? aspAllRouteData = null,
            string? linkText = null
        )
        {
            LinkViewModel? link = !string.IsNullOrWhiteSpace(href) ? new LinkViewModel(linkText, href)
                : !string.IsNullOrWhiteSpace(aspController) ? new LinkViewModel(aspController, aspAction ?? "", linkText, aspAllRouteData)
                : null;

            return View(link);
        }
    }
}
