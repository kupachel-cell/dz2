using System;
using dz1lat.enums;
namespace dz1lat
{
    internal class Program
    {
        static string GetDrinkByProfession(string profession)
        {
            string normalizedInput = profession == null ? null : profession.Trim().ToLower();

            switch (normalizedInput)
            {
                case "jabroni":
                    return "Patron Tequila";
                case "school counselor":
                    return "Anything with Alcohol";
                case "programmer":
                    return "Hipster Craft Beer";
                case "bike gang member":
                    return "Moonshine";
                case "politician":
                    return "Your tax dollars";
                case "rapper":
                    return "Cristal";
                default:
                    return "Beer";
            }
        }

        static void Main(string[] args)
            {
            Console.WriteLine("Задание 1");
            int[] numbers = new int[10];
            Console.WriteLine("Введите 10 целых чисел по очереди:");
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Число {i + 1}: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            bool isSorted = true;
            int errorIndex = -1;
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] <= numbers[i - 1])
                {
                    isSorted = false;
                    errorIndex = i + 1;
                    break;
                }
            }
            if (isSorted)
            {
                Console.WriteLine("Последовательность упорядочена по возрастанию.");
            }
            else
            {
                Console.WriteLine($"Последовательность НЕ упорядочена по возрастанию.\nПорядковый номер первого неподошедшего числа: {errorIndex}");
            }
            Console.ReadKey();

            Console.WriteLine("Задание 2\nВведите порядковый номер карты k (6 <= k <= 14): ");
            try
            {
                int k = Convert.ToInt32(Console.ReadLine());

                if (k < 6 || k > 14)
                {
                    throw new ArgumentOutOfRangeException();
                }
                string cardName;
                switch (k)
                {
                    case 6: cardName = "Шестерка"; break;
                    case 7: cardName = "Семерка"; break;
                    case 8: cardName = "Восьмерка"; break;
                    case 9: cardName = "Девятка"; break;
                    case 10: cardName = "Десятка"; break;
                    case 11: cardName = "Валет"; break;
                    case 12: cardName = "Дама"; break;
                    case 13: cardName = "Король"; break;
                    case 14: cardName = "Туз"; break;
                    default: cardName = "Такой карты нет"; break;
                }

                Console.WriteLine($"Достоинство карты: {cardName}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: Введено не число.");
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Ошибка: Число вне диапазона от 6 до 14.");
            }
            catch (Exception)
            {
                Console.WriteLine("Произошла непредвиденная ошибка.");
            }
            finally
            {
                Console.WriteLine("Карта была определена.");
            }

            Console.WriteLine("Задание 3\nВведите тип личности:");
            string input = Console.ReadLine();

            string output = GetDrinkByProfession(input);

            Console.WriteLine($"Подать ему: {output}");
            Console.ReadKey();

            Console.WriteLine("Задание 4\nВведите порядковые номер дня недели");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number < 1 || number > 7)
            {
                Console.WriteLine("Ошибка: Номер должен быть от 1 до 7.");
            }
            else
            {
                DaysOfWeek day = (DaysOfWeek)number;

                switch (day)
                {
                    case DaysOfWeek.Понедельник:
                        Console.WriteLine("Это Понедельник");
                        break;
                    case DaysOfWeek.Вторник:
                        Console.WriteLine("Это Вторник");
                        break;
                    case DaysOfWeek.Среда:
                        Console.WriteLine("Это Среда");
                        break;
                    case DaysOfWeek.Четверг:
                        Console.WriteLine("Это Четверг");
                        break;
                    case DaysOfWeek.Пятница:
                        Console.WriteLine("Это Пятница");
                        break;
                    case DaysOfWeek.Суббота:
                        Console.WriteLine("Это Суббота");
                        break;
                    case DaysOfWeek.Воскресенье:
                        Console.WriteLine("Это Воскресенье");
                        break;
                }
            }
            Console.ReadKey();

            Console.WriteLine("Задание 5\nВведите количество элементов: ");
            int n = Convert.ToInt32(Console.ReadLine());
            string[] dolls = new string[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Введите название предмета номер {i + 1}: ");
                dolls[i] = Console.ReadLine();
            }
            int bag=0;
            foreach (string doll in dolls)
            {
                if (doll == "Hello Kitty" || doll == "Barbie doll")
                {
                    bag++;
                }
            }

            Console.WriteLine($"В сумке кукол: {bag}");
        }

        }

    }


        
    

        

    
    

