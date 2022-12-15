// See https://aka.ms/new-console-template for more information

#region 1.3
int[,]arr=new int[4,4];
int s=0;
int m=0;
for(int y=0;y<4; y++){
    for(int x=0;x<4;x++){
        arr[y,x]=1;
    }
}
for(int y=0;y<4;y++){
    s+=arr[y,m];
    m++;
}
Console.WriteLine(s);
#endregion

#region 1.6
int[,]arr=new int[4,7];
string[]mins=new string[28];
int min=1000000,z=0;
for(int x=0;x<4;x++){
    for(int y=0;y<7;y++){
        arr[x,y]=22;
    }
}

for(int x=0;x<4;x++){
    for(int y=0;y<7;y++){
        if(arr[x,y]<min){
            min=arr[x,y];
        }
    }
}
for(int x=0;x<4;x++){
    for(int y=0;y<7;y++){
        if(arr[x,y]==min){
            mins[z]=($"x={x}; y={y}");
            z++;
        }
    }
}
for(int y=0;y<mins.Length;y++){
    Console.WriteLine(mins[y]);
}
#endregion 

#region 1.12
int[,]arr=new int[6,7];
int maxx=0,maxy=0;
int max=-1000000;
Random random= new Random();
for(int y=0;y<arr.GetLength(0);y++){
    for(int x=0;x<arr.GetLength(1);x++){
        arr[y,x]=random.Next(10,50);
    }
}
Console.WriteLine("Матрица:");
for(int y=0;y<6;y++){
    for(int x=0;x<7;x++){
        Console.Write($"{arr[y,x]} ");
    }
    Console.WriteLine();
}
for(int y=0;y<6;y++){
    for(int x=0;x<7;x++){
        if(arr[y,x]>max){
            max=arr[y,x];
            maxx=x;
            maxy=y;
        }
    }
}
for(int x=maxx;x<5;x++){
    for(int y=0;y<7;y++){
        arr[x,y]=arr[x+1,y];
    }
}
for(int x=0;x<5;x++){
    for(int y=maxy;y<6;y++){
        arr[x,y]=arr[x,y+1];
    }
}
Console.WriteLine("Максимальное число:" + max);
Console.WriteLine("Новая матрица:");
for(int y=0;y<5;y++){
    for(int x=0;x<6;x++){
        Console.Write($"{arr[y,x]} ");
    }
    Console.WriteLine();
}
#endregion

#region 1.13
int[,]arr=new int[5,5];
int maxx=0,maxy=0,z=0;
int max=-1000000;
Random random= new Random();
for(int y=0;y<arr.GetLength(0);y++){
    for(int x=0;x<arr.GetLength(1);x++){
        arr[y,x]=random.Next(10,50);
    }
}
Console.WriteLine("Матрица:");
for(int y=0;y<5;y++){
    for(int x=0;x<5;x++){
        Console.Write($"{arr[y,x]} ");
    }
    Console.WriteLine();
}
for(int y=0;y<5;y++){
    for(int x=0;x<5;x++){
        if(y==x){
            if(arr[y,x]>max){
                max=arr[y,x];
                maxy=y;
                maxx=x;
            }
        }
    }
}
for(int y=0;y<5;y++){
    for(int x=0;x<5;x++){
        z=arr[y,maxx];
        if(x==3){
            arr[y,maxx] = arr[y,x];
            arr[y,x] = z;
        }
    }
    
}
Console.WriteLine("Новая матрица:");
for(int y=0;y<5;y++){
    for(int x=0;x<5;x++){
        Console.Write($"{arr[y,x]} ");
    }
    Console.WriteLine();
}
#endregion

