using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6211_Assignment2
{
    public class Algorithm
    {
        static Random random = new Random();
        public static int[] numbers = new int[50];
        public static List<int> maxNumbersDescending = new List<int>();
        

        public static int[] CreateDataset(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(10, 31);
            }
            return arr;
        }

        public static void Display(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
                if ((i + 1) % 25 == 0)
                    Console.WriteLine();
            }
        }

        public static void DisplayList(List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + " ");
                if ((i + 1) % 25 == 0)
                    Console.WriteLine();
            }
        }

        // Question 1

        public static int FindMaximum(int[] arr)
        {
            int currentLargest = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                // Search array using linear search
                // Find max number in array
                if (arr[i] > currentLargest)
                {
                    currentLargest = arr[i];
                }
            }
            maxNumbersDescending.Add(currentLargest); // This method adds highest number twice. How do I then delete this number from array (or re-assign its value to -1) so next highest number will be found next (and added to maxNumbersDescending list?
            // Add max number to list
            return currentLargest;

            /*
            // Display n largest numbers
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
                if ((i + 1) % 25 == 0)
                    Console.WriteLine();
            }
            */
        }

        // Question 2

        public static void NumOccurenceSearch(int[] arr, int value1, int value2)
        {
            int[] numbersClone2 = new int[Algorithm.numbers.Length];
            Array.Copy(numbers, numbersClone2, numbers.Length);
            
            // Display the elements of the array.
            Console.WriteLine("The array contains the following values:");
            for (int i = numbersClone2.GetLowerBound(0); i <= numbersClone2.GetUpperBound(0); i++)
            Console.WriteLine("\t[{0,2}]: {1}\t", i, numbersClone2[i]);

            // Search for the first occurrence of the duplicated value.
            int searchNum = value1;
            int index = Array.IndexOf(arr, searchNum);
            Console.WriteLine("The first occurrence of \"{0}\" is at index {1}.", searchNum, index);
            /*
            // Search for the user chosen occurrence ('value2') of the value.
            searchNum= value1;
            int searchOccurence = value2;
            index = Array.IndexOf(arr[], searchNum);
            Console.WriteLine("The item {0} has occurence {1} at index {2}.", value1, value2, index);
            */
        }


        /*
            foreach (int number in arr)
            {
                int count;
                dict.TryGetValue(number, out count);
                count++;
                // Replace the entry if it already exists
                dict[number] = count;
            }
            int chosenNumber = 0, ocurrences = 0;
            foreach (var pair in dict)
            {
                if (pair.Value > ocurrences)
                {
                    ocurrences = pair.Value;
                    chosenNumber = pair.Key;
                }
            }
            Console.WriteLine("The chosen number is {0} and it appears {1} times", chosenNumber, ocurrences);
            */


        //int indexPosition = 0;
        ////Display the index of the occurence
        //for (int i = 0; i < arr.Length; i++)
        //{
        //    if (arr[i].Equals(value1))
        //    {
        //        arr[i] = indexPosition;
        //        dict.Add(1, indexPosition);
        //        // need to increment 'key'

        //    }
        //    else
        //        Console.WriteLine("Your number was not found in the array");
        //}
        //Console.WriteLine("The item {0} has occurance {1} at index: {2}", value1, value2, indexPosition);
        //foreach (KeyValuePair<int, int> valuePair in dict)
        //{
        //    Console.WriteLine("Key: {0}, Value: {1}",
        //    dict.Keys, dict.Values);
        //}

        public static void DisplayDictionary(Dictionary<int, int> dict)
        {
            foreach (KeyValuePair<int, int> valuePair in dict)
            {
                Console.WriteLine("Key: {0}, Value: {1}",
                dict.Keys, dict.Values);
            }
        }

        // QUESTION 3
        public static int LastOccuranceSearch(int[] arr, int value)
        {
            int output = Array.LastIndexOf(arr, value);
            return output;
        }
    }

        
}
