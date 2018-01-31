using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HousePartsLib;

namespace BuildersLib
{
    public class WallsBuilder : Worker, IWorker
    {
        public void Work(IPart[] parts)
        {
            foreach (IPart item in parts)
            {
                //if (((item is Basement) as Basement).IsBuilt == false)
                //{
                    if ((item as Basement).IsBuilt == false)
                    {
                    return;
                    } 
                //}
            }

            foreach (IPart part in parts)
            {
                if (part is Walls && part.IsBuilt == false)
                {
                    Console.WriteLine(" >>> test - Work = WallsBuilder build  -> Walls");
                    (part as Walls).Build();
                }
            }
        }
    }
}
