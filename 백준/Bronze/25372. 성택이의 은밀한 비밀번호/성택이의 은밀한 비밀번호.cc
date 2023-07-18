#include <iostream>
using namespace std;
int main()
{
    int a;
    string b;

    cin>>a;

for(int i=0; i<a;i++)
{
   cin>>b;

    if(b.length()>=6 && b.length()<=9)
    {
        cout<<"yes"<<endl;
    }

    else
    {
        cout<<"no"<<endl;
    }
}

    return 0;
}