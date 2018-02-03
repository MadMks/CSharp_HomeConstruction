using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousePartsLib
{
    public class Door : IPart
    {
        public int NumberOfParts { get; set; }
        public bool IsBuilt { get; set; }
        public int NumberBuiltParts { get; set; } = 0;

        public Door()
        {
            NumberOfParts = 1;
            IsBuilt = false;
        }
        public Door(int numberOfParts)
        {
            NumberOfParts = numberOfParts;
            IsBuilt = false;
        }

        public void Build()
        {
            NumberBuiltParts++;

            if (NumberBuiltParts == NumberOfParts)
            {
                IsBuilt = true;
            }
        }

        public override string ToString()
        {
            return " Дверь";
        }


    }
}