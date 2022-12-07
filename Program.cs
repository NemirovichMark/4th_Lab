using System;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main(string[] args)
        {
            #region lvl1_task3

            Console.WriteLine("Input matrix: ");
            var arr = new List<List<int>>();
            var input = Console.ReadLine().Split();
            var n = 0;
            var m = input.Length;
            while (input[0] != "")
            {
                List<int> temp = new List<int>(m);
                foreach (var s in input)
                {
                    if (int.TryParse(s, out var elem))
                    {
                        temp.Add(elem);
                    }
                }

                n++;
                arr.Add(temp);
                input = Console.ReadLine().Split();
            }

            var sum = 0;
            for (var i = 0; i < n; i++)
            {
                sum += arr[i][i];
                sum += arr[n - i - 1][i];
            }

            if (n % 2 == 1)
            {
                sum -= arr[n / 2][n / 2];
            }

            Console.WriteLine(sum);

            #endregion

            #region lvl1_task6

            Console.WriteLine("Input matrix: ");
            arr = new List<List<int>>();
            input = Console.ReadLine().Split();
            n = 0;
            m = input.Length;
            while (input[0] != "")
            {
                List<int> temp = new List<int>(m);
                foreach (var s in input)
                {
                    if (int.TryParse(s, out var elem))
                    {
                        temp.Add(elem);
                    }
                }

                n++;
                arr.Add(temp);
                input = Console.ReadLine().Split();
            }

            List<int> outP = new List<int>(n);
            int min, minI;
            for (var i = 0; i < n; i++)
            {
                var temp = arr[i];
                min = temp[0];
                var minN = -1;
                for (var j = 1; j < m; j++)
                {
                    if (temp[j] < min)
                    {
                        min = temp[j];
                        minN = j;
                    }
                }

                outP.Add(minN);
            }

            Console.Write("Output array: ");
            foreach (var elem in outP)
            {
                Console.Write(elem + " ");
            }

            #endregion

            #region lvl1_task12

            Console.WriteLine("Input matrix: ");
            arr = new List<List<int>>();
            input = Console.ReadLine().Split();
            n = 0;
            m = input.Length;
            while (input[0] != "")
            {
                List<int> temp = new List<int>(m);
                foreach (var s in input)
                {
                    if (int.TryParse(s, out var elem))
                    {
                        temp.Add(elem);
                    }
                }

                n++;
                arr.Add(temp);
                input = Console.ReadLine().Split();
            }

            var maxI = -1;
            var maxJ = -1;
            var max = 0;
            for (var i = 0; i < n; i++)
            {
                for (var j = 0; j < m; j++)
                {
                    if (arr[i][j] > max)
                    {
                        maxI = i;
                        maxJ = j;
                        max = arr[i][j];
                    }
                }
            }

            for (var i = 0; i < n; i++)
            {
                arr[i].RemoveAt(maxJ);
            }

            arr.RemoveAt(maxI);

            Console.WriteLine("Output matrix: ");
            foreach (var row in arr)
            {
                foreach (var elem in row)
                {
                    Console.Write(elem + " ");
                }

                Console.WriteLine();
            }

            #endregion

            #region lvl1_task13

            Console.WriteLine("Input matrix: ");
            arr = new List<List<int>>();
            input = Console.ReadLine().Split();
            n = 0;
            m = input.Length;
            while (input[0] != "")
            {
                List<int> temp = new List<int>(m);
                foreach (var s in input)
                {
                    if (int.TryParse(s, out var elem))
                    {
                        temp.Add(elem);
                    }
                }

                n++;
                arr.Add(temp);
                input = Console.ReadLine().Split();
            }

            maxJ = -1;
            var maxD = 0;
            for (var i = 0; i < n; i++)
            {
                if (arr[i][i] > maxD)
                {
                    maxD = arr[i][i];
                    maxJ = i;
                }
            }

            for (var i = 0; i < n; i++)
            {
                (arr[i][3], arr[i][maxJ]) = (arr[i][maxJ], arr[i][3]);
            }

            Console.WriteLine("Output matrix: ");
            for (var i = 0; i < n; i++)
            {
                for (var j = 0; j < m; j++)
                {
                    Console.Write(arr[i][j] + " ");
                }

                Console.WriteLine();
            }

            #endregion

            #region lvl1_task17

            Console.WriteLine("Input matrix: ");
            arr = new List<List<int>>();
            input = Console.ReadLine().Split();
            n = 0;
            m = input.Length;
            while (input[0] != "")
            {
                List<int> temp = new List<int>(m);
                foreach (var s in input)
                {
                    if (int.TryParse(s, out var elem))
                    {
                        temp.Add(elem);
                    }
                }

                n++;
                arr.Add(temp);
                input = Console.ReadLine().Split();
            }

            for (var k = 0; k < n; k++)
            {
                minI = -1;
                min = arr[k][0];
                for (var i = 1; i < m; i++)
                {
                    if (arr[k][i] < min)
                    {
                        minI = i;
                        min = arr[k][i];
                    }
                }

                for (var i = minI; i > 0; i--)
                {
                    arr[k][i] = arr[k][i - 1];
                }

                arr[k][0] = min;
            }

            Console.WriteLine("Output matrix: ");
            for (var i = 0; i < n; i++)
            {
                for (var j = 0; j < m; j++)
                {
                    Console.Write(arr[i][j] + " ");
                }

                Console.WriteLine();
            }

            #endregion

            #region lvl1_task29

            Console.WriteLine("Input matrix: ");
            arr = new List<List<int>>();
            input = Console.ReadLine().Split();
            n = 0;
            m = input.Length;
            while (input[0] != "")
            {
                List<int> temp = new List<int>(m);
                foreach (var s in input)
                {
                    if (int.TryParse(s, out var elem))
                    {
                        temp.Add(elem);
                    }
                }

                n++;
                arr.Add(temp);
                input = Console.ReadLine().Split();
            }

            minI = -1;
            min = arr[1][0];
            for (var i = 1; i < m; i++)
            {
                var absElem = Math.Abs(arr[1][i]);
                if (absElem < min)
                {
                    minI = i;
                    min = absElem;
                }
            }

            for (var i = 0; i < n; i++)
            {
                arr[i].RemoveAt(minI + 1);
            }

            Console.WriteLine("Output matrix: ");
            for (var i = 0; i < n; i++)
            {
                for (var j = 0; j < m - 1; j++)
                {
                    Console.Write(arr[i][j] + " ");
                }

                Console.WriteLine();
            }

            #endregion

            #region lvl1_task31

            Console.WriteLine("Input matrix (A): ");
            arr = new List<List<int>>();
            input = Console.ReadLine().Split();
            n = 0;
            m = input.Length;
            while (input[0] != "")
            {
                List<int> temp = new List<int>(m);
                foreach (var s in input)
                {
                    if (int.TryParse(s, out var elem))
                    {
                        temp.Add(elem);
                    }
                }

                n++;
                arr.Add(temp);
                input = Console.ReadLine().Split();
            }

            Console.WriteLine("Input vector (B): ");
            var arrB = new List<int>(n);
            input = Console.ReadLine().Split();
            foreach (var s in input)
            {
                if (int.TryParse(s, out var elem))
                {
                    arrB.Add(elem);
                }
            }

            minI = -1;
            min = arr[4][0];
            for (var i = 1; i < m; i++)
            {
                if (arr[4][i] < min)
                {
                    minI = i;
                    min = arr[4][i];
                }
            }

            for (var i = 0; i < n; i++)
            {
                arr[i].Insert(minI + 1, arrB[i]);
            }

            Console.WriteLine("Output matrix: ");
            for (var i = 0; i < n; i++)
            {
                for (var j = 0; j < m + 1; j++)
                {
                    Console.Write(arr[i][j] + " ");
                }

                Console.WriteLine();
            }

            #endregion

            #region lvl2_task7

            Console.WriteLine("Input matrix: ");
            arr = new List<List<int>>();
            input = Console.ReadLine().Split();
            n = 0;
            m = input.Length;
            while (input[0] != "")
            {
                List<int> temp = new List<int>(m);
                foreach (var s in input)
                {
                    if (int.TryParse(s, out var elem))
                    {
                        temp.Add(elem);
                    }
                }

                n++;
                arr.Add(temp);
                input = Console.ReadLine().Split();
            }

            maxI = -1;
            max = 0;
            for (var i = 0; i < n; i++)
            {
                if (arr[i][i] > max)
                {
                    max = arr[i][i];
                    maxI = i;
                }
            }

            for (var i = 0; i < maxI; i++)
            {
                for (var j = i + 1; j < m; j++)
                {
                    arr[i][j] = 0;
                }
            }

            Console.WriteLine("Output matrix: ");
            for (var i = 0; i < n; i++)
            {
                for (var j = 0; j < m; j++)
                {
                    Console.Write(arr[i][j] + " ");
                }

                Console.WriteLine();
            }

            #endregion

            #region lvl2_task8

            Console.WriteLine("Input matrix: ");
            arr = new List<List<int>>();
            input = Console.ReadLine().Split();
            n = 0;
            m = input.Length;
            while (input[0] != "")
            {
                List<int> temp = new List<int>(m);
                foreach (var s in input)
                {
                    if (int.TryParse(s, out var elem))
                    {
                        temp.Add(elem);
                    }
                }

                n++;
                arr.Add(temp);
                input = Console.ReadLine().Split();
            }

            for (var i = 0; i < n; i += 2)
            {
                var maxAi = -1;
                var maxA = 0;
                var maxBi = -1;
                var maxB = 0;
                for (var j = 0; j < m; j++)
                {
                    if (arr[i][j] > maxA)
                    {
                        maxA = arr[i][j];
                        maxAi = j;
                    }

                    if (arr[i + 1][j] > maxB)
                    {
                        maxB = arr[i + 1][j];
                        maxBi = j;
                    }
                }

                (arr[i][maxAi], arr[i + 1][maxBi]) = (arr[i + 1][maxBi], arr[i][maxAi]);
            }

            Console.WriteLine("Output matrix: ");
            for (var i = 0; i < n; i++)
            {
                for (var j = 0; j < m; j++)
                {
                    Console.Write(arr[i][j] + " ");
                }

                Console.WriteLine();
            }

            #endregion

            #region lvl2_task9

            Console.WriteLine("Input matrix: ");
            arr = new List<List<int>>();
            input = Console.ReadLine().Split();
            n = 0;
            m = input.Length;
            while (input[0] != "")
            {
                List<int> temp = new List<int>(m);
                foreach (var s in input)
                {
                    if (int.TryParse(s, out var elem))
                    {
                        temp.Add(elem);
                    }
                }

                n++;
                arr.Add(temp);
                input = Console.ReadLine().Split();
            }

            for (var i = 0; i < n; i++)
            {
                for (var j = 0; j < m / 2; j++)
                {
                    (arr[i][j], arr[i][m - j - 1]) = (arr[i][m - j - 1], arr[i][j]);
                }
            }

            Console.WriteLine("Output matrix: ");
            for (var i = 0; i < n; i++)
            {
                for (var j = 0; j < m; j++)
                {
                    Console.Write(arr[i][j] + " ");
                }

                Console.WriteLine();
            }

            #endregion

            #region lvl3_task1

            Console.WriteLine("Input matrix: ");
            arr = new List<List<int>>();
            input = Console.ReadLine().Split();
            n = 0;
            m = input.Length;
            while (input[0] != "")
            {
                List<int> temp = new List<int>(m);
                foreach (var s in input)
                {
                    if (int.TryParse(s, out var elem))
                    {
                        temp.Add(elem);
                    }
                }

                n++;
                arr.Add(temp);
                input = Console.ReadLine().Split();
            }

            for (var i = 0; i < n; i++)
            {
                for (var j = n - 1; j > i; j--)
                {
                    if (arr[j].Min() > arr[j - 1].Min())
                    {
                        (arr[j], arr[j - 1]) = (arr[j - 1], arr[j]);
                    }
                }
            }

            Console.WriteLine("Output matrix: ");
            for (var i = 0; i < n; i++)
            {
                for (var j = 0; j < m; j++)
                {
                    Console.Write(arr[i][j] + " ");
                }

                Console.WriteLine();
            }

            #endregion

            #region lvl3_task2

            Console.WriteLine("Input matrix: ");
            arr = new List<List<int>>();
            input = Console.ReadLine().Split();
            n = 0;
            m = input.Length;
            while (input[0] != "")
            {
                List<int> temp = new List<int>(m);
                foreach (var s in input)
                {
                    if (int.TryParse(s, out var elem))
                    {
                        temp.Add(elem);
                    }
                }

                n++;
                arr.Add(temp);
                input = Console.ReadLine().Split();
            }

            for (var i = 0; i < n; i++)
            {
                if (i % (n - 1) == 0)
                {
                    for (var j = 0; j < m; j++)
                    {
                        arr[i][j] = 0;
                    }
                }
                else
                {
                    arr[i][0] = arr[i][m - 1] = 0;
                }
            }

            Console.WriteLine("Output matrix: ");
            for (var i = 0; i < n; i++)
            {
                for (var j = 0; j < m; j++)
                {
                    Console.Write(arr[i][j] + " ");
                }

                Console.WriteLine();
            }

            #endregion

            #region lvl3_task3

            Console.WriteLine("Input matrix: ");
            arr = new List<List<int>>();
            input = Console.ReadLine().Split();
            n = 0;
            m = input.Length;
            while (input[0] != "")
            {
                List<int> temp = new List<int>(m);
                foreach (var s in input)
                {
                    if (int.TryParse(s, out var elem))
                    {
                        temp.Add(elem);
                    }
                }

                n++;
                arr.Add(temp);
                input = Console.ReadLine().Split();
            }

            var outA = new List<int>(2 * n - 1);

            for (var i = n - 1; i >= 0; i--)
            {
                sum = 0;
                for (var j = 0; j < n - i; j++)
                {
                    sum += arr[i + j][j];
                }

                outA.Add(sum);
            }

            for (var i = 1; i < n; i++)
            {
                sum = 0;
                for (var j = 0; j < n - i; j++)
                {
                    sum += arr[i + j][i];
                }

                outA.Add(sum);
            }

            Console.Write("Output array: ");
            foreach (var elem in outA)
            {
                Console.Write(elem + " ");
            }

            Console.WriteLine();

            #endregion

            #region lvl3_task4

            Console.WriteLine("Input matrix: ");
            arr = new List<List<int>>();
            input = Console.ReadLine().Split();
            n = 0;
            m = input.Length;
            while (input[0] != "")
            {
                List<int> temp = new List<int>(m);
                foreach (var s in input)
                {
                    if (int.TryParse(s, out var elem))
                    {
                        temp.Add(elem);
                    }
                }

                n++;
                arr.Add(temp);
                input = Console.ReadLine().Split();
            }

            for (var i = n / 2; i < n; i++)
            {
                for (var j = 0; j < i; j++)
                {
                    arr[i][j] = 1;
                }
            }

            Console.WriteLine("Output matrix: ");
            for (var i = 0; i < n; i++)
            {
                for (var j = 0; j < m; j++)
                {
                    Console.Write(arr[i][j] + " ");
                }

                Console.WriteLine();
            }

            #endregion

            #region lvl3_task8

            Console.WriteLine("Input matrix: ");
            arr = new List<List<int>>();
            input = Console.ReadLine().Split();
            n = 0;
            m = input.Length;
            while (input[0] != "")
            {
                List<int> temp = new List<int>(m);
                foreach (var s in input)
                {
                    if (int.TryParse(s, out var elem))
                    {
                        temp.Add(elem);
                    }
                }

                n++;
                arr.Add(temp);
                input = Console.ReadLine().Split();
            }

            for (var i = 0; i < n; i++)
            {
                for (var j = n - 1; j > i; j--)
                {
                    var sumA = 0;
                    var sumB = 0;
                    for (var k = 0; k < m; k++)
                    {
                        if (arr[j][k] > 0)
                        {
                            sumA++;
                        }

                        if (arr[j - 1][k] > 0)
                        {
                            sumB++;
                        }
                    }

                    if (sumA > sumB)
                    {
                        (arr[j], arr[j - 1]) = (arr[j - 1], arr[j]);
                    }
                }
            }

            Console.WriteLine("Output matrix: ");
            for (var i = 0; i < n; i++)
            {
                for (var j = 0; j < m; j++)
                {
                    Console.Write(arr[i][j] + " ");
                }

                Console.WriteLine();
            }

            #endregion

            #region lvl3_task10

            Console.WriteLine("Input matrix: ");
            arr = new List<List<int>>();
            input = Console.ReadLine().Split();
            n = 0;
            m = input.Length;
            while (input[0] != "")
            {
                List<int> temp = new List<int>(m);
                foreach (var s in input)
                {
                    if (int.TryParse(s, out var elem))
                    {
                        temp.Add(elem);
                    }
                }

                n++;
                arr.Add(temp);
                input = Console.ReadLine().Split();
            }

            for (var k = 0; k < n; k++)
            {
                if (k % 2 == 0)
                {
                    for (var i = 0; i < m; i++)
                    {
                        for (var j = 0; j < m - i - 1; j++)
                        {
                            if (arr[k][j] > arr[k][j + 1])
                            {
                                (arr[k][j], arr[k][j + 1]) = (arr[k][j + 1], arr[k][j]);
                            }
                        }
                    }
                }
                else
                {
                    for (var i = 0; i < m; i++)
                    {
                        for (var j = m - 1; j > i; j--)
                        {
                            if (arr[k][j] > arr[k][j - 1])
                            {
                                (arr[k][j], arr[k][j - 1]) = (arr[k][j - 1], arr[k][j]);
                            }
                        }
                    }
                }
            }

            Console.WriteLine("Output matrix: ");
            for (var i = 0; i < n; i++)
            {
                for (var j = 0; j < m; j++)
                {
                    Console.Write(arr[i][j] + " ");
                }

                Console.WriteLine();
            }

            #endregion

            #region lvl3_task11

            Console.WriteLine("Input matrix: ");
            arr = new List<List<int>>();
            input = Console.ReadLine().Split();
            n = 0;
            m = input.Length;
            while (input[0] != "")
            {
                List<int> temp = new List<int>(m);
                foreach (var s in input)
                {
                    if (int.TryParse(s, out var elem))
                    {
                        temp.Add(elem);
                    }
                }

                n++;
                arr.Add(temp);
                input = Console.ReadLine().Split();
            }

            for (var i = 0; i < n; i++)
            {
                while (arr[i].Contains(0))
                {
                    arr.RemoveAt(i);
                    n--;
                }
            }

            Console.WriteLine("Output matrix: ");
            for (var i = 0; i < n; i++)
            {
                for (var j = 0; j < m; j++)
                {
                    Console.Write(arr[i][j] + " ");
                }

                Console.WriteLine();
            }

            #endregion
        }
    }
}
