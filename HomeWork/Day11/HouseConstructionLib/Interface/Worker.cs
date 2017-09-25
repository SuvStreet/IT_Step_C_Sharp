using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseConstructionLib
{
    // Строитель
    public class Worker : IWorker
    {
        House house;

        public Worker(House house)
        {
            this.house = house;
        }

        // цикл постройки частей дома
        public void Work()
        {
            for (int i = 0; i < house.CountParts; i++)
            {
                if (house[i] is Basement)
                {
                    if (!house[i].GetConstruction())
                    {
                        house[i].IncreaseProcessOfConstructionByOne();
                        break;
                    }
                }
            }

            for (int i = 0; i < house.CountParts; i++)
            {
                if (house[i] is Walls)
                {
                    if (!house[i].GetConstruction())
                    {
                        house[i].IncreaseProcessOfConstructionByOne();
                    }
                }
            }

            for (int i = 0; i < house.CountParts; i++)
            {
                if (house[i] is Window)
                {
                    if (!house[i].GetConstruction())
                    {
                        house[i].IncreaseProcessOfConstructionByOne();
                    }
                }
            }

            for (int i = 0; i < house.CountParts; i++)
            {
                if (house[i] is Door)
                {
                    if (!house[i].GetConstruction())
                    {
                        house[i].IncreaseProcessOfConstructionByOne();
                    }
                }
            }

            for (int i = 0; i < house.CountParts; i++)
            {
                if (house[i] is Roof)
                {
                    if (!house[i].GetConstruction())
                    {
                        house[i].IncreaseProcessOfConstructionByOne();
                    }
                }
            }
        }
    }
}
