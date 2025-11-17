namespace NHSUKFrontendRazor.ViewComponents
{
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Mvc;
    using NHSUKFrontendRazor.ViewModels;

    public class FieldsetViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(
            string title,
            List<FieldViewModel> fieldList)
        {
            var model = new FieldsetViewModel(title, fieldList);

            return View(model);
        }
    }
}
