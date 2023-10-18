int cnt = 0;
for (int i = 0; i < 6; i++)
{
    
    char n = char.Parse(Console.ReadLine());
    if (n == 'W') cnt++;
}

if (cnt == 0) Console.WriteLine("-1");
else if(cnt>=5) Console.WriteLine("1");
else if (cnt >= 3) Console.WriteLine("2");
else Console.WriteLine("3");
