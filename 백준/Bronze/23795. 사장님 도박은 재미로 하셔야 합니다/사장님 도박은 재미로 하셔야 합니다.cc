#include <iostream>

using namespace std;

int main()
{
    int a,b=0;
    while(1)
    {
        cin>>a;

        if(a==-1)
        {
            break;
        }

        b+=a;


    }
    cout<<b<<endl;
}