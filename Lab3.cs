using System;
using System.IO;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Text;
using System.Linq;

namespace _OOP
{
    public class Lab3
    {
        public static void Lab3_menu()
        {
            Console.Clear();
            Console.WriteLine("Рядки та робота з файлами у С#. \n---------------------------------------------------\n1.Текст.\n2.Робота з зовнішними текстовими файлами.\n3.Вивід у зовнішний текстовий файл.\n4.Головне меню");
            string text = System.Console.ReadLine();
            int a = Convert.ToInt32(text);
            switch (a)
            {
                case 1:
                    Lab3_1();
                    break;
                case 2:
                    Lab3_2();
                    break;
                case 3:
                    Lab3_3();
                    break;
                case 4:
                    _OOP.Program.Main();
                    break;
                default:
                    Lab3_menu();
                    break;
            }
        }
        private static void Lab3_1()
        {
            Console.Clear();
            Console.WriteLine("З клавіатури вводиться текстовий рядок. Розробити консольний застосунок, який\n1.Знищує всі слова, які починаються і закінчуються за одну й ту ж літеру;\n2.Підраховує кількість різних слів, що входять до заданого тексту.");
            Console.WriteLine("---------------------------------------------------");
            Console.Write("Введіть декілька слів через пробіл: ");
            string text = Console.ReadLine();
            string[] strs = text.Split();
            Console.Write("Виберіть завдання: ");
            string choose = System.Console.ReadLine();
            int a = Convert.ToInt32(choose);
            switch (a)
            {
                case 1:
                    foreach (var word in strs)
                    {
                        if (string.Equals(word[0], word[word.Length - 1]) && word.Length > 1)
                        {
                            strs[Array.IndexOf(strs, word)] = "";
                        }
                    }
                    Console.WriteLine("Результат:");
                    foreach (var word in strs)
                    {
                        Console.Write(word + " ");
                    }
                    break;
                case 2:
                    int[] count = new int[strs.Length];

                    for (int i = 0; i < count.Length; ++i)
                    {
                        count[i] = 1;
                    }

                    for (int i = 0; i < strs.Length; ++i)
                    {
                        for (int j = i + 1; j < strs.Length; ++j)
                        {
                            if (strs[i] == strs[j])
                            {
                                ++count[i];
                            }
                        }
                    }

                    Console.WriteLine();
                    Console.WriteLine("Результат:");
                    for (int i = 0; i < count.Length; ++i)
                    {
                        if (count[i] > 0)
                        {
                            Console.WriteLine("{0} - {1}", strs[i], count[i]);
                        }
                    }
                    break;
            }



            Console.WriteLine("\n\nНатисніть будь яку клавішу, щоб продовжити...");
            ConsoleKeyInfo _exit = Console.ReadKey();
            if (1 == 1)
            {
                Lab3_menu();
            }

        }
        private static void Lab3_2()
        {
            Console.Clear();
            string first, seccond, third;
            int _1res, _2res, _3res;
            Console.WriteLine("Записати у файл sport.txt, що знаходитиметься на диску D прізвища та результати 3 переможців олімпіади з інформатики.\nВивести вміст файлу на екран для візуального контролю. Внести в кінець файлу прізвище та ім'я голови журі");
            Console.WriteLine("---------------------------------------------------\nНатисніть будь яку клавішу, щоб продовжити...");
            Console.ReadKey();

            Console.Clear();
            Console.WriteLine("Перший призер.");
            Console.WriteLine("---------------------------------------------------");
            Console.Write("1.Введіть прізвище фіналіста: ");
            first = Console.ReadLine();
            Console.WriteLine("2.Введіть результат");
            _1res = int.Parse(Console.ReadLine());

            Console.Clear();
            Console.WriteLine("Другий призер.");
            Console.WriteLine("---------------------------------------------------");
            Console.Write("1.Введіть прізвище фіналіста: ");
            seccond = Console.ReadLine();
            Console.WriteLine("2.Введіть результат");
            _2res = int.Parse(Console.ReadLine());

            Console.Clear();
            Console.WriteLine("Третій призер.");
            Console.WriteLine("---------------------------------------------------");
            Console.Write("1.Введіть прізвище фіналіста: ");
            third = Console.ReadLine();
            Console.WriteLine("2.Введіть результат");
            _3res = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Голова журі.");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("Введіть прізвище та ім'я");
            string juri = Console.ReadLine();
            Console.Clear();
            string path = @"F:\University\ALGlab\sports.txt";

            FileInfo myfile = new FileInfo(path);

            StreamWriter Writer;

            if (myfile.Exists)
            {
                myfile.Delete();
            }

            Writer = myfile.CreateText();
            Writer.Write($"Результати фіналістів \nТретє місце \n{third}\t{_3res}\nДруге місце \n{seccond}\t{_2res}\nПерше місце \n{first}\t{_1res}");
            Writer.Write("\n \n Голова журі — " + juri);
            Writer.Close();
            using (StreamReader Reader = new StreamReader(path))
            {
                Console.WriteLine(Reader.ReadToEnd());
                Reader.Close();
            }



            Console.WriteLine("\n\nНатисніть будь яку клавішу, щоб продовжити...");
            ConsoleKeyInfo _exit = Console.ReadKey();
            if (1 == 1)
            {
                Lab3_menu();
            }
        }
        private static void Lab3_3()
        {
            Console.Clear();
            string path = @"F:\University\ALGlab\input.txt";
            string output = @"F:\University\ALGlab\output.txt";
            FileInfo myfile = new FileInfo(path);

            using (StreamReader Reader = new StreamReader(path))
            {
                string str = Reader.ReadToEnd();

                string[] words = str.Split(new char[] { '\n', '\r', ' ', ':', ';', '.', ',', '?', '!', '(', ')', '{', '}', '[', ']', '@', '#', '№', '$', '^', '%', '&', '*', '/', '|' }, StringSplitOptions.RemoveEmptyEntries);

                int[] count = new int[words.Length];

                for (int i = 0; i < count.Length; ++i)
                {
                    count[i] = 1;
                }

                for (int i = 0; i < words.Length; ++i)
                {
                    for (int j = i + 1; j < words.Length; ++j)
                    {
                        if (words[i] == words[j])
                        {
                            ++count[i];

                            count[j] = -999999999;
                        }
                    }
                }
                using (StreamWriter Writer = new StreamWriter(output))
                {
                    for (int i = 0; i < count.Length; ++i)
                    {
                        if (count[i] > 0)
                        {
                            Writer.Write("{0} - {1}", words[i], count[i]);
                        }
                    }
                    Writer.Write("\nКiлькiсть використаних символiв: {0}", str.Length);
                    Writer.Close();
                }
                Console.WriteLine("Перевірте файл Output.txt з вихідними данними.");
                Reader.Close();



                Console.WriteLine("\n\nНатисніть будь яку клавішу, щоб продовжити...");
                ConsoleKeyInfo _exit = Console.ReadKey();
                if (1 == 1)
                {
                    Lab3_menu();
                }
            }

        }
    }
}
