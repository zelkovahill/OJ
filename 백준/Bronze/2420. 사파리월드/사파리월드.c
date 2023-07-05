#include <stdio.h>

int main()
{
    long long a, b;
    long long c;
    
    scanf("%lld %lld",&a,&b);
    
    c= a>=b ? a-b :b-a;
    printf("%lld",c);
    
    return 0;
}