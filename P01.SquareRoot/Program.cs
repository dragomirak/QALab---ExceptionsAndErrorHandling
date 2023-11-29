namespace P01.SquareRoot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            try
            {
                int number = int.Parse(input);
                if (number < 0)
                {
                    throw new ArgumentException();
                }
                double result = Math.Sqrt(number);
                Console.WriteLine(result);
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Invalid number.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid format.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("The number is too big for integer.");
            }
            finally
            {
                Console.WriteLine("Goodbye."); 
            }
        }
    }
}