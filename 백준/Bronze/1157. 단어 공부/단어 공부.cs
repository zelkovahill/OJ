string s = Console.ReadLine().ToUpper();

int[] Arr = new int[91];

for(int i=0;i<s.Length;i++)
{
    Arr[s[i]]++;
}

int max = 0;
char c = '?';

for(int i ='A';i<='Z';i++)
{
    if (Arr[i] > max)
    {
        max = Arr[i];
        c = (char)i;
    }

    else if (Arr[i] == max) c = '?';
}
Console.WriteLine(c);