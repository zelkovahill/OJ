StreamReader sr = new StreamReader(Console.OpenStandardInput());
StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

var N = int.Parse(sr.ReadLine()!);

while(N>0)
{
    var A = sr.ReadLine()!.Split(' ').ToArray();
    if (A[0] == A[1]) sw.WriteLine("OK");
    else sw.WriteLine("ERROR");

    N--;
}

sr.Close();
sw.Close();