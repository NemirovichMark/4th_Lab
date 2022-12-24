//Task 1.3
using System.Globalization;

Console.WriteLine("Task 1.3");
double[,] a = new double[4, 4];
double x;
for (int j = 0; j < 4; j += 1)
{
    Console.WriteLine($"Введите {j} строку");
    string[] g = Console.ReadLine().Split();
    if (g.Length == 4)
    {
        for (int i = 0; i < g.Length; i += 1)
        {
            if (double.TryParse(g[i], out x))
            {
                a[j, i] = x;
            }
            else
            {
                Console.WriteLine("Неверный ввод");
            }
        }
    }
    else
    {
        Console.WriteLine("Неверный ввод");
        Environment.Exit(0);
    }
}
double s=0;
for (int i = 0; i < 4; i += 1)
{
    s += a[i, i];
}
Console.WriteLine(s);

//Task 1.6
Console.WriteLine("Task 1.6");
a = new double[4, 7];
double[] A= new double[4];
for (int j = 0; j < 4; j += 1)
{
    Console.WriteLine($"Введите {j} строку");
    string[] g = Console.ReadLine().Split();
    if (g.Length == 7)
    {
        for (int i = 0; i < g.Length; i += 1)
        {
            if (double.TryParse(g[i], out x))
            {
                a[j, i] = x;
            }
            else
            {
                Console.WriteLine("Неверный ввод");
            }
        }
    }
    else
    {
        Console.WriteLine("Неверный ввод");
        Environment.Exit(0);
    }
}
double min = 1000000000;
for (int j = 0; j < 4; j += 1)
{
    for (int i = 0; i < 7; i += 1)
    {
        if (a[j,i]<min)
        {
            min = a[j,i];
        }
    }
    A[j] = min;
    min = 1000000000;
}
for (int i = 0; i < A.Length; i += 1)
{
    Console.WriteLine($"A[{i}]={A[i]}");
}

//Task 1.12
Console.WriteLine("Task 1.12");
a = new double[6, 7];
double[,] b = new double[5, 6];
for (int j = 0; j < 6; j += 1)
{
    Console.WriteLine($"Введите {j} строку");
    string[] g = Console.ReadLine().Split();
    if (g.Length == 7)
    {
        for (int i = 0; i < g.Length; i += 1)
        {
            if (double.TryParse(g[i], out x))
            {
                a[j, i] = x;
            }
            else
            {
                Console.WriteLine("Неверный ввод");
            }
        }
    }
    else
    {
        Console.WriteLine("Неверный ввод");
        Environment.Exit(0);
    }
}
double max = -1000000;
int maxi = 0;
int maxj = 0;
for (int j = 0; j < 6; j += 1)
{
    for (int i = 0; i < 7; i += 1)
    {
        if (a[j, i] > max)
        {
            max = a[j, i];
            maxi = i;
            maxj = j;
        }
    }
}
for (int j = 0; j < 6; j += 1)
{
    if (j < maxj)
    {
        for (int i = 0; i < 7; i += 1)
        {
            if (i < maxi)
            {
                b[j, i] = a[j, i];
            }
            if (i > maxi)
            {
                b[j, i - 1] = a[j, i];
            }
        }
    }
    if (j > maxj)
    {
        for (int i = 0; i < 7; i += 1)
        {
            if (i < maxi)
            {
                b[j - 1, i] = a[j, i];
            }
            if (i > maxi)
            {
                b[j - 1, i - 1] = a[j, i];
            }
        }
    }
}
Console.WriteLine("");
for (int j = 0; j < 5; j += 1)
{
    for (int i = 0; i < 6; i += 1)
    {
        Console.Write($"{b[j, i]} ");
    }
    Console.WriteLine();
}

