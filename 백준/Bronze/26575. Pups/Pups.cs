int N = int.Parse(Console.ReadLine());


for(int i=0;i<N;i++)
{

    var A = Console.ReadLine().Split();

    var a = double.Parse(A[0]);
    var b = double.Parse(A[1]);
    var c = double.Parse(A[2]);

    var sum = a * b * c;

    Console.WriteLine($"${sum:F2}");


}