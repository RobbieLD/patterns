using Patterns.Memento;
using System.Collections.Generic;

namespace Patterns.Runner
{
    public static class MementoRunner
    {
        public static void Run()
        {
            BikeRace race = new BikeRace(new string[] { "Tom", "Dick", "Harry", "Bill", "Jim", "Rick", "Fred", "Joe", "Dan", "Gav", "Mark", "Henry" });

            // Run to first checkpoint
            race.RunToCheckPoint();
            race.DisplayTheRace();

            CheckPointSave checkpointOne = new CheckPointSave(race.Save());

            race.RunToCheckPoint();
            race.DisplayTheRace();

            // Return to the saved state
            race.Restore(checkpointOne.Restore());
            race.DisplayTheRace();
        }
    }
}
