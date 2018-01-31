using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HousePartsLib;

namespace BuildersLib
{
    public class TeamLeader : Worker, IWorker
    {
        //IPart[] _parts;  // +-
        //public TeamLeader() { }
        //public TeamLeader(IPart[] parts)  // +-
        //{
        //    _parts = parts;
        //}

        public void Work(IPart[] parts)
        {
            // Работа бригадира состоит в формировании отчета.

            // формирует отчёт, что уже построено
            // и какая часть работы выполнена.

            int nBuiltParts = 0;

            foreach (IPart part in parts)
            {
                // отчет по каждой части.
                if (part.IsBuilt == true)
                {
                    Write(part + ": построено\n");

                    nBuiltParts++;
                }
                else if (part.NumberOfParts > 1)
                {
                    Write(part + $": построено - {part.NumberBuiltParts} из {part.NumberOfParts} частей");
                }
            }

            // если все построено, то вызовем метод
            // все построено
            if (nBuiltParts == parts.Length)
            {
                ConstructionCompleted();
            }

        }

        void ConstructionCompleted()
        {
            WriteLine("\n" + new string('=', 36));

            WriteLine("\n Строительство дома завершено.\n");
        }

        void ImageOfTheHouse()
        {
            WriteLine("#\n#\n#\n#\n#\n#\n#\n");
        }

    }
}
