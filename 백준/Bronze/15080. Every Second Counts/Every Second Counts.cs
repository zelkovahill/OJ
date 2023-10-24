
    var a = Console.ReadLine().Split(" : ").Select(int.Parse).ToArray();
    var b = Console.ReadLine().Split(" : ").Select(int.Parse).ToArray();

int start = a[2] + a[1] * 60 + a[0] * 3600;
int end = b[2] + b[1] * 60 + b[0] * 3600;

if (start > end) Console.WriteLine(24 * 3600 - start + end);
else Console.WriteLine(end - start);


