
static void Main()
{

    static double[][] AAA()
    {
        double[][] flag = new double[1][];

        try
        {
            Console.WriteLine("Enter str");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter stlb");
            int y = int.Parse(Console.ReadLine());

            double[][] arr = new double[x][];

            for (int i = 0; i < x; i++)
            {
                double[] a = new double[y];
                for (int j = 0; j < y; j++)
                {
                    a[j] = double.Parse(Console.ReadLine());
                }

                arr[i] = a;
            }
            return arr;
        }
        catch (Exception)
        {
            Console.WriteLine("Error");
            return flag;
        }
    }
    double[][] b = AAA();
    int index = 1;
    int next = index + 1;
    double temp = 0;
    for (int i = 0; i < b.Length; i++)
    {
        if (i % 2 != 0)
        {
            while (index < b.Length)
            {
                if (b[i][index - 1] < b[i][index])
                {
                    index = next;
                    next++;
                }
                else
                {
                    temp = b[i][index - 1];
                    b[i][index - 1] = b[i][index];
                    b[i][index] = temp;
                    index--;
                    if (index == 0)
                    {
                        index = next;
                        next++;
                    }

                }
            }
        }
        if (i % 2 == 0)
        {
            while (index < b.Length)
            {
                if (b[i][index - 1] > b[i][index])
                {
                    index = next;
                    next++;
                }
                else
                {
                    temp = b[i][index - 1];
                    b[i][index - 1] = b[i][index];
                    b[i][index] = temp;
                    index--;
                    if (index == 0)
                    {
                        index = next;
                        next++;
                    }
                }
            }
        }
        for (int ii = 0; ii < b.Length; ii++)
        {
            for (int j = 0; j < b[ii].Length; j++)
            {
                Console.Write(b[ii][j] + " ");
            }
            Console.WriteLine();
        }
    }
}
