using System;

public class Example
{
    public static void Main()
    {
        var input = Console.ReadLine();
char []N =new char[input.Length];

for (int i = 0; i < input.Length; i++)
{


   if (input[i] >= 'A' && input[i] <= 'Z') N[i] = (char)(input[i] + 32);
   else if (input[i] >= 'a' && input[i] <= 'z') N[i] = (char)(input[i] - 32);

  
}

string output = new string(N);
Console.WriteLine(output);
    }
}