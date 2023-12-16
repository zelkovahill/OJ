int n = int.Parse(Console.ReadLine());


for (int i = 0; i < n; i++)
{
  string[] a = Console.ReadLine().Split(' ');
  int b = int.Parse(a[0]);
  char c = char.Parse(a[1]);
  for (int j = 0; j < b; j++)
  {
    Console.Write(c);
  }
  Console.WriteLine();

}