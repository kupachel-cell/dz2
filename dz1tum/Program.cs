using System;

namespace dz1tum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Упражнение 4.1+Упражнение 4.2+ Дз 4.1\nВведите текущий год");
            try
            {
                Console.Write("Введите год: ");
                int year = int.Parse(Console.ReadLine());
                Console.Write("Введите номер дня в году: ");
                int day = int.Parse(Console.ReadLine());
                bool isLeapYear = (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
                int maxDays = isLeapYear ? 366 : 365;
                if (day < 1 || day > maxDays)
                {
                    throw new ArgumentOutOfRangeException(nameof(day), $"Число должно быть в диапазоне от 1 до {maxDays} для {year} года.");
                }
                int[] daysInMonths = { 31, isLeapYear ? 29 : 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
                string[] monthNames = { "января", "февраля", "марта", "апреля", "мая", "июня", "июля", "августа", "сентября", "октября", "ноября", "декабря" };
                int currentDay = day;
                int monthIndex = 0;
                while (currentDay > daysInMonths[monthIndex])
                {
                    currentDay -= daysInMonths[monthIndex];
                    monthIndex++;
                }
                Console.WriteLine($"Число {day} соответствует: {currentDay} {monthNames[monthIndex]}.");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"Ошибка валидации: {ex.Message}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: Число введено некорректно.");
            }
        }
    }
}
