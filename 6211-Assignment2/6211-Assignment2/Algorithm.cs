using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

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

        public static int[] FindMax(int[] arr, int num)
        {

            /*temp array to preserve original*/

            int[] temp = new int[arr.Length];

            Array.Copy(arr, temp, arr.Length);

            /*Array to hold the max numbers of size user defined size, could be a list.*/

            int[] maxNums = new int[num];

            /*External loop is needed to find the "num" amount of largest values.*/

            for (int number = 0; number < num; number++)
            {
                /*variable to hold the location(index) of the max, resets every itteration of the external loop*/

                int maxLoc = 0;

                /*Linear Search*/

                int max = temp[0];

                for (int i = 1; i < temp.Length; i++)

                {

                    if (max < temp[i])

                    {

                        max = temp[i];

                        maxLoc = i;//store the location of the max

                    }

                }

                /*Add the max number to the array using the counter from the external loop and the maxloc variables*/

                maxNums[number] = temp[maxLoc];

                /*Used to test if the correct data is being added to the maximums array*/

                /*
                Console.WriteLine($"Temp: {maxNums[number]}\tmaxLoc: {maxLoc}");

                Console.ReadLine();
                */

                /*Remove the largest number from the dataset so it wont be found again.

                  This could be anything as long as it fits the data type*/

                temp[maxLoc] = -1;

            }

            /*Return the array of maximums to be used in the main*/

            return maxNums;

        }



        // Question 2
        
        public static string NumOccurenceSearch(int[] arr, int value1, int value2)

        {
            string result = ""; // String to hold the result

            /*A list to hold the indices of the selected number*/

            List<int> occurences = new List<int>();


            /*Linear Search Loop to find the numbers occurences, no need to copy the array data isn't altered*/

            for (int i = 0; i < arr.Length; i++)

            {

                if (arr[i] == value1)

                {

                    /* Add the current element of the array to the list */
                    occurences.Add(i);

                }

            }

            /*Check to see if any ocurrences */

            if (occurences.Count > 0)

            {
                while (occurences.Count<value2)
                {
                    return $"The number {value1} does not occur {value2} times.";
                }
                result = $"The item {value1} has ocurrence {value2} at index postion {occurences[(value2)-1]}.";//set the string to display the element in the list using value2 as the index.
            }

            else

            {

                result = $"The number {value1} does not occur in the list.";// Response if no occurences are found

            }

            return result;// Return the string so it can be displayed in the main menu.

        }

        // QUESTION 3
        public static int LastOccuranceSearch(int[] arr, int value)
        {
            int result; // Int to hold the 'last occurance' result

            /*A list to hold the indices of the selected number*/

            List<int> occurences = new List<int>();


            /*Linear Search Loop to find the numbers occurences */

            for (int i = 0; i < arr.Length; i++)

            {

                if (arr[i] == value)

                {

                    /* Add the current element of the array to the list */
                    occurences.Add(i);

                }

            }

            /*Check to see if any ocurrences */

            if (occurences.Count > 0)

            {

                result = occurences[occurences.Count-1];

            }

            else

            {

                result = -1;

            }

            return result;
        }


        // QUESTION 4

        public static long bubbleSort(int[] arr)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            // External loop to check all of array
            for (int i = 0; i < arr.Length-1; i++)
            {
                // Internal loop to go thru elements and check each one
                for (int j = 0; j < arr.Length-1; j++)
                {
                    // If current element is larger, swap
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            stopwatch.Stop();
            return stopwatch.ElapsedTicks;
        }

        public static long improvedBubbleSort(int[] arr)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            bool swap = true;
            // External loop to check all of array
            for (int i = 0; i < arr.Length-1; i++)
            {
                swap = false;
                // Internal loop goes thru elements, checks each and subtracts i as the largest element
                for (int j = 0; j < arr.Length-1-i; j++)
                {
                    // If current element is larger, swap them
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = temp;
                        // Check if any swaps have been made for data in near order
                        swap = true;
                    }
                }
                // If no swaps, break
                if (!swap)
                    break;
            }
            // Return time to sort array
            stopwatch.Stop();
            return stopwatch.ElapsedTicks;
        }


    }


}
