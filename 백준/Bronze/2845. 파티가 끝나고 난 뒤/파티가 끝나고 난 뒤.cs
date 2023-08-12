using System;

class Program
{
    static int x;

    static void Main(string[] args)
    {
        string[] A = Console.ReadLine().Split();
        int a = int.Parse(A[0]);
        int b = int.Parse(A[1]);

        x = a * b;

        string[] B = Console.ReadLine().Split();
        int c = int.Parse(B[0]);
        int d = int.Parse(B[1]);
        int e = int.Parse(B[2]);
        int f = int.Parse(B[3]);
        int g = int.Parse(B[4]);

        Console.Write((c - x) + " ");
        Console.Write((d - x) + " ");
        Console.Write((e - x) + " ");
        Console.Write((f - x) + " ");
        Console.Write((g - x));
    }
}
