using System;
using Patterns.Behavioral.Mediator;

namespace Patterns.Runner
{
    public class MediatorRunner : BaseRunner, IRunner
    {
        public void Run()
        {
            ShowTitle();

            Auction auction = new Auction();
            Participant tom = new Bidder("Tom");
            Participant dick = new Bidder("Dick");
            Participant harry = new Bidder("Harry");
            Participant fred = new Auctioneer("Fred");

            // Register the participants in the auction
            auction.Register(tom);
            auction.Register(dick);
            auction.Register(harry);
            auction.Register(fred);

            // Do some auctioning
            fred.Participate("Who will start the bidding?");
            tom.Participate("Bidding 100");
            dick.Participate("Bidding 110");
            harry.Participate("Bidding 150");
            fred.Participate("Bike sold to Harry for 150");
        }
    }
}
