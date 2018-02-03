using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HousePartsLib;
using DesignDll;

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

            int nBuiltParts = 0;

            //WriteLine(new string('=', 36));

            WriteLine("\n Отчет о выполненных работах:\n");

            foreach (IPart part in parts)
            {
                if (part.IsBuilt == true)
                {
                    Write(part + ": построено\n");

                    nBuiltParts++;
                }
                else if (part.NumberOfParts > 1)
                {
                    Write(part + $": построено - {part.NumberBuiltParts} из {part.NumberOfParts} частей\n");
                }
            }

            ShowPartOfTheWorkInPercent(parts);

            WriteLine("\n" + new string('=', 36));

            // если все построено, то вызовем метод
            // все построено
            if (nBuiltParts == parts.Length)
            {
                WriteLine(" Нажмите любую клавишу.");
                ReadKey();

                ConstructionCompleted();
            }

        }

        void ConstructionCompleted()
        {
            WriteLine("\n" + new string('=', 36));

            Design.Green();
            WriteLine("\n Строительство дома завершено.\n");
            Design.Default();

            ImageOfTheHouse();
        }

        // Предварительный отчет.
        public void PreliminaryReport(IPart[] parts)
        {
            WriteLine("\n Требуется построить:");

            foreach (IPart part in parts)
            {
                Write($" - {part}");
                if (part.NumberOfParts > 1)
                {
                    Write($" ({part.NumberOfParts} шт)");
                }
                WriteLine();
            }

            Design.Line();
        }

        private void ShowPartOfTheWorkInPercent(IPart[] parts)
        {
            int nOfAllParts = 0;
            int nBuiltParts = 0;

            // Считаем кол-во всех частей дома,
            // и кол-во построенных частей.
            foreach (IPart part in parts)
            {
                if (part.NumberOfParts > 1)
                {
                    nOfAllParts += part.NumberOfParts;

                    nBuiltParts += part.NumberBuiltParts;
                }
                else if (part.NumberOfParts == 1)
                {
                    nOfAllParts++;

                    if (part.IsBuilt == true)
                    {
                        nBuiltParts++;
                    }
                }
            }
            
            
            WriteLine("\n Всего выполнено: "
                + $"{Math.Round((100 / (double)nOfAllParts) * nBuiltParts)}% работы.");
        }


        private void ImageOfTheHouse()
        {
            WriteLine(@"
                           (   )
                          (    )
                           (    )
                          (    )
                            )  )
                           (  (                  /\
                            (_)                 /  \  /\
                    ________[_]________      /\/    \/  \
           /\      /\        ______    \    /   /\/\  /\/\
          /  \    //_\       \    /\    \  /\/\/    \/    \
   /\    / /\/\  //___\       \__/  \    \/
  /  \  /\/    \//_____\       \ |[]|     \
 /\/\/\/       //_______\       \|__|      \
/      \      /XXXXXXXXXX\                  \
        \    /_I_II  I__I_\__________________\
               I_I|  I__I_____[]_|_[]_____I
               I_II  I__I_____[]_|_[]_____I
               I II__I  I     XXXXXXX     I
            ~~~~~'   '~~~~~~~~~~~~~~~~~~~~~~~~" + "\n\n");
        }



    }
}
