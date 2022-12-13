//1st level task 3
int n = 4;
int m = 4;
double[,] a = new double[n, m];
Console.WriteLine("Enter elements of a matrix:");   
double x = 0;
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        double.TryParse(Console.ReadLine(), out x);
        a[i, j] = x;
    }
}
double sum = 0;
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        if (i == j)
            sum+= a[i, j];
    }
}
Console.WriteLine($"Summa = {sum}");


//1st level task 6
int n = 4, m = 7;
int[,] a = new int[n, m];
int[] aa = new int[n];
int x = 0;
Console.WriteLine("Enter elements of a matrix:");
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        int.TryParse(Console.ReadLine(), out x);
        a[i, j] = x;
    }
}
Console.WriteLine("Matrix:");
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        Console.Write(a[i, j] + "\t");
    }
    Console.WriteLine();
}
for (int i = 0; i < n; i++)
{
    int min = a[i, 0], stroka = 0;
    for (int j = 0; j < m; j++)
    {
        if (a[i, j] < min)
        {
            min = a[i, j];
            stroka = j;
        }
    }
    aa[i] = stroka;
}
Console.WriteLine("Array:");
for (int i = 0; i < n; i++)
    Console.Write("{0} ", aa[i]);


//1st level task 12
int n = 6, m = 7;
int[,] a = new int[n, m];
int x = 0;
Console.WriteLine("Enter elements of a matrix:");
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        int.TryParse(Console.ReadLine(), out x);
        a[i, j] = x;
    }
}
Console.WriteLine("Matrix:");
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        Console.Write(a[i, j] + "\t");
    }
    Console.WriteLine();
}
int stroka = 0; 
    int stolb = 0;
int max = a[0, 0]; 
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        if (a[i, j] > max)
        {
            max = a[i, j];
            stroka = j;
            stolb = i;
        }
    }
}
n = n - 1;
m = m - 1;
for (int i = stolb; i < n; i++)
{
    for (int j = 0 ; j < m; j++)
    {
        a[i, j] = a[i + 1, j];  
    }
}
for (int i = 0; i < n; i++)
{
    for (int j = stroka; j < m; j++)
    {
        a[i, j] = a[i, j + 1];
    }
}
Console.WriteLine("Matrix:");
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        Console.Write(a[i, j] + "\t");
    }
    Console.WriteLine();
}


//1st level task 13
int n = 5, m = 5;
int[,] a = new int[n, m];
int x = 0;
Console.WriteLine("Enter elements of a matrix:");
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        int.TryParse(Console.ReadLine(), out x);
        a[i, j] = x;
    }
}
Console.WriteLine("Matrix:");
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        Console.Write(a[i, j] + "\t");
    }
    Console.WriteLine();
}
int stolb = 0;
int max = a[0, 0]; 
for (int i = 0; i < n; i++)
{
        if (a[i, i] > max)
        {
            max = a[i, i];
            stolb = i;
        }
}
int p = 0;
for (int i = 0; i < n; i++)
{
        p = a[i, 3];
        a[i, 3] = a[i, stolb];
        a[i, stolb] = p;
}

Console.WriteLine("Matrix:");
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        Console.Write(a[i, j] + "\t");
    }
    Console.WriteLine();
}

//1st level task 17
Console.WriteLine("Enter n and m");
int n = 0;
int m = 0;
int.TryParse(Console.ReadLine(), out n);
int.TryParse(Console.ReadLine(), out m);
int[,] a = new int[n, m];
int x = 0;
Console.WriteLine("Enter elements of a matrix:");
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        int.TryParse(Console.ReadLine(), out x);
        a[i, j] = x;
    }
}
Console.WriteLine("Matrix:");
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        Console.Write(a[i, j] + "\t");
    }
    Console.WriteLine();
}
for (int i = 0; i < n; i++)
{
    int min = a[i, 0], imin = 0;
    for (int j = 0; j < m; j++)
    {
        if (min > a[i, j])
        {
            min = a[i, j];
            imin = j;
        }
    }
    for (int j = imin; j > 0; j--) 
    a[i, j] = a[i, j - 1];
    a[i, 0] = min;
}
Console.WriteLine("Matrix:");
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        Console.Write(a[i, j] + "\t");
    }
    Console.WriteLine();
}



