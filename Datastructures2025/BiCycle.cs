using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructures2025
{


    public class BiCycle
    {
        private string _sno;

        public string SNO
        {
            get { return _sno; }
        }

        

        public string Model { get; set; }

        public int Gears { get; set; }

        public BiCycle( int gears, string model, string sno )
        {
            Gears = gears;
            Model = model;
            _sno = sno;
            
        }

        public override string ToString()
        {
            return $"Stelnummer:{_sno} antal gear:{Gears} model:{Model} ";
        }
    }
}
