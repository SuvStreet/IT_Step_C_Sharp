using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseConstructionLib
{
    // Бригадир
    public class TeamLeader : IWorker
    {
        House house;

        public TeamLeader(House house)
        {
            this.house = house;
        }

        // вывод сделанной работы строителями
        public void Work()
        {
            int process = 0;
            int full = 0;

            for (int i = 0; i < house.CountParts; i++)
            {
                process += house[i].GetCountConstruction();
                full += house[i].GetCountFull();
            }
            Console.WriteLine("Дом завершён на {0} процента(-ов).", 100 * process / full);
        }
    }
}
