using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HousePartsLib;
using BuildersLib;

namespace CSharp_HomeConstruction
{
    class Program
    {
        static void Main(string[] args)
        {

            Team team = new Team();
            House house = new House();

            foreach (Team item in team)
            {
                if ((item as IWorker) is BasementBuilder)
                {
                    ((item as IWorker) as BasementBuilder).Work();
                    //(item as BasementBuilder).Work();
                }
            }

        }
    }
}
