#include <iostream>
#include <algorithm>

using namespace std;

int main() {
    int A1,A2,A3;
    cin>>A1>>A2>>A3;

int r1 = A2*2+A3*4;
int r2= A1*2+A3*2;
int r3 = A1*4+A2*2;

 int result = min(r1, min(r2, r3));
cout<<result<<"\n";
    return 0;
}
