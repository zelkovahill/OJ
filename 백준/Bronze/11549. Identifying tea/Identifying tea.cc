#include <iostream>
using namespace std;

int main()
{
    ios_base::sync_with_stdio(false);
    cout.tie(0);
    cin.tie(0);

int n ,x, cnt=0;
cin>>n;
for(int i = 0;i<5;i++)
{
    cin>>x;

if(x==n) cnt++;
}
cout<<cnt<<"\n";


   


}