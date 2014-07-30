using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Web;
using Umbraco.Web.Models;

namespace Webshop.view.ViewModels
{
    public class ProductGroupViewmodel : BaseViewModel
    {
        public ProductGroupViewmodel(IPublishedContent model)
            : base(model)
        {
            Products = model.Children.Where(x => x.DocumentTypeAlias == "Product")
                .Select(x => new ProductViewModel(x));
        }

        public IEnumerable<ProductViewModel> Products { get; set; }
    }

    public class ProductViewModel : BaseViewModel
    {
        public ProductViewModel(IPublishedContent model)
            : base(model)
        {
        }

        public decimal Price
        {
            get { return decimal.Parse(GetPropertyValue("Price").ToString()); }
        }
    }
}