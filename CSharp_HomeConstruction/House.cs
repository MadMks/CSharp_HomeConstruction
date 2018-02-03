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
        private int _nIterations;

        public House()
        {
            _nIterations = 0;

            HouseIsBuilt = false;   // TODO ???
            //parts = new IPart[2];
            //parts[0] = new Basement();
            //parts[1] = new
            parts = new IPart[]
            {
                new Basement(),
                new Walls(4)
            };
        }

        public bool CheckWhetherTheHouseIsBuilt()
        {
            foreach (IPart part in parts)
            {
                if (part.IsBuilt == false)
                {
                    return false;
                }
            }

            return true;
        }

        public void CheckAvailabilityOfAllEmployees()
        {
            _nIterations++;

            if (_nIterations > NumberOfAllPartsInHouse())
            {
                throw new NoRelevantEmployees();
            }
        }

        private int NumberOfAllPartsInHouse()
        {
            int nOfAllParts = 0;

            // Считаем кол-во всех частей дома,
            foreach (IPart part in parts)
            {
                if (part.NumberOfParts > 1)
                {
                    nOfAllParts += part.NumberOfParts;
                }
                else if (part.NumberOfParts == 1)
                {
                    nOfAllParts++;
                }
            }

            return nOfAllParts;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return parts.GetEnumerator();
        }
    }
}
