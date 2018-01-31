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

            Console.WriteLine(new string('=', 36));
            Console.WriteLine("\n Отчет о выполненных работах:\n");

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

            // TODO выводим какая часть работы выполнена (возможно в процентах)
            ShowPartOfTheWorkInPercent(parts);

            Console.WriteLine("\n" + new string('=', 36));

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

        // Изображение дома.
        void ImageOfTheHouse()
        {
            WriteLine("#\n#\n#\n#\n#\n#\n#\n");
        }

        // Предварительный отчет.
        public void PreliminaryReport(IPart[] parts)
        {
            Console.WriteLine(" Требуется построить:");

            foreach (IPart part in parts)
            {
                Console.Write($" - {part}");
                if (part.NumberOfParts > 1)
                {
                    Console.Write($" ({part.NumberOfParts} шт)");
                }
                Console.WriteLine();
            }
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
            
            Console.WriteLine("\n Всего выполнено: "
                + $"{Math.Round((100 / (double)nOfAllParts) * nBuiltParts)}% работы.");
        }



    }
}