#region 1.17
int n=0,m=0;
try{
    Console.WriteLine("Введите x матрицы");
     n=Convert.ToInt32(Console.ReadLine());
}
catch(Exception){}
try{
    Console.WriteLine("Введите y матрицы");
     m=Convert.ToInt32(Console.ReadLine());
}
catch(Exception){}
int[,]arr=new int[n,m];
Random random= new Random();
for(int y=0;y<arr.GetLength(0);y++){
    for(int x=0;x<arr.GetLength(1);x++){
        arr[y,x]=random.Next(10,50);
    }
}
Console.WriteLine("Матрица:");
for(int y=0;y<n;y++){
    for(int x=0;x<m;x++){
        Console.Write($"{arr[y,x]} ");
    }
    Console.WriteLine();
}
int min, minx, z;
for(int y = 0; y < n; y++)
{
    min = arr[y, 0];
    minx = 0;
    for(int x = 0; x < m; x++)
    {
        if(arr[y,x] < min)
        {
            min = arr[y,x];
            minx = x;
        }
    }
    while(minx != 0)
    {
        z = arr[y, minx];
        arr[y, minx] = arr[y, minx - 1];
        arr[y, minx - 1] = z;
        minx--;
    }
}
Console.WriteLine("Новая матрица:");
for(int y=0;y<n;y++){
    for(int x=0;x<m;x++){
        Console.Write($"{arr[y,x]} ");
    }
    Console.WriteLine();
}
#endregion

#region 1.29
int[,]arr=new int[5,7];
Random random= new Random();
for(int y=0;y<arr.GetLength(0);y++){
    for(int x=0;x<arr.GetLength(1);x++){
        arr[y,x]=random.Next(10,50);
    }
}
Console.WriteLine("Матрица:");
for(int y=0;y<5;y++){
    for(int x=0;x<7;x++){
        Console.Write($"{arr[y,x]} ");
    }
    Console.WriteLine();
}
int min_abs = Math.Abs(arr[1, 0]);
int minx = 0;
for (int x = 0; x < 7; x++)
{
    if (Math.Abs(arr[1, x]) < min_abs)
    {
        min_abs = Math.Abs(arr[1, x]);
        minx = x;
    }
}
for (int y = 0; y < 5; y++)
{
    for (int x = minx; x < 7 - 1; x++)
    {
        arr[y, x] = arr[y, x + 1];
    }
}
Console.WriteLine("Новая матрица:");
for(int y=0;y<5;y++){
    for(int x=0;x<6;x++){
        Console.Write($"{arr[y,x]} ");
    }
    Console.WriteLine();
}
#endregion

#region 1.31
int[,]arr = new int[5,8];
int[]arr2 = new int[]{88,88,88,88,88};
int min=100000;
int minx=0;
Random random= new Random();
for(int y=0;y<arr.GetLength(0);y++){
    for(int x=0;x<arr.GetLength(1)-1;x++){
        arr[y,x]=random.Next(10,50);
    }
}
Console.WriteLine("Матрица:");
for(int y=0;y<5;y++){
    for(int x=0;x<8;x++){
        Console.Write($"{arr[y,x]} ");
    }
    Console.WriteLine();
}
for(int y=0;y<5;y++){
    for(int x=0; x<7;x++){
        if(arr[4, x]<min){
            min=arr[4, x];
            minx=x;
        }
    }
}
for(int y=0;y<5;y++){
    for (int x =7; x > minx; x--)
    {
        arr[y, x] = arr[y, x - 1];
    }
     arr[y, minx + 1] = arr2[y];
}
Console.WriteLine(min);
Console.WriteLine("Новая матрица:");
for(int y=0;y<5;y++){
    for(int x=0;x<8;x++){
        Console.Write($"{arr[y,x]} ");
    }
    Console.WriteLine();
}
#endregion

