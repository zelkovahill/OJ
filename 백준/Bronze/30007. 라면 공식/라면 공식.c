#include <stdio.h>

int main()
{
   int t;
scanf("%d",&t);
for(int i=0;i<t;i++)
{
    int A ,B , X;
    scanf("%d %d %d",&A,&B,&X);

    int sum = A*(X-1)+B;
    printf("%d\n",sum);
}
}