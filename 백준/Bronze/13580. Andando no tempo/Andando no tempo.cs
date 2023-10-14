var arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
Array.Sort(arr);




if (arr[0] == arr[1] || arr[1] == arr[2] || arr[0] + arr[1] == arr[2])
    Console.WriteLine("S");
else Console.WriteLine("N");