using System;
using System.Collections.Generic;
using System.Text;

namespace _4th_Lab
{
    internal class Line
    {
        static Random rand;

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

        #region OutPut
        public static void Print(int[] array)
        {
            if(array == null)
            {
                Error.Kill();
            }

            foreach(var element in array)
            {
                Console.Write($"{element, 5}");
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
    }
}
