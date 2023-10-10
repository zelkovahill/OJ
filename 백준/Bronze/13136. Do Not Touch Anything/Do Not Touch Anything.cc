#include <iostream>
#include <cmath>

using namespace std;

int main()
{
    ios_base::sync_with_stdio(false);
    cin.tie(0);
    cout.tie(0);
    
    long long int r,c,n;
    cin>>r>>c>>n;
    
    long long int R,N;
    
    if(r%n==0) R=r/n;
    else R=r/n+1;
    
    if(c%n==0) N=c/n;
    else N=c/n+1;
    
    long long int res = R*N;
    
    
    
    cout<<res<<"\n";
    
}