var N = int.Parse(Console.ReadLine()!);


    var I = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
    
    

    int sum = Math.Min(N, I[0])+Math.Min(N,I[1])+Math.Min(N,I[2]);

    Console.WriteLine(sum);



    N--;
