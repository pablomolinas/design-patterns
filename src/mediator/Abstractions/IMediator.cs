namespace mediator.Abstractions
{
    public interface IMediator
    {
        string GetGroupName();
        void RegisterUser(User user);
        void SendMessage(User user, string message);
    }
}
