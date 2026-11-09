namespace NHSUKFrontendRazor.ViewComponents
{
    using Microsoft.AspNetCore.Mvc;
    using NHSUKFrontendRazor.ViewModels;

    /// <summary>
    /// A ViewComponent that renders pagination controls based on current sequence, total pages, and URLs.
    /// </summary>
    public class PaginationViewComponent : ViewComponent
    {
        /// <summary>
        /// Invokes the pagination view component.
        /// </summary>
        /// <param name="currentPage">The current page or sequence identifier.</param>
        /// <param name="totalPage">The total pages or sequence identifier.</param>
        /// <param name="prevUrl">The URL for the previous page.</param>
        /// <param name="nextUrl">The URL for the next page.</param>
        /// <param name="previousSequence">Optional override for the previous sequence display text.</param>
        /// <param name="nextSequence">Optional override for the next sequence display text.</param>
        /// <returns>The view component result.</returns>
        public IViewComponentResult Invoke(
            string currentPage,
            string totalPage,
            string? prevUrl,
            string? nextUrl,
            string? previousSequence = null,
            string? nextSequence = null)
        {
            var model = new PaginationViewModel(currentPage, totalPage, prevUrl, nextUrl, previousSequence, nextSequence);
            return this.View(model);
        }
    }
}