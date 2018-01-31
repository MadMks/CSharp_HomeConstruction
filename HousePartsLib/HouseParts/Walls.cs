using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousePartsLib
{
    public class Walls : IPart
    {
        public int NumberOfParts { get; set; }
        public bool IsBuilt { get; set; }

        //private int _nBuiltParts = 0;
        public int NumberBuiltParts { get; set; } = 0;


        public Walls()
        {
            NumberOfParts = 1;
            IsBuilt = false;
        }
        public Walls(int numberOfParts)
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

        //public int GetQuantityBuiltParts()
        //{
        //    return _nBuiltParts;
        //}

        public override string ToString()
        {
            return " Стены"; // TODO string
        }

    }
}
