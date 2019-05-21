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
            Console.WriteLine("**********************************************************");
            Console.WriteLine("******************* 6211 ASSIGNMENT 2 ********************");
            Console.WriteLine("*************** Hamish Wadsworth 9835077 *****************");
            Console.WriteLine("**********************************************************\n\n");

            // QUESTION 1
            Console.WriteLine("QUESTION 1\n\n");
            //Console.WriteLine("\n\nOriginal Array");
            Algorithm.CreateDataset(Algorithm.numbers);
            //Algorithm.Display(Algorithm.numbers);
            int[] numbersClone = new int[Algorithm.numbers.Length];
            Array.Copy(Algorithm.numbers, numbersClone, Algorithm.numbers.Length);
            Console.WriteLine("Data clone");
            Algorithm.Display(numbersClone);

            Console.Write("\nHow many maximum values would you like to find? ");
            int n = int.Parse(Console.ReadLine());
            //Algorithm.FindMaximum(numbersClone, n);
            //Algorithm.FindMax(numbersClone, n);
            int[] maxNums = Algorithm.FindMax(numbersClone, n);
            //Console.Write($"The {n} largest elements in array are: {maxNums}");
            /* Testing maxNums array */
            //Console.WriteLine("\nTesting maxNums Array");


            // NEED TO LOOP THRU maxNums TO DISPLAY ITS ELEMENTS
            //foreach (int x in maxNums)
            //{
            //    Console.Write (x + " ");
            //}
            // Console.Write($"The {n} largest elements in array are: {????}");
            //for (int i = 0; i < maxNums.Length; i++)
            //{
            //    Console.Write(i + " ");
            //}






            /*
            // testing findmaximum method
            Algorithm.FindMaximum(numbersClone);
            Console.WriteLine("Largest number: {0}", Algorithm.FindMaximum(numbersClone));

            // testing maxNumbersDescending list
            Console.WriteLine("\n\nmaxNumbersDescending List");
            Algorithm.DisplayList(Algorithm.maxNumbersDescending);
            Console.WriteLine("\nMax Numbers List count: {0}", Algorithm.maxNumbersDescending.Count());
            */







            // QUESTION 2
            int[] numbersClone2 = new int[Algorithm.numbers.Length];
            Array.Copy(Algorithm.numbers, numbersClone2, Algorithm.numbers.Length);
            Console.WriteLine("\n\n\nQUESTION 2\n");
            Console.WriteLine("Data Clone 2");
            Algorithm.Display(numbersClone2);
            Console.Write("\nWhat value do you want to find: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("\nWhich occurence do you want to find: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine(Algorithm.NumOccurenceSearch(numbersClone2, a, b));


            // QUESTION 3
            int[] numbersClone3 = new int[Algorithm.numbers.Length];
            Array.Copy(Algorithm.numbers, numbersClone3, Algorithm.numbers.Length);
            Console.WriteLine("\n\n\nQUESTION 3\n\n");
            Console.WriteLine("Data Clone 3");
            Algorithm.Display(numbersClone3);
            Console.WriteLine("What value do you want to find?");
            int input = int.Parse(Console.ReadLine());
            //Algorithm.LastOccuranceSearch(numbersClone3, input);
            Console.WriteLine($"The item {input} has its last occurance at index: {Algorithm.LastOccuranceSearch(numbersClone3,input)}");


            Console.ReadLine();
        }
    }
}
