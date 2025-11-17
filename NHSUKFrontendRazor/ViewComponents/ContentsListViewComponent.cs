namespace NHSUKFrontendRazor.ViewComponents
{
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Mvc;
    using NHSUKFrontendRazor.ViewModels;

    /// <summary>
    /// A ViewComponent that renders a list of contents based on the provided name and list of content items.
    /// </summary>
    public class ContentsListViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(
            string name,
            IEnumerable<ContentsListItemViewModel> listItems)
        {
            var model = new ContentsListViewModel(name, listItems);

            return View(model);
        }
    }
}
