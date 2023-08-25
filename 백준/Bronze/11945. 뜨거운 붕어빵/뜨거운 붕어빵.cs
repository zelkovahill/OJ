using System;
using System.Linq;
using System.IO;
// StreamReader 텍스트 기반 파일 또는 스트림에서 데이터를 읽을 때 사용되는 클래스
// 파일이나 스트림으로부터 문자열 데이터를 읽어와서 처리할 수 있는 기능을 제공

StreamReader streamReader = new StreamReader(Console.OpenStandardInput());
StreamWriter streamwriter= new StreamWriter(Console.OpenStandardOutput());

int[] I = Array.ConvertAll(streamReader.ReadLine().Split(), int.Parse);
int n = I[0];

for(int i=0;i<n;i++)
{
    var str = streamReader.ReadLine();
    streamwriter.WriteLine(new string(str.Reverse().ToArray()));
}

streamReader.Close();
streamwriter.Close();

//  자바를 쓰는 느낌이다