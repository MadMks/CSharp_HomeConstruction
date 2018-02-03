using System;
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
        private IWorker[] _workers;

        public Team()
        {
            _workers = new IWorker[]
            {
                new DoorBuilder(),
                new BasementBuilder(),
                new WallsBuilder(),
                new RoofBuilder(),
                new WindowBuilder(),
                new TeamLeader()
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _workers.GetEnumerator();
        }
    }
}