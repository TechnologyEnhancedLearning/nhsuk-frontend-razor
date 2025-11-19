namespace NHSUKFrontendRazor.ViewComponents
{
    using Microsoft.AspNetCore.Mvc;
    using NHSUKFrontendRazor.ViewModels;

    /// <summary>
    /// A ViewComponent that renders a Header.
    /// </summary>
    public class HeaderViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(
            Organisation organisationDetails,
            bool? isService = true,
            AccountLinks? accountLinks = null,
            List<LinkViewModel>? navigationLinks = null,
            Dictionary<string, string>? theme = null,
            LinkViewModel? searchLink = null,
            string? searchFolder = null,
            string? searchNavView = null,
            string? searchControllerName = null)
        {
            theme ??= HeaderTheme.BLUE;

            accountLinks ??= new AccountLinks
                (
                    new LinkViewModel("myaccount", null, "My account", null),
                    new LinkViewModel("Home", "Logout", "Log out", null),
                    null
                );
            

            var model = new HeaderViewModel(organisationDetails, isService, accountLinks, navigationLinks, theme, searchLink, searchFolder, searchNavView, searchControllerName);

            return View(model);
        }
    }
}
