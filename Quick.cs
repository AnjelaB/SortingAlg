using System;

namespace SortName
{
    /// <summary>
    /// Class for Quick Sort algorithm.
    /// </summary>
    public class Quick
    {
        /// <summary>
        /// The Array for insertion sorting.
        /// </summary>
        private int[] array;

        /// <summary>
        /// Parameterized constructor with array type parameter.
        /// </summary>
        /// <param name="arr">Parameter to initialize field.</param>
        public Quick(int[] arr)
        {
            array = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                array[i] = arr[i];
            }
        }

        /// <summary>
        /// Method to find the right index of current element and
        /// replace right elements if thay are less than current element or
        /// left otherwise.
        /// </summary>
        /// <param name="start">The start index of observable part of array.</param>
        /// <param name="end">The end index of observable part of array.</param>
        /// <returns></returns>
        public int Help(int start,int end)
        {
            
            if (end < start)
                return -1;
            int current = start;
            bool t = true;
            while ((end-start) != 0)
            {
                if (t)
                {
                    if (array[start] > array[end])
                    {
                        int k = array[start];
                        array[start] = array[end];
                        array[end] = k;
                        current = end;
                        start++;
                        t = false;
                    }
                    else
                        end--;
                }
                else
                {
                    if (array[start] > array[end])
                    {
                        int k = array[start];
                        array[start] = array[end];
                        array[end] = k;
                        current = start;
                        end--;
                        t = true;
                    }
                    else
                        start++;
                }
            }
            return current;
        }

        /// <summary>
        /// Method to sort the array.
        /// </summary>
        /// <param name="start">The Start index</param>
        /// <param name="end">The End index</param>
        public void Sort(int start,int end)
        {
            if ((start == end || end<0 || start>=array.Length) && start>=end)
                return;
            int current=Help(start, end);
            Sort(start, current - 1);
            Sort(current + 1, end);
            
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
                Console.WriteLine("Quick Sort  Memory:0");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                foreach (int el in array)
                {
                    Console.Write(el + " ");
                }
                Console.WriteLine("Quick Sort  Memory:0");
            }
        }
    }
}
