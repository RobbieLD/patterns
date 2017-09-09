using System;

namespace Patterns.Behavioral.Memento
{
    public class BikeRace
    {
        private string[] _participants;

        public BikeRace(string[] participants)
        {
            _participants = participants;
        }

        public void RunToCheckPoint()
        {
            // Shuffle the ranks

            Random rand = new Random();

            int n = _participants.Length;

            while(n > 1)
            {
                n--;
                int k = rand.Next(n + 1);
                string name = _participants[k];
                _participants[k] = _participants[n];
                _participants[n] = name;
            }

        }

        public void DisplayTheRace()
        {
            Console.WriteLine("The Race stadings are as follows");
            for (int i = 0; i < _participants.Length; i++)
            {
                Console.WriteLine($"{i}: {_participants[i]}");
            }
        }

        public string[] GetRace()
        {
            return _participants;
        }

        public void Restore(string[] race)
        {
            _participants = race;
        }

        public string[] Save()
        {
            return _participants.Clone() as string[];
        }


    }
}
