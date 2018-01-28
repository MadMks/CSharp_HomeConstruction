using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HousePartsLib;
//using System.Collections;

namespace CSharp_HomeConstruction
{
    public class House /*: IEnumerable*/
    {
        IPart[] parts;
        //public IPart[] Parts { get; set; }

        public House()
        {
            parts = new IPart[1];
            parts[0] = new Basement();
        }

        //IEnumerator IEnumerable.GetEnumerator()
        //{
        //    return parts.GetEnumerator();
        //}
    }
}
