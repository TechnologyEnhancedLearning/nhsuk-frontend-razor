namespace NHSUKFrontendRazor.ViewComponents
{
    using Microsoft.AspNetCore.Mvc;
    using NHSUKFrontendRazor.ViewModels;

    /// <summary>
    /// A ViewComponent that rendes a hero section.
    /// </summary>
    public class HeroViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(
            string? imageSrc = null,
            string? heading = null,
            string? textContent = null)
        { 
            var model = new HeroViewModel(imageSrc, heading, textContent);

            return View(model);
        }
    }
}
