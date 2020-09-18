using System;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Xml;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ввод изначальных данных
            Console.WriteLine("Как говорится, добро пожаловать на борт нашего болотного ледокола. Кем звать себя прикажешь?");
            string nick = Console.ReadLine();
            Console.WriteLine($"Приятно познакомиться, {nick}, введите сегодняшнюю дату");
            Console.WriteLine("Введите год");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите месяц");
            int b = Convert.ToInt32(Console.ReadLine());
            if (b > 0 && b <= 12) { } //Всего 12 месяцев
            else
            {
                Console.WriteLine($"Попался фраер! Нет месяца под номером {b}");
                return;
            }
            Console.WriteLine("Введите день");
            int c = Convert.ToInt32(Console.ReadLine());
            if (c > 0 && c <=31) { }
            else
            {
                Console.WriteLine($"Попался фраер! Не существует дня, как {c}");
                return;
            }
            //Шедевр идет под откос из-за високоса
            if (b == 2)
            {
                if (a % 4 == 0) //раз в 4 года (високос)
                {
                    if (c > 0 && c <= 29) { }
                    else
                    {
                        Console.WriteLine($"Сорян, братан, в этом месяце нет {c} дня");
                        return;
                    }
                }
                else
                {
                    if (c > 0 && c <= 28) { }
                    else
                    {
                        Console.WriteLine($"Сорян, братан, в этом месяце нет {c} дня");
                        return;
                    }
                }
            }
            else if (b == 4 && b == 6 && b == 9 && b == 11) //Месяцы, в которых по 30 дней
            {
                if (c > 0 && c <= 30) { }
                else
                {
                    Console.WriteLine("Сорян, братан, в этом месяце нет {c} дня");
                    return;
                }
            }
            else if (b == 1 && b == 3 && b == 5 && b == 7 && b == 8 && b == 10 && b == 12) //Месяцы, в которых по 31 дню
            {
                if (c > 0 && c <= 31) { }
                else
                {
                    Console.WriteLine($"Сорян, братан, в этом месяце нет {c} дня");
                    return;
                }
            }

            
            //Ввод данных
            Console.WriteLine("Красавела, братела");
            Console.WriteLine("Введите дату своего дня рождения");
            Console.WriteLine("Введите год рождения");
            int a2 = Convert.ToInt32(Console.ReadLine());
            if (a > a2) { }
            else
            {
                Console.WriteLine("Некорректный год рождения");
                return;
            }
            Console.WriteLine("Введите месяц дня рождения");
            int b2 = Convert.ToInt32(Console.ReadLine());
            if (b2 > 0 && b2 <= 12) { }
            else
            {
                Console.WriteLine($"Нет такого месяца как {b2}");
                return;
            }
            Console.WriteLine("Введите день своего рождения");
            int c2 = Convert.ToInt32(Console.ReadLine());
            if (c2 > 0 && c2 <= 31) { }
            else
            {
                Console.WriteLine($"Не существует такого дня, как {c2}");
                return;
            }
            // ПРОКЛЯТЫЙ ВИСОКООООС
            if (b2 == 2) 
            {
                if (a2 % 4 == 0)
                {
                    if (c2 > 0 && c2 <= 29) { }
                    else
                    {
                        Console.WriteLine($"Нет такого дня как {c2}");
                        return;
                    }
                }
                else 
                {
                    if (c2 > 0 && c2 <= 28) { }
                    else
                    {
                        Console.WriteLine($"Нет такого дня как {c2}");
                        return;
                    }
                }
            }
           



            else if (b2 == 1 && b2 == 3 && b2 == 5 && b2 == 7 && b2 == 8 && b2 == 10 && b2 == 12)
            {
                if (c2 > 0 && c2 <= 31) { }
                else
                {
                    Console.WriteLine($"Нет такого дня как {c2}");
                    return;
                }
            }

            else if (b2 == 4 && b2 == 6 && b2 == 9 && b2 == 11)
            {
                if (c2 > 0 && c2 <= 30) { }
                else
                {
                    Console.WriteLine($"Нет такого дня как {c2}");
                    return;
                }
            }
             //Вычисление возраста
            int old = a - a2; //дата - год рождения
            if (b2 > b)
            {
                old -= 1;
            }
            else if (b2 == b)
            {
                if (c2 > c)
                {
                    old -= 1;
                }    

            }
            Console.WriteLine($"Дарова, {nick}, тебе сейчас {old} годиков");
            Console.WriteLine("Удачной охоты, сталкер!");
            Console.ReadKey();
        }
    }
}