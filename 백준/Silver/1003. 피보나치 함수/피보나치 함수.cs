StreamReader sr = new StreamReader(Console.OpenStandardInput());
StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

int n = int.Parse(sr.ReadLine());

for (int i = 0; i < n; i++)
{
    int[,] fibonacci = new int[41, 2];
    fibonacci[0, 0] = 1;
    fibonacci[1, 1] = 1;
    int m = int.Parse(sr.ReadLine());
    
    for(int j=2;j<=m;j++)
    {
        fibonacci[j, 0] = fibonacci[j - 1, 0] + fibonacci[j - 2, 0];
        fibonacci[j, 1] = fibonacci[j - 1, 1] + fibonacci[j - 2, 1];
    }

    sw.WriteLine("{0} {1}", fibonacci[m, 0], fibonacci[m, 1]);
}

sr.Close();
sw.Close();