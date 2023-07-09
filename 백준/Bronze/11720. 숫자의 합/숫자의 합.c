#include <stdio.h>

int main()
{
    int a , sum =0;

    scanf("%d",&a);

    char num[a];

    scanf("%s",num);

    for(int i =0; i<a;i++)
    {
        sum+= num[i] - '0';
    }

    printf("%d\n",sum);

    return 0;
}