using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseConstructionLib
{
    public interface IPart
    {
        // построена ли часть дома полностью
        bool GetConstruction();

       // добоволение условной единицы части дома на один
        void IncreaseProcessOfConstructionByOne();

        // полная сумма условных единиц всех частей дома
        int GetCountFull();

        // построенные части дома
        int GetCountConstruction();
    }
}
