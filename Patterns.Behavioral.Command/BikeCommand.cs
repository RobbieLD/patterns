namespace Patterns.Behavioral.Command
{
    class BikeCommand : BaseBikeRideCommand
    {
        protected IBike _bike;
        protected BikeAction _action;

        public BikeCommand(IBike bike, BikeAction action)
        {
            _bike = bike;
            _action = action;
        }

        public override void DoAction()
        {
            switch(_action)
            {
                case BikeAction.GoBackwards:
                    _bike.YPosition--;
                    break;
                case BikeAction.GoForwards:
                    _bike.YPosition++;
                    break;
                case BikeAction.TurnLeft:
                    _bike.XPosition--;
                    break;
                case BikeAction.TurnRight:
                    _bike.XPosition++;
                    break;
            }
        }

        public override void UndoAction()
        {
            switch (_action)
            {
                case BikeAction.GoBackwards:
                    _bike.YPosition++;
                    break;
                case BikeAction.GoForwards:
                    _bike.YPosition--;
                    break;
                case BikeAction.TurnLeft:
                    _bike.XPosition++;
                    break;
                case BikeAction.TurnRight:
                    _bike.XPosition--;
                    break;
            }
        }

        public override string ToString()
        {
            return _action.ToString();
        }
    }
}
