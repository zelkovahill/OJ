#include <stdio.h>

int main()
{
    long long k,w,m;
    long long result=0;
    scanf("%lld %lld %lld",&k,&w,&m);

    while(k<w)
    {
        k+=m;
        result++;
    }

    printf("%lld\n",result);

    return 0;


}