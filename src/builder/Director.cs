using builder.Abstractions;

namespace builder
{
    public class Director : IDirector
    {
        public IBuilder _builder { get; set; }
        public void SetBuilder(IBuilder builder)
        {
            _builder = builder;
        }

        public void Build()
        {
            _builder.BuildHeader();
            _builder.BuildCategories();
            _builder.BuildLogistic();
        }

    }
}
