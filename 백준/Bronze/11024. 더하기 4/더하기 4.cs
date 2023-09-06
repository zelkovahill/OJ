var T =int.Parse(Console.ReadLine());

while(T>0)
{
    var N =Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
    int sum = 0;

    for(int i =0; i<N.Length; i++)
    {
        sum+= N[i];
    }
    Console.WriteLine(sum);


    T--;

}