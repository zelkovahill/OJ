using System;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());

        for (int n = 1; n <= N; n++)
        {
            for (int o = 0; o < n; o++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}
