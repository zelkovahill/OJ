#include <iostream>

using namespace std;

int main()
{
int a,b=0;

for(int i=0;i<5;i++)
{
  cin>>a;
  if(40>a)
  {
    b+=40;
  }
  else 
  {
    b+=a;
  }
  

}

cout<<b/5<<endl;
}