//Task 1.13
Console.WriteLine("Task 1.13");
a = new double[5, 5];
b = new double[5, 5];
for (int j = 0; j < 5; j += 1)
{
    Console.WriteLine($"Введите {j} строку");
    string[] g = Console.ReadLine().Split();
    if (g.Length == 5)
    {
        for (int i = 0; i < g.Length; i += 1)
        {
            if (double.TryParse(g[i], out x))
            {
                a[j, i] = x;
            }
            else
            {
                Console.WriteLine("Неверный ввод");
            }
        }
    }
    else
    {
        Console.WriteLine("Неверный ввод");
        Environment.Exit(0);
    }
}
max = -1000000;
maxi = 0;
for (int i = 0; i < 5; i += 1)
    {
        if (a[i, i] > max)
        {
            max = a[i, i];
            maxi = i;
        }
    }

for (int j = 0; j < 5; j += 1)
{
    for (int i = 0; i < 5; i += 1)
    {
        if (i != maxi & i !=4)
        {
            b[j, i] = a[j, i];
        }
        if (i == maxi)
        {
            b[j, i] = a[j, 4];
        }
        if (i == 4)
        {
            b[j, i] = a[j, maxi];
        }
    }
}
Console.WriteLine("");
for (int j = 0; j < 5; j += 1)
{
    for (int i = 0; i < 5; i += 1)
    {
        Console.Write($"{b[j, i]} ");
    }
    Console.WriteLine();
}

//Task 1.17
Console.WriteLine("Task 1.17");
int n=0;
int m=0;
int z = 0;
Console.WriteLine("Введите n");
string[] u = Console.ReadLine().Split();
if (u.Length == 1)
{
    if (int.TryParse(u[0], out z))
    {
        n = z;
    }
    else
    {
        Console.WriteLine("Неверный ввод");
    }
}
Console.WriteLine("Введите m");
u = Console.ReadLine().Split();
if (u.Length == 1)
{
    if (int.TryParse(u[0], out z))
    {
        m = z;
    }
    else
    {
        Console.WriteLine("Неверный ввод");
    }
}
a = new double[n,m];
b = new double[n,m];
for (int j = 0; j < n; j += 1)
{
    Console.WriteLine($"Введите {j} строку");
    string[] g = Console.ReadLine().Split();
    if (g.Length == m)
    {
        for (int i = 0; i < g.Length; i += 1)
        {
            if (double.TryParse(g[i], out x))
            {
                a[j, i] = x;
            }
            else
            {
                Console.WriteLine("Неверный ввод");
            }
        }
    }
    else
    {
        Console.WriteLine("Неверный ввод");
        Environment.Exit(0);
    }
}
min = 1000000000;
int mini = 0;
for (int j = 0; j < n; j += 1)
{
    for (int i = 0; i < m; i += 1)
    {
        if (a[j, i] < min)
        {
            min = a[j, i];
            mini = i;
        }
    }
    for (int i = 0; i < m; i += 1)
    {
        if (i < mini)
        {
            b[j, i+1]= a[j, i];
        }
        if (i == mini)
        {
            b[j, 0] = a[j, i];
        }
        if (i > mini)
        {
            b[j, i] = a[j, i];
        }
    }
    min = 1000000000;
}
Console.WriteLine("");
for (int j = 0; j < n; j += 1)
{
    for (int i = 0; i < m; i += 1)
    {
        Console.Write($"{b[j, i]} ");
    }
    Console.WriteLine();
}

