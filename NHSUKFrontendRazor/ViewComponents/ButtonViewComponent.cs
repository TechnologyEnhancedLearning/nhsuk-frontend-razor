namespace NHSUKFrontendRazor.ViewComponents
{
    using Microsoft.AspNetCore.Mvc;
    using NHSUKFrontendRazor.ViewModels;

    /// <summary>
    /// A ViewComponent that renders a button.
    /// </summary>
    public class ButtonViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(
            string text,
            string? style = null,
            string styling = ButtonStyle.PRIMARY,
            string? href = null,
            string? aspController = null,
            string? aspAction = null,
            Dictionary<string, string>? aspRouteData = null,
            bool preventDoubleClick = false)
        {
            LinkViewModel? link = !string.IsNullOrWhiteSpace(href) ? new LinkViewModel(text, href)
                : !string.IsNullOrWhiteSpace(aspController) ? new LinkViewModel(aspController, aspAction ?? "", text, aspRouteData)
                : null;

            var model = new ButtonViewModel(text, link, styling, style, preventDoubleClick);

            return View(model);
        }
    }
}
