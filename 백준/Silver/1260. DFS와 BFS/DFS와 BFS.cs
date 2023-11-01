bool[] visit = new bool[1001];
List<int>[] node = new List<int>[1001];


var I = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
int n = I[0],
    m = I[1],
    v = I[2];

for(int i = 1;i<=n;i++)
{
    node[i] = new List<int>();
}

for(int i = 0; i<m; i++)
{
    var O = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
    int a= O[0],
        b = O[1];
    node[a].Add(b);
    node[b].Add(a);
}

for (int i = 1; i <= n; i++)
{
    node[i].Sort();
}

visit[v] = true;
DFS(v);
Console.WriteLine();

for(int i  =1;i<=n;i++)
{
    visit[i] = false;
}
visit[v] = true;
BFS(v);




void DFS(int v)
{
    Console.Write($"{v} ");
    int s = node[v].Count;
    for(int i = 0; i<s;i++)
    {
        if (visit[node[v][i]]) continue;

        visit[node[v][i]] = true;
        DFS(node[v][i]);

    }

}

void BFS(int v)
{
    Queue<int> q = new Queue<int>();
    q.Enqueue(v);
    while(q.Count>0)
    {
        int n = q.Dequeue();
        Console.Write($"{n} ");

        int s = node[n].Count;
        for(int i=0; i<s;i++)
        {
            if (visit[node[n][i]]) continue;

            visit[node[n][i]] = true;
            q.Enqueue(node[n][i]);
        }

    }
}