#include <stdio.h>

int main()
{
    int n;
    scanf("%d",&n);

    for(int i=0;i<n;i++)
    {
        int a,b,c,d;
        scanf("%d %d %d %d",&a,&b,&c,&d);
        int sum =b+c+d;
if(sum >= 55 && b >= 11 && c >= 8 && d >= 12) printf("%d %d PASS\n",a,sum);
else printf("%d %d FAIL\n",a,sum);

        


    }

    return 0;
}