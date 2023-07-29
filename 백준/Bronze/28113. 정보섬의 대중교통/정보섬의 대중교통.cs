string[] a = Console.ReadLine().Split();

int N = int.Parse(a[0]);
int A = int.Parse(a[1]); //버스 
int B = int.Parse(a[2]); //지하철 



if (A > B && B < N + A)
{
    Console.WriteLine("Subway");
}

else if (A < B && A < N + A)
{
    Console.WriteLine("Bus");
}

else
{
    Console.WriteLine("Anything");
}