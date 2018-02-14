using System;

namespace SortName
{
    /// <summary>
    /// Class for Heap Sort algorithm.
    /// </summary>
    public class Heap
    {
        /// <summary>
        /// The Array for Heap sorting.
        /// </summary>
        private int[] array;

        /// <summary>
        /// The left child index.
        /// </summary>
        private int left;

        /// <summary>
        /// The right child index.
        /// </summary>
        private int right;

        /// <summary>
        /// Parameterized constructor with array type parameter.
        /// </summary>
        /// <param name="arr">Parameter to initialize field.</param>
        public Heap(int[] arr)
        {
            array = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                array[i] = arr[i];
            }
           
        }

        /// <summary>
        /// Method to set the largest value to parent from parent, left child and right child.
        /// </summary>
        /// <param name="size">The last index of observable part of array.</param>
        /// <param name="parent">The index of parent.</param>
        /// <returns></returns>
        public Array Heapfy(int size, int parent)
        {
            left = 2 * parent + 1;
            right = 2 * parent + 2;
            if (right <= size-1 && array[right] > array[parent] && array[right] > array[left])
            {
                int k = array[right];
                array[right] = array[parent];
                array[parent] = k;
            }
            else if(right <= size-1 && array[left] > array[parent] && array[right] < array[left])
            {
                int k = array[left];
                array[left] = array[parent];
                array[parent] = k;
            }
            else if (left <= size-1 && array[left]>array[parent])
            {
                int k = array[left];
                array[left] = array[parent];
                array[parent] = k;
            }

            return array;
        }

        /// <summary>
        /// Method to sort given array with Heap algorithm.
        /// </summary>
        public void Sort()
        {
            int n = array.Length;
            while (n != 0)
            {
                for (int j = n/2-1; j >= 0; j--)
                {
                    Heapfy(n, j);
                }
                int k = array[n - 1];
                array[n - 1] = array[0];
                array[0] = k;
                n--;
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
                Console.WriteLine("Heap Sort Memory:0");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                foreach (int el in array)
                {
                    Console.Write(el + " ");
                }
                Console.WriteLine("Heap Sort Memory:0");
            }
        }
    }
}
