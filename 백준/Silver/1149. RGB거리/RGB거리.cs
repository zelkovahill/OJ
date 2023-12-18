StreamReader sr = new StreamReader(Console.OpenStandardInput());
StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());



int n = int.Parse(sr.ReadLine());
int[,] d = new int[n + 1, 3];
int[,] a = new int[n + 1, 3];
    
for (int i = 1; i <= n; i++)
{
    string[] input = sr.ReadLine().Split(' ');
    for(int j=0; j<3 ;j++)
    {
        a[i, j] = int.Parse(input[j]);
    }
}

for(int i =1;i<=n; i++)
{
    d[i, 0] = Math.Min(d[i - 1, 1], d[i - 1, 2]) + a[i, 0];
    d[i, 1] = Math.Min(d[i - 1, 0], d[i - 1, 2]) + a[i, 1];
    d[i, 2] = Math.Min(d[i - 1, 0], d[i - 1, 1]) + a[i, 2];
}

sw.WriteLine(Min(Min(d[n, 0], d[n, 1]), d[n, 2]));

sr.Close();
sw.Close();

static int Min(int a, int b)
{
    return a < b ? a : b;
}