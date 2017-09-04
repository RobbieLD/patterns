using Microsoft.VisualStudio.TestTools.UnitTesting;
using Patterns.Memento;

namespace Patterns.Tests
{
    [TestClass]
    public class MementoTests
    {
        [TestMethod]
        [TestCategory("Memento")]
        public void BikeRace_Save_SavesBikeRace()
        {
            // Arrange
            BikeRace race = new BikeRace(new string[] { "Tom", "Dick", "Harry" });

            // Act
            race.RunToCheckPoint();
            CheckPointSave checkpointOne = new CheckPointSave(race.Save());
            race.RunToCheckPoint();

            // Assert
            Assert.AreNotSame(race.GetRace(), checkpointOne.Restore());
        }

        [TestMethod]
        [TestCategory("Memento")]
        public void BikeRace_Restore_RestoresBikeRace()
        {
            // Arrange
            BikeRace race = new BikeRace(new string[] { "Tom", "Dick", "Harry" });

            // Act
            race.RunToCheckPoint();
            CheckPointSave checkpointOne = new CheckPointSave(race.Save());
            race.RunToCheckPoint();
            race.Restore(checkpointOne.Restore());

            // Assert
            Assert.AreSame(race.GetRace(), checkpointOne.Restore());
        }
    }
}
