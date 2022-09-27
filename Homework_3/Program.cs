using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//#define TASK1
namespace Homework_3
{
    internal class Program
    {
        public static void Main(string[] args)
        {

#if TASK1
            int width = 4;
            char symbol = '*';
            Square(width, symbol);    

        }
        public static void Square(int width, char symbol)
        {
            char[,] A = new char[width, width];
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }
        }
#endif
            Web web = new Web("", "", "", "");
            web.NewWeb(web);
        }

        class Web
        {
            string _name;
            string _address;
            string _description;
            string _IP;

            public string Name
            {
                get => _name; set => _name = value;
            }
            public string Address
            {
                get => _address; set => _address = value;
            }
            public string Description
            {
                get => _description; set => _description = value;
            }
            public string IP
            {
                get => _IP; set => _IP = value;
            }

            public Web(string name, string address, string description, string IP)
            {
                _name = name;
                _address = address;
                _description = description;
                _IP = IP;
            }

            public Web NewWeb(Web web)
            {
                Console.Write("Введите название сайта:"); string name = Console.ReadLine();
                Console.Write("Введите путь к сайту:"); string addres = Console.ReadLine();
                Console.Write("Введите описание сайта:"); string description = Console.ReadLine();
                Console.Write("Введите IP адрес сайта:"); string IP = Console.ReadLine();
                //Console.Write("Введите эл.почту магазина:"); string email = Console.ReadLine();
                //Console.Write("Введите площадь магазина:"); int area = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Название магазина: " + name+ "\nпуть к сайту: " + addres + "\nописание сайта:" + description + "\nIP адрес сайта: " + IP);
                return web;
            }
            //public override string ToString()
            //{
            //    return " Магазин: " + Name + ";\n Адресс: " + Address + ";\n Профиль магазина: " + ProfShop + ";\n Номер телефона: " + PhoneNumb + ";\n Адресс эл.почты: " + EmailShop + ";\n Площадь: " + Shoparea.ToString() + " квадратных метров";
            //}
            //public void GetShopInfo()
            //{
            //    Console.WriteLine(ToString());
            //}
        }
    }
}

//дание 4
//Создайте класс «Веб-сайт». Необходимо хранить в
//полях класса: название сайта, путь к сайту, описание
//сайта, ip адрес сайта.Реализуйте методы класса для ввода
//данных, вывода данных, реализуйте доступ к отдельным
//полям через методы класса. 