//Task 1.29
Console.WriteLine("Task 1.29");
a = new double[5, 7];
b = new double[5, 6];
for (int j = 0; j < 5; j += 1)
{
    Console.WriteLine($"Введите {j} строку");
    string[] g = Console.ReadLine().Split();
    if (g.Length == 7)
    {
        for (int i = 0; i < g.Length; i += 1)
        {
            if (double.TryParse(g[i], out x))
            {
                a[j, i] = x;
            }
            else
            {
                Console.WriteLine("Неверный ввод");
            }
        }
    }
    else
    {
        Console.WriteLine("Неверный ввод");
        Environment.Exit(0);
    }
}
min = 1000000000;
mini = 0;
for (int i = 0; i < 7; i += 1)
{
    if (Math.Abs(a[1, i]) < min)
    {
        min = Math.Abs(a[1, i]);
        mini = i;
    }
}
if (mini != 6)
{
    for (int j = 0; j < 5; j += 1)
    {
        for (int i = 0; i < 7; i += 1)
        {
            if (i <= mini)
            {
                b[j, i] = a[j, i];
            }
            if (i > mini + 1)
            {
                b[j, i - 1] = a[j, i];
            }

        }

    }
    Console.WriteLine("");
    for (int j = 0; j < 5; j += 1)
    {
        for (int i = 0; i < 6; i += 1)
        {
            Console.Write($"{b[j, i]} ");
        }
        Console.WriteLine();
    }
}
if (mini == 6)
{
    Console.WriteLine("");
    for (int j = 0; j < 5; j += 1)
    {
        for (int i = 0; i < 7; i += 1)
        {
            Console.Write($"{a[j, i]} ");
        }
        Console.WriteLine();
    }
}

//Task 1.31
Console.WriteLine("Task 1.31");
a = new double[5, 7];
b = new double[5, 8];
double[,] c = new double[1, 5];
for (int j = 0; j < 5; j += 1)
{
    Console.WriteLine($"Введите {j} строку");
    string[] g = Console.ReadLine().Split();
    if (g.Length == 7)
    {
        for (int i = 0; i < g.Length; i += 1)
        {
            if (double.TryParse(g[i], out x))
            {
                a[j, i] = x;
            }
            else
            {
                Console.WriteLine("Неверный ввод");
            }
        }
    }
    else
    {
        Console.WriteLine("Неверный ввод");
        Environment.Exit(0);
    }
}
for (int j = 0; j < 1; j += 1)
{
    Console.WriteLine("Введите B в строку");
    string[] g = Console.ReadLine().Split();
    if (g.Length == 5)
    {
        for (int i = 0; i < g.Length; i += 1)
        {
            if (double.TryParse(g[i], out x))
            {
                c[j, i] = x;
            }
            else
            {
                Console.WriteLine("Неверный ввод");
            }
        }
    }
    else
    {
        Console.WriteLine("Неверный ввод");
        Environment.Exit(0);
    }
}
min = 1000000000;
mini = 0;
for (int i = 0; i < 7; i += 1)
{
    if (a[4, i] < min)
    {
        min = a[4, i];
        mini = i;
    }
}
for (int j = 0; j < 5; j += 1)
{
    for (int i = 0; i < 8; i += 1)
    {
        if (i <= mini)
        {
            b[j, i] = a[j, i];
        }
        if (i == mini + 1)
        {
            b[j, i] = c[0, j];
        }
        if (i > mini + 1)
        {
            b[j, i] = a[j, i - 1];
        }

    }

}
Console.WriteLine("");
for (int j = 0; j < 5; j += 1)
{
    for (int i = 0; i < 8; i += 1)
    {
        Console.Write($"{b[j, i]} ");
    }
    Console.WriteLine();
}

//Task 2.7
Console.WriteLine("Task 2.7");
a = new double[6, 6];
for (int j = 0; j < 6; j += 1)
{
    Console.WriteLine($"Введите {j} строку");
    string[] g = Console.ReadLine().Split();
    if (g.Length == 6)
    {
        for (int i = 0; i < g.Length; i += 1)
        {
            if (double.TryParse(g[i], out x))
            {
                a[j, i] = x;
            }
            else
            {
                Console.WriteLine("Неверный ввод");
            }
        }
    }
    else
    {
        Console.WriteLine("Неверный ввод");
        Environment.Exit(0);
    }
}

