using Microsoft.AspNetCore.Html;

namespace NHSUKFrontendRazor.ViewModels
{
    public class FieldsetViewModel
    {
        public FieldsetViewModel(
            string title,
            List<FieldViewModel> fieldList)
        {
            Title = title;
            FieldList = fieldList;
        }

        public string Title { get; set; }
        public List<FieldViewModel> FieldList { get; set; }

    }

    public class FieldViewModel
    {
        public FieldViewModel(Func<object, IHtmlContent> content)
        {
            Content = content;
        }

        public Func<object, IHtmlContent> Content { get; set; }
    }
}
