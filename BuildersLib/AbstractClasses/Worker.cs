using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildersLib
{
    public abstract class Worker : Employee
    {
        // свойство Специализация
        public string Specialization { get; set; }  // TODO !?
    }
}
