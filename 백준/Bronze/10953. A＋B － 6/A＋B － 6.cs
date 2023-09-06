StreamReader sr = new StreamReader(Console.OpenStandardInput());
StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());


var N=int.Parse(sr.ReadLine()!);

while(N>0)
{
    var A = sr.ReadLine()!.Split(',').Select(int.Parse).ToArray();
    sw.WriteLine(A[0] + A[1]);
    N--;
}

sr.Close();
sw.Close();