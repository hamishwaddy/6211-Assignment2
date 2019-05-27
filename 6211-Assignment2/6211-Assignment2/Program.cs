using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6211_Assignment2
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool loopBreak = true;
            while (true)
            {
                StandardMessages.Heading();
                // MENU
                Console.WriteLine("Choose a method to test...\n1 - Question 1\n2 - Question 2\n3 - Question 3\n4 - Question 4\n5 - Exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        // QUESTION 1
                        Console.Clear();
                        StandardMessages.Heading();
                        Console.WriteLine("\n*** QUESTION 1 ***\n");
                        Algorithm.CreateDataset(Algorithm.numbers);
                        int[] numbersClone = new int[Algorithm.numbers.Length];
                        Array.Copy(Algorithm.numbers, numbersClone, Algorithm.numbers.Length);
                        Console.WriteLine("Unsorted Data Set");
                        Algorithm.Display(numbersClone);

                        Console.Write("\nHow many maximum values would you like to find? ");
                        int n = int.Parse(Console.ReadLine());
                        int[] maxNums = Algorithm.FindMax(numbersClone, n);
                        Console.Write($"\nThe {n} largest elements in array are: ");
                        foreach (int x in maxNums)
                        {
                            Console.Write(x + " ");
                        }
                        Console.WriteLine("\n\n\n\nPress any key to return to the main menu");
                        Console.ReadLine();
                        break;

                    case 2:
                        // QUESTION 2
                        Console.Clear();
                        StandardMessages.Heading();
                        Algorithm.CreateDataset(Algorithm.numbers);
                        int[] numbersClone2 = new int[Algorithm.numbers.Length];
                        Array.Copy(Algorithm.numbers, numbersClone2, Algorithm.numbers.Length);
                        Console.WriteLine("\n*** QUESTION 2 ***\n");
                        Console.WriteLine("Unsorted Data Set");
                        Algorithm.Display(numbersClone2);
                        Console.Write("\nWhat value do you want to find: ");
                        int a = int.Parse(Console.ReadLine());
                        Console.Write("\nWhich occurence do you want to find: ");
                        int b = int.Parse(Console.ReadLine());
                        Console.WriteLine(Algorithm.NumOccurenceSearch(numbersClone2, a, b));
                        Console.WriteLine("\n\n\n\nPress any key to return to the main menu");
                        Console.ReadLine();
                        break;

                    case 3:
                        // QUESTION 3
                        Console.Clear();
                        StandardMessages.Heading();
                        Algorithm.CreateDataset(Algorithm.numbers);
                        int[] numbersClone3 = new int[Algorithm.numbers.Length];
                        Array.Copy(Algorithm.numbers, numbersClone3, Algorithm.numbers.Length);
                        Console.WriteLine("\n*** QUESTION 3 ***\n");
                        Console.WriteLine("Unsorted Data Set");
                        Algorithm.Display(numbersClone3);
                        Console.Write("\nWhat value do you want to find? ");
                        int input = int.Parse(Console.ReadLine());
                        Algorithm.LastOccuranceSearch(numbersClone3, input);
                        if (Algorithm.LastOccuranceSearch(numbersClone3, input) != -1)
                        {

                            Console.WriteLine($"The item {input} has its last occurance at index: {Algorithm.LastOccuranceSearch(numbersClone3, input)}");

                        }
                        else
                        {

                            Console.WriteLine($"The item {input} was not found");

                        }
                        Console.WriteLine("\n\n\n\nPress any key to return to the main menu");
                        Console.ReadLine();
                        break;

                    case 4:
                        // QUESTION 4
                        Console.Clear();
                        StandardMessages.Heading();
                        Algorithm.CreateDataset(Algorithm.numbers);
                        int[] numbersClone4 = new int[Algorithm.numbers.Length];
                        Array.Copy(Algorithm.numbers, numbersClone4, Algorithm.numbers.Length);
                        int[] numbersClone5 = new int[Algorithm.numbers.Length];
                        Array.Copy(Algorithm.numbers, numbersClone5, Algorithm.numbers.Length);
                        Console.WriteLine("\n*** QUESTION 4 ****\n");
                        Console.WriteLine("Unsorted Data Set");
                        Algorithm.Display(numbersClone4);
                        Console.WriteLine("\nTime to sort using Bubble Sort method: {0} ticks", Algorithm.bubbleSort(numbersClone4));
                        //Algorithm.Display(numbersClone5);
                        Console.WriteLine("Time to sort using Improved Bubble Sort method: {0} ticks", Algorithm.improvedBubbleSort(numbersClone5));
                        Console.WriteLine("\n\n\n\nPress any key to return to the main menu");
                        Console.ReadLine();
                        break;

                    default:
                        loopBreak = false;
                        break;
                }
                if (!loopBreak)
                {
                    break;
                }
            }

            Console.ReadLine();
        }
    }
}
