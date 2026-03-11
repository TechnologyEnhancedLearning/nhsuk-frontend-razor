namespace NHSUKFrontendRazor.ViewComponents
{
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Mvc;
    using NHSUKFrontendRazor.ViewModels;

    public class CancelLinkViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(
            string? href = null,
            string? aspController = null,
            string? aspAction = null,
            Dictionary<string, string>? aspAllRouteData = null,
            string? text = "Cancel"
        )
        {
            LinkViewModel? link = !string.IsNullOrWhiteSpace(href) ? new LinkViewModel(text, href)
                : !string.IsNullOrWhiteSpace(aspController) ? new LinkViewModel(aspController, aspAction ?? "", text, aspAllRouteData)
                : null;

            return View(link);
        }
    }
}