//1st level task 29
int n = 5;
int m = 7;
int[,] a = new int[n, m];
int x = 0;
Console.WriteLine("Enter elements of a matrix:");
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        int.TryParse(Console.ReadLine(), out x);
        a[i, j] = x;
    }
}
Console.WriteLine("Matrix:");
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        Console.Write(a[i, j] + "\t");
    }
    Console.WriteLine();
}
int stolb = -1;
int min = int.MaxValue;
for (int i = 0; i < n; i++)
{ 
    for (int j = 0; j < m; j++)
    {
        if (i == 1)
        {
            if (min > Math.Abs(a[1, j]))
            {
                min = a[1, j];
                stolb = j;
            }
        }
    }
}
if (stolb == m - 1) stolb = -1;
m = m - 1;
stolb += 1;
if (stolb < m)
{
    for (int i = 0; i < n; i++)
    {
        for (int j = stolb; j < m; j++)
        {
            a[i, j] = a[i, j + 1];
        }
    }
}
Console.WriteLine("Matrix:");
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        Console.Write(a[i, j] + "\t");
    }
    Console.WriteLine();
}

//1st level task 31
int n = 5;
int m = 8;
int[,] a = new int[n, m];
int[] b = new int[5] { 100, 100, 100, 100, 100 };
int x = 0;
Console.WriteLine("Enter elements of a matrix:");
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        int.TryParse(Console.ReadLine(), out x);
        a[i, j] = x;
    }
}
Console.WriteLine("Matrix:");
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        Console.Write(a[i, j] + "\t");
    }
    Console.WriteLine();
}
int stolb = -1;
int min = int.MaxValue;
for (int i = 0; i < n; i++)
{ 
    for (int j = 0; j < m; j++)
    {
        if (i == 4)
        {
            if (min > a[4, j])
            {
                min = a[4, j];
                stolb = j;
            }
        }
    }
}

if (stolb == 6) stolb = 0;

for (int i = 0; i < 5; i++)
    for (int j = 6; j > stolb; j--)
        a[i, j + 1] = a[i, j];

for (int i = 0; i < 5; i++)
    a[i, stolb + 1] = b[i];

    Console.WriteLine("Matrix:");
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        Console.Write(a[i, j] + "\t");
    }
    Console.WriteLine();
}


//2nd Level Task 7
int n = 6;
int m = 6;
int[,] a = new int[n, m];
int x = 0;
Console.WriteLine("Enter elements of a matrix:");
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        int.TryParse(Console.ReadLine(), out x);
        a[i, j] = x;
    }
}
Console.WriteLine("Matrix:");
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        Console.Write(a[i, j] + "\t");
    }
    Console.WriteLine();
}
int max = int.MinValue;
int stroka = -1;
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        if (max < a[i, j])
        {
            max = a[i, j];
            stroka = i;
        }
    }
}
for (int i = stroka - 1; i >= 0; i--)
{
    for (int j = 5; j > i; j--)
    {
        a[i, j] = 0;
    }
}
Console.WriteLine("Matrix:");
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        Console.Write(a[i, j] + "\t");
    }
    Console.WriteLine();
}

// 2nd Level Task 8
int n = 6;
int m = 6;
int[,] a = new int[n, m];
int[] b = new int[n];
int x = 0;
Console.WriteLine("Enter elements of a matrix:");
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        int.TryParse(Console.ReadLine(), out x);
        a[i, j] = x;
    }
}
Console.WriteLine("Matrix:");
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        Console.Write(a[i, j] + "\t");
    }
    Console.WriteLine();
}
int max = int.MinValue;
int stroka = -1;
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        if (max < a[i, j])
        {
            max = a[i, j];
            stroka = j;
        }
    }
    b[i] = stroka;
}
int p = 0;
for (int i = 0; i < n; i += 2)
{
    p = a[i, b[i]]; 
    a[i, b[i]] = a[i + 1, b[i + 1]];
    a[i + 1, b[i + 1]] = p;
}
Console.WriteLine("Matrix:");
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        Console.Write(a[i, j] + "\t");
    }
    Console.WriteLine();
}


