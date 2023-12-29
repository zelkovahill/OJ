while (true)
{
    List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp))
        .ToList();

    if (arr[0] == 0)
        break;

    int n = 1;

    for (int i = 0; i < arr[0]; i++)
    {
        int sf = arr[2 * i + 1];
        int p = arr[2 * i + 2];
        n=n*sf-p;
    }

    Console.WriteLine(n);

}