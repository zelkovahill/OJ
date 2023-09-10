using System;

public class Example
{
    public static void Main()
    {
        string [] B = Console.ReadLine().Split(' ');
        string str =B[0];
        int n =int.Parse(B[1]);
        
        for(int i = 0; i<n;i++)
        {
            Console.Write(str);
        }

    }
}