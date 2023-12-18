using var sr = new StreamReader(Console.OpenStandardInput());
using var sw = new StreamWriter(Console.OpenStandardOutput());

int cnt = Convert.ToInt32(sr.ReadLine());
int[] list = new int[10001];
 
for (int i = 0; i < cnt; i++)
{
    list[int.Parse(sr.ReadLine())]++;
}
for (int i = 0; i <= 10000; i++)
{
    if (list[i] != 0)
    {
        for (int j = 0; j < list[i]; j++)
        {
            sw.WriteLine(i);
        }
    }
}