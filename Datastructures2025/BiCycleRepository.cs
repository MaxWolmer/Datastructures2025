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
            for(int i =0;i<_bicycles.Count; i++)
            {
                if (_bicycles[i].SNO==sno)
                {
                    return _bicycles[i];
                }
            }
            return null; 
        }



    }
}
