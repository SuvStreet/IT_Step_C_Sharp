using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseConstructionLib
{
    // Дом
    public class House
    {
        // создание массива интерфейсных ссылок
        IPart[] parts = new IPart[11];
        
        // размер массива
        public int CountParts
        {
            get { return parts.Length; }
        }

        // заполнение массива интерфейсными ссылками
        public House()
        {
            parts[0] = new Basement();
            parts[1] = new Walls();
            parts[2] = new Walls();
            parts[3] = new Walls();
            parts[4] = new Walls();
            parts[5] = new Door();
            parts[6] = new Window();
            parts[7] = new Window();
            parts[8] = new Window();
            parts[9] = new Window();
            parts[10] = new Roof();
        }

        // обращение к ссылочным интерфейсам с помощью индекса
        public IPart this[int index] {
            get { return parts[index]; }
        }

        // рисунок дома
        public void PresentationAtHome()
        {
            Console.Clear();
            Console.WriteLine("   &&&&                  /\\");
            Console.WriteLine("     &&&                /  \\");
            Console.WriteLine("       &&              /    \\");
            Console.WriteLine("        &&            /      \\");
            Console.WriteLine("          &          /        \\");
            Console.WriteLine("           &        /          \\");
            Console.WriteLine("            ||     /            \\");
            Console.WriteLine("            ||    /              \\");
            Console.WriteLine("            ||   /                \\");
            Console.WriteLine("            ||  /                  \\");
            Console.WriteLine("            || /                    \\");
            Console.WriteLine("            ||/                      \\");
            Console.WriteLine("            |/                        \\");
            Console.WriteLine("            /                          \\");
            Console.WriteLine("           /        ________            \\");
            Console.WriteLine("          /         |      |             \\");
            Console.WriteLine("         /          |      |              \\");
            Console.WriteLine("        /           |      |               \\");
            Console.WriteLine("       /            |     *|                \\");
            Console.WriteLine("      /             |      |                 \\");
            Console.WriteLine("     /              |      |                  \\");
            Console.WriteLine("     ###########################################");
            Console.WriteLine("     #                                         #");
            Console.WriteLine("     #                                         #");
            Console.WriteLine("     #                                         #");
            Console.WriteLine("     #        -------------         _________  #");
            Console.WriteLine("     #        |     |     |         |       |  #");
            Console.WriteLine("     #        |_____|_____|         |       |  #");
            Console.WriteLine("     #        |     |     |         |       |  #");
            Console.WriteLine("     #        |     |     |         |       |  #");
            Console.WriteLine("     #        -------------         |      *|  #");
            Console.WriteLine("     #                              |       |  #");
            Console.WriteLine("     #                              |       |  #");
            Console.WriteLine("     #                              |       |  #");
            Console.WriteLine("     ###########################################");
            Console.WriteLine("     ###########################################");
            Console.WriteLine("                                                ");
            Console.WriteLine("Мы строили, строили, и наконец построили!!!! ))");
        }

        // построена ли часть дома полностью
        public bool Building()
        {
            foreach (IPart part in parts)
            {
                if (!part.GetConstruction())
                {
                    return false;
                }
            }
            return true;
        }
    }
}
