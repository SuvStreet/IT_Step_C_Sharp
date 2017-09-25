using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseConstructionLib
{
    public abstract class Part : IPart
    {
        // Условные еденицы для постройки части дома
        protected int processOfConstruction;
        // Потребность в условных единицах для постройки части дома
        protected int fullPart;

        public Part(int fullPart)
        {
            this.fullPart = fullPart;
            processOfConstruction = 0;
        }

        public bool GetConstruction()
        {
            if (processOfConstruction >= fullPart)
            {
                return true;
            }
            return false;
        }

        public void IncreaseProcessOfConstructionByOne()
        {
            processOfConstruction++;
        }

        public int GetCountFull()
        {
            return fullPart;
        }

        public int GetCountConstruction()
        {
            return processOfConstruction;
        }
    }
}
