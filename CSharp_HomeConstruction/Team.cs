using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BuildersLib;
using HousePartsLib;

namespace CSharp_HomeConstruction
{
    class Team : IEnumerable
    {
        IWorker[] workers;  // TODO private

        public Team()
        {
            //workers = new IWorker[1];
            //workers[0] = new BasementBuilder();
            workers = new IWorker[]
            {
                new BasementBuilder(),
                new WallsBuilder(),
                new TeamLeader()
            };
        }

        //public Team() { }
        //public Team(IPart[] parts)
        //{
        //    workers = new IWorker[]
        //    {
        //        new TeamLeader(parts),
        //        new BasementBuilder()
        //    };
        //}

        //public void SearchTeamLeader()
        //{
        //    foreach (IWorker worker in workers)
        //    {
        //        if (worker is TeamLeader)
        //        {
        //            return;
        //        }
        //    }

        //    throw new TeamDoesNotHaveATeamLeader();
        //}

        IEnumerator IEnumerable.GetEnumerator()
        {
            return workers.GetEnumerator();
        }
    }
}
