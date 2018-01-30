using System;
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

        public void Work(IPart[] part)
        {
            // Работа бригадира состоит в формировании отчета.

            // формирует отчёт, что уже построено
            // и какая часть работы выполнена.
            throw new NotImplementedException();
        }
    }
}
