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
        public void Work(IPart[] parts)
        {
            foreach (IPart part in parts)
            {
                // Проверки на предыдущую часть нет,
                // так как фундамент строим первым.
                if (part is Basement && part.IsBuilt == false)
                {
                    DownloadBar();
                    (part as Basement).Build();
                }
            }
        }


    }
}