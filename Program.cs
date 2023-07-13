using System;
using System.IO;
using System.Linq;

namespace Lab03_Review
{
    class Program
    {
        static void Main(string[] args)
        {
            Challenge1();
            Challenge2();
            Challenge3();
            Challenge4();
            Challenge5();
            Challenge6();
            Challenge7();
            Challenge8();
            Challenge9();
        }

        static void Challenge1()
        {
            Console.Write("Please enter 3 numbers: ");
            string input = Console.ReadLine();
            string[] numbers = input.Split(' ');

            int product = 1;
            for (int i = 0; i < 3 && i < numbers.Length; i++)
            {
                if (int.TryParse(numbers[i], out int num))
                    product *= num;
                else
                    product *= 1;
            }

            Console.WriteLine("The product of these 3 numbers is: " + product);
        }

        static void Challenge2()
        {
            Console.Write("Please enter a number between 2-10: ");
            int count;
            while (!int.TryParse(Console.ReadLine(), out count) || count < 2 || count > 10)
            {
                Console.Write("Invalid input. Please enter a number between 2-10: ");
            }

            int[] numbers = new int[count];
            for (int i = 0; i < count; i++)
            {
                Console.Write((i + 1) + " of " + count + " - Enter a number: ");
                while (!int.TryParse(Console.ReadLine(), out numbers[i]) || numbers[i] < 0)
                {
                    Console.Write("Invalid input. Please enter a positive integer: ");
                }
            }

            double average = numbers.Average();
            Console.WriteLine("The average of these " + count + " numbers is: " + average);
        }

        static void Challenge3()
        {
            int size = 5;
            for (int i = 0; i < size * 2 - 1; i++)
            {
                int count = i < size ? i + 1 : size * 2 - i - 1;
                int spaces = size - count;

                Console.Write(new string(' ', spaces));
                Console.WriteLine(new string('*', count * 2 - 1));
            }
        }

        static void Challenge4()
        {
            Console.WriteLine("Enter a series of numbers separated by commas:");
            string input = Console.ReadLine();

            // Split the input string into an array of integers
            int[] numbers = input.Split(',')
                                 .Select(int.Parse)
                                 .ToArray();

            int mostFrequent = numbers.GroupBy(x => x)
                                      .OrderByDescending(g => g.Count())
                                      .ThenBy(g => Array.IndexOf(numbers, g.Key))
                                      .Select(g => g.Key)
                                      .FirstOrDefault();

            Console.WriteLine("The most frequent number is: " + mostFrequent);
        }

       static void Challenge5()
        {
            Console.WriteLine("Enter a series of numbers separated by commas:");
            string input = Console.ReadLine();
            string[] numberStrings = input.Split(',');
            int[] numbers = new int[numberStrings.Length];

            for (int i = 0; i < numberStrings.Length; i++)
            {
                if (int.TryParse(numberStrings[i].Trim(), out int number))
                {
                    numbers[i] = number;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid array of integers.");
                    return;
                }
            }

            if (numbers.Length == 0)
            {
                Console.WriteLine("The array is empty.");
            }
            else
            {
                int max = numbers[0];
                for (int i = 1; i < numbers.Length; i++)
                {
                    if (numbers[i] > max)
                        max = numbers[i];
                }
                Console.WriteLine("The maximum value is: " + max);
            }
        }

        static void Challenge6()
        {
            Console.Write("Enter a word: ");
            string word = Console.ReadLine();

            using (StreamWriter writer = File.AppendText("words.txt"))
            {
                writer.WriteLine(word);
            }

            Console.WriteLine("Word saved to words.txt.");
        }

       static void Challenge7()
        {
            string[] lines = File.ReadAllLines("words.txt");
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
        }



       static void Challenge8()
        {
            string[] lines = File.ReadAllLines("words.txt");
            if (lines.Length > 0)
            {
                // Remove a word (e.g., the first word)
                string[] remainingWords = lines.Skip(1).ToArray();

                using (StreamWriter writer = new StreamWriter("words.txt"))
                {
                    foreach (string word in remainingWords)
                    {
                        writer.WriteLine(word);
                    }
                }
                Console.WriteLine("Word removed from words.txt.");
            }
            else
            {
                Console.WriteLine("The file is empty.");
            }
        }


        static void Challenge9()
        {
            Console.Write("Enter a sentence: ");
            string sentence = Console.ReadLine();
            string[] words = sentence.Split(' ');

            string[] result = new string[words.Length];
            for (int i = 0; i < words.Length; i++)
            {
                result[i] = words[i] + ": " + words[i].Length;
            }

            Console.WriteLine(string.Join(", ", result));
        }
    }
}