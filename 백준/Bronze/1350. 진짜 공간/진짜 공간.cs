StreamReader sr = new StreamReader(Console.OpenStandardInput());
StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

int n = int.Parse(sr.ReadLine());
string[] input = sr.ReadLine().Split(' ');
long clusterSize = int.Parse(sr.ReadLine());
int[] size = new int[n];

long cnt = 0;

for (int i = 0; i < n; i++)
{
    size[i] = int.Parse(input[i]);

    cnt += (size[i] != 0) ? size[i] / clusterSize : 0;
    
    cnt += (size[i]%clusterSize > 0) ? 1 : 0;
}

sw.WriteLine(cnt * clusterSize);

sr.Close();
sw.Close();
