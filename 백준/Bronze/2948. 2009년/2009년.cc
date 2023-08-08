#include <iostream>
#include <vector>
#include <algorithm>
using namespace std;



int main()
{
    string day[7] = {"Wednesday","Thursday","Friday","Saturday","Sunday","Monday","Tuesday"};
    int m,d, arr[13] = {0,31,28,31,30,31,30,31,31,30,31,30,31};
    cin >> d >>m;
    for(int i=1;i<m;i++) d+=arr[i];
    cout << day[d%7] << '\n';

}