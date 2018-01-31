using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HousePartsLib;
using System.Collections;

namespace CSharp_HomeConstruction
{
    public class House : IEnumerable
    {
        //IPart[] parts;
        public IPart[] parts { get; set; }  // +-   // TODO p -> P
        public bool HouseIsBuilt { get; set; }  // TODO ???

        public House()
        {
            HouseIsBuilt = false;   // TODO ???
            //parts = new IPart[2];
            //parts[0] = new Basement();
            //parts[1] = new
            parts = new IPart[]
            {
                new Basement(),
                new Walls(2)
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return parts.GetEnumerator();
        }
    }
}
