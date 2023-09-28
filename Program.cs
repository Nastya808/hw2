using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace hw2
{

    /*
    class Program
    {
        static void Main()
        {
            Console.Write("Введіть шестизначне число: ");
            string input = Console.ReadLine();

            if (input.Length != 6 || !IsNumeric(input))
            {
                Console.WriteLine("Помилка: Введіть шестизначне числе.");
                return;
            }

            Console.Write("Введіть номери розрядів для заміни (наприклад, 1 6): ");
            string replaceIndices = Console.ReadLine();
            string[] indices = replaceIndices.Split(' ');

            if (indices.Length != 2 || !int.TryParse(indices[0], out int index1) || !int.TryParse(indices[1], out int index2))
            {
                Console.WriteLine("Помилка: Введіть два коректних номери розрядів.");
                return;
            }

            if (index1 < 1 || index1 > 6 || index2 < 1 || index2 > 6)
            {
                Console.WriteLine("Помилка");
                return;
            }

            char[] digits = input.ToCharArray();

            char temp = digits[index1 - 1];
            digits[index1 - 1] = digits[index2 - 1];
            digits[index2 - 1] = temp;

            string result = new string(digits);

            Console.WriteLine($"Результат: {result}");
        }

        static bool IsNumeric(string input)
        {
            foreach (char c in input)
            {
                if (!char.IsDigit(c))
                    return false;
            }
            return true;
        }
    }
    */
    class Program
    {
        static void Main()
        {
            Console.Write("Введіть дату у форматі dd.MM.yyyy: ");
            string dateString = Console.ReadLine();

            if (!DateTime.TryParseExact(dateString, "dd.MM.yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime date))
            {
                Console.WriteLine("Помилка: Некоректний формат дати.");
                return;
            }

            string season = GetSeason(date.Month);
            string dayOfWeek = date.DayOfWeek.ToString();

            Console.WriteLine($"Пора року: {season}");
            Console.WriteLine($"День тижня: {dayOfWeek}");
        }

        static string GetSeason(int month)
        {
            switch (month)
            {
                case 12:
                case 1:
                case 2:
                    return "Winter";
                case 3:
                case 4:
                case 5:
                    return "Spring";
                case 6:
                case 7:
                case 8:
                    return "Summer";
                case 9:
                case 10:
                case 11:
                    return "Autumn";
                default:
                    return "Unknown";
            }
        }

    }
}
