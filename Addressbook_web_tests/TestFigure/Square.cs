using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Addressbook_web_tests
{
    class Square : Figure
    {
        private int size; // переменая размера

        public Square(int size)

        {
            this.size = size;
        }

        // Свойство "Размер"
        public int Size { 

        get // получение
        {
            return size;
        }

        set // запись
        { 
        size = value;
       }

      }

    }

}
