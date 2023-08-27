var A = int.Parse(Console.ReadLine()!);
var B = int.Parse(Console.ReadLine()!);
var C = int.Parse(Console.ReadLine()!);

int sum = A * B * C;

string sumStr = sum.ToString();

int[] Count = new int[10];

foreach(char digitChar in sumStr)
{
    int digit = (int)(digitChar - '0');
    Count[digit]++;
}

for(int i =0;i<=9;i++)
{
    Console.WriteLine(Count[i]);
}
