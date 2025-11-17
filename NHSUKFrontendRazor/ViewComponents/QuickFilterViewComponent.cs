namespace NHSUKFrontendRazor.ViewComponents
{
    using Microsoft.AspNetCore.Mvc;
    using NHSUKFrontendRazor.ViewModels;

    /// <summary>
    /// A ViewComponent that renders a tag based on the provided name and styling.
    /// </summary>
    public class QuickFiltersViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(
            List<string> tagNames,
            string myLearningsType,
            string resourcesType,
            string cataloguesType,
            string dashboardTrayLearningResourceType)
        {
            var model = new QuickFiltersViewModel
            (
                tagNames,
                myLearningsType,
                resourcesType,
                cataloguesType,
                dashboardTrayLearningResourceType
            );
            return View(model);
        }
    }
}