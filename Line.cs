using System;
using System.Buffers;
using System.Collections.Generic;
using System.Text;

namespace _4th_Lab
{
    internal class Line
    {
        static Random rand;

        #region Fill
        public static void Fill(int[] array, int minValue, int maxValue)
        {
            if(array == null)
            {
                Error.Kill();
            }

            int seed = DateTime.Now.Millisecond;
            rand = new Random(seed);
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(minValue, maxValue);
            }
        }
        #endregion

        #region OutPut
        public static void Print(int[] array)
        {
            if(array == null)
            {
                Error.Kill();
            }

            foreach(var element in array)
            {
                Console.Write($"{element}\t");
            }
            Console.WriteLine();
        }

        public static void Print(string[] array)
        {
            if (array == null)
            {
                Error.Kill();
            }

            foreach (var element in array)
            {
                Console.WriteLine($"{element, 4}");
            }
        }
        #endregion

        #region Add
        public static void Add(ref int[] array, int element)
        {
            if(array == null)
            {
                Error.Kill();
            }

            int[] final = new int[array.Length + 1];
            for(int i = 0; i < array.Length; i++)
            {
                final[i] = array[i];
            }

            final[array.Length] = element;
            array = final;
        }

        public static void Add(ref string[] array, string element)
        {
            if (array == null)
            {
                Error.Kill();
            }

            string[] final = new string[array.Length + 1];
            for (int i = 0; i < array.Length; i++)
            {
                final[i] = array[i];
            }

            final[array.Length] = element;
            array = final;
        }
        #endregion

        #region Inverse
        public static void Inverse(int[] array)
        {
            if(array == null)
            {
                Error.Kill();
            }

            for(int i = 0; i < array.Length / 2; i++)
            {
                int inverseIndex = array.Length - i - 1;

                int temp = array[i];
                array[i] = array[inverseIndex];
                array[inverseIndex] = temp;
            }
        }
        #endregion

        #region Sum
        public static int Sum(int[] array)
        {
            if(array == null)
            {
                Error.Kill();
            }

            int sum = 0;
            for(int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }

            return sum;
        }
        #endregion

        #region Sort
        public static void Sort(int[] array, bool isEven)
        {
            if(array == null)
            {
                Error.Kill();
            }

            int index = isEven ? 0 : 1;

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = index; j < array.Length - 2 - i; j += 2)
                {
                    if (isEven)
                    {
                        if (array[j] < array[j + 2])
                        {
                            array[j] = array[j] + array[j + 2];
                            array[j + 2] = array[j] - array[j + 2];
                            array[j] = array[j] - array[j + 2];
                        }
                    }
                    else
                    {
                        if (array[j] > array[j + 2])
                        {
                            array[j] = array[j] + array[j + 2];
                            array[j + 2] = array[j] - array[j + 2];
                            array[j] = array[j] - array[j + 2];
                        }
                    }
                }
            }
        }

        public static void BubbleSort(int[] array)
        {
            if(array == null)
            {
                Error.Kill();
            }

            for(int i = 0; i < array.Length - 1; i++)
            {
                for(int j = 0; j < array.Length - 1 - i; j++)
                {
                    if (array[j] < array[j + 1])
                    {
                        array[j] = array[j] + array[j + 1];
                        array[j + 1] = array[j] - array[j + 1];
                        array[j] = array[j] - array[j + 1];
                    }
                }
            }
        }
        #endregion
        
        #region Move
        public static void Move(int[] array, int index)
        {
            if (array == null)
            {
                Error.Kill();
            }

            if (index < 0 || index >= array.Length)
            {
                Error.Kill();
            }

            int temp = array[index];
            for(int i = index; i > 0; i--)
            {
                array[i] = array[i - 1];
            }
            array[0] = temp;
        }
        #endregion
        
        #region Search
        public static int FindMin(int[] array)
        {
            if(array == null)
            {
                Error.Kill();
            }

            int min = array[0];
            int index = 0;
            for(int i = 0; i < array.Length; i++)
            {
                if(min > array[i])
                {
                    min = array[i];
                    index = i;
                }
            }
            return index;
        }
        #endregion
    }
}
