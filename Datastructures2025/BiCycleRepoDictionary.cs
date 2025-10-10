using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructures2025
{
    public class BiCycleRepoDictionary : IBiCycleRepository
    {
        //instance field
        private Dictionary<string, BiCycle> _bikes;

        public BiCycleRepoDictionary()
        {
            _bikes = new Dictionary<string, BiCycle>();
        }

        public int Count
        {
            get { return _bikes.Count; }
        }

        public void Add(BiCycle bicycle)
        {
            if (!_bikes.ContainsKey(bicycle.SNO))
            {
                _bikes.Add(bicycle.SNO, bicycle);
            }
        }

        public void Remove(string sno)
        {
            throw new NotImplementedException();
        }

        public BiCycle? Search(string sno)
        {
            throw new NotImplementedException();
        }

        public void Update(BiCycle updatedBicycle)
        {
            throw new NotImplementedException();
        }
    }
}
