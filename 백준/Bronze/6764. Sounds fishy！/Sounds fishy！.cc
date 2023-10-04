#include <iostream>
using namespace std;

int main()
{
    ios_base::sync_with_stdio(false);
    cout.tie(0);
    cin.tie(0);

int n[4];
for(int i =0;i<4;i++)
{
    cin>>n[i];
}

if(n[0]>n[1]&&n[1]>n[2]&&n[2]>n[3])
cout<<"Fish Diving\n";

else if(n[0] < n[1] && n[1] < n[2] && n[2] < n[3]) 
cout << "Fish Rising\n";

else if(n[0] == n[1] && n[1] == n[2] && n[2] == n[3]) 
cout << "Fish At Constant Depth\n";

else 
 cout << "No Fish\n";
}