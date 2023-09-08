using System.Numerics;

StreamReader sr = new StreamReader(Console.OpenStandardInput());
StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

int T = int.Parse(sr.ReadLine()!);

for(int i=0;i<T;i++)
{
    var gongbeak = sr.ReadLine();

    BigInteger Candy = 0;

    int N = int.Parse(sr.ReadLine()!);

    
    for(int j=0;j<N;j++)
    {
        Candy +=BigInteger.Parse(sr.ReadLine()!);

    }

    sw.WriteLine(Candy % N == 0 ? "YES" : "NO");
}

sr.Close();
sw.Close();