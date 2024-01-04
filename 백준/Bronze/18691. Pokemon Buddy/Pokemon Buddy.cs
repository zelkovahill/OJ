int t = int.Parse(Console.ReadLine()!);

for (int i = 0; i < t; i++)
{
    string[] n = Console.ReadLine()!.TrimEnd().Split(' ');

    int g = int.Parse(n[0]);
    int c = int.Parse(n[1]);
    int e = int.Parse(n[2]);

    int res = e - c;

    if (g == 1) res = res;
    else if (g == 2) res = res * 3;
    else res =res * 5;
    
    if(res<=0) Console.WriteLine("0");
    else Console.WriteLine(res);

}