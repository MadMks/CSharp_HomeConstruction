using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousePartsLib
{
    public class Window : IPart
    {
        public int NumberOfParts { get; set; }
        public bool IsBuilt { get; set; }

        public int NumberBuiltParts { get; set; } = 0;


        public Window()
        {
            NumberOfParts = 1;
            IsBuilt = false;
        }
        public Window(int numberOfParts)
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
            return " Окна";
        }


    }
}