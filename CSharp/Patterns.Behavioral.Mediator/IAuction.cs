namespace Patterns.Behavioral.Mediator
{
    public interface IAuction
    {
        void Register(Participant participant);
        void Participate(Participant from, string message);
    }
}
