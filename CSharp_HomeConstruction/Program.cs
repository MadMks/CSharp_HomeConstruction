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
            //Team team = new Team(house.parts);   // +-


            foreach (IPart item in house)
            {
                Console.WriteLine($" {item.GetType().Name} - {item.IsBuilt}");
            }
            Console.WriteLine("\n");


            // Ищем бригадира, чтобы он вывел предварительный отчет.
            foreach (IWorker worker in team)
            {
                if (worker is TeamLeader)
                {
                    (worker as TeamLeader).PreliminaryReport(house.parts);  // TODO P
                }
            }
            Console.WriteLine("\n");


            // Строительство дома.
            while (house.CheckWhetherTheHouseIsBuilt() == false)
            {
                foreach (IWorker worker in team)
                {
                    //foreach (IPart part in house)
                    //{
                    //    worker.Work(part);
                    //}  
                    worker.Work(house.parts);   // +-? 
                }
            }
            



            Console.WriteLine("\n\n");
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
