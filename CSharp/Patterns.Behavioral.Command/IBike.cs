namespace Patterns.Behavioral.Command
{
    interface IBike
    {
        int XPosition { get; set; }
        int YPosition { get; set; }

        double GetDistanceFromOrigin();
    }
}
