using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HouseConstructionLib
{
    // Бригада строителей
    public class Team
    {
        private int idWorker;
        House house;

        // создание массива интерфейсных ссылок
        IWorker[] workers = new IWorker[2];

        // создание объекта
        public Team(House house)
        {
            this.house = house;
        }

        // добавление строителей, чем больше, тем быстрее завершится постройка дома
        public void AddWorker(IWorker worker)
        {
            if (workers[workers.Length - 1] != null)
            {
                Array.Resize(ref workers, workers.Length + 1);
            }
            workers[idWorker] = worker;
            ++idWorker;
        }

        // стройка частей дома
        public void Build()
        {
            Console.Clear();
            while (!house.Building())
            {
                foreach (IWorker worker in workers)
                {
                    worker.Work();
                    Thread.Sleep(200); // приостанавливаем поток на 200 миллисекунд
                }
            }
        }
    }
}
