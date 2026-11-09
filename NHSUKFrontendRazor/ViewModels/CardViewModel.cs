namespace NHSUKFrontendRazor.ViewModels
{
    using Microsoft.AspNetCore.Html;

    public class CardViewModel
    {
        public CardViewModel(
            string title,
            string? description = null,
            string? imageSrc = null,
            bool hasBanner = false,
            int headingLevel = 2,
            bool hasArrow = false,
            bool isSecondary = false,
            LinkViewModel? link = null,
            string? resourceType = null,
            LinkViewModel? catalogueLink = null,
            IHtmlContent? ratingContent = null,
            string? accessPermission = null,
            LinkViewModel? bookmarkLink = null,
            string? badgeSrc = null,
            string? providerDetails = null,
            string? providerFooterClass = "card-provider-details--blank")
        {
            Title = title;
            Description = description;
            ImageSrc = imageSrc;
            HasBanner = hasBanner;
            HeadingLevel = headingLevel;
            HasArrow = hasArrow;
            IsSecondary = isSecondary;
            Link = link;

            // Resource & Catalogue card specific properties
            ResourceType = resourceType;
            CatalogueLink = catalogueLink;
            RatingContent = ratingContent;
            AccessPermission = accessPermission;
            BookmarkLink = bookmarkLink;
            BadgeSrc = badgeSrc;
            ProviderDetails = providerDetails;
            ProviderFooterClass = providerFooterClass;
        }

        /// <summary>
        /// Gets or sets the title of the card.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the description of the card.
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// Gets or sets the source URL of the image to be displayed on the card.
        /// </summary>
        public string? ImageSrc { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the card displays a top banner (e.g. for catalogues).
        /// </summary>
        public bool HasBanner { get; set; }

        /// <summary>
        /// Gets or sets the HTML heading level for the title (default: 2 -> h2).
        /// </summary>
        public int HeadingLevel { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the card should display an arrow.
        /// </summary>
        public bool HasArrow { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the card is styled as a secondary card.
        /// </summary>
        public bool IsSecondary { get; set; }

        /// <summary>
        /// Gets or sets the main link of the card title.
        /// </summary>
        public LinkViewModel? Link { get; set; }

        /// <summary>
        /// Gets or sets the resource type label (e.g., "Image", "Web link", "Course").
        /// </summary>
        public string? ResourceType { get; set; }

        /// <summary>
        /// Gets or sets the catalogue link.
        /// </summary>
        public LinkViewModel? CatalogueLink { get; set; }

        /// <summary>
        /// Gets or sets the star rating partial/HTML content.
        /// </summary>
        public IHtmlContent? RatingContent { get; set; }

        /// <summary>
        /// Gets or sets the access status text (e.g. "Access granted", "Access restricted").
        /// </summary>
        public string? AccessPermission { get; set; }

        /// <summary>
        /// Gets or sets the bookmark action link.
        /// </summary>
        public LinkViewModel? BookmarkLink { get; set; }

        /// <summary>
        /// Gets or sets the provider logo or catalogue badge image source.
        /// </summary>
        public string? BadgeSrc { get; set; }

        /// <summary>
        /// Gets or sets the provider name/details text in the footer bar.
        /// </summary>
        public string? ProviderDetails { get; set; }

        /// <summary>
        /// Gets or sets the fallback CSS class for the footer bar when no provider text is present.
        /// </summary>
        public string? ProviderFooterClass { get; set; }

        /// <summary>
        /// Gets a value indicating whether this card should render the dashboard structure.
        /// </summary>
        public bool IsDashboardCard =>
            HasBanner ||
            !string.IsNullOrEmpty(ResourceType) ||
            CatalogueLink != null ||
            RatingContent != null ||
            !string.IsNullOrEmpty(AccessPermission) ||
            BookmarkLink != null ||
            !string.IsNullOrEmpty(BadgeSrc) ||
            !string.IsNullOrEmpty(ProviderDetails);
    }
}