#include <stdio.h>

int main()
{
    long c;
    int a,b;
    scanf("%d",&c);
    
    for(int i = 1; i<=c ;i++)
    {
        scanf("%d %d",&a,&b);
        printf("%d\n",a+b);
    }
}