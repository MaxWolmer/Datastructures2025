using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructures2025
{
    public class BiCycleRepository : IBiCycleRepository
    {
        private List<BiCycle> _bicycles;

        public BiCycleRepository()
        {
            _bicycles = new List<BiCycle>();
        }

        public int Count
        {
            get { return _bicycles.Count; }
        }

        public void Add(BiCycle bicycle)
        {
            foreach (BiCycle b in _bicycles)
            {
                if (bicycle.SNO == b.SNO)
                {
                    return;
                }
            }
            //if (bicycle != null && Search(bicycle.SNO == null))
            _bicycles.Add(bicycle);
        }

        public BiCycle? Search(string sno)
        {
            //foreach(BiCycle b in _bicycles)
            //{
            //    if (b.SNO== sno)
            //    {
            //        return b;
            //    }
            //}
            //return null; 
            for (int i = 0; i < _bicycles.Count; i++)
            {
                if (_bicycles[i].SNO == sno)
                {
                    return _bicycles[i];
                }
            }
            return null;
        }

        public void Remove(string sno)
        {
            BiCycle? bToBeRemoved = Search(sno);
            if (bToBeRemoved != null)
            {
                _bicycles.Remove(bToBeRemoved);
            }
        }

        public void Update(string sno, BiCycle updatedBicycle)
        {
            Remove(updatedBicycle.SNO);
            Add(updatedBicycle);
        }

        public void PrintAll()
        {
            throw new NotImplementedException();
        }
    }

}

