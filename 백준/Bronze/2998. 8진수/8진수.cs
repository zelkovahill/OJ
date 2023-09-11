Dictionary<string, string> twoToEight = new Dictionary<string, string>
        {
            { "000", "0" },
            { "001", "1" },
            { "010", "2" },
            { "011", "3" },
            { "100", "4" },
            { "101", "5" },
            { "110", "6" },
            { "111", "7" }
        };

string N = Console.ReadLine()!;
string R = "";

while(N.Length%3!=0)
{
    N = "0" + N;
}

while(!string.IsNullOrEmpty(N))
{
    R += twoToEight[N.Substring(0, 3)];
    N = N.Substring(3);
}

Console.WriteLine(R);