using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Patterns.Behavioral.Mediator;
using System;
using System.IO;

namespace Patterns.Tests
{
    [TestClass]
    public class MediatorTests
    {
        [TestMethod]
        [TestCategory("Mediator")]
        public void Auctioneer_Participate_CallsParticipantsReceive()
        {
            // Arrange
            string bidderName = "bidder";
            string auctioneerName = "auctioneer";
            Auction auction = new Auction();
            Participant bidder = new Bidder(bidderName);
            Participant auctioneer = new Auctioneer(auctioneerName);

            auction.Register(bidder);
            auction.Register(auctioneer);

            using (StringWriter writer = new StringWriter())
            {
                // Capture the console output
                Console.SetOut(writer);

                // Act
                auctioneer.Participate("Who will start the bidding?");

                // Assert
                Assert.IsTrue(writer.ToString().Contains($"{auctioneerName} to {bidderName}"));

            }
        }
    }
}
