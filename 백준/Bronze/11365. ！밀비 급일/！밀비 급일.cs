while (true)
{
    var input = Console.ReadLine();
    
    if (input == "END") break;

    string reverse = new string(input.Reverse().ToArray());
    Console.WriteLine(reverse);
}