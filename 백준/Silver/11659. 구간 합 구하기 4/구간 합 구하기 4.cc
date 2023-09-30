#include <iostream>

using namespace std;

int main()
{
    ios_base::sync_with_stdio(false);
    cin.tie(0);
    cout.tie(0);

    int n,m,a,b,x;
int N[100000]={0,};
cin>>n>>m;
int sum =0;

for(int i=1;i<=n;i++)
{
    cin>>x;
    sum+=x;
    N[i]=sum;
}

for(int i=0;i<m;i++)
{
    cin>>a>>b;
    cout<<N[b]-N[a-1]<<"\n";
}




}