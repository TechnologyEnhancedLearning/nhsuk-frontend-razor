namespace NHSUKFrontendRazor.ViewComponents
{
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Html;
    using Microsoft.AspNetCore.Mvc;
    using NHSUKFrontendRazor.ViewModels;

    /// <summary>
    /// A ViewComponent that renders an NHSUK card component or an extended dashboard card.
    /// </summary>
    public class CardViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(
            string title,
            string? description = null,
            string? imageSrc = null,
            bool hasBanner = false,
            int headingLevel = 2,
            bool hasArrow = false,
            bool isSecondary = false,
            string? text = "",
            string? href = null,
            string? aspController = null,
            string? aspAction = null,
            Dictionary<string, string>? aspRouteData = null,
            string? resourceType = null,
            string? catalogueText = null,
            string? catalogueHref = null,
            IHtmlContent? ratingContent = null,
            string? accessPermission = null,
            string? bookmarkText = null,
            string? bookmarkHref = null,
            string? badgeSrc = null,
            string? providerDetails = null,
            string? providerFooterClass = "card-provider-details--blank")
        {
            // Main card title link
            LinkViewModel? link = !string.IsNullOrWhiteSpace(href)
                ? new LinkViewModel(text ?? title, href)
                : !string.IsNullOrWhiteSpace(aspController)
                    ? new LinkViewModel(aspController, aspAction ?? "", text ?? title, aspRouteData)
                    : null;

            // Catalogue link
            LinkViewModel? catalogueLink = (!string.IsNullOrWhiteSpace(catalogueText) && !string.IsNullOrWhiteSpace(catalogueHref))
                ? new LinkViewModel(catalogueText, catalogueHref)
                : null;

            // Bookmark link
            LinkViewModel? bookmarkLink = (!string.IsNullOrWhiteSpace(bookmarkText) && !string.IsNullOrWhiteSpace(bookmarkHref))
                ? new LinkViewModel(bookmarkText, bookmarkHref)
                : null;

            var model = new CardViewModel(
                title: title,
                description: description,
                imageSrc: imageSrc,
                hasBanner: hasBanner,
                headingLevel: headingLevel,
                hasArrow: hasArrow,
                isSecondary: isSecondary,
                link: link,
                resourceType: resourceType,
                catalogueLink: catalogueLink,
                ratingContent: ratingContent,
                accessPermission: accessPermission,
                bookmarkLink: bookmarkLink,
                badgeSrc: badgeSrc,
                providerDetails: providerDetails,
                providerFooterClass: providerFooterClass
            );

            return View(model);
        }
    }
}