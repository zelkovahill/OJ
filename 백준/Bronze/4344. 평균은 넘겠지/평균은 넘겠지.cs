int C = int.Parse(Console.ReadLine());

while(C>0)
{
    C--;

    string[] N = Console.ReadLine().Split();

    int sum = 0;

    for(int i=1;i<N.Length;i++)
    {
        sum += int.Parse(N[i]);
    }

    int Average = sum / int.Parse(N[0]);

    int Result = 0;

    for(int i=1; i<N.Length;i++)
    {
        if (int.Parse(N[i])>Average)
        {

            Result++;
        }

    }

    Console.WriteLine($"{(float)Result / float.Parse(N[0]) * 100:0.000}%");

}