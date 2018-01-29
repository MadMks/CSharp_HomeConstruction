using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HousePartsLib;
using BuildersLib;

namespace CSharp_HomeConstruction
{
    class Program
    {
        static void Main(string[] args)
        {

            Team team = new Team();
            House house = new House();



            foreach (IPart item in house)
            {
                Console.WriteLine($" {item.GetType().Name} - {item.IsBuilt}");
            }
            Console.WriteLine();



            foreach (IWorker worker in team)
            {
                foreach (IPart part in house)
                {
                    worker.Work(part);
                }   
            }



            Console.WriteLine();
            foreach (IPart item in house)
            {
                Console.WriteLine($" {item.GetType().Name} - {item.IsBuilt}");
            }

        }
    }
}

//if ((item as IWorker) is BasementBuilder)
//{
//    ((item as IWorker) as BasementBuilder).Work();
//    //(item as BasementBuilder).Work();
//}

/*(item as IWorker)*/
