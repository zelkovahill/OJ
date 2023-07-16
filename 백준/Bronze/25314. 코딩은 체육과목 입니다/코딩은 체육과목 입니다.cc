#include <iostream>

using namespace std;

int main()
{
    int a;
    cin>>a;
    
    for(int i=4;i<=a;i++)
    {
        if(i%4==0)
        {
            cout<<"long ";
        }
        i++;
    }
    cout<<"int"<<endl;
}