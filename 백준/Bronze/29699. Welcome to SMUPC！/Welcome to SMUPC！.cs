string input = "WelcomeToSMUPC"; //14 Length
var N = int.Parse(Console.ReadLine()!);

int sum = N % input.Length;

if(sum ==0)
{
    Console.WriteLine(input[input.Length - 1]);
}

else
{
    Console.WriteLine(input[sum - 1]);
}


