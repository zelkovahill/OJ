#include <stdio.h>
#include <math.h>

int main()
{
    int T;
    int a[10];
    scanf("%d",&T);

    for(int i=1;i<=T;i++)
    {

int sum=0;

for(int j=0;j<10;j++)
{
    scanf("%d",&a[j]);
    sum+=a[j];
}

double result =round((double)sum/10);

printf("#%d %0.f\n",i,result);


    }
}