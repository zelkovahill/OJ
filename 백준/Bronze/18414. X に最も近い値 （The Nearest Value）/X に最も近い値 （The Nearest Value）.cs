var input = Console.ReadLine()!.TrimEnd().Split(' ').ToList().Select(arr=>Convert.ToInt32(arr)).ToList();

int x = input[0];
int l = input[1];
int r = input[2];

if(x<l)
    Console.WriteLine(l);

else if(x>r)
    Console.WriteLine(r);

else
    Console.WriteLine(x);