var N =int.Parse(Console.ReadLine());

var T =Console.ReadLine().Split(' ').Select(int.Parse).ToList();

int sum = 0;

int day = 0;
int time = 0;

for(int i = 0; i<T.Count; i++)
{
    
   sum+= T[i];

    if (i < N - 1) sum += 8;
  
   
}

day = sum / 24;
time = sum % 24;
Console.WriteLine($"{day} {time}");





