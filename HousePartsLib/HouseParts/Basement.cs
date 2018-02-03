using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousePartsLib
{
    public class Basement : IPart
    {
        public int NumberOfParts { get; set; }
        public int NumberBuiltParts { get; set; }
        public bool IsBuilt { get; set; }

        public Basement()
        {
            NumberOfParts = 1;
            IsBuilt = false;
        }

        public void Build()
        {
            IsBuilt = true;
        }

        public override string ToString()
        {
            return $" Фундамент";
        }
    }
}