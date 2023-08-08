#include <iostream>
#include <string>

using namespace std;

const int MOD = 20000303;

int main()
{

   
   cin.tie(0);
   string a;
   cin>>a;

   int result =0;

   for(int i=0; i<a.length();i++)
   {
    int b=a[i]-'0';

    result = ((result*10)%MOD+b)%MOD;
   }

   cout<<result<<"\n";
}