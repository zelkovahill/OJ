var A = Console.ReadLine()!.Split(' ').Select(Double.Parse).ToArray();

var Asum = A[0] / A[1];

var B = Console.ReadLine()!.Split(' ').Select(Double.Parse).ToArray();

var Bsum = Math.Pow(B[0], 2) * Math.PI / B[1];

if (Asum > Bsum) Console.WriteLine("Slice of pizza");
else Console.WriteLine("Whole pizza"); 





