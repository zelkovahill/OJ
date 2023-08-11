while(true)
{
    string s = Console.ReadLine().ToLower();

    int count = 0;

    if(s=="#")
    {
        break;
    }

    else
    {
        for(int i=0;i<s.Length;i++)
        {
            if (s[i] == 'a' || s[i] == 'e' || s[i] == 'i' || s[i] == 'o' || s[i] == 'u')
            {
                count++;
            }
        }
    }

    Console.WriteLine(count);
}