#region 2.7
int[,]arr=new int[6,6];
Random random= new Random();
for(int y=0;y<arr.GetLength(0);y++){
    for(int x=0;x<arr.GetLength(1);x++){
        arr[y,x]=random.Next(10,50);
    }
}
Console.WriteLine("Матрица:");
for(int y=0;y<6;y++){
    for(int x=0;x<6;x++){
        Console.Write($"{arr[y,x]} ");
    }
    Console.WriteLine();
}
int z=0;
int max=-10000;
int maxy=-10000;
int maxx=-10000;
for(int x=0;x<6;x++){
    if(arr[z,x]>max){
        max=arr[z,x];
        maxy=z;
        maxx=x;
    }
    z++;
}
Console.WriteLine(max);
for(int y=0;y<maxy;y++){
    for(int x=maxy;x<6;x++){
            arr[y,x]=0;
    }
}
Console.WriteLine("Новая матрица:");
for(int y=0;y<6;y++){
    for(int x=0;x<6;x++){
        Console.Write($"{arr[y,x]} ");
    }
    Console.WriteLine();
}
#endregion

#region 2.8
int[,]arr=new int[6,6];
Random random= new Random();
for(int y=0;y<arr.GetLength(0);y++){
    for(int x=0;x<arr.GetLength(1);x++){
        arr[y,x]=random.Next(10,50);
    }
}
Console.WriteLine("Матрица:");
for(int y=0;y<6;y++){
    for(int x=0;x<6;x++){
        Console.Write($"{arr[y,x]} ");
    }
    Console.WriteLine();
}
for (int y = 0; y < 6; y += 2)
{
    int max = arr[y, 0];
    int maxx = 0;
    int max2 = arr[y + 1, 0];
    int max2x = 0;
    int c;
    for (int x = 0; x < 6; x++)
    {
        if (arr[y, x] > max)
        {
            max = arr[y, x];
            maxx = x;
        }

        if (arr[y + 1, x] > max2)
        {
            max2 = arr[y + 1, x];
            max2x = x;
        }
    }
    c = arr[y, maxx];
    arr[y, maxx] = arr[y + 1, max2x];
    arr[y+ 1, max2x] = c;
}


Console.WriteLine("Новая матрица:");
for(int y=0;y<6;y++){
    for(int x=0;x<6;x++){
        Console.Write($"{arr[y,x]} ");
    }
    Console.WriteLine();
}
#endregion

#region 2.9
int[,] arr=new int[6,7];
Random random= new Random();
for(int y=0;y<arr.GetLength(0);y++){
    for(int x=0;x<arr.GetLength(1);x++){
        arr[y,x]=random.Next(10,50);
    }
}
Console.WriteLine("Матрица:");
for(int y=0;y<6;y++){
    for(int x=0;x<7;x++){
        Console.Write($"{arr[y,x]} ");
    }
    Console.WriteLine();
}
int c=0;
for (int y = 0; y < 6; y++)
{
    for (int x = 0; x < 4; x++)
    {
        c = arr[y, x];
        arr[y, x] = arr[y, 6 - x];
        arr[y, 6 - x] = c;
    }
}
Console.WriteLine("Новая матрица:");
for(int y=0;y<6;y++){
    for(int x=0;x<7;x++){
        Console.Write($"{arr[y,x]} ");
    }
    Console.WriteLine();
}
#endregion

#region 3.1
int n = 7, m = 5;
int[,] arr = new int[n, m];
Random random= new Random();
for(int y=0;y<arr.GetLength(0);y++){
    for(int x=0;x<arr.GetLength(1);x++){
        arr[y,x]=random.Next(10,50);
    }
}
Console.WriteLine("Матрица:");
for(int y=0;y<7;y++){
    for(int x=0;x<5;x++){
        Console.Write($"{arr[y,x]} ");
    }
    Console.WriteLine();
}
int[] b = new int [n];
for (int y = 0; y < n; y++)
{
    int min = arr[y, 0];
    for (int x = 1; x < m; x++)
    {
        if (arr[y, x] < min)
        {
            min = arr[y, x];
        }
    }
    b[y] = min;
}
//foreach (int x in b) Console.WriteLine(x);
int el = 1;
int temp;
while (el < n)
{
    if (el == 0 || b[el] <= b[el - 1])
    {
        el++;
    }
    else
    {
        temp = b[el - 1];
        b[el - 1] = b[el];
        b[el] = temp;
        for (int x = 0; x < m; x++)
        {
            temp = arr[el - 1, x];
            arr[el - 1, x] = arr[el, x];
            arr[el, x] = temp;
        }
        el--;
    }
}
Console.WriteLine("Новая матрица:");
for (int y = 0; y < n; y++)
{
    for (int x = 0; x < m; x++)
    {
        Console.Write($"{arr[y, x]} ");
    }
    Console.WriteLine();
}
#endregion

