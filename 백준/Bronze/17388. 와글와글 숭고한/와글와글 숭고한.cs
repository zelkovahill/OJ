string[] input = Console.ReadLine().Split(' ');

var S = int.Parse(input[0]);
var K = int.Parse(input[1]);
var H = int.Parse(input[2]);





if (S + K + H >= 100) Console.WriteLine("OK");
else
{
    int min = Math.Min(S, Math.Min(K, H));
    if (min == S) Console.WriteLine("Soongsil");
   else if (min == K) Console.WriteLine("Korea");
    else if(min == H) Console.WriteLine("Hanyang");
}

// C#에서 제공하는 Math.Min 함수 사용