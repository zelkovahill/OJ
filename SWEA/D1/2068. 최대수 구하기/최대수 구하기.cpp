#include <stdio.h>

int main()
{
    int n;
    scanf("%d",&n);

    for(int i=1;i<=n;i++)
    {
        int A[10];
        int max =0;
        for(int j=0;j<10;j++)
        {
scanf("%d",&A[j]);
if(max<A[j]) max=A[j];
        }
        printf("#%d %d\n",i,max);
    }
    return 0;
}