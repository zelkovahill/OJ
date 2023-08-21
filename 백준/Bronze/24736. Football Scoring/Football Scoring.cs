int[] B = new int[2];

for (int i = 0; i < 2; i++)
{

    string[] A = Console.ReadLine().Split();


    int a = int.Parse(A[0]); //Touchdown - 6 points
    int b = int.Parse(A[1]); //Field Goal - 3 points
    int c = int.Parse(A[2]); //Safety - 2 points
    int d = int.Parse(A[3]); //1 point (Field Goal or Safety) - Typically called the “Point after”
    int e = int.Parse(A[4]); //2 points (touchdown) - Typically called the “Two-point conversion”

    B[i] = a * 6 + b * 3 + c * 2 + d + e * 2;

}

for(int i=0;i<2;i++)
{
    Console.Write(B[i]+" ");
}