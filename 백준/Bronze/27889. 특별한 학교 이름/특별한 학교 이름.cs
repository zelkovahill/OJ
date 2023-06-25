using System;

class Program
{
    static void Main(string[] args)
    {
        string abbreviation = Console.ReadLine();
        string fullName = "";

        switch (abbreviation)
        {
            case "NLCS":
                fullName = "North London Collegiate School";
                break;
            case "BHA":
                fullName = "Branksome Hall Asia";
                break;
            case "KIS":
                fullName = "Korea International School";
                break;
            case "SJA":
                fullName = "St. Johnsbury Academy";
                break;
            default:
                Console.WriteLine("해당하는 학교의 약칭이 없습니다.");
                return;
        }

        Console.WriteLine(fullName);
    }
}
