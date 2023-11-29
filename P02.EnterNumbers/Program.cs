using System.Security.Cryptography.X509Certificates;

namespace P02.EnterNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            int prevNum = 1;

            while (numbers.Count < 10)
            {
                try
                {
                    int num = ReadNumber(prevNum, 100);
                    numbers.Add(num);
                    prevNum = num;
                }
                catch (ArgumentException)
                {
                    Console.WriteLine($"Your number is not in range {prevNum} - 100!");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid Number!");
                }
            }

            Console.WriteLine(string.Join(", ", numbers));

        }

        static int ReadNumber(int start, int end)
        {
            int number = int.Parse(Console.ReadLine());

            if (number <= start || number >= end)
            {
                throw new ArgumentException();
            }

            return number;
        }
    }
}
