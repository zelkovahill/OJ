#include <stdio.h>

int main(void)
{
    int a ; // 시간
    int b ; // 술 마쉼?

    scanf("%d %d",&a,&b);

    if(12<=a&&a<=16&&b==0)
    {
        printf("320\n");
    }

    else
    {
        printf("280\n");
    }
    return 0;
}