namespace Patterns.Command
{
    abstract class BaseBikeRideCommand : IBikeRideCommand
    {
        public abstract void DoAction();
        public abstract void UndoAction();
    }
}
