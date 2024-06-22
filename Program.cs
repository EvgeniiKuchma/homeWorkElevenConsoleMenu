using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWorkElevenConsoleMenu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string menuItem;
            bool canExit = true;
            Random random = new Random();

            const string CommandShowName = "1";
            const string CommandShowAge = "2";
            const string CommandShowNumber = "3";
            const string CommandClearCosole = "4";
            const string CommandExit = "5";

            while (canExit)
            {
            Console.WriteLine($"{CommandShowName}.Узнать свое имя.\n" +
                $"{CommandShowAge}.Узнать свой возраст.\n{CommandShowNumber}.Получить случайное число.\n" +
                $"{CommandClearCosole}.Очистить консолью\n{CommandExit}.Выйти из программы.\n");
            
            Console.Write("Выберите пункт меню: ");
            menuItem = Console.ReadLine();

                switch (menuItem)
                {
                    case CommandShowName:
                        string name;
                        Console.Write("Введите ваше имя: ");
                        name = Console.ReadLine();
                        Console.WriteLine("Вас зовут " + name + ".\n");
                        break;

                    case CommandShowAge:
                        int age;
                        Console.Write("Введите ваш возрвст: ");
                        age = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Вам " + age + " лет.\n");
                        break;

                    case CommandShowNumber:
                        int rangeMin, rangeMax;
                        Console.Write("Введите желаемый диапазон показываемого числа: ");
                        rangeMin = Convert.ToInt32(Console.ReadLine());
                        rangeMax = Convert.ToInt32(Console.ReadLine()); 
                        int number = random.Next(rangeMin, rangeMax);
                        Console.WriteLine("Ваше число: " + number + ".\n");
                        break;

                    case CommandClearCosole:
                        Console.Clear();
                        Console.WriteLine("Консоль очищена!\n");
                        break;

                    case CommandExit:
                        canExit = false;
                        Console.WriteLine("В с е г о хо ро ше го \n");
                        break;

                    default:
                        Console.WriteLine("Неверный выбор попробуй еще раз!\n");
                        break ;
                }
            }
        }
    }
}
