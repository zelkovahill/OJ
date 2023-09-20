#include  <iostream>

using namespace std;


int main()
{
    ios::sync_with_stdio(false);
    cin.tie(nullptr);
    // c++ 문제 풀 때 많이 쓰는 것이니 외우도록

 int N;
 cin>>N;

 while(N>0)
 {
    string I;
    cin>>I;

    string ans =I.substr(0,1);

for(size_t j=1; j<I.length();j++)
{
    if(I[j]==I[j-1])
    {
        continue;
        ans+=I[j];
    }
    ans +=I[j];
}


    N--;
    cout<<ans<<endl;
 }



 return 0;
}

