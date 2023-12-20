int a = 0;
int b = 0;
string s = Console.ReadLine();

for (int i = 0; i < s.Length; i += 2)
{
    if (s[i] == 'A')
    {
        a += s[i + 1] - '0';
    }
    else
    {
        b += s[i + 1] - '0';
    }
}

if(a>b) Console.WriteLine('A');
else    Console.WriteLine('B');

