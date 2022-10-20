using System;

namespace _4_Lab {
    class Program {
        static void Main(string[] args) {
            // Support Functions -------------

            static double[,] getMatrix(int rows = 1, int cols = 1) {
                double[,] matrix = new double[rows, cols];

                for (int i = 0; i < rows; i++) {
                    double[] row = getArray();

                    if (row == null) {
                        return null;
                    }
                    
                    if (row.Length != cols) {
                        Console.WriteLine($"Not {cols} elements in a row");
                        return null;
                    }

                    for (int j = 0; j < cols; j++) {
                        matrix[i, j] = row[j];
                    }
                }

                return matrix;
            }

            static double[,] getUnknownMatrix() {
                Console.WriteLine($"To complete the input of the matrix print empty line");

                bool firstRow = true;
                int rowSize = 0;

                double[][] preResult = new double[0][];
                int resSize = 0;


                while (true) {
                    string s = Console.ReadLine();

                    if (s == "") {
                        break;
                    }

                    string[] strNums = s.Trim().Split();

                    if (firstRow) {
                        rowSize = strNums.Length;
                        firstRow = false;
                    }

                    if (strNums.Length != rowSize) {
                        Console.WriteLine("Incorrect input. Different number of columns in rows");
                        return null;
                    }

                    double[] array = new double[rowSize];
                    for (int i = 0; i < rowSize; i++) {
                        if (!double.TryParse(strNums[i], out array[i])) {
                            Console.WriteLine("One of the elements isn`t a number");
                            return null;
                        }
                    }

                    Array.Resize(ref preResult, resSize + 1);
                    preResult[resSize] = array;
                    resSize++;
                }

                double[,] result = new double[resSize, rowSize];

                for (int i = 0; i < resSize; i++) {
                    for (int j = 0; j < rowSize; j++) {
                        result[i, j] = preResult[i][j];
                    }
                }

                return result;
            }

            static double[] getArray() {
                string[] strNums = Console.ReadLine().Trim().Split();
                double[] array = new double[strNums.Length];

                for (int i = 0; i < strNums.Length; i++) {
                    if (!double.TryParse(strNums[i], out array[i])) {
                        Console.WriteLine("One of the elements isn`t a number");
                        return null;
                    }
                    
                }

                return array;
            }

            static void printMatrix(double[,] matrix) {
                for (int i = 0; i < matrix.GetLength(0); i++) {
                    for (int j = 0; j < matrix.GetLength(1); j++) {
                        Console.Write(String.Format("{0} ", matrix[i, j]));
                    }
                    Console.WriteLine();
                }
            }

            static void printMatrixAnswer(string taskNum, double[,] matrix) {
                Console.WriteLine($"Task {taskNum} answer:");
                printMatrix(matrix);
            }

            static void printArrayAnswer(string taskNum, double[] array) {
                Console.WriteLine($"Task {taskNum} answer:");
                Console.WriteLine(String.Join(" ", array));
            }

            static void printDoubleAnswer(string taskNum, double num) {
                Console.WriteLine($"Task {taskNum} answer:\n{num}");
            }


            // Level 1 -----------------------

            static void task_1_3() {
                double[,] matrix = getMatrix(4, 4);
                double sum = 0;

                if (matrix == null) {
                    return;
                }

                for (int i = 0; i < 4; i++) {
                    sum += matrix[i, i];
                    sum += matrix[i, 4 - 1 - i];
                }

                printDoubleAnswer("1.3", sum);
            }

            static void task_1_6() {
                double[,] matrix = getMatrix(4, 7);
                double[] inds = new double[7];

                if (matrix == null) {
                    return;
                }

                double minElem;

                for (int i = 0; i < matrix.GetLength(1); i++) {
                    minElem = matrix[0, i];
                    for (int j = 0; j < matrix.GetLength(0); j++) {
                        if (matrix[j, i] < minElem) {
                            inds[i] = j;
                            minElem = matrix[j, i];
                        }
                    }
                }

                printArrayAnswer("1.6", inds);
            }

            static void task_1_12() {
                double[,] matrix = getMatrix(6, 7);
                int rowInd = 0, colInd = 0;
                double maxElem = matrix[0, 0];

                if (matrix == null) {
                    return;
                }

                for (int i = 0; i < matrix.GetLength(0); i++) {
                    for (int j = 0; j < matrix.GetLength(1); j++) {
                        if (matrix[i, j] > maxElem) {
                            maxElem = matrix[i, j];
                            rowInd = i;
                            colInd = j;
                        }
                    }
                }

                double[,] answerMatrix = new double[5, 6];
                int ansRowInd = 0, ansColInd = 0;
                for (int i = 0; i < matrix.GetLength(0); i++) {
                    if (i == rowInd) {
                        continue;
                    }

                    ansColInd = 0;
                    for (int j = 0; j < matrix.GetLength(1); j++) {
                        if (j != colInd) {
                            answerMatrix[ansRowInd, ansColInd] = matrix[i, j];
                            ansColInd++;
                        }
                    }

                    ansRowInd++;
                }

                printMatrixAnswer("1.12", answerMatrix);
            }

            static void task_1_13() {
                double[,] matrix = getMatrix(5, 5);
                int colInd = 0;
                double maxElem = matrix[0, 0];

                if (matrix == null) {
                    return;
                }

                for (int i = 0; i < matrix.GetLength(0); i++) {
                    if (matrix[i, i] > maxElem) {
                        maxElem = matrix[i, i];
                        colInd = i;
                    }

                    if (matrix[5 - 1 - i, i] > maxElem) {
                        maxElem = matrix[5 - 1 - i, i];
                        colInd = i;
                    }
                }


                for (int i = 0; i < matrix.GetLength(0); i++) {
                    double temp = matrix[i, colInd];
                    matrix[i, colInd] = matrix[i, 3];
                    matrix[i, 3] = temp;
                }

                printMatrixAnswer("1.13", matrix);

            }

            static void task_1_17() {
                string[] strNums = Console.ReadLine().Trim().Split();
                if (strNums.Length != 2) {
                    Console.WriteLine();
                    return;
                }
                if (!int.TryParse(strNums[0], out int n)) {
                    Console.WriteLine();
                    return;
                }
                if (!int.TryParse(strNums[1], out int m)) {
                    Console.WriteLine();
                    return;
                }

                double[,] matrix = getMatrix(n, m);
                double minElem;
                int minInd;

                if (matrix == null) {
                    return;
                }

                for (int i = 0; i < matrix.GetLength(0); i++) {
                    minElem = matrix[i, 0];
                    for (int j = 0; j < matrix.GetLength(1); j++) {
                        if (matrix[i, j] < minElem) {
                            minElem = matrix[i, j];
                        }
                    }
                    matrix[i, 0] = minElem;
                }

                printMatrixAnswer("1.17", matrix);
            }

            static void task_1_29() {
                double[,] matrix = getMatrix(5, 7);
                double minElem = matrix[1, 0];
                int colInd = 0;

                if (matrix == null) {
                    return;
                }

                for (int i = 0; i < matrix.GetLength(1); i++) {
                    if (Math.Abs(matrix[1, i]) < minElem) {
                        colInd = i;
                        minElem = Math.Abs(matrix[1, i]);
                    }
                }

                if (colInd == matrix.GetLength(1) - 1) {
                    printMatrixAnswer("1.29", matrix);
                }

                double[,] result = new double[5, 6];
                int curInd = 0;
                for (int i = 0; i < 5; i++) {
                    curInd = 0;
                    for (int j = 0; j < 7; j++) {
                        if (j == colInd + 1) {
                            continue;
                        }
                        result[i, curInd] = matrix[i, j];
                        curInd++;
                    }
                }

                printMatrixAnswer("1.29", result);
            }

            static void task_1_31() {
                double[,] matrix = getMatrix(5, 7);
                double[] array = getArray();
                double[,] answer = new double[5, 8];

                if (matrix == null) {
                    return;
                }

                int minInd = 0;
                double minElem = matrix[4, 0];

                for (int i = 0; i < 7; i++) {
                    if (matrix[4, i] < minElem) {
                        minElem = matrix[4, i];
                        minInd = i;
                    }
                }

                for (int i = 0; i < 5; i++) {
                    for (int j = 0; j < 7; j++) {
                        if (minInd < j) {
                            answer[i, j + 1] = matrix[i, j];
                        } else {
                            answer[i, j] = matrix[i, j];
                        }

                    }
                }

                for (int i = 0; i < 5; i++) {
                    answer[i, minInd + 1] = array[i];
                }

                printMatrixAnswer("1.31", answer);

            }


            // Level 2 -----------------------

            static void task_2_7() {
                double[,] matrix = getMatrix(6, 6);

                if (matrix == null) {
                    return;
                }

                int maxInd = 0;
                double maxElem = matrix[0, 0];

                for (int i = 0; i < 6; i++) {
                    if (matrix[i, i] > maxElem) {
                        maxElem = matrix[i, i];
                        maxInd = i;
                    }
                }

                for (int i = 0; i < 6; i++) {
                    if (maxInd == i) {
                        break;
                    }
                    for (int j = 0; j < 6; j++) {
                        if (j > i) {
                            matrix[i, j] = 0;
                        }
                    }
                }

                printMatrixAnswer("2.7", matrix);
            }

            static void task_2_8() {
                double[,] matrix = getMatrix(6, 6);

                if (matrix == null) {
                    return;
                }

                int maxIndA = 0, maxIndB = 0;
                double maxElemA = 0, maxElemB = 0;

                for (int i = 0; i < 3; i++) {
                    maxIndA = 0;
                    maxIndB = 0;
                    maxElemA = matrix[i * 2, 0];
                    maxElemB = matrix[i * 2 + 1, 0];

                    for (int j = 0; j < 6; j++) {
                        if (matrix[i * 2, j] > maxElemA) {
                            maxElemA = matrix[i * 2, j];
                            maxIndA = j;
                        }
                        if (matrix[i * 2 + 1, j] > maxElemB) {
                            maxElemB = matrix[i * 2 + 1, j];
                            maxIndB = j;
                        }
                    }

                    matrix[i * 2, maxIndA] = maxElemB;
                    matrix[i * 2 + 1, maxIndB] = maxElemA;
                }

                printMatrixAnswer("2.8", matrix);
            }

            static void task_2_9() {
                double[,] matrix = getMatrix(6, 7);
                double temp;

                if (matrix == null) {
                    return;
                }

                for (int i = 0; i < 6; i++) {
                    for (int j = 0; j < 4; j++) {
                        temp = matrix[i, j];
                        matrix[i, j] = matrix[i, 6 - j];
                        matrix[i, 6 - j] = temp;
                    }
                }

                printMatrixAnswer("2.8", matrix);
            }


            // Level 3 -----------------------

            static void task_3_1() {
                double[,] matrix = getMatrix(7, 5);

                if (matrix == null) {
                    return;
                }

                double[] minElems = new double[5];
                int[] ids = new int[5];

                for (int i = 0; i < matrix.GetLength(1); i++) {
                    minElems[i] = matrix[0, i];
                    ids[i] = i;
                    for (int j = 0; j < matrix.GetLength(0); j++) {
                        if (minElems[i] > matrix[j, i]) {
                            minElems[i] = matrix[j, i];
                        }
                    }
                }

                double numTemp;
                int idTemp;

                for (int i = 0; i < minElems.Length; i++) {
                    for (int j = i + 1; j < minElems.Length; j++) {
                        if (minElems[i] < minElems[j]) {
                            numTemp = minElems[i];
                            minElems[i] = minElems[j];
                            minElems[j] = numTemp;

                            idTemp = ids[i];
                            ids[i] = ids[j];
                            ids[j] = idTemp;
                        }
                    }
                }

                double[,] answer = new double[7, 5];
                int curInd = 0;
                foreach (int i in ids) {
                    for (int j = 0; j < matrix.GetLength(0); j++) {
                        answer[j, curInd] = matrix[j, i];
                    }
                    curInd++;
                }

                printMatrixAnswer("3.1", answer);
            }

            static void task_3_2() {
                double[,] matrix = getUnknownMatrix();

                if (matrix == null) {
                    return;
                }

                for (int i = 0; i < matrix.GetLength(0); i++) {
                    if (i == 0 || i == matrix.GetLength(0) - 1) {
                        for (int j = 1; j < matrix.GetLength(1) - 1; j++) {
                            matrix[i, j] = 0;
                        }
                    }
                    matrix[i, 0] = 0;
                    matrix[i, matrix.GetLength(0) - 1] = 0;
                }

                printMatrixAnswer("3.2", matrix);
            }

            static void task_3_3() {
                double[,] matrix = getUnknownMatrix();

                if (matrix == null) {
                    return;
                }

                if (matrix.GetLength(0) != matrix.GetLength(1)) {
                    Console.WriteLine("Wrong matrix");
                    return;
                }

                int size = matrix.GetLength(0);

                double[] answer = new double[size * 2 - 1];

                for (int i = 0; i < answer.Length; i++) {
                    answer[i] = 0;
                }


                for (int i = 0; i < size; i++) {
                    answer[size - 1] += matrix[i, i];
                }



                for (int coef = 1; coef < size; coef++) {
                    int i = coef;
                    int j = 0;
                    
                    while (i != size) {
                        answer[size - 1 + coef] += matrix[i, j];
                        i++;
                        j++;
                    }


                    i = 0;
                    j = coef;

                    while (j != size) {
                        answer[size - 1 - coef] += matrix[i, j];
                        i++;
                        j++;
                    }
                }

                printArrayAnswer("3.3", answer);
            }

            static void task_3_4() {
                if (!int.TryParse(Console.ReadLine(), out int n)) {
                    return;
                }

                double[,] matrix = getMatrix(n, n);

                if (matrix == null) {
                    return;
                }

                for (int i = n / 2; i < matrix.GetLength(0); i++) {
                    for (int j = 0; j < matrix.GetLength(1); j++) {
                        if (i < j) {
                            continue;
                        }
                        matrix[i, j] = 1;
                    }
                }

                printMatrixAnswer("3.4", matrix);
            }

            static void task_3_8() {
                double[,] matrix = getMatrix(7, 5);

                if (matrix == null) {
                    return;
                }

                int[] posCnt = new int[5];
                int[] ids = new int[5];

                for (int i = 0; i < matrix.GetLength(1); i++) {
                    posCnt[i] = 0;
                    ids[i] = i;
                    for (int j = 0; j < matrix.GetLength(0); j++) {
                        if (matrix[j, i] > 0) {
                            posCnt[i]++;
                        }
                    }
                }

                int temp;

                for (int i = 0; i < posCnt.Length; i++) {
                    for (int j = i + 1; j < posCnt.Length; j++) {
                        if (posCnt[i] < posCnt[j]) {
                            temp = posCnt[i];
                            posCnt[i] = posCnt[j];
                            posCnt[j] = temp;

                            temp = ids[i];
                            ids[i] = ids[j];
                            ids[j] = temp;
                        }
                    }
                }

                Console.WriteLine(String.Join(" ", ids));

                double[,] answer = new double[7, 5];
                int curInd = 0;
                foreach (int i in ids) {
                    for (int j = 0; j < matrix.GetLength(0); j++) {
                        answer[j, curInd] = matrix[j, i];
                    }
                    curInd++;
                }

                printMatrixAnswer("3.1", answer);
            }

            static void task_3_10() {
                double[,] matrix = getUnknownMatrix();

                if (matrix == null) {
                    return;
                }

                double temp;
                for (int i = 0; i < matrix.GetLength(1); i += 2) {
                    for (int j1 = 0; j1 < matrix.GetLength(0); j1++) {
                        for (int j2 = j1 + 1; j2 < matrix.GetLength(0); j2++) {
                            if (matrix[j1, i] < matrix[j2, i]) {
                                temp = matrix[j1, i];
                                matrix[j1, i] = matrix[j2, i];
                                matrix[j2, i] = temp;
                            }
                        }
                    }
                }

                for (int i = 1; i < matrix.GetLength(1); i += 2) {
                    for (int j1 = 0; j1 < matrix.GetLength(0); j1++) {
                        for (int j2 = j1 + 1; j2 < matrix.GetLength(0); j2++) {
                            if (matrix[j1, i] > matrix[j2, i]) {
                                temp = matrix[j1, i];
                                matrix[j1, i] = matrix[j2, i];
                                matrix[j2, i] = temp;
                            }
                        }
                    }
                }

                printMatrixAnswer("3.10", matrix);
            }

            static void task_3_11() {
                double[,] matrix = getUnknownMatrix();

                if (matrix == null) {
                    return;
                }

                int[] coolInd = new int[matrix.GetLength(1)];
                int coolIndSize = 0;

                for (int i = 0; i < matrix.GetLength(1); i++) {
                    bool flag = true;

                    for(int j = 0; j < matrix.GetLength(0); j++) {
                        if (matrix[j, i] == 0) {
                            flag = false;
                            break;
                        }
                    }
                    
                    if (flag) {
                        coolInd[coolIndSize] = i;
                        coolIndSize++;
                    }
                }

                double[,] answer = new double[matrix.GetLength(0), coolIndSize];
                int curInd = 0;
                for (int i = 0; i < answer.GetLength(0); i++) {
                    curInd = 0;
                    for (int j = 0; j < coolIndSize; j++) { 
                        answer[i, curInd] = matrix[i, coolInd[j]];
                        curInd++;
                    }
                }

                printMatrixAnswer("3.11", answer);
            }


            // -------------------------------

            task_1_3();

        }
    }
}
