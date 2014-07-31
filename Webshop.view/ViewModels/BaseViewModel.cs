using Umbraco.Core.Models;
using Umbraco.Web.Models;

namespace Webshop.view.ViewModels
{
    public class BaseViewModel
    {
        protected readonly IPublishedContent _model;

        public BaseViewModel(IPublishedContent model)
        {
            _model = model;
        }

        public object ID
        {
            get
            {
                return _model.Id;
            }
        }

        public string Name
        {
            get
            {
                return _model.Name;
            }
        }

        public object GetPropertyValue(string name)
        {
            var prop = _model.GetProperty(name);

            if (!prop.HasValue)
                return null;

            return prop.Value; }
        }
}