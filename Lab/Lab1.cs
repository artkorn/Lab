using System;
using System.Collections.Generic;
using System.Text;

namespace _OOP
{
    public class Lab1
    {
        public static void Lab1_menu()
        {
            Console.Clear();
            Console.WriteLine("Інтегроване середовище розробки Visual Studio.\nСтворення і компіляція консольного проекта за допогою .net cli.\n---------------------------------------------------\n1.Середнє арифметичне та геометричне.\n2.Головне меню");
            string text = System.Console.ReadLine();
            int a = Convert.ToInt32(text);
            switch (a)
            {
                case 1:
                    Lab1_1();
                    break;
                case 2:
                    _OOP.Program.Main();
                    break;
                default:
                    Lab1_menu();
                    break;
            }
        }
            public static void Lab1_1()
            {
                Console.Clear();
                Console.WriteLine("Написати програму, що розв’язує задачу, згідно номера свого варіанта.\nДля написання тесту використати дані контрольного прикладу до свого варіанта:\nДано два числа a та b. Знайти їх середнє арифметичне та середнє геометричне.\nВхідні дані: a = 3, b = 27.\nВихідні дані: sa = 15, sg = 9.");
                Console.Write("---------------------------------------------------\nВведіть перше число: ");
                String one = System.Console.ReadLine();

                Console.Write("Введіть друге число: ");
                String two = System.Console.ReadLine();

                int a = Convert.ToInt32(one);
                int b = Convert.ToInt32(two);

                double sa = (a + b) / 2;
                double sg = Math.Sqrt(a * b);

                Console.Write("---------------------------------------------------\nСереднє Арифметичне: {0}\nСереднє геометричне: {1}", sa, sg);
                Console.WriteLine("\n\nНатисніть будь яку клавішу, щоб продовжити...");
                ConsoleKeyInfo _exit = Console.ReadKey();
                if (1 == 1)
                {
                    Lab1_menu();
                }

            }
    }
}