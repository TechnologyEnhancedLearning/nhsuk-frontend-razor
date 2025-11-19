namespace NHSUKFrontendRazor.ViewModels
{
    public class HeaderViewModel
    {
        public HeaderViewModel(
            Organisation organisationDetails,
            bool? isService,
            AccountLinks? accountLinks,
            List<LinkViewModel>? navigationLinks,
            Dictionary<string, string> theme,
            LinkViewModel searchLink,
            string? searchFolder,
            string? searchNavView,
            string? searchControllerName
            )
        {
            OrganisationDetails = organisationDetails;
            IsService = isService;
            AccountLinks = accountLinks;
            NavigationLinks = navigationLinks;
            Theme = theme;
            SearchLink = searchLink;
            SearchFolder = searchFolder;
            SearchNavView = searchNavView;
            SearchControllerName = searchControllerName;
        }

        public Organisation OrganisationDetails { get; set; }

        public bool? IsService { get; set; }

        public AccountLinks? AccountLinks { get; set; }

        public List<LinkViewModel>? NavigationLinks { get; set; }

        public Dictionary<string, string> Theme { get; set; }

        public LinkViewModel? SearchLink { get; set; }

        public string? SearchFolder { get; set; }

        public string? SearchNavView { get; set; }

        public string? SearchControllerName { get; set; }

    }

    public static class HeaderTheme
    {
        public static Dictionary<string, string> BLUE = new Dictionary<string, string> { { "header", "nhsuk-header" }, { "navigation", "nhsuk-header__navigation" } };
        public static Dictionary<string, string> WHITE = new Dictionary<string, string> { { "header", "nhsuk-header nhsuk-header--white" }, { "navigation", "nhsuk-header__navigation nhsuk-header__navigation--white" } };
        public static Dictionary<string, string> MIXED = new Dictionary<string, string> { { "header", "nhsuk-header nhsuk-header--white" }, { "navigation", "nhsuk-header__navigation" } };
    }

    public class Organisation
    {
        public Organisation(
        string name,
        string split,
        string descriptor)
        {
            Name = name;
            Split = split;
            Descriptor = descriptor;
        }

        public string? Name { get; set; }
        public string? Split { get; set; }
        public string? Descriptor { get; set; }
    }

    public class AccountLinks
    {
        public AccountLinks(
            LinkViewModel account,
            LinkViewModel logout,
            List<LinkViewModel>? additionalLinks
            )
        {
            Account = account;
            Logout = logout;
            AdditionalLinks = additionalLinks;
        }

        public LinkViewModel Account { get; set; }
        public LinkViewModel Logout { get; set; }
        public List<LinkViewModel>? AdditionalLinks { get; set; }
    }
}