max = -1000000;
maxi = 0;
for (int i = 0; i < 6; i += 1)
{
    if (a[i, i] > max)
    {
        max = a[i, i];
        maxi = i;
    }
}
for (int j = 0; j < 6; j += 1)
{
    for (int i = 0; i < 6; i += 1)
    {
        if (j < maxi & i>j)
        {
            a[j, i] = 0;
        }
    }
}
Console.WriteLine("");
for (int j = 0; j < 6; j += 1)
{
    for (int i = 0; i < 6; i += 1)
    {
        Console.Write($"{a[j, i]} ");
    }
    Console.WriteLine();
}

//Task 2.8
Console.WriteLine("Task 2.8");
a = new double[6, 6];
for (int j = 0; j < 6; j += 1)
{
    Console.WriteLine($"Введите {j} строку");
    string[] g = Console.ReadLine().Split();
    if (g.Length == 6)
    {
        for (int i = 0; i < g.Length; i += 1)
        {
            if (double.TryParse(g[i], out x))
            {
                a[j, i] = x;
            }
            else
            {
                Console.WriteLine("Неверный ввод");
            }
        }
    }
    else
    {
        Console.WriteLine("Неверный ввод");
        Environment.Exit(0);
    }
}
max = -1000000;
int max0=0;
int max1 = 0;
int max2 = 0;
int max3 = 0;
int max4 = 0;
int max5 = 0;
for (int i = 0; i < 6; i += 1)
{
    if (a[0, i] > max)
    {
        max = a[0, i];
        max0 = i;
    }
}
max = -1000000;
for (int i = 0; i < 6; i += 1)
{
    if (a[1, i] > max)
    {
        max = a[1, i];
        max1 = i;
    }
}
max = -1000000;
for (int i = 0; i < 6; i += 1)
{
    if (a[2, i] > max)
    {
        max = a[2, i];
        max2 = i;
    }
}
max = -1000000;
for (int i = 0; i < 6; i += 1)
{
    if (a[3, i] > max)
    {
        max = a[3, i];
        max3 = i;
    }
}
max = -1000000;
for (int i = 0; i < 6; i += 1)
{
    if (a[4, i] > max)
    {
        max = a[4, i];
        max4 = i;
    }
}
max = -1000000;
for (int i = 0; i < 6; i += 1)
{
    if (a[5, i] > max)
    {
        max = a[5, i];
        max5 = i;
    }
}
x= 0;
x = a[0, max0];
a[0, max0] = a[1, max1];
a[1, max1] = x;
x = 0;
x = a[2, max2];
a[2, max2] = a[3, max3];
a[3, max3] = x;
x = 0;
x = a[4, max4];
a[4, max4] = a[5, max5];
a[5, max5] = x;
Console.WriteLine("");
for (int j = 0; j < 6; j += 1)
{
    for (int i = 0; i < 6; i += 1)
    {
        Console.Write($"{a[j, i]} ");
    }
    Console.WriteLine();
}

//Task 2.9
Console.WriteLine("Task 2.9");
a = new double[6, 7];
b = new double[6, 7];
for (int j = 0; j < 6; j += 1)
{
    Console.WriteLine($"Введите {j} строку");
    string[] g = Console.ReadLine().Split();
    if (g.Length == 7)
    {
        for (int i = 0; i < g.Length; i += 1)
        {
            if (double.TryParse(g[i], out x))
            {
                a[j, i] = x;
            }
            else
            {
                Console.WriteLine("Неверный ввод");
            }
        }
    }
    else
    {
        Console.WriteLine("Неверный ввод");
        Environment.Exit(0);
    }
}
for (int j = 0; j < 6; j += 1)
{
    for (int i = 0; i < 7; i += 1)
    {
        b[j, i] = a[j,6-i];
    }
}
Console.WriteLine("");
for (int j = 0; j < 6; j += 1)
{
    for (int i = 0; i < 7; i += 1)
    {
        Console.Write($"{b[j, i]} ");
    }
    Console.WriteLine();
}

