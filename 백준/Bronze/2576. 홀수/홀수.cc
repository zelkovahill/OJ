#include <iostream>

using namespace std;

int main()
{
   int N , min=100 , sum=0;

for(int i=0;i<7;i++)
{
    cin>>N;
    if(N%2==1)
    {
        sum+=N;
        if(N<min)
        {
            min=N;
        }
    }

    
}
if(sum==0)
    {
        cout<<"-1"<<endl;
    }

    else
    {
        cout<<sum<<endl<<min<<endl;
    }

}