using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HousePartsLib;

namespace BuildersLib
{
    public class WindowBuilder : Worker, IWorker
    {

        public void Work(IPart[] parts)
        {
            if (ThePreviousPartIsBuilt(parts))
            {
                foreach (IPart part in parts)
                {
                    if (part is Window && part.IsBuilt == false)
                    {
                        DownloadBar();
                        (part as Window).Build();
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
                if (part is Door && part.IsBuilt == true)
                {
                    return true;
                }
            }

            return false;
        }


    }
}