//2nd Level Task 9
int n = 6;
int m = 7;
int[,] a = new int[n, m];
int[] b = new int[n];
int x = 0;
Console.WriteLine("Enter elements of a matrix:");
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        int.TryParse(Console.ReadLine(), out x);
        a[i, j] = x;
    }
}
Console.WriteLine("Matrix:");
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        Console.Write(a[i, j] + "\t");
    }
    Console.WriteLine();
}
int p = 0;
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m / 2; j++)
    {
        p = a[i, m - 1 - j];
        a[i, m - 1 - j] = a[i, j];
        a[i, j] = p;
    }
}
Console.WriteLine("Matrix:");
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        Console.Write(a[i, j] + "\t");
    }
    Console.WriteLine();
}


//3rd Level Task 1
int n = 7;
int m = 5;
double[,] a = new double[n, m];
double[,] res = new double[n, m];
double[,] aa = new double[n, 2];
double x = 0;
Console.WriteLine("Enter elements of matrix");
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        double.TryParse(Console.ReadLine(), out x);
        a[i, j] = x;
    }
}
Console.WriteLine("Matrix:");
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        Console.Write(a[i, j] + "\t");
    }
    Console.WriteLine();
}

int stolb;
double p1;
double p2;
double index;
for (int i = 0; i < n; i++)
{
    double mini = a[i, 0];
    for (int j = 0; j < m; j++)
    {
        if (mini > a[i, j]) mini = a[i, j];
    }
    aa[i, 0] = i;
    aa[i, 1] = mini;
}
for (int i = 0; i < n; i++)
{
    index = aa[i, 0];
    double maxi = aa[i, 1];
    stolb = i;
    for (int j = i + 1; j < n; j++)
    {
        if (aa[j, 1] > maxi)
        {
            maxi = aa[j, 1];
            index = aa[j, 0];
            stolb = j;
        }
    }
    p1 = aa[i, 0];
    aa[i, 0] = index;
    aa[stolb, 0] = p1;
    p2 = aa[i, 1];
    aa[i, 1] = maxi;
    aa[stolb, 1] = p2;
}
for (int i = 0; i < n; i++)
{
    stolb = (int)aa[i, 0];
    for (int j = 0; j < m; j++)
        res[i, j] = a[stolb, j];
}
Console.WriteLine("Matrix:");
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        Console.Write(res[i, j] + "\t");
    }
    Console.WriteLine();
}


//3rd Level Task 2
int n = 4;
int m = 4;
int[,] a = new int[n, m];
int x = 0;
Console.WriteLine("Enter elements of a matrix:");
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        int.TryParse(Console.ReadLine(), out x);
        a[i, j] = x;
    }
}
Console.WriteLine("Matrix:");
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        Console.Write(a[i, j] + "\t");
    }
    Console.WriteLine();
}
for (int i = 0; i < 4; i++)
{
    a[i, 0] = 0;
    a[0, i] = 0;
    a[i, 3] = 0;
    a[3, i] = 0;
}
Console.WriteLine("Matrix:");
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        Console.Write(a[i, j] + "\t");
    }
    Console.WriteLine();
}


//3rd Level Task 3
int n = 0;
Console.WriteLine("Enter n:");
int.TryParse(Console.ReadLine(), out n);
int[,] a = new int[n, n];
int x = 0;
Console.WriteLine("Enter elements of a matrix:");
for (int i = 0; i < n; i++)
    for (int j = 0; j < n; j++)
    {
        int.TryParse(Console.ReadLine(), out x);
        a[i, j] = x;
    }
Console.WriteLine("Matrix:");
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(a[i, j] + "\t");
    }
    Console.WriteLine();
}
int [] b = new int [n * 2 - 1];
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        b[j - i + n - 1] += a[i, j];
    }
}
Console.WriteLine("Array:");
for (int i = 0; i < n; i++)
    Console.Write("{0} ", b[i]);


//3rd Level Task 4
int n = 0;
Console.WriteLine("Enter n:");
int.TryParse(Console.ReadLine(), out n);
int[,] a = new int[n, n];
int x = 0;
Console.WriteLine("Enter elements of a matrix:");
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        int.TryParse(Console.ReadLine(), out x);
        a[i, j] = x;
    }
}
Console.WriteLine("Matrix:");
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(a[i, j] + "\t");
    }
    Console.WriteLine();
}
for (int i = n / 2; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        if (j <= i)
            a[i, j] = 1;
    }
}
Console.WriteLine("Matrix:");
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(a[i, j] + "\t");
    }
    Console.WriteLine();
}


