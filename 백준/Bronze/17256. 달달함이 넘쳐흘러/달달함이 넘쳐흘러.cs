public class Cake
{
   public int x=0;
   public int y=0;
   public int z=0;

   

}




class Program
{
    static void Main(string[] args)
    {
        Cake a = new Cake();
        string[] A = Console.ReadLine().Split();
        a.x = int.Parse(A[0]);
        a.y = int.Parse(A[1]);
        a.z = int.Parse(A[2]);


        
        Cake c = new Cake();
        string[] C = Console.ReadLine().Split();
        c.x = int.Parse(C[0]);
        c.y = int.Parse(C[1]);
        c.z = int.Parse(C[2]);


        Cake b = new Cake();
        b.x = c.x - a.z;
        b.y = c.y / a.y;
        b.z = c.z - a.x;



        Console.WriteLine($"{b.x} {b.y} {b.z}");



    }
}