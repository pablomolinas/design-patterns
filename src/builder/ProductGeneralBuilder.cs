using builder.Abstractions;
using builder.Models;

namespace builder
{
    public class ProductGeneralBuilder : IBuilder
    {
        private Product _product;

        public void BuildHeader()
        {
            _product = new Product(ProductTypes.General);
        }
        
        public void BuildCategories()
        {
            _product.Category = "Categories for General product.";
        }

        public void BuildLogistic()
        {
            _product.Logistic = "Logistic data for General product.";
        }

        public Product GetResult()
        {
            return _product;
        }
    }
}
