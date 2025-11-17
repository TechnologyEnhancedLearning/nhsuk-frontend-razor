namespace NHSUKFrontendRazor.ViewComponents
{
    using Microsoft.AspNetCore.Mvc;
    using NHSUKFrontendRazor.ViewModels;

    /// <summary>
    /// A ViewComponent that renders a skip link to allow users to jump to the main content of a page.
    /// </summary>
    public class SkipLinkViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(
            string mainContentID,
            string text = "Skip to main content")
        {
            var model = new SkipLinkViewModel(mainContentID, text);

            return View(model);
        }
    }
}
