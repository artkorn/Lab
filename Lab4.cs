using System;
using System.Collections.Generic;
using System.Text;

namespace _OOP
{
    public class Lab4
    {
        public static void Lab4_menu()
        {
            Console.Clear();
            Console.WriteLine("Створення класів в C#. Поліморфізм.");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("1.Класс Student.\n2.Метеорологічні данні.\n3.База данних.\n4.Головне Меню.");
            string text = System.Console.ReadLine();
            int a = Convert.ToInt32(text);
            switch (a)
            {

                case 1:
                    Lab4_1();
                    break;
            /*
                    case 2:
                        Lab4_2();
                        break;
                    case 3:
                        Lab4_3();
                        break;
            */
                case 4:
                    _OOP.Program.Main();
                    break;
                default:
                    Lab4_menu();
                    break;
            }
        }
            private static void Lab4_1()
            {
                Console.Clear();
                Student s = new Student();
                Console.Write("Введіть рейтинг: ");
                s.Rating = Convert.ToInt16(Console.ReadLine());
                s.StudentRating(s.Rating);
                Console.WriteLine("\n\nНатисніть будь яку клавішу, щоб продовжити...");
                ConsoleKeyInfo _exit = Console.ReadKey();
                if (1 == 1)
                {
                    Lab4_menu();
                }
            }
            private static void Lab4_2()
            {
            MeteData Day5 = new MeteData("23.05.2020", 16, 737);
            MeteData Day4 = new MeteData("19.05.2020", 19, 730);
            MeteData Day3 = new MeteData("16.05.2020", 16, 748);
            MeteData Day1 = new MeteData("21.05.2020", 17, 747);
            MeteData Day2 = new MeteData("14.05.2020", 14, 740);
            MeteData Day6 = new MeteData("30.05.2020", 10, 737);
            MeteData Day7 = new MeteData("11.05.2020", 11, 730);
            MeteData Day8 = new MeteData("05.05.2020", 34, 707);
            MeteData Day9 = new MeteData("10.05.2020", 15, 732);
            MeteData Day10 = new MeteData("01.05.2020", 20, 750);
            List<MeteData> Days = new List<MeteData>();
            Days.Add(Day1); Days.Add(Day2); Days.Add(Day3); Days.Add(Day4); Days.Add(Day5);
            Days.Add(Day6); Days.Add(Day7); Days.Add(Day8); Days.Add(Day9); Days.Add(Day10);
            MeteData Most = Day1;
            MeteData Less = Day1;
            for (int i = 0; i < Days.Count; i++)
            {


                for (int k = 0; k < Days.Count; k++)
                {
                    if (Most.AtmospherePressure < Days[k].AtmospherePressure)
                    {
                        Most = Days[i];
                    }
                    if (Less.AtmospherePressure > Days[k].AtmospherePressure)
                    {
                        Less = Days[i];
                    }
                    if (Days[i].AtmospherePressure > Days[k].AtmospherePressure)
                    {
                        MeteData temp = Days[k];
                        Days[k] = Days[i];
                        Days[i] = temp;
                    }
                }
            }
            Console.WriteLine("Date      |Temperature | Atmosphere Pressure");
            for (int i = 0; i < Days.Count; i++)
            {
                Console.WriteLine(Days[i].Data + "|" + Days[i].Tempreture + "          |" + Days[i].AtmospherePressure);
            }
            Console.WriteLine("\nThe greatest Atmosphere Pressure");
            Console.WriteLine(Most.Data + "|" + Most.AtmospherePressure);
            Console.WriteLine("The least Atmosphere Pressure");
            Console.WriteLine(Less.Data + "|" + Less.AtmospherePressure);



            Console.WriteLine("\n\nНатисніть будь яку клавішу, щоб продовжити...");
            ConsoleKeyInfo _exit = Console.ReadKey();
            if (1 == 1)
            {
                Lab4_menu();
            }
        }
        
    }
    public class Student
    {
        public string LastName { get; set; }
        public string Group { get; set; }
        public string Year { get; set; }
        public string Adrees { get; set; }
        public string Passport { get; set; }
        public string Age { get; set; }
        public string Phone { get; set; }
        public int Rating { get; set; }
        public string StudentRating(int R)
        {
            if (R >= 90)
            {
                Console.WriteLine("Вітаємо відмінника");
                return "Вітаємо відмінника";
            }
            string s = (R >= 75) ? ("Можна вчитися краще") : ("Варто більше уваги приділяти навчанню");
            Console.WriteLine(s);
            return s;
        }
    }
    public class MeteData
    {
        public string Data { get; set; }
        public float Tempreture { get; set; }
        public int AtmospherePressure { get; set; }
        public MeteData(string Data, float Temp, int Atmosphere)
        {
            this.Data = Data;
            Tempreture = Temp;
            AtmospherePressure = Atmosphere;
        }
        public MeteData()
        {
            this.Data = "";
            Tempreture = 0;
            AtmospherePressure = 0;
        }

    }
}
