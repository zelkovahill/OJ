#include <iostream>
using namespace std;

int main()
{
    ios_base::sync_with_stdio(false);
    cout.tie(0);
    cin.tie(0);
int n,m,k;
cin>>n>>m>>k;

int ans = min(m,k)+min(n-m,n-k);
cout<<ans<<"\n";


}