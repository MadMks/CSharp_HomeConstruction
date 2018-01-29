using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousePartsLib
{
    public class Walls : IPart
    {
        public bool IsBuilt { get; set; }

        public Walls()
        {
            IsBuilt = false;
        }

        public void Build()
        {
            IsBuilt = true;
        }
    }
}
