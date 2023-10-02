#include <iostream>
using namespace std;

int main()
{
    ios_base::sync_with_stdio(false);
    cout.tie(0);
    cin.tie(0);
int n,result=0;
cin>>n;

for(int i=0;i<n;i++)
{
int m;
cin>>m;
result+=m;
}

if(result==0) cout<<"Stay\n";
else if(result>0) cout<<"Right\n";
else cout<<"Left\n";

}