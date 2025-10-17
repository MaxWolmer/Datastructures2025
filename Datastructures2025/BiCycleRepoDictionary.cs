using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructures2025
{
    public class BiCycleRepoDictionary : IBiCycleRepository
    {
<<<<<<< HEAD
        //Instance field
=======
        //instance field
>>>>>>> 6a8d0e3f42e4741c8ca6ddb66c3fdc3450579d71
        private Dictionary<string, BiCycle> _bikes;

        public BiCycleRepoDictionary()
        {
            _bikes = new Dictionary<string, BiCycle>();
        }

        public int Count
        {
<<<<<<< HEAD
            get {return _bikes.Count; }
        } 
        //=> throw new NotImplementedException();
=======
            get { return _bikes.Count; }
        }
>>>>>>> 6a8d0e3f42e4741c8ca6ddb66c3fdc3450579d71

        public void Add(BiCycle bicycle)
        {
            if (!_bikes.ContainsKey(bicycle.SNO))
            {
                _bikes.Add(bicycle.SNO, bicycle);
            }
        }

        public void PrintAll()
        {
<<<<<<< HEAD
            foreach (var pair in _bikes)
            {
                Console.WriteLine($"key {pair.Key} \nvalue {pair.Value} ");
            }
            {
                foreach(BiCycle b in _bikes.Values)
                {
                    Console.WriteLine(b);
                }
=======
            //foreach(var pair in _bikes)
            //{
            //    Console.WriteLine($" key {pair.Key} value {pair.Value} ");
            //}
            foreach(BiCycle b in _bikes.Values)
            {
                Console.WriteLine(b);
>>>>>>> 6a8d0e3f42e4741c8ca6ddb66c3fdc3450579d71
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

<<<<<<< HEAD
        public void Update(string sno, BiCycle updatedBicycle)
=======
        public void Update(BiCycle updatedBicycle)
>>>>>>> 6a8d0e3f42e4741c8ca6ddb66c3fdc3450579d71
        {
            if (_bikes.ContainsKey(updatedBicycle.SNO))
            {
                _bikes[updatedBicycle.SNO] = updatedBicycle;
            }
<<<<<<< HEAD
=======
            
>>>>>>> 6a8d0e3f42e4741c8ca6ddb66c3fdc3450579d71
        }
    }
}
