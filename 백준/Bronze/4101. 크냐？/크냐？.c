#include <stdio.h>

int main()
{
    int a =0; 
    int b = 0;
    int c;
    while(1)
    {
    scanf("%d %d",&a,&b);

    c =  (a>b) ? 1 : 0 ;

if(a==0 && b==0)
{
    break;
}
if(c==1)
{
    printf("Yes\n");
}
else
{
    printf("No\n");
}

    }
    return 0;
}