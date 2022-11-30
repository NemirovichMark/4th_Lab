using System;
using System.Collections.Generic;

namespace Lab_4
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Level I
            Console.WriteLine("---- Level I -------------------------------\n");

            #region Task  3
            Console.WriteLine("Task 3:\n");

            int[,] matrix = new int[4, 4]
            {
                { 2, 8, 16, 5 },
                { 3, 19, 0, 7 },
                { 1, 8, 11, 3 },
                { 5, -7, 12, -9 }
            };

            int sum = 0;

            // Initial matrix
            Console.WriteLine("Initial matrix: ");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                    Console.Write("{0,-5}", matrix[i, j]);
                Console.WriteLine();
            }

            // Finding sum
            for (int i = 0; i < matrix.GetLength(0); i++)
                sum += matrix[i, i];

            Console.WriteLine($"\nSum: {sum}");

            #endregion

            #region Task 6
            Console.WriteLine("\nTask 6:\n");

            Random random = new Random();
            matrix = new int[4, 7];
            int[] result = new int[matrix.GetLength(0)];

            int min = 0;

            // Initialize matrix
            Console.WriteLine("Initial matrix: ");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = random.Next(-20, 21);
                    Console.Write("{0, -5}", matrix[i, j]);
                }

                Console.WriteLine();
            }

            // Form an array of mins from each of matrix rows
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                min = matrix[i, 0];
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] < min)
                        min = matrix[i, j];
                }

                result[i] = min;
            }

            Console.Write("\nMinimums: ");
            foreach (var num in result)
                Console.Write($"{num} ");
            Console.WriteLine();
            #endregion

            #region Task 12
            Console.WriteLine("\nTask 12:\n");
            int rows = 4;
            int columns = 4;
            matrix = new int[rows, columns];

            // Initialize matrix
            Console.WriteLine("Initial matrix: ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = random.Next(-20, 21);
                    Console.Write("{0, -5}", matrix[i, j]);
                }

                Console.WriteLine();
            }

            // Find maximum
            int max = matrix[0, 0];
            int imax = 0;
            int jmax = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (matrix[i, j] > max)
                    {
                        max = matrix[i, j];
                        imax = i;
                        jmax = j;
                    }
                }
            }

            // Delete row
            for (int i = imax; i < rows - 1; i++)
            {
                for (int j = 0; j < columns; j++)
                    matrix[i, j] = matrix[i + 1, j];
            }

            rows--;

            // Delete columns
            for (int j = jmax; j < columns - 1; j++)
            {
                for (int i = 0; i < rows; i++)
                    matrix[i, j] = matrix[i, j + 1];
            }

            columns--;

            // Write result
            Console.WriteLine();
            Console.WriteLine("Result matrix:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                    Console.Write("{0, -5}", matrix[i, j]);
                Console.WriteLine();
            }

            #endregion

            #region Task 13
            Console.WriteLine("\nTask 13:\n");

            matrix = new int[5, 5];

            // Initialize matrix
            Console.WriteLine("Initial matrix: ");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = random.Next(-20, 21);
                    Console.Write("{0, -5}", matrix[i, j]);
                }

                Console.WriteLine();
            }

            // Find maximum
            max = matrix[0, 0];
            jmax = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                if (max < matrix[i, i])
                {
                    max = matrix[i, i];
                    jmax = i;
                }
            }

            // Swap columns
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int swap = matrix[i, 3];
                matrix[i, 3] = matrix[i, jmax];
                matrix[i, jmax] = swap;
            }

            // Write answer
            Console.WriteLine();
            Console.WriteLine("Result:");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                    Console.Write("{0, -5}", matrix[i, j]);
                Console.WriteLine();
            }
            #endregion

            #region Task 17
            Console.WriteLine("\nTask 17:\n");

            min = 0;
            int jmin = 0;

            Console.Write("Enter rows count: ");
            if (!int.TryParse(Console.ReadLine(), out rows))
            {
                Console.WriteLine("Value has an incorrect format!");
                return;
            }
            else if (rows < 1)
            {
                Console.WriteLine("There must be at least one row");
                return;
            }

            Console.Write("Enter columns count: ");
            if (!int.TryParse(Console.ReadLine(), out columns))
            {
                Console.WriteLine("Value has an incorrect format!");
                return;
            }
            else if (columns < 1)
            {
                Console.WriteLine("There must be at least one column");
                return;
            }

            Console.WriteLine();

            matrix = new int[rows, columns];

            // Initialize matrix
            Console.WriteLine("Initial matrix: ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = random.Next(-20, 21);
                    Console.Write("{0, -5}", matrix[i, j]);
                }

                Console.WriteLine();
            }

            // Perform swap
            for (int i = 0; i < rows; i++)
            {
                min = matrix[i, 0];
                jmin = 0;

                // Find minimum in current row
                for (int j = 0; j < columns; j++)
                {
                    if (matrix[i, j] < min)
                    {
                        min = matrix[i, j];
                        jmin = j;
                    }
                }

                // Shift elements to the right
                for (int j = jmin; j > 0; j--)
                    matrix[i, j] = matrix[i, j - 1];

                // Put min element to beginnig of current row
                matrix[i, 0] = min;
            }

            // Write answer
            Console.WriteLine();
            Console.WriteLine("Result:");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                    Console.Write("{0, -5}", matrix[i, j]);
                Console.WriteLine();
            }
            #endregion

            #region Task 29
            Console.WriteLine("\nTask 29:\n");

            rows = 5;
            columns = 7;

            matrix = new int[rows, columns];

            // Initialize matrix
            Console.WriteLine("Initial matrix: ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = random.Next(-20, 21);
                    Console.Write("{0, -5}", matrix[i, j]);
                }

                Console.WriteLine();
            }

            Console.WriteLine();

            // Find abs minimum of 2 row
            min = Math.Abs(matrix[1, 0]);
            jmin = 0;

            for (int j = 1; j < matrix.GetLength(1); j++)
            {
                int absValue = Math.Abs(matrix[1, j]);
                if (absValue < min)
                {
                    min = absValue;
                    jmin = j;
                }
            }

            // Delete column after min index
            for (int j = jmin + 1; j < columns - 1; j++)
            {
                for (int i = 0; i < rows; i++)
                    matrix[i, j] = matrix[i, j + 1];
            }

            columns--;

            // Write answer
            Console.WriteLine();
            Console.WriteLine("Result:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                    Console.Write("{0, -5}", matrix[i, j]);
                Console.WriteLine();
            }
            #endregion

            #region Task 31
            Console.WriteLine("\nTask 31:\n");

            rows = 5;
            columns = 8;

            matrix = new int[rows, columns];
            int[] vector = new int[5] { 188, 188, 188, 188, 188 };

            // Initialize matrix
            Console.WriteLine("Initial matrix: ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns - 1; j++)
                {
                    matrix[i, j] = random.Next(-20, 21);
                    Console.Write("{0, -5}", matrix[i, j]);
                }

                Console.Write("{0, -5}", "( )");
                Console.WriteLine();
            }

            Console.WriteLine();

            // Find min of 5 row
            min = matrix[4, 0];
            jmin = 0;

            for (int j = 1; j < columns - 1; j++)
            {
                if (matrix[4, j] < min)
                {
                    min = matrix[4, j];
                    jmin = j;
                }
            }

            // Shift elements
            for (int j = columns - 1; j > jmin; j--)
            {
                for (int i = 0; i < rows; i++)
                    matrix[i, j] = matrix[i, j - 1];
            }

            // Put vector into matrix
            for (int i = 0; i < rows; i++)
                matrix[i, jmin + 1] = vector[i];


            // Write answer
            Console.WriteLine();
            Console.WriteLine("Result:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                    Console.Write("{0, -5}", matrix[i, j]);
                Console.WriteLine();
            }
            #endregion

            #endregion

            #region Level II
            Console.WriteLine("\n---- Level II -------------------------------\n");

            #region Task 7
            Console.WriteLine("\nTask 7:\n");

            rows = 6;
            columns = 6;

            matrix = new int[rows, columns];

            // Initialize matrix
            Console.WriteLine("Initial matrix: ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = random.Next(-20, 21);
                    Console.Write("{0, -5}", matrix[i, j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            // Find max
            max = matrix[0, 0];
            imax = 0;

            for (int i = 1; i < rows; i++)
            {
                if (matrix[i, i] > max)
                {
                    max = matrix[i, i];
                    imax = i;
                }
            }

            // Put zeros
            for (int i = imax - 1; i >= 0; i--)
            {
                for (int j = i + 1; j < columns; j++)
                    matrix[i, j] = 0;
            }

            // Write answer
            Console.WriteLine();
            Console.WriteLine("Result:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                    Console.Write("{0, -5}", matrix[i, j]);
                Console.WriteLine();
            }
            #endregion

            #region Task 8
            Console.WriteLine("\nTask 8:\n");

            rows = 6;
            columns = 6;

            matrix = new int[rows, columns];

            // Initialize matrix
            Console.WriteLine("Initial matrix: ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = random.Next(-20, 21);
                    Console.Write("{0, -5}", matrix[i, j]);
                }
                Console.WriteLine();
            }

            // Find max
            int previousMax = 0;
            int previousMaxIndex = 0;

            for (int i = 0; i < rows; i++)
            {
                max = matrix[i, 0];
                jmax = 0;

                // Find max in current row
                for (int j = 0; j < columns; j++)
                {
                    if (max < matrix[i, j])
                    {
                        max = matrix[i, j];
                        jmax = j;
                    }
                }

                if ((i + 1) % 2 != 0)
                {
                    previousMax = max;
                    previousMaxIndex = jmax;
                }
                else
                {
                    int swap = matrix[i, jmax];
                    matrix[i, jmax] = previousMax;
                    matrix[i - 1, previousMaxIndex] = swap;
                }
            }

            // Write answer
            Console.WriteLine();
            Console.WriteLine("Result:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                    Console.Write("{0, -5}", matrix[i, j]);
                Console.WriteLine();
            }
            #endregion

            #region Task 9
            Console.WriteLine("\nTask 9:\n");

            rows = 6;
            columns = 6;

            matrix = new int[rows, columns];

            // Initialize matrix
            Console.WriteLine("Initial matrix: ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = random.Next(-20, 21);
                    Console.Write("{0, -5}", matrix[i, j]);
                }
                Console.WriteLine();
            }

            // Invert elements in each row
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns / 2; j++)
                {
                    int swap = matrix[i, columns - (j + 1)];
                    matrix[i, columns - (j + 1)] = matrix[i, j];
                    matrix[i, j] = swap;
                }
            }

            // Write answer
            Console.WriteLine();
            Console.WriteLine("Result:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                    Console.Write("{0, -5}", matrix[i, j]);
                Console.WriteLine();
            }
            #endregion

            #endregion

            #region Level III
            Console.WriteLine("\n---- Level III -------------------------------\n");

            #region Task 1A
            Console.WriteLine("\nTask 1A:\n");

            rows = 7;
            columns = 5;

            matrix = new int[rows, columns];

            // Initialize matrix
            Console.WriteLine("Initial matrix: ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = random.Next(-20, 21);
                    Console.Write("{0, -5}", matrix[i, j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            // Find mins of each row
            int[] rowsMinimums = new int[rows];

            for (int i = 0; i < rows; i++)
            {
                min = matrix[i, 0];
                for (int j = 1; j < columns; j++)
                {
                    if (matrix[i, j] < min)
                        min = matrix[i, j];
                }

                rowsMinimums[i] = min;
            }

            // Sort rows
            int sortIndex = 1;
            while (sortIndex < rowsMinimums.Length)
            {
                if (sortIndex == 0 || rowsMinimums[sortIndex] <= rowsMinimums[sortIndex - 1])
                {
                    sortIndex++;
                }
                else
                {
                    // Swap elements in array
                    int swap = rowsMinimums[sortIndex - 1];
                    rowsMinimums[sortIndex - 1] = rowsMinimums[sortIndex];
                    rowsMinimums[sortIndex] = swap;

                    // Swap rows in matrix
                    for (int j = 0; j < columns; j++)
                    {
                        swap = matrix[sortIndex - 1, j];
                        matrix[sortIndex - 1, j] = matrix[sortIndex, j];
                        matrix[sortIndex, j] = swap;
                    }

                    sortIndex--;
                }
            }

            // Write answer
            Console.WriteLine();
            Console.WriteLine("Result:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                    Console.Write("{0, -5}", matrix[i, j]);
                Console.WriteLine();
            }
            #endregion

            #region Task 1B
            Console.WriteLine("\nTask 1B:\n");

            rows = 7;
            columns = 5;

            int[] oneDimensionalMatrix = new int[rows * columns];

            // Initialize matrix
            Console.WriteLine("Initial matrix: ");
            for (int i = 0; i < oneDimensionalMatrix.Length; i++)
            {
                oneDimensionalMatrix[i] = random.Next(-20, 21);
                Console.Write("{0, -5}", oneDimensionalMatrix[i]);

                if ((i + 1) % columns == 0)
                    Console.WriteLine();
            }

            Console.WriteLine();

            // Find mins of each row
            rowsMinimums = new int[rows];

            min = oneDimensionalMatrix[0];
            int imin = 0;
            for (int i = 1; i < oneDimensionalMatrix.Length; i++)
            {
                if (oneDimensionalMatrix[i] < min)
                    min = oneDimensionalMatrix[i];

                if ((i + 1) % columns == 0)
                {
                    rowsMinimums[imin] = min;
                    min = oneDimensionalMatrix[i];
                    imin++;
                }
            }

            // Sort rows
            int offset = 0;
            sortIndex = 1;
            while (sortIndex < rowsMinimums.Length)
            {
                if (sortIndex == 0 || rowsMinimums[sortIndex] <= rowsMinimums[sortIndex - 1])
                {
                    sortIndex++;
                }
                else
                {
                    // Swap elements in array
                    int swap = rowsMinimums[sortIndex - 1];
                    rowsMinimums[sortIndex - 1] = rowsMinimums[sortIndex];
                    rowsMinimums[sortIndex] = swap;

                    int previousRowIndex = (sortIndex - 1) * columns;
                    int currentRowIndex = sortIndex * columns;

                    // Swap rows in matrix
                    for (offset = 0; offset < columns; offset++)
                    {
                        int previousIndex = previousRowIndex + offset;
                        int currentIndex = currentRowIndex + offset;

                        swap = oneDimensionalMatrix[previousIndex];
                        oneDimensionalMatrix[previousIndex] = oneDimensionalMatrix[currentIndex];
                        oneDimensionalMatrix[currentIndex] = swap;
                    }

                    sortIndex--;
                }
            }

            // Write answer
            Console.WriteLine();
            Console.WriteLine("Result:");
            for (int i = 0; i < oneDimensionalMatrix.Length; i++)
            {
                Console.Write("{0, -5}", oneDimensionalMatrix[i]);

                if ((i + 1) % columns == 0)
                    Console.WriteLine();
            }
            #endregion

            #region Task 2A
            Console.WriteLine("\nTask 2A:\n");

            rows = 8;
            columns = 8;

            matrix = new int[rows, columns];

            // Initialize matrix
            Console.WriteLine("Initial matrix: ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = random.Next(-20, 21);
                    Console.Write("{0, -5}", matrix[i, j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            // Fill perimeter with zeros
            for (int i = 0; i < columns; i++)
            {
                matrix[0, i] = 0;
                matrix[i, 0] = 0;

                matrix[columns - 1, i] = 0;
                matrix[i, columns - 1] = 0;
            }

            // Write answer
            Console.WriteLine();
            Console.WriteLine("Result:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                    Console.Write("{0, -5}", matrix[i, j]);
                Console.WriteLine();
            }
            #endregion

            #region Task 2B
            Console.WriteLine("\nTask 2B:\n");

            rows = 8;
            columns = 8;

            oneDimensionalMatrix = new int[rows * columns];

            // Initialize matrix
            Console.WriteLine("Initial matrix: ");
            for (int i = 0; i < oneDimensionalMatrix.Length; i++)
            {
                oneDimensionalMatrix[i] = random.Next(-20, 21);
                Console.Write("{0, -5}", oneDimensionalMatrix[i]);

                if ((i + 1) % columns == 0)
                    Console.WriteLine();
            }

            Console.WriteLine();

            // Fill perimeter with zeros
            for (int i = 0; i < columns; i++)
            {
                oneDimensionalMatrix[i] = 0;
                oneDimensionalMatrix[i + columns * (columns - 1)] = 0;

                oneDimensionalMatrix[i * columns] = 0;
                oneDimensionalMatrix[i * columns + columns - 1] = 0;
            }

            // Write answer
            Console.WriteLine();
            Console.WriteLine("Result:");
            for (int i = 0; i < oneDimensionalMatrix.Length; i++)
            {
                Console.Write("{0, -5}", oneDimensionalMatrix[i]);

                if ((i + 1) % columns == 0)
                    Console.WriteLine();
            }
            #endregion

            #region Task 3A
            Console.WriteLine("\nTask 3A:\n");

            rows = 5;
            columns = 5;

            matrix = new int[rows, columns];

            // Initialize matrix
            Console.WriteLine("Initial matrix: ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = random.Next(-20, 21);
                    Console.Write("{0, -5}", matrix[i, j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            // Summarize diagonal elements
            int[] diagonalSums = new int[2 * columns - 1];
            int mirrorSum;

            offset = 0;
            int middleIndex = diagonalSums.Length / 2;

            while (offset < columns)
            {
                sum = 0;
                mirrorSum = 0;

                for (int j = 0; j < columns - offset; j++)
                {
                    if (offset == 0)
                        sum += matrix[j, j];
                    else
                    {
                        sum += matrix[j + offset, j];
                        mirrorSum += matrix[j, j + offset];
                    }
                }

                diagonalSums[middleIndex + offset] = sum;
                if (offset != 0)
                    diagonalSums[middleIndex - offset] = mirrorSum;

                offset++;
            }

            // Write answer
            Console.WriteLine();
            Console.WriteLine("Diagonals sums:");

            offset = diagonalSums.Length;
            foreach (var num in diagonalSums)
            {
                for (int i = 0; i < offset - 1; i++)
                    Console.Write("{0,-4}", " ");
                Console.WriteLine(num);
                offset--;
            }
            Console.WriteLine();
            #endregion

            #region Task 3B
            Console.WriteLine("\nTask 3B:\n");

            rows = 5;
            columns = 5;

            oneDimensionalMatrix = new int[rows * columns];

            // Initialize matrix
            Console.WriteLine("Initial matrix: ");
            for (int i = 0; i < oneDimensionalMatrix.Length; i++)
            {
                oneDimensionalMatrix[i] = random.Next(-20, 21);
                Console.Write("{0, -5}", oneDimensionalMatrix[i]);

                if ((i + 1) % columns == 0)
                    Console.WriteLine();
            }

            Console.WriteLine();

            // Summarize diagonal elements
            diagonalSums = new int[2 * columns - 1];

            offset = 0;
            middleIndex = diagonalSums.Length / 2;

            while (offset < columns)
            {
                sum = 0;
                mirrorSum = 0;

                for (int j = 0; j < columns - offset; j++)
                {
                    int elementIndex = j * (columns + 1);

                    sum += oneDimensionalMatrix[elementIndex + offset];
                    if (offset != 0)
                        mirrorSum += oneDimensionalMatrix[elementIndex + offset * columns];
                }

                diagonalSums[middleIndex - offset] = sum;
                if (offset != 0)
                    diagonalSums[middleIndex + offset] = mirrorSum;

                offset++;
            }

            // Write answer
            Console.WriteLine();
            Console.WriteLine("Diagonals sums:");

            offset = diagonalSums.Length;
            foreach (var num in diagonalSums)
            {
                for (int i = 0; i < offset - 1; i++)
                    Console.Write("{0,-4}", " ");
                Console.WriteLine(num);
                offset--;
            }
            Console.WriteLine();
            #endregion

            #region Task 4A
            Console.WriteLine("\nTask 4A:\n");

            rows = 7;
            columns = 7;

            matrix = new int[rows, columns];

            // Initialize matrix
            Console.WriteLine("Initial matrix: ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = random.Next(-20, 21);
                    Console.Write("{0, -5}", matrix[i, j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            // Fill matrix
            for (int i = rows / 2; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (i == j) break;
                    matrix[i, j] = 1;
                }
            }

            // Write answer
            Console.WriteLine();
            Console.WriteLine("Result:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                    Console.Write("{0, -5}", matrix[i, j]);
                Console.WriteLine();
            }
            #endregion

            #region Task 4B
            Console.WriteLine("\nTask 4B:\n");

            rows = 5;
            columns = 5;

            oneDimensionalMatrix = new int[rows * columns];

            // Initialize matrix
            Console.WriteLine("Initial matrix: ");
            for (int i = 0; i < oneDimensionalMatrix.Length; i++)
            {
                oneDimensionalMatrix[i] = random.Next(-20, 21);
                Console.Write("{0, -5}", oneDimensionalMatrix[i]);

                if ((i + 1) % columns == 0)
                    Console.WriteLine();
            }

            Console.WriteLine();

            int length = oneDimensionalMatrix.Length;
            int skip = columns / 2 + 1;

            // Fill matrix
            for (int i = (length - rows) / 2; i < rows * columns;)
            {
                if (i % (rows + 1) == 0)
                {
                    i += skip;
                    skip--;
                    continue;
                }

                oneDimensionalMatrix[i] = 1;
                i++;
            }

            // Write answer
            Console.WriteLine();
            Console.WriteLine("Result:");
            for (int i = 0; i < oneDimensionalMatrix.Length; i++)
            {
                Console.Write("{0, -5}", oneDimensionalMatrix[i]);

                if ((i + 1) % columns == 0)
                    Console.WriteLine();
            }
            #endregion

            #region Task 8A
            Console.WriteLine("\nTask 8A:\n");

            rows = 7;
            columns = 5;

            matrix = new int[rows, columns];

            // Initialize matrix
            Console.WriteLine("Initial matrix: ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = random.Next(-20, 21);
                    Console.Write("{0, -5}", matrix[i, j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            // Count positive elements in each row

            int[] positiveElementsCount = new int[rows];
            int count = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (matrix[i, j] > 0)
                        count++;
                }

                positiveElementsCount[i] = count;
            }

            // Sort rows
            sortIndex = 1;
            while (sortIndex < positiveElementsCount.Length)
            {
                if (sortIndex == 0 ||
                    positiveElementsCount[sortIndex - 1] >= positiveElementsCount[sortIndex])
                {
                    sortIndex++;
                }
                else
                {
                    // Swap elements in array
                    int swap = positiveElementsCount[sortIndex];
                    positiveElementsCount[sortIndex] = positiveElementsCount[sortIndex - 1];
                    positiveElementsCount[sortIndex - 1] = swap;

                    // Swap rows in matrix
                    for (int j = 0; j < columns; j++)
                    {
                        swap = matrix[sortIndex - 1, j];
                        matrix[sortIndex - 1, j] = matrix[sortIndex, j];
                        matrix[sortIndex, j] = swap;
                    }

                    sortIndex--;
                }
            }

            // Write answer
            Console.WriteLine();
            Console.WriteLine("Result:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                    Console.Write("{0, -5}", matrix[i, j]);
                Console.WriteLine();
            }
            #endregion

            #region Task 8B
            Console.WriteLine("\nTask 8B:\n");

            rows = 7;
            columns = 5;

            oneDimensionalMatrix = new int[rows * columns];

            // Initialize matrix
            Console.WriteLine("Initial matrix: ");
            for (int i = 0; i < oneDimensionalMatrix.Length; i++)
            {
                oneDimensionalMatrix[i] = random.Next(-20, 21);
                Console.Write("{0, -5}", oneDimensionalMatrix[i]);

                if ((i + 1) % columns == 0)
                    Console.WriteLine();
            }

            Console.WriteLine();

            // Count positive elements in each row
            positiveElementsCount = new int[rows];
            int index = 0;
            count = 0;

            for (int i = 1; i < oneDimensionalMatrix.Length; i++)
            {
                if (oneDimensionalMatrix[i] > 0)
                    count++;

                if ((i + 1) % columns == 0)
                {
                    positiveElementsCount[index] = count;
                    index++;
                    count = 0;
                }
            }

            // Sort rows
            sortIndex = 1;
            offset = 0;

            while (sortIndex < positiveElementsCount.Length)
            {
                if (sortIndex == 0 ||
                    positiveElementsCount[sortIndex - 1] >= positiveElementsCount[sortIndex])
                {
                    sortIndex++;
                }
                else
                {
                    // Swap elements in array
                    int swap = positiveElementsCount[sortIndex];
                    positiveElementsCount[sortIndex] = positiveElementsCount[sortIndex - 1];
                    positiveElementsCount[sortIndex - 1] = swap;

                    int previousRowIndex = (sortIndex - 1) * columns;
                    int currentRowIndex = sortIndex * columns;

                    // Swap rows in matrix
                    for (offset = 0; offset < columns; offset++)
                    {
                        int previousIndex = previousRowIndex + offset;
                        int currentIndex = currentRowIndex + offset;

                        swap = oneDimensionalMatrix[previousIndex];
                        oneDimensionalMatrix[previousIndex] = oneDimensionalMatrix[currentIndex];
                        oneDimensionalMatrix[currentIndex] = swap;
                    }

                    sortIndex--;
                }
            }

            // Write answer
            Console.WriteLine();
            Console.WriteLine("Result:");
            for (int i = 0; i < oneDimensionalMatrix.Length; i++)
            {
                Console.Write("{0, -5}", oneDimensionalMatrix[i]);

                if ((i + 1) % columns == 0)
                    Console.WriteLine();
            }
            #endregion

            #region Task 10A
            Console.WriteLine("\nTask 10A:\n");

            rows = 7;
            columns = 5;

            matrix = new int[rows, columns];

            // Initialize matrix
            Console.WriteLine("Initial matrix: ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = random.Next(-20, 21);
                    Console.Write("{0, -5}", matrix[i, j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            // Sort each row
            for (int i = 0; i < rows; i++)
            {
                // If odd row
                if ((i + 1) % 2 != 0)
                {
                    sortIndex = 0;

                    while (sortIndex < columns)
                    {
                        if (sortIndex == 0 || matrix[i, sortIndex - 1] <= matrix[i, sortIndex])
                        {
                            sortIndex++;
                        }
                        else
                        {
                            int swap = matrix[i, sortIndex];
                            matrix[i, sortIndex] = matrix[i, sortIndex - 1];
                            matrix[i, sortIndex - 1] = swap;

                            sortIndex--;
                        }
                    }
                }
                // If even
                else
                {
                    sortIndex = 0;

                    while (sortIndex < columns)
                    {
                        if (sortIndex == 0 || matrix[i, sortIndex - 1] >= matrix[i, sortIndex])
                        {
                            sortIndex++;
                        }
                        else
                        {
                            int swap = matrix[i, sortIndex];
                            matrix[i, sortIndex] = matrix[i, sortIndex - 1];
                            matrix[i, sortIndex - 1] = swap;

                            sortIndex--;
                        }
                    }
                }
            }

            // Write answer
            Console.WriteLine();
            Console.WriteLine("Result:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                    Console.Write("{0, -5}", matrix[i, j]);
                Console.WriteLine();
            }
            #endregion

            #region Task 10B
            Console.WriteLine("\nTask 10B:\n");

            rows = 7;
            columns = 5;

            oneDimensionalMatrix = new int[rows * columns];

            // Initialize matrix
            Console.WriteLine("Initial matrix: ");
            for (int i = 0; i < oneDimensionalMatrix.Length; i++)
            {
                oneDimensionalMatrix[i] = random.Next(-20, 21);
                Console.Write("{0, -5}", oneDimensionalMatrix[i]);

                if ((i + 1) % columns == 0)
                    Console.WriteLine();
            }

            Console.WriteLine();

            for (int i = 0; i < oneDimensionalMatrix.Length; i += columns)
            {
                // If odd
                if ((i / columns + 1) % 2 != 0)
                {
                    sortIndex = i + 1;

                    while (sortIndex < i + columns)
                    {
                        if (sortIndex == i ||
                            oneDimensionalMatrix[sortIndex - 1] <= oneDimensionalMatrix[sortIndex])
                        {
                            sortIndex++;
                        }
                        else
                        {
                            // Swap elements in array
                            int swap = oneDimensionalMatrix[sortIndex];
                            oneDimensionalMatrix[sortIndex] = oneDimensionalMatrix[sortIndex - 1];
                            oneDimensionalMatrix[sortIndex - 1] = swap;

                            sortIndex--;
                        }
                    }
                }
                // If even
                else
                {
                    sortIndex = i + 1;

                    while (sortIndex < i + columns)
                    {
                        if (sortIndex == i ||
                            oneDimensionalMatrix[sortIndex - 1] >= oneDimensionalMatrix[sortIndex])
                        {
                            sortIndex++;
                        }
                        else
                        {
                            // Swap elements in array
                            int swap = oneDimensionalMatrix[sortIndex];
                            oneDimensionalMatrix[sortIndex] = oneDimensionalMatrix[sortIndex - 1];
                            oneDimensionalMatrix[sortIndex - 1] = swap;

                            sortIndex--;
                        }
                    }
                }
            }

            // Write answer
            Console.WriteLine();
            Console.WriteLine("Result:");
            for (int i = 0; i < oneDimensionalMatrix.Length; i++)
            {
                Console.Write("{0, -5}", oneDimensionalMatrix[i]);

                if ((i + 1) % columns == 0)
                    Console.WriteLine();
            }
            #endregion

            #region Task 11A
            Console.WriteLine("\nTask 11A:\n");

            rows = 7;
            columns = 5;

            matrix = new int[rows, columns];
            int[,] reducedMatrix = null;
            Queue<int> remainingRows = new Queue<int>();

            // Initialize matrix
            Console.WriteLine("Initial matrix: ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = random.Next(0, 9);
                    Console.Write("{0, -5}", matrix[i, j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            // Search for zero
            for (int i = 0; i < rows; i++)
            {
                bool keep = true;
                for (int j = 0; j < columns; j++)
                    keep = matrix[i, j] != 0;

                if (keep)
                    remainingRows.Enqueue(i);
            }

            // Initialize reduced matrix
            reducedMatrix = new int[remainingRows.Count, columns];

            // Fill with remaining rows
            index = 0;
            while (remainingRows.Count > 0)
            {
                int row = remainingRows.Dequeue();

                for (int j = 0; j < columns; j++)
                    reducedMatrix[index, j] = matrix[row, j];

                index++;    
            }

            // Write result
            Console.WriteLine();
            Console.WriteLine("Result matrix:");
            for (int i = 0; i < reducedMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < columns; j++)
                    Console.Write("{0, -5}", reducedMatrix[i, j]);
                Console.WriteLine();
            }
            #endregion

            #region Task 11B
            Console.WriteLine("\nTask 11B:\n");

            rows = 7;
            columns = 5;

            oneDimensionalMatrix = new int[rows * columns];

            // Initialize matrix
            Console.WriteLine("Initial matrix: ");
            for (int i = 0; i < oneDimensionalMatrix.Length; i++)
            {
                oneDimensionalMatrix[i] = random.Next(0, 9);
                Console.Write("{0, -5}", oneDimensionalMatrix[i]);

                if ((i + 1) % columns == 0)
                    Console.WriteLine();
            }
            Console.WriteLine();

            // Search for zero
            for (int i = 0; i <= rows * columns - columns; i += columns)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (oneDimensionalMatrix[i + j] == 0)
                    {
                        // Delete row
                        for (int currentRow = i; currentRow < rows * columns - columns; currentRow += columns)
                        {
                            for (j = 0; j < columns; j++)
                                oneDimensionalMatrix[currentRow + j] = oneDimensionalMatrix[currentRow + columns + j];
                        }

                        rows--;
                        i -= 5;
                        break;
                    }
                }
            }

            // Write answer
            Console.WriteLine();
            Console.WriteLine("Result:");
            for (int i = 0; i < rows * columns; i++)
            {
                Console.Write("{0, -5}", oneDimensionalMatrix[i]);

                if ((i + 1) % columns == 0)
                    Console.WriteLine();
            }
            #endregion

            #endregion
        }
    }
}
