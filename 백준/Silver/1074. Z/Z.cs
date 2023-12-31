using System.IO.Compression;

List<int> arr = Console.ReadLine()!.TrimEnd().Split(' ').Select(arr=> Convert.ToInt32(arr)).ToList();

var n = arr[0];
var r = arr[1];
var c = arr[2];

Console.WriteLine(z(n,r,c));




static int z(int n, int r, int c)
{
    int ans = 0;

    while (n > 0)
    {
        n--;

        if (r < Math.Pow(2, n) && c < Math.Pow(2, n))
        {
            ans = ans;
        }
        
        else if (r < Math.Pow(2, n) && c >= Math.Pow(2, n))
        {
            ans+= (int)Math.Pow(2, 2*n);
            c -= (int)Math.Pow(2, n);
        }
        
        else if (r >= Math.Pow(2, n) && c < Math.Pow(2, n))
        {
            ans += 2 * (int)Math.Pow(2, 2 * n);
            r -= (int)Math.Pow(2, n);
        }
        
        else if (r >= Math.Pow(2, n) && c >= Math.Pow(2, n))
        {
            ans += 3 * (int)Math.Pow(2, 2 * n);
            r -= (int)Math.Pow(2, n);
            c -= (int)Math.Pow(2, n);
        }
    }

    return ans;

}
