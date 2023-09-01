StreamReader sr = new StreamReader(Console.OpenStandardInput());
StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

while (true)
{
    var N = int.Parse(sr.ReadLine()!);

    if (N == 0) break;

    for (int i=1;i<=N;i++)
    {
        for(int j=0;j<i;j++)
        {
            sw.Write("*");
        }
        sw.WriteLine();
    }

    
}
sr.Close();
sw.Close();