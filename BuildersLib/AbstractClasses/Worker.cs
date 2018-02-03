using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DesignDll;

namespace BuildersLib
{
    public abstract class Worker : Employee
    {
        // TODO  можно написать конкретную специализацию
        // (напр установщик дверей).

        protected void DownloadBar()
        {
            Design.Blue();
            for (int i = 0; i < 5; i++)
            {
                Console.Write(" #");
                System.Threading.Thread.Sleep(100);
            }
            Console.WriteLine("   Нажмите любую клавишу.");
            Design.Default();
            Console.ReadKey();
        }


    }
}