//Task 3.1
Console.WriteLine("Task 3.1");
a = new double[7, 5];
b = new double[7, 5];
for (int j = 0; j < 7; j += 1)
{
    Console.WriteLine($"Введите {j} строку");
    string[] g = Console.ReadLine().Split();
    if (g.Length == 5)
    {
        for (int i = 0; i < g.Length; i += 1)
        {
            if (double.TryParse(g[i], out x))
            {
                a[j, i] = x;
            }
            else
            {
                Console.WriteLine("Неверный ввод");
            }
        }
    }
    else
    {
        Console.WriteLine("Неверный ввод");
        Environment.Exit(0);
    }
}
double[] mins = new double[7];
int[] minis = new int[7];
min = 100000000;
mini = 0;
for (int j = 0; j < 7; j += 1)
{
    for (int i = 0; i < 5; i += 1)
    {
        if (a[j, i] < min)
        {
            min = a[j, i];
        }
    }
    mins[j] = min;
    minis[j] = j;
    min = 10000000;
}
for (int i = 0; i < 7; i += 1)
{
    for (int j = 0; j < 6; j += 1)
    {
        if (mins[j] < mins[j + 1])
        {
            x = mins[j];
            mins[j] = mins[j + 1];
            mins[j + 1] = x;
            z = minis[j];
            minis[j] = minis[j + 1];
            minis[j + 1] = z;
        }
    }
}
for (int j = 0; j < 7; j += 1)
{
    for (int i = 0; i < 5; i += 1)
    {
        b[j, i] = a[minis[j], i];
    }
}
Console.WriteLine("");
for (int j = 0; j < 7; j += 1)
{
    for (int i = 0; i < 5; i += 1)
    {
        Console.Write($"{b[j, i]} ");
    }
    Console.WriteLine();
}

//Task 3.2
Console.WriteLine("Task 3.2");
Console.WriteLine("Введите n");
u = Console.ReadLine().Split();
if (u.Length == 1)
{
    if (int.TryParse(u[0], out z))
    {
        n = z;
    }
    else
    {
        Console.WriteLine("Неверный ввод");
    }
}
a = new double[n, n];
for (int j = 0; j < n; j += 1)
{
    Console.WriteLine($"Введите {j} строку");
    string[] g = Console.ReadLine().Split();
    if (g.Length == n)
    {
        for (int i = 0; i < g.Length; i += 1)
        {
            if (double.TryParse(g[i], out x))
            {
                a[j, i] = x;
            }
            else
            {
                Console.WriteLine("Неверный ввод");
            }
        }
    }
    else
    {
        Console.WriteLine("Неверный ввод");
        Environment.Exit(0);
    }
}
for (int j = 0; j < n; j += 1)
{
    for (int i = 0; i < n; i += 1)
    {
        if (j==0 | i == 0 | j==n-1 | i==n-1) 
        {
            a[j, i] = 0;
        }
    }
}
Console.WriteLine("");
for (int j = 0; j < n; j += 1)
{
    for (int i = 0; i < n; i += 1)
    {
        Console.Write($"{a[j, i]} ");
    }
    Console.WriteLine();
}

//Task 3.3
Console.WriteLine("Task 3.3");
Console.WriteLine("Введите n");
u = Console.ReadLine().Split();
if (u.Length == 1)
{
    if (int.TryParse(u[0], out z))
    {
        n = z;
    }
    else
    {
        Console.WriteLine("Неверный ввод");
    }
}
a = new double[n, n];
for (int j = 0; j < n; j += 1)
{
    Console.WriteLine($"Введите {j} строку");
    string[] g = Console.ReadLine().Split();
    if (g.Length == n)
    {
        for (int i = 0; i < g.Length; i += 1)
        {
            if (double.TryParse(g[i], out x))
            {
                a[j, i] = x;
            }
            else
            {
                Console.WriteLine("Неверный ввод");
            }
        }
    }
    else
    {
        Console.WriteLine("Неверный ввод");
        Environment.Exit(0);
    }
}
int p = 0;
double sum=0;
double[] sums= new double[2*n-1];
for (int j = 0; j < n; j += 1)
{

    if (j == 0)
    {
        for (int i = 0; i < n; i += 1)
        {
            z = 0;
            sum = 0;
            for (int k = i; k < n; k += 1)
            {
                sum += a[z, k];
                z++;
            }
            sums[p] = sum;
            p++;
        }
    }
    else
    {
        z = 0;
        sum = 0;
        for (int k = j; k < n; k += 1)
        {
            sum += a[k, z];
            z++;
        }
        sums[p] = sum;
        p++;
    }
}
Console.WriteLine("");
for (int i = 0; i < 2 * n - 1; i += 1)
{
    Console.Write($"{sums[i]} ");
}

