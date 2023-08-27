var N = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

// 1. 1부터 8까지 차례대로   ascending
// 2. 8부터 1까지 차례대로   descending
// 3. 섞임                mixed

bool isAscending = true;
bool isDescending = true;

for(int i = 0; i < N.Length-1;i++)
{
    if (N[i] > N[i + 1]) isAscending = false;
    if (N[i] < N[i + 1]) isDescending = false;

}

if (isAscending) Console.WriteLine("ascending");
else if (isDescending) Console.WriteLine("descending");
else Console.WriteLine("mixed");


