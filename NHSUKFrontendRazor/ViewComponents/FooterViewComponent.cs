namespace NHSUKFrontendRazor.ViewComponents
{
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Mvc;
    using NHSUKFrontendRazor.ViewModels;

    /// <summary>
    /// A ViewComponent that renders a footer with links.
    /// </summary>
    public class FooterViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(
            string copyright,
            IEnumerable<FooterItemGroupModel> footerGroupList,
            bool isVerticallyAligned = true)
        {
            var model = new FooterViewModel(copyright, footerGroupList, isVerticallyAligned);

            return View(model);
        }
    }
}
