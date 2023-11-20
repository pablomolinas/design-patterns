namespace builder.Abstractions
{
    public interface IDirector
    {
        IBuilder _builder { get; set; }

        void SetBuilder(IBuilder builder);
        void Build();
    }
}
