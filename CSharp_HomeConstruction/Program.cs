using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BuildersLib;
using DesignDll;


namespace CSharp_HomeConstruction
{
    class Program
    {
        static void Main(string[] args)
        {
            Title = " Строительство дома";

            Team team = new Team();
            House house = new House();


            // Ищем бригадира, чтобы он вывел предварительный отчет.
            foreach (IWorker worker in team)
            {
                if (worker is TeamLeader)
                {
                    (worker as TeamLeader).PreliminaryReport(house.Parts);
                }
            }
            WriteLine("\n");


            try
            {
                // Строительство дома.
                while (house.CheckWhetherTheHouseIsBuilt() == false)
                {
                    foreach (IWorker worker in team)
                    {
                        worker.Work(house.Parts);
                    }

                    // Если кол-во итераций больше кол-ва частей
                    // кинем исключение (нет подходящего работника).
                    house.CheckAvailabilityOfAllEmployees();
                }
            }
            catch (NoRelevantEmployees e)
            {
                Design.Red();
                WriteLine("\n [error] " + e.Message + "\n");
                Design.Default();
            }
            catch (Exception e)
            {
                Design.Red();
                WriteLine("\n [error] " + e.Message + "\n");
                Design.Default();
            }
            
            

        }
    }
}