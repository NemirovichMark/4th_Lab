using System;
using System.Collections.Generic;

namespace Lab_4
{
    internal class Program
    {
        static int[,] CreateMatrix(int rows, int columns)
        {
            int[,] matrix = new int[rows, columns];
            Random randomizer = new Random();
            Console.Write("\n\nYour matrix:");
            for (int i = 0; i < rows; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = randomizer.Next(-100, 100);
                    Console.Write($"{matrix[i, j],5}");
                }
            }
            Console.WriteLine();

            return matrix;
        }

        static void ShowMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                Console.WriteLine();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j],5}");
                }
            }
            Console.WriteLine();
        }
        
        static void SortDown(int[,] matrix)
        {
            int ROWS = matrix.GetLength(0);
            int COLUMNS = matrix.GetLength(1);
            int left = 0;
            int right = ROWS * COLUMNS;
            int swop = 0;
            int row, column, nextRow, nextColumn, temp = 0;
            while (left < right)
            {
                for (int i = left; i < right; i++)
                {
                    row = i / COLUMNS;
                    column = i % COLUMNS;
                    nextRow = row + (column + 1) / COLUMNS;
                    nextColumn = (column + 1) % COLUMNS;
                    if (nextRow == ROWS)
                        break;
                    if (matrix[row, column] < matrix[nextRow, nextColumn])
                    {
                        temp = matrix[nextRow, nextColumn];
                        matrix[nextRow, nextColumn] = matrix[row, column];
                        matrix[row, column] = temp;
                        swop++;
                    }
                }
                right--;

                if (swop == 0)
                {
                    break;
                }
                swop = 0;
                for (int i = right; i > left; i--)
                {
                    row = i / COLUMNS;
                    column = i % COLUMNS;
                    nextRow = row - (COLUMNS - column) / COLUMNS;
                    nextColumn = (i - 1) % COLUMNS;
                    if (nextRow < 0)
                        break;
                    if (matrix[row, column] > matrix[nextRow, nextColumn])
                    {
                        temp = matrix[nextRow, nextColumn];
                        matrix[nextRow, nextColumn] = matrix[row, column];
                        matrix[row, column] = temp;
                        swop++;
                    }
                }
                left++;
                if (swop == 0)
                {
                    break;
                }
            }
            Console.WriteLine("\n\nCoctailSort:");
            ShowMatrix(matrix);
        }
        
        static void SortUp(int[,] matrix)
        {
            int ROWS = matrix.GetLength(0);
                int COLUMNS = matrix.GetLength(1);
                int left = 0;
                int right = ROWS * COLUMNS;
                int swop = 0;
                int row, column, nextRow, nextColumn, temp = 0;
                while (left < right)
                {
                    for (int i = left; i < right; i++)
                    {
                        row = i / COLUMNS;
                        column = i % COLUMNS;
                        nextRow = row + (column + 1) / COLUMNS;
                        nextColumn = (column + 1) % COLUMNS;
                        if (nextRow == ROWS)
                            break;
                        if (matrix[row, column] > matrix[nextRow, nextColumn])
                        {
                            temp = matrix[nextRow, nextColumn];
                            matrix[nextRow, nextColumn] = matrix[row, column];
                            matrix[row, column] = temp;
                            swop++;
                        }
                    }
                    right--;

                    if (swop == 0)
                    {
                        break;
                    }
                    swop = 0;
                    for (int i = right; i > left; i--)
                    {
                        row = i / COLUMNS;
                        column = i % COLUMNS;
                        nextRow = row - (COLUMNS - column) / COLUMNS;
                        nextColumn = (i - 1) % COLUMNS;
                        if (nextRow < 0)
                            break;
                        if (matrix[row, column] < matrix[nextRow, nextColumn])
                        {
                            temp = matrix[nextRow, nextColumn];
                            matrix[nextRow, nextColumn] = matrix[row, column];
                            matrix[row, column] = temp;
                            swop++;
                        }
                    }
                    left++;
                    if (swop == 0)
                    {
                        break;
                    }
                }
                Console.WriteLine("\n\nCoctailSort:");
                ShowMatrix(matrix);
        }

        static void Main(string[] args)
        {
            //Part 1
            /*
            #region 3
            int[,] a = CreateMatrix(4, 4);
            int sum = 0;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                sum += a[i, i];
            }
            Console.WriteLine(sum);
            #endregion 
            
            #region 6
            int[,] A = CreateMatrix(4, 7);
            List<int> minimal = new List<int>(4);
            int min;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                min = A[i, 0];
                for (int i1 = 1; i1 < A.GetLength(1); i1++)
                {
                    if (A[i, i1] < min) 
                        min = A[i, i1];
                }
                minimal.Add(min);
            }
            foreach (int el in minimal)
                Console.WriteLine(el);
            #endregion
            
            #region 12
            int[,] A = CreateMatrix(6, 7);
            int max = A[0, 0], index_max_row = 0, index_max_column = 0;
            int rows = A.GetLength(0), columns = A.GetLength(1);

            for (int column_index = 0; column_index < columns; column_index++)
                for (int row_index = 0; row_index < rows; row_index++)
                    if (A[row_index, column_index] > max)
                    {
                        max = A[row_index, column_index];
                        index_max_row = row_index;
                        index_max_column = column_index;
                    }

            for (int column_index = index_max_column; column_index < columns - 1; column_index++)
                for (int row_index = 0; row_index < rows; row_index++)
                    A[row_index, column_index] = A[row_index, column_index + 1];

            for (int row_index = index_max_row; row_index < rows - 1; row_index++)
                for (int column_index = 0; column_index < columns; column_index++)
                    A[row_index, column_index] = A[row_index + 1, column_index];               
            for (int i = 0; i < columns; i++)
                A[rows - 1, i] = 0;
            for (int i = 0; i < rows; i++)
                A[i, columns - 1] = 0;            
            ShowMatrix(A);
            #endregion
                      
            #region 13
            int[,] a = CreateMatrix(5, 5);
            int max = a[0, 0];
            int column_index = 0;
            for (int i = 1; i < a.GetLength(1); i++)            
                if (a[i, i] > max)
                {
                    max = a[i, i];
                    column_index = i;
                }

            if (column_index != 4)
            {
                int row_4th = 3;
                int intermediate_value;
                for (int i = 0; i < a.GetLength(1); i++)
                {
                    intermediate_value = a[i, column_index]; // записал значение из столбца с максимальным значением 
                    a[i, column_index] = a[i, row_4th];
                    a[i, row_4th] = intermediate_value;
                }
            }
            ShowMatrix(a);
            #endregion
            
            #region 17
            int n = 5, m = 7;
            int[,] B = CreateMatrix(n, m);

            int local_min, local_min_index;
            //цикл, перебирающий индексы всех строк массива
            for (int row_index = 0; row_index < n; row_index++)
            {
                local_min = B[row_index, 0];
                local_min_index = 0;
                //поиск индекса минимального элемента в конкретной строке
                for (int row_element_index = 0; row_element_index < m; row_element_index++)
                {
                    if (B[row_index, row_element_index] < local_min)
                    {
                        local_min = B[row_index, row_element_index];
                        local_min_index = row_element_index;
                    }
                }

                int[] intermediate_values = new int[m - 1];
                int count = 0;
                //формирование массива из всех значений конкретной строки, кроме минимального
                for (int row_element_index = 0; row_element_index < m; row_element_index++)
                    if (row_element_index != local_min_index)
                    {
                        intermediate_values[count] = B[row_index, row_element_index];
                        count++;
                    }

                //присвоение первому элементу конкретной строки значения минимального
                B[row_index, 0] = B[row_index, local_min_index];
                //присвоение остальным элементам конкретной строки всех значений кроме минимального, с сохранением упорядоченности
                for (int row_element_index = 1; row_element_index < m; row_element_index++)
                    B[row_index, row_element_index] = intermediate_values[row_element_index - 1];
            }
            ShowMatrix(B);
            #endregion
            
            #region 29
            int[,] F = CreateMatrix(5, 7);
            int row_2nd = 1;
            int min = Math.Abs(F[row_2nd, 0]);
            int min_index = 0;

            //находим индекс минимального значения по модулю во втором ряду
            for (int i = 1; i < F.GetLength(1); i++) 
            {
                if (Math.Abs(F[row_2nd, i]) < min)
                {
                    min = Math.Abs(F[row_2nd, i]);
                    min_index = i;
                }
            }

            //сдвиг столбцов после столбца с минимальным элементом на шаг влево, не включая столбец после столбца с минимальным элементом
            if (min_index != F.GetLength(1) - 1)
                for (int column_index = min_index + 1; column_index < F.GetLength(1) - 1; column_index++) //перебор столбцов                
                    for (int row_index = 0; row_index < F.GetLength(0); row_index++) //перебор рядов                    
                        F[row_index, column_index] = F[row_index, column_index + 1];

            int row_index2 = matrix.GetLength(0) - 1;
            //обращение последнего стобца в нули
            if (min_index != F.GetLength(1) - 1)            
            {                
                for (int column_index2 = 0; column_index2 < matrix.GetLength(1); column_index2++)
                    matrix[row_index2, column_index2] = 0;
            
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    Console.WriteLine();
                    for (int j = 0; j < matrix.GetLength(1) - 1; j++)
                    {
                        Console.Write($"{matrix[i, j],5}");
                    }
                }
            }
            #endregion
            
            #region 31
            int[] B = { 2, 4, 6, 7, 5 };
            int rows = 5, columns = 8;
            int[,] A = new int[rows, columns];
            Random randomizer = new Random();
            Console.Write("\n\nYour matrix:");
            for (int i = 0; i < rows; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < columns - 1; j++)
                {
                    A[i, j] = randomizer.Next(-100, 100);
                    Console.Write($"{A[i, j],5}");
                }

                for (int j = columns - 1; j < columns; j++)                
                    Console.Write($"{A[i, j],5}");                
            }
            Console.WriteLine();

            int row_5th = 4;
            int min = A[row_5th, 0];
            int min_index = 0;
            //находим индекс стобца с минимальным элементом в 5 строке
            for (int i = 1; i < A.GetLength(1); i++)
            {
                if (A[row_5th, i] < min)
                {
                    min = A[row_5th, i];
                    min_index = i;
                }
            }

            //сдвиг всех стобцов до стобца с минимальным значением вправо
            if (min_index != A.GetLength(1))
                for (int column_index = A.GetLength(1) - 1; column_index > min_index; column_index--)
                    for (int row_index = 0; row_index < A.GetLength(0); row_index++)
                        A[row_index, column_index] = A[row_index, column_index - 1];

            //помещения вектора В после столбца с минимальным значением в пятой строке
            for (int row_index = 0; row_index < A.GetLength(0); row_index++)
                A[row_index, min_index + 1] = B[row_index];
            ShowMatrix(A);
            #endregion
            */


            //Part 2
            /*
            #region 7
            int[,] A = CreateMatrix(6, 6);
            int max = A[0, 0];
            int max_index = 0;
            for (int i = 1; i < A.GetLength(0); i++)
                if (A[i, i] > max)
                {
                    max = A[i, i];
                    max_index = i;
                }
            
            int count = 0;
            for (int row_index = 0; row_index < max_index; row_index++)
            {
                for (int column_index = 1 + count; column_index < A.GetLength(1); column_index++)
                    A[row_index, column_index] = 0;
                count++;
            }
            ShowMatrix(A);
            #endregion
            
            #region 8
            int[,] B = CreateMatrix(6, 6);
            int max, max_index_1st, max_index_2nd, intermediate_value;
            for (int row_index = 0; row_index < B.GetLength(0); row_index += 2)
            {
                //поиск индекса максимального элемента в первой строке
                max = B[row_index, 0];
                max_index_1st = 0;                
                for (int column_index = 0; column_index < B.GetLength(1); column_index++)                
                    if (B[row_index, column_index] > max)
                    {
                        max = B[row_index, column_index];
                        max_index_1st = column_index;
                    }                                    

                //поиск индекса максимального элемента во второй строке
                max = B[row_index + 1, 0];
                max_index_2nd = 0;                         
                for (int column_index = 0; column_index < B.GetLength(1); column_index++)                
                    if (B[row_index + 1, column_index] > max)
                    {
                        max = B[row_index + 1, column_index];
                        max_index_2nd = column_index;
                    }                                    

                //замена значений
                intermediate_value = B[row_index, max_index_1st];
                B[row_index, max_index_1st] = B[row_index + 1, max_index_2nd];
                B[row_index + 1, max_index_2nd] = intermediate_value;
            }
            ShowMatrix(B);
            #endregion
            
            #region 9
            int[,] A = CreateMatrix(6,7);
            int columns = A.GetLength(1) - 1;            
            int len = A.GetLength(1) / 2;
            int intermediate_value;
            for (int row_index = 0; row_index < A.GetLength(0); row_index++)            
                for (int column_index = 0; column_index < len; column_index++)
                {
                    intermediate_value = A[row_index, column_index];
                    A[row_index, column_index] = A[row_index,columns - column_index];
                    A[row_index, columns - column_index] = intermediate_value;
                }
            ShowMatrix(A);
            #endregion
            */
            
            
            //Part 3
            /*
            #region 1
            int[,] matrix = CreateMatrix(7, 5);
            var dict = new Dictionary<int, int>();            
            for (int row_index = 0; row_index < matrix.GetLength(0); row_index++)
            {
                int local_min = Int32.MaxValue;
                for (int column_index = 0; column_index < matrix.GetLength(1); column_index++)                
                    if (matrix[row_index, column_index] < local_min)                    
                        local_min = matrix[row_index, column_index];

                dict.Add(row_index, local_min);
            }
            
            int[] row_indexes = new int[matrix.GetLength(0)];
            for (int i = 0; i < row_indexes.Length; i++)
            {
                int max = dict.Values.Max();
                row_indexes[i] = dict.FirstOrDefault(x => x.Value == max).Key;
                dict.Remove(row_indexes[i]);
            }

            int row_index1;
            int[,] tempArray = new int[matrix.GetLength(0), matrix.GetLength(1)];
            for (int row_index = 0; row_index < matrix.GetLength(0); row_index++)
            {
                row_index1 = row_indexes[row_index];
                for (int column_index = 0; column_index < matrix.GetLength(1); column_index++)
                    tempArray[row_index, column_index] = matrix[row_index1, column_index];
            }

            for (int row_index = 0; row_index < matrix.GetLength(0); row_index++)            
                for (int column_index = 0; column_index < matrix.GetLength(1); column_index++)                
                    matrix[row_index, column_index] = tempArray[row_index, column_index];

            ShowMatrix(matrix);
            foreach (int el in row_indexes)
                Console.WriteLine(el);
            #endregion
            
            #region 2
            int[,] matrix = CreateMatrix(6, 6);
            for (int row_index = 0; row_index < matrix.GetLength(0); row_index += matrix.GetLength(0) - 1)
                for (int column_index = 0; column_index < matrix.GetLength(1); column_index++) //+= matrix.GetLength(1) - 1)
                {
                    matrix[row_index, column_index] = 0;
                    matrix[column_index, row_index] = 0;
                }
            ShowMatrix(matrix);
            #endregion
            
            #region 3
            int n = 3;
            int[,] matrix = CreateMatrix(n, n);
            int amount = 0;
            for (int index = 0; index < matrix.GetLength(1); index++)
            {
                amount += matrix[index, index];
                if (index != matrix.GetLength(1) - 1)
                    amount += matrix[index, index + 1] + matrix[index + 1, index];
            }
            Console.WriteLine(amount);
            #endregion
            
            #region 4
            int n = 15;
            int lenght = n / 2;
            //if (n % 2 != 0)
                //lenght--;
            int[,] matrix = CreateMatrix(n, n);
            for (int row_index = lenght; row_index < matrix.GetLength(0); row_index++)
                for (int column_index = 0; column_index < matrix.GetLength(1); column_index++)                
                    if (column_index <= row_index)
                        matrix[row_index, column_index] = 1;                
            ShowMatrix(matrix);
            #endregion                      

            #region 8
            int[,] matrix = CreateMatrix(7, 5);
            var dict = new Dictionary<int, int>();
            int positive_amount;
            for (int row_index = 0; row_index < matrix.GetLength(0); row_index++)
            {
                positive_amount = 0;
                for (int column_index = 0; column_index < matrix.GetLength(1); column_index++)
                    if (matrix[row_index, column_index] > 0)
                        positive_amount++;

                dict.Add(row_index, positive_amount);
            }

            int[] row_indexes = new int[matrix.GetLength(0)];
            for (int i = 0; i < row_indexes.Length; i++)
            {
                int max = dict.Values.Max();
                row_indexes[i] = dict.FirstOrDefault(x => x.Value == max).Key;
                dict.Remove(row_indexes[i]);
            }

            int row_index1;
            int[,] tempArray = new int[matrix.GetLength(0), matrix.GetLength(1)];
            for (int row_index = 0; row_index < matrix.GetLength(0); row_index++)
            {
                row_index1 = row_indexes[row_index];
                for (int column_index = 0; column_index < matrix.GetLength(1); column_index++)
                    tempArray[row_index, column_index] = matrix[row_index1, column_index];
            }

            for (int row_index = 0; row_index < matrix.GetLength(0); row_index++)
                for (int column_index = 0; column_index < matrix.GetLength(1); column_index++)
                    matrix[row_index, column_index] = tempArray[row_index, column_index];

            ShowMatrix(matrix);
            #endregion
            */
            #region 10
            int[,] matrix = CreateMatrix(5, 5);
            int count = 0;
            if (matrix.GetLength(1) % 2 != 0)
                count++; 
            int[,] chet_matrix = new int [matrix.GetLength(0), matrix.GetLength(1) / 2 + count];

            //забираем чётные индексы
            for (int row_index = 0; row_index < chet_matrix.GetLength(0); row_index++)
            {
                count = 0;
                for (int column_index = 0; column_index < chet_matrix.GetLength(1); column_index++)
                {
                    chet_matrix[row_index, column_index] = matrix[row_index, count];
                    count += 2;
                }                
            }

            int[,] nechet_matrix = new int[matrix.GetLength(0), matrix.GetLength(1) / 2];
            //забираем нечётные индексы
            for (int row_index = 0; row_index < nechet_matrix.GetLength(0); row_index++)
            {
                count = 1;
                for (int column_index = 0; column_index < nechet_matrix.GetLength(1); column_index++)
                {
                    nechet_matrix[row_index, column_index] = matrix[row_index, count];
                    count += 2;
                }
            }


            //упорядочеваем нечётные индексы по возрастанию
            chet_matrix = SortDown(nechet_matrix);
            nechet_matrix = SortUp(nechet_matrix);
            for (int row_index = 0; row_index < matrix.GetLength(0); row_index++)            
                for (int column_index = 0; column_index < matrix.GetLength(1) - 1; column_index++)
                {
                    matrix[row_index, colomn_index] = chet_matrix[row_index, colomn_index]
                    matrix[row_index, colomn_index + 1] = nechet_matrix[row_index, colomn_index]
                }
            ShowMatrix(nechet_matrix);
            Console.WriteLine($"{nechet_matrix.GetLength(0)}, {nechet_matrix.GetLength(1)}");
            #endregion

            #endregion
            /*
            #region 11
            int[,] matrix = CreateMatrix(7, 6);
            //matrix[1, 2] = 0;
            //matrix[2, 2] = 0;
            //matrix[3, 4] = 0;
            //matrix[5, 0] = 0;
            ShowMatrix(matrix);
            for (int row_index = matrix.GetLength(0) - 1; row_index > 0; row_index--)
                for (int column_index = 0; column_index < matrix.GetLength(1); column_index++)
                {
                    if (matrix[row_index, column_index] == 0)
                    {
                        for (int row_index1 = row_index; row_index1 < matrix.GetLength(0) - 1; row_index1++)
                            for (int column_index1 = 0; column_index1 < matrix.GetLength(1); column_index1++)
                                matrix[row_index1, column_index1] = matrix[row_index1 + 1, column_index1];
                        int row_index2 = matrix.GetLength(0) - 1;
                        for (int column_index2 = 0; column_index2 < matrix.GetLength(1); column_index2++)
                            matrix[row_index2, column_index2] = 0;
                    }
                }
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                Console.WriteLine();
                for (int j = 0; j < matrix.GetLength(1) - 1; j++)
                {
                    Console.Write($"{matrix[i, j],5}");
                }
            }
            #endregion
            */
