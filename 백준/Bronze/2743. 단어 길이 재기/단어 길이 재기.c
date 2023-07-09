#include <stdio.h>

#define a 100

int main()
{
    char A[a];
    int b =0; // 갯수

    scanf("%s",A);

    while(1)
    if(A[b]!=0)
    {
    b++;
    }
    else
    {
        break;
    }
    printf("%d\n",b);

    return 0;
}