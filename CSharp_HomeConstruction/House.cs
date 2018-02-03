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
        public IPart[] Parts { get; set; }
        private int _nIterations;

        public House()
        {
            _nIterations = 0;

            Parts = new IPart[]
            {
                new Basement(),
                new Window(4),
                new Roof(),
                new Door(),
                new Walls(4)
            };
        }

        public bool CheckWhetherTheHouseIsBuilt()
        {
            foreach (IPart part in Parts)
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
            foreach (IPart part in Parts)
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
            return Parts.GetEnumerator();
        }


    }
}