StreamReader sr = new StreamReader(Console.OpenStandardInput());
StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

var N=sr.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
var sum = 0;
for(int i=0;i<N.Length;i++)
{
    sum += N[i];
}

sw.WriteLine(sum);

sr.Close();
sw.Close();