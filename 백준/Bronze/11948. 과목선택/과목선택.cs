var N = new int[6];

for (int i = 0; i < 6; i++)
{

    N[i] = int.Parse(Console.ReadLine()!);


}

int[] nege = { N[0], N[1], N[2], N[3] };

Array.Sort(nege);

var A = nege[1] + nege[2] + nege[3];

var B =N[4] >= N[5] ? N[4] : N[5];

var C = A + B;

Console.WriteLine(C);