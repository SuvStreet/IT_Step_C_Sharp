using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    class CarException: Exception
    {
        public CarException()
        { } // создаться исключение но ничего не выведет

        public CarException(string message):
            base(message) // создаётся исключение
        { }

        public CarException(string message, Exception ex):
            base(message) // создаётся исключение 
                          // и создаётся вложеное исключение
        { }

    }
}
