string[] a = Console.ReadLine().Split();

int A=int.Parse(a[0]);
int B=int.Parse(a[1]);
int C=int.Parse(a[2]);

Console.WriteLine( (A+B)%C);
Console.WriteLine(((A%C) + (B%C))%C);
    Console.WriteLine( (A*B)%C);
        Console.WriteLine(((A%C) * (B%C))%C);