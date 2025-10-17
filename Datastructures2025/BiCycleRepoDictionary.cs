using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructures2025
{
    public class BiCycleRepoDictionary : IBiCycleRepository
    {
        //Instance field
        private Dictionary<string, BiCycle> _bikes;

        public BiCycleRepoDictionary()
        {
            _bikes = new Dictionary<string, BiCycle>();
        }

        public int Count
        {
            get {return _bikes.Count; }
        } 
        //=> throw new NotImplementedException();

        public void Add(BiCycle bicycle)
        {
            if (!_bikes.ContainsKey(bicycle.SNO))
            {
                _bikes.Add(bicycle.SNO, bicycle);
            }
        }

        public void PrintAll()
        {
            foreach (var pair in _bikes)
            {
                Console.WriteLine($"key {pair.Key} \nvalue {pair.Value} ");
            }
            {
                foreach(BiCycle b in _bikes.Values)
                {
                    Console.WriteLine(b);
                }
            }
        }

        public void Remove(string sno)
        {
            _bikes.Remove(sno);
        }

        public BiCycle? Search(string sno)
        {
            if (_bikes.ContainsKey(sno))
            {
                return _bikes[sno];
            }
            return null;
        }

        public void Update(string sno, BiCycle updatedBicycle)
        {
            if (_bikes.ContainsKey(updatedBicycle.SNO))
            {
                _bikes[updatedBicycle.SNO] = updatedBicycle;
            }
        }
    }
}
