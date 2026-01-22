namespace NHSUKFrontendRazor.ViewModels
{
    using System.Collections.Generic;

    public class LinkViewModel
    {
        public readonly string AspAction;

        public readonly string AspController;

        public readonly string LinkText;

        public readonly string Url;

        public readonly Dictionary<string, string>? AspAllRouteData;

        public LinkViewModel(string aspController, string aspAction, string linkText, Dictionary<string, string>? aspAllRouteData = null)
        {
            AspAction = aspAction;
            AspController = aspController;
            LinkText = linkText;
            AspAllRouteData = aspAllRouteData;
        }

        public LinkViewModel(string linkText, string url)
        {
            LinkText = linkText;
            Url = url;
        }
    }
}
