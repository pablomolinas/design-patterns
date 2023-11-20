using builder.Models;

namespace builder.Abstractions
{
    public interface IBuilder
    {
        void BuildHeader();
        void BuildCategories();
        void BuildLogistic();
        Product GetResult();
    }
}
