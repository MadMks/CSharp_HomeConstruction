﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BuildersLib;

namespace CSharp_HomeConstruction
{
    class Team : IEnumerable
    {
        IWorker[] workers;

        public Team()
        {
            workers = new IWorker[1];
            workers[0] = new BasementBuilder();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return workers.GetEnumerator();
        }
    }
}
