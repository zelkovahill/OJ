#include <stdio.h>
#include <stdlib.h>

int main()
{
int n;
scanf("%d",&n);

if(1<=n&&n<=9999)
{
int sum=0;
int m=n;

while(n>0)
{
  int digit = n%10;
  sum+=digit;
  n/=10;
}


printf("%d\n",sum);




}


return 0;
}
