#include <stdio.h>

int main()
{
int a;
int max=0; //최댓값 넣을 것
int b=0; // 순서

for(int i=1;i<=9;i++)
{
    scanf("%d",&a);
    if(a>max)
    {
        max=a;
        b=i;
    }

    

}

printf("%d\n%d\n",max,b);

return 0;

}