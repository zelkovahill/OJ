#include <stdio.h>

int main()
{
    int a;
    int b =1 ;
    scanf("%d",&a);
    for(int i =1; i<=a;i++)
    {
        b*=i;
    }
    printf("%d\n",b);
    
}