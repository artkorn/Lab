using System;
using System.Diagnostics.CodeAnalysis;

namespace _OOP
{
    class Program
    {
        public static void Main()
        {
            try
            {
                Console.OutputEncoding = System.Text.Encoding.Unicode;
                Console.Clear();
                Console.WriteLine("14. Морас Артур IK-11. ООП.\n---------------------------------------------------\n1.Visual Studio. Створення і компіляція консольного проекта.\n2.Умовні оператори, цикли та масиви у С#.\n3.Рядки та робота з файлами у С#. \n4.Створення класів в C#. Поліморфізм.");
                string text = System.Console.ReadLine();
                int a = Convert.ToInt32(text);

                switch (a)
                {
                    case 1:
                        _OOP.Lab1.Lab1_menu();
                        break;
                    case 2:
                        _OOP.Lab2.Lab2_menu();
                        break;
                    case 3:
                        _OOP.Lab3.Lab3_menu();
                        break;
                    case 4:
                        _OOP.Lab4.Lab4_menu();
                        break;
                    
                }
            }
            catch
            {
                Console.Clear();
                Console.WriteLine("Перевірте введені данні!\n\nНатисніть будь яку клавішу, шоб повернутись у головне меню...");
                ConsoleKeyInfo cki = Console.ReadKey();
                Main();
            }
        }
        public static void Menu()
        {
            Console.WriteLine("Повернутись у головне меню?[Y or N]:");

            ConsoleKeyInfo cki = Console.ReadKey();

            if (cki.Key.ToString() == "Y")
            {
                Console.Clear();
                Main();
            }
            else
            {
                Console.Clear();
                Environment.Exit(0);
            }
        }
    }
}
