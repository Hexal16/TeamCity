using System;

namespace ForTheTeam
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello TeamCity! Enter you name");
            new Program().Start();
        }

        public void Start()
        {
            var name = Console.ReadLine();

            Console.WriteLine("Enter your birth year");
            var yearAsString = Console.ReadLine();

            var (year, reason) = GetYear(yearAsString);

            if (!string.IsNullOrEmpty(reason))
            {
                Console.WriteLine($"Cannot calculate {reason}");
            }

            Console.WriteLine(LegitBirthYear(year) ? GetPossibleAge(year) : "I don't believe you!!");
        }

        public string GetPossibleAge(int year)
        {
            return $"I guess you could be around {DateTime.Now.Year - year} years old";
        }

        public bool LegitBirthYear(int year)
        {
            var currentYear = DateTime.Now.Year;
            if (year > currentYear) return false;
            if (currentYear - year > 100) return false;
            return true;
        }

        public (int, string) GetYear(string yearAsString)
        {
            if (string.IsNullOrEmpty(yearAsString)) return (0, "This is null");

            if (int.TryParse(yearAsString, out var year))
            {
                return (year, string.Empty);
            }

            return (0, "This is not a real year");
        }
    }
}