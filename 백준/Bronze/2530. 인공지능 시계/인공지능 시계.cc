#include <iostream>

using namespace std;

int main()
{
int a,b,c;

cin>>a>>b>>c;

int d; // 초 

cin>>d;

cout<<(a+(b+(c+d)/60)/60)%24<<" "<<(b+(c+d)/60)%60<<" "<<(c+d)%60<<endl;



}