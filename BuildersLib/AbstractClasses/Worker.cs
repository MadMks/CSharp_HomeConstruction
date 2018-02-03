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

        protected void DownloadBar()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.Write(" #");
                System.Threading.Thread.Sleep(100);
            }
            Console.WriteLine("   Нажмите любую клавишу.");
            Console.ReadKey();
            //Console.WriteLine();
        }
    }
}
