#include <stdio.h>

int main()
{
    int a,b,c,d;
    int e= 0;   
    


    scanf("%d",&a);     // 구매한 물건의 총  가격
    scanf("%d",&b);     // 개수

    for(int i=1;i<=b;i++)
    {
        scanf("%d %d",&c,&d);
    e+=c*d; //물건 가격 곱하기 개수
    }

    if(a==e)    // 같으면 예스
    {
        printf("Yes\n");
    }

    else    // 다르면 노
    {
        printf("No\n");
    }

    return 0;
}