namespace NHSUKFrontendRazor.ViewModels
{
    public class HeaderViewModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HeaderViewModel"/> class.
        /// </summary>
        /// <param name="organisationDetails">The details of the organisation for branding.</param>
        /// <param name="isService">Indicates if the header is for a service or an organisation.</param>
        /// <param name="accountLinks">Links related to the user's account.</param>
        /// <param name="navigationLinks">The primary navigation links for the header.</param>
        /// <param name="theme">The color theme for the header and navigation.</param>
        /// <param name="searchLink">A simple link for the header search form.</param>
        /// <param name="searchFolder">The folder for a component-based search view.</param>
        /// <param name="searchNavView">The view name for a component-based search.</param>
        /// <param name="searchControllerName">The controller name for a component-based search.</param>
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

        /// <summary>
        /// Gets or sets the organisation details for header branding.
        /// </summary>
        public Organisation OrganisationDetails { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the header is for a service.
        /// </summary>
        public bool? IsService { get; set; }

        /// <summary>
        /// Gets or sets the links for the account section of the header.
        /// </summary>
        public AccountLinks? AccountLinks { get; set; }

        /// <summary>
        /// Gets or sets the list of primary navigation links.
        /// </summary>
        public List<LinkViewModel>? NavigationLinks { get; set; }

        /// <summary>
        /// Gets or sets the theme for the header, which controls CSS classes.
        /// </summary>
        public Dictionary<string, string> Theme { get; set; }

        /// <summary>
        /// Gets or sets the view model for a simple search link in the header.
        /// </summary>
        public LinkViewModel? SearchLink { get; set; }

        /// <summary>
        /// Gets or sets the folder name for invoking a search ViewComponent.
        /// </summary>
        public string? SearchFolder { get; set; }

        /// <summary>
        /// Gets or sets the view name for invoking a search ViewComponent.
        /// </summary>
        public string? SearchNavView { get; set; }

        /// <summary>
        /// Gets or sets the controller name for invoking a search ViewComponent.
        /// </summary>
        public string? SearchControllerName { get; set; }

    }

    /// <summary>
    /// Provides predefined themes for the NHS header component.
    /// </summary>
    public static class HeaderTheme
    {
        public static Dictionary<string, string> BLUE = new Dictionary<string, string> { { "header", "nhsuk-header" }, { "navigation", "nhsuk-header__navigation" } };
        public static Dictionary<string, string> WHITE = new Dictionary<string, string> { { "header", "nhsuk-header nhsuk-header--white" }, { "navigation", "nhsuk-header__navigation nhsuk-header__navigation--white" } };
        public static Dictionary<string, string> MIXED = new Dictionary<string, string> { { "header", "nhsuk-header nhsuk-header--white" }, { "navigation", "nhsuk-header__navigation" } };
    }

    /// <summary>
    /// Represents the details of an NHS organisation for display in the header.
    /// </summary>
    public class Organisation
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Organisation"/> class.
        /// </summary>
        /// <param name="name">The main name of the organisation.</param>
        /// <param name="split">The secondary part of the organisation's name, often a location or type.</param>
        /// <param name="descriptor">A descriptor for the organisation, such as a region or trust type.</param>
        public Organisation(
        string name,
        string split,
        string descriptor)
        {
            Name = name;
            Split = split;
            Descriptor = descriptor;
        }

        /// <summary>
        /// Gets or sets the primary name of the organisation (e.g., "Anytown").
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// Gets or sets the split part of the organisation name (e.g., "Clinical Commissioning Group").
        /// </summary>
        public string? Split { get; set; }

        /// <summary>
        /// Gets or sets the descriptor for the organisation (e.g., "NHS Trust").
        /// </summary>
        public string? Descriptor { get; set; }
    }


    /// <summary>
    /// Represents the set of links related to user account management in the header.
    /// </summary>
    public class AccountLinks
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountLinks"/> class.
        /// </summary>
        /// <param name="account">The primary link to the user's account page.</param>
        /// <param name="logout">The link to log the user out.</param>
        /// <param name="additionalLinks">A list of any additional links related to the user's account.</param>
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

        /// <summary>
        /// Gets or sets the primary link to the user's account page.
        /// </summary>
        public LinkViewModel Account { get; set; }

        /// <summary>
        /// Gets or sets the link used for logging out.
        /// </summary>
        public LinkViewModel Logout { get; set; }

        /// <summary>
        /// Gets or sets a list of additional account-related links.
        /// </summary>
        public List<LinkViewModel>? AdditionalLinks { get; set; }
    }
}
