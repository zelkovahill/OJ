int t = int.Parse(Console.ReadLine());
int sum = 0;

for (int i = 0; i < t; i++)
{
    string[] input = Console.ReadLine().Split(' ');
    int a = int.Parse(input[0]),
        b = int.Parse(input[1]);
  
    
    switch(a)
    {
        case 136:
        sum += 1000;
        break;
        
        case 142:
            sum += 5000;
            break;
        
        case 148:
            sum += 10000;
            break;
        
        case 154:
            sum += 50000;
            break;
    }

}

Console.WriteLine(sum);