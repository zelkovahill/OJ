#include <stdio.h>


int main()
{
    int a[31]={0,};
    int b;

    for(int i=0;i<28;i++)
    {
        scanf("%d",&b);
        a[b]=1;
    }

    for(int i=1; i<=30; i++)
    {
        if(!a[i])
        {
        printf("%d\n",i);
        }
    }
return 0;
}