#region 3.2
int n = 5;
int[,] arr = new int[n, n];
Random random= new Random();
for(int y=0;y<arr.GetLength(0);y++){
    for(int x=0;x<arr.GetLength(1);x++){
        arr[y,x]=random.Next(0,10);
    }
}
Console.WriteLine("Матрица:");
for(int y=0;y<n;y++){
    for(int x=0;x<n;x++){
        Console.Write($"{arr[y,x]} ");
    }
    Console.WriteLine();
}
for (int y = 0; y < n; y++){
    arr[0, y] = 0;
    arr[n-1, y] = 0;
    arr[y, 0] = 0;
    arr[y, n-1] = 0;
}
Console.WriteLine("Новая матрица:");
for (int y = 0; y < n; y++){
    for (int x = 0; x < n; x++){
        Console.Write($"{arr[y, x]} ");
    }
    Console.WriteLine();
}
#endregion

#region 3.3
Console.WriteLine("Введите размер квадратной матрицы(n)");
int n = Convert.ToInt32(Console.ReadLine());
int[,] arr = new int[n, n];
Random random= new Random();
for(int y=0;y<arr.GetLength(0);y++){
    for(int x=0;x<arr.GetLength(1);x++){
        arr[y,x]=random.Next(0,10);
    }
}
Console.WriteLine("Матрица:");
for(int y=0;y<n;y++){
    for(int x=0;x<n;x++){
        Console.Write($"{arr[y,x]} ");
    }
    Console.WriteLine();
}
int[] arr2 = new int[2*n - 1];
for (int y = 0; y < n; y++){
    int sum1 = 0, sum2 = 0;
    for (int x = 0; x <= y; x++){
        sum1 += arr[n - 1 - y + x, x];
        sum2 += arr[x, n - 1 - y + x];
    }
    arr2[y] = sum1;
    arr2[(2*n - 1) - 1 - y] = sum2;
}
Console.WriteLine("Вектор:");
foreach (int x in arr2) Console.Write($"{x} ");
#endregion

#region 3.4
Console.WriteLine("Введите размер квадратной матрицы(n)");
int n = Convert.ToInt32(Console.ReadLine());
int[,] arr = new int[n, n];
Random random= new Random();
for(int y=0;y<arr.GetLength(0);y++){
    for(int x=0;x<arr.GetLength(1);x++){
        arr[y,x]=random.Next(0,10);
    }
}
Console.WriteLine("Матрица:");
for(int y=0;y<n;y++){
    for(int x=0;x<n;x++){
        Console.Write($"{arr[y,x]} ");
    }
    Console.WriteLine();
}
for (int y = (int)(Math.Round((double)n / 2)); y < n; y++){
    for (int x = 0; x <= y; x++){
        arr[y, x] = 0;
    }
}
Console.WriteLine("Новая матрица:");
for (int y = 0; y < n; y++){
    for (int x = 0; x < n; x++){
        Console.Write($"{arr[y, x]} ");
    }
    Console.WriteLine();
}
#endregion

#region 3.8
int n = 7, m = 5;
int[,] arr = new int[n, m];
Random random= new Random();
for(int y=0;y<arr.GetLength(0);y++){
    for(int x=0;x<arr.GetLength(1);x++){
        arr[y,x]=random.Next(-10,10);
    }
}
Console.WriteLine("Матрица:");
for(int y=0;y<n;y++){
    for(int x=0;x<m;x++){
        Console.Write($"{arr[y,x],3} ");
    }
    Console.WriteLine();
}
int[] arr2 = new int [n];
for (int y = 0; y < n; y++){
    int cnt_positive = 0;
    for (int x = 0; x < m; x++){
        if (arr[y, x] > 0) cnt_positive++;
    }
    arr2[y] = cnt_positive;
}

