using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructures2025
{
    public class BiCycleRepository
    {
        private List<BiCycle> _bicycles;

        public BiCycleRepository()
        {
            _bicycles = new List<BiCycle>();
        }

        public int Count
        {
            get { return _bicycles.Count;  }
        }
         
        public void Add(BiCycle bicycle)
        {
            if (bicycle!=null)
                _bicycles.Add(bicycle);
        }

    }
}
