#include <stdio.h>
 
int main()
{
    int T;
    scanf("%d",&T);
 
int A[10];
 
for(int i=1;i<=10;i++)
{
int sum =0;
 
for(int j=0;j<10;j++)
{
    scanf("%d",&A[j]);
}
 
for(int j=0;j<10;j++)
{
    if(A[j]%2!=0) sum+=A[j];
}
printf("#%d %d\n",i,sum);
 
}
    return 0;
}