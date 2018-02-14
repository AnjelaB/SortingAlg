using System;
using SortName;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;

namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of array.");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[n];
            Stopwatch time = new Stopwatch();
            Dictionary<int, double> dictionary = new Dictionary<int, double>();
            
            Random r = new Random();
            for(int i = 0; i < n; i++)
            {
                array[i] = r.Next(125);
            }
            foreach( int el in array)
            {
                Console.Write(el + " ");
            }

            Console.WriteLine("\nSelect which algorithm you want to perform:");
            Console.WriteLine("1.Insertion sort");
            Console.WriteLine("2.Bubble sort");
            Console.WriteLine("3.Quick sort");
            Console.WriteLine("4.Heap sort");
            Console.WriteLine("5.Merge sort");
            Console.WriteLine("6.All");
            string t = Console.ReadLine();

            Insertion insertion=default(Insertion);
            Bubble bubble=default(Bubble);
            Quick quick=default(Quick);
            Heap heap=default(Heap);
            Merge merge=default(Merge);
            
            
            string[] k = t.Split('-');
            if (k[0] == t)
            {
                string[] numbers = t.Split(',');
                if (numbers[0] == "6")
                {
                    insertion = new Insertion(array);
                    time.Start();
                    insertion.Sort();
                    time.Stop();
                    dictionary.Add(1, time.Elapsed.TotalMilliseconds);
                    time.Reset();


                    bubble = new Bubble(array);
                    time.Start();
                    bubble.Sort();
                    time.Stop();
                    dictionary.Add(2, time.Elapsed.TotalMilliseconds);
                    time.Reset();


                    quick = new Quick(array);
                    time.Start();
                    quick.Sort(0, n - 1);
                    time.Stop();
                    time.Reset();
                    dictionary.Add(3, time.Elapsed.TotalMilliseconds);
                    

                    heap = new Heap(array);
                    time.Start();
                    heap.Sort();
                    time.Stop();
                    dictionary.Add(4, time.Elapsed.TotalMilliseconds);
                    time.Reset();


                    merge = new Merge(array);
                    time.Start();
                    merge.Sort();
                    time.Stop();
                    dictionary.Add(5, time.Elapsed.TotalMilliseconds);
                    time.Reset();
                }
                else
                    foreach (string el in numbers) {

                        switch (el)
                        {
                            case "1":
                                insertion = new Insertion(array);
                                time.Start();
                                insertion.Sort();
                                time.Stop();
                                dictionary.Add(1, time.Elapsed.TotalMilliseconds);
                                time.Reset();

                                break;
                            case "2":
                                bubble = new Bubble(array);
                                time.Start();
                                bubble.Sort();
                                time.Stop();
                                dictionary.Add(2, time.Elapsed.TotalMilliseconds);
                                time.Reset();

                                break;
                            case "3":
                                quick = new Quick(array);
                                time.Start();
                                quick.Sort(0, n - 1);
                                time.Stop();
                                dictionary.Add(3, time.Elapsed.TotalMilliseconds);
                                time.Reset();
                                break;
                            case "4":
                                heap = new Heap(array);
                                time.Start();
                                heap.Sort();
                                time.Stop();
                                dictionary.Add(4, time.Elapsed.TotalMilliseconds);
                                time.Reset();
                                break;
                            case "5":
                                merge = new Merge(array);
                                time.Start();
                                merge.Sort();
                                time.Stop();
                                dictionary.Add(5, time.Elapsed.TotalMilliseconds);
                                time.Reset();
                                break;
                        }
                    
                }
            }
            else
            {
                int number1 = Convert.ToInt32(k[0]);
                int number2 = Convert.ToInt32(k[1]);
                while (number1 <= number2)
                {
                    switch (number1)
                    {
                        case 1:
                            insertion = new Insertion(array);
                            time.Start();
                            insertion.Sort();
                            time.Stop();
                            dictionary.Add(1, time.Elapsed.TotalMilliseconds);
                            time.Reset();
                            break;
                        case 2:
                            bubble = new Bubble(array);
                            time.Start();
                            bubble.Sort();
                            time.Stop();
                            dictionary.Add(2, time.Elapsed.TotalMilliseconds);
                            time.Reset();
                            break;
                        case 3:
                            quick = new Quick(array);
                            time.Start();
                            quick.Sort(0, n - 1);
                            time.Stop();
                            dictionary.Add(3, time.Elapsed.TotalMilliseconds);
                            time.Reset();
                            break;
                        case 4:
                            heap = new Heap(array);
                            time.Start();
                            heap.Sort();
                            time.Stop();
                            dictionary.Add(4, time.Elapsed.TotalMilliseconds);
                            time.Reset();
                            break;
                        case 5:
                            merge = new Merge(array);
                            time.Start();
                            merge.Sort();
                            time.Stop();
                            dictionary.Add(5, time.Elapsed.TotalMilliseconds);
                            time.Reset();
                            break;
                    }
                    number1++;
                }
            }

            double time1 = dictionary.First().Value;
            int index = dictionary.First().Key;
            if (dictionary.Count != 1)
                for (int i = 0; i <= 5; i++)
                {
                    if (dictionary.ContainsKey(i) == true)
                    {
                        if (dictionary[i] < time1)
                        {
                            time1 = dictionary[i];
                            index = i;
                        }
                    }
                }


            foreach (int i in dictionary.Keys)
            {
                switch (i)
                {
                    case 1:
                        {
                            if (index == i)
                            {
                                insertion.Print(true);
                                Console.WriteLine(dictionary[i] + "ms");
                            }
                            else
                            {
                                insertion.Print(false);
                                Console.WriteLine(dictionary[i] + "ms");
                            }

                            break;
                        }
                    case 2:
                        {
                            if (index == i)
                            {
                                bubble.Print(true);
                                Console.WriteLine(dictionary[i] + "ms");
                            }
                            else
                            {
                                bubble.Print(false);
                                Console.WriteLine(dictionary[i] + "ms");
                            }
                            break;
                        }
                    case 3:
                        {
                            if (index == i)
                            {
                                quick.Print(true);
                                Console.WriteLine(dictionary[i] + "ms");
                            }
                            else
                            {
                                quick.Print(false);
                                Console.WriteLine(dictionary[i] + "ms");
                            }
                            break;
                        }
                    case 4:
                        {
                            if (index == i)
                            {
                                heap.Print(true);
                                Console.WriteLine(dictionary[i] + "ms");
                            }
                            else
                            {
                                heap.Print(false);
                                Console.WriteLine(dictionary[i] + "ms");
                            }
                            break;
                        }
                    case 5:
                        {
                            if (index == i)
                            {
                                merge.Print(true);
                                Console.WriteLine(dictionary[i] + "ms");
                            }
                            else
                            {
                                merge.Print(false);
                                Console.WriteLine(dictionary[i] + "ms");
                            }
                            break;
                        }




                }
            }
            
            Console.ReadLine();

        }

    }
}
