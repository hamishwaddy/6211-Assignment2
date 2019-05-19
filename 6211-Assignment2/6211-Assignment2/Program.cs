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
            Console.WriteLine("QUESTION 1\nYou are required to write a console application with an Algorithm class.\nThis class should contain a Numbers array which contains 50 integer elements.These elements are to be generated at random.\nYou are to write a Display method, which will display the contents of this array to the screen.\nAdd the appropriate code to Main, so the numbers are displayed.");
            Console.WriteLine("The particular challenge for this question is to then add a findMaximum method to your program that will receive two parameters:\n\tan array\n\tan integer(n = number of maximum elements to be found)\nThis method has the job of displaying the n largest elements in the array it receives and displaying it to the screen as shown in the sample program below.\nNOTE:  Do not use the array sort method to complete this challenge.");

            Console.WriteLine("\n\nOriginal Array");
            Algorithm.CreateDataset(Algorithm.numbers);
            Algorithm.Display(Algorithm.numbers);
            int[] numbersClone = new int[Algorithm.numbers.Length];
            Array.Copy(Algorithm.numbers, numbersClone, Algorithm.numbers.Length);
            Console.WriteLine("\n\nData clone");
            Algorithm.Display(numbersClone);

            // testing findmaximum method
            Algorithm.FindMaximum(numbersClone);
            Console.WriteLine("Largerst number: {0}", Algorithm.FindMaximum(numbersClone));

            // testing maxNumbersDescending list
            Console.WriteLine("\n\nmaxNumbersDescending List");
            Algorithm.DisplayList(Algorithm.maxNumbersDescending);
            Console.WriteLine("\nMax Numbers List count: {0}", Algorithm.maxNumbersDescending.Count());

            //Console.Write("\nHow many maximum values would you like to find? ");
            //int n = int.Parse(Console.ReadLine());
            //Console.WriteLine($"\n\nThe {n} largest elements in array are:");
            //Algorithm.FindMaximum(numbersClone, n);

            // QUESTION 2
            int[] numbersClone2 = new int[Algorithm.numbers.Length];
            Array.Copy(Algorithm.numbers, numbersClone2, Algorithm.numbers.Length);
            Console.WriteLine("\n\n\n*** QUESTION 2 ***\n\n");
            Console.WriteLine("Data Clone 2");
            Algorithm.Display(numbersClone2);
            Console.Write("\nWhat value do you want to find: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("\nWhich occurence do you want to find");
            int b = int.Parse(Console.ReadLine());
            Algorithm.NumOccurenceSearch(numbersClone2, a, b);


            Console.ReadLine();
        }
    }
}
