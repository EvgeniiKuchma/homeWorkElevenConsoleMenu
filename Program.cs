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
            int menuItem = 0;

            while (menuItem != 5)
            {
            Console.WriteLine($"1.Узнать свое имя.\n" +
                $"2.Узнать свой возраст.\n3.Получить случайное число.\n" +
                $"4.Очистить консолью\n5.Выйти из программы.");
            
            Console.Write("Выберите пункт меню: ");
            menuItem = Convert.ToInt32(Console.ReadLine());

                switch (menuItem)
                {
                    case 1:
                        string name;
                        Console.Write("1.Введите ваше имя: ");
                        name = Console.ReadLine();
                        Console.WriteLine("Вас зовут " + name + ".");
                        break;
                    case 2:
                        int age;
                        Console.Write("Введите ваш возрвст: ");
                        age = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Вам " + age + " лет.");
                        break;
                    case 3:
                        int rangeMin, rangeMax;
                        Console.Write("Введите желаемый дипозон показываемого числа: ");
                        rangeMin = Convert.ToInt32(Console.ReadLine());
                        rangeMax = Convert.ToInt32(Console.ReadLine());
                        Random random = new Random();
                        int number = random.Next(rangeMin, rangeMax);
                        Console.WriteLine("Ваше число: " + number + ".");
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("Консоль очищена!");
                        break;
                    case 5:
                        Console.WriteLine("В с е г о хо ро ше го ");
                        break;
                    default:
                        Console.WriteLine("Неверный выбор попробуй еще раз!");
                        break ;

                }
            }
        }
    }
}
