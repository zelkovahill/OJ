int N = int.Parse(Console.ReadLine());

while(N-- > 0)
{
   

    string[] A = Console.ReadLine().Split();
    long a = long.Parse(A[0]);
    long b = long.Parse(A[1]);
    long c = long.Parse(A[2]);
    long d = long.Parse(A[3]);

    if (a * b == c * d) Console.WriteLine("Tie");

    else if (a * b > c * d) Console.WriteLine("TelecomParisTech");

    else Console.WriteLine("Eurecom");


}