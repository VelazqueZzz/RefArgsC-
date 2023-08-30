using System;

class ArgsDemo
{
    static void alpha(ref int n)
    {
        Console.WriteLine("V methode alpha(). Na vhode: " + n);
        n++;
        Console.WriteLine("V methode alpha(). Na vihode: " + n);
    }
    static void bravo(ref int[] n)
    {
        Console.WriteLine("V methode bravo(). Na vhode: " + ArraToText(n));
        for (int k = 0; k < n.Length; k++)
        {
            n[k]++;
        }
        Console.WriteLine("V methode bravo(). navihode: " + ArraToText(n));
    }
    static void charlie(ref int[] n)
    {
        Console.WriteLine("V methode charlie(). Na vhode: " + ArraToText(n));
        int[] m = new int[n.Length];
        for (int k = 0; k < n.Length; k++)
        {
            m[k] = n[k] + 1;
        }
        n = m;
        Console.WriteLine("V methode charlie(). Na vihode: " + ArraToText(n));
    }
    static string ArraToText(int[] n)
    {
        string res = "[" + n[0];
        for (int k = 1; k < n.Length; k++)
        {
            res += "," + n[k];
        }
        res += "]";
        return res;
    }
    static void Main()
    {
        int A = 100;
        Console.WriteLine("do vizova alpha(): A=" + A);
        alpha(ref A);
        Console.WriteLine("Posle vizova methoda alpha: A=" + A);
        int[] B = { 1, 3, 5 };
        Console.WriteLine("Do vizova methoda bravo(): B=" + ArraToText(B));
        bravo(ref B);
        Console.WriteLine("Posle vizova methoda bravo(): B=" + ArraToText(B));
        int[] C = { 2, 4, 6 };
        Console.WriteLine("Do vizova methoda charlie(): C=" + ArraToText(C));
        charlie(ref C);
        Console.WriteLine("Posle vizova methoda charlie(): C=" + ArraToText(C));
    }

}
