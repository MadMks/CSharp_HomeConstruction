using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HousePartsLib;
using BuildersLib;

// TODO если не добавить работника для соответствующей части, то цыкл будет бесконечным

namespace CSharp_HomeConstruction
{
    class Program
    {
        static void Main(string[] args)
        {

            Team team = new Team();
            House house = new House();
            //Team team = new Team(house.parts);   // +-
            if (true)
            {
                throw new TeamDoesNotHaveATeamLeader();
            }

            //foreach (IPart item in house)
            //{
            //    Console.WriteLine($" {item.GetType().Name} - {item.IsBuilt}");
            //}
            //Console.WriteLine("\n");


            // Ищем бригадира, чтобы он вывел предварительный отчет.
            foreach (IWorker worker in team)
            {
                if (worker is TeamLeader)
                {
                    (worker as TeamLeader).PreliminaryReport(house.parts);  // TODO P
                }
            }
            Console.WriteLine("\n");


            try
            {
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

                    // Если кол-во итераций больше кол-ва частей
                    // кинем исключени (нет подходящего работника).
                    house.CheckAvailabilityOfAllEmployees();
                }
            }
            catch (NoRelevantEmployees e)
            {
                Design.Red();
                Console.WriteLine("\n [error]" + e.Message + "\n");
                Design.Default();
            }
            catch (TeamDoesNotHaveATeamLeader e)
            {
                Design.Red();
                Console.WriteLine("\n [error]" + e.Message + "\n");
                Design.Default();
            }
            catch (Exception e)
            {
                Design.Red();
                Console.WriteLine("\n [error]" + e.Message + "\n");
                Design.Default();
            }
            
            



            //Console.WriteLine("\n\n");
            //foreach (IPart item in house)
            //{
            //    Console.WriteLine($" {item.GetType().Name} - {item.IsBuilt}");
            //}

        }
    }
}

//if ((item as IWorker) is BasementBuilder)
//{
//    ((item as IWorker) as BasementBuilder).Work();
//    //(item as BasementBuilder).Work();
//}
//
/*(item as IWorker)*/
