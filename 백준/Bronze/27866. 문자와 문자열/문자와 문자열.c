#include <stdio.h>

int main()
{
    char a[1000];

    int b;

    scanf("%s\n %d",a,&b);

    printf("%c",a[b-1]);

    return 0;
}