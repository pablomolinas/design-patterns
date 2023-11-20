namespace state.Abstractions
{
    public interface IState
    {
        void Handle(Context context);
    }
}
