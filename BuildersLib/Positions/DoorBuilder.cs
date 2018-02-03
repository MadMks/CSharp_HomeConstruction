using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HousePartsLib;

namespace BuildersLib
{
    public class DoorBuilder : Worker, IWorker
    {
        public void Work(IPart[] parts)
        {
            if (ThePreviousPartIsBuilt(parts))
            {
                foreach (IPart part in parts)
                {
                    if (part is Door && part.IsBuilt == false)
                    {
                        DownloadBar();
                        (part as Door).Build();
                    }
                }
            }
        }

        // Проверяем построена ли предыдущая часть
        // (нужная для стротельства текущей части).
        bool ThePreviousPartIsBuilt(IPart[] parts)
        {
            foreach (IPart part in parts)
            {
                if (part is Walls && part.IsBuilt == true)
                {
                    return true;
                }
            }

            return false;
        }


    }
}