//3rd Level Task 8
int n = 7;
int m = 5;
int[,] a = new int[n, m];
int [,] neew = new int[n, m];
int x = 0;
Console.WriteLine("Enter elements of a matrix:");
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        int.TryParse(Console.ReadLine(), out x);
        a[i, j] = x;
    }
}
Console.WriteLine("Matrix:");
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        Console.Write(a[i, j] + "\t");
    }
    Console.WriteLine();
}
int p = 0;
int p1 = 0;
int p2 = 0;
int [,] a1 = new int[n, 2];
int k = 0;
for (int i = 0; i < n; i++)
{

    for (int j = 0; j < m; j++)
    {
        if (a[i, j] > 0)
        {
            k++;
        }
    }
    a1[i, 0] = i;
    a1[i, 1] = k;
    k = 0;
}
for (int i = 0; i < n; i++)
{
    int max = a1[i, 1];
    p2 = i;
    for (int j = 1 + i; j < n; j++)
    {
        if (a1[j, 1] > max)
        {
            max = a1[j, 1];
            p2 = j;
        }
    }
    p = a1[i, 0];
    a1[i, 0] = p2;
    a1[p2, 0] = p;
    p1 = a1[i, 1];
    a1[i, 1] = max;
    a1[p2, 1] = p1;
}
for (int i = 0; i < n; i++)
{
    p2 = (int)a1[i, 0];
    for (int j = 0; j < m; j++)
    {
        neew[i, j] = a[p2, j];
    }
}
Console.WriteLine("Matrix:");
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        Console.Write(neew[i, j] + "\t");
    }
    Console.WriteLine();
}


//3rd Level Task 10
Console.WriteLine("Enter n and m");
int n = 0;
int m = 0;
int.TryParse(Console.ReadLine(), out n);
int.TryParse(Console.ReadLine(), out m);
int[,] a = new int[n, m];
int x = 0;
Console.WriteLine("Enter elements of a matrix:");
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        int.TryParse(Console.ReadLine(), out x);
        a[i, j] = x;
    }
}
Console.WriteLine("Matrix:");
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        Console.Write(a[i, j] + "\t");
    }
    Console.WriteLine();
}
int p = 0;
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m - 1; j++)
        for (int k = j; k < m; k++)
        {
            if (i % 2 == 0)
                if (a[i, j] < a[i, k])
                {
                    p = a[i, j]; 
                    a[i, j] = a[i, k];
                    a[i, k] = p;
                }
            else
            {
                if (a[i, j] > a[i, k])
                {
                    p = a[i, j]; 
                    a[i, j] = a[i, k];
                    a[i, k] = p;
                }
            }
        }
}
Console.WriteLine("Matrix:");
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        Console.Write(a[i, j] + "\t");
    }
    Console.WriteLine();
}



//3rd Level Task 11
Console.WriteLine("Enter n and m");
int n = 0;
int m = 0;
int.TryParse(Console.ReadLine(), out n);
int.TryParse(Console.ReadLine(), out m);
int[,] a = new int[n, m];
int x = 0;
Console.WriteLine("Enter elements of a matrix:");
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        int.TryParse(Console.ReadLine(), out x);
        a[i, j] = x;
    }
}
Console.WriteLine("Matrix:");
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        Console.Write(a[i, j] + "\t");
    }
    Console.WriteLine();
}
List<int> b = new List<int>();
for (int i = 0; i < n; i++)
{
    bool flag = false;  
    for (int j = 0; j < m; j++)
    {
        if (a[i, j] == 0)
        {
            flag = true;
        }
    }
    if (flag == true)
    {
        b.Add(i);
    }
}
Console.WriteLine("Matrix:");
int index = 0;
int length = b.Count();
for (int i = 0; i < n; i++)
{
    if (index == length)
    {
        index = 0;
    }
    else if (i == b[index])
    {
        index += 1;
        continue;
    }
        for (int j = 0; j < m; j++)
        {
            Console.Write(a[i, j] + "\t");
        }
        Console.WriteLine();    
}