// Console.Write("arr2 = ");
// foreach (int x in arr2) Console.Write($"{x} ");

int element = 1;
int temp;
while (element < n){
    if (element == 0 || arr2[element] <= arr2[element - 1]){
        element++;
    }

    else{
        temp = arr2[element - 1];
        arr2[element - 1] = arr2[element];
        arr2[element] = temp;

        for (int x = 0; x < m; x++){
            temp = arr[element - 1, x];
            arr[element - 1, x] = arr[element, x];
            arr[element, x] = temp;
        }

        element--;
    }
}

Console.WriteLine("Новая матрица:");
for (int y = 0; y < n; y++){
    for (int x = 0; x < m; x++){
        Console.Write($"{arr[y, x],3} ");
    }
    Console.WriteLine();
}
#endregion

#region 3.10

   static void ShellSort(int[,] matrix, int row, int a)
{
    if (a == 0)
    {
        var step = matrix.GetLength(1) / 2;
        while (step > 0)
        {
            for (int y = step; y < matrix.GetLength(1); y++)
            {
                int x = y;
                while ((x >= step) && matrix[row, x - step] < matrix[row, x])
                {
                    var temp = matrix[row, x - step];
                    matrix[row, x - step] = matrix[row, x];
                    matrix[row, x] = temp;
                    x -= step;
                }
            }
            step /= 2;
        }
    }
    else if (a == 1)
    {
        var step = matrix.GetLength(1) / 2;
        while (step > 0)
        {
            for (int y = step; y < matrix.GetLength(1); y++)
            {
                int x = y;
                while ((x >= step) && matrix[row, x - step] > matrix[row, x])
                {
                    var temp = matrix[row, x - step];
                    matrix[row, x - step] = matrix[row, x];
                    matrix[row, x] = temp;
                    x -= step;
                }
            }
            step /= 2;
        }
    }
}
int n = Convert.ToInt32(Console.ReadLine()), m = Convert.ToInt32(Console.ReadLine());
int[,] A = new int[n, m];
for (int y = 0; y < n; y++)
{
    for (int x = 0; x < m; x++)
    {
        do
        {
        }
        while (!int.TryParse(Console.ReadLine(), out A[y, x]));
    }
}
for (int y = 0; y < n; y++) ShellSort(A, y, y % 2);
Console.WriteLine();
for (int y = 0; y < n; y++)
{
    for (int x = 0; x < m; x++)
    {
        Console.Write($"{A[y, x],3} ");
    }
    Console.WriteLine();
}
#endregion

#region 3.11
int n = 5, m = 5;
int[,] arr = new int[n, m];
Random random= new Random();
for(int y=0;y<arr.GetLength(0);y++){
    for(int x=0;x<arr.GetLength(1);x++){
        arr[y,x]=random.Next(-5,5);
    }
}
Console.WriteLine("Матрица:");
for(int y=0;y<n;y++){
    for(int x=0;x<m;x++){
        Console.Write($"{arr[y,x],3} ");
    }
    Console.WriteLine();
}
bool[] check = new bool[n];
for (int y = 0; y < n; y++){
    bool zero = false;
    for (int x = 0; x < m; x++){
        if (arr[y, x] == 0){
            zero = true;
        }
    }
    check[y] = zero;
}
int[,] arr2 = new int[n, m];
int c = 0;
for (int y = 0; y < n; y++){
    if (check[y]){
        continue;
    }
    for (int x = 0; x < m; x++){
        arr2[c, x] = arr[y, x];
    }
    c++;
}
Console.WriteLine("Новая матрица:");
for (int y = 0; y < n; y++){
    for (int x = 0; x < m; x++){
        Console.Write($"{arr2[y, x],3} ");
    }
    Console.WriteLine();
}
#endregion
