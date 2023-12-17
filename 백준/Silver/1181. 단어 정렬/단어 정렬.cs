int n =int.Parse(Console.ReadLine());

List<string> list = new List<string>();

for (int i = 0; i < n; i++)
{
    string w = Console.ReadLine();
    list.Add(w.ToLower());
}

list=list.Distinct().ToList();
list.Sort();
list = list.OrderBy(x => x.Length).ToList();

foreach (string a in list)
{
    Console.WriteLine(a);
}