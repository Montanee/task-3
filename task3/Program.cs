using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите вашу дату рождения в формате (гггг-мм-дд):");
        DateTime birthDate;
        if (DateTime.TryParse(Console.ReadLine(), out birthDate))
        {
            DateTime currentDate = DateTime.Now;
            int years = currentDate.Year - birthDate.Year;
            int months = currentDate.Month - birthDate.Month;
            int days = currentDate.Day - birthDate.Day;

            if (days < 0)
            {
                months--;
                days += DateTime.DaysInMonth(birthDate.Year, birthDate.Month);
            }
            if (months < 0)
            {
                years--;
                months += 12;
            }

            Console.WriteLine($"Ваш возраст: {years} лет, {months} месяцев, {days} дней");
        }
        else
        {
            Console.WriteLine("Некорректный формат даты. Попробуйте еще раз.");
        }
    }
}
