using System;

namespace P04.PlayCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] integers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            bool exceptionsFound = true;
            int exceptionsCount = 0;

            while (exceptionsFound)
            {
                string[] input = Console.ReadLine().Split(" ").ToArray();
                string command = input[0];
                try
                {
                    int index = int.Parse(input[1]);
                    if (command == "Replace")
                    {
                        int element = int.Parse(input[2]);
                        integers[index] = element;
                    }
                    else if (command == "Print")
                    {
                        int endIndex = int.Parse(input[2]);
                        for (int i = index; i <= endIndex; i++)
                        {
                            if (index < 0 || endIndex > integers.Length - 1)
                            {
                                throw new IndexOutOfRangeException();
                            }
                            Console.Write(integers[i]);
                            if (i < endIndex)
                            {
                                Console.Write(", ");
                            }
                        }
                        Console.WriteLine();
                    }
                    else if (command == "Show")
                    {
                        Console.WriteLine(integers[index]);
                    }
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("The index does not exist!");
                    exceptionsCount++;
                }
                catch (FormatException)
                {
                    Console.WriteLine("The variable is not in the correct format!");
                    exceptionsCount++;
                }

                if (exceptionsCount == 3)
                {
                    exceptionsFound = false;
                }
            }

            Console.WriteLine(string.Join(", ", integers));
        }
    }
}

/*
1 2 3 4 5
Replace 1 9
Replace 6 3
Show 3
Show peter 
Show 6 
 */