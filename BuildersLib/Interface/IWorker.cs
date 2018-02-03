using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HousePartsLib;

namespace BuildersLib
{
    public interface IWorker
    {
        void Work(IPart[] parts);
    }
}