//Task 3.4
Console.WriteLine("Task 3.4");
Console.WriteLine("Введите n");
u = Console.ReadLine().Split();
if (u.Length == 1)
{
    if (int.TryParse(u[0], out z))
    {
        n = z;
    }
    else
    {
        Console.WriteLine("Неверный ввод");
    }
}
a = new double[n, n];
for (int j = 0; j < n; j += 1)
{
    Console.WriteLine($"Введите {j} строку");
    string[] g = Console.ReadLine().Split();
    if (g.Length == n)
    {
        for (int i = 0; i < g.Length; i += 1)
        {
            if (double.TryParse(g[i], out x))
            {
                a[j, i] = x;
            }
            else
            {
                Console.WriteLine("Неверный ввод");
            }
        }
    }
    else
    {
        Console.WriteLine("Неверный ввод");
        Environment.Exit(0);
    }
}
for (int j = 0; j < n; j += 1)
{
    for (int i = 0; i < n; i += 1)
    {
        if (j+1>n/2 & i<=j)
        {
            a[j, i] = 1;
        }
    }
}
Console.WriteLine("");
for (int j = 0; j < n; j += 1)
{
    for (int i = 0; i < n; i += 1)
    {
        Console.Write($"{a[j, i]} ");
    }
    Console.WriteLine();
}

//Task 3.8
Console.WriteLine("Task 3.8");
Console.WriteLine("Введите n");
u = Console.ReadLine().Split();
if (u.Length == 1)
{
    if (int.TryParse(u[0], out z))
    {
        n = z;
    }
    else
    {
        Console.WriteLine("Неверный ввод");
    }
}
a = new double[n, n];
b = new double[n, n];
for (int j = 0; j < n; j += 1)
{
    Console.WriteLine($"Введите {j} строку");
    string[] g = Console.ReadLine().Split();
    if (g.Length == n)
    {
        for (int i = 0; i < g.Length; i += 1)
        {
            if (double.TryParse(g[i], out x))
            {
                a[j, i] = x;
            }
            else
            {
                Console.WriteLine("Неверный ввод");
            }
        }
    }
    else
    {
        Console.WriteLine("Неверный ввод");
        Environment.Exit(0);
    }
}
int[] kol = new int[n];
int[] koli = new int[n];
int q=0;
for (int j = 0; j <n; j += 1)
{
    for (int i = 0; i < n; i += 1)
    {
        if (a[j, i] > 0)
        {
            q++;
        }
    }
    kol[j] = q;
    koli[j] = j;
    q = 0;
}
for (int i = 0; i < n; i += 1)
{
    for (int j = 0; j < n-1; j += 1)
    {
        if (kol[j] < kol[j + 1])
        {
            z = kol[j];
            kol[j] = kol[j + 1];
            kol[j + 1] = z;
            z = koli[j];
            koli[j] = koli[j + 1];
            koli[j + 1] = z;
        }
    }
}
for (int j = 0; j < n; j += 1)
{
    for (int i = 0; i < n; i += 1)
    {
        b[j, i] = a[koli[j], i];
    }
}
Console.WriteLine("");
for (int j = 0; j < n; j += 1)
{
    for (int i = 0; i < n; i += 1)
    {
        Console.Write($"{b[j, i]} ");
    }
    Console.WriteLine();
}

