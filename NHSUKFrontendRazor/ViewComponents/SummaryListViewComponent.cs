namespace NHSUKFrontendRazor.ViewComponents
{
    using Microsoft.AspNetCore.Mvc;
    using NHSUKFrontendRazor.ViewModels;

    /// <summary>
    /// A ViewComponent that renders a list of summary items with an optional border.
    /// </summary>
    public class SummaryListViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(IEnumerable<SummaryListItemViewModel> summaryListItem,
            bool hasBorder = true)
        {
            var model = new SummaryListViewModel
            (
                summaryListItem,
                hasBorder
            );

            return View(model);
        }
    }
}
