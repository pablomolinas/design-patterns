using builder.Abstractions;
using builder.Models;

namespace builder
{
    public class ProductServiceBuilder : IBuilder
    {
        private Product _product;

        public void BuildHeader()
        {
            _product = new Product(ProductTypes.Service);
        }

        public void BuildCategories()
        {
            _product.Category = "Categories for Service product.";
        }

        public void BuildLogistic()
        {
            _product.Logistic = "Logistic data for Service product.";
        }

        public Product GetResult()
        {
            return _product;
        }
    }
}
