using System;
using System.Collections.Generic;

namespace Patterns.Builder
{
    public class Bike
    {
        private Dictionary<string, string> _componants = new Dictionary<string, string>();
        private readonly string _bikeType;

        public Bike(string name)
        {
            _bikeType = name;
        }

        public string this[string key]
        {
            get
            {
                return _componants[key];
            }

            set
            {
                _componants[key] = value;
            }
        }

        public void DescribeBike()
        {
            Console.WriteLine("Describing: {0}", _bikeType);

            foreach (var key in _componants.Keys)
            {
                Console.WriteLine(" - Componant: {0} Value: {1}", key, _componants[key]);
            }
        }
    }
}
