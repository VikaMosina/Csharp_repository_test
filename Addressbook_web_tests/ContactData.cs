using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Addressbook_web_tests
{
    internal class ContactData
    {
        private string firstname;
        private string lastname;
        private string middlename = "";
        private string nickname = "";
        private string title = "";
        private string company = "";
        private string address = "";
        private string home = "";
        private string mobile = "";
        private string work = "";
        private string fax = "";
        private string email = "";
        private string email2 = "";
        private string email3 = "";
        private string homepage = "";


        public ContactData(string firstname, string lastname)

        { 
            this.firstname = firstname;
            this.lastname = lastname;
        
        }

        public string Firstname
        {
            get // получение 
            {
                return firstname;
            }
            set // запись
            {
                firstname = value;
            }
        }

        public string Lastname
        {
            get // получение 
            {
                return lastname;
            }
            set // запись
            {
                lastname = value;
            }
        }

        public string Middlename
        {
            get // получение 
            {
                return middlename;
            }
            set // запись
            {
                middlename = value;
            }
        }

        public string Nickname
        {
            get // получение 
            {
                return nickname;
            }
            set // запись
            {
                nickname = value;
            }
        }

        public string Title
        {
            get // получение 
            {
                return title;
            }
            set // запись
            {
                title = value;
            }
        }

        public string Company
        {
            get // получение 
            {
                return company;
            }
            set // запись
            {
                company = value;
            }
        }

        public string Address
        {
            get // получение 
            {
                return address;
            }
            set // запись
            {
                address = value;
            }
        }

        public string Home
        {
            get // получение 
            {
                return home;
            }
            set // запись
            {
                home = value;
            }
        }

        public string Mobile
        {
            get // получение 
            {
                return mobile;
            }
            set // запись
            {
                mobile = value;
            }
        }

        public string Work
        {
            get // получение 
            {
                return work;
            }
            set // запись
            {
                work = value;
            }
        }

        public string Fax
        {
            get // получение 
            {
                return fax;
            }
            set // запись
            {
                fax = value;
            }
        }

        public string Email
        {
            get // получение 
            {
                return email;
            }
            set // запись
            {
                email = value;
            }
        }

        public string Email2
        {
            get // получение 
            {
                return email2;
            }
            set // запись
            {
                email2 = value;
            }
        }

        public string Email3
        {
            get // получение 
            {
                return email3;
            }
            set // запись
            {
                email3 = value;
            }
        }

        public string Homepage
        {
            get // получение 
            {
                return homepage;
            }
            set // запись
            {
                homepage = value;
            }
        }

    }
}

