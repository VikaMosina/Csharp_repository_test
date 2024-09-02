using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Addressbook_web_tests
{
    class Circle : Figure
    {
        private int radius; // переменная радиуса

        public Circle(int radius) {

            this.radius = radius;

        }
        // Свойство "Радиус"
        public int Radius {

            get // получение
            {
                return radius;
            }

            set // запись
            {
                radius = value;
            }

        }
    }
}
