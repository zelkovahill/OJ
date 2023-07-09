#include <stdio.h>

int main()
{
    int a;
    int b[101];
    int c;

    scanf("%d",&a);

    for(int i=0;i<a;i++)
    {
        scanf("%d",&b[i]);
    }
    scanf("%d",&c);

    int d =0;
    for(int i=0;i<a;i++)
    {
        if(b[i]==c)
        {
            d++;
        }
    }
printf("%d\n",d);

return 0;
}