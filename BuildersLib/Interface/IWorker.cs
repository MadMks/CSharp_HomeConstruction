using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HousePartsLib;

namespace BuildersLib
{
    public interface IWorker/* : IPart*/
    {
        // метод Работать или Строить
        void Work(IPart part);
    }
}
