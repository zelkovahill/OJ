#include <iostream>
using namespace std;

int main()
{

int a;   //  입력 받을 값
int b,c;    //  출력 값

cin>> a;
// 37 , 102 
// 10 . 12

if(a%10==0)
{
    b=10;
    c=a/100;
}

else
{
    b=a%10;
    c=a/10;
}


cout<<c+b<<endl;

}