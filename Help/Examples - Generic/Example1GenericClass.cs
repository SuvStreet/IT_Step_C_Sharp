using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Простейший обобщенный класс!");
            Point<int> point1 = new Point<int>(1, 2);
            Console.WriteLine(point1);
            Console.WriteLine(typeof(Point<int>).ToString());

            Point<float> point2 = new Point<float>(1.0f, 2.5f);
            Console.WriteLine(point2);
            Console.WriteLine(typeof(Point<double>).ToString());
            Console.ReadKey();
        }
        // создание обобщенного класса (generic класса)
        // координаты точки могут быть любого типа
        public class Point<T>
        {
            T x;   // обобщенное поле
            public T X
            {
                get { return x; }
                set { x = value; }
            }
            T y;
            public T Y
            {
                get { return y; }
                set { y = value; }
            }
            public Point() // конструктор
            {
                this.x = default(T);
                this.y = default(T);
            }
            public Point(T x, T y) // конструктор
            {
                this.x = x;
                this.y = y;
            }
            public override string ToString()
            {
                return String.Format("X = {0}, Y = {1}", x.ToString(), y.ToString());
            }
        }
    }
}
