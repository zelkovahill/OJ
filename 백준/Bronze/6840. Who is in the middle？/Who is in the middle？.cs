var a = new int[3];

for(int i = 0; i<3;i++)
{
    a[i] = int.Parse(Console.ReadLine()!);
    
}
Array.Sort(a);
Console.WriteLine(a[1]);