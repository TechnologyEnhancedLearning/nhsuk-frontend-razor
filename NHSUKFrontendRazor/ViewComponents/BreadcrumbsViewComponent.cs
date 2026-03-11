namespace NHSUKFrontendRazor.ViewComponents
{
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Mvc;
    using NHSUKFrontendRazor.ViewModels;

    /// <summary>
    /// A ViewComponent that renders a breadcrumb navigation based on the provided links.
    /// </summary>
    public class BreadcrumbsViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(List<LinkViewModel> links)
        {
            var model = new BreadcrumbsViewModel(links);

            return View(model);
        }
    }
}
