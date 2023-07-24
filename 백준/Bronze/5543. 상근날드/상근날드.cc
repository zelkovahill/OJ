#include <iostream> 


using namespace std;

// a b c 세 수를 비교 하는 식 표현
// (a<=b && a<=c) ? a: (b<=a && b<=c) ? b : c

int main()
{
  int a,b,c,d,e;
  int f=0,g=0;

  cin>>a>>b>>c>>d>>e;

f=(a<=b && a<=c) ? a: (b<=a && b<=c) ? b : c;
g = d>e ? e:d;

cout<<f+g-50<<endl;


  

  



}