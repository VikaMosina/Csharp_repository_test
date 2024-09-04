using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAddressbookTests
{
    class AccountData
    {
        private string username; // Значение имени
        private string password; // Значение пароля

        // Конструктор для изменения параметров
        public AccountData(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        // Создаем свойство для имени

        public string Username { 
        
            get
            {
                return username;
            }
            set
            {
                username = value;
            }
        }

        // Создаем свойство для пароля
        public string Password
        {
            get 
            { 
                return password;
            }
            set
            {
                password = value;
            }
        
        }

    }
}
