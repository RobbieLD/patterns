namespace Patterns.Behavioral.Command
{
    interface IBikeRideCommand
    {
        void DoAction();
        void UndoAction();
    }
}