//Task 3.10
Console.WriteLine("Task 3.10");
Console.WriteLine("Введите n");
u = Console.ReadLine().Split();
if (u.Length == 1)
{
    if (int.TryParse(u[0], out z))
    {
        n = z;
    }
    else
    {
        Console.WriteLine("Неверный ввод");
    }
}
Console.WriteLine("Введите m");
u = Console.ReadLine().Split();
if (u.Length == 1)
{
    if (int.TryParse(u[0], out z))
    {
        m = z;
    }
    else
    {
        Console.WriteLine("Неверный ввод");
    }
}
a = new double[n, m];
b = new double[n, m];
for (int j = 0; j < n; j += 1)
{
    Console.WriteLine($"Введите {j} строку");
    string[] g = Console.ReadLine().Split();
    if (g.Length == n)
    {
        for (int i = 0; i < g.Length; i += 1)
        {
            if (double.TryParse(g[i], out x))
            {
                a[j, i] = x;
            }
            else
            {
                Console.WriteLine("Неверный ввод");
            }
        }
    }
    else
    {
        Console.WriteLine("Неверный ввод");
        Environment.Exit(0);
    }
}
double[] ar = new double[m];
for (int j = 0; j < n; j += 1)
{
    for (int i = 0; i < m; i += 1)
    {
        ar[i] = a[j, i];
    }
    Array.Sort(ar);
    if(j%2==0)
    {
        for (int i = 0; i < m; i += 1)
        {
            b[j, i] = ar[m-1-i];
        }
    }
    else
    {
        for (int i = 0; i < m; i += 1)
        {
            b[j, i] = ar[i];
        }
    }
}
Console.WriteLine("");
for (int j = 0; j < n; j += 1)
{
    for (int i = 0; i < m; i += 1)
    {
        Console.Write($"{b[j, i]} ");
    }
    Console.WriteLine();
}

//Task 3.11
Console.WriteLine("Task 3.11");
Console.WriteLine("Введите n");
u = Console.ReadLine().Split();
if (u.Length == 1)
{
    if (int.TryParse(u[0], out z))
    {
        n = z;
    }
    else
    {
        Console.WriteLine("Неверный ввод");
    }
}
Console.WriteLine("Введите m");
u = Console.ReadLine().Split();
if (u.Length == 1)
{
    if (int.TryParse(u[0], out z))
    {
        m = z;
    }
    else
    {
        Console.WriteLine("Неверный ввод");
    }
}
a = new double[n, m];
for (int j = 0; j < n; j += 1)
{
    Console.WriteLine($"Введите {j} строку");
    string[] g = Console.ReadLine().Split();
    if (g.Length == n)
    {
        for (int i = 0; i < g.Length; i += 1)
        {
            if (double.TryParse(g[i], out x))
            {
                a[j, i] = x;
            }
            else
            {
                Console.WriteLine("Неверный ввод");
            }
        }
    }
    else
    {
        Console.WriteLine("Неверный ввод");
        Environment.Exit(0);
    }
}
q = 0;
int kl = 0;
for (int j = 0; j < n; j += 1)
{
    for (int i = 0; i < m; i += 1)
    {
        if (a[j,i] ==0)
        {
            q = 1;
        }
    }
    kl += q;
    q = 0;
}
b = new double[n-kl, m];
q = 0;
z = 0;
for (int j = 0; j < n; j += 1)
{
    for (int i = 0; i < m; i += 1)
    {
        if (a[j, i] == 0)
        {
            q = 1;
        }
    }
    if (q==0)
    {
        for (int i = 0; i < m; i += 1)
        {
            b[z,i] = a[j, i];
        }
        z++;
    }
    q = 0;
}
Console.WriteLine("");
for (int j = 0; j < n-kl; j += 1)
{
    for (int i = 0; i < m; i += 1)
    {
        Console.Write($"{b[j, i]} ");
    }
    Console.WriteLine();
}