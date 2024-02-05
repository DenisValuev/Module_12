using System.Diagnostics;

namespace Module12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Задание №12.1.2 Линейные алгоритмы
            Console.WriteLine("Как Вас зовут?");
            string name = Console.ReadLine();
            var greetings = "Привет, " + name;
            Console.WriteLine(greetings);

            // Задание №12.1.3 Циклические алгоритмы
            Console.WriteLine("Сколько элементов будет в массиве?");
            int count = int.Parse(Console.ReadLine());
            int[] array = new int[count];
            for (int i = 0; i < count; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Все элементы записаны");

            // Задание №12.1.4 Алгоритмы с ветвлением
            Console.WriteLine("Введите свой возраст");
            var age = int.Parse(Console.ReadLine());
            if (age > 13)
            {
                Console.WriteLine("Вы успешно зарегистрированы");
            }
            else
            {
                Console.WriteLine("Пользователи младше 14 лет не могут быть зарегистрированы");
            }
        }
    }
}