using state.Abstractions;

namespace state
{
    public class StateB : IState
    {
        public void Handle(Context context)
        {
            Console.WriteLine("State B: handle request.");

            context.ChangeState(new StateA());
        }
    }
}
