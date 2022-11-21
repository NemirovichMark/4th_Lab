using System;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;
using static System.Math;
{
    /*
    Console.WriteLine("N1.3:");
    double x;
    double s = 0;
    double q = 0;
    const int n = 4;
    double[,] mas= new double[n, n];
    for(int i = 0; i <4;i++)
    {
        string[] a = Console.ReadLine().Split();
        for(int j=0;j<a.Length;j++)
        {
            if (a.Length==4)
            {
                bool y = double.TryParse(a[j], out x);
                if (y == true)
                {
                    mas[i, j] = x;
                }
                else
                {
                    Console.WriteLine("Неверный ввод");
                    Environment.Exit(0);
                }
            }
            else
            {
                Console.WriteLine("Неверный ввод");
                Environment.Exit(0);
            }
        }
    }
    s = mas[0, 0] + mas[1,1] + mas[2,2] + mas[3,3];
    Console.WriteLine($"Искомая сумма равна {s}");
    

    Console.WriteLine("N1.6:");
    const int b1 = 4;
    const int b2 = 7;
    double ys;
    double[] minmas = new double[b1];
    double[,] mass = new double[b1, b2];
    for (int i = 0; i < b1; i++)
    {
        string[] u = Console.ReadLine().Split();
        for (int j = 0; j < u.Length; j++)
        {
            if (u.Length == b2)
            {
                bool t = double.TryParse(u[j], out ys);
                if (t == true)
                {
                    mass[i, j] = ys;
                }
                else
                {
                    Console.WriteLine("Неверный ввод");
                    Environment.Exit(0);
                }
            }
            else
            {
                Console.WriteLine("Неверный ввод");
                Environment.Exit(0);
            }
        }
    }
    double min = Pow(10,9);
    double imin = 1000;
    int z = 0;
    for(int i = 0; i < b1; i++)
    {
        for(int j = 0; j < b2; j++)
        {
           if (mass[i, j] < min)
            {
                min= mass[i, j];
                imin = j;
            }    
        }
        minmas[z] = imin;
        min = Pow(10, 9);
        z++;
    }
    for(int i=0;i<minmas.Length;i++)
    {
        Console.Write($"{minmas[i]} ");
    }
    Console.WriteLine();
    

    Console.WriteLine("N1.12");
    double v;
    const int a1 = 6;
    const int a2 = 7;
    double[,] m = new double[a1, a2];
    double[,] ma = new double[a1-1, a2-1];
    for (int i = 0; i < a1; i++)
    {
        string[] ut = Console.ReadLine().Split();
        for (int j = 0; j < ut.Length; j++)
        {
            if (ut.Length == a2)
            {
                bool t = double.TryParse(ut[j], out v);
                if (t == true)
                {
                    m[i, j] = v;
                }
                else
                {
                    Console.WriteLine("Неверный ввод");
                    Environment.Exit(0);
                }
            }
            else
            {
                Console.WriteLine("Неверный ввод");
                Environment.Exit(0);
            }
        }
    }
        double maxx = 0;
        int inmax = 0;
        int jmax = 0;
        for(int i = 0; i <a1; i++)
        {
            for(int j = 0; j < a2; j++)
            {
            if (m[i, j] > maxx)
            {
                maxx = m[i, j];
                inmax = i;
                jmax = j;
            }

            }
        }
    int wdr1 = 0;
    int wdr2 = 0;
    for (int i = 0; i < a1; i++)
    {
        for (int j = 0; j < a2; j++)
        {
            if(i==inmax)
            {
                wdr2 = i - 1;
                break;
            }
            if(j!=jmax)
            {
                ma[wdr1, wdr2] = m[i, j];
                wdr1++;
            }
        }
        wdr1 = 0;
        wdr2++;
    }
    for (int i = 0; i < a1-1; i++)
    {
        for (int j = 0; j < a2-1; j++)
        {
            Console.Write($"{ma[i, j]} ");
        }
        Console.WriteLine();
    }
    
    
    Console.WriteLine("N1.13");
    const int c1 = 5;
    const int c2 = 5;
    double vi;
    double[,] jh = new double[c1, c2];
    for (int i = 0; i < c1; i++)
    {
        string[] ust = Console.ReadLine().Split();
        for (int j = 0; j < ust.Length; j++)
        {
            if (ust.Length == c2)
            {
                bool t = double.TryParse(ust[j], out vi);
                if (t == true)
                {
                    jh[i, j] = vi;
                }
                else
                {
                    Console.WriteLine("Неверный ввод");
                    Environment.Exit(0);
                }
            }
            else
            {
                Console.WriteLine("Неверный ввод");
                Environment.Exit(0);
            }
        }
    }
    Console.WriteLine();
    int jmaxi = 0;
    double MAX = 0;
    for(int i = 0; i < c1; i++)
    {
            if (jh[i, i] > MAX)
            {
                MAX= jh[i, i];
                jmaxi = i;
            }
            
    }
    for(int i = 0; i < c1; i++)
    {
        double ir = 0;
        ir=jh[i, 3];
        jh[i, 3] = jh[i, jmaxi];
        jh[i, jmaxi] = ir;
    }
    for(int i = 0; i < c1; i++)
    {
        for(int j = 0; j < c2; j++)
        {
            Console.Write($"{jh[i, j]} ");
        }
        Console.WriteLine();
    }
    

    Console.WriteLine("N1.17:");
    int n1 = 0;
    int m1 = 0;
    int Q;
    string QI1 = Console.ReadLine();
    string QI2 = Console.ReadLine();
    bool we1 = Int32.TryParse(QI1, out Q);
    if(we1==true)
    {
        n1 = Q;
    }
    else
    {
        Console.WriteLine("Неверный ввод");
        Environment.Exit(0);
    }
    bool we2 = Int32.TryParse(QI2, out Q);
    if (we2 == true)
    {
        m1 = Q;
    }
    else
    {
        Console.WriteLine("Неверный ввод");
        Environment.Exit(0);
    }
    double vi1;
    double[,] dsd = new double[n1, m1];
    for (int i = 0; i < n1; i++)
    {
        string[] stu = Console.ReadLine().Split();
        for (int j = 0; j < stu.Length; j++)
        {
            if (stu.Length == m1)
            {
                bool t = double.TryParse(stu[j], out vi1);
                if (t == true)
                {
                   dsd[i, j] = vi1;
                }
                else
                {
                    Console.WriteLine("Неверный ввод");
                    Environment.Exit(0);
                }
            }
            else
            {
                Console.WriteLine("Неверный ввод");
                Environment.Exit(0);
            }
        }
    }
    for (int i = 0; i < n1; i++)
    {
        string[] dea = new string[m1 + 1];
        double mih = 1000000;
        int mihi = 0;
        for (int j = 0; j < m1; j++)
        {
            dea[j + 1] = Convert.ToString(dsd[i, j]);
            if (dsd[i, j] < mih)
            {
                mih = dsd[i, j];
                mihi = j;
            }
        }
        dea[0] = Convert.ToString(mih);
        int zr = 0;
        for (int j = 0; j < m1; j++)
        {
            if (zr == mihi + 1)
            {
                if (zr + 1 == dea.Length)
                {
                    break;
                }
                else
                {
                    dsd[i, j] = Convert.ToDouble(dea[zr+1]);
                    zr+=2;
                }

            }
            else
            {
                dsd[i, j] = Convert.ToDouble(dea[zr]);
                zr++;
            }
        }

    }
    Console.WriteLine();
    for(int i = 0; i < n1; i++)
    {
        for(int j = 0; j < m1; j++)
        {
            Console.Write($"{dsd[i, j]} ");
        }
        Console.WriteLine();
    }
    



    Console.WriteLine("N1.29:");
    const int A = 5;
    const int B = 7;
    double V;
    double[,] M = new double[A, B];
    double[,] Ma = new double[A, B - 1];
    for (int i = 0; i < A; i++)
    {
        string[] qwer = Console.ReadLine().Split();
        for (int j = 0; j < qwer.Length; j++)
        {
            if (qwer.Length == B)
            {
                bool tq = double.TryParse(qwer[j], out V);
                if (tq == true)
                {
                    M[i, j] = V;
                }
                else
                {
                    Console.WriteLine("Неверный ввод");
                    Environment.Exit(0);
                }
            }
            else
            {
                Console.WriteLine("Неверный ввод");
                Environment.Exit(0);
            }
        }
    }
    double MIN = 10000;
    int IMIN = 1000;
    for (int i = 0; i < B; i++)
    {
        if (Abs(M[2, i]) < MIN)
        {
            MIN = Abs(M[2, i]);
            IMIN = i;
        }
    }
    int ZR = 0;
    for(int i = 0; i < A; i++)
    {
        for (int j = 0; j < B;j++)
        {
            if (j != IMIN)
            {
                Ma[i, ZR] = M[i,j];
                ZR++;
            }
        }
        ZR = 0;
    }
    for(int i = 0; i < A; i++)
    {
        for (int j = 0; j < B-1; j++)
        {
            Console.Write($"{Ma[i, j]} ");
        }
        Console.WriteLine();
    }    
    


    Console.WriteLine("N1.31:");
    const int B1 = 5;
    const int B2 = 7;
    double[,] IQ1 = new double[B1, B2];
    double[,] IQ2 = new double[B1, B2 + 1];
    double GG;
    double counter=0;
    string[] vektor1 = Console.ReadLine().Split();
    double[] vektor2 = new double[vektor1.Length];
    for(int i=0;i<vektor1.Length;i++)
    {
        bool RTX = double.TryParse(vektor1[i], out GG);
        if( RTX ==true)
        {
            vektor2[i] = GG;
            counter++;
        }
        else
        {
            Environment.Exit(0);
        }
        
    }
    if (counter == 5)
    {
        for (int i = 0; i < B1; i++)
        {
            string[] dasf = Console.ReadLine().Split();
            for (int j = 0; j < dasf.Length; j++)
            {
                if (dasf.Length == B2)
                {
                    bool Wq = double.TryParse(dasf[j], out GG);
                    if (Wq == true)
                    {
                        IQ1[i, j] = GG;
                    }
                    else
                    {
                        Console.WriteLine("Неверный ввод");
                        Environment.Exit(0);
                    }
                }
                else
                {
                    Console.WriteLine("Неверный ввод");
                    Environment.Exit(0);
                }
            }
        }
        double MINI = 10000;
        int IMINI = 19139;
        for (int j = 0; j < B2; j++)
        {
            if (IQ1[4, j] < MINI)
            {
                MINI = IQ1[4, j];
                IMINI = j;
            }
        }
        int kv = 0;
        int brt = 0;
        for (int i = 0; i < B1; i++)
        {
            for (int j = 0; j < B2; j++)
            {
                if (j != IMINI)
                {
                    IQ2[i, brt] = IQ1[i, j];
                    brt++;
                }
                else
                {
                    IQ2[i, brt] = IQ1[i, j];
                    IQ2[i, brt + 1] = vektor2[kv];
                    brt += 2;
                    kv++;

                }
            }
            brt = 0;
        }
        for (int i = 0; i < B1; i++)
        {
            for (int j = 0; j < B2 + 1; j++)
            {
                Console.Write($"{IQ2[i, j]} ");
            }
            Console.WriteLine();
        }
    }
    else
    {
        Console.WriteLine("Неверный ввод");
    }
    
    

    Console.WriteLine("N2.7:");
    const int RE1 = 6;
    const int RE2 = 6;
    double EXO;
    double[,] wex = new double[RE1, RE2];
    for (int i = 0; i < RE1; i++)
        {
            string[] zil = Console.ReadLine().Split();
            for (int j = 0; j < zil.Length; j++)
            {
                if (zil.Length == RE2)
                {
                    bool joke = double.TryParse(zil[j], out EXO);
                    if (joke == true)
                    {
                        wex[i, j] = EXO;
                    }
                    else
                    {
                        Console.WriteLine("Неверный ввод");
                        Environment.Exit(0);
                    }
                }
                else
                {
                    Console.WriteLine("Неверный ввод");
                    Environment.Exit(0);
                }
            }
        }
    double maxq = 0;
    int indexm = 0;
    for(int i = 0; i < RE1; i++)
    {
        if (wex[i,i]>maxq)
        {
            maxq = wex[i,i];
            indexm = i;
        }    
    }
    for(int i = 0; i < RE1; i++)
    {
        for(int j=0;j<RE2;j++)
        {
            if(i!=indexm)
            {
               if(j>i)
                {
                    wex[i, j] = 0;
                }
            }
            else
            {
                for (int a = 0; a < RE1; a++)
                {
                    for (int b = 0; b < RE2; b++)
                    {
                        Console.Write($"{wex[a, b]} ");
                    }
                    Console.WriteLine();
                }
                Environment.Exit(0);
            }
        }
    }
    
    

    Console.WriteLine("N2.8:");
    const int RT1 = 6;
    const int RT2 = 6;
    double invo;
    double[,] qvas = new double[RT1, RT2];
    for (int i = 0; i < RT1; i++)
    {
        string[] zis = Console.ReadLine().Split();
        for (int j = 0; j < zis.Length; j++)
        {
            if (zis.Length == RT2)
            {
                bool joke = double.TryParse(zis[j], out invo);
                if (joke == true)
                {
                    qvas[i, j] = invo;
                }
                else
                {
                    Console.WriteLine("Неверный ввод");
                    Environment.Exit(0);
                }
            }
            else
            {
                Console.WriteLine("Неверный ввод");
                Environment.Exit(0);
            }
        }
    }
    int chear1 = 0;
    int chear2 = 0;
    while(chear2<RT1)
    {
        double maga1 = 0;
        int maxdexa1 = 0;
        int maxdexa2 = 0;
        double maga2 = 0;
        for(int i = chear1; i < chear2+2; i++)
        {
            for(int j = 0; j < RT2; j++)
            {
                if(qvas[i, j]>maga1)
                {
                    maga2 = qvas[i, j];
                    maxdexa2 = j;
                }   
            }
            if (i % 2 == 0)
            {
                maxdexa1 = maxdexa2;
                maga1 = maga2;
            }
            else
            {
                qvas[chear2,maxdexa1]=qvas[chear2+1,maxdexa2];
                qvas[chear2 + 1, maxdexa2] = maga1;

            }
            maxdexa2 = 0;
            maga2 = 0;
        }
        chear2 +=2;
        chear1 = chear2;
    }
    Console.WriteLine();
    for (int a = 0; a < RT1; a++)
    {
        for (int b = 0; b < RT2; b++)
        {
            Console.Write($"{qvas[a, b]} ");
        }
        Console.WriteLine();
    }
    
    Console.WriteLine("N2.9:");
    const int GA1 = 6;
    const int GA2 = 7;
    double zerf;
    double[,] forg = new double[GA1, GA2];
    for (int i = 0; i < GA1; i++)
    {
        string[] sws = Console.ReadLine().Split();
        for (int j = 0; j < sws.Length; j++)
        {
            if (sws.Length == GA2)
            {
                bool joker = double.TryParse(sws[j], out zerf);
                if (joker == true)
                {
                    forg[i, j] = zerf;
                }
                else
                {
                    Console.WriteLine("Неверный ввод");
                    Environment.Exit(0);
                }
            }
            else
            {
                Console.WriteLine("Неверный ввод");
                Environment.Exit(0);
            }
        }
    }
    for(int i = 0; i < GA1; i++)
    {
        double[] copy = new double[GA2];
        int zaq = 0;
        for (int j = GA2-1; j > -1; j-=1)
        {
            copy[zaq] = forg[i, j];
            zaq++;
        }
        for (int f = 0; f < GA2; f++)
        {
            forg[i, f] = copy[f];
        }
    }
    Console.WriteLine();
    for (int a = 0; a < GA1; a++)
    {
        for (int b = 0; b < GA2; b++)
        {
            Console.Write($"{forg[a, b]} ");
        }
        Console.WriteLine();
    }
    


    Console.WriteLine("N3.1:");
    const int GS1 = 7;
    const int GS2 = 5;
    double zere;
    double[,] ember = new double[GS1, GS2];
    double[,] spirit = new double[GS1, GS2];
    for (int i = 0; i < GS1; i++)
    {
        string[] dad = Console.ReadLine().Split();
        for (int j = 0; j < dad.Length; j++)
        {
            if (dad.Length == GS2)
            {
                bool rjoker = double.TryParse(dad[j], out zere);
                if (rjoker == true)
                {
                    ember[i, j] = zere;
                }
                else
                {
                    Console.WriteLine("Неверный ввод");
                    Environment.Exit(0);
                }
            }
            else
            {
                Console.WriteLine("Неверный ввод");
                Environment.Exit(0);
            }
        }
    }
    double[] hran = new double[GS1];
    double[] ihran = new double[GS1];
    int zeq = 0;
    for (int i = 0; i < GS1; i++)
    {
        double minsk = 100000000;
        for(int j= 0; j < GS2; j++)
        {
            if(ember[i, j] < minsk)
            {
                minsk= ember[i, j];
            }
        }
        hran[zeq] = minsk;
        ihran[zeq] = minsk*10+i; 
        zeq++;
    }
    Array.Sort(hran);
    int[] fina=new int[GS1];
    int qur = 0;
    for (int i = 0; i < hran.Length; i++)
    { 
        for(int j = 0; j < ihran.Length; j++)
        {
            if (hran[i] == (ihran[j]-ihran[j]%10)/10)
            {
                fina[qur] = Convert.ToInt32(ihran[j]%10);
                qur++;
                break;
            }
        }
    }
    int ywa = 0;
    for (int i = 0; i < fina.Length; i++) 
    {
        for (int j = 0; j < GS2; j++)
        {
            spirit[ywa, j] = ember[fina[i], j];
        }
        ywa++;
    }
    Console.WriteLine();
    for (int a = 0; a < GS1; a++)
    {
        for (int b = 0; b < GS2; b++)
        {
            Console.Write($"{spirit[a, b]} ");
        }
        Console.WriteLine();
    }
    

    Console.WriteLine("N3.2:");
    const int QS1 = 4;
    const int QS2 = 4;
    double puf;
    double[,] nst = new double[QS1, QS2];
    for (int i = 0; i < QS1; i++)
    {
        string[] sad = Console.ReadLine().Split();
        for (int j = 0; j < sad.Length; j++)
        {
            if (sad.Length == QS2)
            {
                bool rfjoker = double.TryParse(sad[j], out puf);
                if (rfjoker == true)
                {
                    nst[i, j] = puf;
                }
                else
                {
                    Console.WriteLine("Неверный ввод");
                    Environment.Exit(0);
                }
            }
            else
            {
                Console.WriteLine("Неверный ввод");
                Environment.Exit(0);
            }
        }
    }
    for(int i = 0; i < QS1; i++)
    {
        for(int j = 0; j < QS2; j++)
        {
            if(i==0 | i==3 | j==0| j==3)
            {
                nst[i, j] = 0;
            }
        }
    }
    Console.WriteLine();
    for (int a = 0; a < QS1; a++)
    {
        for (int b = 0; b < QS2; b++)
        {
            Console.Write($"{nst[a, b]} ");
        }
        Console.WriteLine();
    }
    

    Console.WriteLine("N3.3:");
    double puf;
    int rtyu;
    int ladno=0;
    bool nu = Int32.TryParse(Console.ReadLine(),out rtyu);
    if (nu==true)
    {
        ladno = rtyu;
    }
    else
    {
        Console.WriteLine("Неверный ввод");
        Environment.Exit(0);
    }
    double[,] pudge = new double[ladno, ladno];
    for (int i = 0; i < ladno; i++)
    {
        string[] tango = Console.ReadLine().Split();
        for (int j = 0; j < tango.Length; j++)
        {
            if (tango.Length == ladno)
            {
                bool rfjoker = double.TryParse(tango[j], out puf);
                if (rfjoker == true)
                {
                    pudge[i, j] = puf;
                }
                else
                {
                    Console.WriteLine("Неверный ввод");
                    Environment.Exit(0);
                }
            }
            else
            {
                Console.WriteLine("Неверный ввод");
                Environment.Exit(0);
            }
        }
    }
    double[] pyat = new double[2*ladno-1];
    double sims = 0;
    int qasd = 2;
    for(int j = 0; j < ladno; j++)
       {
        int indi = 0;
        int indj = j;
        sims = 0;
        while(indi<ladno & indj<ladno)
        {
            sims+=pudge[indi,indj];
            indi++;
            indj++;
        }
        pyat[qasd]=sims;
        qasd++;
       }
    sims = 0;
    int qwev = 0;
    for(int i = ladno-1; i > 0; i--)
    {
        int fi = i;
        int fj = 0;
        sims = 0;
        while (fi < ladno & fj < ladno)
        {
            sims += pudge[fi, fj];
            fi++;
            fj++;
        }
        pyat[qwev] = sims;
        qwev++;
    }
    Console.WriteLine();
    for(int i = 0; i < pyat.Length; i++)
    {
        Console.Write($"{pyat[i]} ");
    }
    Console.WriteLine();

    
    Console.WriteLine("N3.4:");
    double ghoul;
    int ruiner;
    int wef = 0;
    bool travoman = Int32.TryParse(Console.ReadLine(), out ruiner);
    if (travoman == true)
    {
        wef = ruiner;
    }
    else
    {
        Console.WriteLine("Неверный ввод");
        Environment.Exit(0);
    }
    double[,] io = new double[wef, wef];
    for (int i = 0; i < wef; i++)
    {
        string[] prox = Console.ReadLine().Split();
        for (int j = 0; j < prox.Length; j++)
        {
            if (prox.Length == wef)
            {
                bool rfjoker = double.TryParse(prox[j], out ghoul);
                if (rfjoker == true)
                {
                    io[i, j] = ghoul;
                }
                else
                {
                    Console.WriteLine("Неверный ввод");
                    Environment.Exit(0);
                }
            }
            else
            {
                Console.WriteLine("Неверный ввод");
                Environment.Exit(0);
            }
        }
    }
    int gran = 0;
    if (wef % 2 == 0)
    {
        gran = wef / 2+1;
    }
    else
    {
        gran = (wef-1)/ 2 + 1;
    }
    for(int i = gran-1; i < wef; i++)
    {
        for(int j = 0; j < wef; j++)
        {
            if (j<=i)
            {
                io[i, j] = 1;
            }
            else
            {
                break;
            }
        }    
    }
    Console.WriteLine();
    for (int a = 0; a < wef; a++)
    {
        for (int b = 0; b < wef; b++)
        {
            Console.Write($"{io[a, b]} ");
        }
        Console.WriteLine();
    }
    

    Console.WriteLine("N3.8:");
    const int SS1 = 3;
    const int SS2 = 3;
    double zere;
    double[,] pri = new double[SS1, SS2];
    double[,] part = new double[SS1, SS2];
    for (int i = 0; i < SS1; i++)
    {
        string[] dadw = Console.ReadLine().Split();
        for (int j = 0; j < dadw.Length; j++)
        {
            if (dadw.Length == SS2)
            {
                bool rjokera = double.TryParse(dadw[j], out zere);
                if (rjokera == true)
                {
                    pri[i, j] = zere;
                }
                else
                {
                    Console.WriteLine("Неверный ввод");
                    Environment.Exit(0);
                }
            }
            else
            {
                Console.WriteLine("Неверный ввод");
                Environment.Exit(0);
            }
        }
    }
    double[] hrna = new double[SS1];
    double[] ihrna = new double[SS1];
    int zeq = 0;
    double ches = 0;
    for (int i = 0; i < SS1; i++)
    {
        ches = 0;
        for (int j = 0; j < SS2; j++)
        {
            if (pri[i, j]>0)
            {
                ches++;
            }
        }
        hrna[zeq] = ches;
        ihrna[zeq] = ches * 10 + i;
        zeq++;
    }
    Array.Sort(hrna);
    int[] finat = new int[SS1];
    int qur = 0;
    for (int i = 0; i < hrna.Length; i++)
    {
        for (int j = 0; j < ihrna.Length; j++)
        {
            if (hrna[i] == (ihrna[j] - ihrna[j] % 10) / 10)
            {
                finat[qur] = Convert.ToInt32(ihrna[j] % 10);
                qur++;
                break;
            }
        }
    }
    int ywa = 0;
    for (int i = 0; i < finat.Length; i++)
    {
        for (int j = 0; j < SS2; j++)
        {
            part[ywa, j] = pri[finat[i], j];
        }
        ywa++;
    }
    
    
    Console.WriteLine("N3.10:");
    int biba;
    int SGM1 = 0;
    int SGM2 = 0;
    bool yor1 = Int32.TryParse(Console.ReadLine(),out biba);
    if(yor1==true)
    {
        SGM1= biba;
    }
    else
    {
        Console.WriteLine("Неверный ввод");
        Environment.Exit(0);
    }
    bool yor2 = Int32.TryParse(Console.ReadLine(), out biba);
    if (yor2 == true)
    {
        SGM2 = biba;
    }
    else
    {
        Console.WriteLine("Неверный ввод");
        Environment.Exit(0);
    }
    double tere;
    double[,] qli = new double[SGM1, SGM2];
    for (int i = 0; i < SGM1; i++)
    {
        string[] sdadw = Console.ReadLine().Split();
        for (int j = 0; j < sdadw.Length; j++)
        {
            if (sdadw.Length == SGM2)
            {
                bool rjoera = double.TryParse(sdadw[j], out tere);
                if (rjoera == true)
                {
                    qli[i, j] = tere;
                }
                else
                {
                    Console.WriteLine("Неверный ввод");
                    Environment.Exit(0);
                }
            }
            else
            {
                Console.WriteLine("Неверный ввод");
                Environment.Exit(0);
            }
        }
    }
    for(int i = 0; i < SGM1; i++)
    {
        double[] masti = new double[SGM2];
        for (int j = 0; j < SGM2; j++)
        {
            masti[j] = qli[i, j];
        }
        Array.Sort(masti);
        if (i % 2 == 0)
        {
            Array.Reverse(masti);
        }
        for(int j = 0; j < SGM2; j++)
        {
            qli[i,j]=masti[j];
        }
    }
    Console.WriteLine();
    for (int a = 0; a < SGM1; a++)
    {
        for (int b = 0; b < SGM2; b++)
        {
            Console.Write($"{qli[a, b]} ");
        }
        Console.WriteLine();
    }
    */

    Console.WriteLine("N3.11:");
    int boba;
    int GM1 = 0;
    int GM2 = 0;
    bool yar1 = Int32.TryParse(Console.ReadLine(), out boba);
    if (yar1 == true)
    {
        GM1 = boba;
    }
    else
    {
        Console.WriteLine("Неверный ввод");
        Environment.Exit(0);
    }
    bool yar2 = Int32.TryParse(Console.ReadLine(), out boba);
    if (yar2 == true)
    {
        GM2 = boba;
    }
    else
    {
        Console.WriteLine("Неверный ввод");
        Environment.Exit(0);
    }
    double terem;
    double[,] qlint = new double[GM1, GM2];
    for (int i = 0; i < GM1; i++)
    {
        string[] sdodw = Console.ReadLine().Split();
        for (int j = 0; j < sdodw.Length; j++)
        {
            if (sdodw.Length == GM2)
            {
                bool rjoera = double.TryParse(sdodw[j], out terem);
                if (rjoera == true)
                {
                    qlint[i, j] = terem;
                }
                else
                {
                    Console.WriteLine("Неверный ввод");
                    Environment.Exit(0);
                }
            }
            else
            {
                Console.WriteLine("Неверный ввод");
                Environment.Exit(0);
            }
        }
    }
    int chis = 0;
    for(int i = 0; i < GM1; i++)
    {
        for(int j = 0; j < GM2; j++)
        {
            if(qlint[i, j] == 0)
            {
                chis++;
                break;
            }
        }
    }
    int GRM1 = 0;
    double[,] east = new double[GM1-chis, GM2];
    for (int i = 0; i < GM1; i++)
    {
        double qipo = 0;
        for (int j = 0; j < GM2; j++)
        {
            if (qlint[i, j] == 0)
            {
                qipo++;
                break;
            }
        }
        if(qipo == 0)
        {
            for(int j=0;j<GM2; j++)
            {
                east[GRM1,j]=qlint[i,j];
            }
            GRM1++;
        }
        
    }
    Console.WriteLine();
    for (int a = 0; a < GM1-chis; a++)
    {
        for (int b = 0; b < GM2; b++)
        {
            Console.Write($"{east[a, b]} ");
        }
        Console.WriteLine();
    }
}