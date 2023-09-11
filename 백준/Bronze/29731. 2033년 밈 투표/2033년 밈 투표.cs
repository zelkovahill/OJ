using System.Collections.Generic;

int T = int.Parse(Console.ReadLine());
List<string> P = new List<string>();

for(int i=0;i<T;i++)
{
    var I = Console.ReadLine().Trim();
    P.Add(I);
}

bool isChanged = false;

string[] Rick =
{
    "Never gonna give you up",
            "Never gonna let you down",
            "Never gonna run around and desert you",
            "Never gonna make you cry",
            "Never gonna say goodbye",
            "Never gonna tell a lie and hurt you",
            "Never gonna stop"
};

foreach(string R in P)
{
    if (!Array.Exists(Rick, element => element== R))
    {
        isChanged = true;
        break;
    }
}

if (isChanged) Console.WriteLine("Yes");
else Console.WriteLine("No");