#include <iostream>

using namespace std;

int main()
{
    int a,b;
    cin>>a>>b;
    
   bool sum=a*(100-b)/100>=100? 0:1;
   cout<<sum<<endl;
}