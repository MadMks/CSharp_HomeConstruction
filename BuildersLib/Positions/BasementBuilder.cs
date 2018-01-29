using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HousePartsLib;

namespace BuildersLib
{
    public class BasementBuilder : Worker, IWorker
    {
        public void Work(IPart part)
        {
            //Console.WriteLine(part.IsBuilt);
            

            if (part is Basement && part.IsBuilt == false)
            {
                Console.WriteLine(" >>> test - Work = BasementBuilder build Basement");
                (part as Basement).Build();
            }

            //Console.WriteLine(part.IsBuilt);
        }
    }
}
