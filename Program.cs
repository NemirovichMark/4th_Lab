using System;


namespace lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            //goto used to test the tasks faster, not as a part of the program

            //goto random_input_generator;

            //goto task_6_lv1;
            //goto task_12_lv1;
            //goto task_13_lv1;
            //goto task_17_lv1;
            //goto task_29_lv1;
            //goto task_31_lv1;

            //goto task_7_lv2;
            //goto task_8_lv2;
            //goto task_9_lv2;

            //goto task_1_lv3;
            //goto task_2_lv3;
            //goto task_3_lv3;
            //goto task_4_lv3;
            //goto task_8_lv3;
            //goto task_10_lv3;
            goto task_11_lv3;


            #region task 3 lv1
            Console.WriteLine("Task 3 (level 1)");
            Console.WriteLine("Enter the values of the 4x4 matrix.");

            int n = 4, m = 4;
            double[,] a = new double[n, m];
            double x;
            bool try_x;
            double s = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    try_x = double.TryParse(Console.ReadLine(), out x);

                    if (!try_x)
                    {
                        Console.WriteLine("Invalid input.");
                        Console.ReadLine();
                        return;
                    }

                    a[i, j] = x;
                }
            }

            Console.WriteLine();
            Console.WriteLine("Here is your matrix:");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{a[i, j],5}  ");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < n; i++)
            {
                s += a[i, i];
            }

            Console.WriteLine();
            Console.WriteLine($"The sum of the main diagonal is {s}.");

            Console.ReadLine();

        #endregion

        task_6_lv1:
            #region task 6 lv1
            Console.WriteLine("Task 6 (level 1)");
            Console.WriteLine("Enter the values of the 4x7 matrix.");

            n = 4;
            m = 7;

            a = new double[n, m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    try_x = double.TryParse(Console.ReadLine(), out x);

                    if (!try_x)
                    {
                        Console.WriteLine("Invalid input.");
                        Console.ReadLine();
                        return;
                    }

                    a[i, j] = x;
                }
            }

            Console.WriteLine();
            Console.WriteLine("Here is your matrix:");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{a[i, j],5}  ");
                }
                Console.WriteLine();
            }


            double min;
            int min_i;
            int[] b = new int[n]; 

            for (int i = 0; i < n; i++)
            {
                min = a[i, 0];
                min_i = 0;

                for (int j = 0; j < m; j++)
                {
                    if (a[i, j] < min)
                    {
                        min = a[i, j];
                        min_i = j;
                    }
                }
                b[i] = min_i;
            }

            Console.WriteLine();
            Console.WriteLine("Here is your array:");

            foreach (int val in b)
            {
                Console.Write($"{val} ");
            }

            Console.ReadLine();
        #endregion

        task_12_lv1:
            #region task 12 lv1
            Console.WriteLine("Task 12 (level 1)");
            Console.WriteLine("Enter the values of the 6x7 matrix.");

            n = 6;
            m = 7;

            a = new double[n, m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    try_x = double.TryParse(Console.ReadLine(), out x);

                    if (!try_x)
                    {
                        Console.WriteLine("Invalid input.");
                        Console.ReadLine();
                        return;
                    }

                    a[i, j] = x;
                }
            }

            Console.WriteLine();
            Console.WriteLine("Here is your matrix:");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{a[i, j],5}  ");
                }
                Console.WriteLine();
            }


            double max = a[0, 0];
            int max_i = 0, max_j = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (a[i, j] > max)
                    {
                        max = a[i, j];
                        max_i = i;
                        max_j = j;
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine($"The maximum value in the matrix: {max} ({max_i};{max_j}).");

            for (int i = max_i; i < n - 1; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    a[i, j] = a[i + 1, j];
                }
            }

            for (int j = max_j; j < m - 1; j++)
            {
                for (int i = 0; i < n; i++)
                {
                    a[i, j] = a[i, j + 1];
                }
            }

            Console.WriteLine();
            Console.WriteLine("Here is your new matrix:");

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < m - 1; j++)
                {
                    Console.Write($"{a[i, j],5}  ");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        #endregion

        task_13_lv1:
            #region task 13 lv1
            Console.WriteLine("Task 13 (level 1)");
            Console.WriteLine("Enter the values of the 5x5 matrix.");

            n = 5;
            m = 5;

            a = new double[n, m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    try_x = double.TryParse(Console.ReadLine(), out x);

                    if (!try_x)
                    {
                        Console.WriteLine("Invalid input.");
                        Console.ReadLine();
                        return;
                    }

                    a[i, j] = x;
                }
            }

            Console.WriteLine();
            Console.WriteLine("Here is your matrix:");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{a[i, j],5}  ");
                }
                Console.WriteLine();
            }


            max = a[0, 0];
            max_j = 0;

            for (int i = 0; i < n; i++)
            {
                if (a[i, i] > max)
                {
                    max = a[i, i];
                    max_j = i;
                }
            }

            Console.WriteLine();
            Console.WriteLine($"The maximum value in the main diagonal: {max} ({max_j};{max_j}).");

            double[] temp = new double[n];  

            for (int i = 0; i < n; i++)
            {
                temp[i] = a[i, 3];
                a[i, 3] = a[i, max_j];
                a[i, max_j] = temp[i];
            }

            Console.WriteLine();
            Console.WriteLine("Here is your new matrix:");

            for (int i = 0; i < n ; i++)
            {
                for (int j = 0; j < m ; j++)
                {
                    Console.Write($"{a[i, j],5}  ");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        #endregion

        task_17_lv1:
            #region task 17 lv1
            Console.WriteLine("Task 17 (level 1)");

            Console.WriteLine("Enter the N value.");
            try_x = int.TryParse(Console.ReadLine(), out n);

            if ((!try_x) || (n <= 0))
            {
                Console.WriteLine("Invalid input.");
                Console.ReadLine();
                return;
            }

            Console.WriteLine();
            Console.WriteLine("Enter the M value.");
            try_x = int.TryParse(Console.ReadLine(), out m);

            if ((!try_x) || (n <= 0))
            {
                Console.WriteLine("Invalid input.");
                Console.ReadLine();
                return;
            }

            Console.WriteLine();
            Console.WriteLine("Enter the values of the NxM matrix.");

            a = new double[n, m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    try_x = double.TryParse(Console.ReadLine(), out x);

                    if (!try_x)
                    {
                        Console.WriteLine("Invalid input.");
                        Console.ReadLine();
                        return;
                    }

                    a[i, j] = x;
                }
            }

            Console.WriteLine();
            Console.WriteLine("Here is your matrix:");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{a[i, j],5}  ");
                }
                Console.WriteLine();
            }
            
            int min_j;

            for (int i = 0; i < n; i++)
            {
                min = a[i, 0];
                min_j = 0;

                for(int j = 0; j < m; j++)
                {
                    if (a[i, j] < min)
                    {
                        min = a[i, j];
                        min_j = j;
                    }
                }

                for (int j = min_j; j > 0; j--)
                {
                    a[i, j] = a[i, j - 1];
                }

                a[i, 0] = min;

            }

            
            Console.WriteLine();
            Console.WriteLine("Here is your new matrix:");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{a[i, j],5}  ");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        #endregion

        task_29_lv1:
            #region task 29 lv1
            Console.WriteLine("Task 29 (level 1)");
            Console.WriteLine("Enter the values of the 5x7 matrix.");

            n = 5;
            m = 7;

            a = new double[n, m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    try_x = double.TryParse(Console.ReadLine(), out x);

                    if (!try_x)
                    {
                        Console.WriteLine("Invalid input.");
                        Console.ReadLine();
                        return;
                    }

                    a[i, j] = x;
                }
            }

            Console.WriteLine();
            Console.WriteLine("Here is your matrix:");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{a[i, j],5}  ");
                }
                Console.WriteLine();
            }


            min = a[1, 0];
            min_j = 0;

            for (int j = 1; j < m; j++)
            {
                if (Math.Abs(a[1, j]) < Math.Abs(min))
                {
                    min = a[1, j];
                    min_j = j;
                }
            }

            Console.WriteLine();
            Console.WriteLine($"The min value (by module) in the 2nd row: {min} (1;{min_j}).");

            for (int i = 0; i < n; i++)
            {
                for (int j = min_j + 1; j < m - 1; j++)
                {
                    a[i, j] = a[i, j + 1];
                }
            }

            if (min_j < m - 1)
            {
                m -= 1;
            }


            Console.WriteLine();
            Console.WriteLine("Here is your new matrix:");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{a[i, j],5}  ");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        #endregion

        task_31_lv1:
            #region task 31 lv1
            Console.WriteLine("Task 31 (level 1)");
            Console.WriteLine("Enter the first 5x7 values of the 5x8 matrix.");

            n = 5;
            m = 8;

            a = new double[n, m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m - 1; j++)
                {
                    try_x = double.TryParse(Console.ReadLine(), out x);

                    if (!try_x)
                    {
                        Console.WriteLine("Invalid input.");
                        Console.ReadLine();
                        return;
                    }

                    a[i, j] = x;
                }
            }

            Console.WriteLine();
            Console.WriteLine("Here is your matrix:");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{a[i, j],5}  ");
                }
                Console.WriteLine();
            }


            min = a[4, 0];
            min_j = 0;

            for (int j = 1; j < m - 1; j++)
            {
                if (a[4, j] < min)
                {
                    min = a[4, j];
                    min_j = j;
                }
            }

            Console.WriteLine();
            Console.WriteLine($"The min value in the 5th row: {min} (4;{min_j}).");

            for (int i = 0; i < n; i++)
            {
                for (int j = m - 1; j > min_j; j--)
                {
                    a[i, j] = a[i, j - 1];
                }
            }
            
            min_j += 1;

            Console.WriteLine();
            Console.WriteLine("Enter the values of the vector (length = 5).");

            double vector_val;
            for (int i = 0; i < 5; i++)
            {
                try_x = double.TryParse(Console.ReadLine(), out vector_val);

                if (!try_x)
                {
                    Console.WriteLine("Invalid input.");
                    Console.ReadLine();
                    return;
                }

                a[i, min_j] = vector_val;
            }

            Console.WriteLine();
            Console.WriteLine("Here is your new matrix:");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{a[i, j],5}  ");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        #endregion


        task_7_lv2:
            #region task 7 lv2
            Console.WriteLine("Task 7 (level 2)");
            Console.WriteLine("Enter the values of the 6x6 matrix.");

            n = 6;
            m = 6;

            a = new double[n, m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    try_x = double.TryParse(Console.ReadLine(), out x);

                    if (!try_x)
                    {
                        Console.WriteLine("Invalid input.");
                        Console.ReadLine();
                        return;
                    }

                    a[i, j] = x;
                }
            }

            Console.WriteLine();
            Console.WriteLine("Here is your matrix:");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{a[i, j],5}  ");
                }
                Console.WriteLine();
            }


            max = a[0, 0];
            max_i = 0;
            max_j = 0;

            for (int i = 0; i < n; i++)
            {
                if (a[i, i] > max)
                {
                    max = a[i, i];
                    max_i = i;
                    max_j = i;
                }
            }

            Console.WriteLine();
            Console.WriteLine($"The maximum value in the main diagonal: {max} ({max_j};{max_j}).");

            for (int i = 0; i < max_i; i++)
            {
                for (int j = m - 1; j > i; j--)
                {
                    a[i, j] = 0;
                }
            }

            Console.WriteLine();
            Console.WriteLine("Here is your new matrix:");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{a[i, j],5}  ");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        #endregion

        task_8_lv2:
            #region task 8 lv2
            Console.WriteLine("Task 8 (level 2)");
            Console.WriteLine("Enter the values of the 6x6 matrix.");

            n = 6;
            m = 6;

            a = new double[n, m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    try_x = double.TryParse(Console.ReadLine(), out x);

                    if (!try_x)
                    {
                        Console.WriteLine("Invalid input.");
                        Console.ReadLine();
                        return;
                    }

                    a[i, j] = x;
                }
            }

            Console.WriteLine();
            Console.WriteLine("Here is your matrix:");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{a[i, j],5}  ");
                }
                Console.WriteLine();
            }

            double[] max_vals = new double[6];
            int[] max_inds = new int[6];

            for (int i = 0; i < n; i++)
            {
                max = a[i, 0];
                max_j = 0;

                for (int j = 0; j < m; j++)
                {
                    if (a[i, j] > max)
                    {
                        max = a[i, j];
                        max_j = j;
                    }
                }

                max_vals[i] = max;
                max_inds[i] = max_j;
            }

            double temp2;

            temp2 = a[0, max_inds[0]];
            a[0, max_inds[0]] = a[1, max_inds[1]];
            a[1, max_inds[1]] = temp2;

            temp2 = a[2, max_inds[2]];
            a[2, max_inds[2]] = a[3, max_inds[3]];
            a[3, max_inds[3]] = temp2;

            temp2 = a[4, max_inds[4]];
            a[4, max_inds[4]] = a[5, max_inds[5]];
            a[5, max_inds[5]] = temp2;

            Console.WriteLine();
            Console.WriteLine("Here is your new matrix:");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{a[i, j],5}  ");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        #endregion

        task_9_lv2:
            #region task 9 lv2
            Console.WriteLine("Task 9 (level 2)");
            Console.WriteLine("Enter the values of the 6x7 matrix.");

            n = 6;
            m = 7;

            a = new double[n, m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    try_x = double.TryParse(Console.ReadLine(), out x);

                    if (!try_x)
                    {
                        Console.WriteLine("Invalid input.");
                        Console.ReadLine();
                        return;
                    }

                    a[i, j] = x;
                }
            }

            Console.WriteLine();
            Console.WriteLine("Here is your matrix:");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{a[i, j],5}  ");
                }
                Console.WriteLine();
            }

            int last_j;

            for (int i = 0; i < n; i++)
            {
                last_j = m - 1;

                for (int j = 0; j < m / 2; j++)
                {
                    temp2 = a[i, last_j];
                    a[i, last_j] = a[i, j];
                    a[i, j] = temp2;
                    last_j -= 1;
                }
            }

            Console.WriteLine();
            Console.WriteLine("Here is your new matrix:");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{a[i, j],5}  ");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        #endregion


        task_1_lv3:
            #region task 1 lv3
            Console.WriteLine("Task 1 (level 3)");
            Console.WriteLine("Enter the values of the 7x5 matrix.");

            n = 7;
            m = 5;

            a = new double[n, m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    try_x = double.TryParse(Console.ReadLine(), out x);

                    if (!try_x)
                    {
                        Console.WriteLine("Invalid input.");
                        Console.ReadLine();
                        return;
                    }

                    a[i, j] = x;
                }
            }

            Console.WriteLine();
            Console.WriteLine("Here is your matrix:");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{a[i, j],5}  ");
                }
                Console.WriteLine();
            }

            double[] min_vals = new double[7];
            int[] min_inds = new int[7];

            for (int i = 0; i < n; i++)
            {
                min = a[i, 0];

                for (int j = 0; j < m; j++)
                {
                    if (a[i, j] < min)
                    {
                        min = a[i, j];
                    }
                }

                min_vals[i] = min;
                min_inds[i] = i;
            }

            /*Console.WriteLine();
            foreach (double val in min_vals)
            {
                Console.Write($"{val} ");
            }

            Console.WriteLine();
            foreach (double val in min_inds)
            {
                Console.Write($"{val} ");
            }
            Console.WriteLine();*/
            

            for (int i = 0; i < n - 1; i++)
            {
                max = min_vals[i];
                max_i = i;

                for (int j = i + 1; j < n; j++)
                {
                    if (min_vals[j] > max)
                    {
                        max = min_vals[j];
                        max_i = j;
                    }
                }

                min_vals[max_i] = min_vals[i];
                min_vals[i] = max;

                temp2 = min_inds[max_i];
                min_inds[max_i] = min_inds[i];
                min_inds[i] = (int)temp2;
            }


            /*Console.WriteLine();
            foreach (double val in min_vals)
            {
                Console.Write($"{val} ");
            }

            Console.WriteLine();
            foreach (double val in min_inds)
            {
                Console.Write($"{val} ");
            }
            Console.WriteLine();*/

            double[,] temp3 = (double[,])a.Clone();
            temp2 = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    a[i, j] = temp3[min_inds[(int)temp2], j];
                }
                temp2++;
            }

            Console.WriteLine();
            Console.WriteLine("Here is your new matrix:");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{a[i, j],5}  ");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        #endregion

        task_2_lv3:
            #region task 2 lv3
            Console.WriteLine("Task 2 (level 3)");

            Console.WriteLine("Enter the N value.");
            try_x = int.TryParse(Console.ReadLine(), out n);

            if ((!try_x) || (n <= 0))
            {
                Console.WriteLine("Invalid input.");
                Console.ReadLine();
                return;
            }

            Console.WriteLine();
           
            Console.WriteLine("Enter the values of the NxN matrix.");

            m = n;
            a = new double[n, m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    try_x = double.TryParse(Console.ReadLine(), out x);

                    if (!try_x)
                    {
                        Console.WriteLine("Invalid input.");
                        Console.ReadLine();
                        return;
                    }

                    a[i, j] = x;
                }
            }

            Console.WriteLine();
            Console.WriteLine("Here is your matrix:");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{a[i, j],5}  ");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < n * n; i++)
            {
                if ((i < n) || (i >= n * (n - 1)) || (i % n == 0) || (i % n == n - 1))
                {
                    a[i / n, i % n] = 0;
                }
            }

            Console.WriteLine();
            Console.WriteLine("Here is your new matrix:");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{a[i, j],5}  ");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        #endregion

        task_3_lv3:
            #region task 3 lv3
            Console.WriteLine("Task 3 (level 3)");

            Console.WriteLine("Enter the N value.");
            try_x = int.TryParse(Console.ReadLine(), out n);

            if ((!try_x) || (n <= 0))
            {
                Console.WriteLine("Invalid input.");
                Console.ReadLine();
                return;
            }

            Console.WriteLine();

            Console.WriteLine("Enter the values of the NxN matrix.");

            m = n;
            a = new double[n, m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    try_x = double.TryParse(Console.ReadLine(), out x);

                    if (!try_x)
                    {
                        Console.WriteLine("Invalid input.");
                        Console.ReadLine();
                        return;
                    }

                    a[i, j] = x;
                }
            }

            Console.WriteLine();
            Console.WriteLine("Here is your matrix:");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{a[i, j],5}  ");
                }
                Console.WriteLine();
            }

            double[] vector = new double[2 * n - 1];
            

            for (int j_start = 0; j_start < n; j_start++)
            {
                vector_val = 0;
                for (int i = 0; i < n - j_start; i++)
                {
                    vector_val += a[i, i + j_start];
                }

                vector[n - 1 + j_start] = vector_val;
            }


            for(int j_start = n - 2; j_start >= 0; j_start--)
            {
                vector_val = 0;
                for (int i = n - 1; i >= j_start; i--)
                {
                    vector_val += a[i, i - j_start];
                }

                vector[n - 1 - j_start] = vector_val;
            }


            Console.WriteLine();
            Console.WriteLine("Here is your new vector:");

            foreach (double val in vector)
            {
                Console.Write($"{val} ");
            }
            
            Console.ReadLine();
        #endregion


        task_4_lv3:
            #region task 4 lv3
            Console.WriteLine("Task 4 (level 3)");

            Console.WriteLine("Enter the N value.");
            try_x = int.TryParse(Console.ReadLine(), out n);

            if ((!try_x) || (n <= 0))
            {
                Console.WriteLine("Invalid input.");
                Console.ReadLine();
                return;
            }

            Console.WriteLine();

            Console.WriteLine("Enter the values of the NxN matrix.");

            m = n;
            a = new double[n, m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    try_x = double.TryParse(Console.ReadLine(), out x);

                    if (!try_x)
                    {
                        Console.WriteLine("Invalid input.");
                        Console.ReadLine();
                        return;
                    }

                    a[i, j] = x;
                }
            }

            Console.WriteLine();
            Console.WriteLine("Here is your matrix:");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{a[i, j],5}  ");
                }
                Console.WriteLine();
            }

            for (int i = n / 2; i < n; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    a[i, j] = 1;
                }
            }

            Console.WriteLine();
            Console.WriteLine("Here is your new matrix:");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{a[i, j],5}  ");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        #endregion

        task_8_lv3:
            #region task 8 lv3
            Console.WriteLine("Task 8 (level 3)");
            Console.WriteLine("Enter the values of the 7x5 matrix.");

            n = 7;
            m = 5;

            a = new double[n, m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    try_x = double.TryParse(Console.ReadLine(), out x);

                    if (!try_x)
                    {
                        Console.WriteLine("Invalid input.");
                        Console.ReadLine();
                        return;
                    }

                    a[i, j] = x;
                }
            }

            Console.WriteLine();
            Console.WriteLine("Here is your matrix:");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{a[i, j],5}  ");
                }
                Console.WriteLine();
            }

            int[] counts = new int[7];
            int count;
            int[] inds = new int[7];

            for (int i = 0; i < n; i++)
            {
                count = 0;

                for (int j = 0; j < m; j++)
                {
                    if (a[i, j] > 0)
                    {
                        count++;
                    }
                }

                counts[i] = count;
                inds[i] = i;
            }

            /*Console.WriteLine();
            foreach (int val in counts)
            {
                Console.Write($"{val} ");
            }

            Console.WriteLine();
            foreach (int val in inds)
            {
                Console.Write($"{val} ");
            }
            Console.WriteLine();*/


            for (int i = 0; i < n - 1; i++)
            {
                max = counts[i];
                max_i = i;

                for (int j = i + 1; j < n; j++)
                {
                    if (counts[j] > max)
                    {
                        max = counts[j];
                        max_i = j;
                    }
                }

                counts[max_i] = counts[i];
                counts[i] = (int)max;

                temp2 = inds[max_i];
                inds[max_i] = inds[i];
                inds[i] = (int)temp2;
            }


            /*Console.WriteLine();
            foreach (double val in counts)
            {
                Console.Write($"{val} ");
            }

            Console.WriteLine();
            foreach (double val in inds)
            {
                Console.Write($"{val} ");
            }
            Console.WriteLine();*/

            temp3 = (double[,])a.Clone();
            temp2 = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    a[i, j] = temp3[inds[(int)temp2], j];
                }
                temp2++;
            }

            Console.WriteLine();
            Console.WriteLine("Here is your new matrix:");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{a[i, j],5}  ");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        #endregion

        task_10_lv3:
            #region task 10 lv3
            Console.WriteLine("Task 10 (level 3)");

            Console.WriteLine("Enter the N value.");
            try_x = int.TryParse(Console.ReadLine(), out n);

            if ((!try_x) || (n <= 0))
            {
                Console.WriteLine("Invalid input.");
                Console.ReadLine();
                return;
            }

            Console.WriteLine();
            Console.WriteLine("Enter the M value.");
            try_x = int.TryParse(Console.ReadLine(), out m);

            if ((!try_x) || (n <= 0))
            {
                Console.WriteLine("Invalid input.");
                Console.ReadLine();
                return;
            }

            Console.WriteLine();
            Console.WriteLine("Enter the values of the NxM matrix.");

            a = new double[n, m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    try_x = double.TryParse(Console.ReadLine(), out x);

                    if (!try_x)
                    {
                        Console.WriteLine("Invalid input.");
                        Console.ReadLine();
                        return;
                    }

                    a[i, j] = x;
                }
            }

            Console.WriteLine();
            Console.WriteLine("Here is your matrix:");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{a[i, j],5}  ");
                }
                Console.WriteLine();
            }


            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    for (int j = 0; j < m - 1; j++)
                    {
                        max = a[i, j];
                        max_i = j;

                        for (int k = j + 1; k < m; k++)
                        {
                            if (a[i, k] > max)
                            {
                                max = a[i, k];
                                max_i = k;
                            }
                        }

                        a[i, max_i] = a[i, j];
                        a[i, j] = max;
                    }
                }

                else
                {
                    for (int j = 0; j < m - 1; j++)
                    {
                        min = a[i, j];
                        min_i = j;

                        for (int k = j + 1; k < m; k++)
                        {
                            if (a[i, k] < min)
                            {
                                min = a[i, k];
                                min_i = k;
                            }
                        }

                        a[i, min_i] = a[i, j];
                        a[i, j] = min;
                    }
                }
                
            }

            Console.WriteLine();
            Console.WriteLine("Here is your new matrix:");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{a[i, j],5}  ");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        #endregion

        task_11_lv3:
            #region task 11 lv3
            Console.WriteLine("Task 11 (level 3)");

            Console.WriteLine("Enter the N value.");
            try_x = int.TryParse(Console.ReadLine(), out n);

            if ((!try_x) || (n <= 0))
            {
                Console.WriteLine("Invalid input.");
                Console.ReadLine();
                return;
            }

            Console.WriteLine();
            Console.WriteLine("Enter the M value.");
            try_x = int.TryParse(Console.ReadLine(), out m);

            if ((!try_x) || (n <= 0))
            {
                Console.WriteLine("Invalid input.");
                Console.ReadLine();
                return;
            }

            Console.WriteLine();
            Console.WriteLine("Enter the values of the NxM matrix.");

            a = new double[n, m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    try_x = double.TryParse(Console.ReadLine(), out x);

                    if (!try_x)
                    {
                        Console.WriteLine("Invalid input.");
                        Console.ReadLine();
                        return;
                    }

                    a[i, j] = x;
                }
            }

            Console.WriteLine();
            Console.WriteLine("Here is your matrix:");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{a[i, j],5}  ");
                }
                Console.WriteLine();
            }


            b = new int[n];
            count = 0;

            for (int i = 0; i < n; i++)
            {
                b[i] = 1;
                count++;

                for (int j = 0; j < m; j++)
                {
                    if (a[i, j] == 0)
                    {
                        b[i] = 0;
                        count--;
                        break;
                    }
                }
            }

            /*foreach (int val in b)
            {
                Console.Write($"{val} ");
            }
            Console.WriteLine(count);*/

            temp3 = (double[,])a.Clone();
            a = new double[n, m];
            int count2 = 0;

            for (int i = 0; i < n; i ++)
            {
                if (b[i] == 1)
                {
                    for (int j = 0; j < m; j++)
                    {
                        a[count2, j] = temp3[i, j];
                    }
                    count2++;
                }
            }

            Console.WriteLine();
            Console.WriteLine("Here is your new matrix:");

            for (int i = 0; i < count; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{a[i, j],5}  ");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        #endregion


        random_input_generator:
            #region random input generator

            Console.WriteLine();
            Console.WriteLine("RNG:");
            Console.WriteLine();

            Random r = new Random();
            for(int i = 0; i < 6 * 8; i++)
            {
                Console.WriteLine($"{r.Next(100)}");
            }

            Console.ReadLine();
            #endregion
        }
    }
}