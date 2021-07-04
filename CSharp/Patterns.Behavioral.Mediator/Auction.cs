using System;
using System.Collections.Generic;

namespace Patterns.Behavioral.Mediator
{
    public class Auction : IAuction
    {
        private Dictionary<string, Participant> _bidders = new Dictionary<string, Participant>();
        private Participant _auctioneer;

        public void Participate(Participant from, string message)
        {
            if(_auctioneer == null)
            {
                throw new ArgumentOutOfRangeException("Can't have an auction with out an auctioneer");
            }

            if(from is Auctioneer)
            {
                // We need to nofity all the other bidders
                foreach(Bidder bidder in _bidders.Values)
                {
                    bidder.Receive(from.Name, message);
                }
            }
            else
            {
                // We only need to notify the auctioneer
                _auctioneer.Receive(from.Name, message);
            }
        }

        public void Register(Participant participant)
        {
            if(participant is Auctioneer)
            {
                if(_auctioneer != null)
                {
                    throw new ArgumentOutOfRangeException("Each Auction can only have one auctioneer");
                }else
                {
                    _auctioneer = participant;
                }
            }else
            {
                // Add the participant to the auction
                if (!_bidders.ContainsKey(participant.Name))
                {
                    _bidders[participant.Name] = participant;
                }
            }

            // Make the participant aware of the auction it's participating in
            participant.Auction = this;
        }
    }
}
