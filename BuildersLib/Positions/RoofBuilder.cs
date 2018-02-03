using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HousePartsLib;

namespace BuildersLib
{
    public class RoofBuilder : Worker, IWorker
    {
        public void Work(IPart[] parts)
        {
            if (ThePreviousPartIsBuilt(parts))
            {
                foreach (IPart part in parts)
                {
                    if (part is Roof && part.IsBuilt == false)
                    {
                        DownloadBar();
                        (part as Roof).Build();
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
                if (part is Window && part.IsBuilt == true)
                {
                    return true;
                }
            }

            return false;
        }



    }
}