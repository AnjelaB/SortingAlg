using System;

namespace SortName
{
    /// <summary>
    /// Class for Bubble Sort algorithm.
    /// </summary>
    public class Bubble
    {
        /// <summary>
        /// The Array for bubble sorting.
        /// </summary>
        private int[] array;

        /// <summary>
        /// Parameterized constructor with array type parameter.
        /// </summary>
        /// <param name="arr">Parameter to initialize field.</param>
        public Bubble(int[] arr)
        {
            array = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                array[i] = arr[i];
            }
            
        }

        /// <summary>
        /// Method to sort given array with bubble algorithm.
        /// </summary>
        public void Sort()
        {
            bool t = true;
            while (t)
            {
                t = false;
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        int k = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = k;
                        t = true;
                    }
                    
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
                Console.WriteLine("Bubble Sort Memory:0");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                
                foreach(int el in array)
                {
                    Console.Write(el + " ");
                }
                Console.WriteLine("Bubble Sort Memory:0");
            }
        }
    }
}
