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

            if (ThePreviousPartIsBuilt(parts))
            {
                foreach (IPart part in parts)
                {
                    if (part is Walls && part.IsBuilt == false)
                    {
                        //Console.WriteLine(" #");
                        DownloadBar();
                        (part as Walls).Build();
                    }
                }
            }
            
        }

        // Проверяем построена ли предыдущая часть
        // (нужная для стротельства текущей части).
        bool ThePreviousPartIsBuilt(IPart[] parts)
        {
            foreach (IPart item in parts)
            {
                //if (((item is Basement) as Basement).IsBuilt == false)
                //{
                if ((item as Basement).IsBuilt == true)
                {
                    return true;
                }
                //}
            }

            return false;
        }



    }
}
