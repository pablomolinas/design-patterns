using state.Abstractions;

namespace state
{
    public class StateA : IState
    {
        public void Handle(Context context)
        {
            Console.WriteLine("State A: handle request.");

            context.ChangeState(new StateB());
        }
    }
}
