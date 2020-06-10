using System;
using System.Collections.Generic;
using System.Text;

namespace _OOP
{
    public class Lab2
    {
        public static void Lab2_menu()
        {
            Console.Clear();
            Console.WriteLine("Умовні оператори, цикли та масиви у С#.\n---------------------------------------------------\n1.Switch...case.\n2.Значення функції\n3.Робота з масивами.\n4.Матриці.\n5.Головне меню.");
            string text = System.Console.ReadLine();
            int a = Convert.ToInt32(text);
            switch (a)
            {
                case 1:
                    Lab2_1();
                    break;
                case 2:
                    Lab2_2();
                    break;
                case 3:
                    Lab2_3();
                    break;
                case 4:
                    Lab2_4();
                    break;
                case 5:
                    _OOP.Program.Main();
                    break;
                default:
                    Lab2_menu();
                    break;
            }
        }
        public static void Lab2_1()
        {
            Console.Clear();
            Console.WriteLine("В будинку 9 поверхів. Введіть номер квартири щоб дізнатись на якому поверсі вона знаходиться ");

            string text = System.Console.ReadLine();
            int a = Convert.ToInt32(text);

            switch (a)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("1 Поверх");
                    break;
                case 6:
                case 7:
                case 8:
                case 9:
                case 10:
                    Console.WriteLine("2 Поверх");
                    break;
                case 11:
                case 12:
                case 13:
                case 14:
                case 15:
                    Console.WriteLine("3 Поверх");
                    break;
                case 16:
                case 17:
                case 18:
                case 19:
                case 20:
                    Console.WriteLine("4 Поверх");
                    break;
                case 21:
                case 22:
                case 23:
                case 24:
                case 25:
                    Console.WriteLine("5 Поверх");
                    break;
                case 26:
                case 27:
                case 28:
                case 29:
                case 30:
                    Console.WriteLine("6 Поверх");
                    break;
                case 31:
                case 32:
                case 33:
                case 34:
                case 35:
                    Console.WriteLine("7 Поверх");
                    break;
                case 36:
                case 37:
                case 38:
                case 39:
                case 40:
                    Console.WriteLine("8 Поверх");
                    break;
                case 41:
                case 42:
                case 43:
                case 44:
                case 45:
                    Console.WriteLine("9 Поверх");
                    break;
            }
            Console.WriteLine("\n\nНатисніть будь яку клавішу, щоб продовжити...");
            ConsoleKeyInfo _exit = Console.ReadKey();
            if (1 == 1)
            {
                Lab2_menu();
            }
        }
        public static void Lab2_2()
        {

            Console.Clear();
            Console.WriteLine("y=x^3, a=-6, b=3, dx=0.75");
                double a = -6;
                double b = 3;
                while (a != b)
                {
                    double c = Math.Pow(a, 3);
                    Console.WriteLine("x = " + a + "; F(x) = " + c);
                    a += 0.75;
                }
            Console.WriteLine("\n\nНатисніть будь яку клавішу, щоб продовжити...");
            ConsoleKeyInfo _exit = Console.ReadKey();
                if (1 == 1)
                {
                    Lab2_menu();
                }
        }
        private static void Lab2_3()
        {
                Console.Clear();
                Console.WriteLine("Введiть кiлькiсть елементiв");
                int Count = 0;
                Count = Convert.ToInt16(Console.ReadLine());
                int[] array = new int[Count];
                Console.WriteLine("1) - Ввести значення самому\n2) Згенерувати випадково [-100,100]");
                int Res = 0;
                Res = Convert.ToInt16(Console.ReadLine());
                if (Res == 1)
                {
                    for (int i = 0; i < Count; i++)
                    {
                        Console.Write($"Array[{i}] = ");
                        array[i] = Convert.ToInt16(Console.ReadLine());
                    }
                }
                else if (Res != 0)
                {
                    var Rand = new Random();
                    for (int i = 0; i < Count; i++)
                    {
                        array[i] = Rand.Next(-100, 100);
                    }
                }

                int ar = 1;
                int ind = 0;
                int max = 0;
                ar = MaxModule(array);
                for (int i = 0; i < array.Length; i++)
                {
                    if (Math.Abs(array[i]) > Math.Abs(max))

                    {
                        max = array[i];
                        ind = i;
                    }
                }
                max = 0;
                for (int i = 0; i < ind; i++)
                {
                    max += array[i];
                }
                Console.WriteLine("\nx = " + ar + " i = " + max);
                Console.WriteLine("\n\nНатисніть будь яку клавішу, щоб продовжити...");
                ConsoleKeyInfo _exit = Console.ReadKey();
                if (1 == 1)
                {
                    Lab2_menu();
                }
        }
        public static int MaxModule(int[] array)
        {
            int ar = 1;
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 == 0)
                {
                    ar *= array[i];
                }
            }
            return ar;
        }

        private static void Lab2_4()
        {
            Console.Clear();

            Console.WriteLine("Згенерувати матрицю?[Y or N]:");
            ConsoleKeyInfo cki = Console.ReadKey();
            Console.WriteLine("");

            int r = 0, R = 0, c = 0, C = 0;
            Console.WriteLine("Введіть число рядів та стовпців матриці.");
            Console.Write("Число рядів M1 = "); //Введите R
            R = Convert.ToInt32(Console.ReadLine());
            Console.Write("Число стовпців N = "); //Введите C
            C = Convert.ToInt32(Console.ReadLine());
            Random rnd = new Random();

            int[,] M = new int[R, C];
            int sum = 0;
            int sumPob = 0;
            int i = R;
            for (r = 0; r < R; r++)
            {
                if (cki.Key.ToString() == "Y")
                {
                    for (c = 0; c < C; c++)
                    {
                        int Mm = rnd.Next(0, 100); //Генерация случайного числа
                        M[r, c] = Mm;
                    }
                }
                else
                {
                    for (c = 0; c < C; c++)
                    {
                        Console.Write($"Array[{r},{c}] = ");
                        M[r, c] = Convert.ToInt16(Console.ReadLine());

                    }
                }
                
                

                if (r < R && r < C)
                    sum += M[r, r];
                    i--;
                if (r < R && i < C)
                    sumPob += M[r, i];
            }

            //вывод матрицы
            Console.WriteLine("---------------------------------------------------\nСтворена матриця M*N");
            Console.WriteLine();
            for (r = 0; r < R; ++r)
            {
                for (c = 0; c < C; ++c)
                {
                    Console.Write(M[r, c].ToString("D2") + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("Сума діагоналі матрицы = " + sum);
            Console.WriteLine("Сума побічной діагонали матриці = " + sumPob);

            Console.WriteLine("\n\nНатисніть будь яку клавішу, щоб продовжити...");
            ConsoleKeyInfo _exit = Console.ReadKey();
            if (1 == 1)
            {
                Lab2_menu();
            }

        }

    }
}