class Program // 빼머금
{

    static void Main(string[] args)
    {

        var T = int.Parse(Console.ReadLine()!);

        for (int i = 0; i < T; i++)
        {
            string s = Console.ReadLine()!;
            int score = C(s);
            Console.WriteLine(score);

        }

    }

    static int C(string s)
    {
        int total = 0;
        int current = 0;

        foreach (char c in s)
        {
            if (c == 'O') // 숫자 0 써서 틀림
            {
                current++;
                total += current;
            }

            else
            {
                current = 0;
            }
        }



        return total;
    }
}