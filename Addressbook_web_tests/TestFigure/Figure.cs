using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Addressbook_web_tests
{
    internal class Figure
    {
        private bool colored = false; // переменая окрашивания с присвоением значения

        // Свойство "Окрашивание"
        public bool Colored
        {
            get // получение 
            {
                return colored;
            }
            set // запись
            {
                colored = value;
            }
        }

    }
}
