namespace NHSUKFrontendRazor.ViewComponents
{
    using Microsoft.AspNetCore.Mvc;
    using NHSUKFrontendRazor.ViewModels;
    using static System.Net.Mime.MediaTypeNames;

    /// <summary>
    /// A ViewComponent that renders a card component.
    /// </summary>
    public class CardViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(
            string title,
            string? description = null,
            string? imageSrc = null,
            int headingLevel = 2,
            bool hasArrow = false,
            bool isSecondary = false,
            string? text = "",
            string? href = null,
            string? aspController = null,
            string? aspAction = null,
            Dictionary<string, string>? aspRouteData = null)
        {
            LinkViewModel? link = !string.IsNullOrWhiteSpace(href) ? new LinkViewModel(text, href)
                : !string.IsNullOrWhiteSpace(aspController) ? new LinkViewModel(aspController, aspAction ?? "", text, aspRouteData)
                : null;

            var model = new CardViewModel
            (
                title,
                description,
                imageSrc,
                headingLevel,
                hasArrow,
                isSecondary,
                link
            );
            return View(model);
        }
    }
}
