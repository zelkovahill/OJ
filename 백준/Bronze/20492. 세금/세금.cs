int N = int.Parse(Console.ReadLine()); // 상금

// 1. 전체 상금의 22%를 제세공과금으로 납부하는 경우
// 2 .상금의 80%를 필요 경비로 인정받고 나머지 금액중 22%만을 제세공과금으로 납부하는 경우

Console.WriteLine(N * 0.78 + " " + (( N * 0.8 )+(N*0.2*0.78)));


    