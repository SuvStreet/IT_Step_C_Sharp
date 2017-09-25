using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HouseConstructionLib;

namespace HouseConstruction
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(100, 40); // устанавливаем значение высоты и ширины окна консоли

            House house = new HouseConstructionLib.House();
            Team team = new HouseConstructionLib.Team(house);

            int pos = 0;
            int count = 0;
            bool teamLeader = false;
            bool worker = false;

            while (pos != 3)
            {
                Console.WriteLine("В вашей команде {0} человек.", count);
                Console.WriteLine("1 - Нанять строителя");
                Console.WriteLine("2 - Нанять бригадира");
                Console.WriteLine("3 - Строить");
                Console.Write(Environment.NewLine + "Выберите пункт: ");
                if (Int32.TryParse(Console.ReadLine(), out pos))
                {
                    if (pos == 1)
                    {
                        Console.Clear();
                        team.AddWorker(new Worker(house));
                        worker = true;
                        count++;
                    }

                    else if (pos == 2)
                    {
                        Console.Clear();
                        team.AddWorker(new TeamLeader(house));
                        teamLeader = true;
                        count++;
                    }

                    else if ((pos == 3) && (worker == false))
                    {
                        Console.Clear();
                        Console.WriteLine("В вашей команде нет строителей!" + Environment.NewLine);
                        pos = 0;
                    }

                    else if ((pos == 3) && (teamLeader == false))
                    {
                        Console.Clear();
                        Console.WriteLine("В вашей команде нет бригадира!" + Environment.NewLine);
                        pos = 0;
                    }
                    else Console.Clear();
                }
                else Console.Clear();
            }

            team.Build();
            house.PresentationAtHome();
            Console.ReadKey();
        }
    }
}
