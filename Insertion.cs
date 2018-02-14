using System;

namespace SortName
{
    /// <summary>
    /// Class for Insertion Sort algorithm.
    /// </summary>
    public class Insertion
    {
        /// <summary>
        /// The Array for insertion sorting.
        /// </summary>
        private int[] array;

        /// <summary>
        /// Parameterized constructor with array type parameter.
        /// </summary>
        /// <param name="arr">Parameter to initialize field.</param>
        public Insertion(int[] arr)
        {
            array = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                array[i] = arr[i];
            }
        }

        /// <summary>
        /// Method to sort given array with insertion algorithm.
        /// </summary>
        public void Sort()
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    if (array[j] < array[j - 1])
                    {
                        int k = array[j];
                        array[j] = array[j - 1];
                        array[j - 1] = k;
                    }
                    else break;
                }
            }
        }

        /// <summary>
        /// Method to print array.
        /// </summary>
        public void Print(bool t)
        {
            if (t)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                foreach (int el in array)
                {
                    Console.Write(el + " ");
                }
                Console.WriteLine("Insertion Sort Memory:0");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                foreach (int el in array)
                {
                    Console.Write(el + " ");
                }
                Console.WriteLine("Insertion Sort Memory:0");
            }
        }
    }
}

