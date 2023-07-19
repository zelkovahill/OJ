#include <iostream>

using namespace std;

int main()
{
  int A,B; // A와 B 의 각각 통장 잔고
  int C;  // 치킨 한마리의 가격
  cin>>A>>B;
  cin>>C;

if(A+B>=2*C)
cout<<A+B-(2*C)<<endl;

else
cout<<A+B<<endl;



}