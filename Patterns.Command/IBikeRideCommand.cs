namespace Patterns.Command
{
    interface IBikeRideCommand
    {
        void DoAction();
        void UndoAction();
    }
}
